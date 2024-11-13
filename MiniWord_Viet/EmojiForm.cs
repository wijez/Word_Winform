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
    public partial class EmojiForm : Form
    {
        private RichTextBox richTextBox;

        public EmojiForm(RichTextBox rtb)
        {
            InitializeComponent();
            this.richTextBox = rtb;

            // Add sample emojis (you can add more emojis as needed)
            var emojis = new string[]
            {
                "😀", "😁", "😂", "🤣", "😃", "😄", "😅", "😆",
                "😇", "😍", "😎", "😜", "😝", "😒", "😔", "😓"
            };

            // Dynamically create emoji buttons
            int x = 10, y = 10;
            foreach (var emoji in emojis)
            {
                Button emojiButton = new Button();
                emojiButton.Text = emoji;
                emojiButton.Width = 50;
                emojiButton.Height = 50;
                emojiButton.Location = new System.Drawing.Point(x, y);
                emojiButton.Click += EmojiButton_Click;

                this.Controls.Add(emojiButton);

                x += 60; // Adjust button position for next emoji

                // Move to next row after 5 emojis
                if (x > 300)
                {
                    x = 10;
                    y += 60;
                }
            }
        }
        private void EmojiForm_Load(object sender, EventArgs e)
        {
            // Your code to handle form load event
        }


        private void EmojiButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                // Insert the selected emoji into the RichTextBox at the cursor position
                richTextBox.SelectedText = button.Text;
            }
            // this.Close();
        }
    }
}
