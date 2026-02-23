using System;

namespace asztali_projekt_ikea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ikea> ikeabutor = FileManager.Readfile("ikea.csv");
            Console.WriteLine("Termékeink: ");
            Console.WriteLine("__________________________");
            foreach (Ikea item in ikeabutor)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n----------------------");
            Console.WriteLine("\nvásárlás = 1");
            Console.WriteLine("\nvisszáru = 2");
            Console.WriteLine("\nakciók = 3");
            Console.WriteLine("\nkilépés = 4");
            Console.WriteLine("\n");
            
            string choice =  Console.ReadLine();

            switch (choice){
                case "1":
                    Console.WriteLine("mit szeretnél venni?");
                    foreach (Ikea item in ikeabutor)
                    {
                        Console.WriteLine(item.name);
                    }
                    int ujcount = int.Parse(Console.ReadLine());
                    Console.WriteLine(ikeabutor[ujcount].name.ToString());
                    Console.WriteLine("____________________________");
                    Console.WriteLine("mennyit szeretnel venni?: ");
                    Console.WriteLine($"elérhető mennyiség: {ikeabutor[ujcount].db}");
                    int megujabbcount = int.Parse(Console.ReadLine());
                    ikeabutor[ujcount].buy(megujabbcount);
                    
                    break;
                case "2":
                    Console.WriteLine("mit szeretnél visszavinni?");
                    foreach (Ikea item in ikeabutor)
                    {
                        Console.WriteLine(item.name);
                    }
                    int visszaUjCount = int.Parse(Console.ReadLine());
                    Console.WriteLine(ikeabutor[visszaUjCount].name.ToString());
                    Console.WriteLine("____________________________");
                    Console.WriteLine("mennyit szeretnel visszavinni?: ");
                    Console.WriteLine($"elérhető mennyiség: {ikeabutor[visszaUjCount].db}");
                    int visszaMegUjabbCount = int.Parse(Console.ReadLine());
                    ikeabutor[visszaUjCount].Return(visszaMegUjabbCount);
                    break;
                case "3":
                    Console.WriteLine("melyik termékre szeretnél akciót?: ");
                    int akcioInt = int.Parse(Console.ReadLine());
                    ikeabutor[akcioInt].discount();
                    break;
                case "4":
                    Console.WriteLine("viszlát!");
                    break;
              
            }
        }
    }
}
