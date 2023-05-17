using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esari_app
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void signInbackground1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            signInBackground.Show();
            signInBackground.BringToFront();
            signInForm1.Show();
            signInForm1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
