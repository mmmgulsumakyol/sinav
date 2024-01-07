
//1′ den kullanıcının girdiği sayıya kadar olan sayıları toplayan örnek:


int topLAM = 0;
Console.WriteLine("Bir Sayı Giriniz:");
int sayi=Convert.ToInt32(Console.ReadLine());   

for(int i=0; i <=sayi; i++)
{
    topLAM=topLAM+i;
}
Console.WriteLine("1-{0} arası sayıların toplamı = {1}", sayi, topLAM);

