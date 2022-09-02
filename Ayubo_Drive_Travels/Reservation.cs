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
    public partial class Reservation : MetroFramework.Forms.MetroForm
    {
        public Reservation()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        private void Reservation_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hadaragama\Documents\Ayubo_Drive_Database.mdf;Integrated Security=True;Connect Timeout=30");
            populate();
        }
        private void populate()
        {
            con.Open();
            da = new SqlDataAdapter("Select * from Vehicles_table", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGridVehicles.DataSource = dt;
            con.Close();

        }
        private void Clear()
        {
            txt_cname.Clear();
            txt_phone.Clear();
            txt_rid.Clear();
            txt_vid.Clear();
            txt_nic.Clear();
            combo_vc.SelectedIndex = -1;
            combo_rentcato.SelectedIndex = -1;
            dtp_rentd.Value = DateTime.Now;

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

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into Reservation_table values('" + txt_rid.Text + "','" + txt_cname.Text + "','" + txt_phone.Text + "','" + txt_nic.Text + "','" + combo_vc.SelectedItem + "','" + txt_vid.Text + "','" + dtp_rentd.Value + "','"+ combo_rentcato.SelectedItem +"')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                Clear();
                cmd.Dispose();

            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGridVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_vid.Text = metroGridVehicles.SelectedRows[0].Cells[0].Value.ToString();
            combo_vc.SelectedItem = metroGridVehicles.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Delete from Reservation_table where vehi_Id = '" + txt_vid.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MetroFramework.MetroMessageBox.Show(this, "Delete Data Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroFramework.MetroMessageBox.Show(this, "Data Cannot Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
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
