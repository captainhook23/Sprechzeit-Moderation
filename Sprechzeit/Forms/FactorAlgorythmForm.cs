using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Spire.Doc;


namespace Sprechzeit.Forms
{
    public partial class FactorAlgorythmForm : Form
    {
        string filePath;
        string text;
        bool BeginToCount = false;
        public FactorAlgorythmForm()
        {
            InitializeComponent();

        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                textBox1_Textdokument.Text = File.ReadAllText(filePath);
            }
        }        

        private void CreateString()
        {
            string allWords = textBox1_Textdokument.Text;
            string[] lines = allWords.Split('\n');
            foreach (string line in lines)
            {
                if (BeginToCount == true)
                {
                    if (line.Contains("O-Ton") == false)
                    {
                        text += line;
                    }
                }
                if (line.Contains("Beitragstext") == true)
                {
                    BeginToCount = true;
                }
            }

            string trimmed = text.Replace(" ", "");
            string newLine = trimmed.Replace("\n", "");
            string final = newLine.Replace("\r", "");
            char[] charArray = final.ToCharArray();

            textBox1.Text = final;
            textBox2.Text = text;// feld Links
            textBox3.Text = charArray.Count().ToString();
        }

        private void btn_UpdateFactor_Click(object sender, EventArgs e)
        {
            OpenFile();
            CreateString();
        }

        private void button1_Clear_Click(object sender, EventArgs e)
        {
            textBox1_Textdokument.Clear();
        }
    }
}
