using Diziler.Common;
using System;
using System.Windows.Forms;

namespace Diziler.AppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            var textHelper = new TextHelper();
            var count = textHelper.GetNumberOfLetters(txtLyric.Text, Convert.ToChar(txtLetter.Text));
            lblCount.Text = count.ToString();
        }
    }
}
