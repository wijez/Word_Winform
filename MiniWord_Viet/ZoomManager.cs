using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniWord_Viet
{
    internal class ZoomManager
    {
        
            private TrackBar zoomTrackBar;
            private ToolStripStatusLabel zoomLabel;
            private RichTextBox richTextBox;
            private StatusStrip statusStrip;

            public ZoomManager(StatusStrip statusStrip, RichTextBox richTextBox)
            {
                this.statusStrip = statusStrip;
                this.richTextBox = richTextBox;
                InitializeZoomControls();
            }

            private void InitializeZoomControls()
            {
                zoomTrackBar = new TrackBar
                {
                    Minimum = 10,
                    Maximum = 200,
                    Value = 100,
                    TickStyle = TickStyle.None,
                    Width = 100
                };
                zoomTrackBar.Scroll += ZoomTrackBar_Scroll;

                var trackBarHost = new ToolStripControlHost(zoomTrackBar);
                statusStrip.Items.Add(trackBarHost);

                zoomLabel = new ToolStripStatusLabel("100%");
                statusStrip.Items.Add(zoomLabel);
            }

            private void ZoomTrackBar_Scroll(object sender, EventArgs e)
            {
                zoomLabel.Text = $"{zoomTrackBar.Value}%";
                float zoomFactor = zoomTrackBar.Value / 100f;
                richTextBox.ZoomFactor = zoomFactor;
            }
        }

}
