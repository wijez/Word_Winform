using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniWord_Viet
{
    internal class RulerManager
    {
            private Panel rulerPanel;
            private RichTextBox associatedRichTextBox;
            private Label associatedLabel;
            private bool isHorizontal;

            public RulerManager(Panel rulerPanel, RichTextBox richTextBox, Label label, bool isHorizontal)
            {
                this.rulerPanel = rulerPanel;
                this.associatedRichTextBox = richTextBox;
                this.associatedLabel = label;
                this.isHorizontal = isHorizontal;
            }

            public void CreateRuler()
            {
                rulerPanel.Width = isHorizontal ? associatedRichTextBox.Width : 15;
                rulerPanel.Height = isHorizontal ? 15 : associatedRichTextBox.Height;
                rulerPanel.BackColor = Color.LightGray;

                int step = 50;
                int length = isHorizontal ? associatedRichTextBox.Width : associatedRichTextBox.Height;

                for (int i = 0; i < length; i += step)
                {
                    CreateRulerMarker(i, step);
                    CreateRulerMark(i);
                }
                rulerPanel.BringToFront();
            }

            private void CreateRulerMarker(int position, int step)
            {
                Label markerLabel = new Label
                {
                    Text = (position / step).ToString(),
                    AutoSize = true,
                    Location = isHorizontal ? new Point(position, 5) : new Point(5, position)
                };
                rulerPanel.Controls.Add(markerLabel);
            }

            private void CreateRulerMark(int position)
            {
                Panel mark = new Panel
                {
                    Size = isHorizontal ? new Size(1, 5) : new Size(5, 1),
                    BackColor = Color.Black,
                    Location = isHorizontal ? new Point(position, 10) : new Point(10, position)
                };
                rulerPanel.Controls.Add(mark);
            }
        }
}
