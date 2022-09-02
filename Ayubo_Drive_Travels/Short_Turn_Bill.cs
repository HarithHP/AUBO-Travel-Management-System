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
    public partial class Short_Turn_Bill : MetroFramework.Forms.MetroForm
    {
        public Short_Turn_Bill()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        private void Short_Turn_Bill_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hadaragama\Documents\Ayubo_Drive_Database.mdf;Integrated Security=True;Connect Timeout=30");
            populate();
        }
        private void populate()
        {
            con.Open();
            da = new SqlDataAdapter("Select * from Short_turn_bill_table", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGridShort.DataSource = dt;
            con.Close();

        }
        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroGridShort_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
