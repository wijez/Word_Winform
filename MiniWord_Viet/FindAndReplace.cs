using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniWord_Viet
{
    public partial class FindAndReplace : Form
    {
        public string FindText { get; private set; }
        public string ReplaceText { get; private set; }
        private RichTextBox richTextBox;

        public FindAndReplace(RichTextBox rtb)
        {
            InitializeComponent();
            this.richTextBox = rtb;
            this.FormClosing += new FormClosingEventHandler(FindAndReplace_FormClosing);
        }

        private void FindAndReplace_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < richTextBox.TextLength; i++)
            {
                richTextBox.Select(i, 1);

                if (richTextBox.SelectionBackColor == Color.Yellow)
                {
                    richTextBox.SelectionBackColor = Color.White;
                }
            }
        }

        private void FindAndReplace_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindText = textBox1.Text;
            FindInText(FindText);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            FindText = textBox1.Text;
            ReplaceText = textBox2.Text;
            ReplaceInText(FindText, ReplaceText);
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            FindText = textBox1.Text;
            ReplaceText = textBox2.Text;
            ReplaceAllInText(FindText, ReplaceText);
        }

        private void FindInText(string text)
        {
            // Start the search from the beginning
            int startIndex = 0;
            int textLength = text.Length;

            // Loop through the text in the RichTextBox
            while (startIndex < richTextBox.TextLength)
            {
                // Find the next occurrence of the text starting from the current position
                startIndex = richTextBox.Find(text, startIndex, RichTextBoxFinds.None);

                // If no match is found, exit the loop
                if (startIndex == -1)
                    break;

                // Highlight the found text
                richTextBox.Select(startIndex, textLength);
                richTextBox.SelectionBackColor = Color.Yellow; // Set highlight color

                // Move the starting index to the next character after the found text
                startIndex += textLength;
            }

            // If no occurrences are found, show a message
            if (startIndex == 0)
            {
                MessageBox.Show("Text not found!", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        // Replace the first occurrence of the text
        private void ReplaceInText(string findText, string replaceText)
        {
            int startIndex = richTextBox.Find(findText);
            if (startIndex != -1)
            {
                richTextBox.SelectedText = replaceText;
            }
            else
            {
                MessageBox.Show("Text not found!", "Replace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Replace all occurrences of the text
        private void ReplaceAllInText(string findText, string replaceText)
        {
            int startIndex = 0;
            while (startIndex < richTextBox.Text.Length)
            {
                startIndex = richTextBox.Find(findText, startIndex, RichTextBoxFinds.None);
                if (startIndex == -1)
                    break;

                richTextBox.Select(startIndex, findText.Length);
                richTextBox.SelectedText = replaceText;
                startIndex += replaceText.Length; // Move the cursor after the replaced text
            }
        }
    }
}
