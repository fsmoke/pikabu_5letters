using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace _5Letters
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var myPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
			var wordsPath = Path.Combine(myPath, "words.txt");
			if (!File.Exists(wordsPath))
			{
				MessageBox.Show("Файл words.txt не найден - он должен лежать рядом с exe программы!", "Ошибка");
				return;
			}
			var wordsStrings = File.ReadAllLines(wordsPath);
			var allWords = new List<string>(wordsStrings);

			Application.Run(new FormMain(allWords));
		}
	}
}
