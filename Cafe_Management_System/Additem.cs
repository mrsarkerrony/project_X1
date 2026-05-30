using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Additem : Form
    {
        public Additem()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (itembox.Text == "" || categorybox.Text == "" || pricebox.Text == "")
            {
                MessageBox.Show("Please Fill All Fields");
                return;
            }
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DR10NJP\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True;");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO item (name, category, price) VALUES (@name, @category, @price)", con);
                cmd.Parameters.AddWithValue("@name", itembox.Text);
                cmd.Parameters.AddWithValue("@category", categorybox.Text);
                cmd.Parameters.AddWithValue("@price", pricebox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Add Success");
                ClearAll();
            }

            catch 
            {

                MessageBox.Show("error...");
            }

        }
       


        
        
        

        public void ClearAll()
        {
            categorybox.SelectedIndex = -1;
            itembox.Clear();
            pricebox.Clear();
        }

        private void Additem_Load(object sender, EventArgs e)
        {

        }
    }
}
