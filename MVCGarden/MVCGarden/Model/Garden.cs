using System;
using System.Collections.Generic;
using System.Text;

namespace MVCGarden.Model
{
    public class Garden
    {
        public Garden(decimal vegiPrice, decimal fruitPrice, int vegiKg, int fruitKg)
        {
            this.VegiPrice = vegiPrice;
            this.FruitPrice = fruitPrice;
            this.VegiKg = vegiKg;
            this.FruitKg = fruitKg;
        }

        public decimal VegiPrice { get; set; }
        public decimal FruitPrice { get; set; }
        public int VegiKg { get; set; }
        public int FruitKg { get; set; }
        public decimal CalculatePrice()
        {
            return 1.94m * (this.VegiKg * this.VegiPrice + FruitKg * FruitPrice);
        }
    }
}
