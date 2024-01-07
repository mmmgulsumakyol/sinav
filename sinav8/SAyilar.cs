using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinav8
{
    internal class Sayilar
    {
        int not1;
        int not2;
        int not3;
        int sonuc;
      public int Not1
        {  
            get { return not1; }
            set { not1 = value; }
        }
        public int Not2
        {
            get { return not2; }    
            set { not2 = value; }
        }
        public int Not3
        {
            get { return not3; }    
            set { not3 = value; }
        }
        public int Sonuc
        {
            get { return sonuc;}
            set { sonuc = value; }
        }
      public int  OrtalamaHesapla(int sinav1,int sinav2,int sinav3)
        {
            sonuc = (not1 + not2 + not3) / 3;
            return sonuc;


        }
    }
}
