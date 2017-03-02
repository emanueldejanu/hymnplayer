using System;
using System.Drawing;
using System.Windows.Forms;
using HymnPlayer.Models;

namespace HymnPlayer
{
    public partial class PlayerForm : Form
    {
        private int currentVerse = 0;

        private string[] verses;

        public PlayerForm()
        {
            InitializeComponent();
            verses = new[] {"No verse"};
        }

        public PlayerForm(Hymn hymn)
            : this()
        {
            verses = new string[hymn.Verses.Count + 1];
            verses[0] = "Imnul " + hymn.Number + "\n" + hymn.Title;
            int index = 1;
            foreach (var verse in hymn.Verses)
            {
                verses[index++] = verse.Text;
            }
        }

        private void UpdateText()
        {
            lblText.Text = verses[currentVerse];
        }

        private Font CalculateFontSize(string text)
        {
            lblText.Text = text;
            lblText.AutoSize = true;
            Font currentFont = Font;
            for (int i = 16; i < 1000; i += 2)
            {
                Font textFont = new Font(currentFont.Name, i, currentFont.Style);
                lblText.Font = textFont;
                if (lblText.Width > Width || lblText.Height > Height)
                    break;
                currentFont = textFont;
            }
            return currentFont;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (currentVerse > 0)
                {
                    currentVerse--;
                    lblText.BackgroundImage = null;
                    UpdateText();
                }
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Space)
            {
                if (currentVerse + 1 < verses.Length)
                {
                    currentVerse++;
                    UpdateText();
                }
                else if (currentVerse + 1 == verses.Length)
                {
                    currentVerse++;
                    lblText.Text = "";
                    lblText.BackgroundImage = Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\Lighthouse.jpg");
                    lblText.BackgroundImageLayout = ImageLayout.Center;
                }
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            lblText.Visible = false;
            Font currentFont = null;
            foreach (var verse in verses)
            {
                var calculatedFont = CalculateFontSize(verse);
                if (currentFont == null || calculatedFont.Size < currentFont.Size)
                    currentFont = calculatedFont;
            }
            lblText.AutoSize = false;
            lblText.Text = verses[currentVerse];
            lblText.Font = currentFont ?? Font;
            lblText.Top = 0;
            lblText.Left = 0;
            lblText.Width = Width;
            lblText.Height = Height;
            lblText.Visible = true;
        }
    }
}
