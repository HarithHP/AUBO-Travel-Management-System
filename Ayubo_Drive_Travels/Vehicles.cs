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
    public partial class Vehicles : MetroFramework.Forms.MetroForm
    {
        public Vehicles()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        private void Vehicles_Load(object sender, EventArgs e)
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
                cmd = new SqlCommand("insert into Vehicles_table values('" + txt_vid.Text + "','" + combo_vc.SelectedItem + "','" + txt_vb.Text + "','" + txt_vm.Text + "','" + dtp_rd.Value + "','" + txt_fee_withoutdriver.Text + "','" + txt_fee_withdriver.Text + "')", con);
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
        private void Clear()
        {
            txt_vb.Clear();
            txt_vid.Clear();
            txt_vm.Clear();
            txt_fee_withdriver.Clear();
            txt_fee_withoutdriver.Clear();
            combo_vc.SelectedIndex = -1;
            dtp_rd.Value = DateTime.Now;

        }

        private void metroGridVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_vid.Text = metroGridVehicles.SelectedRows[0].Cells[0].Value.ToString();
            combo_vc.SelectedItem = metroGridVehicles.SelectedRows[0].Cells[1].Value.ToString();
            txt_vb.Text = metroGridVehicles.SelectedRows[0].Cells[2].Value.ToString();
            txt_vm.Text = metroGridVehicles.SelectedRows[0].Cells[3].Value.ToString();
            dtp_rd.Text = metroGridVehicles.SelectedRows[0].Cells[4].Value.ToString();
            txt_fee_withoutdriver.Text = metroGridVehicles.SelectedRows[0].Cells[5].Value.ToString();
            txt_fee_withdriver.Text = metroGridVehicles.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Update Vehicles_table set vehi_cat = '" + combo_vc.SelectedItem + "',vehi_brand = '" + txt_vb.Text + "',vehi_model = '" + txt_vm.Text + "',vehi_regi_date = '" + dtp_rd.Value + "',vehi_fee_withoutdriver = '" + txt_fee_withoutdriver.Text + "' vehi_fee_withdriver = '" + txt_fee_withdriver.Text + "' where vehi_Id = '" + txt_vid.Text + "'", con);
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
                cmd = new SqlCommand("Delete from Vehicles_table where vehi_Id = '" + txt_vid.Text + "'", con);
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_showcars_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("Select * from Vehicles_table where vehi_cat ='Car'" , con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGridVehicles.DataSource = dt;
            con.Close();
        }

        private void btn_showsuvs_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("Select * from Vehicles_table where vehi_cat ='Suv'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGridVehicles.DataSource = dt;
            con.Close();
        }

        private void btn_showvans_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("Select * from Vehicles_table where vehi_cat ='Van'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGridVehicles.DataSource = dt;
            con.Close();
        }
    }
}
