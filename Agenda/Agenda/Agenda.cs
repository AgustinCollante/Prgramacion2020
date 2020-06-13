using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Agenda 
    {

        private const int TAM = 20;
        private Contacto[] _contactos;
        public int _contador;

        public int NumContactos
        {
            get
            {
                return _contador;
            }
        }

        public Agenda()
        {
            _contador = 0;
            _contactos = new Contacto[TAM];

        }

        public void AgregarContactos(Contacto c) 
        {
            if (_contador < TAM) 
            {
                _contactos[_contador] = c;
                _contador++;
            }
            
        }


        public void BorrarUltimo() 
        {
            if (_contador > 0) 
            {
                _contactos[_contador - 1] = null;
                _contador--;
            }else 
            {
                Console.WriteLine("La agenda está vacia");
            }
            
            
        }

        private bool NoHayContctos() 
        {
            if (_contador == 0) 
            {
                return true;
            }
            return false;
        }

        public void Mostrar() 
        {
            if (NoHayContctos() == false) 
            {
                Contacto[] ordenada = new Contacto[_contador];
                Array.Copy(_contactos, ordenada, _contador);
                Array.Sort(ordenada);

                foreach (var c in ordenada) 
                {
                    Console.WriteLine(c.ToString());
                }
            }
        }

        public void MostrarDesc()
        {
            if (NoHayContctos() == false)
            {
                Contacto[] ordenada = new Contacto[_contador];
                Array.Copy(_contactos, ordenada, _contador);
                Array.Sort(ordenada);
                Array.Reverse(ordenada);

                foreach (var c in ordenada)
                {
                    Console.WriteLine(c.ToString());
                }
            }
        }

        public string BuscarNombre(string Nombre) 
        {
            foreach (var contacto in _contactos) 
            {
                if (contacto.Nombre == Nombre)
                {
                    return contacto.ToString();
                }
            }
            return "No se encontró el contacto";
        }

        public string CadenadeContactos(Contacto[] contactos) 
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _contador; i++)
            {
                if (contactos[i] != null)
                {
                    string dato = string.Format(i + 1 + ", " + contactos[i]);
                    sb.AppendLine(dato);

                    return sb.ToString();
                }
             }
            return null;
            
        }

        public override string ToString()
        {
            return CadenadeContactos(_contactos);
        }

        public void MostrarContacto() 
        {
            Console.WriteLine(this);
        }

        public void Esperar() 
        {
            Console.WriteLine("Ingrese una tecla para continuar");
            Console.ReadKey();
        }
        public void Limpiar() 
        {
            Console.Clear();
        }


    }

}
