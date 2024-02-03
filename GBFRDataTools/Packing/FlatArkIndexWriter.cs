using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

using Syroot.BinaryData;

namespace GBFRDataTools.Packing;

public class FlatArkIndexWriter
{
    private FlatArkIndexFile _file;

    private uint _fieldsTableOffset;
    private uint _fieldOffsetTableSize;
    private uint _fieldTableSize;
    private long _lastPos;

    public FlatArkIndexWriter(FlatArkIndexFile file)
    {
        _file = file;
    }

    public void Write(Stream stream)
    {
        BinaryStream bs = new BinaryStream(stream);

        List<FlatArkIndexFileField> fields =
        [
            new FlatArkIndexFileField(_file.Codename, sizeof(uint), WriteString),
            new FlatArkIndexFileField(_file.NumArchives, sizeof(ushort), WriteUInt16),
            new FlatArkIndexFileField(_file.XXHashSeed, sizeof(ushort), WriteUInt16),
            new FlatArkIndexFileField(_file.ArchiveFilesHashTable, sizeof(uint), WriteUInt64Table),
            new FlatArkIndexFileField(_file.FileToChunkIndexerTable, sizeof(uint), WriteFileToChunkIndexerTable),
            new FlatArkIndexFileField(_file.ChunkEntries, sizeof(uint), WriteChunkEntries),
            new FlatArkIndexFileField(_file.ExternalFilesHashTable, sizeof(uint), WriteUInt64Table),
            new FlatArkIndexFileField(_file.ExternalFilesSizes, sizeof(uint), WriteUInt64Table),
            new FlatArkIndexFileField(_file.CachedChunksIndices, sizeof(uint), WriteCachedChunkIndices),
        ];

        _fieldOffsetTableSize = (uint)(sizeof(ushort) + ((1 + fields.Count) * sizeof(ushort)));
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

        for (int i = 0; i < fields.Count; i++)
            _fieldTableSize += fields[i].FieldSize;

        WriteFields(bs, fields);
    }

    private bool WriteFields(BinaryStream stream, List<FlatArkIndexFileField> fields)
    {
        long fieldOffset = stream.Position;

        _lastPos = fieldOffset + _fieldsTableOffset;

        // Written in reverse for some reason
        int j = 0;
        for (int i = fields.Count - 1; i >= 0; i--)
        {
            FlatArkIndexFileField field = fields[i];
            bool fieldHasValue = field.WriteCallback(stream, fieldOffset, field.Object);
            _lastPos = stream.Position;

            if (fieldHasValue)
            {
                stream.Position = _fieldsTableOffset - ((j + 1) * sizeof(ushort));
                stream.WriteUInt16((ushort)(fieldOffset - _fieldsTableOffset));
                stream.Position = _lastPos;
            }

            fieldOffset += field.FieldSize;
            j++;
        }

        return true;
    }

    private bool WriteString(BinaryStream stream, long fieldOffset, object obj)
    {
        stream.Position = fieldOffset;
        stream.WriteUInt32((uint)(_lastPos - fieldOffset));
        stream.Position = _lastPos;

        stream.WriteString((string)obj, StringCoding.Int32CharCount);
        return true;
    }

    private bool WriteUInt16(BinaryStream stream, long fieldOffset, object obj)
    {
        ushort value = (ushort)obj;
        if (value == 0)
            return false;

        stream.Position = fieldOffset;
        stream.WriteUInt16((ushort)obj);

        stream.Position = _lastPos;
        return true;
    }

    private bool WriteFileToChunkIndexerTable(BinaryStream stream, long fieldOffset, object obj)
    {
        stream.Position = fieldOffset;
        stream.WriteUInt32((uint)(_lastPos - fieldOffset));
        stream.Position = _lastPos;

        List<FlatArkFileToChunkIndexer> entries = (List<FlatArkFileToChunkIndexer>)obj;
        stream.WriteUInt32((uint)entries.Count);

        for (int i = 0; i < entries.Count; i++)
            entries[i].Write(stream);
        stream.Align(0x08, grow: true);

        return true;
    }

    private bool WriteChunkEntries(BinaryStream stream, long fieldOffset, object obj)
    {
        stream.Position = fieldOffset;
        stream.WriteUInt32((uint)(_lastPos - fieldOffset));
        stream.Position = _lastPos;

        List<FlatArkChunkEntry> chunkEntries = (List<FlatArkChunkEntry>)obj;
        stream.WriteUInt32((uint)chunkEntries.Count);

        for (int i = 0; i < chunkEntries.Count; i++)
            chunkEntries[i].Write(stream);
        stream.Align(0x08, grow: true);

        return true;
    }

    private bool WriteUInt64Table(BinaryStream stream, long fieldOffset, object obj)
    {
        stream.Position = fieldOffset;
        stream.WriteUInt32((uint)(_lastPos - fieldOffset));
        stream.Position = _lastPos;

        List<ulong> hashTable = (List<ulong>)obj;
        stream.WriteUInt32((uint)hashTable.Count);

        for (int i = 0; i < hashTable.Count; i++)
            stream.WriteUInt64(hashTable[i]);
        stream.Align(0x08, grow: true);

        return true;
    }

    private bool WriteExternalFileSizes(BinaryStream stream, long fieldOffset, object obj)
    {
        stream.Position = fieldOffset;
        stream.WriteUInt32((uint)(_lastPos - fieldOffset));
        stream.Position = _lastPos;

        List<ulong> externalFileSizes = (List<ulong>)obj;
        stream.WriteUInt32((uint)externalFileSizes.Count);

        for (int i = 0; i < externalFileSizes.Count; i++)
            stream.WriteUInt64(externalFileSizes[i]);
        stream.Align(0x08, grow: true);


        return true;
    }

    private bool WriteCachedChunkIndices(BinaryStream stream, long fieldOffset, object obj)
    {
        stream.Position = fieldOffset;
        stream.WriteUInt32((uint)(_lastPos - fieldOffset));
        stream.Position = _lastPos;

        List<uint> cachedIndices = (List<uint>)obj;
        stream.WriteUInt32((uint)cachedIndices.Count);

        for (int i = 0; i < cachedIndices.Count; i++)
            stream.WriteUInt32(cachedIndices[i]);
        stream.Align(0x08, grow: true);

        return true;
    }

    public record FlatArkIndexFileField(object Object, uint FieldSize, Func<BinaryStream, long, object, bool> WriteCallback);
}
