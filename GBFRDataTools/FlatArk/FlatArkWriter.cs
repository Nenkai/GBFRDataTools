using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syroot.BinaryData;

namespace GBFRDataTools.FlatArk;

/// <summary>
/// Flat Ark Field.
/// </summary>
/// <param name="Object">Object to write.</param>
/// <param name="FieldSize">Field size. For offsets, normally just 4.</param>
/// <param name="WriteCallback">Object writer. Result is used for whether to write the field offset or not.</param>
public record FlatArkField(object Object, uint FieldSize, Func<BinaryStream, long, object, bool> WriteCallback);

public class FlatArkWriter
{
    private List<FlatArkField> _fields;

    private uint _fieldsTableOffset;
    private uint _fieldOffsetTableSize;
    private uint _fieldTableSize;
    private long _lastPos;

    public FlatArkWriter(List<FlatArkField> fields)
    {
        _fields = fields;
    }

    public void Write(Stream stream)
    {
        BinaryStream bs = new BinaryStream(stream);

        _fieldOffsetTableSize = (uint)(sizeof(ushort) + (1 + _fields.Count) * sizeof(ushort));
        _fieldsTableOffset = sizeof(uint) + 0x06 + _fieldOffsetTableSize;

        stream.Position = 0;
        stream.WriteUInt32(_fieldsTableOffset);

        stream.Position = _fieldsTableOffset;
        bs.WriteUInt32(_fieldOffsetTableSize);

        long fieldStartOffset = bs.Position;
        stream.Position = 0x0A;
        bs.WriteUInt16((ushort)_fieldOffsetTableSize);
        bs.WriteUInt16((ushort)fieldStartOffset);

        bs.Position = fieldStartOffset;

        for (int i = 0; i < _fields.Count; i++)
            _fieldTableSize += _fields[i].FieldSize;

        WriteFields(bs, _fields);
        bs.Align(0x08, grow: true);
    }

    private bool WriteFields(BinaryStream stream, List<FlatArkField> fields)
    {
        long fieldOffset = stream.Position;

        // Skip to the end, as some fields are just offsets to data
        stream.Position = fieldOffset + _fieldsTableOffset;

        // Written in reverse for some reason
        int j = 0;
        for (int i = fields.Count - 1; i >= 0; i--)
        {
            FlatArkField field = fields[i];
            bool fieldHasValue = field.WriteCallback(stream, fieldOffset, field.Object);
            _lastPos = stream.Position;

            if (fieldHasValue)
            {
                stream.Position = _fieldsTableOffset - (j + 1) * sizeof(ushort);
                stream.WriteUInt16((ushort)(fieldOffset - _fieldsTableOffset));
                stream.Position = _lastPos;
            }

            fieldOffset += field.FieldSize;
            j++;
        }

        return true;
    }

    public static bool WriteString(BinaryStream stream, long fieldOffset, object obj)
    {
        long lastPos = stream.Position;
        stream.Position = fieldOffset;
        stream.WriteUInt32((uint)(lastPos - fieldOffset));
        stream.Position = lastPos;

        stream.WriteString((string)obj, StringCoding.Int32CharCount);
        return true;
    }

    public static bool WriteUInt16(BinaryStream stream, long fieldOffset, object obj)
    {
        ushort value = (ushort)obj;
        if (value == 0)
            return false;

        long lastPos = stream.Position;

        stream.Position = fieldOffset;
        stream.WriteUInt16((ushort)obj);

        stream.Position = lastPos;
        return true;
    }
}
