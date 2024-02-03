using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Hashing;
using System.Buffers.Binary;

namespace GBFRDataTools;

public class FlatArk
{
    public FlatArkIndex Index { get; private set; }
    public Dictionary<string, int> ExternalFilesHashTable = [];
    public Dictionary<string, int> ArchiveFilesHashTable = [];

    public void Open(string indexFile)
    {
        Index = new FlatArkIndex();
        Index.Read(indexFile);

        using var reader = new StreamReader("filelist.txt");
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();

            byte[] hashBytes = XxHash64.Hash(Encoding.ASCII.GetBytes(line), 0);
            ulong hash = BinaryPrimitives.ReadUInt64BigEndian(hashBytes);

            int fileIdx = Index.ExternalFilesHashTable.BinarySearch(hash);
            if (fileIdx >= 0)
            {
                ExternalFilesHashTable.TryAdd(line, fileIdx);
            }
            else
            {
                fileIdx = Index.ArchiveFilesHashTable.BinarySearch(hash);
                if (fileIdx >= 0)
                    ArchiveFilesHashTable.TryAdd(line, fileIdx);
            }
        }

        Console.WriteLine($"External Files Hashes: {ExternalFilesHashTable.Count}/{Index.ExternalFilesHashTable.Count}");
        Console.WriteLine($"Archive Files Hashes: {ArchiveFilesHashTable.Count}/{Index.ArchiveFilesHashTable.Count}");
    }

    public void Extract(string fileName)
    {
        if (ExternalFilesHashTable.TryGetValue(fileName, out _))
            throw new ArgumentException("This file is external, it is already extracted.");

        if (!ArchiveFilesHashTable.TryGetValue(fileName, out int index))
            throw new FileNotFoundException("File was not found in archive.");

        var indexer = Index.FileIndices[index];

    }
}
