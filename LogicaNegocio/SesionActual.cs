using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public static class SesionActual
    {
        private static strUsuario usr = new strUsuario();

        private struct strUsuario
        {
            public int idUsuario;
            public int idNivel;
            public string login;
            public bool primerLogin;
            public int numNotificaciones;
        }

        public static int IdUsuario
        {
            get { return (usr.idUsuario); }
            set { usr.idUsuario = value; }
        }

        public static int IdNivel
        {
            get { return (usr.idNivel); }
            set { usr.idNivel = value; }
        }

        public static string Login
        {
            get { return (usr.login); }
            set { usr.login = value; }
        }

        public static bool PrimerLogin
        {
            get { return (usr.primerLogin); }
            set { usr.primerLogin = value; }
        }

        public static int NumNotificaciones
        {
            get { return (usr.numNotificaciones); }
            set { usr.numNotificaciones = value; }
        }
    }
}
