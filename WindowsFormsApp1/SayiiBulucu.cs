using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class SayiiBulucu
    {
        public int BuyukOlaniBul(int sayi1, int sayi2)
        {
            int sonuc;
            if (sayi1 > sayi2)
                sonuc = sayi1;
            else
                sonuc = sayi2;
            return sonuc;
        }
            
        
        

    }
}

