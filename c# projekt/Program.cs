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
        }
    }
}
