using MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class View
    {
        public void menu()
        {
            Console.WriteLine("Que desea hacer?");
            Console.WriteLine("1. Mostrar cliente");
            Console.WriteLine("2. Agregar cliente");
            Console.WriteLine("3. Modificar cliente");
            Console.WriteLine("4. Eliminar cliente");
            Console.WriteLine("0. Salir");
        }

        // acciones mostrar cliente
        public void pedirClienteParaMostrar()
        {
            Console.WriteLine("Introuce el id del cliente que quieres mostrar");
        }
        public void mostrarCliente(Cliente cliente)
        {
            Console.WriteLine(cliente.ToString());
        }

        // acciones agregar cliente
        public void agregarCliente()
        {
            Console.WriteLine("Introduce los datos del cliente: ");
        }

        // pedir campos. Sirve tanto para agregar como para modificar
        public void pedirNombre()
        {
            Console.WriteLine("Nombre: ");
        }

        public void pedirApellido()
        {
            Console.WriteLine("Apellido: ");
        }

        public void pedirDireccion()
        {
            Console.WriteLine("Direccion: ");
        }

        public void pedirDNI()
        {
            Console.WriteLine("DNI: ");
        }
        public void pedirFecha()
        {
            Console.WriteLine("Introduce los campos de la fecha por separado.");
        }
        public void pedirDia()
        {
            Console.WriteLine("Dia: ");
        }

        public void pedirMes()
        {
            Console.WriteLine("Mes: ");
        }

        public void pedirAño()
        {
            Console.WriteLine("Año: ");
        }

        // acciones modificar cliente
        public void pedirClienteParaModificar()
        {
            Console.WriteLine("Introuce el id del cliente que quieres modificar");
        }
        public void modificarCliente()
        {
            Console.WriteLine("Si quieres dejar algun campo como estaba dejalo en blanco (click intro)");
        }

        // acciones borrar cliente

        public void pedirClienteParaBorrar()
        {
            Console.WriteLine("Que cliente quieres borrar? Introduce el ID");
        }
    }
}
