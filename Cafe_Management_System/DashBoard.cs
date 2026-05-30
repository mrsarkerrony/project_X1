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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        public DashBoard(string user)
        {
            InitializeComponent();

            if(user== "Guest")
            {
                btnAdd.Hide();
                btnRemove.Hide();
                btnUpdate.Hide();
            }
            else if(user== "Admin")
            {
                btnAdd.Show();
                btnRemove.Show();
                btnUpdate.Show();
            }
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            PlaceHolder ph = new PlaceHolder();
            ph.TopLevel = false;
            panel2.Controls.Add(ph);
            ph.BringToFront();
            ph.Show();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Additem ad = new Additem();
            ad.TopLevel = false;
            panel2.Controls.Add(ad);
            ad.BringToFront();
            ad.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.TopLevel = false;
            panel2.Controls.Add(u);
            u.BringToFront();
            u.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove u = new Remove();
            u.TopLevel = false;
            panel2.Controls.Add(u);
            u.BringToFront();
            u.Show();
        }
    }
}
