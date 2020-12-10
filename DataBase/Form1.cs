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
        SqlDataAdapter adapter, adapter2;
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
            pictureBox1.Image = Image.FromFile("../../Image/list.png");
            con.Close();
            con.Open();

            adapter2 = new SqlDataAdapter("SELECT Kategooria_nimetus FROM Kategooria", con);
            DataTable kat_tabel = new DataTable();
            adapter2.Fill(kat_tabel);
            foreach(DataRow row in kat_tabel.Rows)
            {
                comboBox1.Items.Add(row["Kategooria_nimetus"]);
            }

            string sqlExpression = "SELECT PictureStr FROM Toodetable";

            SqlCommand command = new SqlCommand(sqlExpression, con);
            int PhotoWay = command.ExecuteNonQuery();
            Console.WriteLine("Добавлено объектов: {0}", PhotoWay);

            con.Close();
        }
        private void ClearData()
        {
            Id = 0;
            Toodetxt.Text = "";
            Kogustxt.Text = "";
            Hindtxt.Text = "";
            pictureBox1.Image = Image.FromFile("../../Image/list.png");

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (Toodetxt.Text != "" && Kogustxt.Text != "" && Hindtxt.Text != "" && comboBox1.SelectedItem != "")
            {
                cmd = new SqlCommand("INSERT INTO Toodetable(ToodeNimetus,Kogus,Hind,Kategooria_nimetus) SET Toodenimetus=@toode,Kogus=@kogus,Hind=@hind where Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@toode", Toodetxt.Text);
                cmd.Parameters.AddWithValue("@kogus", Kogustxt.Text);
                cmd.Parameters.AddWithValue("@hind", Hindtxt.Text);
                string file_pilt = Toodetxt + ".jpg";
                cmd.Parameters.AddWithValue("@pilt", file_pilt);
                cmd.Parameters.AddWithValue("@kat", (comboBox1.SelectedItem));
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
                cmd.Parameters.AddWithValue("@hind", Hindtxt.Text.Replace(',', '.'));
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andme on lisatud");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Toodetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Kogustxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Hindtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            pictureBox1.Image = Image.FromFile(@"..\..C:\Users\opilane\source\repos\Tooded\Images" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            string v = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox1.SelectedIndex = Int32.Parse(v);
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
            if (Id != 0)
            {
                cmd = new SqlCommand("delete ToodeTable where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void btn_LisaPilt_Click_1(object sender, EventArgs e) //
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.InitialDirectory = Path.GetFullPath(@"C:\Users\opilane\Images");
            ofg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofg.ShowDialog() == DialogResult.OK)
            {
                ofg = new SaveFileDialog();
                ofg.FileName = Toodetxt + ".jpg";
                ofg.Filter = "Image Files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                ofg.InitialDirectory = Path.GetFullPath(@"C:\Users\opilane\source\repos\Tooded\Images");

                if(ofg.ShowDialog()==DialogResult.OK)
                {
                    File.Copy(open.FileName, ofg.FileName);
                    ofg.RestoreDirectory = true;
                    pictureBox1.Image = Image.FromFile(ofg.FileName);
                }
            }
        }
    }
}
