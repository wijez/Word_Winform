using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniWord_Viet
{
    internal class MarginHandler
    {
        private readonly RichTextBox _richTextBox;
        private PageSettings _pageSettings;

        // Constructor nhận RichTextBox để thao tác
        public MarginHandler(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
            _pageSettings = new PageSettings();
        }

        // Các preset margins
        private readonly Margins NarrowMargins = new Margins(50, 50, 50, 50);        // 0.5 inch
        private readonly Margins ModerateMargins = new Margins(100, 100, 100, 100);  // 1.0 inch
        private readonly Margins WideMargins = new Margins(200, 200, 200, 200);      // 2.0 inch
        private readonly Margins MirroredMargins = new Margins(150, 100, 100, 100);  // Left wider for binding

        // Phương thức xử lý narrow margins
        public void ApplyNarrowMargins()
        {
            try
            {
                _pageSettings.Margins = NarrowMargins;
                UpdateDocumentMargins(NarrowMargins);
                ShowSuccessMessage("Narrow margins applied successfully.");
            }
            catch (Exception ex)
            {
                HandleError("Error applying narrow margins", ex);
            }
        }

        // Phương thức xử lý moderate margins
        public void ApplyModerateMargins()
        {
            try
            {
                _pageSettings.Margins = ModerateMargins;
                UpdateDocumentMargins(ModerateMargins);
                ShowSuccessMessage("Moderate margins applied successfully.");
            }
            catch (Exception ex)
            {
                HandleError("Error applying moderate margins", ex);
            }
        }

        // Phương thức xử lý wide margins
        public void ApplyWideMargins()
        {
            try
            {
                _pageSettings.Margins = WideMargins;
                UpdateDocumentMargins(WideMargins);
                ShowSuccessMessage("Wide margins applied successfully.");
            }
            catch (Exception ex)
            {
                HandleError("Error applying wide margins", ex);
            }
        }

        // Phương thức xử lý mirrored margins
        public void ApplyMirroredMargins()
        {
            try
            {
                _pageSettings.Margins = MirroredMargins;
                UpdateDocumentMargins(MirroredMargins);
                ShowSuccessMessage("Mirrored margins applied successfully.");
            }
            catch (Exception ex)
            {
                HandleError("Error applying mirrored margins", ex);
            }
        }

        // Phương thức xử lý Office 2003 Default margins
        public void ApplyOffice2003DefaultMargins()
        {
            try
            {
                var office2003Margins = new Margins(72, 72, 72, 72); // 1 inch margins
                _pageSettings.Margins = office2003Margins;
                UpdateDocumentMargins(office2003Margins);
                ShowSuccessMessage("Office 2003 default margins applied successfully.");
            }
            catch (Exception ex)
            {
                HandleError("Error applying Office 2003 default margins", ex);
            }
        }

        // Phương thức xử lý custom margins
        public void ApplyCustomMargins()
        {
            try
            {
                using (var customMarginDialog = new CustomMarginDialog(_pageSettings.Margins))
                {
                    if (customMarginDialog.ShowDialog() == DialogResult.OK)
                    {
                        var customMargins = customMarginDialog.GetCustomMargins();
                        _pageSettings.Margins = customMargins;
                        UpdateDocumentMargins(customMargins);
                        ShowSuccessMessage("Custom margins applied successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                HandleError("Error applying custom margins", ex);
            }
        }

        // Phương thức cập nhật margins cho document
        private void UpdateDocumentMargins(Margins margins)
        {
            if (_richTextBox != null)
            {
                // Convert margins from hundredths of an inch to pixels
                float dpi = 96.0f; // Màn hình Windows thường dùng 96 DPI
                int leftMargin = (int)(margins.Left * dpi / 100);
                int rightMargin = (int)(margins.Right * dpi / 100);

                _richTextBox.SelectAll();
                _richTextBox.SelectionIndent = leftMargin;
                _richTextBox.SelectionRightIndent = rightMargin;
                _richTextBox.SelectionLength = 0; // Bỏ chọn text
            }
        }

        // Hiển thị thông báo thành công
        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Xử lý lỗi
        private void HandleError(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Custom Dialog để nhập margin tùy chỉnh
    public class CustomMarginDialog : Form
    {
        private NumericUpDown nudLeft, nudRight, nudTop, nudBottom;
        private Button btnOK, btnCancel;
        private Margins currentMargins;

        public CustomMarginDialog(Margins margins)
        {
            currentMargins = margins;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Size = new Size(300, 200);
            this.Text = "Custom Margins";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;

            // Create controls
            var lblLeft = new Label() { Text = "Left Margin:", Location = new Point(10, 20) };
            var lblRight = new Label() { Text = "Right Margin:", Location = new Point(10, 50) };
            var lblTop = new Label() { Text = "Top Margin:", Location = new Point(10, 80) };
            var lblBottom = new Label() { Text = "Bottom Margin:", Location = new Point(10, 110) };

            nudLeft = new NumericUpDown()
            {
                Location = new Point(120, 20),
                Minimum = 0,
                Maximum = 1000,
                Value = currentMargins.Left
            };

            nudRight = new NumericUpDown()
            {
                Location = new Point(120, 50),
                Minimum = 0,
                Maximum = 1000,
                Value = currentMargins.Right
            };

            nudTop = new NumericUpDown()
            {
                Location = new Point(120, 80),
                Minimum = 0,
                Maximum = 1000,
                Value = currentMargins.Top
            };

            nudBottom = new NumericUpDown()
            {
                Location = new Point(120, 110),
                Minimum = 0,
                Maximum = 1000,
                Value = currentMargins.Bottom
            };

            btnOK = new Button()
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Location = new Point(70, 140)
            };

            btnCancel = new Button()
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Location = new Point(150, 140)
            };

            // Add controls to form
            this.Controls.AddRange(new Control[]
            {
            lblLeft, lblRight, lblTop, lblBottom,
            nudLeft, nudRight, nudTop, nudBottom,
            btnOK, btnCancel
            });
        }

        public Margins GetCustomMargins()
        {
            return new Margins(
                (int)nudLeft.Value,
                (int)nudRight.Value,
                (int)nudTop.Value,
                (int)nudBottom.Value
            );
        }
    }
}
