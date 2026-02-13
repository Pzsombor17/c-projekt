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
            string choice = Console.ReadLine();
            Console.WriteLine(" vásárlás = 1");
            Console.WriteLine("visszáru = 2");
            switch(choice){
                case "1":
                    Console.WriteLine("mennyit szeretnél venni?");
                    int ujcount = int.Parse(Console.ReadLine());
                    
                    break;
                case "2":

                    break;

              
            }
        }
    }
}
