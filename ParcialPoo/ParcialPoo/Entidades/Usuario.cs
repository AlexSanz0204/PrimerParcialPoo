using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPoo.Entidades
{
    class Usuario
    {
        private string nombre;
        private int contra;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Contra { get => contra; set => contra = value; }


        public Usuario()
        {
        }

        public Usuario(string nombre, int contra)
        {
            this.nombre = nombre;
            this.contra = contra;
        }
    }
}
