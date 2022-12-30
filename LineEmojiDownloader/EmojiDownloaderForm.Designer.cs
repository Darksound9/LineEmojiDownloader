namespace LineEmojiDownloader
{
    partial class EmojiDownloaderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmojiDownloaderForm));
            this.label1 = new System.Windows.Forms.Label();
            this.URLTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.animatedCheckBox = new System.Windows.Forms.CheckBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.numOfEmojisLabel = new System.Windows.Forms.Label();
            this.numOfEmojis = new System.Windows.Forms.TextBox();
            this.directoryButton = new System.Windows.Forms.Button();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter emoji pack URL: (Example: https://store.line.me/emojishop/product/61e2818c2" +
    "01b4c6cc07b7f21/en )";
            // 
            // URLTextbox
            // 
            this.URLTextbox.Location = new System.Drawing.Point(12, 36);
            this.URLTextbox.Name = "URLTextbox";
            this.URLTextbox.Size = new System.Drawing.Size(520, 20);
            this.URLTextbox.TabIndex = 1;
            this.URLTextbox.TextChanged += new System.EventHandler(this.URLTextbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // animatedCheckBox
            // 
            this.animatedCheckBox.AutoSize = true;
            this.animatedCheckBox.Location = new System.Drawing.Point(12, 91);
            this.animatedCheckBox.Name = "animatedCheckBox";
            this.animatedCheckBox.Size = new System.Drawing.Size(137, 17);
            this.animatedCheckBox.TabIndex = 3;
            this.animatedCheckBox.Text = "Get animated versions?";
            this.animatedCheckBox.UseVisualStyleBackColor = true;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(12, 157);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(39, 13);
            this.OutputLabel.TabIndex = 4;
            this.OutputLabel.Text = "Output";
            // 
            // numOfEmojisLabel
            // 
            this.numOfEmojisLabel.AutoSize = true;
            this.numOfEmojisLabel.Location = new System.Drawing.Point(54, 68);
            this.numOfEmojisLabel.Name = "numOfEmojisLabel";
            this.numOfEmojisLabel.Size = new System.Drawing.Size(95, 13);
            this.numOfEmojisLabel.TabIndex = 5;
            this.numOfEmojisLabel.Text = "How many emojis?";
            // 
            // numOfEmojis
            // 
            this.numOfEmojis.Location = new System.Drawing.Point(12, 65);
            this.numOfEmojis.Name = "numOfEmojis";
            this.numOfEmojis.Size = new System.Drawing.Size(36, 20);
            this.numOfEmojis.TabIndex = 6;
            // 
            // directoryButton
            // 
            this.directoryButton.Location = new System.Drawing.Point(12, 115);
            this.directoryButton.Name = "directoryButton";
            this.directoryButton.Size = new System.Drawing.Size(137, 23);
            this.directoryButton.TabIndex = 7;
            this.directoryButton.Text = "Choose install directory";
            this.directoryButton.UseVisualStyleBackColor = true;
            this.directoryButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(155, 120);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(115, 13);
            this.directoryLabel.TabIndex = 8;
            this.directoryLabel.Text = "No install path chosen!";
            // 
            // EmojiDownloaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 179);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.directoryButton);
            this.Controls.Add(this.numOfEmojis);
            this.Controls.Add(this.numOfEmojisLabel);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.animatedCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.URLTextbox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmojiDownloaderForm";
            this.Text = "Line Emoji Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox URLTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox animatedCheckBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label numOfEmojisLabel;
        private System.Windows.Forms.TextBox numOfEmojis;
        private System.Windows.Forms.Button directoryButton;
        private System.Windows.Forms.Label directoryLabel;
    }
}

