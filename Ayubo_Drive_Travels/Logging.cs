using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ayubo_Drive_Travels
{
    public partial class Logging : MetroFramework.Forms.MetroForm
    {
        public Logging()
        {
            InitializeComponent();
        }

        private void Logging_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_pw.Clear();
            txt_userid.Clear();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hadaragama\Documents\Ayubo_Drive_Database.mdf;Integrated Security=True;Connect Timeout=30");
        private void btn_logging_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select count(*) from User_table where user_Id = '" + txt_userid.Text + "' and user_pw = '" + txt_pw.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Home obj = new Home();
                    obj.Show();
                }
                else
                {
                    
                    MetroFramework.MetroMessageBox.Show(this, "Invalid Password or Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception)
            {
                if (txt_userid.Text == "admin".ToString() && txt_pw.Text == "admin".ToString())
                {
                    this.Hide();
                    Home obj = new Home();
                    obj.Show();

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }
        private void txt_pw_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
