using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contacto : IComparable<Contacto>
    {
        public string Nombre { get; set; }

        public int Telefono { get; set; }

        public string Email { get; set; }

        public Contacto()
        {

        }

        public Contacto(string Nombre, int Telefono, string Email)
        {
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            this.Email = Email;

        }

        public override bool Equals(object obj)
        {
            if (obj == null) {
                return false;
            }

           Contacto c = obj as Contacto;
            if (c == null) {
                return false;
            }

            return string.Equals(Nombre, c.Nombre) && int.Equals(Telefono, c.Telefono);
        }

        public override int GetHashCode()
        {
            unchecked 
            {
                int hasNombre = (Nombre != null ? Nombre.GetHashCode() : 0);
                int hasTelefono = (Telefono != 0 ? Telefono.GetHashCode() : 0);

                return (hasNombre * 397) ^ (hasTelefono);
            }
        }

        public override string ToString()
        {
            return string.Format("Nombre: " + Nombre + ", Telefono: " + Telefono + ", Email: " + Email);
        }

        public int CompareTo(Contacto other)
        {
            return Nombre.CompareTo(other.Nombre);
        }
    }
        

        
}
