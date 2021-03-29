using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_7___Archivo_Secuencial_Indexado.Models
{
    class Employee
    {
        private String id;
        private String name;
        private String address;
        private String phone;
        private Position position;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public Position Position { get => position; set => position = value; }

        public string GetLine => id + "," + name + address + phone + position.Id;
    }
}
