using System;
using System.Windows.Forms;

namespace kmon
{
    public partial class frmAddServer : Form
    {

        public static string strServerName;

        public frmAddServer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbServerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            strServerName = tbServerName.Text.Trim();
            this.Close();
        }
    }
}
