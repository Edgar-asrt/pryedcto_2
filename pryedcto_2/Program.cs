using Proyecto;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using static pryedcto_2.Ivanna;

namespace pryedcto_2
{
    public class Instancia
    {
        public Edgar edgar = new Edgar();
        public Datos Datos = new Datos(10, 50, 20);  
        public Ivanna ivanna = new Ivanna();
        public Bueno Bueno = new Bueno();
        public Jairo Jairo = new Jairo();   
        public Sensores Sensores = new Sensores("Sensores");

        public void Edgar()
        {
            Ensendido encender = new Ensendido();
            encender.ensender();
            Datos.Mostrar();
        }
        public void Ivanna()
        {
            SensorMovimiento sensorMovimiento = new SensorMovimiento("Sensor de Movimiento");   
            sensorMovimiento.detectarObjeto();
            sensorMovimiento.contador(10);
            SensorVelocidad sensorVelocidad = new SensorVelocidad("Sensor de Velocidad");
            sensorVelocidad.CalcularVelocidad(10);
            SensorTolva sensorTolva = new SensorTolva("Sensor de Tolva");
            sensorTolva.drop();


        }
        public void extraccionB()
        {
            Bueno bueno = new Bueno();
            bueno.Mover1();
        }
        public void partejairo()
        {
            Jairo2 jairo2 = new Jairo2();
            jairo2.iniciojairo();   

        }


    }
   internal class Program
    {
       
        static void Main(string[] args)
        {

            Instancia instancia = new Instancia();
            instancia.Edgar();
            instancia.extraccionB();
            instancia.Ivanna();
            instancia.partejairo();
            

        }
    }
}
