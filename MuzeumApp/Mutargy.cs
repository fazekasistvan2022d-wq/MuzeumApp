using System;
using System.Collections.Generic;
using System.Text;

namespace MuzeumApp
{
    public class Mutargy
    {
        public string Azonosito { get; set; }
        protected int becsultErtek { get; set; }
        public int BecsultErtek
        {
            get { return becsultErtek; }
            set {
                if (value <= 0)
                {
                    becsultErtek = 50_000;
                }
                else
                {
                    becsultErtek = value;
                }
            }
        }
        private static int osszesMutargySzama = 0;
        public static int OsszesMutargySzama { get; }

        public Mutargy(string azon, int becsult)
        {
            Azonosito = azon;
            BecsultErtek = becsult;
            osszesMutargySzama++;
        }
        public virtual int BiztositasDij()
        {
            return Convert.ToInt32(becsultErtek*0.02);
        }
        public override string ToString()
        {
            return $"Műtárgy {Azonosito} | Becsült érték: {becsultErtek} Ft | Biztosítás: {BiztositasDij()} Ft";
        }

    }
}
