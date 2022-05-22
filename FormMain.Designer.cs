
namespace _5Letters
{
	partial class FormMain
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
			this.splitContainerMain = new System.Windows.Forms.SplitContainer();
			this.groupBoxWord = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxLetter1 = new System.Windows.Forms.TextBox();
			this.comboBoxLetter1 = new System.Windows.Forms.ComboBox();
			this.textBoxLetter2 = new System.Windows.Forms.TextBox();
			this.comboBoxLetter2 = new System.Windows.Forms.ComboBox();
			this.textBoxLetter3 = new System.Windows.Forms.TextBox();
			this.comboBoxLetter3 = new System.Windows.Forms.ComboBox();
			this.textBoxLetter4 = new System.Windows.Forms.TextBox();
			this.comboBoxLetter4 = new System.Windows.Forms.ComboBox();
			this.textBoxLetter5 = new System.Windows.Forms.TextBox();
			this.comboBoxLetter5 = new System.Windows.Forms.ComboBox();
			this.splitContainerButtonAndWords = new System.Windows.Forms.SplitContainer();
			this.buttonFind = new System.Windows.Forms.Button();
			this.groupBoxWordsToTest = new System.Windows.Forms.GroupBox();
			this.textBoxWords = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.richTextBoxVariants = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
			this.splitContainerMain.Panel1.SuspendLayout();
			this.splitContainerMain.Panel2.SuspendLayout();
			this.splitContainerMain.SuspendLayout();
			this.groupBoxWord.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerButtonAndWords)).BeginInit();
			this.splitContainerButtonAndWords.Panel1.SuspendLayout();
			this.splitContainerButtonAndWords.Panel2.SuspendLayout();
			this.splitContainerButtonAndWords.SuspendLayout();
			this.groupBoxWordsToTest.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainerMain
			// 
			this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
			this.splitContainerMain.Name = "splitContainerMain";
			this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerMain.Panel1
			// 
			this.splitContainerMain.Panel1.Controls.Add(this.groupBoxWord);
			this.splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(10);
			// 
			// splitContainerMain.Panel2
			// 
			this.splitContainerMain.Panel2.Controls.Add(this.splitContainerButtonAndWords);
			this.splitContainerMain.Size = new System.Drawing.Size(666, 412);
			this.splitContainerMain.SplitterDistance = 132;
			this.splitContainerMain.TabIndex = 1;
			// 
			// groupBoxWord
			// 
			this.groupBoxWord.Controls.Add(this.tableLayoutPanel1);
			this.groupBoxWord.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxWord.Location = new System.Drawing.Point(10, 10);
			this.groupBoxWord.Name = "groupBoxWord";
			this.groupBoxWord.Padding = new System.Windows.Forms.Padding(4);
			this.groupBoxWord.Size = new System.Drawing.Size(646, 112);
			this.groupBoxWord.TabIndex = 1;
			this.groupBoxWord.TabStop = false;
			this.groupBoxWord.Text = "Введите вариант слова";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.textBoxLetter1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxLetter1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxLetter2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxLetter2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxLetter3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxLetter3, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxLetter4, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxLetter4, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxLetter5, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxLetter5, 4, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 17);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 91);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// textBoxLetter1
			// 
			this.textBoxLetter1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.textBoxLetter1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBoxLetter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLetter1.Location = new System.Drawing.Point(51, 8);
			this.textBoxLetter1.MaxLength = 1;
			this.textBoxLetter1.Name = "textBoxLetter1";
			this.textBoxLetter1.Size = new System.Drawing.Size(33, 38);
			this.textBoxLetter1.TabIndex = 1;
			this.textBoxLetter1.Text = ".";
			this.textBoxLetter1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxLetter1.WordWrap = false;
			this.textBoxLetter1.Click += new System.EventHandler(this.textBoxOnClick);
			this.textBoxLetter1.TextChanged += new System.EventHandler(this.textBoxLetter_TextChanged);
			this.textBoxLetter1.Enter += new System.EventHandler(this.textBoxOnClick);
			// 
			// comboBoxLetter1
			// 
			this.comboBoxLetter1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.comboBoxLetter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLetter1.FormattingEnabled = true;
			this.comboBoxLetter1.Items.AddRange(new object[] {
            "Нету",
            "На месте",
            "Не на месте"});
			this.comboBoxLetter1.Location = new System.Drawing.Point(17, 62);
			this.comboBoxLetter1.Name = "comboBoxLetter1";
			this.comboBoxLetter1.Size = new System.Drawing.Size(101, 21);
			this.comboBoxLetter1.TabIndex = 2;
			this.comboBoxLetter1.SelectedIndexChanged += new System.EventHandler(this.comboBoxLetter_SelectedIndexChanged);
			// 
			// textBoxLetter2
			// 
			this.textBoxLetter2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.textBoxLetter2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBoxLetter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLetter2.Location = new System.Drawing.Point(176, 8);
			this.textBoxLetter2.MaxLength = 1;
			this.textBoxLetter2.Name = "textBoxLetter2";
			this.textBoxLetter2.Size = new System.Drawing.Size(33, 38);
			this.textBoxLetter2.TabIndex = 1;
			this.textBoxLetter2.Text = ".";
			this.textBoxLetter2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxLetter2.WordWrap = false;
			this.textBoxLetter2.Click += new System.EventHandler(this.textBoxOnClick);
			this.textBoxLetter2.TextChanged += new System.EventHandler(this.textBoxLetter_TextChanged);
			this.textBoxLetter2.Enter += new System.EventHandler(this.textBoxOnClick);
			// 
			// comboBoxLetter2
			// 
			this.comboBoxLetter2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.comboBoxLetter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLetter2.FormattingEnabled = true;
			this.comboBoxLetter2.Items.AddRange(new object[] {
            "Нету",
            "На месте",
            "Не на месте"});
			this.comboBoxLetter2.Location = new System.Drawing.Point(140, 62);
			this.comboBoxLetter2.Name = "comboBoxLetter2";
			this.comboBoxLetter2.Size = new System.Drawing.Size(105, 21);
			this.comboBoxLetter2.TabIndex = 2;
			this.comboBoxLetter2.SelectedIndexChanged += new System.EventHandler(this.comboBoxLetter_SelectedIndexChanged);
			// 
			// textBoxLetter3
			// 
			this.textBoxLetter3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.textBoxLetter3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBoxLetter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLetter3.Location = new System.Drawing.Point(301, 8);
			this.textBoxLetter3.MaxLength = 1;
			this.textBoxLetter3.Name = "textBoxLetter3";
			this.textBoxLetter3.Size = new System.Drawing.Size(33, 38);
			this.textBoxLetter3.TabIndex = 1;
			this.textBoxLetter3.Text = ".";
			this.textBoxLetter3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxLetter3.WordWrap = false;
			this.textBoxLetter3.Click += new System.EventHandler(this.textBoxOnClick);
			this.textBoxLetter3.TextChanged += new System.EventHandler(this.textBoxLetter_TextChanged);
			this.textBoxLetter3.Enter += new System.EventHandler(this.textBoxOnClick);
			// 
			// comboBoxLetter3
			// 
			this.comboBoxLetter3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.comboBoxLetter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLetter3.FormattingEnabled = true;
			this.comboBoxLetter3.Items.AddRange(new object[] {
            "Нету",
            "На месте",
            "Не на месте"});
			this.comboBoxLetter3.Location = new System.Drawing.Point(265, 62);
			this.comboBoxLetter3.Name = "comboBoxLetter3";
			this.comboBoxLetter3.Size = new System.Drawing.Size(105, 21);
			this.comboBoxLetter3.TabIndex = 2;
			this.comboBoxLetter3.SelectedIndexChanged += new System.EventHandler(this.comboBoxLetter_SelectedIndexChanged);
			// 
			// textBoxLetter4
			// 
			this.textBoxLetter4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.textBoxLetter4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBoxLetter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLetter4.Location = new System.Drawing.Point(426, 8);
			this.textBoxLetter4.MaxLength = 1;
			this.textBoxLetter4.Name = "textBoxLetter4";
			this.textBoxLetter4.Size = new System.Drawing.Size(33, 38);
			this.textBoxLetter4.TabIndex = 1;
			this.textBoxLetter4.Text = ".";
			this.textBoxLetter4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxLetter4.WordWrap = false;
			this.textBoxLetter4.Click += new System.EventHandler(this.textBoxOnClick);
			this.textBoxLetter4.TextChanged += new System.EventHandler(this.textBoxLetter_TextChanged);
			this.textBoxLetter4.Enter += new System.EventHandler(this.textBoxOnClick);
			// 
			// comboBoxLetter4
			// 
			this.comboBoxLetter4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.comboBoxLetter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLetter4.FormattingEnabled = true;
			this.comboBoxLetter4.Items.AddRange(new object[] {
            "Нету",
            "На месте",
            "Не на месте"});
			this.comboBoxLetter4.Location = new System.Drawing.Point(390, 62);
			this.comboBoxLetter4.Name = "comboBoxLetter4";
			this.comboBoxLetter4.Size = new System.Drawing.Size(105, 21);
			this.comboBoxLetter4.TabIndex = 2;
			this.comboBoxLetter4.SelectedIndexChanged += new System.EventHandler(this.comboBoxLetter_SelectedIndexChanged);
			// 
			// textBoxLetter5
			// 
			this.textBoxLetter5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.textBoxLetter5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBoxLetter5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLetter5.Location = new System.Drawing.Point(552, 8);
			this.textBoxLetter5.MaxLength = 1;
			this.textBoxLetter5.Name = "textBoxLetter5";
			this.textBoxLetter5.Size = new System.Drawing.Size(33, 38);
			this.textBoxLetter5.TabIndex = 1;
			this.textBoxLetter5.Text = ".";
			this.textBoxLetter5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxLetter5.WordWrap = false;
			this.textBoxLetter5.Click += new System.EventHandler(this.textBoxOnClick);
			this.textBoxLetter5.TextChanged += new System.EventHandler(this.textBoxLetter_TextChanged);
			this.textBoxLetter5.Enter += new System.EventHandler(this.textBoxOnClick);
			// 
			// comboBoxLetter5
			// 
			this.comboBoxLetter5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.comboBoxLetter5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLetter5.FormattingEnabled = true;
			this.comboBoxLetter5.Items.AddRange(new object[] {
            "Нету",
            "На месте",
            "Не на месте"});
			this.comboBoxLetter5.Location = new System.Drawing.Point(516, 62);
			this.comboBoxLetter5.Name = "comboBoxLetter5";
			this.comboBoxLetter5.Size = new System.Drawing.Size(105, 21);
			this.comboBoxLetter5.TabIndex = 2;
			this.comboBoxLetter5.SelectedIndexChanged += new System.EventHandler(this.comboBoxLetter_SelectedIndexChanged);
			// 
			// splitContainerButtonAndWords
			// 
			this.splitContainerButtonAndWords.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerButtonAndWords.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainerButtonAndWords.Location = new System.Drawing.Point(0, 0);
			this.splitContainerButtonAndWords.Name = "splitContainerButtonAndWords";
			this.splitContainerButtonAndWords.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerButtonAndWords.Panel1
			// 
			this.splitContainerButtonAndWords.Panel1.Controls.Add(this.buttonFind);
			this.splitContainerButtonAndWords.Panel1MinSize = 32;
			// 
			// splitContainerButtonAndWords.Panel2
			// 
			this.splitContainerButtonAndWords.Panel2.Controls.Add(this.groupBoxWordsToTest);
			this.splitContainerButtonAndWords.Panel2.Padding = new System.Windows.Forms.Padding(10);
			this.splitContainerButtonAndWords.Size = new System.Drawing.Size(666, 276);
			this.splitContainerButtonAndWords.SplitterDistance = 32;
			this.splitContainerButtonAndWords.TabIndex = 1;
			// 
			// buttonFind
			// 
			this.buttonFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.buttonFind.Location = new System.Drawing.Point(237, 0);
			this.buttonFind.Margin = new System.Windows.Forms.Padding(0);
			this.buttonFind.Name = "buttonFind";
			this.buttonFind.Size = new System.Drawing.Size(196, 28);
			this.buttonFind.TabIndex = 0;
			this.buttonFind.Text = "Отсеять";
			this.buttonFind.UseVisualStyleBackColor = true;
			this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
			// 
			// groupBoxWordsToTest
			// 
			this.groupBoxWordsToTest.Controls.Add(this.textBoxWords);
			this.groupBoxWordsToTest.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxWordsToTest.Location = new System.Drawing.Point(10, 10);
			this.groupBoxWordsToTest.Name = "groupBoxWordsToTest";
			this.groupBoxWordsToTest.Padding = new System.Windows.Forms.Padding(5);
			this.groupBoxWordsToTest.Size = new System.Drawing.Size(646, 220);
			this.groupBoxWordsToTest.TabIndex = 0;
			this.groupBoxWordsToTest.TabStop = false;
			this.groupBoxWordsToTest.Text = "Найденные варианты";
			// 
			// textBoxWords
			// 
			this.textBoxWords.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxWords.Location = new System.Drawing.Point(5, 18);
			this.textBoxWords.MaxLength = 32767000;
			this.textBoxWords.Multiline = true;
			this.textBoxWords.Name = "textBoxWords";
			this.textBoxWords.ReadOnly = true;
			this.textBoxWords.Size = new System.Drawing.Size(636, 197);
			this.textBoxWords.TabIndex = 0;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 412);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(840, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// richTextBoxVariants
			// 
			this.richTextBoxVariants.Dock = System.Windows.Forms.DockStyle.Right;
			this.richTextBoxVariants.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBoxVariants.Location = new System.Drawing.Point(666, 0);
			this.richTextBoxVariants.Name = "richTextBoxVariants";
			this.richTextBoxVariants.Size = new System.Drawing.Size(174, 412);
			this.richTextBoxVariants.TabIndex = 3;
			this.richTextBoxVariants.Text = "Отбракованные варианты:\n";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(840, 434);
			this.Controls.Add(this.splitContainerMain);
			this.Controls.Add(this.richTextBoxVariants);
			this.Controls.Add(this.statusStrip1);
			this.Name = "FormMain";
			this.Text = "5Букв";
			this.splitContainerMain.Panel1.ResumeLayout(false);
			this.splitContainerMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
			this.splitContainerMain.ResumeLayout(false);
			this.groupBoxWord.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.splitContainerButtonAndWords.Panel1.ResumeLayout(false);
			this.splitContainerButtonAndWords.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerButtonAndWords)).EndInit();
			this.splitContainerButtonAndWords.ResumeLayout(false);
			this.groupBoxWordsToTest.ResumeLayout(false);
			this.groupBoxWordsToTest.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainerMain;
		private System.Windows.Forms.GroupBox groupBoxWord;
		private System.Windows.Forms.Button buttonFind;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox textBoxLetter1;
		private System.Windows.Forms.TextBox textBoxLetter2;
		private System.Windows.Forms.TextBox textBoxLetter3;
		private System.Windows.Forms.TextBox textBoxLetter4;
		private System.Windows.Forms.TextBox textBoxLetter5;
		private System.Windows.Forms.SplitContainer splitContainerButtonAndWords;
		private System.Windows.Forms.ComboBox comboBoxLetter1;
		private System.Windows.Forms.ComboBox comboBoxLetter2;
		private System.Windows.Forms.ComboBox comboBoxLetter3;
		private System.Windows.Forms.ComboBox comboBoxLetter4;
		private System.Windows.Forms.ComboBox comboBoxLetter5;
		private System.Windows.Forms.RichTextBox richTextBoxVariants;
		private System.Windows.Forms.GroupBox groupBoxWordsToTest;
		private System.Windows.Forms.TextBox textBoxWords;
	}
}

