using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinav
{
    internal class Sayilar
    {
        int a;
        int b;
        int c;
        int sonuc;
        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B { get { return b; }set { b = value; } }
        public int C { get { return c; }set { c = value; } }
        public int Sonuc {  get { return sonuc; }set {  sonuc = value; } }
        public int OrtalamaHesapla()
        {
            sonuc=(a+b+c)/3;    
            return sonuc;
        }
    }
}
