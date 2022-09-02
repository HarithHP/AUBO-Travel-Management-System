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
    public partial class Long_Turn : MetroFramework.Forms.MetroForm
    {
        public Long_Turn()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        private void Long_Turn_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hadaragama\Documents\Ayubo_Drive_Database.mdf;Integrated Security=True;Connect Timeout=30");
            populate();
        }
        private void cal_days()
        {
            DateTime startTime = dtp_rentd.Value;
            DateTime endTime = dtp_return.Value;

            TimeSpan duration = new TimeSpan(endTime.Ticks - startTime.Ticks);
            txt_nodays.Text = duration.ToString(@"dd");
            double days = Convert.ToDouble(txt_nodays.Text);
            double remaindays = days % 7;
            int nodays = (int)Math.Round(remaindays);
            txt_nodays.Text = remaindays.ToString();


            double weeks = (endTime - startTime).TotalDays / 7;
            int noweeks = (int)Math.Round(weeks);
            txt_no_weeks.Text = noweeks.ToString();

        }
        private void populate()
        {
            con.Open();
            da = new SqlDataAdapter("Select * from Reservation_table where rent_cat = 'Long Turn'", con);
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

        private void btn_cal_Click(object sender, EventArgs e)
        {
            calculation();
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into Long_turn_bill_table values('" + txt_rid.Text + "','" + txt_cname.Text + "','" + combo_vc.SelectedItem + "','" + txt_vid.Text + "','" + dtp_rentd.Value + "','" + combo_rentcato.SelectedItem + "','" + dtp_return.Value + "','" + combo_driver.SelectedItem + "','" + txt_Fee.Text + "','" + txt_fee_for_week.Text + "','" + txt_no_weeks.Text + "','" + txt_nodays.Text + "','" + lbl_amount.Text + "')", con);
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

        private void metroGridReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_rid.Text = metroGridReservation.SelectedRows[0].Cells[0].Value.ToString();
            txt_cname.Text = metroGridReservation.SelectedRows[0].Cells[1].Value.ToString();
            combo_vc.SelectedItem = metroGridReservation.SelectedRows[0].Cells[4].Value.ToString();
            txt_vid.Text = metroGridReservation.SelectedRows[0].Cells[5].Value.ToString();
            dtp_rentd.Text = metroGridReservation.SelectedRows[0].Cells[6].Value.ToString();
            combo_rentcato.SelectedItem = metroGridReservation.SelectedRows[0].Cells[7].Value.ToString();
        }
        private void calculation()
        {
            double days = Convert.ToDouble(txt_nodays.Text);
            double remaindays = days % 7;
            int intdays = (int)Math.Round(remaindays);
            int weeks = Convert.ToInt32(txt_no_weeks.Text);
            double dayfee = Convert.ToDouble(txt_Fee.Text);
            double weekfee = Convert.ToDouble(txt_fee_for_week.Text);
            double amount = 0;
            amount = ((intdays * dayfee) + (weekfee * weeks));
            lbl_amount.Text = amount.ToString();

        }

        private void combo_driver_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_driver.SelectedItem.ToString() == "Without Driver")
            {
                try
                {
                    con.Open();
                    string query = "select * from Vehicles_table where vehi_Id = " + txt_vid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_Fee.Text = dr["vehi_fee_withoutdriver"].ToString();
                    }
                    con.Close();
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if(combo_driver.SelectedItem.ToString() == "With Driver")
            {
                try
                {
                    con.Open();
                    string query = "select * from Vehicles_table where vehi_Id = " + txt_vid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_Fee.Text = dr["vehi_fee_withdriver"].ToString();
                    }
                    con.Close();
                }
                catch(Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_Fee_TextChanged(object sender, EventArgs e)
        {
            double feeday = Convert.ToDouble(txt_Fee.Text);
            double feeweek = (feeday * 6);
            txt_fee_for_week.Text = feeweek.ToString();
            cal_days();


        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            txt_cname.Clear();
            txt_rid.Clear();
            txt_vid.Clear(); 
            combo_vc.SelectedIndex = -1;
            combo_driver.SelectedIndex = -1;
            combo_rentcato.SelectedIndex = -1;     
            dtp_rentd.Value = DateTime.Now;
            dtp_return.Value = DateTime.Now;

        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            
            LongTurn_Bill obj = new LongTurn_Bill();
            obj.ShowDialog();
        }
    }
}
