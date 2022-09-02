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
    public partial class LongTurn_Bill : MetroFramework.Forms.MetroForm
    {
        public LongTurn_Bill()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        private void LongTurn_Bill_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hadaragama\Documents\Ayubo_Drive_Database.mdf;Integrated Security=True;Connect Timeout=30");
            populate();
        }
        private void populate()
        {
            con.Open();
            da = new SqlDataAdapter("Select * from Long_turn_bill_table", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGridLong.DataSource = dt;
            con.Close();

        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
