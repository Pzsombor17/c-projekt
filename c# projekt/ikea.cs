using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            if (data[5] == "True") 
            { this.raktaron = true; }
            else if (data[5] == "False") 
            { this.raktaron = false; }
            else { this.raktaron = false; }
            this.price = int.Parse(data[6]);
            this.maxStock = int.Parse(data[7]);

        }
        public void buy(int count)
        {
            if (raktaron==true && db > count) {
                Console.WriteLine("Van raktáron,Ennyibe fog kerülni+ ÁFA:");
                db -= count;
                Console.WriteLine($"{(price * count) * 0.27} Ft");
                Console.WriteLine($"ennyi maradt raktáron: {db}");
                
            }
            else
            {
                Console.WriteLine("elfogyott a termékből");
                
            }

        }
        
        public void Return(int visszadb)
        {

            if (db + visszadb <= maxStock)
            {
                db += visszadb;
                raktaron = true;
                Console.WriteLine($"\n---  sikeres visszavetel---");
                Console.WriteLine($"Visszavett mennyiség: {visszadb} db");
                Console.WriteLine($"jelenlegi darabszam visszavetel utan: {db}");
            }
            else
            {
                Console.WriteLine($"Nem fér el raktáron, max mennyiség: {maxStock}, jelenlegi: {db}");
            }
        }
        public void discount()
        {
            Random rnd = new Random();
            double kedvezmeny = 0.10 + rnd.NextDouble() * (0.80 - 0.10);
            Console.WriteLine($"Ennyi a kedvezmény: {kedvezmeny} %");
            Console.WriteLine($"Eredeti ár: {price} ft");
            Console.WriteLine($"Az új ár: {(price * kedvezmeny)} Ft");
        }
        public int ReStock()
        {
            raktaron = true;
            return db = maxStock;
            
        }
        public override string ToString()
        {
            return $"A típús: {type}, méret: {size}, szín: {color}, neve: {name}, elérhető darabszám: {db}, raktáron: ,ár: {price},van-e raktáron: {raktaron}, ennyi fér el a raktárban: {maxStock}";
        }
    }
}
