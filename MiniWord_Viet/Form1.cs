using System.Windows.Forms;

namespace MiniWord_Viet
{
    public partial class Form1 : Form
    {
        private ToolStripControlHost trackBarHost;
        private TrackBar zoomTrackBar;
        private ToolStripStatusLabel zoomLabel;
        private Panel zoomPanel;
        private int richTextBoxCount = 1;
        private string currentFilePath;

        private Panel horizontalMarker;
        private Panel verticalMarker;
        private bool isDraggingHorizontal;
        private bool isDraggingVertical;
        private int originalIndent;

        private DocumentManager documentManager;

        private MarginHandler marginHandler;
        private ZoomManager zoomManager;
        private UnifiedRulerManager rulerManager;

        public Form1()
        {
            InitializeComponent();
            //InitializeStatusStrip();
            //CreateRuler(rulerHorizontal, true, lblHorizontal);
            //CreateRuler(rulerVertical, false, lblVertical);

            marginHandler = new MarginHandler(richTextBox1);
            documentManager = new DocumentManager(richTextBox1);
            zoomManager = new ZoomManager(statusStrip1, richTextBox1);

            //CreateDraggableMarkers();

            rulerManager = new UnifiedRulerManager(
             rulerHorizontal,
             rulerVertical,
             richTextBox1,
             lblHorizontal,
             lblVertical
         );
            rulerManager.Initialize();

            richTextBox1.SelectionChanged += RichTextBox1_SelectionChanged;

            SetScrollToTop();
        }

        private void RichTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            originalIndent = richTextBox1.SelectionIndent;
        }


        //private void Marker_MouseDown(object sender, MouseEventArgs e)
        //{
        //    // Start dragging when marker is clicked
        //    if (sender == horizontalMarker)
        //        isDraggingHorizontal = true;
        //    else if (sender == verticalMarker)
        //        isDraggingVertical = true;
        //}

        //private void MarkerHorizontal_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (isDraggingHorizontal)
        //    {
        //        int newX = Math.Max(0, Math.Min(e.X + horizontalMarker.Left, rulerHorizontal.Width - horizontalMarker.Width));
        //        horizontalMarker.Left = newX;

        //        richTextBox1.SelectionIndent = newX;
        //    }
        //}

        //private void MarkerVertical_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (isDraggingVertical)
        //    {
        //        int newY = Math.Max(0, Math.Min(e.Y + verticalMarker.Top, rulerVertical.Height - verticalMarker.Height));
        //        verticalMarker.Top = newY;
        //        richTextBox1.Height = newY;
        //    }
        //}

        //private void Marker_MouseUp(object sender, MouseEventArgs e)
        //{
        //    isDraggingHorizontal = false;
        //    isDraggingVertical = false;
        //}

        //private void CreateDraggableMarkers()
        //{
        //    horizontalMarker = new Panel
        //    {
        //        Size = new Size(5, rulerHorizontal.Height),
        //        BackColor = Color.Red,
        //        Cursor = Cursors.Hand
        //    };
        //    rulerHorizontal.Controls.Add(horizontalMarker);

        //    verticalMarker = new Panel
        //    {
        //        Size = new Size(rulerVertical.Width, 5),
        //        BackColor = Color.Red,
        //        Cursor = Cursors.Hand
        //    };
        //    rulerVertical.Controls.Add(verticalMarker);
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        //private void InitializeStatusStrip()
        //{
        //    zoomTrackBar = new TrackBar
        //    {
        //        Minimum = 10,
        //        Maximum = 200,
        //        Value = 100,
        //        TickStyle = TickStyle.None,
        //        Width = 100
        //    };
        //    zoomTrackBar.Scroll += ZoomTrackBar_Scroll;

        //    trackBarHost = new ToolStripControlHost(zoomTrackBar);

        //    statusStrip1.Items.Add(trackBarHost);

        //    zoomLabel = new ToolStripStatusLabel("100%");

        //    statusStrip1.Items.Add(zoomLabel);

        //    this.Controls.Add(statusStrip1);
        //}


        private void CreateNewRichTextBox()
        {
            RichTextBox newRichTextBox = new RichTextBox
            {
                Location = new Point(10, richTextBox1.Bottom + 10),
                Size = new Size(600, 400)
            };

            this.Controls.Add(newRichTextBox);
            richTextBoxCount++; // Increment the count of RichTextBoxes
        }

        //private void ZoomTrackBar_Scroll(object sender, EventArgs e)
        //{
        //    zoomLabel.Text = $"{zoomTrackBar.Value}%";
        //    float zoomFactor = zoomTrackBar.Value / 100f;
        //    richTextBox1.ZoomFactor = zoomFactor;

        //}


        private void SetScrollToTop()
        {
            documentPanel.AutoScrollPosition = new Point(0, 0);
        }

        //private void CreateRuler(Panel rulerPanel, bool isHorizontal, Label label)
        //{
        //    rulerPanel.Width = isHorizontal ? richTextBox1.Width : 15;
        //    rulerPanel.Height = isHorizontal ? 15 : richTextBox1.Height;
        //    rulerPanel.BackColor = Color.LightGray;
        //    this.Controls.Add(rulerPanel);

        //    int step = 50;
        //    int length = isHorizontal ? richTextBox1.Width : richTextBox1.Height;

        //    for (int i = 0; i < length; i += step)
        //    {
        //        Label markerLabel = new Label
        //        {
        //            Text = (i / step).ToString(),
        //            AutoSize = true
        //        };

        //        if (isHorizontal)
        //            markerLabel.Location = new Point(i, 5);
        //        else
        //            markerLabel.Location = new Point(5, i);

        //        rulerPanel.Controls.Add(markerLabel);
        //        rulerPanel.BringToFront();

        //        Panel mark = new Panel
        //        {
        //            Size = isHorizontal ? new Size(1, 5) : new Size(5, 1),
        //            BackColor = Color.Black
        //        };

        //        if (isHorizontal)
        //            mark.Location = new Point(i, 10);
        //        else
        //            mark.Location = new Point(10, i);

        //        rulerPanel.Controls.Add(mark);
        //    }
        //}



        private void rulerVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tSMenuSave_Click(object sender, EventArgs e)
        {
            documentManager.SaveDocument();
        }

        private void TSDMenuNew_Click(object sender, EventArgs e)
        {
            documentManager.NewDocument();
        }

        private void tSDMenuOpen_Click(object sender, EventArgs e)
        {
            documentManager.OpenDocument();
        }

        private void tSDMenuSaveAs_Click(object sender, EventArgs e)
        {
           documentManager.SaveDocumentAs();

        }

        private void tSDMenuClose_Click(object sender, EventArgs e)
        {
           documentManager.CloseDocument();
        }

        private void tSDMenuExit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text) && MessageBox.Show("Do you want to save changes before exiting?", "Exit Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tSMenuSave_Click(sender, e);
            }

            Application.Exit();
        }

        private void tSDMenuSave_Click(object sender, EventArgs e)
        {
            documentManager.SaveDocument();
        }

        private void tSDMenuMargin_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void documentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void narrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marginHandler.ApplyNarrowMargins();
        }

        private void moderateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marginHandler.ApplyModerateMargins();
        }

        private void wideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marginHandler.ApplyWideMargins();
        }

        private void mirroredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marginHandler.ApplyMirroredMargins();
        }

        private void office2003DefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marginHandler.ApplyOffice2003DefaultMargins();
        }

        private void cusstomMarginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marginHandler.ApplyCustomMargins();
        }
    }
}
