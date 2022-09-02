using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo_Drive_Travels
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation obj = new Reservation();
            obj.Show();
        }

        private void btn_vehicles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicles obj = new Vehicles();
            obj.Show();
        }

        private void btn_stcal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Short_Turn obj = new Short_Turn();
            obj.Show();
        }

        private void btn_ltcal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Long_Turn obj = new Long_Turn();
            obj.Show();
        }

        private void pic_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logging obj = new Logging();
            obj.Show();
        }

        private void pic_box_usermanagemt_Click(object sender, EventArgs e)
        {
            this.Hide();
            User obj = new User();
            obj.Show();
        }

        private void lbl_usermanagemt_Click(object sender, EventArgs e)
        {
            this.Hide();
            User obj = new User();
            obj.Show();
        }

        private void pic_feeinfor_Click(object sender, EventArgs e)
        {
            
            Fee_Information obj = new Fee_Information();
            obj.ShowDialog();
        }

        private void lbl_feeinfo_Click(object sender, EventArgs e)
        {
            Fee_Information obj = new Fee_Information();
            obj.ShowDialog();
        }
      
    }
}
