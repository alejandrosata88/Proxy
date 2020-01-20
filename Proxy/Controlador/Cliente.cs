using Proxy.Servicio.Implementacion.ServicioEncender;
using Proxy.Servicio.Interface;
using System;

namespace Proxy.Controlador
{
    public class Cliente
    {
        public void Main()
        {
            string cMensaje= string.Empty;
            IServicioEncender IServiceEncender = new Encender();
            Console.WriteLine("se ingresa la llave 1");
            cMensaje=IServiceEncender.ArrancarMotor(1);
            Console.WriteLine(cMensaje);

            Console.WriteLine("se ingresa la llave 1");
            IServiceEncender = new EncenderProxy(IServiceEncender);
            cMensaje = IServiceEncender.ArrancarMotor(1);
            Console.WriteLine(cMensaje);

            Console.WriteLine("se ingresa la llave 2");
            cMensaje = IServiceEncender.ArrancarMotor(2);
            Console.WriteLine(cMensaje);
            Console.ReadLine();
        }
    }
}
