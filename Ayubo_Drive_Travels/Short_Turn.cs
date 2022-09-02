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
    public partial class Short_Turn : MetroFramework.Forms.MetroForm
    {
        public Short_Turn()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        private void Short_Turn_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hadaragama\Documents\Ayubo_Drive_Database.mdf;Integrated Security=True;Connect Timeout=30");
            populate();
        }
        private void populate()
        {
            con.Open();
            da = new SqlDataAdapter("Select * from Reservation_table where rent_cat = 'Short Turn'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGridReservation.DataSource = dt;
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

        private void btn_view_Click(object sender, EventArgs e)
        {
            Short_Turn_Bill obj = new Short_Turn_Bill();
            obj.ShowDialog();
        }

        private void metroGridReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_rid.Text = metroGridReservation.SelectedRows[0].Cells[0].Value.ToString();
            txt_cname.Text = metroGridReservation.SelectedRows[0].Cells[1].Value.ToString();
            combo_vc.SelectedItem = metroGridReservation.SelectedRows[0].Cells[4].Value.ToString();
            txt_vid.Text = metroGridReservation.SelectedRows[0].Cells[5].Value.ToString();
            dtp_rentd.Text = metroGridReservation.SelectedRows[0].Cells[6].Value.ToString();
            combo_rentcato.SelectedItem = metroGridReservation.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void combo_driver_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_driver.SelectedItem.ToString() == "Without Driver" && combopackage.SelectedItem.ToString() == "Air Port Pick or Drop" && combo_vc.SelectedItem.ToString()=="Car")
            {
                txt_fee_package.Text = 4000.ToString();
                txt_fee_km.Text = 25.ToString();
                txt_fee_hour.Text = 0.ToString();

            }
            else if (combo_driver.SelectedItem.ToString() == "With Driver" && combopackage.SelectedItem.ToString() == "Air Port Pick or Drop" && combo_vc.SelectedItem.ToString() == "Car")
            {
                txt_fee_package.Text = 5000.ToString();
                txt_fee_km.Text = 35.ToString();
                txt_fee_hour.Text = 100.ToString();
            }
            else if (combo_driver.SelectedItem.ToString() == "Without Driver" && combopackage.SelectedItem.ToString() == "100Km" && combo_vc.SelectedItem.ToString() == "Car")
            {
                txt_fee_package.Text = 6000.ToString();
                txt_fee_km.Text = 25.ToString();
                txt_fee_hour.Text = 0.ToString();
            }
            else if (combo_driver.SelectedItem.ToString() == "With Driver" && combopackage.SelectedItem.ToString() == "100Km" && combo_vc.SelectedItem.ToString() == "Car")
            {
                txt_fee_package.Text = 8000.ToString();
                txt_fee_km.Text = 35.ToString();
                txt_fee_hour.Text = 100.ToString();
            }
            else if (combo_driver.SelectedItem.ToString() == "Without Driver" && combopackage.SelectedItem.ToString() == "Air Port Pick or Drop" && combo_vc.SelectedItem.ToString() == "Van")
            {
                txt_fee_package.Text = 5000.ToString();
                txt_fee_km.Text = 35.ToString();
                txt_fee_hour.Text = 0.ToString();

            }
            else if (combo_driver.SelectedItem.ToString() == "With Driver" && combopackage.SelectedItem.ToString() == "Air Port Pick or Drop" && combo_vc.SelectedItem.ToString() == "Van")
            {
                txt_fee_package.Text = 8000.ToString();
                txt_fee_km.Text = 45.ToString();
                txt_fee_hour.Text = 150.ToString();
            }
            else if (combo_driver.SelectedItem.ToString() == "Without Driver" && combopackage.SelectedItem.ToString() == "100Km" && combo_vc.SelectedItem.ToString() == "Van")
            {
                txt_fee_package.Text = 8000.ToString();
                txt_fee_km.Text = 35.ToString();
                txt_fee_hour.Text = 0.ToString();
            }
            else if (combo_driver.SelectedItem.ToString() == "With Driver" && combopackage.SelectedItem.ToString() == "100Km" && combo_vc.SelectedItem.ToString() == "Van")
            {
                txt_fee_package.Text = 12000.ToString();
                txt_fee_km.Text = 45.ToString();
                txt_fee_hour.Text = 150.ToString();
            }
            else if (combo_driver.SelectedItem.ToString() == "Without Driver" && combopackage.SelectedItem.ToString() == "Air Port Pick or Drop" && combo_vc.SelectedItem.ToString() == "Suv")
            {
                txt_fee_package.Text = 6000.ToString();
                txt_fee_km.Text = 40.ToString();
                txt_fee_hour.Text = 0.ToString();

            }
            else if (combo_driver.SelectedItem.ToString() == "With Driver" && combopackage.SelectedItem.ToString() == "Air Port Pick or Drop" && combo_vc.SelectedItem.ToString() == "Suv")
            {
                txt_fee_package.Text = 10000.ToString();
                txt_fee_km.Text = 50.ToString();
                txt_fee_hour.Text = 200.ToString();
            }
            else if (combo_driver.SelectedItem.ToString() == "Without Driver" && combopackage.SelectedItem.ToString() == "100Km" && combo_vc.SelectedItem.ToString() == "Suv")
            {
                txt_fee_package.Text = 11000.ToString();
                txt_fee_km.Text = 40.ToString();
                txt_fee_hour.Text = 0.ToString();
            }
            else if (combo_driver.SelectedItem.ToString() == "With Driver" && combopackage.SelectedItem.ToString() == "100Km" && combo_vc.SelectedItem.ToString() == "Suv")
            {
                txt_fee_package.Text = 16000.ToString();
                txt_fee_km.Text = 50.ToString();
                txt_fee_hour.Text = 200.ToString();
            }
        }
        private void calculation()
        {
            double kms = Convert.ToDouble(txt_no_km.Text);
            double hours = Convert.ToDouble(txt_no_hours.Text);
            double kmfee = Convert.ToDouble(txt_fee_km.Text);
            double hourfee = Convert.ToDouble(txt_fee_hour.Text);
            double pacfee = Convert.ToDouble(txt_fee_package.Text);
            double amount = 0;
            amount = (pacfee + (kms * kmfee) + (hours * hourfee));
            lbl_amount.Text = amount.ToString();
        }
        private void btn_cal_Click(object sender, EventArgs e)
        {
            calculation();
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into Short_turn_bill_table values('" + txt_rid.Text + "','" + txt_cname.Text + "','" + combo_vc.SelectedItem + "','" + txt_vid.Text + "','" + dtp_rentd.Value + "','" + combo_rentcato.SelectedItem + "','" + combopackage.SelectedItem + "','" + combo_driver.SelectedItem + "','" + txt_fee_package.Text + "','" + txt_fee_km.Text + "','" + txt_fee_hour.Text + "','" + txt_no_km.Text + "','" + txt_no_hours.Text + "','" + lbl_amount.Text + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                cmd.Dispose();
                Clear();

            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public void Clear()
        {
            txt_cname.Clear();
            txt_rid.Clear();
            txt_vid.Clear();
            dtp_rentd.Value = DateTime.Now;
            txt_fee_hour.Clear();
            txt_fee_km.Clear();           
            txt_fee_package.Clear();
            txt_no_hours.Clear();
            txt_no_km.Clear();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
