using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace MiniWord_Viet
{
    internal class DocumentManager
    {
        private RichTextBox richTextBox;
        private string currentFilePath;

        public DocumentManager(RichTextBox richTextBox)
        {
            this.richTextBox = richTextBox;
        }
        public void NewDocument()
        {
            if (HasUnsavedChanges() && PromptSaveChanges())
            {
                SaveDocument();
            }
            richTextBox.Clear();
            currentFilePath = null;
        }

        public void OpenDocument()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Open File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName;
                    richTextBox.Text = File.ReadAllText(currentFilePath);
                    ShowMessage("File opened successfully.", "Open");
                }
            }
        }

        public void SaveDocument()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveDocumentAs();
            }
            else
            {
                File.WriteAllText(currentFilePath, richTextBox.Text);
                ShowMessage("File saved successfully.", "Save");
            }
        }

        public void SaveDocumentAs()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Document (*.docx)|*.docx|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "docx";
                saveFileDialog.Title = "Save As";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    File.WriteAllText(currentFilePath, richTextBox.Text);
                    ShowMessage("File saved successfully.", "Save As");
                }
            }
        }

        public void CloseDocument()
        {
            if (HasUnsavedChanges() && PromptSaveChanges())
            {
                SaveDocument();
            }
            richTextBox.Clear();
            currentFilePath = null;
        }

        private bool HasUnsavedChanges()
        {
            return !string.IsNullOrEmpty(richTextBox.Text);
        }

        private bool PromptSaveChanges()
        {
            return MessageBox.Show("Do you want to save changes?", "Save Changes",
                MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
}
}
