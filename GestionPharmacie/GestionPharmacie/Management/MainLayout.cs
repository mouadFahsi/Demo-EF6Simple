using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPharmacie
{
    public partial class MainLayout : Form
    {
        public MainLayout()
        {
            InitializeComponent();
            //fullscrean
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new Point(0, 0);
            this.Size = SystemInformation.PrimaryMonitorSize;

            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Login l = new Login();
            //panel1.Controls.Clear();
            //l.TopLevel = false;
            //l.AutoScroll = false;
            //panel1.Controls.Add(l);
            //l.Show();
            //l.Location = new Point(600, 175);

            //panel1.Dock = DockStyle.Fill;
            //WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel3.Visible = false;
            flowLayoutPanel4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel3.Visible = true;
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel4.Visible = true;
            flowLayoutPanel3.Visible = false;
            flowLayoutPanel2.Visible = false;
        }
    }
}
