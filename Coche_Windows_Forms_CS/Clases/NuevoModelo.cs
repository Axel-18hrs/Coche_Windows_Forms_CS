using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coche_Windows_Forms_CS.Clases
{
    // clase hija o derivada
    public class NuevoModelo : Auto
    {

        // los atributos o variables globales son las caracteristicas que definen a una clase o objeto
        private string _color;

        public string Color
        {
            get
            {
                return Color;
            }
            set
            {
                _color = value;
            }
        }

        // aqui se usa el polimorfismo y la base de un metodo de la clase superior o clase padre
        public override void ToString()
        {
            if (Color != "Negro")
            {
                MessageBox.Show("Este auto se vera increible!");
            }
        }

        // aqui se usa el polimorfismo y la base de un metodo de la clase superior o clase padre
        public override void Chocar()
        {
            if (Color == "Negro")
            {
                MessageBox.Show("Ese color se ve muy inseguro. ¿Sabias que el color mas propenso a choques y accidentes es el negro?", "???", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

