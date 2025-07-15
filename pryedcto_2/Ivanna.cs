// Archivo corregido y organizado

using Proyecto;

namespace pryedcto_2
{
    public class Ivanna
    {
        public class Sensores
        {
            protected string _nombre;
            public Bueno _bueno = new Bueno(); // Aquí se mantiene la referencia al objeto Bueno

            public Sensores(string nombre)
            {
                _nombre = nombre;
            }

            public bool detectarObjeto()
            {
                Console.WriteLine("Sensor: Se detectó objeto...");
                return true;
            }
        }

        public class SensorMovimiento : Sensores
        {
            private int _cantidadObjetos;

            public SensorMovimiento(string nombre, int cantidadObjetos)
                : base(nombre)
            {
                _cantidadObjetos = cantidadObjetos;
            }

            public void detectarMovimiento()
            {
                Console.WriteLine($"Sensor {_nombre} : Se detectaron {_cantidadObjetos} objetos.");
            }

            public void contador(float objetosDetectados)
            {
                float cajasActuales = _bueno.cajas;

                if (objetosDetectados == cajasActuales)
                {
                    Console.WriteLine("Sensor: Cantidad correcta de objetos.");
                }
                else if (objetosDetectados > cajasActuales)
                {
                    Console.WriteLine("Sensor: Hay demasiados objetos.");
                }
                else
                {
                    Console.WriteLine("Sensor: Faltan objetos.");
                }
            }
        }

        public class SensorVelocidad : Sensores
        {
            private float _velocidad;

            public SensorVelocidad(string nombre, float velocidad)
                : base(nombre)
            {
                _velocidad = velocidad;
            }

            public void CalcularVelocidad()
            {
                Console.WriteLine($"Sensor {_nombre}: Calculando velocidad: {_velocidad} m/s");
            }
        }
    }

    public class ExtraccionIV : Ivanna
    {
        private SensorMovimiento sensorMov;
        private SensorVelocidad sensorVel;

        public ExtraccionIV()
        {
            // Crear sensores con valores que tú quieras
            sensorMov = new SensorMovimiento("Movimiento01", 5);
            sensorVel = new SensorVelocidad("Velocidad01", 2.5f);
        }

        public void Ejecutar()
        {
            sensorMov.detectarMovimiento();
            sensorMov.contador(5); // puedes pasar el valor desde afuera también

            sensorVel.CalcularVelocidad();
        }
    }
}
