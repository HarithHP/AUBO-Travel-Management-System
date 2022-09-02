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
    public partial class User : MetroFramework.Forms.MetroForm
    {
        public User()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        private void User_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hadaragama\Documents\Ayubo_Drive_Database.mdf;Integrated Security=True;Connect Timeout=30");
            populate();
        }
        private void populate()
        {
            con.Open();
            da = new SqlDataAdapter("Select * from User_table", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGridUser.DataSource = dt;
            con.Close();

        }
        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Home obj = new Home();
            obj.Show();
        }
        private void Clear()
        {
            txt_uaddress.Clear();
            txt_uid.Clear();
            txt_uname.Clear();
            txt_upw.Clear();
            txt_user_phone.Clear();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into User_table values('" + txt_uid.Text + "','" + txt_uname.Text + "','" + txt_uaddress.Text + "','" + txt_user_phone.Text + "','" + txt_upw.Text + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                populate();
                Clear();
                cmd.Dispose();

            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_uid.Text = metroGridUser.SelectedRows[0].Cells[0].Value.ToString();
            txt_uname.Text = metroGridUser.SelectedRows[0].Cells[1].Value.ToString();
            txt_uaddress.Text = metroGridUser.SelectedRows[0].Cells[2].Value.ToString();
            txt_user_phone.Text = metroGridUser.SelectedRows[0].Cells[3].Value.ToString();
            txt_upw.Text = metroGridUser.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Update User_table set user_name = '" + txt_uname.Text + "',user_address = '" + txt_uaddress.Text + "',user_phone = '" + txt_user_phone.Text + "',user_pw = '" + txt_upw.Text + "' where user_Id = '" + txt_uid.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MetroFramework.MetroMessageBox.Show(this, "Data Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroFramework.MetroMessageBox.Show(this, "Data Cannot Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                populate();
                Clear();
                cmd.Dispose();
            }
            catch (SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Delete from User_table where user_Id = '" + txt_uid.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MetroFramework.MetroMessageBox.Show(this, "Delete Data Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroFramework.MetroMessageBox.Show(this, "Data Cannot Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                populate();
                Clear();
                cmd.Dispose();
            }
            catch (SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
