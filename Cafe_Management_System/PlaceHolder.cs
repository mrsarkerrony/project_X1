using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Cafe_Management_System
{
    public partial class PlaceHolder : Form
    {
        public PlaceHolder()
        {
            InitializeComponent();
        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DR10NJP\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True;");

            con.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT name FROM item WHERE category=@category",
                con
            );

            cmd.Parameters.AddWithValue("@category", combobox.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            listView1.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listView1.Items.Add(dt.Rows[i]["name"].ToString());
            }

            con.Close();

        }

        private void PlaceHolder_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(
        @"Data Source=DESKTOP-DR10NJP\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True;"
    );

            con.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT DISTINCT category FROM item",
                con
            );

            SqlDataReader reader = cmd.ExecuteReader();

            combobox.Items.Clear();

            while (reader.Read())
            {
                combobox.Items.Add(reader["category"].ToString());
            }

            reader.Close();
            con.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DR10NJP\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True;");

            con.Open();

            SqlCommand cmd = new SqlCommand( "SELECT name FROM item WHERE category=@category and name like @name", con);

            cmd.Parameters.AddWithValue("@category", combobox.Text);
            cmd.Parameters.AddWithValue("@name", guna2TextBox1.Text + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            listView1.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listView1.Items.Add(dt.Rows[i]["name"].ToString());
            }

            con.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantitybox.ResetText();
            totalbox.Clear();

            if (listView1.SelectedItems.Count > 0)
            {
                string text = listView1.SelectedItems[0].Text;
                itembox.Text = text;
            }


            if (listView1.SelectedItems.Count > 0)
            {


                string itemName = listView1.SelectedItems[0].Text;
                itembox.Text = itemName;


                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DR10NJP\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True;");

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT price FROM item WHERE name=@name", con);

                cmd.Parameters.AddWithValue("@name", itemName);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    pricebox.Text = reader["price"].ToString();
                }

                reader.Close();
                con.Close();

            }
        }

        private void quantitybox_ValueChanged(object sender, EventArgs e)
        {
            if (pricebox.Text != "")
            {
                int price = Convert.ToInt32(pricebox.Text);
                int quantity = Convert.ToInt32(quantitybox.Value);

                int total = price * quantity;

                totalbox.Text = total.ToString();
            }
        }
        protected int n, total = 0;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (itembox.Text != "" && pricebox.Text != "" && totalbox.Text != "")
            {
                int row = guna2DataGridView1.Rows.Add();

                guna2DataGridView1.Rows[row].Cells[0].Value = itembox.Text;
                guna2DataGridView1.Rows[row].Cells[1].Value = pricebox.Text;
                guna2DataGridView1.Rows[row].Cells[2].Value = quantitybox.Value.ToString();
                guna2DataGridView1.Rows[row].Cells[3].Value = totalbox.Text;


                total += Convert.ToInt32(totalbox.Text);
                label7.Text = "TK/- " + total;


                itembox.Clear();
                pricebox.Clear();
                totalbox.Clear();
                quantitybox.Value = 1;

                
            }
            else
            {
                MessageBox.Show("Please select an item first!");
            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = guna2DataGridView1.SelectedRows[0].Index;

                
                int itemTotal = Convert.ToInt32( guna2DataGridView1.SelectedRows[0].Cells[3].Value);

                
                total -= itemTotal;
                label7.Text = "TK/- " + total;

                guna2DataGridView1.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to remove!");
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                guna2DataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void printbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
