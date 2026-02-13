namespace asztali_projekt_ikea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ikea> ikeabutor = FileManager.Readfile("ikea.csv");
            foreach (Ikea item in ikeabutor)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" vásárlás = 1");
            Console.WriteLine("visszáru = 2");
            string choice = Console.ReadLine();
            switch (choice){
                case "1":
                    Console.WriteLine("mit szeretnél venni?");
                    int ujcount = int.Parse(Console.ReadLine());
                    Console.WriteLine("____________________________");
                    Console.WriteLine("mennyit szeretnel venni?: ");
                    int megujabbcount = int.Parse(Console.ReadLine());
                    ikeabutor[ujcount].buy(megujabbcount);
                    
                    break;
                case "2":

                    break;

              
            }
        }
    }
}
