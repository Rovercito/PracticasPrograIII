using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    public class Farmaco
    {
        private string nombre;
        private string cantidad;
        private string precio;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Farmaco(string nombre, string cantidad, string precio)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
            
        }
    }
}
