using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniWord_Viet
{
    internal class UnifiedRulerManager
    {
        private Panel rulerHorizontal;
        private Panel rulerVertical;
        private RichTextBox associatedRichTextBox;
        private Label horizontalLabel;
        private Label verticalLabel;

        private Panel horizontalMarker;
        private Panel verticalMarker;
        private bool isDraggingHorizontal;
        private bool isDraggingVertical;

        private Dictionary<int, int> lineIndents = new Dictionary<int, int>();

        public UnifiedRulerManager(
            Panel horizontalRulerPanel,
            Panel verticalRulerPanel,
            RichTextBox richTextBox,
            Label horizontalLabel,
            Label verticalLabel)
        {
            this.rulerHorizontal = horizontalRulerPanel;
            this.rulerVertical = verticalRulerPanel;
            this.associatedRichTextBox = richTextBox;
            this.horizontalLabel = horizontalLabel;
            this.verticalLabel = verticalLabel;
        }

        public void Initialize()
        {
            CreateRulers();
            CreateDraggableMarkers();
            AttachEventHandlers();
        }

        private void CreateRulers()
        {
            ConfigureRuler(rulerHorizontal, true);
            CreateRulerElements(rulerHorizontal, true);

            ConfigureRuler(rulerVertical, false);
            CreateRulerElements(rulerVertical, false);
        }

        private void ConfigureRuler(Panel ruler, bool isHorizontal)
        {
            ruler.Width = isHorizontal ? associatedRichTextBox.Width : 15;
            ruler.Height = isHorizontal ? 15 : associatedRichTextBox.Height;
            ruler.BackColor = Color.LightGray;
            ruler.BringToFront();

        }

        private void CreateRulerElements(Panel ruler, bool isHorizontal)
        {
            int step = 50;
            int length = isHorizontal ? associatedRichTextBox.Width : associatedRichTextBox.Height;

            for (int i = 0; i < length; i += step)
            {
                CreateRulerMarker(ruler, i, step, isHorizontal);
                CreateRulerMark(ruler, i, isHorizontal);
            }
        }

        private void CreateRulerMarker(Panel ruler, int position, int step, bool isHorizontal)
        {
            Label markerLabel = new Label
            {
                Text = (position / step).ToString(),
                AutoSize = true,
                Location = isHorizontal ? new Point(position, 5) : new Point(5, position)
            };
            ruler.Controls.Add(markerLabel);
        }

        private void CreateRulerMark(Panel ruler, int position, bool isHorizontal)
        {
            Panel mark = new Panel
            {
                Size = isHorizontal ? new Size(1, 5) : new Size(5, 1),
                BackColor = Color.Black,
                Location = isHorizontal ? new Point(position, 10) : new Point(10, position)
            };
            ruler.Controls.Add(mark);
        }

        private void CreateDraggableMarkers()
        {
            horizontalMarker = new Panel
            {
                Size = new Size(5, rulerHorizontal.Height),
                BackColor = Color.Red,
                Cursor = Cursors.Hand
            };
            rulerHorizontal.Controls.Add(horizontalMarker);

            verticalMarker = new Panel
            {
                Size = new Size(rulerVertical.Width, 5),
                BackColor = Color.Red,
                Cursor = Cursors.Hand
            };
            rulerVertical.Controls.Add(verticalMarker);
        }

        private void AttachEventHandlers()
        {
            horizontalMarker.MouseDown += (s, e) => isDraggingHorizontal = true;
            horizontalMarker.MouseMove += MarkerHorizontal_MouseMove;
            horizontalMarker.MouseUp += (s, e) => isDraggingHorizontal = false;

            verticalMarker.MouseDown += (s, e) => isDraggingVertical = true;
            verticalMarker.MouseMove += MarkerVertical_MouseMove;
            verticalMarker.MouseUp += (s, e) => isDraggingVertical = false;

            associatedRichTextBox.Click += RichTextBox_Click;
        }

        private void associatedRichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            // Get the current line number based on cursor position
            int currentLine = associatedRichTextBox.GetLineFromCharIndex(associatedRichTextBox.SelectionStart);

            // Retrieve the stored indent for this line, if any
            if (lineIndents.TryGetValue(currentLine, out int indent))
            {
                // Move the horizontal marker to the stored indent position
                horizontalMarker.Left = indent;
            }
            else
            {
                // If no specific indent is stored, reset the marker to the start (e.g., 0)
                horizontalMarker.Left = 0;
            }
        }


        private void MarkerHorizontal_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggingHorizontal)
            {
                int newX = Math.Max(0, Math.Min(e.X + horizontalMarker.Left,
                    rulerHorizontal.Width - horizontalMarker.Width));
                horizontalMarker.Left = newX;

                int currentLine = associatedRichTextBox.GetLineFromCharIndex(associatedRichTextBox.SelectionStart);

                // Set the indent for the current line
                associatedRichTextBox.SelectionStart = associatedRichTextBox.GetFirstCharIndexFromLine(currentLine);
                associatedRichTextBox.SelectionLength = 0;
                associatedRichTextBox.SelectionIndent = newX;
                lineIndents[currentLine] = newX;

            }
        }

        private void MarkerVertical_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggingVertical)
            {
                int newY = Math.Max(0, Math.Min(e.Y + verticalMarker.Top,
                    rulerVertical.Height - verticalMarker.Height));
                verticalMarker.Top = newY;
                associatedRichTextBox.Height = newY;
            }
        }

      

        private void RichTextBox_Click(object sender, EventArgs e)
        {
            int clickedLine = associatedRichTextBox.GetLineFromCharIndex(associatedRichTextBox.SelectionStart);

            if (lineIndents.TryGetValue(clickedLine, out int indent))
            {
                horizontalMarker.Left = indent;
            }
            else
            {
                horizontalMarker.Left = 0;
            }

        }
    }
}
