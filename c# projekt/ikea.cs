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
        //public bool raktaron { get; set; }
        public int price { get; set; }
        public int maxStock { get; set; }
        public Ikea(string[] data)
        {
            this.type = data[0];
            this.size = double.Parse(data[1]);
            this.color = data[2];
            this.name = data[3];
            this.db = int.Parse(data[4]);
            //this.raktaron = Convert.ToBoolean(data[6]);
            this.price = int.Parse(data[5]);
            this.maxStock = int.Parse(data[6]);

        }
        public int buy(int count)
        {
            return price *= count;
        }
        
        public int Return(int db,string type)
        {
            return 1;
        }
        public double discout()
        {
            return 1;
        }
        public int ReStock()
        {
            return 1;
        }
        public override string ToString()
        {
            return $"A típús: {type}, méret: {size}, szín: {color}, neve: {name}, elérhető darabszám: {db}, raktáron: ,ár: {price}, ennyi fér el a raktárban: {maxStock}";
        }
    }
}
