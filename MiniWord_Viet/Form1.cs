using System.Collections;
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
        private ToolsManager toolsManager;
        private MarginHandler marginHandler;
        private ZoomManager zoomManager;
        private UnifiedRulerManager rulerManager;
        private HomeManager homeManager;
        private InsertManager insertManager;
        private List<string> fontList;

        public Form1()
        {
            InitializeComponent();
            toolsManager = new ToolsManager(richTextBox1);
            marginHandler = new MarginHandler(richTextBox1);
            documentManager = new DocumentManager(richTextBox1);
            zoomManager = new ZoomManager(statusStrip1, richTextBox1);
            homeManager = new HomeManager(richTextBox1);
            insertManager = new InsertManager(richTextBox1);


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

            tSCFontSize.Items.AddRange(new object[] { 8, 10, 12, 14, 16, 18, 20, 24, 28, 32, 36, 48, 72 });
            tSCFontSize.SelectedIndex = 2;
            //foreach (FontFamily font in FontFamily.Families)
            //{
            //    tSMenuStyle.Items.Add(font.Name);
            //}

            //if (tSMenuStyle.Items.Count > 0)
            //{
            //    tSMenuStyle.SelectedIndex = 0;
            //}
            fontList = new List<string>();
            foreach (FontFamily font in FontFamily.Families)
            {
                fontList.Add(font.Name);
                tSMenuStyle.Items.Add(font.Name);
            }

            // Set default selection if there are items
            if (tSMenuStyle.Items.Count > 0)
            {
                tSMenuStyle.SelectedIndex = 0;
            }
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

        private void tSMenuRedo_Click(object sender, EventArgs e)
        {
            toolsManager.Redo();
        }

        private void tSMenuUndo_Click(object sender, EventArgs e)
        {
            toolsManager.Undo();
        }

        private void tSMenuColorText_Click(object sender, EventArgs e)
        {
            toolsManager.ChooseBackgroundColor();
        }

        private void tSMenuA_Click(object sender, EventArgs e)
        {
            toolsManager.ChooseTextColor();
        }

        private void tSMenuBrush_Click(object sender, EventArgs e)
        {
            toolsManager.ToggleBold();
        }

        private void tsMenuBgColor_Click(object sender, EventArgs e)
        {
            toolsManager.ChooseBackgroundColorInline();
        }

        private void tSCFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolsManager.ApplyFontSizeFromComboBox(tSCFontSize);
        }

        private void tSMenuStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolsManager.ApplyFontStyleFromComboBox(tSMenuStyle);
        }

        private void tSMenuBold_Click(object sender, EventArgs e)
        {
            toolsManager.ToggleBold();
        }


        private void tSMenuUnderline_Click(object sender, EventArgs e)
        {
            toolsManager.ToggleUnderline();
        }

        private void tSMenuItalic_Click(object sender, EventArgs e)
        {
            toolsManager.ToggleItalic();
        }

        private void tSMenuStyle_Click(object sender, EventArgs e)
        {

        }

        private void tSCFontSize_Click(object sender, EventArgs e)
        {
        }

        private void tsMenuFontSize_Click(object sender, EventArgs e)
        {
            homeManager.ShowFontDialog();
        }

        private void tSMenuFontStyle_Click(object sender, EventArgs e)
        {
            homeManager.ShowFontDialog();
        }

        private void tsMenuZoomIn_Click(object sender, EventArgs e)
        {
            homeManager.ZoomIn();
        }

        private void tsMenuZoomOut_Click(object sender, EventArgs e)
        {
            homeManager.ZoomOut();
        }



        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.B:
                        toolsManager.ToggleBold();
                        break;
                    case Keys.I:
                        toolsManager.ToggleItalic();
                        break;
                    case Keys.U:
                        toolsManager.ToggleUnderline();
                        break;
                    case Keys.C:
                        richTextBox1.Copy();
                        e.Handled = true;
                        break;
                    case Keys.V:
                        richTextBox1.Paste();
                        e.Handled = true;
                        break;
                    case Keys.A:
                        richTextBox1.SelectAll();
                        e.Handled = true;
                        break;
                    case Keys.Z:
                        toolsManager.Undo();
                        break;
                }

                e.Handled = true;

            }
        }

        private void tSMenuFind_Click(object sender, EventArgs e)
        {
            FindAndReplace findAndReplaceForm = new FindAndReplace(richTextBox1);
            findAndReplaceForm.ShowDialog();
        }

        private void tSMenuImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    insertManager.InsertImage(openFileDialog.FileName);
                }
            }
        }

        private void tSMenuEmoji_Click(object sender, EventArgs e)
        {
            EmojiForm emojiForm = new EmojiForm(richTextBox1);
            emojiForm.Show();

        }

        private void tSMenuStyle_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
