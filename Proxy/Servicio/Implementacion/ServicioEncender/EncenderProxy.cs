using Proxy.Servicio.Interface;

namespace Proxy.Servicio.Implementacion.ServicioEncender
{
    public class EncenderProxy : IServicioEncender
    {
        private IServicioEncender IServicioEncender;

        public EncenderProxy(IServicioEncender _IServicioEncender)
        {
            this.IServicioEncender = _IServicioEncender;
        }

        public string CheckAccess(int _iLlave)
        {
            string cMensaje = "";
            if (_iLlave == 1)
                cMensaje= this.IServicioEncender.ArrancarMotor(_iLlave);
            else
                cMensaje = "Error de llave";
            return cMensaje;
        }

        public string ArrancarMotor(int _iLlave)
        {
            string cMensaje = "";
            cMensaje=CheckAccess(_iLlave);
            return cMensaje;
        }
    }
}
