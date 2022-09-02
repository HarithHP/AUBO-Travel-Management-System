using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Ayubo_Drive_Travels
{
    public partial class Flash_Loading : MetroFramework.Forms.MetroForm
    {
        public Flash_Loading()
        {
            InitializeComponent();
            ProgressBar1.Value = 0;
        }

        private void Flash_Loading_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Value += 1;
            ProgressBar1.Text = ProgressBar1.Value.ToString() + "%";
            try
            {
                if (ProgressBar1.Value == 100)
                {
                    timer1.Enabled = false;
                    this.Hide();
                    Logging obj = new Logging();
                    obj.Show();

                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
