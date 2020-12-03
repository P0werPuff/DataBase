﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\Tooded.mdf; Integrated Security = True");
        SqlCommand command;
        SqlDataAdapter adapter;
        int Id = 0;
        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            connect.Open();
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Toodetable", connect);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connect.Close();

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (Toodetxt.Text != "" && Kogustxt.Text != "" && Hindtxt.Text != "") 
            {
                command = new SqlCommand("UPDATE Toodetable SET +" +
                    "ToodeNimetus=@toode, Kogus=@koogus, Hind=@hind WHERE Id=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@toode", Toodetxt.Text);
                command.Parameters.AddWithValue("@kogus", Kogustxt.Text);
                command.Parameters.AddWithValue("@hind", Hindtxt.Text);
                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed uuendatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }
            
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Toodetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Kogustxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Hindtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void ClearData()
        {
            Id = 0;
            Toodetxt.Text = "";
            Kogustxt.Text = "";
            Hindtxt.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toodedDataSet.Toodetable' table. You can move, or remove it, as needed.
            this.toodetableTableAdapter.Fill(this.toodedDataSet.Toodetable);

        }
    }
}
