using Microsoft.Data.SqlClient;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.AxHost;

namespace WinFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bussinessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Create the new form object (renamed variable to 'form' for clarity)
            BizContacts form = new BizContacts();

            form.MdiParent = this;

            // 3. Show the specific form instance
            form.Show();
        }
        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Your click code goes here
            LayoutMdi(MdiLayout.Cascade);
        }
        private void titleVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void titleHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Any code placed here runs right when the app starts up
        }



    }
}
