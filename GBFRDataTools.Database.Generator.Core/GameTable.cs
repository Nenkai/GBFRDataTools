using Syroot.BinaryData;
using Syroot.BinaryData.Memory;

namespace GBFRDataTools.DB.Generated;

public interface IGameTableRow
{
    static int RowSize { get; }

    void ReadRow(Span<byte> rowBytes);
    void WriteRow(BinaryStream bs, ref long lastStrPtrOffset);
}

public abstract class GameTable<T> where T : IGameTableRow, new()
{
    public abstract int RowSize { get; }
    public abstract bool HasPointerTypes { get; }

    public List<T> Rows { get; } = [];

    public void Read(Span<byte> span)
    {
        var sr = new SpanReader(span);
        long rowCount = sr.ReadInt64();

        if (!HasPointerTypes && 8 + (RowSize * rowCount) != span.Length)
            throw new InvalidDataException($"Table did not match expected size, it's larger");

        for (int i = 0; i < rowCount; i++)
        {
            var row = new T();
            row.ReadRow(span[(8 + (i * RowSize))..]);
            Rows.Add(row);
        }
    }

    public void Write(BinaryStream bs)
    {
        bs.WriteUInt64((ulong)Rows.Count);
        long lastStrPtrOffset = bs.Position + (RowSize * Rows.Count);

        foreach (var row in Rows)
        {
            row.WriteRow(bs, ref lastStrPtrOffset);
        }
    }
}
