using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tri_Cast_Video_Converter
{
    public partial class LicenseForm : Form
    {
        public LicenseForm()
        {
            InitializeComponent();
            InitializeLicenseText();
            this.FormClosing += LicenseForm_FormClosing;
        }

        private void InitializeLicenseText()
        {
            string licenseText = "License Agreement:\n\n" +
                "By using this software, you agree to the terms of the GNU General Public License, " +
                "available at <https://www.gnu.org/licenses/>.\n\n" +
                "Click the link above to view the full license.";

            richTextBoxLicense.Text = licenseText;
            richTextBoxLicense.ReadOnly = true;
            richTextBoxLicense.Font = new Font("Segoe UI", 10);
            richTextBoxLicense.ForeColor = Color.Black;
            richTextBoxLicense.BackColor = SystemColors.Window;
            richTextBoxLicense.Dock = DockStyle.Fill;
            richTextBoxLicense.MouseClick += RichTextBoxLicense_MouseClick;
        }

        private void RichTextBoxLicense_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int index = richTextBoxLicense.GetCharIndexFromPosition(e.Location);
                if (index >= 0)
                {
                    string url = GetUrlFromText(richTextBoxLicense.Text, index);
                    if (!string.IsNullOrEmpty(url))
                    {
                        System.Diagnostics.Process.Start(url);
                    }
                }
            }
        }

        private string GetUrlFromText(string text, int index)
        {
            int start = text.LastIndexOf("<", index);
            int end = text.IndexOf(">", index);
            if (start >= 0 && end > start)
            {
                return text.Substring(start + 1, end - start - 1);
            }
            return null;
        }

        private void LicenseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                e.Cancel = true; // Prevent closing unless "I Accept" is clicked
            }
        }

        private void buttonAccept_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
