using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    class Cliente
    {
        private static int id_auto_incremental = 1;
        public int id { get; private set; } //private para que no se pueda modificar el id
        public string name { get; set; }
        public string surname { get; set; }
        public string direction { get; set; }
        public string dni { get; set; }
        public string fecha { get; set; }

        public Cliente(string name, string surname, string direction, string dni, string fecha)
        {
            this.id = id_auto_incremental;
            id_auto_incremental++;
            this.name = name;
            this.surname = surname;
            this.direction = direction;
            this.dni = dni;
            this.fecha = fecha;
        }

        public override string ToString()
        {
            return $"Cliente {id}, nombre: {name}, apellido: {surname}, direccion: {direction}, DNI: {dni}, fecha: {fecha}";
        }
    }
}
