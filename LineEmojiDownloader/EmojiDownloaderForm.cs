using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace LineEmojiDownloader
{
    public partial class EmojiDownloaderForm : Form
    {
        public EmojiDownloaderForm()
        {
            InitializeComponent();
            this.directoryButton.Click += new System.EventHandler(this.BrowseFolderButton_Click);
        }

        private void EmojiDownloaderForm_Load(object sender, EventArgs e)
        {
        }

        private void URLTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.OutputLabel.Text = "Output";

            string emojiID;

            if (!(this.URLTextbox.Text.Length > 0) || !(this.URLTextbox.Text.Contains("/")))
            {
                this.OutputLabel.Text = "URL could not be parsed, HexID for emojipack could not be found.";
                return;
            }

            var split = this.URLTextbox.Text.Split('/');
            emojiID = split[split.Length - 2];

            if (!IsHex(emojiID))
            {
                this.OutputLabel.Text = "Found emojiID: " + emojiID + "could not be parsed as a hex value.";
                return;
            }

            if (!IsDigitsOnly(this.numOfEmojis.Text))
            {
                this.OutputLabel.Text = "Whole numbers only for number of emojis to download.";
                return;
            }

            if (!directoryLabel.Text.Contains(":"))
            {
                this.OutputLabel.Text = "Please choose an install directory.";
                return;
            }


            int numOfEmojis = int.Parse(this.numOfEmojis.Text);
            string newURL = "https://stickershop.line-scdn.net/sticonshop/v1/sticon/" + emojiID + "/iPhone/";
            string installPath = directoryLabel.Text + "\\" + emojiID + "\\";
            string fileType = this.animatedCheckBox.Checked ? "_animation.png" : ".png";
            string format = "000.##";

            if (!Directory.Exists(installPath))
            {
                Directory.CreateDirectory(installPath);
            }

            for (int i = 1; i <= numOfEmojis; i++)
            {
                string fileName = (i.ToString(format) + fileType);
                save_file_from_url((installPath + fileName), (newURL + fileName));
            }

            this.OutputLabel.Text = "All files downloaded successfully.";
        }

        public void save_file_from_url(string file_name, string url)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            byte[] content;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();

            using (BinaryReader br = new BinaryReader(stream))
            {
                content = br.ReadBytes(500000);
                br.Close();
            }
            response.Close();

            FileStream fs = new FileStream(file_name, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            try
            {
                bw.Write(content);
            }
            finally
            {
                fs.Close();
                bw.Close();
            }
        }

        private void BrowseFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.directoryLabel.Text = folderDlg.SelectedPath;
            }
        }

        private bool IsHex(IEnumerable<char> chars)
        {
            bool isHex;
            foreach (var c in chars)
            {
                isHex = ((c >= '0' && c <= '9') ||
                         (c >= 'a' && c <= 'f') ||
                         (c >= 'A' && c <= 'F'));

                if (!isHex)
                    return false;
            }
            return true;
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
