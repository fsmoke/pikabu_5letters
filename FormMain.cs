using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _5Letters
{
	public partial class FormMain : Form
	{
		private void AppendTextRB(string text, Color color)
		{
			richTextBoxVariants.SelectionStart = richTextBoxVariants.TextLength;
			richTextBoxVariants.SelectionLength = 0;

			richTextBoxVariants.SelectionBackColor = color;
			richTextBoxVariants.AppendText(text);
			richTextBoxVariants.SelectionColor = richTextBoxVariants.ForeColor;
		}

		private List<string> _allWords;
		private List<char> _absense = new List<char>();
		private List<char> [] _wrongPos = new List<char>[5];
		
		public FormMain(List<string> words)
		{
			InitializeComponent();
			_allWords = words;

			comboBoxLetter1.Tag = textBoxLetter1;
			comboBoxLetter2.Tag = textBoxLetter2;
			comboBoxLetter3.Tag = textBoxLetter3;
			comboBoxLetter4.Tag = textBoxLetter4;
			comboBoxLetter5.Tag = textBoxLetter5;

			comboBoxLetter1.SelectedIndex = comboBoxLetter2.SelectedIndex =
				comboBoxLetter3.SelectedIndex = comboBoxLetter4.SelectedIndex = comboBoxLetter5.SelectedIndex = 0;

			richTextBoxVariants.AppendText("\n");
		}

		private void buttonFind_Click(object sender, EventArgs e)
		{
			var cbs = new List<ComboBox>{ comboBoxLetter1 , comboBoxLetter2 , 
				comboBoxLetter3, comboBoxLetter4, comboBoxLetter5 };

			var variant = new List<KeyValuePair<char, Color>>();
			for (var i = 0; i < cbs.Count; ++i) 
			{
				var tb = (cbs[i].Tag as TextBox);
				var letter = tb.Text[0];
				if (!tb.ReadOnly)
				{
					if (_wrongPos[i] == null)
						_wrongPos[i] = new List<char>();
					if (cbs[i].SelectedIndex == 2)
						_wrongPos[i].Add(char.ToLower(letter));
					else if (cbs[i].SelectedIndex == 0)
						_absense.Add(char.ToLower(letter));
					else
					{
						tb.ReadOnly = true;
						tb.Enabled = false;
						cbs[i].Enabled = false;
					}
				}
				variant.Add(new KeyValuePair<char, Color>(letter, tb.BackColor));
			}

			//main process here
			var words = new List<string>();
			foreach (var word in _allWords)
			{
				if (word.Length < 5)
					continue;
				bool found = true;
				for (int i = 0; i < 5; ++i)
				{
					var c = char.ToLower(word[i]);

					bool letterOnThePlace = false;
					//first step
					{
						var tb = (cbs[i].Tag as TextBox);
						var letter = char.ToLower(tb.Text[0]);
						if (tb.ReadOnly)
						{
							if (c != letter)
							{
								found = false;
								break;
							}
							else
								letterOnThePlace = true;
						}
					}

					if (!letterOnThePlace)
					{
						//second step
						Func<bool> testWrongPos = () =>
						{
							foreach (var letter in _wrongPos[i])
							{
								if (letter == c)
									return true;
							}
							return false;
						};

						if (testWrongPos())
						{
							found = false;
							break;
						}

						//third step
						Func<bool> testAbsense = () =>
						{
							foreach (var letter in _absense)
							{
								if (letter == c)
									return true;
							}
							return false;
						};

						if (testAbsense())
						{
							found = false;
							break;
						}
					}
				}
				if (!found)
					continue;

				words.Add(word);
			}
			//-----------------
			string comma = "";
			textBoxWords.Clear();
			foreach (var w in words)
			{
				textBoxWords.AppendText(comma + w);
				comma = ", ";
			}

			foreach (var p in variant)
				AppendTextRB(p.Key.ToString(), p.Value);
			richTextBoxVariants.AppendText("\n");
		}

		private void comboBoxLetter_SelectedIndexChanged(object sender, EventArgs e)
		{
			var cb = sender as ComboBox;
			var tb = cb.Tag as TextBox;
			switch(cb.SelectedIndex)
			{
				case 0:
					tb.BackColor = Color.Gray;
					break;
				case 1:
					tb.BackColor = Color.Yellow;
					break;
				case 2:
					tb.BackColor = Color.White;
					break;
			}
		}

		private void textBoxOnClick(object sender, EventArgs eventArgs)
		{
			var textBox = (TextBox)sender;
			textBox.SelectAll();
			textBox.Focus();
		}

		private void textBoxLetter_TextChanged(object sender, EventArgs e)
		{
			this.SelectNextControl((Control)sender, true, true, true, true);
		}
	}
}
