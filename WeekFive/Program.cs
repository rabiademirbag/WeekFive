using WeekFive;

public class Program
{
    public static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        Console.WriteLine("Araba üretmek ister misiniz? (evet:e, hayır:h)");
        string choice = Console.ReadLine().ToLower();
        while (choice != "e" && choice !="h")
        {
            Console.WriteLine("Lütfen geçerli bir değer giriniz (e/h)");
            choice = Console.ReadLine();
        }
        while(choice == "e")
        {
            Console.WriteLine("Araba seri no girin:");
            string seriNo= Console.ReadLine();
            Console.WriteLine("Araba markası girin: ");
            string marka= Console.ReadLine();
            Console.WriteLine("Araba modeli girin: ");
            string model= Console.ReadLine();
            Console.WriteLine("Araba rengi girin: ");
            string renk= Console.ReadLine();

        KapiGiris:
            int kapi = 0;
            try
            {
                Console.WriteLine("Araba kapı sayısı girin: ");
                string kapiSayisi = Console.ReadLine();
                kapi = Convert.ToInt16(kapiSayisi);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Geçersiz değer");
                goto KapiGiris;
            }
            catch (OverflowException ex) {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer giridiniz.");
                goto KapiGiris;
            }

            Car car = new Car(seriNo, marka, model, renk, kapi);
            cars.Add(car);
            Console.WriteLine("Başka araba oluşturmak ister misiniz (evet/hayır): ");
            string choice2= Console.ReadLine().ToLower();
            if(choice2 != "evet")
            {
                foreach (var i in cars)
                {
                    Console.WriteLine(i.SeriNo + " " + i.Marka);
                }
                break;
           
            }            

        }
        
           Console.WriteLine("İyi günler");
    }
}