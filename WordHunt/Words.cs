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

namespace WordHunt
{
    public partial class Words : Form
    {
        int id = 0;
        public Words()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-KB4N4TR;Initial Catalog=DbDictionary;Integrated Security=True");

        private void showWords()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from Words order by EnglishWord", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = read["WordId"].ToString();
                item.SubItems.Add(read["EnglishWord"].ToString());
                item.SubItems.Add(read["TurkishWord"].ToString());
                item.SubItems.Add(read["WordDate"].ToString());
                item.SubItems.Add(read["WordStatus"].ToString());
                listView1.Items.Add(item);
            }
            con.Close();
        }

        private void Words_Load(object sender, EventArgs e)
        {
            showWords();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into Words (EnglishWord, TurkishWord, WordDate, WordStatus) Values ('"+ txtEnglish.Text +"', '" + txtTurkish.Text + "', '" + DateTime.Now.ToString() + "', 1)", con);
            command.ExecuteNonQuery();
            con.Close();
            listView1.Items.Clear();
            showWords();
            txtId.Clear();
            txtEnglish.Clear();
            txtTurkish.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("Delete from Words where WordId=" + txtId.Text, con);
            command.ExecuteNonQuery();
            con.Close();
            listView1.Items.Clear();
            showWords();
            txtId.Clear();
            txtEnglish.Clear();
            txtTurkish.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtId.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtEnglish.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtTurkish.Text = listView1.SelectedItems[0].SubItems[2].Text;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("Update Words set EnglishWord='" + txtEnglish.Text +"', TurkishWord='" + txtTurkish.Text + "'where WordId=" + txtId.Text, con);
            command.ExecuteNonQuery();
            con.Close();
            listView1.Items.Clear();
            showWords();
            txtId.Clear();
            txtEnglish.Clear();
            txtTurkish.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("Update Words set WordStatus=0 where WordId=" + txtId.Text, con);
            command.ExecuteNonQuery();
            con.Close();
            listView1.Items.Clear();
            showWords();
            txtId.Clear();
            txtEnglish.Clear();
            txtTurkish.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("Update Words set WordStatus=1 where WordId=" + txtId.Text, con);
            command.ExecuteNonQuery();
            con.Close();
            listView1.Items.Clear();
            showWords();
            txtId.Clear();
            txtEnglish.Clear();
            txtTurkish.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void txtId_Enter(object sender, EventArgs e)
        {
        }

        private void txtEnglish_Enter(object sender, EventArgs e)
        {
        }

        private void txtEnglish_Leave(object sender, EventArgs e)
        {
        }

        private void txtTurkish_Enter(object sender, EventArgs e)
        {
        }

        private void txtTurkish_Leave(object sender, EventArgs e)
        {
        }
    }
}
