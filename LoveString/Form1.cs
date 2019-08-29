using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoveString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Tb_Original_Text_TextChanged(object sender, EventArgs e)
        {
            string originalText = this.tb_Original_Text.Text.Trim();
            byte[] originalTextUtf8Bytes = Encoding.UTF8.GetBytes(originalText);
            //编码
            this.tb_Ascii.Text = EncodeHelper.Utf8ToASCII(originalTextUtf8Bytes);
            this.tb_BZip2.Text = Convert.ToBase64String(originalTextUtf8Bytes);
            this.tb_Bytes.Text = originalTextUtf8Bytes.BytesArrayToHexArray();
            this.tb_Gb18030.Text = EncodeHelper.Utf8ToUtfGB18030(originalTextUtf8Bytes);
            this.tb_Gb2312.Text = EncodeHelper.Utf8ToUtfGB2312(originalTextUtf8Bytes);
            this.tb_Gbk.Text = EncodeHelper.Utf8ToUtfGBK(originalTextUtf8Bytes);
            this.tb_Hex.Text = BitConverter.ToString(originalTextUtf8Bytes).Replace("-", "");
            this.tb_UniBigEnd.Text = EncodeHelper.Utf8ToBigEndianUnicode(originalTextUtf8Bytes);
            this.tb_Unicode.Text = EncodeHelper.Utf8ToUnicode(originalTextUtf8Bytes);
            this.tb_Utf8.Text = EncodeHelper.FormatHexString(originalTextUtf8Bytes);
            this.tb_Utf7.Text = EncodeHelper.Utf8ToUtf7(originalTextUtf8Bytes);
            this.tb_Utf32.Text = EncodeHelper.Utf8ToUtf32(originalTextUtf8Bytes);
            //加密
            this.tb_Md5.Text = originalText.Md5();
            this.tb_Sha1.Text = originalText.Sha1(); ;
            this.tb_Base64.Text = Convert.ToBase64String(originalTextUtf8Bytes);
            this.tb_Crc32.Text = originalText.CRC32Str().ToString();

            //压缩
            CompressionHelper.CompressionProvider = CompressionType.Zip;
            byte[] zipBytes = CompressionHelper.Compress(originalTextUtf8Bytes);
            this.tb_Zip.Text = BitConverter.ToString(zipBytes).Replace("-", " ");
            //var str = CompressionHelper.DeCompress(this.tb_Zip.Text.Replace(" ", "").ToBytes());
            //var ss = Encoding.UTF8.GetString(str);

            CompressionHelper.CompressionProvider = CompressionType.GZip;
            byte[] gzipBytes = CompressionHelper.Compress(originalTextUtf8Bytes);
            this.tb_Gzip.Text = BitConverter.ToString(gzipBytes).Replace("-", " ");
            //str = CompressionHelper.DeCompress(this.tb_Gzip.Text.Replace(" ", "").ToBytes());
            //var ss=Encoding.UTF8.GetString(str);

            CompressionHelper.CompressionProvider = CompressionType.BZip2;
            byte[] bzip2Bytes = CompressionHelper.Compress(originalTextUtf8Bytes);
            this.tb_BZip2.Text = BitConverter.ToString(bzip2Bytes).Replace("-", " ");
            //str = CompressionHelper.DeCompress(this.tb_BZip2.Text.Replace(" ", "").ToBytes());
            //ss = Encoding.UTF8.GetString(str);

            this.tb_Zlib.Text = ZlibHelper.CompressToHexString(originalText);
            string sss = ZlibHelper.DecmpressFromHexString(this.tb_Zlib.Text.Replace(" ", ""));
        }
    }
}
