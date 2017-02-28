using System;
using System.Drawing;
using System.Windows.Forms;

namespace HymnPlayer
{
    public partial class PlayerForm : Form
    {
        private int currentVerse = 0;

        private string[] verses = new[]
        {
            "Imnul 1\nPlecaţi-vă lui Dumnezeu!",
            "1. Plecaţi-vă lui Dumnezeu,   \nPopoare-oriunde vă găsiţi;  \nEl ni L-a dat pe Fiul Său,\nCunoaşteţi-L şi Îi serviţi!",
            "2. Veniţi ’nainte-I mulţumind!\nEl ne-a făcut, nu singuri, noi\nŞi, când umblam noi rătăcind,\nLa turma Lui ne-aduse-apoi.",
            "3. Suntem popor sub mâna Lui,\nCu trup şi suflet siguri stăm,\nDacă nu Lui, atuncea cui,\nCântarea noastră să ’nălţăm?",
            "4. Cât lumea e cuprinsul Său,\nStatornic e-n cuvânt şi har!\nEl este-al nostru Dumnezeu\nIubire fără de hotar!"
        };

        public PlayerForm()
        {
            InitializeComponent();
        }

        private void UpdateText()
        {
            lblText.Font = CalculateFontSize(verses[currentVerse]);
            lblText.AutoSize = false;
            lblText.Top = 0;
            lblText.Left = 0;
            lblText.Width = Width;
            lblText.Height = Height;
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
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            UpdateText();
        }
    }
}
