using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScbPasswordGenerator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		static string Shuffle(string input)
		{
			var q = from c in input.ToCharArray()
							orderby Guid.NewGuid()
							select c;
			string s = string.Empty;
			foreach (var r in q)
				s += r;
			return s;
		}
		public string Generate(int length, bool isLower, bool isCapital, bool isNumber, bool isSymbol)
		{

			string upperCharList = "ABCDEFGHJKLMNOPRSTUVWYZ";
			string charList = "abcdefghijkmnoprstuvyz";
			string numberList = "1234567890";
			string symbolList = "!_-&.#";
			StringBuilder str0 = new StringBuilder(100);
			StringBuilder str1 = new StringBuilder(100);
			StringBuilder str2 = new StringBuilder(100);
			StringBuilder str3 = new StringBuilder(100);

			int divide = 0;
			divide += isLower ? 1 : 0;
			divide += isCapital ? 1 : 0;
			divide += isNumber ? 1 : 0;
			divide += isSymbol ? 1 : 0;
			 
			int piece = length / divide;
			int remaining = (length % divide);
			bool isRemainingAdded = false;
			if (isCapital)
			{
				int lengthOfUpperChar = piece;
				lengthOfUpperChar += !isRemainingAdded ? remaining : 0;
				isRemainingAdded = true;
				Random random0 = new Random();
				while (0 < lengthOfUpperChar--)
				{
					str0.Append(upperCharList[random0.Next(upperCharList.Length)]);
				}
			}

			if (isLower)
			{
				int lengthOfChar = piece;
				lengthOfChar += !isRemainingAdded ? remaining : 0;
				isRemainingAdded = true;
				Random random1 = new Random();
				while (0 < lengthOfChar--)
				{
					str1.Append(charList[random1.Next(charList.Length)]);
				}
			}
			if (isNumber)
			{
				int lengthOfNumber = piece ;
				lengthOfNumber += !isRemainingAdded ? remaining : 0;
				isRemainingAdded = true;
				Random random2 = new Random();
				while (0 < lengthOfNumber--)
				{
					str2.Append(numberList[random2.Next(numberList.Length)]);
				}

			}
			if (isSymbol)
			{
				int lengthOfSymbol = piece;
				lengthOfSymbol += !isRemainingAdded ? remaining : 0;
				isRemainingAdded = true;
				Random random3 = new Random();
				while (0 < lengthOfSymbol--)
				{
					str3.Append(symbolList[random3.Next(symbolList.Length)]);
				}
			}
			return Shuffle(str0.ToString() + str1.ToString() + str2.ToString() + str3.ToString());
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem == null)
			{
        resultLabel.ForeColor = Color.Red;
        resultLabel.Text = "Lütfen metnin uzunluğunu belirtilen değerlerden seçiniz!"; 
			}
			else if (!isLower.Checked && !isCapital.Checked &&!isNumber.Checked&& !isSymbol.Checked )
			{
				resultLabel.ForeColor = Color.Red;
        resultLabel.Text = "Lütfen karakter tiplerinden en az birini seçiniz!";
			}
			else
			{
				var length = int.Parse(comboBox1.SelectedItem.ToString());

				textBox1.Text = Generate(length, isLower.Checked, isCapital.Checked, isNumber.Checked, isSymbol.Checked);
        resultLabel.Text = "✓ Üretildi";
        resultLabel.ForeColor = Color.Green;
				copyButton.Visible = true;
      }
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var text = textBox1.Text;
			if(text == "")
			{
				resultLabel.ForeColor = Color.Red;
        resultLabel.Text = "Lütfen önce şifre üretiniz!";
        
			}
			else
			{
        // Set the value saved in the Clipboard
        Clipboard.SetDataObject(text.ToString());
        resultLabel.Text = "✓ Panoya Kopyalandı";
        resultLabel.ForeColor = Color.Green;
      }




     
    }
	}
}
