using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_7___Archivo_Secuencial_Indexado.Models
{
    class Position
    {
        private String id;
        private String name;
        private double amount;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Amount { get => amount; set => amount = value; }

        public string GetLine => id + "," + name + "," + amount.ToString();
    }
}
