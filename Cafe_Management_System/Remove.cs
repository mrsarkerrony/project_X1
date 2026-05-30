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
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DR10NJP\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True;");

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from item where name like'" + searchbox.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            guna2DataGridView1.DataSource = dt;

            con.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Remove_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DR10NJP\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True;");

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from item", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            guna2DataGridView1.DataSource = dt;

            con.Close();
        }
        string itemName = "";
        private void removebtn_Click(object sender, EventArgs e)
        {
            if (itemName != "")
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this item?",
                    "Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(
                        @"Data Source=DESKTOP-DR10NJP\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True;"
                    );

                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM item WHERE name=@name",
                        con
                    );

                    cmd.Parameters.AddWithValue("@name", itemName);

                    int delete = cmd.ExecuteNonQuery();

                    if (delete > 0)
                    {
                        MessageBox.Show("Item Removed Successfully!");
                        Remove_Load(null,null);
                    }
                    else
                    {
                        MessageBox.Show("Delete Failed!");
                    }

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select an item first!");
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                itemName = row.Cells["name"].Value.ToString();
            }
        }
    }
}
