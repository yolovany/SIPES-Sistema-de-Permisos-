using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Solicitud
    {
        #region Atributos

        int _involucrados;
        int _idSolicitud;
        string _FechaSolicitud;
        int _NumeroEmpleado;
        int _CostoEvento;
        int _RecursoCombustibleDef;
        int _FolioSolicitud;
        string _EstadoSolicitud;
        string _NombreMaestro;
        string _EmailSolicitante;
        string _CategoriaEmpleado;
        string _NombreEvento;
        string _LugarEvento;
        string _FechaSalida;
        string _HoraSalida;
        string _FechaRegreso;
        string _HoraRegreso;
        bool _RecursoHospedajeCheckbool;
        bool _RecursoViaticosCheckbool;
        bool _RecursoTransporteCheckbool;
        string _RecursoTransporteDef;
        bool _RecursoOficioComisionbool;
        bool _RecursoCombustibleCheckbool;
        bool _RecursoOtroCheckbool;
        string _RecursoOtroDef;
        bool _ActAsociadaCACEICIEESCheckbool;
        bool _ActAsociadaISO90012008Checkbool;
        bool _ActAsociadaLicenciaturaCheckbool;
        bool _ActAsociadaPosgradoCheckbool;
        bool _ActAsociadaPersonalCheckbool;
        bool _ActAsociadaOtraCheckbool;
        string _ActAsociadaOtraDef;
     

        bool _CarrAsociadaCivilCheck;
        bool _CarrAsociadaComputacionCheck;
        bool _CarrAsociadaElectronicaCheck;
        bool _CarrAsociadaIndustrialCheck;
        bool _CarrAsociadaArquitecturaCheck;
        bool _CarrAsociadaBioingenieriaCheck;
        bool _CarrAsociadaNanotecnologiaCheck;

        bool _RevCoordinadorCivil;
        bool _RevCoordinadorElectronica;
        bool _RevCoordinadorComputacion;
        bool _RevCoordinadorIndustrial;
        bool _RevCoordinadorArquitectura;
        bool _RevCoordinadorBioingenieria;
        bool _RevCoordinadorNanotecnologia;
        bool _RevDirector;
        bool _RevSubdirector;
        bool _RevAdministrador;
        bool _RevPosgrado;

        bool _AprobadoCoordinadorCivil;
        bool _AprobadoCoordinadorElectronica;
        bool _AprobadoCoordinadorComputacion;
        bool _AprobadoCoordinadorIndustrial;
        bool _AprobadoCoordinadorArquitectura;
        bool _AprobadoCoordinadorBioingenieria;
        bool _AprobadoCoordinadorNanotecnologia;
        bool _AprobadoSubDirector;
        bool _AprobadoAdministrador;
        bool _AprobadoDirector;
        bool _AprobadoPosgrado;

        #endregion

        #region Encapsulamiento
        public int IdSolicitud
        {
            get
            {
                return _idSolicitud;
            }

            set
            {
                _idSolicitud = value;
            }
        }

        public string FechaSolicitud
        {
            get
            {
                return _FechaSolicitud;
            }

            set
            {
                _FechaSolicitud = value;
            }
        }

        public int NumeroEmpleado
        {
            get
            {
                return _NumeroEmpleado;
            }

            set
            {
                _NumeroEmpleado = value;
            }
        }

        public int CostoEvento
        {
            get
            {
                return _CostoEvento;
            }

            set
            {
                _CostoEvento = value;
            }
        }

        public int RecursoCombustibleDef
        {
            get
            {
                return _RecursoCombustibleDef;
            }

            set
            {
                _RecursoCombustibleDef = value;
            }
        }

        public int FolioSolicitud
        {
            get
            {
                return _FolioSolicitud;
            }

            set
            {
                _FolioSolicitud = value;
            }
        }

        public string EstadoSolicitud
        {
            get
            {
                return _EstadoSolicitud;
            }

            set
            {
                _EstadoSolicitud = value;
            }
        }

        public string NombreMaestro
        {
            get
            {
                return _NombreMaestro;
            }

            set
            {
                _NombreMaestro = value;
            }
        }

        public string EmailSolicitante
        {
            get
            {
                return _EmailSolicitante;
            }

            set
            {
                _EmailSolicitante = value;
            }
        }

        public string CategoriaEmpleado
        {
            get
            {
                return _CategoriaEmpleado;
            }

            set
            {
                _CategoriaEmpleado = value;
            }
        }

        public string NombreEvento
        {
            get
            {
                return _NombreEvento;
            }

            set
            {
                _NombreEvento = value;
            }
        }

        public string LugarEvento
        {
            get
            {
                return _LugarEvento;
            }

            set
            {
                _LugarEvento = value;
            }
        }

        public string FechaSalida
        {
            get
            {
                return _FechaSalida;
            }

            set
            {
                _FechaSalida = value;
            }
        }

        public string HoraSalida
        {
            get
            {
                return _HoraSalida;
            }

            set
            {
                _HoraSalida = value;
            }
        }

        public string FechaRegreso
        {
            get
            {
                return _FechaRegreso;
            }

            set
            {
                _FechaRegreso = value;
            }
        }

        public string HoraRegreso
        {
            get
            {
                return _HoraRegreso;
            }

            set
            {
                _HoraRegreso = value;
            }
        }

        public bool RecursoHospedajeCheckbool
        {
            get
            {
                return _RecursoHospedajeCheckbool;
            }

            set
            {
                _RecursoHospedajeCheckbool = value;
            }
        }

        public bool RecursoViaticosCheckbool
        {
            get
            {
                return _RecursoViaticosCheckbool;
            }

            set
            {
                _RecursoViaticosCheckbool = value;
            }
        }

        public bool RecursoTransporteCheckbool
        {
            get
            {
                return _RecursoTransporteCheckbool;
            }

            set
            {
                _RecursoTransporteCheckbool = value;
            }
        }

        public string RecursoTransporteDef
        {
            get
            {
                return _RecursoTransporteDef;
            }

            set
            {
                _RecursoTransporteDef = value;
            }
        }

        public bool RecursoOficioComisionbool
        {
            get
            {
                return _RecursoOficioComisionbool;
            }

            set
            {
                _RecursoOficioComisionbool = value;
            }
        }

        public bool RecursoCombustibleCheckbool
        {
            get
            {
                return _RecursoCombustibleCheckbool;
            }

            set
            {
                _RecursoCombustibleCheckbool = value;
            }
        }

        public bool RecursoOtroCheckbool
        {
            get
            {
                return _RecursoOtroCheckbool;
            }

            set
            {
                _RecursoOtroCheckbool = value;
            }
        }

        public string RecursoOtroDef
        {
            get
            {
                return _RecursoOtroDef;
            }

            set
            {
                _RecursoOtroDef = value;
            }
        }

        public bool ActAsociadaCACEICIEESCheckbool
        {
            get
            {
                return _ActAsociadaCACEICIEESCheckbool;
            }

            set
            {
                _ActAsociadaCACEICIEESCheckbool = value;
            }
        }

        public bool ActAsociadaISO90012008Checkbool
        {
            get
            {
                return _ActAsociadaISO90012008Checkbool;
            }

            set
            {
                _ActAsociadaISO90012008Checkbool = value;
            }
        }

        public bool ActAsociadaLicenciaturaCheckbool
        {
            get
            {
                return _ActAsociadaLicenciaturaCheckbool;
            }

            set
            {
                _ActAsociadaLicenciaturaCheckbool = value;
            }
        }

        public bool ActAsociadaPosgradoCheckbool
        {
            get
            {
                return _ActAsociadaPosgradoCheckbool;
            }

            set
            {
                _ActAsociadaPosgradoCheckbool = value;
            }
        }

        public bool ActAsociadaPersonalCheckbool
        {
            get
            {
                return _ActAsociadaPersonalCheckbool;
            }

            set
            {
                _ActAsociadaPersonalCheckbool = value;
            }
        }

        public bool ActAsociadaOtraCheckbool
        {
            get
            {
                return _ActAsociadaOtraCheckbool;
            }

            set
            {
                _ActAsociadaOtraCheckbool = value;
            }
        }

        public string ActAsociadaOtraDef
        {
            get
            {
                return _ActAsociadaOtraDef;
            }

            set
            {
                _ActAsociadaOtraDef = value;
            }
        }



        public bool AprobadoSubDirector
        {
            get
            {
                return _AprobadoSubDirector;
            }

            set
            {
                _AprobadoSubDirector = value;
            }
        }

        public bool AprobadoAdministrador
        {
            get
            {
                return _AprobadoAdministrador;
            }

            set
            {
                _AprobadoAdministrador = value;
            }
        }

        public bool AprobadoDirector
        {
            get
            {
                return _AprobadoDirector;
            }

            set
            {
                _AprobadoDirector = value;
            }
        }

        public bool AprobadoPosgrado
        {
            get
            {
                return _AprobadoPosgrado;
            }

            set
            {
                _AprobadoPosgrado = value;
            }
        }

        public bool CarrAsociadaCivilCheck
        {
            get
            {
                return _CarrAsociadaCivilCheck;
            }

            set
            {
                _CarrAsociadaCivilCheck = value;
            }
        }

        public bool CarrAsociadaComputacionCheck
        {
            get
            {
                return _CarrAsociadaComputacionCheck;
            }

            set
            {
                _CarrAsociadaComputacionCheck = value;
            }
        }

        public bool CarrAsociadaElectronicaCheck
        {
            get
            {
                return _CarrAsociadaElectronicaCheck;
            }

            set
            {
                _CarrAsociadaElectronicaCheck = value;
            }
        }

        public bool CarrAsociadaIndustrialCheck
        {
            get
            {
                return _CarrAsociadaIndustrialCheck;
            }

            set
            {
                _CarrAsociadaIndustrialCheck = value;
            }
        }

        public bool CarrAsociadaArquitecturaCheck
        {
            get
            {
                return _CarrAsociadaArquitecturaCheck;
            }

            set
            {
                _CarrAsociadaArquitecturaCheck = value;
            }
        }

        public bool CarrAsociadaBioingenieriaCheck
        {
            get
            {
                return _CarrAsociadaBioingenieriaCheck;
            }

            set
            {
                _CarrAsociadaBioingenieriaCheck = value;
            }
        }

        public bool CarrAsociadaNanotecnologiaCheck
        {
            get
            {
                return _CarrAsociadaNanotecnologiaCheck;
            }

            set
            {
                _CarrAsociadaNanotecnologiaCheck = value;
            }
        }

        public int Involucrados
        {
            get
            {
                return _involucrados;
            }

            set
            {
                _involucrados = value;
            }
        }

        public bool RevCoordinadorCivil
        {
            get
            {
                return _RevCoordinadorCivil;
            }

            set
            {
                _RevCoordinadorCivil = value;
            }
        }

        public bool RevCoordinadorElectronica
        {
            get
            {
                return _RevCoordinadorElectronica;
            }

            set
            {
                _RevCoordinadorElectronica = value;
            }
        }

        public bool RevCoordinadorComputacion
        {
            get
            {
                return _RevCoordinadorComputacion;
            }

            set
            {
                _RevCoordinadorComputacion = value;
            }
        }

        public bool RevCoordinadorIndustrial
        {
            get
            {
                return _RevCoordinadorIndustrial;
            }

            set
            {
                _RevCoordinadorIndustrial = value;
            }
        }

        public bool RevCoordinadorArquitectura
        {
            get
            {
                return _RevCoordinadorArquitectura;
            }

            set
            {
                _RevCoordinadorArquitectura = value;
            }
        }

        public bool RevCoordinadorBioingenieria
        {
            get
            {
                return _RevCoordinadorBioingenieria;
            }

            set
            {
                _RevCoordinadorBioingenieria = value;
            }
        }

        public bool RevCoordinadorNanotecnologia
        {
            get
            {
                return _RevCoordinadorNanotecnologia;
            }

            set
            {
                _RevCoordinadorNanotecnologia = value;
            }
        }

        public bool RevDirector
        {
            get
            {
                return _RevDirector;
            }

            set
            {
                _RevDirector = value;
            }
        }

        public bool RevSubdirector
        {
            get
            {
                return _RevSubdirector;
            }

            set
            {
                _RevSubdirector = value;
            }
        }

        public bool RevAdministrador
        {
            get
            {
                return _RevAdministrador;
            }

            set
            {
                _RevAdministrador = value;
            }
        }

        public bool RevPosgrado
        {
            get
            {
                return _RevPosgrado;
            }

            set
            {
                _RevPosgrado = value;
            }
        }

        public bool AprobadoCoordinadorCivil
        {
            get
            {
                return _AprobadoCoordinadorCivil;
            }

            set
            {
                _AprobadoCoordinadorCivil = value;
            }
        }

        public bool AprobadoCoordinadorElectronica
        {
            get
            {
                return _AprobadoCoordinadorElectronica;
            }

            set
            {
                _AprobadoCoordinadorElectronica = value;
            }
        }

        public bool AprobadoCoordinadorComputacion
        {
            get
            {
                return _AprobadoCoordinadorComputacion;
            }

            set
            {
                _AprobadoCoordinadorComputacion = value;
            }
        }

        public bool AprobadoCoordinadorIndustrial
        {
            get
            {
                return _AprobadoCoordinadorIndustrial;
            }

            set
            {
                _AprobadoCoordinadorIndustrial = value;
            }
        }

        public bool AprobadoCoordinadorArquitectura
        {
            get
            {
                return _AprobadoCoordinadorArquitectura;
            }

            set
            {
                _AprobadoCoordinadorArquitectura = value;
            }
        }

        public bool AprobadoCoordinadorBioingenieria
        {
            get
            {
                return _AprobadoCoordinadorBioingenieria;
            }

            set
            {
                _AprobadoCoordinadorBioingenieria = value;
            }
        }

        public bool AprobadoCoordinadorNanotecnologia
        {
            get
            {
                return _AprobadoCoordinadorNanotecnologia;
            }

            set
            {
                _AprobadoCoordinadorNanotecnologia = value;
            }
        }



        #endregion

        public E_Solicitud()
        {
            FechaSolicitud = string.Empty;
            EstadoSolicitud = "PENDIENTE";
            NombreMaestro = string.Empty;
            EmailSolicitante = string.Empty;
            CategoriaEmpleado = string.Empty;
            NombreEvento = string.Empty;
            LugarEvento = string.Empty;
            FechaSalida = string.Empty;
            HoraSalida = string.Empty;
            FechaRegreso = string.Empty;
            HoraRegreso = string.Empty;
            RecursoHospedajeCheckbool = false;
            RecursoViaticosCheckbool = false;
            RecursoTransporteCheckbool = false;
            RecursoTransporteDef = string.Empty;
            RecursoOficioComisionbool = false;
            RecursoCombustibleCheckbool = false;
            RecursoOtroCheckbool = false;
            RecursoOtroDef = string.Empty;
            ActAsociadaCACEICIEESCheckbool = false;
            ActAsociadaISO90012008Checkbool = false;
            ActAsociadaLicenciaturaCheckbool = false;
            ActAsociadaPosgradoCheckbool = false;
            ActAsociadaPersonalCheckbool = false;
            ActAsociadaOtraCheckbool = false;
            ActAsociadaOtraDef = string.Empty;
  
            CarrAsociadaCivilCheck = false;
            CarrAsociadaComputacionCheck = false;
            CarrAsociadaElectronicaCheck = false;
            CarrAsociadaIndustrialCheck = false;
            CarrAsociadaArquitecturaCheck = false;
            CarrAsociadaBioingenieriaCheck = false;
            CarrAsociadaNanotecnologiaCheck = false;
            Involucrados = 0;

        }

    }
}
