using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniWord_Viet
{
    internal class HomeManager
    {
        private RichTextBox richTextBox;
        private float zoomFactor = 1.0f;

        public HomeManager(RichTextBox rtb)
        {
            this.richTextBox = rtb;
        }

        public void ShowFontDialog()
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                // Set initial font settings to current selection
                fontDialog.Font = richTextBox.SelectionFont ?? richTextBox.Font;

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    // Apply selected font to the selected text
                    richTextBox.SelectionFont = fontDialog.Font;
                }
            }
        }

        // Zoom in (increase zoom factor)
        public void ZoomIn()
        {
            if (zoomFactor < 5.0f) // Limit zoom in to avoid excessive size
            {
                zoomFactor += 0.1f;
                richTextBox.ZoomFactor = zoomFactor;
            }
        }

        // Zoom out (decrease zoom factor)
        public void ZoomOut()
        {
            if (zoomFactor > 0.1f) // Limit zoom out to avoid excessive shrink
            {
                zoomFactor -= 0.1f;
                richTextBox.ZoomFactor = zoomFactor;
            }
        }
    }
}
