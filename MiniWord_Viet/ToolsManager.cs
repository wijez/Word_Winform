using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniWord_Viet
{
    internal class ToolsManager
    {
        private RichTextBox richTextBox;

        public ToolsManager(RichTextBox rtb)
        {
            this.richTextBox = rtb;
        }

        // Undo action
        public void Undo() => richTextBox.Undo();

        // Redo action
        public void Redo() => richTextBox.Redo();

        // Change selected text color
        public void ChangeTextColor(Color color) => richTextBox.SelectionColor = color;

        // Change text background color
        public void ChooseBackgroundColor()
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SelectionBackColor = colorDialog.Color;
                }
            }
        }
        // chose background inline  
        public void ChooseBackgroundColorInline()
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Nếu văn bản được chọn, hãy áp dụng màu nền cho văn bản đã chọn
                    if (richTextBox.SelectionLength > 0)
                    {
                        richTextBox.SelectionBackColor = colorDialog.Color;
                    }
                    else
                    {
                        // Lấy vị trí dấu mũ (con trỏ) hiện tại trong RichTextBox
                        int currentCaretPosition = richTextBox.SelectionStart;

                        // Bắt đầu dòng hiện tại
                        int lineStart = richTextBox.GetFirstCharIndexOfCurrentLine();

                        // Lấy kết thúc dòng hiện tại (chỉ số bắt đầu của dòng tiếp theo))
                        int lineEnd = richTextBox.GetFirstCharIndexFromLine(richTextBox.GetLineFromCharIndex(lineStart) + 1);

                        // Nếu dấu mũ ở dòng cuối cùng thì dòngEnd có thể nằm ngoài nội dung
                        if (lineEnd == -1)
                            lineEnd = richTextBox.TextLength;

                        richTextBox.Select(lineStart, lineEnd - lineStart);
                        richTextBox.SelectionBackColor = colorDialog.Color;

                        // Tùy chọn đặt lại lựa chọn về vị trí dấu mũ ban đầu
                        richTextBox.SelectionStart = currentCaretPosition;
                    }
                }
            }
        }


        // Toggle Bold style
        public void ToggleBold()
        {
            Font currentFont = richTextBox.SelectionFont;
            FontStyle newStyle = currentFont.Bold ? FontStyle.Regular : FontStyle.Bold;
            richTextBox.SelectionFont = new Font(currentFont, newStyle);
        }
        public void ToggleItalic()
        {
            Font currentFont = richTextBox.SelectionFont;
            FontStyle newStyle = currentFont.Italic ? FontStyle.Regular : FontStyle.Italic;
            richTextBox.SelectionFont = new Font(currentFont, newStyle);
        }
        public void ToggleUnderline()
        {
            Font currentFont = richTextBox.SelectionFont;
            FontStyle newStyle = currentFont.Underline ? FontStyle.Regular : FontStyle.Underline;
            richTextBox.SelectionFont = new Font(currentFont, newStyle);
        }

        public void ChooseTextColor()
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SelectionColor = colorDialog.Color;
                }
            }
        }

        // Set font size
        public void SetFontSize(float size)
        {
            if (richTextBox.SelectionFont != null)
            {
                Font currentFont = richTextBox.SelectionFont;
                richTextBox.SelectionFont = new Font(currentFont.FontFamily, size, currentFont.Style);
            }
        }

        // Method to apply font size from ComboBox input
        public void ApplyFontSizeFromComboBox(ToolStripComboBox comboBox)
        {
            if (float.TryParse(comboBox.Text, out float newSize))
            {
                SetFontSize(newSize);
            }
            else
            {
                MessageBox.Show("Please enter a valid font size.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ApplyFontStyleFromComboBox(ToolStripComboBox comboBox)
        {
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a font family.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedFontFamily = comboBox.SelectedItem.ToString();

            try
            {
                SetFontFamily(selectedFontFamily);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("The selected font family is not supported.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SetFontFamily(string fontFamily)
        {
            if (richTextBox.SelectionFont != null)
            {
                // Preserve the current font size and style while changing the font family
                Font currentFont = richTextBox.SelectionFont;
                richTextBox.SelectionFont = new Font(fontFamily, currentFont.Size, currentFont.Style);
            }
            else
            {
                // Apply font family to the default text if no specific selection is made
                richTextBox.Font = new Font(fontFamily, richTextBox.Font.Size, richTextBox.Font.Style);
            }
        }

        public void FindText(string findText)
        {
            int startIndex = richTextBox.SelectionStart + richTextBox.SelectionLength;
            int foundIndex = richTextBox.Find(findText, startIndex, RichTextBoxFinds.None);

            if (foundIndex != -1)
            {
                richTextBox.Select(foundIndex, findText.Length);
            }
            else
            {
                MessageBox.Show("Text not found.", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Replace text
        public void ReplaceText(string findText, string replaceText)
        {
            int startIndex = richTextBox.SelectionStart + richTextBox.SelectionLength;
            int foundIndex = richTextBox.Find(findText, startIndex, RichTextBoxFinds.None);

            if (foundIndex != -1)
            {
                richTextBox.Select(foundIndex, findText.Length);
                richTextBox.SelectedText = replaceText;
            }
            else
            {
                MessageBox.Show("Text not found.", "Replace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
