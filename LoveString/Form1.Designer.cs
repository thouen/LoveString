namespace LoveString
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Original_Text = new System.Windows.Forms.TextBox();
            this.lbl_OriginalText = new System.Windows.Forms.Label();
            this.tb_Unicode = new System.Windows.Forms.TextBox();
            this.tb_Ascii = new System.Windows.Forms.TextBox();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lbl_BZip2 = new System.Windows.Forms.Label();
            this.tb_BZip2 = new System.Windows.Forms.TextBox();
            this.lbl_Zlib = new System.Windows.Forms.Label();
            this.tb_Zlib = new System.Windows.Forms.TextBox();
            this.lbl_Gzip = new System.Windows.Forms.Label();
            this.tb_Gzip = new System.Windows.Forms.TextBox();
            this.lbl_Zip = new System.Windows.Forms.Label();
            this.tb_Zip = new System.Windows.Forms.TextBox();
            this.lbl_UniBigEnd = new System.Windows.Forms.Label();
            this.tb_UniBigEnd = new System.Windows.Forms.TextBox();
            this.lbl_bytes = new System.Windows.Forms.Label();
            this.tb_Bytes = new System.Windows.Forms.TextBox();
            this.lbl_Sha1 = new System.Windows.Forms.Label();
            this.tb_Sha1 = new System.Windows.Forms.TextBox();
            this.lbl_Md5 = new System.Windows.Forms.Label();
            this.tb_Md5 = new System.Windows.Forms.TextBox();
            this.lbl_Utf32 = new System.Windows.Forms.Label();
            this.tb_Utf32 = new System.Windows.Forms.TextBox();
            this.lbl_UTF7 = new System.Windows.Forms.Label();
            this.lbl_Gb18030 = new System.Windows.Forms.Label();
            this.lbl_Hex = new System.Windows.Forms.Label();
            this.tb_Utf7 = new System.Windows.Forms.TextBox();
            this.tb_Gb18030 = new System.Windows.Forms.TextBox();
            this.tb_Hex = new System.Windows.Forms.TextBox();
            this.lbl_GBK = new System.Windows.Forms.Label();
            this.lbl_Gb2312 = new System.Windows.Forms.Label();
            this.tb_Gbk = new System.Windows.Forms.TextBox();
            this.tb_Gb2312 = new System.Windows.Forms.TextBox();
            this.lbl_Ascii = new System.Windows.Forms.Label();
            this.lbl_Unicode = new System.Windows.Forms.Label();
            this.lbl_Base64 = new System.Windows.Forms.Label();
            this.tb_Base64 = new System.Windows.Forms.TextBox();
            this.lbl_Crc32 = new System.Windows.Forms.Label();
            this.tb_Crc32 = new System.Windows.Forms.TextBox();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Original_Text
            // 
            this.tb_Original_Text.Location = new System.Drawing.Point(114, 15);
            this.tb_Original_Text.Name = "tb_Original_Text";
            this.tb_Original_Text.Size = new System.Drawing.Size(293, 21);
            this.tb_Original_Text.TabIndex = 0;
            this.tb_Original_Text.TextChanged += new System.EventHandler(this.Tb_Original_Text_TextChanged);
            // 
            // lbl_OriginalText
            // 
            this.lbl_OriginalText.AutoSize = true;
            this.lbl_OriginalText.Location = new System.Drawing.Point(38, 19);
            this.lbl_OriginalText.Name = "lbl_OriginalText";
            this.lbl_OriginalText.Size = new System.Drawing.Size(35, 12);
            this.lbl_OriginalText.TabIndex = 1;
            this.lbl_OriginalText.Text = "文本:";
            // 
            // tb_Unicode
            // 
            this.tb_Unicode.Location = new System.Drawing.Point(114, 48);
            this.tb_Unicode.Name = "tb_Unicode";
            this.tb_Unicode.Size = new System.Drawing.Size(293, 21);
            this.tb_Unicode.TabIndex = 2;
            // 
            // tb_Ascii
            // 
            this.tb_Ascii.Location = new System.Drawing.Point(114, 114);
            this.tb_Ascii.Name = "tb_Ascii";
            this.tb_Ascii.Size = new System.Drawing.Size(293, 21);
            this.tb_Ascii.TabIndex = 3;
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.lbl_Crc32);
            this.pnl_Main.Controls.Add(this.tb_Crc32);
            this.pnl_Main.Controls.Add(this.lbl_Base64);
            this.pnl_Main.Controls.Add(this.tb_Base64);
            this.pnl_Main.Controls.Add(this.lbl_BZip2);
            this.pnl_Main.Controls.Add(this.tb_BZip2);
            this.pnl_Main.Controls.Add(this.lbl_Zlib);
            this.pnl_Main.Controls.Add(this.tb_Zlib);
            this.pnl_Main.Controls.Add(this.lbl_Gzip);
            this.pnl_Main.Controls.Add(this.tb_Gzip);
            this.pnl_Main.Controls.Add(this.lbl_Zip);
            this.pnl_Main.Controls.Add(this.tb_Zip);
            this.pnl_Main.Controls.Add(this.lbl_UniBigEnd);
            this.pnl_Main.Controls.Add(this.tb_UniBigEnd);
            this.pnl_Main.Controls.Add(this.lbl_bytes);
            this.pnl_Main.Controls.Add(this.tb_Bytes);
            this.pnl_Main.Controls.Add(this.lbl_Sha1);
            this.pnl_Main.Controls.Add(this.tb_Sha1);
            this.pnl_Main.Controls.Add(this.lbl_Md5);
            this.pnl_Main.Controls.Add(this.tb_Md5);
            this.pnl_Main.Controls.Add(this.lbl_Utf32);
            this.pnl_Main.Controls.Add(this.tb_Utf32);
            this.pnl_Main.Controls.Add(this.lbl_UTF7);
            this.pnl_Main.Controls.Add(this.lbl_Gb18030);
            this.pnl_Main.Controls.Add(this.lbl_Hex);
            this.pnl_Main.Controls.Add(this.tb_Utf7);
            this.pnl_Main.Controls.Add(this.tb_Gb18030);
            this.pnl_Main.Controls.Add(this.tb_Hex);
            this.pnl_Main.Controls.Add(this.lbl_GBK);
            this.pnl_Main.Controls.Add(this.lbl_Gb2312);
            this.pnl_Main.Controls.Add(this.tb_Gbk);
            this.pnl_Main.Controls.Add(this.tb_Gb2312);
            this.pnl_Main.Controls.Add(this.lbl_Ascii);
            this.pnl_Main.Controls.Add(this.lbl_Unicode);
            this.pnl_Main.Controls.Add(this.lbl_OriginalText);
            this.pnl_Main.Controls.Add(this.tb_Ascii);
            this.pnl_Main.Controls.Add(this.tb_Unicode);
            this.pnl_Main.Controls.Add(this.tb_Original_Text);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Main.Location = new System.Drawing.Point(0, 21);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(445, 644);
            this.pnl_Main.TabIndex = 4;
            // 
            // lbl_BZip2
            // 
            this.lbl_BZip2.AutoSize = true;
            this.lbl_BZip2.Location = new System.Drawing.Point(38, 547);
            this.lbl_BZip2.Name = "lbl_BZip2";
            this.lbl_BZip2.Size = new System.Drawing.Size(41, 12);
            this.lbl_BZip2.TabIndex = 37;
            this.lbl_BZip2.Text = "BZIP2:";
            // 
            // tb_BZip2
            // 
            this.tb_BZip2.Location = new System.Drawing.Point(114, 543);
            this.tb_BZip2.Name = "tb_BZip2";
            this.tb_BZip2.Size = new System.Drawing.Size(293, 21);
            this.tb_BZip2.TabIndex = 36;
            // 
            // lbl_Zlib
            // 
            this.lbl_Zlib.AutoSize = true;
            this.lbl_Zlib.Location = new System.Drawing.Point(38, 514);
            this.lbl_Zlib.Name = "lbl_Zlib";
            this.lbl_Zlib.Size = new System.Drawing.Size(35, 12);
            this.lbl_Zlib.TabIndex = 35;
            this.lbl_Zlib.Text = "ZLIB:";
            // 
            // tb_Zlib
            // 
            this.tb_Zlib.Location = new System.Drawing.Point(114, 510);
            this.tb_Zlib.Name = "tb_Zlib";
            this.tb_Zlib.Size = new System.Drawing.Size(293, 21);
            this.tb_Zlib.TabIndex = 34;
            // 
            // lbl_Gzip
            // 
            this.lbl_Gzip.AutoSize = true;
            this.lbl_Gzip.Location = new System.Drawing.Point(38, 481);
            this.lbl_Gzip.Name = "lbl_Gzip";
            this.lbl_Gzip.Size = new System.Drawing.Size(35, 12);
            this.lbl_Gzip.TabIndex = 33;
            this.lbl_Gzip.Text = "GZIP:";
            // 
            // tb_Gzip
            // 
            this.tb_Gzip.Location = new System.Drawing.Point(114, 477);
            this.tb_Gzip.Name = "tb_Gzip";
            this.tb_Gzip.Size = new System.Drawing.Size(293, 21);
            this.tb_Gzip.TabIndex = 32;
            // 
            // lbl_Zip
            // 
            this.lbl_Zip.AutoSize = true;
            this.lbl_Zip.Location = new System.Drawing.Point(38, 448);
            this.lbl_Zip.Name = "lbl_Zip";
            this.lbl_Zip.Size = new System.Drawing.Size(29, 12);
            this.lbl_Zip.TabIndex = 31;
            this.lbl_Zip.Text = "ZIP:";
            // 
            // tb_Zip
            // 
            this.tb_Zip.Location = new System.Drawing.Point(114, 444);
            this.tb_Zip.Name = "tb_Zip";
            this.tb_Zip.Size = new System.Drawing.Size(293, 21);
            this.tb_Zip.TabIndex = 30;
            // 
            // lbl_UniBigEnd
            // 
            this.lbl_UniBigEnd.AutoSize = true;
            this.lbl_UniBigEnd.Location = new System.Drawing.Point(38, 85);
            this.lbl_UniBigEnd.Name = "lbl_UniBigEnd";
            this.lbl_UniBigEnd.Size = new System.Drawing.Size(65, 12);
            this.lbl_UniBigEnd.TabIndex = 29;
            this.lbl_UniBigEnd.Text = "UniBigEnd:";
            // 
            // tb_UniBigEnd
            // 
            this.tb_UniBigEnd.Location = new System.Drawing.Point(114, 81);
            this.tb_UniBigEnd.Name = "tb_UniBigEnd";
            this.tb_UniBigEnd.Size = new System.Drawing.Size(293, 21);
            this.tb_UniBigEnd.TabIndex = 28;
            // 
            // lbl_bytes
            // 
            this.lbl_bytes.AutoSize = true;
            this.lbl_bytes.Location = new System.Drawing.Point(38, 349);
            this.lbl_bytes.Name = "lbl_bytes";
            this.lbl_bytes.Size = new System.Drawing.Size(41, 12);
            this.lbl_bytes.TabIndex = 27;
            this.lbl_bytes.Text = "Bytes:";
            // 
            // tb_Bytes
            // 
            this.tb_Bytes.Location = new System.Drawing.Point(114, 345);
            this.tb_Bytes.Name = "tb_Bytes";
            this.tb_Bytes.Size = new System.Drawing.Size(293, 21);
            this.tb_Bytes.TabIndex = 26;
            // 
            // lbl_Sha1
            // 
            this.lbl_Sha1.AutoSize = true;
            this.lbl_Sha1.Location = new System.Drawing.Point(38, 415);
            this.lbl_Sha1.Name = "lbl_Sha1";
            this.lbl_Sha1.Size = new System.Drawing.Size(35, 12);
            this.lbl_Sha1.TabIndex = 25;
            this.lbl_Sha1.Text = "SHA1:";
            // 
            // tb_Sha1
            // 
            this.tb_Sha1.Location = new System.Drawing.Point(114, 411);
            this.tb_Sha1.Name = "tb_Sha1";
            this.tb_Sha1.Size = new System.Drawing.Size(293, 21);
            this.tb_Sha1.TabIndex = 24;
            // 
            // lbl_Md5
            // 
            this.lbl_Md5.AutoSize = true;
            this.lbl_Md5.Location = new System.Drawing.Point(38, 382);
            this.lbl_Md5.Name = "lbl_Md5";
            this.lbl_Md5.Size = new System.Drawing.Size(29, 12);
            this.lbl_Md5.TabIndex = 23;
            this.lbl_Md5.Text = "MD5:";
            // 
            // tb_Md5
            // 
            this.tb_Md5.Location = new System.Drawing.Point(114, 378);
            this.tb_Md5.Name = "tb_Md5";
            this.tb_Md5.Size = new System.Drawing.Size(293, 21);
            this.tb_Md5.TabIndex = 22;
            // 
            // lbl_Utf32
            // 
            this.lbl_Utf32.AutoSize = true;
            this.lbl_Utf32.Location = new System.Drawing.Point(38, 151);
            this.lbl_Utf32.Name = "lbl_Utf32";
            this.lbl_Utf32.Size = new System.Drawing.Size(47, 12);
            this.lbl_Utf32.TabIndex = 21;
            this.lbl_Utf32.Text = "UTF-32:";
            // 
            // tb_Utf32
            // 
            this.tb_Utf32.Location = new System.Drawing.Point(114, 147);
            this.tb_Utf32.Name = "tb_Utf32";
            this.tb_Utf32.Size = new System.Drawing.Size(293, 21);
            this.tb_Utf32.TabIndex = 20;
            // 
            // lbl_UTF7
            // 
            this.lbl_UTF7.AutoSize = true;
            this.lbl_UTF7.Location = new System.Drawing.Point(38, 184);
            this.lbl_UTF7.Name = "lbl_UTF7";
            this.lbl_UTF7.Size = new System.Drawing.Size(41, 12);
            this.lbl_UTF7.TabIndex = 17;
            this.lbl_UTF7.Text = "UTF-7:";
            // 
            // lbl_Gb18030
            // 
            this.lbl_Gb18030.AutoSize = true;
            this.lbl_Gb18030.Location = new System.Drawing.Point(38, 250);
            this.lbl_Gb18030.Name = "lbl_Gb18030";
            this.lbl_Gb18030.Size = new System.Drawing.Size(53, 12);
            this.lbl_Gb18030.TabIndex = 16;
            this.lbl_Gb18030.Text = "GB18030:";
            // 
            // lbl_Hex
            // 
            this.lbl_Hex.AutoSize = true;
            this.lbl_Hex.Location = new System.Drawing.Point(38, 316);
            this.lbl_Hex.Name = "lbl_Hex";
            this.lbl_Hex.Size = new System.Drawing.Size(29, 12);
            this.lbl_Hex.TabIndex = 13;
            this.lbl_Hex.Text = "HEX:";
            // 
            // tb_Utf7
            // 
            this.tb_Utf7.Location = new System.Drawing.Point(114, 180);
            this.tb_Utf7.Name = "tb_Utf7";
            this.tb_Utf7.Size = new System.Drawing.Size(293, 21);
            this.tb_Utf7.TabIndex = 15;
            // 
            // tb_Gb18030
            // 
            this.tb_Gb18030.Location = new System.Drawing.Point(114, 246);
            this.tb_Gb18030.Name = "tb_Gb18030";
            this.tb_Gb18030.Size = new System.Drawing.Size(293, 21);
            this.tb_Gb18030.TabIndex = 14;
            // 
            // tb_Hex
            // 
            this.tb_Hex.Location = new System.Drawing.Point(114, 312);
            this.tb_Hex.Name = "tb_Hex";
            this.tb_Hex.Size = new System.Drawing.Size(293, 21);
            this.tb_Hex.TabIndex = 12;
            // 
            // lbl_GBK
            // 
            this.lbl_GBK.AutoSize = true;
            this.lbl_GBK.Location = new System.Drawing.Point(38, 283);
            this.lbl_GBK.Name = "lbl_GBK";
            this.lbl_GBK.Size = new System.Drawing.Size(29, 12);
            this.lbl_GBK.TabIndex = 10;
            this.lbl_GBK.Text = "GBK:";
            // 
            // lbl_Gb2312
            // 
            this.lbl_Gb2312.AutoSize = true;
            this.lbl_Gb2312.Location = new System.Drawing.Point(38, 217);
            this.lbl_Gb2312.Name = "lbl_Gb2312";
            this.lbl_Gb2312.Size = new System.Drawing.Size(47, 12);
            this.lbl_Gb2312.TabIndex = 7;
            this.lbl_Gb2312.Text = "GB2312:";
            // 
            // tb_Gbk
            // 
            this.tb_Gbk.Location = new System.Drawing.Point(114, 279);
            this.tb_Gbk.Name = "tb_Gbk";
            this.tb_Gbk.Size = new System.Drawing.Size(293, 21);
            this.tb_Gbk.TabIndex = 8;
            // 
            // tb_Gb2312
            // 
            this.tb_Gb2312.Location = new System.Drawing.Point(114, 213);
            this.tb_Gb2312.Name = "tb_Gb2312";
            this.tb_Gb2312.Size = new System.Drawing.Size(293, 21);
            this.tb_Gb2312.TabIndex = 6;
            // 
            // lbl_Ascii
            // 
            this.lbl_Ascii.AutoSize = true;
            this.lbl_Ascii.Location = new System.Drawing.Point(38, 118);
            this.lbl_Ascii.Name = "lbl_Ascii";
            this.lbl_Ascii.Size = new System.Drawing.Size(41, 12);
            this.lbl_Ascii.TabIndex = 5;
            this.lbl_Ascii.Text = "ASCII:";
            // 
            // lbl_Unicode
            // 
            this.lbl_Unicode.AutoSize = true;
            this.lbl_Unicode.Location = new System.Drawing.Point(38, 52);
            this.lbl_Unicode.Name = "lbl_Unicode";
            this.lbl_Unicode.Size = new System.Drawing.Size(53, 12);
            this.lbl_Unicode.TabIndex = 4;
            this.lbl_Unicode.Text = "UNICODE:";
            // 
            // lbl_Base64
            // 
            this.lbl_Base64.AutoSize = true;
            this.lbl_Base64.Location = new System.Drawing.Point(38, 580);
            this.lbl_Base64.Name = "lbl_Base64";
            this.lbl_Base64.Size = new System.Drawing.Size(47, 12);
            this.lbl_Base64.TabIndex = 39;
            this.lbl_Base64.Text = "BASE64:";
            // 
            // tb_Base64
            // 
            this.tb_Base64.Location = new System.Drawing.Point(114, 576);
            this.tb_Base64.Name = "tb_Base64";
            this.tb_Base64.Size = new System.Drawing.Size(293, 21);
            this.tb_Base64.TabIndex = 38;
            // 
            // lbl_Crc32
            // 
            this.lbl_Crc32.AutoSize = true;
            this.lbl_Crc32.Location = new System.Drawing.Point(38, 613);
            this.lbl_Crc32.Name = "lbl_Crc32";
            this.lbl_Crc32.Size = new System.Drawing.Size(41, 12);
            this.lbl_Crc32.TabIndex = 41;
            this.lbl_Crc32.Text = "CRC32:";
            // 
            // tb_Crc32
            // 
            this.tb_Crc32.Location = new System.Drawing.Point(114, 609);
            this.tb_Crc32.Name = "tb_Crc32";
            this.tb_Crc32.Size = new System.Drawing.Size(293, 21);
            this.tb_Crc32.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 665);
            this.Controls.Add(this.pnl_Main);
            this.Name = "Form1";
            this.Text = "LoveString";
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Original_Text;
        private System.Windows.Forms.Label lbl_OriginalText;
        private System.Windows.Forms.TextBox tb_Unicode;
        private System.Windows.Forms.TextBox tb_Ascii;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Label lbl_Gb18030;
        private System.Windows.Forms.Label lbl_Hex;
        private System.Windows.Forms.TextBox tb_Gb18030;
        private System.Windows.Forms.TextBox tb_Hex;
        private System.Windows.Forms.Label lbl_GBK;
        private System.Windows.Forms.Label lbl_Gb2312;
        private System.Windows.Forms.TextBox tb_Gbk;
        private System.Windows.Forms.TextBox tb_Gb2312;
        private System.Windows.Forms.Label lbl_Ascii;
        private System.Windows.Forms.Label lbl_Unicode;
        private System.Windows.Forms.Label lbl_Utf32;
        private System.Windows.Forms.TextBox tb_Utf32;
        private System.Windows.Forms.Label lbl_UTF7;
        private System.Windows.Forms.TextBox tb_Utf7;
        private System.Windows.Forms.Label lbl_bytes;
        private System.Windows.Forms.TextBox tb_Bytes;
        private System.Windows.Forms.Label lbl_Sha1;
        private System.Windows.Forms.TextBox tb_Sha1;
        private System.Windows.Forms.Label lbl_Md5;
        private System.Windows.Forms.TextBox tb_Md5;
        private System.Windows.Forms.Label lbl_UniBigEnd;
        private System.Windows.Forms.TextBox tb_UniBigEnd;
        private System.Windows.Forms.Label lbl_BZip2;
        private System.Windows.Forms.TextBox tb_BZip2;
        private System.Windows.Forms.Label lbl_Zlib;
        private System.Windows.Forms.TextBox tb_Zlib;
        private System.Windows.Forms.Label lbl_Gzip;
        private System.Windows.Forms.TextBox tb_Gzip;
        private System.Windows.Forms.Label lbl_Zip;
        private System.Windows.Forms.TextBox tb_Zip;
        private System.Windows.Forms.Label lbl_Base64;
        private System.Windows.Forms.TextBox tb_Base64;
        private System.Windows.Forms.Label lbl_Crc32;
        private System.Windows.Forms.TextBox tb_Crc32;
    }
}

