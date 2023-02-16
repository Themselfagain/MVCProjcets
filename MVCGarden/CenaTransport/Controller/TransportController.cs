using System;
using System.Collections.Generic;
using System.Text;
using CenaTransport.Model;
using CenaTransport.View;

namespace CenaTransport.Controller
{
    public class TransportController
    {
        private Display display;
        private Transport transport;
        public TransportController()
        {
            Display display = new Display();
            Transport transport = new Transport(display.Km, display.TimeOfDay);
            display.Total = transport.CalculatedPrice();
            display.ShowResults();
        }


    }
}
