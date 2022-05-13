using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2
{
    public abstract class Producto
    {
        protected double precioVenta;
        protected double costoFabrica;
        protected string nombreProducto;

        public Producto(string nombre, double precio, double costo)
        {
            nombreProducto = nombre;
            costoFabrica = costo;
            precioVenta = precio;
        }

        public abstract string imprimirDatos();
    }

    public class Libro : Producto
    {
        public Libro(string titulo, double precio, double costo)
            : base(titulo, precio, costo)
        {

        }

        public override string imprimirDatos()
        {
            return "Libro: " + nombreProducto + ", Precio: " + precioVenta;
        }
    }

    public class DVD : Producto
    {
        public DVD(string titulo, double precio, double costo)
            : base(titulo, precio, costo)
        {

        }
        public override string imprimirDatos()
        {
            return "DVD: " + nombreProducto + " Precio: " + precioVenta;
        }

    }
}




