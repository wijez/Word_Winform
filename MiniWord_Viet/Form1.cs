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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void CreateNewRichTextBox()
        {
            RichTextBox newRichTextBox = new RichTextBox
            {
                Location = new Point(10, richTextBox1.Bottom + 10),
                Size = new Size(600, 400)
            };

            this.Controls.Add(newRichTextBox);
            richTextBoxCount++;
        }



        private void SetScrollToTop()
        {
            documentPanel.AutoScrollPosition = new Point(0, 0);
        }


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
