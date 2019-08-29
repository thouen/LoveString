using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveString
{
    public class EncodeHelper
    {
        public static string FormatHexString(byte[] bytes, string delimiter = " ")
        {
            string hexString = BitConverter.ToString(bytes).Replace("-", delimiter);
            return hexString;
        }

        public static string Utf8ToASCII(byte[] bytes)
        {
            byte[] dstBytes = Encoding.Convert(Encoding.UTF8, Encoding.ASCII, bytes);
            //string dstString = Encoding.ASCII.GetString(dstBytes);
            return FormatHexString(dstBytes);
        }
        public static string Utf8ToUnicode(byte[] bytes)
        {
            byte[] dstBytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, bytes);
            return FormatHexString(dstBytes);
        }
        public static string Utf8ToBigEndianUnicode(byte[] bytes)
        {
            byte[] dstBytes = Encoding.Convert(Encoding.UTF8, Encoding.BigEndianUnicode, bytes);
            return FormatHexString(dstBytes);
        }

        public static string Utf8ToUtfGBK(byte[] bytes)
        {
            Encoding encoding = Encoding.GetEncoding("GBK");
            byte[] dstBytes = Encoding.Convert(Encoding.UTF8, encoding, bytes);
            return FormatHexString(dstBytes);
        }
        public static string Utf8ToUtfGB2312(byte[] bytes)
        {
            Encoding encoding = Encoding.GetEncoding("GB2312");
            byte[] dstBytes = Encoding.Convert(Encoding.UTF8, encoding, bytes);
            return FormatHexString(dstBytes);
        }

        internal static string Utf8ToUtf32(byte[] bytes)
        {
            byte[] dstBytes = Encoding.Convert(Encoding.UTF8, Encoding.UTF32, bytes);
            return FormatHexString(dstBytes);
        }

        public static string Utf8ToUtfGB18030(byte[] bytes)
        {
            Encoding encoding = Encoding.GetEncoding("GB18030");
            byte[] dstBytes = Encoding.Convert(Encoding.UTF8, encoding, bytes);
            return FormatHexString(dstBytes);
        }
        public static string Utf8ToUtf7(byte[] bytes)
        {
            byte[] dstBytes = Encoding.Convert(Encoding.UTF8, Encoding.UTF7, bytes);
            return FormatHexString(dstBytes);
        }
    }
}
