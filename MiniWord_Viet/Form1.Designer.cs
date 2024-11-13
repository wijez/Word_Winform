namespace MiniWord_Viet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tSMenuFile = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            TSDMenuNew = new ToolStripMenuItem();
            tSDMenuOpen = new ToolStripMenuItem();
            tSDMenuSave = new ToolStripMenuItem();
            tSDMenuSaveAs = new ToolStripMenuItem();
            tSDMenuClose = new ToolStripMenuItem();
            tSDMenuExit = new ToolStripMenuItem();
            tSMenuHome = new ToolStripMenuItem();
            tSMenuFontStyle = new ToolStripMenuItem();
            tsMenuFontSize = new ToolStripMenuItem();
            tsMenuZoomIn = new ToolStripMenuItem();
            tsMenuZoomOut = new ToolStripMenuItem();
            tSMenuInsert = new ToolStripMenuItem();
            tSMenuImage = new ToolStripMenuItem();
            tSMenuEmoji = new ToolStripMenuItem();
            tsMenuDesign = new ToolStripMenuItem();
            tSMenuLayout = new ToolStripMenuItem();
            tSDMenuMargin = new ToolStripMenuItem();
            narrowToolStripMenuItem = new ToolStripMenuItem();
            moderateToolStripMenuItem = new ToolStripMenuItem();
            wideToolStripMenuItem = new ToolStripMenuItem();
            mirroredToolStripMenuItem = new ToolStripMenuItem();
            office2003DefaultToolStripMenuItem = new ToolStripMenuItem();
            cusstomMarginToolStripMenuItem = new ToolStripMenuItem();
            tSMenuReferences = new ToolStripMenuItem();
            tSMenuMailing = new ToolStripMenuItem();
            tSMenuView = new ToolStripMenuItem();
            tSMenuIdea = new ToolStripMenuItem();
            tSMenuSignIn = new ToolStripMenuItem();
            tSMenuShare = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            tSMenuSave = new ToolStripMenuItem();
            tSMenuRedo = new ToolStripMenuItem();
            tSMenuUndo = new ToolStripMenuItem();
            tSMenuColorText = new ToolStripMenuItem();
            tSMenuA = new ToolStripMenuItem();
            tSMenuBrush = new ToolStripMenuItem();
            tsMenuBgColor = new ToolStripMenuItem();
            tSMenuStyle = new ToolStripComboBox();
            tSCFontSize = new ToolStripComboBox();
            tSMenuBold = new ToolStripMenuItem();
            tSMenuItalic = new ToolStripMenuItem();
            tSMenuUnderline = new ToolStripMenuItem();
            tSMenuFind = new ToolStripMenuItem();
            rulerHorizontal = new Panel();
            lblHorizontal = new Label();
            rulerVertical = new Panel();
            lblVertical = new Label();
            label1 = new Label();
            documentPanel = new Panel();
            richTextBox1 = new RichTextBox();
            statusStrip1 = new StatusStrip();
            tSStatusPageof = new ToolStripStatusLabel();
            tSStatusWord = new ToolStripStatusLabel();
            tSStatusLanguage = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            rulerHorizontal.SuspendLayout();
            rulerVertical.SuspendLayout();
            documentPanel.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tSMenuFile, tSMenuHome, tSMenuInsert, tsMenuDesign, tSMenuLayout, tSMenuReferences, tSMenuMailing, tSMenuView, tSMenuIdea, tSMenuSignIn, tSMenuShare });
            menuStrip1.Location = new Point(0, 27);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(888, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // tSMenuFile
            // 
            tSMenuFile.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, TSDMenuNew, tSDMenuOpen, tSDMenuSave, tSDMenuSaveAs, tSDMenuClose, tSDMenuExit });
            tSMenuFile.Name = "tSMenuFile";
            tSMenuFile.Size = new Size(37, 20);
            tSMenuFile.Text = "File";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(111, 6);
            // 
            // TSDMenuNew
            // 
            TSDMenuNew.Name = "TSDMenuNew";
            TSDMenuNew.Size = new Size(114, 22);
            TSDMenuNew.Text = "New";
            TSDMenuNew.Click += TSDMenuNew_Click;
            // 
            // tSDMenuOpen
            // 
            tSDMenuOpen.Name = "tSDMenuOpen";
            tSDMenuOpen.Size = new Size(114, 22);
            tSDMenuOpen.Text = "Open";
            tSDMenuOpen.Click += tSDMenuOpen_Click;
            // 
            // tSDMenuSave
            // 
            tSDMenuSave.Image = Properties.Resources.diskette;
            tSDMenuSave.Name = "tSDMenuSave";
            tSDMenuSave.Size = new Size(114, 22);
            tSDMenuSave.Text = "Save";
            tSDMenuSave.Click += tSDMenuSave_Click;
            // 
            // tSDMenuSaveAs
            // 
            tSDMenuSaveAs.Name = "tSDMenuSaveAs";
            tSDMenuSaveAs.Size = new Size(114, 22);
            tSDMenuSaveAs.Text = "Save As";
            tSDMenuSaveAs.Click += tSDMenuSaveAs_Click;
            // 
            // tSDMenuClose
            // 
            tSDMenuClose.Name = "tSDMenuClose";
            tSDMenuClose.Size = new Size(114, 22);
            tSDMenuClose.Text = "Close";
            tSDMenuClose.Click += tSDMenuClose_Click;
            // 
            // tSDMenuExit
            // 
            tSDMenuExit.Name = "tSDMenuExit";
            tSDMenuExit.Size = new Size(114, 22);
            tSDMenuExit.Text = "Exit";
            tSDMenuExit.Click += tSDMenuExit_Click;
            // 
            // tSMenuHome
            // 
            tSMenuHome.DropDownItems.AddRange(new ToolStripItem[] { tSMenuFontStyle, tsMenuFontSize, tsMenuZoomIn, tsMenuZoomOut });
            tSMenuHome.Name = "tSMenuHome";
            tSMenuHome.Size = new Size(52, 20);
            tSMenuHome.Text = "Home";
            // 
            // tSMenuFontStyle
            // 
            tSMenuFontStyle.Image = Properties.Resources.icons8_font_style_50;
            tSMenuFontStyle.Name = "tSMenuFontStyle";
            tSMenuFontStyle.Size = new Size(129, 22);
            tSMenuFontStyle.Text = "Font Style";
            tSMenuFontStyle.Click += tSMenuFontStyle_Click;
            // 
            // tsMenuFontSize
            // 
            tsMenuFontSize.Image = Properties.Resources._42242_font_size_icon;
            tsMenuFontSize.Name = "tsMenuFontSize";
            tsMenuFontSize.Size = new Size(129, 22);
            tsMenuFontSize.Text = "Font Size";
            tsMenuFontSize.Click += tsMenuFontSize_Click;
            // 
            // tsMenuZoomIn
            // 
            tsMenuZoomIn.Image = Properties.Resources.icons8_zoom_in_50;
            tsMenuZoomIn.Name = "tsMenuZoomIn";
            tsMenuZoomIn.Size = new Size(129, 22);
            tsMenuZoomIn.Text = "Zoom In";
            tsMenuZoomIn.Click += tsMenuZoomIn_Click;
            // 
            // tsMenuZoomOut
            // 
            tsMenuZoomOut.Image = Properties.Resources.icons8_zoom_out_50;
            tsMenuZoomOut.Name = "tsMenuZoomOut";
            tsMenuZoomOut.Size = new Size(129, 22);
            tsMenuZoomOut.Text = "Zoom Out";
            tsMenuZoomOut.Click += tsMenuZoomOut_Click;
            // 
            // tSMenuInsert
            // 
            tSMenuInsert.DropDownItems.AddRange(new ToolStripItem[] { tSMenuImage, tSMenuEmoji });
            tSMenuInsert.Name = "tSMenuInsert";
            tSMenuInsert.Size = new Size(48, 20);
            tSMenuInsert.Text = "Insert";
            // 
            // tSMenuImage
            // 
            tSMenuImage.Image = Properties.Resources.icons8_image_50;
            tSMenuImage.Name = "tSMenuImage";
            tSMenuImage.Size = new Size(107, 22);
            tSMenuImage.Text = "Image";
            tSMenuImage.Click += tSMenuImage_Click;
            // 
            // tSMenuEmoji
            // 
            tSMenuEmoji.Image = Properties.Resources.icons8_crazy_26;
            tSMenuEmoji.Name = "tSMenuEmoji";
            tSMenuEmoji.Size = new Size(107, 22);
            tSMenuEmoji.Text = "Emoji";
            tSMenuEmoji.Click += tSMenuEmoji_Click;
            // 
            // tsMenuDesign
            // 
            tsMenuDesign.Name = "tsMenuDesign";
            tsMenuDesign.Size = new Size(55, 20);
            tsMenuDesign.Text = "Design";
            // 
            // tSMenuLayout
            // 
            tSMenuLayout.DropDownItems.AddRange(new ToolStripItem[] { tSDMenuMargin });
            tSMenuLayout.Name = "tSMenuLayout";
            tSMenuLayout.Size = new Size(55, 20);
            tSMenuLayout.Text = "Layout";
            // 
            // tSDMenuMargin
            // 
            tSDMenuMargin.DropDownItems.AddRange(new ToolStripItem[] { narrowToolStripMenuItem, moderateToolStripMenuItem, wideToolStripMenuItem, mirroredToolStripMenuItem, office2003DefaultToolStripMenuItem, cusstomMarginToolStripMenuItem });
            tSDMenuMargin.Image = Properties.Resources.margin;
            tSDMenuMargin.Name = "tSDMenuMargin";
            tSDMenuMargin.Size = new Size(112, 22);
            tSDMenuMargin.Text = "Margin";
            tSDMenuMargin.Click += tSDMenuMargin_Click;
            // 
            // narrowToolStripMenuItem
            // 
            narrowToolStripMenuItem.Name = "narrowToolStripMenuItem";
            narrowToolStripMenuItem.Size = new Size(174, 22);
            narrowToolStripMenuItem.Text = "Narrow";
            narrowToolStripMenuItem.Click += narrowToolStripMenuItem_Click;
            // 
            // moderateToolStripMenuItem
            // 
            moderateToolStripMenuItem.Name = "moderateToolStripMenuItem";
            moderateToolStripMenuItem.Size = new Size(174, 22);
            moderateToolStripMenuItem.Text = "Moderate";
            moderateToolStripMenuItem.Click += moderateToolStripMenuItem_Click;
            // 
            // wideToolStripMenuItem
            // 
            wideToolStripMenuItem.Name = "wideToolStripMenuItem";
            wideToolStripMenuItem.Size = new Size(174, 22);
            wideToolStripMenuItem.Text = "Wide";
            wideToolStripMenuItem.Click += wideToolStripMenuItem_Click;
            // 
            // mirroredToolStripMenuItem
            // 
            mirroredToolStripMenuItem.Name = "mirroredToolStripMenuItem";
            mirroredToolStripMenuItem.Size = new Size(174, 22);
            mirroredToolStripMenuItem.Text = "Mirrored";
            mirroredToolStripMenuItem.Click += mirroredToolStripMenuItem_Click;
            // 
            // office2003DefaultToolStripMenuItem
            // 
            office2003DefaultToolStripMenuItem.Name = "office2003DefaultToolStripMenuItem";
            office2003DefaultToolStripMenuItem.Size = new Size(174, 22);
            office2003DefaultToolStripMenuItem.Text = "Office 2003 Default";
            office2003DefaultToolStripMenuItem.Click += office2003DefaultToolStripMenuItem_Click;
            // 
            // cusstomMarginToolStripMenuItem
            // 
            cusstomMarginToolStripMenuItem.Name = "cusstomMarginToolStripMenuItem";
            cusstomMarginToolStripMenuItem.Size = new Size(174, 22);
            cusstomMarginToolStripMenuItem.Text = "Custom Margins";
            cusstomMarginToolStripMenuItem.Click += cusstomMarginToolStripMenuItem_Click;
            // 
            // tSMenuReferences
            // 
            tSMenuReferences.Name = "tSMenuReferences";
            tSMenuReferences.Size = new Size(76, 20);
            tSMenuReferences.Text = "References";
            // 
            // tSMenuMailing
            // 
            tSMenuMailing.Name = "tSMenuMailing";
            tSMenuMailing.Size = new Size(59, 20);
            tSMenuMailing.Text = "Mailing";
            // 
            // tSMenuView
            // 
            tSMenuView.Name = "tSMenuView";
            tSMenuView.Size = new Size(44, 20);
            tSMenuView.Text = "View";
            // 
            // tSMenuIdea
            // 
            tSMenuIdea.Image = Properties.Resources.idea;
            tSMenuIdea.Name = "tSMenuIdea";
            tSMenuIdea.Size = new Size(199, 20);
            tSMenuIdea.Text = "Tell me what you want to do ... ";
            // 
            // tSMenuSignIn
            // 
            tSMenuSignIn.Name = "tSMenuSignIn";
            tSMenuSignIn.Size = new Size(55, 20);
            tSMenuSignIn.Text = "Sign In";
            // 
            // tSMenuShare
            // 
            tSMenuShare.Image = Properties.Resources.plus;
            tSMenuShare.Name = "tSMenuShare";
            tSMenuShare.Size = new Size(64, 20);
            tSMenuShare.Text = "Share";
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { tSMenuSave, tSMenuRedo, tSMenuUndo, tSMenuColorText, tSMenuA, tSMenuBrush, tsMenuBgColor, tSMenuStyle, tSCFontSize, tSMenuBold, tSMenuItalic, tSMenuUnderline, tSMenuFind });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(888, 27);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // tSMenuSave
            // 
            tSMenuSave.Image = Properties.Resources.diskette;
            tSMenuSave.Name = "tSMenuSave";
            tSMenuSave.Size = new Size(28, 23);
            tSMenuSave.Click += tSMenuSave_Click;
            // 
            // tSMenuRedo
            // 
            tSMenuRedo.Image = Properties.Resources.undo;
            tSMenuRedo.Name = "tSMenuRedo";
            tSMenuRedo.Size = new Size(28, 23);
            tSMenuRedo.Click += tSMenuRedo_Click;
            // 
            // tSMenuUndo
            // 
            tSMenuUndo.Image = Properties.Resources.undo_circular_arrow;
            tSMenuUndo.Name = "tSMenuUndo";
            tSMenuUndo.Size = new Size(28, 23);
            tSMenuUndo.Click += tSMenuUndo_Click;
            // 
            // tSMenuColorText
            // 
            tSMenuColorText.Image = Properties.Resources.format1;
            tSMenuColorText.Name = "tSMenuColorText";
            tSMenuColorText.Size = new Size(28, 23);
            tSMenuColorText.Click += tSMenuColorText_Click;
            // 
            // tSMenuA
            // 
            tSMenuA.Image = Properties.Resources.letter_a;
            tSMenuA.Name = "tSMenuA";
            tSMenuA.Size = new Size(28, 23);
            tSMenuA.Click += tSMenuA_Click;
            // 
            // tSMenuBrush
            // 
            tSMenuBrush.Image = Properties.Resources.paint_brush;
            tSMenuBrush.Name = "tSMenuBrush";
            tSMenuBrush.Size = new Size(28, 23);
            tSMenuBrush.Click += tSMenuBrush_Click;
            // 
            // tsMenuBgColor
            // 
            tsMenuBgColor.Image = Properties.Resources.paint_bucket;
            tsMenuBgColor.Name = "tsMenuBgColor";
            tsMenuBgColor.Size = new Size(28, 23);
            tsMenuBgColor.Click += tsMenuBgColor_Click;
            // 
            // tSMenuStyle
            // 
            tSMenuStyle.Name = "tSMenuStyle";
            tSMenuStyle.Size = new Size(150, 23);
            tSMenuStyle.SelectedIndexChanged += tSMenuStyle_SelectedIndexChanged;
            tSMenuStyle.Click += tSMenuStyle_Click;
            tSMenuStyle.TextChanged += tSMenuStyle_TextChanged;
            // 
            // tSCFontSize
            // 
            tSCFontSize.AutoSize = false;
            tSCFontSize.Name = "tSCFontSize";
            tSCFontSize.Size = new Size(50, 23);
            tSCFontSize.SelectedIndexChanged += tSCFontSize_SelectedIndexChanged;
            tSCFontSize.Click += tSCFontSize_Click;
            // 
            // tSMenuBold
            // 
            tSMenuBold.Image = Properties.Resources._4295580_bold_font_style_text_thick_icon;
            tSMenuBold.Name = "tSMenuBold";
            tSMenuBold.Size = new Size(28, 23);
            tSMenuBold.Click += tSMenuBold_Click;
            // 
            // tSMenuItalic
            // 
            tSMenuItalic.Image = Properties.Resources._4295570_italic_cursive_font_style_text_icon;
            tSMenuItalic.Name = "tSMenuItalic";
            tSMenuItalic.Size = new Size(28, 23);
            tSMenuItalic.Click += tSMenuItalic_Click;
            // 
            // tSMenuUnderline
            // 
            tSMenuUnderline.Image = Properties.Resources.icons8_underline_50;
            tSMenuUnderline.Name = "tSMenuUnderline";
            tSMenuUnderline.Size = new Size(28, 23);
            tSMenuUnderline.Click += tSMenuUnderline_Click;
            // 
            // tSMenuFind
            // 
            tSMenuFind.Image = Properties.Resources.icons8_find_50;
            tSMenuFind.Name = "tSMenuFind";
            tSMenuFind.Size = new Size(28, 23);
            tSMenuFind.Click += tSMenuFind_Click;
            // 
            // rulerHorizontal
            // 
            rulerHorizontal.BackColor = Color.FromArgb(255, 128, 128);
            rulerHorizontal.Controls.Add(lblHorizontal);
            rulerHorizontal.Location = new Point(46, 51);
            rulerHorizontal.MaximumSize = new Size(794, 15);
            rulerHorizontal.Name = "rulerHorizontal";
            rulerHorizontal.Size = new Size(794, 15);
            rulerHorizontal.TabIndex = 3;
            // 
            // lblHorizontal
            // 
            lblHorizontal.AutoSize = true;
            lblHorizontal.Location = new Point(0, 0);
            lblHorizontal.Name = "lblHorizontal";
            lblHorizontal.Size = new Size(0, 15);
            lblHorizontal.TabIndex = 0;
            // 
            // rulerVertical
            // 
            rulerVertical.BackColor = Color.FromArgb(255, 128, 128);
            rulerVertical.Controls.Add(lblVertical);
            rulerVertical.Controls.Add(label1);
            rulerVertical.Location = new Point(0, 83);
            rulerVertical.MaximumSize = new Size(15, 1123);
            rulerVertical.Name = "rulerVertical";
            rulerVertical.Size = new Size(15, 1123);
            rulerVertical.TabIndex = 4;
            rulerVertical.Paint += rulerVertical_Paint;
            // 
            // lblVertical
            // 
            lblVertical.AutoSize = true;
            lblVertical.Location = new Point(0, 0);
            lblVertical.Name = "lblVertical";
            lblVertical.Size = new Size(0, 15);
            lblVertical.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // documentPanel
            // 
            documentPanel.AutoScroll = true;
            documentPanel.Controls.Add(richTextBox1);
            documentPanel.Controls.Add(statusStrip1);
            documentPanel.Location = new Point(0, 27);
            documentPanel.Name = "documentPanel";
            documentPanel.Size = new Size(888, 423);
            documentPanel.TabIndex = 5;
            documentPanel.Paint += documentPanel_Paint;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(46, 83);
            richTextBox1.MaximumSize = new Size(794, 1123);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(794, 1123);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.KeyDown += richTextBox1_KeyDown;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tSStatusPageof, tSStatusWord, tSStatusLanguage });
            statusStrip1.Location = new Point(0, 1206);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(871, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // tSStatusPageof
            // 
            tSStatusPageof.Name = "tSStatusPageof";
            tSStatusPageof.Padding = new Padding(15, 0, 10, 0);
            tSStatusPageof.Size = new Size(72, 17);
            tSStatusPageof.Text = "Page of";
            // 
            // tSStatusWord
            // 
            tSStatusWord.Name = "tSStatusWord";
            tSStatusWord.Padding = new Padding(0, 0, 10, 0);
            tSStatusWord.Size = new Size(46, 17);
            tSStatusWord.Text = "Word";
            // 
            // tSStatusLanguage
            // 
            tSStatusLanguage.Name = "tSStatusLanguage";
            tSStatusLanguage.Padding = new Padding(0, 0, 10, 0);
            tSStatusLanguage.Size = new Size(69, 17);
            tSStatusLanguage.Text = "Language";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 450);
            Controls.Add(rulerVertical);
            Controls.Add(rulerHorizontal);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(documentPanel);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(904, 489);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            rulerHorizontal.ResumeLayout(false);
            rulerHorizontal.PerformLayout();
            rulerVertical.ResumeLayout(false);
            rulerVertical.PerformLayout();
            documentPanel.ResumeLayout(false);
            documentPanel.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tSMenuFile;
        private ToolStripMenuItem tSMenuHome;
        private ToolStripMenuItem tSMenuInsert;
        private ToolStripMenuItem tsMenuDesign;
        private ToolStripMenuItem tSMenuLayout;
        private ToolStripMenuItem tSMenuReferences;
        private ToolStripMenuItem tSMenuMailing;
        private ToolStripComboBox toolStripComboBox2;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem tSMenuSave;
        private ToolStripMenuItem tSMenuRedo;
        private ToolStripMenuItem tSMenuUndo;
        private ToolStripMenuItem tSMenuColorText;
        private ToolStripMenuItem tSMenuA;
        private ToolStripMenuItem tSMenuBrush;
        private ToolStripMenuItem tsMenuBgColor;
        private ToolStripComboBox tSCFontSize;
        private ToolStripMenuItem tSMenuView;
        private ToolStripMenuItem tSMenuIdea;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem toolStripMenuItem15;
        private ToolStripMenuItem tSMenuSignIn;
        private ToolStripMenuItem tSMenuShare;
        private Panel rulerHorizontal;
        private Label lblHorizontal;
        private Panel rulerVertical;
        private Label label1;
        private Label lblVertical;
        private Panel documentPanel;
        private RichTextBox richTextBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tSStatusPageof;
        private ToolStripStatusLabel tSStatusWord;
        private ToolStripStatusLabel tSStatusLanguage;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem TSDMenuNew;
        private ToolStripMenuItem tSDMenuOpen;
        private ToolStripMenuItem tSDMenuSave;
        private ToolStripMenuItem tSDMenuSaveAs;
        private ToolStripMenuItem tSDMenuClose;
        private ToolStripMenuItem tSDMenuExit;
        private ToolStripMenuItem tSDMenuMargin;
        private ToolStripMenuItem narrowToolStripMenuItem;
        private ToolStripMenuItem moderateToolStripMenuItem;
        private ToolStripMenuItem wideToolStripMenuItem;
        private ToolStripMenuItem mirroredToolStripMenuItem;
        private ToolStripMenuItem office2003DefaultToolStripMenuItem;
        private ToolStripMenuItem cusstomMarginToolStripMenuItem;
        private ToolStripMenuItem tSMenuFontStyle;
        private ToolStripMenuItem tsMenuFontSize;
        private ToolStripMenuItem tsMenuZoomIn;
        private ToolStripMenuItem tsMenuZoomOut;
        private ToolStripComboBox tSMenuStyle;
        private ToolStripMenuItem tSMenuBold;
        private ToolStripMenuItem tSMenuItalic;
        private ToolStripMenuItem tSMenuUnderline;
        private ToolStripMenuItem tSMenuFind;
        private ToolStripMenuItem tSMenuImage;
        private ToolStripMenuItem tSMenuEmoji;
    }
}
