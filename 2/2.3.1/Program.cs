using System;
using System.IO;
using System.IO.Compression;

namespace _2._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            CompressFile(@"c:\boot.ini", @"с:\boot.ini.gz");
        }

        static void CompressFile(string inFilename, string outFilename)
        {
            var sourceFile = new FileStream(inFilename,FileMode.OpenOrCreate);
            var destFile = new FileStream(outFilename, FileMode.OpenOrCreate);

            GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);

            int theByte = sourceFile.ReadByte();
            while (theByte != -1)
            {
                compStream.WriteByte((byte)theByte);
                theByte = sourceFile.ReadByte();
            }

            sourceFile.Close();
            destFile.Close();
        }

    }
}
