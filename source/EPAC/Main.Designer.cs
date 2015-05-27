namespace EPAC
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageParse = new System.Windows.Forms.TabPage();
            this.groupBoxSource = new System.Windows.Forms.GroupBox();
            this.radioButtonWiki = new System.Windows.Forms.RadioButton();
            this.radioButtonImdb = new System.Windows.Forms.RadioButton();
            this.buttonParse = new System.Windows.Forms.Button();
            this.textBoxWiki = new System.Windows.Forms.TextBox();
            this.textBoxImdb = new System.Windows.Forms.TextBox();
            this.groupBoxPreview = new System.Windows.Forms.GroupBox();
            this.richTextBoxPreview = new System.Windows.Forms.RichTextBox();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.textBoxRound = new System.Windows.Forms.TextBox();
            this.textBoxInc = new System.Windows.Forms.TextBox();
            this.labelRound = new System.Windows.Forms.Label();
            this.labelInc = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelPattern = new System.Windows.Forms.Label();
            this.textBoxPattern = new System.Windows.Forms.TextBox();
            this.tabPageCreate = new System.Windows.Forms.TabPage();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.groupBoxTarget = new System.Windows.Forms.GroupBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.tabPageCopy = new System.Windows.Forms.TabPage();
            this.groupBoxCopyLog = new System.Windows.Forms.GroupBox();
            this.richTextBoxCopyLog = new System.Windows.Forms.RichTextBox();
            this.groupBoxCopyTarget = new System.Windows.Forms.GroupBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.textBoxCopyPath = new System.Windows.Forms.TextBox();
            this.labelCopyPath = new System.Windows.Forms.Label();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageParse.SuspendLayout();
            this.groupBoxSource.SuspendLayout();
            this.groupBoxPreview.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.tabPageCreate.SuspendLayout();
            this.groupBoxLog.SuspendLayout();
            this.groupBoxTarget.SuspendLayout();
            this.tabPageCopy.SuspendLayout();
            this.groupBoxCopyLog.SuspendLayout();
            this.groupBoxCopyTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMain.Controls.Add(this.tabPageHome);
            this.tabControlMain.Controls.Add(this.tabPageParse);
            this.tabControlMain.Controls.Add(this.tabPageCreate);
            this.tabControlMain.Controls.Add(this.tabPageCopy);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.ImageList = this.imageListIcons;
            this.tabControlMain.ItemSize = new System.Drawing.Size(187, 60);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(784, 462);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageHome
            // 
            this.tabPageHome.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageHome.Controls.Add(this.label6);
            this.tabPageHome.Controls.Add(this.label5);
            this.tabPageHome.Controls.Add(this.label4);
            this.tabPageHome.Controls.Add(this.label3);
            this.tabPageHome.Controls.Add(this.pictureBox1);
            this.tabPageHome.ImageIndex = 0;
            this.tabPageHome.Location = new System.Drawing.Point(4, 64);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(776, 394);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Yata!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "BSD License";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "(C) 2015 Mojtaba Ahmadi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "v0.1.2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 73);
            this.label3.TabIndex = 1;
            this.label3.Text = "EPAC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EPAC.Properties.Resources.ryuko;
            this.pictureBox1.Location = new System.Drawing.Point(390, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageParse
            // 
            this.tabPageParse.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageParse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageParse.Controls.Add(this.groupBoxSource);
            this.tabPageParse.Controls.Add(this.groupBoxPreview);
            this.tabPageParse.Controls.Add(this.groupBoxOptions);
            this.tabPageParse.ImageIndex = 1;
            this.tabPageParse.Location = new System.Drawing.Point(4, 64);
            this.tabPageParse.Name = "tabPageParse";
            this.tabPageParse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParse.Size = new System.Drawing.Size(776, 394);
            this.tabPageParse.TabIndex = 1;
            this.tabPageParse.Text = "Parse";
            // 
            // groupBoxSource
            // 
            this.groupBoxSource.Controls.Add(this.radioButtonWiki);
            this.groupBoxSource.Controls.Add(this.radioButtonImdb);
            this.groupBoxSource.Controls.Add(this.buttonParse);
            this.groupBoxSource.Controls.Add(this.textBoxWiki);
            this.groupBoxSource.Controls.Add(this.textBoxImdb);
            this.groupBoxSource.Location = new System.Drawing.Point(7, 10);
            this.groupBoxSource.Name = "groupBoxSource";
            this.groupBoxSource.Size = new System.Drawing.Size(760, 95);
            this.groupBoxSource.TabIndex = 6;
            this.groupBoxSource.TabStop = false;
            this.groupBoxSource.Text = "Source:";
            // 
            // radioButtonWiki
            // 
            this.radioButtonWiki.AutoSize = true;
            this.radioButtonWiki.Location = new System.Drawing.Point(17, 61);
            this.radioButtonWiki.Name = "radioButtonWiki";
            this.radioButtonWiki.Size = new System.Drawing.Size(49, 17);
            this.radioButtonWiki.TabIndex = 7;
            this.radioButtonWiki.Text = "Wiki:";
            this.radioButtonWiki.UseVisualStyleBackColor = true;
            // 
            // radioButtonImdb
            // 
            this.radioButtonImdb.AutoSize = true;
            this.radioButtonImdb.Checked = true;
            this.radioButtonImdb.Location = new System.Drawing.Point(17, 30);
            this.radioButtonImdb.Name = "radioButtonImdb";
            this.radioButtonImdb.Size = new System.Drawing.Size(55, 17);
            this.radioButtonImdb.TabIndex = 6;
            this.radioButtonImdb.TabStop = true;
            this.radioButtonImdb.Text = "IMDB:";
            this.radioButtonImdb.UseVisualStyleBackColor = true;
            // 
            // buttonParse
            // 
            this.buttonParse.Location = new System.Drawing.Point(676, 31);
            this.buttonParse.Name = "buttonParse";
            this.buttonParse.Size = new System.Drawing.Size(75, 41);
            this.buttonParse.TabIndex = 2;
            this.buttonParse.Text = "Parse";
            this.buttonParse.UseVisualStyleBackColor = true;
            this.buttonParse.Click += new System.EventHandler(this.buttonParse_Click);
            // 
            // textBoxWiki
            // 
            this.textBoxWiki.Location = new System.Drawing.Point(78, 59);
            this.textBoxWiki.Name = "textBoxWiki";
            this.textBoxWiki.Size = new System.Drawing.Size(588, 20);
            this.textBoxWiki.TabIndex = 3;
            this.textBoxWiki.Enter += new System.EventHandler(this.textBoxWiki_Enter);
            // 
            // textBoxImdb
            // 
            this.textBoxImdb.Location = new System.Drawing.Point(78, 28);
            this.textBoxImdb.Name = "textBoxImdb";
            this.textBoxImdb.Size = new System.Drawing.Size(588, 20);
            this.textBoxImdb.TabIndex = 3;
            this.textBoxImdb.Enter += new System.EventHandler(this.textBoxImdb_Enter);
            // 
            // groupBoxPreview
            // 
            this.groupBoxPreview.Controls.Add(this.richTextBoxPreview);
            this.groupBoxPreview.Location = new System.Drawing.Point(285, 111);
            this.groupBoxPreview.Name = "groupBoxPreview";
            this.groupBoxPreview.Size = new System.Drawing.Size(482, 274);
            this.groupBoxPreview.TabIndex = 1;
            this.groupBoxPreview.TabStop = false;
            this.groupBoxPreview.Text = "Preview:";
            // 
            // richTextBoxPreview
            // 
            this.richTextBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxPreview.Location = new System.Drawing.Point(21, 29);
            this.richTextBoxPreview.Name = "richTextBoxPreview";
            this.richTextBoxPreview.ReadOnly = true;
            this.richTextBoxPreview.Size = new System.Drawing.Size(443, 228);
            this.richTextBoxPreview.TabIndex = 0;
            this.richTextBoxPreview.Text = "";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.textBoxRound);
            this.groupBoxOptions.Controls.Add(this.textBoxInc);
            this.groupBoxOptions.Controls.Add(this.labelRound);
            this.groupBoxOptions.Controls.Add(this.labelInc);
            this.groupBoxOptions.Controls.Add(this.buttonRefresh);
            this.groupBoxOptions.Controls.Add(this.labelPattern);
            this.groupBoxOptions.Controls.Add(this.textBoxPattern);
            this.groupBoxOptions.Location = new System.Drawing.Point(7, 111);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(272, 274);
            this.groupBoxOptions.TabIndex = 0;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options:";
            // 
            // textBoxRound
            // 
            this.textBoxRound.Enabled = false;
            this.textBoxRound.Location = new System.Drawing.Point(57, 107);
            this.textBoxRound.Name = "textBoxRound";
            this.textBoxRound.Size = new System.Drawing.Size(194, 20);
            this.textBoxRound.TabIndex = 6;
            this.textBoxRound.Text = "2";
            // 
            // textBoxInc
            // 
            this.textBoxInc.Enabled = false;
            this.textBoxInc.Location = new System.Drawing.Point(57, 70);
            this.textBoxInc.Name = "textBoxInc";
            this.textBoxInc.Size = new System.Drawing.Size(194, 20);
            this.textBoxInc.TabIndex = 5;
            this.textBoxInc.Text = "1";
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.Location = new System.Drawing.Point(7, 111);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(42, 13);
            this.labelRound.TabIndex = 4;
            this.labelRound.Text = "Round:";
            // 
            // labelInc
            // 
            this.labelInc.AutoSize = true;
            this.labelInc.Location = new System.Drawing.Point(7, 74);
            this.labelInc.Name = "labelInc";
            this.labelInc.Size = new System.Drawing.Size(51, 13);
            this.labelInc.TabIndex = 3;
            this.labelInc.Text = "Increase:";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(114, 216);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 41);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelPattern
            // 
            this.labelPattern.AutoSize = true;
            this.labelPattern.Location = new System.Drawing.Point(7, 37);
            this.labelPattern.Name = "labelPattern";
            this.labelPattern.Size = new System.Drawing.Size(44, 13);
            this.labelPattern.TabIndex = 1;
            this.labelPattern.Text = "Pattern:";
            // 
            // textBoxPattern
            // 
            this.textBoxPattern.Location = new System.Drawing.Point(57, 33);
            this.textBoxPattern.Name = "textBoxPattern";
            this.textBoxPattern.Size = new System.Drawing.Size(194, 20);
            this.textBoxPattern.TabIndex = 0;
            this.textBoxPattern.Text = "Episode [#] - [name]";
            // 
            // tabPageCreate
            // 
            this.tabPageCreate.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageCreate.Controls.Add(this.groupBoxLog);
            this.tabPageCreate.Controls.Add(this.groupBoxTarget);
            this.tabPageCreate.ImageIndex = 2;
            this.tabPageCreate.Location = new System.Drawing.Point(4, 64);
            this.tabPageCreate.Name = "tabPageCreate";
            this.tabPageCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreate.Size = new System.Drawing.Size(776, 394);
            this.tabPageCreate.TabIndex = 2;
            this.tabPageCreate.Text = "Create";
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Controls.Add(this.richTextBoxLog);
            this.groupBoxLog.Location = new System.Drawing.Point(9, 82);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Size = new System.Drawing.Size(758, 303);
            this.groupBoxLog.TabIndex = 8;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "Log:";
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxLog.Location = new System.Drawing.Point(16, 30);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(728, 254);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            // 
            // groupBoxTarget
            // 
            this.groupBoxTarget.Controls.Add(this.buttonCreate);
            this.groupBoxTarget.Controls.Add(this.textBoxPath);
            this.groupBoxTarget.Controls.Add(this.labelPath);
            this.groupBoxTarget.Location = new System.Drawing.Point(7, 10);
            this.groupBoxTarget.Name = "groupBoxTarget";
            this.groupBoxTarget.Size = new System.Drawing.Size(760, 66);
            this.groupBoxTarget.TabIndex = 7;
            this.groupBoxTarget.TabStop = false;
            this.groupBoxTarget.Text = "Target:";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(676, 16);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 41);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(52, 27);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(615, 20);
            this.textBoxPath.TabIndex = 3;
            this.textBoxPath.Text = "C:\\";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(11, 30);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(35, 13);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "Path: ";
            // 
            // tabPageCopy
            // 
            this.tabPageCopy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageCopy.Controls.Add(this.groupBoxCopyLog);
            this.tabPageCopy.Controls.Add(this.groupBoxCopyTarget);
            this.tabPageCopy.ImageIndex = 3;
            this.tabPageCopy.Location = new System.Drawing.Point(4, 64);
            this.tabPageCopy.Name = "tabPageCopy";
            this.tabPageCopy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCopy.Size = new System.Drawing.Size(776, 394);
            this.tabPageCopy.TabIndex = 3;
            this.tabPageCopy.Text = "Copy";
            this.tabPageCopy.UseVisualStyleBackColor = true;
            // 
            // groupBoxCopyLog
            // 
            this.groupBoxCopyLog.Controls.Add(this.richTextBoxCopyLog);
            this.groupBoxCopyLog.Location = new System.Drawing.Point(9, 82);
            this.groupBoxCopyLog.Name = "groupBoxCopyLog";
            this.groupBoxCopyLog.Size = new System.Drawing.Size(758, 303);
            this.groupBoxCopyLog.TabIndex = 10;
            this.groupBoxCopyLog.TabStop = false;
            this.groupBoxCopyLog.Text = "Log:";
            // 
            // richTextBoxCopyLog
            // 
            this.richTextBoxCopyLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxCopyLog.Location = new System.Drawing.Point(16, 30);
            this.richTextBoxCopyLog.Name = "richTextBoxCopyLog";
            this.richTextBoxCopyLog.ReadOnly = true;
            this.richTextBoxCopyLog.Size = new System.Drawing.Size(728, 254);
            this.richTextBoxCopyLog.TabIndex = 0;
            this.richTextBoxCopyLog.Text = "";
            // 
            // groupBoxCopyTarget
            // 
            this.groupBoxCopyTarget.Controls.Add(this.buttonCopy);
            this.groupBoxCopyTarget.Controls.Add(this.textBoxCopyPath);
            this.groupBoxCopyTarget.Controls.Add(this.labelCopyPath);
            this.groupBoxCopyTarget.Location = new System.Drawing.Point(7, 10);
            this.groupBoxCopyTarget.Name = "groupBoxCopyTarget";
            this.groupBoxCopyTarget.Size = new System.Drawing.Size(760, 66);
            this.groupBoxCopyTarget.TabIndex = 9;
            this.groupBoxCopyTarget.TabStop = false;
            this.groupBoxCopyTarget.Text = "Target:";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(676, 16);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 41);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // textBoxCopyPath
            // 
            this.textBoxCopyPath.Location = new System.Drawing.Point(52, 27);
            this.textBoxCopyPath.Name = "textBoxCopyPath";
            this.textBoxCopyPath.Size = new System.Drawing.Size(615, 20);
            this.textBoxCopyPath.TabIndex = 3;
            this.textBoxCopyPath.Text = "C:\\";
            // 
            // labelCopyPath
            // 
            this.labelCopyPath.AutoSize = true;
            this.labelCopyPath.Location = new System.Drawing.Point(11, 30);
            this.labelCopyPath.Name = "labelCopyPath";
            this.labelCopyPath.Size = new System.Drawing.Size(35, 13);
            this.labelCopyPath.TabIndex = 4;
            this.labelCopyPath.Text = "Path: ";
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "ninja.png");
            this.imageListIcons.Images.SetKeyName(1, "search.png");
            this.imageListIcons.Images.SetKeyName(2, "plus.png");
            this.imageListIcons.Images.SetKeyName(3, "copy.png");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPAC";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageParse.ResumeLayout(false);
            this.groupBoxSource.ResumeLayout(false);
            this.groupBoxSource.PerformLayout();
            this.groupBoxPreview.ResumeLayout(false);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.tabPageCreate.ResumeLayout(false);
            this.groupBoxLog.ResumeLayout(false);
            this.groupBoxTarget.ResumeLayout(false);
            this.groupBoxTarget.PerformLayout();
            this.tabPageCopy.ResumeLayout(false);
            this.groupBoxCopyLog.ResumeLayout(false);
            this.groupBoxCopyTarget.ResumeLayout(false);
            this.groupBoxCopyTarget.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageParse;
        private System.Windows.Forms.TabPage tabPageCreate;
        private System.Windows.Forms.GroupBox groupBoxPreview;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Button buttonParse;
        private System.Windows.Forms.TextBox textBoxImdb;
        private System.Windows.Forms.RichTextBox richTextBoxPreview;
        private System.Windows.Forms.GroupBox groupBoxSource;
        private System.Windows.Forms.TextBox textBoxPattern;
        private System.Windows.Forms.Label labelPattern;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.GroupBox groupBoxTarget;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.TabPage tabPageCopy;
        private System.Windows.Forms.GroupBox groupBoxCopyLog;
        private System.Windows.Forms.RichTextBox richTextBoxCopyLog;
        private System.Windows.Forms.GroupBox groupBoxCopyTarget;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.TextBox textBoxCopyPath;
        private System.Windows.Forms.Label labelCopyPath;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.TextBox textBoxRound;
        private System.Windows.Forms.TextBox textBoxInc;
        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.Label labelInc;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonWiki;
        private System.Windows.Forms.RadioButton radioButtonImdb;
        private System.Windows.Forms.TextBox textBoxWiki;
    }
}