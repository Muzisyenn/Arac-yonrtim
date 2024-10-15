
class Program
{
    class Arac
    {
        public string AracTipi;
        public string Model;
        public double Fiyat;
        public bool Kiralandi;

        public Arac(string aracTipi, string model, double fiyat)
        {
            AracTipi = aracTipi;
            Model = model;
            Fiyat = fiyat;
            Kiralandi = false;
        }
    }

    static void Main()
    {
        List<Arac> araclar = new List<Arac>();

        araclar.Add(new Arac("Araba", "Toyota", 200000));
        araclar.Add(new Arac("Kamyonet", "Ford", 300000));

        Console.WriteLine("Araçlar:");
        for (int i = 0; i < araclar.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {araclar[i].AracTipi} - {araclar[i].Model} - {araclar[i].Fiyat} TL");
        }

        Console.WriteLine("\nBir aracı satın almak için seçin (1 veya 2): ");
        int secim = Convert.ToInt32(Console.ReadLine()) - 1;
        if (secim >= 0 && secim < araclar.Count)
        {
            Console.WriteLine("Satın alma işlemi için 3 indirim yüzdesinden birini seçin (5, 10, 15): ");
            double indirimOrani = Convert.ToDouble(Console.ReadLine());
            double indirimMiktari = araclar[secim].Fiyat * (indirimOrani / 100);
            double satisTutari = araclar[secim].Fiyat - indirimMiktari;
            Console.WriteLine($"İndirim: {indirimMiktari} TL");
            Console.WriteLine($"Satış tutarı: {satisTutari} TL");
        }

        Console.WriteLine("\nBir aracı kiralamak için seçin (1 veya 2): ");
        secim = Convert.ToInt32(Console.ReadLine()) - 1;
        if (secim >= 0 && secim < araclar.Count)
        {
            Console.WriteLine("Kaç gün kiralanacak?");
            int kiralamaSuresi = Convert.ToInt32(Console.ReadLine());
            double kiralamaUcreti = kiralamaSuresi * 100;
            Console.WriteLine("Kiralama işlemi için 2 indirim yüzdesinden birini seçin (5, 10): ");
            double indirimOrani = Convert.ToDouble(Console.ReadLine());
            double indirimMiktari = kiralamaUcreti * (indirimOrani / 100);
            double kiralamaTutari = kiralamaUcreti - indirimMiktari;
            Console.WriteLine($"İndirim: {indirimMiktari} TL");
            Console.WriteLine($"Kiralama tutarı: {kiralamaTutari} TL");
        }

        Console.WriteLine("\nBir aracı silmek için seçin (1 veya 2): ");
        secim = Convert.ToInt32(Console.ReadLine()) - 1;
        if (secim >= 0 && secim < araclar.Count)
        {
            araclar.RemoveAt(secim);
            Console.WriteLine("Araç silindi.");
        }

        Console.WriteLine("\nGüncel araç listesi:");
        for (int i = 0; i < araclar.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {araclar[i].AracTipi} - {araclar[i].Model} - {araclar[i].Fiyat} TL");
        }
    }
}
