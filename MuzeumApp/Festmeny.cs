using System;
using System.Collections.Generic;
using System.Text;

namespace MuzeumApp
{
    public class Festmeny: Mutargy
    {
        public int KorEvekben { get; set; }
        public Festmeny(string azon, int becsult, int kor) : base(azon,becsult)
        {
            KorEvekben = kor;
        }

        public override int BiztositasDij()
        {
            return base.BiztositasDij()+500*KorEvekben;
        }

        public override string ToString()
        {
            return base.ToString()+$" | Kor: {KorEvekben} év";
        }
    }
}
