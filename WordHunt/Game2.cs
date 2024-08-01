using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WordHunt
{
    public partial class Game2 : Form
    {
        int point = 0;
        int time = 100;
        int rekor = 0;
        public Game2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KB4N4TR;Initial Catalog=DbDictionary;Integrated Security=True");

        private void ShowSkors()
        {
            con.Open();
            SqlCommand command = new SqlCommand("Select *from Skor order by Skor DESC", con);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["Skor"].ToString();
                listView1.Items.Add(item);
            }
            con.Close();
        }

        private void ShowWord()
        {
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select TOP 1 *FROM Words where WordStatus=1 ORDER BY NEWID()";
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                lblWord.Text += data["EnglishWord"];
                lblTrueAnswer.Text += data["TurkishWord"];
            }
            con.Close();

        }


        private void Game2_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT TurkishWord FROM Words where WordStatus=1", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }
            txtUserAnswer.AutoCompleteCustomSource = MyCollection;
            con.Close();

            lblRekor.Text = rekor.ToString();
            lblRekor.Text = "";

            con.Open();
            SqlCommand command = new SqlCommand("Select TOP 1 *from Skors order by Skor DESC", con);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                lblRekor.Text += data["Skor"];
            }
            con.Close();

            lblTrueAnswer.Visible = false;
            pictureBox1.Visible = false;
            picTrueFalse.Visible = false;
            btnPas.Enabled = false;
            btnTrueFalse.Enabled = false;
            btnOk.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            time = 100;
            point = 0;
            lblPuan.Text = point.ToString();
            txtUserAnswer.Focus();
            btnOk.Enabled = true;
            btnStart.Enabled = false;
            btnBack.Enabled = false;
            lblTrueAnswer.Text = "";
            lblWord.Text = "";
            txtUserAnswer.Text = "";
            SqlCommand command = new SqlCommand();
            con.Open();
            
            command.Connection = con;
            command.CommandText = "select TOP 1 *FROM Words where WordStatus=1 ORDER BY NEWID()";
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                lblWord.Text += data["EnglishWord"];
                lblTrueAnswer.Text += data["TurkishWord"];
            }
            con.Close();

            lblTrueAnswer.Visible = false;
            btnPas.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = time.ToString();
            
            if (time == 0)
            {
                btnStart.Text = "Tekrar Başla";
                btnStart.Enabled = true;
                btnBack.Enabled = true;
                btnPas.Enabled = false;
                btnOk.Enabled = false;
                timer1.Stop();
                time = 100;
                barTime.Value = 100;
                MessageBox.Show(point.ToString(), "Puan");
                rekor = Convert.ToInt32(lblRekor.Text);
                if (point >= rekor)
                {
                    lblRekor.Text = "";
                    listView1.Items.Clear();
                    con.Open();
                    SqlCommand command = new SqlCommand("insert into Skors (ProfileId, Skor) Values (1, '" + lblPuan.Text + "')", con);
                    command.ExecuteNonQuery();
                    
                    SqlCommand command2 = new SqlCommand();
                    command2.Connection = con;
                    command2.CommandText = "Select TOP 1 *from Skors order by Skor DESC";
                    SqlDataReader data = command.ExecuteReader();
                    while (data.Read())
                    {
                        lblRekor.Text += data["Skor"];
                    }
                    con.Close();
                    lblRekor.Text = point.ToString();
                }
                point = 0;
            }

            else
            {
                time--;
                barTime.Value--;
                lblTime.Text = time.ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == "Devam et")
            {
                lblWord.Text = "";
                lblTrueAnswer.Text = "";
                ShowWord();
                lblTrueAnswer.Visible = false;
                btnOk.Text = "Tamam";
                pictureBox1.Visible = false;
                picTrueFalse.Visible = false;
                btnTrueFalse.BackColor = Color.White;
                txtUserAnswer.Enabled = true;
                txtUserAnswer.Clear();
                txtUserAnswer.Focus();
                btnPas.Enabled = true;
            }

            else
            {
                if (txtUserAnswer.Text.ToLower() == lblTrueAnswer.Text.ToLower())
                {
                    point++;
                    txtUserAnswer.Clear();
                    lblWord.Text = "";
                    lblTrueAnswer.Text = "";
                    ShowWord();
                    lblTrueAnswer.Visible = false;
                    btnTrueFalse.BackColor = Color.MediumSeaGreen;
                    picTrueFalse.Visible = true;
                    pictureBox1.Visible = false;
                    txtUserAnswer.Clear();
                    txtUserAnswer.Focus();
                }
                else
                {
                    point--;
                    lblTrueAnswer.Visible = true;
                    btnOk.Text = "Devam et";
                    btnTrueFalse.BackColor = Color.Red;
                    pictureBox1.Visible = true;
                    picTrueFalse.Visible = false;
                    btnPas.Enabled = false;
                    txtUserAnswer.Enabled = false;
                }

            }

            lblPuan.Text = point.ToString();
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            lblTrueAnswer.Visible = true;
            btnOk.Text = "Devam et";
            txtUserAnswer.Focus();
            btnPas.Enabled = false;
            btnTrueFalse.BackColor = Color.White;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            time = 100;
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
