using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asztali_projekt_ikea
{
    public class Ikea
    {
        public string type { get; set; }
        public double size { get; set; }
        public string color { get; set; }
        public string name { get; set; }
        public int db { get; set; }
        public bool raktaron { get; set; }
        public int price { get; set; }
        public int maxStock { get; set; }
        public Ikea(string[] data)
        {
            this.type = data[0];
            this.size = double.Parse(data[1]);
            this.color = data[2];
            this.name = data[3];
            this.db = int.Parse(data[4]);
            this.raktaron = Convert.ToBoolean(data[6]);
            this.price = int.Parse(data[5]);
            this.maxStock = int.Parse(data[6]);

        }
        public double buy(int count)
        {
            if (raktaron == true && db > count) {
                Console.WriteLine("Van raktáron,Ennyibe fog kerülni+ ÁFA:");
                return (price * count) * 0.27;
            }
            else
            {
                Console.WriteLine("elfogyott a termékből");
                return 0;
            }

        }
        
        public int Return(int db,string type)
        {
            return 0;
        }
        public double discount()
        {
            Random rnd = new Random();
            double kedvezmeny = 0.10 + rnd.NextDouble() * (0.80 - 0.10);
            Console.WriteLine($"Ennyi a kedvezmény: {kedvezmeny}");
            return (price * kedvezmeny);
        }
        public int ReStock()
        {
            
            return db = maxStock;
        }
        public override string ToString()
        {
            return $"A típús: {type}, méret: {size}, szín: {color}, neve: {name}, elérhető darabszám: {db}, raktáron: ,ár: {price}, ennyi fér el a raktárban: {maxStock}";
        }
    }
}
