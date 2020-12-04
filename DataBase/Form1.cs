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

namespace DataBase
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\Tooded.mdf; Integrated Security = True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        int Id = 0;
        public Form1()
        {
            InitializeComponent();
            DisplayData();
            

        }

        private void DisplayData()
        {
            con.Open();
            DataTable tabel = new DataTable();
            adapter = new SqlDataAdapter("SELECT *FROM Toodetable", con);
            adapter.Fill(tabel);
            dataGridView1.DataSource = tabel;
            con.Close();

        }
        private void ClearData()
        {
            Id = 0;
            Toodetxt.Text = "";
            Kogustxt.Text = "";
            Hindtxt.Text = "";
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (Toodetxt.Text != "" && Kogustxt.Text != "" && Hindtxt.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO Toodetable(ToodeNimetus,Kogus,Hind) SET Toodenimetus=@toode,Kogus=@kogus,Hind=@hind where Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@toode", Toodetxt.Text);
                cmd.Parameters.AddWithValue("@kogus", Kogustxt.Text);
                cmd.Parameters.AddWithValue("@hind", Hindtxt.Text.Replace());
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andme on lisatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Toodetxt.Text != "" && Kogustxt.Text != "" && Hindtxt.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO Toodetable(Toodenimetus,Kogus,Hind) VALUES (@toode,@kogus,@hind)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@toode", Toodetxt.Text);
                cmd.Parameters.AddWithValue("@kogus", Kogustxt.Text);
                cmd.Parameters.AddWithValue("@hind", Hindtxt.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andme on lisatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }
        
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Toodetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Kogustxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Hindtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            pictureBox1.Image = Image.FromFile(@"..\..C:\Users\opilane\source\repos\Tooded_DB\Images");
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the 'toodedDataSet.Toodetable' table. You can move, or remove it, as needed.
            this.toodetableTableAdapter.Fill(this.toodedDataSet.Toodetable);

        }
        

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            if (Toodetxt.Text != "" && Kogustxt.Text != "" && Hindtxt.Text != "")
            {
                cmd = new SqlCommand("DELETE Toodetable WHERE Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id); cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andme on lisatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

        private void btn_LisaPilt_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.png;*.bmp;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog()==DialogResult.OK)
            {
               
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = Toodetxt.Text + Id;
                save.Filter = "Image Files(*.jpeg;*.png;*.bmp;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
                save.ShowDialog();
                save.RestoreDirectory = true;


            }
        }
    }
}
