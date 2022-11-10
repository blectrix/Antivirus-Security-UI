using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blecrix_Protection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stat1.Visible = true;
            security1.Visible = false;
            privacy1.Visible = false;
            performance1.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            stat1.Visible = false;
            security1.Visible = true;
            privacy1.Visible = false;
            performance1.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            stat1.Visible = false;
            security1.Visible = false;
            privacy1.Visible = true;
            performance1.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            stat1.Visible = false;
            security1.Visible = false;
            privacy1.Visible = false;
            performance1.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            stat1.Visible = true;
            security1.Visible = false;
            privacy1.Visible = false;
            performance1.Visible = false;
        }
    }
}
 