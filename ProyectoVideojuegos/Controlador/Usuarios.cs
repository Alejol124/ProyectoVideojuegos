using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVideojuegos.Controlador
{
    public class Usuarios
    {
        private string nombreusuario;
        private string clave;
        private int rolid;

        public Usuarios(string usuario, string clave, int rolid)
        {
            this.nombreusuario = usuario;
            this.clave = clave;
            this.rolid = rolid;
        }

        public string NombreUsuario { get => nombreusuario; set => nombreusuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public int RolID { get => rolid; set => rolid = value; }
    }
}
