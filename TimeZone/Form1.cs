using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeZone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbTimeZone.Items.Clear();
            foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
                lbTimeZone.Items.Add(z.Id);

            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbTimeZone.SelectedIndex != -1)
            {
                string fusoHorarioId = lbTimeZone.Text;
                //TimeZoneInfo horaBrasilia = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
                //DateTime dataHoraLocal = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, horaBrasilia);
                TimeZoneInfo Standard_Time = TimeZoneInfo.FindSystemTimeZoneById(fusoHorarioId);
                DateTime dataHoraLocal = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, Standard_Time);
                lbDataHora.Items.Add("Data e Horário Local");
                lbDataHora.Items.Add("Para " + fusoHorarioId);
                lbDataHora.Items.Add(dataHoraLocal);
                lbDataHora.Items.Add("--------------------------------");
            }
            else
            {
                MessageBox.Show("Selecione um fuso horário");
            }


        }
    }
}
