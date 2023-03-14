using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coche_Windows_Forms_CS.Clases
{
    // Clase abstracta que no se puede instanciar directamente
    public abstract class Auto
    {
        // atibutos o variables globales desde los que se pueden acceder en otras clases derivadas

        protected string _marca;
        protected string _modelo;
        protected string _motor;


        public string Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                _marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return _modelo;
            }
            set
            {
                _modelo = value;
            }
        }

        public string Motor
        {
            get
            {
                return _motor;
            }
            set
            {
                _motor = value;
            }
        }

        // metodo abstracto que se implementara en todas las clases y que cada una de ellas se encargara de definirlo
        // tambien es un ejemplo de polimorfismo al modificar o personalizar un metodo de la clase object
        public abstract void ToString();

        // metodo abstracto que se implementara en todas las clases y que cada una de ellas se encargara de definirlo
        public abstract void Chocar();
    }
}

