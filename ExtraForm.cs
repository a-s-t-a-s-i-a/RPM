using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPM
{
    public partial class ExtraForm : Form
    {
        MainForm mainfrm;
        int Holorder;
        TimeSpan TimeSpan;
        DateTime ThisDate = DateTime.Now;
        DateTime Holiday;
        public ExtraForm(MainForm Mainfrm, int holorder)
        {
            InitializeComponent();

            mainfrm = Mainfrm;
            Holorder = holorder;

            DateTime dtt = DateTime.Now;

            timer1.Enabled = true;

            switch (Holorder)
            {
                case 0:
                    {
                        HolName.Text = " Рождество";
                        Holiday = new DateTime(dtt.Year, 7, 31);
                        break;
                    }
                case 1:
                    {
                        HolName.Text = "8 Марта";
                        Holiday = new DateTime(dtt.Year, 3, 8);
                        break;
                    }
                case 2:
                    {
                        HolName.Text = "День Народного Единства";
                        Holiday = new DateTime(dtt.Year, 11, 4);
                        break;
                    }
                case 3:
                    {
                        HolName.Text = "День Российского Студенчества";
                        Holiday = new DateTime(dtt.Year, 1, 25);
                        break;
                    }
                case 4:
                    {
                        HolName.Text = "День Снятия Блокады";
                        Holiday = new DateTime(dtt.Year, 1, 27);
                        break;
                    }
            }
        }

        private void ExtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainfrm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ThisDate = DateTime.Now;
            HolName.Visible = true;
            if ((Holiday.Subtract(ThisDate)).Days < 0)
            {
                Holiday = Holiday.AddYears(1);
            }
            TimeSpan = Holiday.Subtract(ThisDate);
            TimeLeft.Text = "Дни: " + TimeSpan.Days + "\nЧасы: " + TimeSpan.Hours + "\nМинуты: " + TimeSpan.Minutes + "\nСекунды: " + TimeSpan.Seconds;
        }

        private void HolName_Click(object sender, EventArgs e)
        {

        }

        private void ExtraForm_Load(object sender, EventArgs e)
        {

        }
    }
}
