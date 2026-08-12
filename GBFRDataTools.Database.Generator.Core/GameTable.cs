using Syroot.BinaryData;
using Syroot.BinaryData.Memory;

namespace GBFRDataTools.Database.Generated;

public interface IGameTableRow
{
    void ReadRow(Span<byte> rowBytes);
    void WriteRow(BinaryStream bs, ref long lastStrPtrOffset);
}

public abstract class GameTable
{
    public abstract void Read(Span<byte> span);
    public abstract void Write(BinaryStream bs);
}

public abstract class GameTable<T> : GameTable where T : IGameTableRow, new()
{
    protected abstract int RowSize { get; }
    protected abstract bool HasPointerTypes { get; }

    public List<T> Rows { get; } = [];

    public override void Read(Span<byte> span)
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

    public override void Write(BinaryStream bs)
    {
        bs.WriteUInt64((ulong)Rows.Count);
        long lastStrPtrOffset = bs.Position + (RowSize * Rows.Count);

        foreach (var row in Rows)
        {
            row.WriteRow(bs, ref lastStrPtrOffset);
        }
    }
}
