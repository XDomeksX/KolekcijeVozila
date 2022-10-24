using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolekcijeVozila
{
    public partial class Form1 : Form
    {
        List<KolekcijeVozila> listVozila = new List<KolekcijeVozila>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNunesi_Click(object sender, EventArgs e)
        {
            try
            {
                KolekcijeVozila memory = new KolekcijeVozila(TXTmodel.Text, TXTgodProizvodnje.Text, Convert.ToInt32(TXTbrojKotaca.Text), "");
                listVozila.Add(memory);
                TXTmodel.Clear();
                TXTgodProizvodnje.Clear();
                TXTbrojKotaca.Clear();

                MessageBox.Show("Uspješan unos!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception greska)
            {
                MessageBox.Show("Pogrešan unos! \r\n" + greska.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNobradi_Click(object sender, EventArgs e)
        {
            foreach (KolekcijeVozila memory in listVozila)
            {
                if (memory.BrojKotaca == 2)
                {
                    memory.Kategorija = "Motocikl";
                }
                if (memory.BrojKotaca == 4)
                {
                    memory.Kategorija = "Automobil";
                }
                if (memory.BrojKotaca > 4)
                {
                    memory.Kategorija = "Kamion";
                }
            }
            foreach (KolekcijeVozila memory in listVozila)
            {
                RTBispis.AppendText(memory.ToString());
            }
        }

        private void BTNispisi_Click(object sender, EventArgs e)
        {
            RTBispis.Text = "Model" + "\tGod. proizvodnje" + "\tBroj kotača" + "\tKategorija\r\n";
            foreach (KolekcijeVozila memory in listVozila)
            {
                RTBispis.AppendText(memory.ToString() + "\r\n");
            }
        }
    }
}
