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
        private string documento;

        public Usuarios(string usuario, string clave, int rolid, string documento)
        {
            this.nombreusuario = usuario;
            this.clave = clave;
            this.rolid = rolid;
            this.documento = documento;
        }

        public string NombreUsuario { get => nombreusuario; set => nombreusuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public int RolID { get => rolid; set => rolid = value; }
        public string Documento { get => documento; set => documento = value; }
    }
}
