namespace VAZIFA_OOP.Classes
{
    public class Book
    {
        private string Nomi;
        public string nomi
        {
            get { return Nomi; } 
            set { Nomi = value; } 
        }
        public string muallifi { get; set; }
        public double narxi { get; set; }

        // Constructor
        public Book(string nomi)
        {
            this.nomi = nomi;
            this.muallifi = "No name";
            this.narxi = 0; 
        }

        public Book(string nomi, string muallifi, double narxi)
        {
            this.nomi = nomi;
            this.muallifi = muallifi;
            this.narxi = narxi;
            Nom(nomi);
            Muallif(muallifi);
        }

        public void Chiqarish()
        {
            Console.WriteLine($"Kitob nomi: {nomi}");
            Console.WriteLine($"Muallifi: {muallifi}");
            Console.WriteLine($"Narxi: {narxi} usd");
        }
        private void Nom(string nom)
        {
            if(nom == "")
            {
                this.nomi = "No name";
            }
        }
        private void Muallif(string muallif)
        {
            if(muallif == "")
            {
                this.muallifi = "No name";
            }
        }
    }
}