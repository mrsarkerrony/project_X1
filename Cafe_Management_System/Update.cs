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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DR10NJP\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True;");

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from item where name like'"+searchitembox.Text+"%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            guna2DataGridView1.DataSource = dt;

            con.Close();
        }

        private void Update_Load(object sender, EventArgs e)
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

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                itembox.Text = row.Cells["name"].Value.ToString();
                categorybox.Text = row.Cells["category"].Value.ToString();
                pricebox.Text = row.Cells["price"].Value.ToString();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(
       @"Data Source=DESKTOP-DR10NJP\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True;"
   );

            con.Open();

            SqlCommand cmd = new SqlCommand(
                "UPDATE item SET category=@category, price=@price WHERE name=@name",
                con
            );

            cmd.Parameters.AddWithValue("@name", itembox.Text);
            cmd.Parameters.AddWithValue("@category", categorybox.Text);
            cmd.Parameters.AddWithValue("@price", pricebox.Text);

            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Item Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Update Failed!");
            }

            con.Close();

            Update_Load(null, null);
        }
    }
}
