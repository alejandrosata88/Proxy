using Proxy.Servicio.Interface;

namespace Proxy.Servicio.Implementacion.ServicioEncender
{
    public class Encender : IServicioEncender
    {
        public string ArrancarMotor(int _iLlave)
        {
            return "Se encendio el motor";
        }
    }
}
