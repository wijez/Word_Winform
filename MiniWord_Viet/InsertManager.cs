using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using EmojiToolkit;

namespace MiniWord_Viet
{
    internal class InsertManager
    {
        private RichTextBox richtextBox;
        private ToolTip emojiToolTip;

        public InsertManager(RichTextBox rtb)
        {
            this.richtextBox = rtb;
           
            emojiToolTip = new ToolTip(); 
            InitializeComponents(); 
           
        }

        private void InitializeComponents()
        {
            
        }

        public void InsertImage(string imagePath)
        {
            try
            {
                Image image = Image.FromFile(imagePath);
                Clipboard.SetImage(image);
                richtextBox.Paste();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting image: " + ex.Message);
            }  
           
        }

        public void InsertEmoji(string emoji)
        {
            if (richtextBox != null && !string.IsNullOrEmpty(emoji))
            {
                int caretPos = richtextBox.SelectionStart;
                richtextBox.Text = richtextBox.Text.Insert(caretPos, emoji);
                richtextBox.SelectionStart = caretPos + emoji.Length;  // Move cursor after inserted emoji
            }
        }
    }
}
