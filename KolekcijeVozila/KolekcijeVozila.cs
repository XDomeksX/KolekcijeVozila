using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijeVozila
{
    internal class KolekcijeVozila
    {
        string model, godProizvodnje, kategorija;
        int brojKotaca;

        public KolekcijeVozila(string model, string godProizvodnje, int brojKotaca, string kategorija)
        {
            this.Model = model;
            this.GodProizvodnje = godProizvodnje;
            this.BrojKotaca = brojKotaca;
        }

        public string Model { get => model; set => model = value; }
        public string GodProizvodnje { get => godProizvodnje; set => godProizvodnje = value; }
        public int BrojKotaca { get => brojKotaca; set => brojKotaca = value; }
        public string Kategorija { get => kategorija; set => kategorija = value; }

        public override string ToString()
        {
            string ispis = this.model + "\t" + this.godProizvodnje + "\t" + this.brojKotaca + "\t" + this.kategorija + "\t";
            return ispis;
        }
    }
}
