using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace HymnPlayer
{
    public class CustomLabel : Label
    {
        public TextRenderingHint TextRenderingHint { get; set; } = TextRenderingHint.SystemDefault;

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pe.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            pe.Graphics.TextRenderingHint = TextRenderingHint;
            base.OnPaint(pe);
        }
    }
}