using VAZIFA_OOP.Classes;

namespace VAZIFA_OOP
{
    class Program
    {
        static void Main()
        {
            Console.Write("Kitob nomini kiriting: ");
            string KitobNomi = Console.ReadLine();

            Console.Write("Kitob muallifini kiriting: ");
            string KitobMuallifi = Console.ReadLine();

            Console.Write("Kitob narxini kiriting: ");
            double KitobNarxi = Convert.ToDouble(Console.ReadLine());

            Book Kitob = new Book(KitobNomi, KitobMuallifi, KitobNarxi);
            Console.WriteLine($"{Kitob.muallifi}ning {Kitob.nomi} nomli kitobi {Kitob.narxi}$ ga sotilmoqda");
            Kitob.Chiqarish();
        }
    }

}
