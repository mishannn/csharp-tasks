using System;
using System.IO;
using System.IO.Compression;

namespace _2._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            UncompressFile(@"c:\boot.ini.gz", @"c:\boot.ini.test");
        }

        static void UncompressFile(string inFilename, string outFilename)
        {
            var sourceFile = new FileStream(inFilename, FileMode.OpenOrCreate);
            var destFile = new FileStream(outFilename, FileMode.OpenOrCreate);

            GZipStream compStream = new GZipStream(sourceFile, CompressionMode.Compress);

            int theByte = compStream.ReadByte();
            while (theByte != -1)
            {
                destFile.WriteByte((byte)theByte);
                theByte = compStream.ReadByte();
            }

        }

    }
}
