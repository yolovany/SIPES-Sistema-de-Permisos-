using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_SolicitudRechazada
    {

        int _FolioSolicitudRechazada;
        string _NombreDeRechazante;
        string _RolRechazante;
        string _CorreoRechazante;
        string _MotivoRechazo;

        public E_SolicitudRechazada()
        {
            FolioSolicitudRechazada = _FolioSolicitudRechazada;
            NombreDeRechazante = _NombreDeRechazante;
            RolRechazante = _RolRechazante;
            CorreoRechazante = _CorreoRechazante;
            MotivoRechazo = _MotivoRechazo;
        }

        #region Encapsulamiento
        public int FolioSolicitudRechazada
        {
            get
            {
                return _FolioSolicitudRechazada;
            }

            set
            {
                _FolioSolicitudRechazada = value;
            }
        }

        public string NombreDeRechazante
        {
            get
            {
                return _NombreDeRechazante;
            }

            set
            {
                _NombreDeRechazante = value;
            }
        }

        public string RolRechazante
        {
            get
            {
                return _RolRechazante;
            }

            set
            {
                _RolRechazante = value;
            }
        }

        public string CorreoRechazante
        {
            get
            {
                return _CorreoRechazante;
            }

            set
            {
                _CorreoRechazante = value;
            }
        }

        public string MotivoRechazo
        {
            get
            {
                return _MotivoRechazo;
            }

            set
            {
                _MotivoRechazo = value;
            }
        }
        #endregion


    }
}
