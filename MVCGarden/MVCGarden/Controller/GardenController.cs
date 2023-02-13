using System;
using System.Collections.Generic;
using System.Text;
using MVCGarden.Model;
using MVCGarden.View;

namespace MVCGarden.Controller
{
    public class GardenController
    {
        private Display display;
        private Garden garden;
        public GardenController()
        {
            display = new Display();
            garden = new Garden(display.VegiPrice, display.FruitPrice, display.VegiKg, display.FruitKg);
            display.Total = garden.CalculatePrice();
            display.ShowResults();

        }
    }
}
