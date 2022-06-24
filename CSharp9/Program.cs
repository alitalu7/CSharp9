Console.WriteLine("Kaç adet sayı gireceksiniz?");
int a = Convert.ToInt32(Console.ReadLine());

int[] sayilar = new int[a];
int toplam = 0;

for (int i = 0; i < a; i++)
{
    Console.WriteLine(a + " adet sayıdan " + (i+1) + ". sayıyı giriniz..." );
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (int say in sayilar)
{
    toplam = toplam + say;
}

Console.WriteLine("Girilen sayıların toplamı = " + toplam);
