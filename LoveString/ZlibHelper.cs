using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zlib;

namespace LoveString
{
    public class ZlibHelper
    {
        public static string CompressToHexString(string srcString)
        {
            byte[] srcBytes = Encoding.UTF8.GetBytes(srcString);
            byte[] dstBytes = CompressToBytes(srcBytes);
            string dstString = BitConverter.ToString(dstBytes).Replace("-", " ");
            return dstString;
        }
        public static string DecmpressFromHexString(string srcString)
        {
            srcString = srcString.Replace(" ", "");
            byte[] srcBytes = srcString.ToBytes();
            byte[] dstBytes = DecompressFromBytes(srcBytes);
            string dstString = Encoding.UTF8.GetString(dstBytes);
            return dstString;
        }
        public static byte[] CompressToBytes(byte[] inData)
        {
            using (MemoryStream outMemoryStream = new MemoryStream())
            using (ZOutputStream outZStream = new ZOutputStream(outMemoryStream, zlibConst.Z_DEFAULT_COMPRESSION))
            using (Stream inMemoryStream = new MemoryStream(inData))
            {
                CopyStream(inMemoryStream, outZStream);
                outZStream.finish();
                byte[] outData = outMemoryStream.ToArray();
                return outData;
            }
        }

        public static byte[] DecompressFromBytes(byte[] inData)
        {
            using (MemoryStream outMemoryStream = new MemoryStream())
            using (ZOutputStream outZStream = new ZOutputStream(outMemoryStream))
            using (Stream inMemoryStream = new MemoryStream(inData))
            {
                CopyStream(inMemoryStream, outZStream);
                outZStream.finish();
                byte[] outData = outMemoryStream.ToArray();
                return outData;
            }
        }

        public static void CopyStream(System.IO.Stream input, System.IO.Stream output)
        {
            byte[] buffer = new byte[2000];
            int len;
            while ((len = input.Read(buffer, 0, 2000)) > 0)
            {
                output.Write(buffer, 0, len);
            }
            output.Flush();
        }
    }
}
