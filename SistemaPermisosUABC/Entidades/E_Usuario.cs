using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Usuario
    {
        #region Atributos
        //atributos
        private int _noEmpleado;
        private string _nombre;
        private string _apellidos;
        private string _email;
        private string _password;
        private string _status;
        private string _rol;

        #endregion

        #region Encapsulados

        public int NoEmpleado
        {
            get
            {
                return _noEmpleado;
            }

            set
            {
                _noEmpleado = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }

        public string Rol
        {
            get
            {
                return _rol;
            }

            set
            {
                _rol = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }

            set
            {
                _apellidos = value;
            }
        }

        #endregion

        #region Contructor
        public E_Usuario()
        {
            NoEmpleado = 0;
            Nombre = string.Empty;
            Apellidos = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            Status = string.Empty;
            Rol = string.Empty;
        }

        #endregion
    }
}
