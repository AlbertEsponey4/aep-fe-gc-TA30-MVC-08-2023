using MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Controller
    {
        private View vista;
        private List<Cliente> clientes;

        public Controller(List<Cliente> clientes, View view)
        {
            this.clientes = clientes;
            this.vista = view;
        }

        public void Ejecutar()
        {
            bool continuar = true;
            do
            {
                vista.menu();
                if (int.TryParse(Console.ReadLine(), out int op))
                {
                    switch (op)
                    {
                        case 0: 
                            continuar = false;
                            break;
                        case 1:
                            vista.pedirClienteParaMostrar();
                            int idMostrar = int.Parse(Console.ReadLine());
                            Cliente clienteMostrar = clientes.Find(cliente => cliente.id == idMostrar);
                            if (clienteMostrar != null)
                                vista.mostrarCliente(clienteMostrar);
                            else
                                Console.WriteLine("No existe");

                            break;
                        case 2:
                            vista.agregarCliente();
                            vista.pedirNombre();
                            string nombre = Console.ReadLine();
                            vista.pedirApellido();
                            string apellido = Console.ReadLine();
                            vista.pedirDireccion();
                            string direccion = Console.ReadLine();
                            vista.pedirDNI();
                            string DNI = Console.ReadLine();
                            vista.pedirFecha();
                            vista.pedirDia();
                            string dia = Console.ReadLine();
                            vista.pedirMes();
                            string mes = Console.ReadLine();
                            vista.pedirAño();
                            string año = Console.ReadLine();
                            string fecha = $"{dia}/{mes}/{año}";
                            Cliente nuevoCliente = new Cliente(nombre, apellido, direccion, DNI, fecha);
                            clientes.Add(nuevoCliente);
                            break;
                        case 3:
                            vista.pedirClienteParaModificar();
                            int idModificar = int.Parse(Console.ReadLine());
                            Cliente clienteModificar = clientes.Find(cliente => cliente.id == idModificar);
                            vista.modificarCliente();
                            // Si los campos no estan vacíos, los actualizamos
                            vista.pedirNombre();
                            string nombreUpdate = Console.ReadLine();
                            if (!string.IsNullOrEmpty(nombreUpdate))
                                clienteModificar.name = nombreUpdate;

                            vista.pedirApellido();
                            string apellidoUpdate = Console.ReadLine();
                            if (!string.IsNullOrEmpty(apellidoUpdate))
                                clienteModificar.surname = apellidoUpdate;

                            vista.pedirDireccion();
                            string direccionUpdate = Console.ReadLine();
                            if (!string.IsNullOrEmpty(direccionUpdate))
                                clienteModificar.direction = direccionUpdate;

                            vista.pedirDNI();
                            string DNIUpdate = Console.ReadLine();
                            if (!string.IsNullOrEmpty(DNIUpdate))
                                clienteModificar.dni = DNIUpdate;

                            vista.pedirFecha();
                            vista.pedirDia();
                            string diaUpdate = Console.ReadLine();
                            vista.pedirMes();
                            string mesUpdate = Console.ReadLine();
                            vista.pedirAño();
                            string añoUpdate = Console.ReadLine();
                            string fechaUpdate = $"{diaUpdate}/{mesUpdate}/{añoUpdate}";
                            if (!string.IsNullOrEmpty(diaUpdate) && !string.IsNullOrEmpty(mesUpdate) && !string.IsNullOrEmpty(añoUpdate))
                                clienteModificar.fecha = fechaUpdate;

                            vista.mostrarCliente(clienteModificar);
                            break;
                        case 4:
                            vista.pedirClienteParaBorrar();
                            int idBorrar = int.Parse(Console.ReadLine());
                            Cliente clienteBorrar = clientes.Find(cliente => cliente.id == idBorrar);
                            clientes.Remove(clienteBorrar);
                            break;

                        default:
                            Console.WriteLine("Opción no valida. Introduce un número del 0 al 4.");
                            break;
                    }
                }
                else
                {
                    throw new Exception("Formato incorrecto de las opciones");
                }
            } while (continuar);
        }
            
    }
}
