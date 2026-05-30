using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            

            AdminLogIn a = new AdminLogIn();
            a.TopLevel = false;
            panel2.Controls.Add(a);
            a.BringToFront();
            a.Show();

        }

        private void guestbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            PlaceHolder a = new PlaceHolder();
            a.TopLevel = false;
            panel2.Controls.Add(a);
            a.BringToFront();
            a.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (Control c in panel2.Controls)
            {
                if (c is Form)
                {
                    c.Dispose(); 
                    break;
                }
            }

            panel2.BringToFront();
            panel2.Show();
        }
    }
}
