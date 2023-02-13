using System;
using System.Collections.Generic;
using System.Text;

namespace MVCGarden.View
{
    public class Display
    {
        public Display()
        {
            this.VegiPrice = 0;
            this.FruitPrice = 0;
            this.VegiKg = 0;
            this.FruitKg = 0;
            this.Total = 0;
            this.GetValues();
        }

        public decimal VegiPrice { get; set; }
        public decimal FruitPrice { get; set; }
        public int VegiKg { get; set; }
        public int FruitKg { get; set; }
        public decimal Total { get; set; }
        public void GetValues()
        {
            this.VegiPrice = decimal.Parse(Console.ReadLine());
            this.FruitPrice = decimal.Parse(Console.ReadLine());
            this.VegiKg = int.Parse(Console.ReadLine());
            this.FruitKg = int.Parse(Console.ReadLine());
        }
        public void ShowResults()
        {
            Console.WriteLine(this.Total);
        
        }
    }
}
