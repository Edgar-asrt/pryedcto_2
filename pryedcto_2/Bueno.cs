using static pryedcto_2.Ivanna;

namespace Proyecto
{

    //2.-Condicionar el objeto para poder moverlo a diferentes direcciones así como
    //agregar o eliminar el mismo objeto para aumentar la cantidad del mismo
    public class Bueno
    {

        public class Sensores2
        {
            private string _nombre;

            public Sensores2(string _nombre)
            {
                this._nombre = _nombre;
            }
        }
        public float cajas;
        public int direccion;
        

        public void Mover1()
        {
            Console.WriteLine("Elige la dirección");
            Console.WriteLine("Izquierda (1) o Derecha (0)");
            this.direccion = int.Parse(Console.ReadLine());
            Console.WriteLine("Elige la cantidad de cajas");
            this.cajas = float.Parse(Console.ReadLine());
            Console.WriteLine($"Cantidad de cajas seleccionada: {this.cajas}");
        }
        
        public class SensorProximidad : Sensores2
        {
            private float _velocidad;

            public SensorProximidad(string _nombre)
                : base(_nombre)
            {

                this._velocidad = _velocidad;
            }
            public void SensorProx(float _proximi)
            {
                Console.WriteLine("Sensor de proximidad: Detectando objetos...");
                Console.WriteLine("Sensor de proximidad: Objetos detectados...");
            }
        }

        public class SensorMovimiento : Sensores2
        {
            private int _cantidadObjetos;
            private string _nombre = "Sensor de Movimiento";
            private Bueno _Bueno;

            public SensorMovimiento(string _nombre, Bueno bueno)
                : base(_nombre)
            {
                this._Bueno = bueno;
            }
        }

        public void CrearSensorMovimiento()
        {
            SensorMovimiento sensorMovimiento = new SensorMovimiento("Sensor de Movimiento", this);
        }
    }
}