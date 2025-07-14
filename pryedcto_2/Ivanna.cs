using Proyecto;

namespace pryedcto_2
{
    public class Ivanna
    {

        public class Sensores
        {
            private string _nombre;

            public Sensores(string _nombre)
            {
                this._nombre = _nombre;
            }
        }
            public class SensorMovimiento : Sensores
            {

                private int _cantidadObjetos;
                private string _nombre = "Sensor de Movimiento";

                private Bueno _Bueno = new Bueno();

                public SensorMovimiento(string _nombre)
                    :base(_nombre)
                {
                    this._cantidadObjetos = _cantidadObjetos;
                }

                public void detectarObjeto(int _cantidadObjetos)
                {
                 
                Console.WriteLine("Sensor {0} : Se detectó objeto..." + _nombre);
                }

                public void contador(float objetosDetectados)
                {
                    float cajasActuales = _Bueno.cajas;

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
                private string _nombre = "Sensor de Movimiento";

                public SensorVelocidad(string _nombre)
                    : base(_nombre)
                {
                    
                    this._velocidad = _velocidad;
                }
                public void CalcularVelocidad(float _velocidad)
                {
                    Console.WriteLine("Sensor: Calculando velocidad...");
                }
            }


            public class SensorTolva : Sensores
            {
                private int _drop;
                private string _nombre = "Sensor de Tolva";
            public SensorTolva(string _nombre)
                    : base(_nombre)
                {
                    this._drop = _drop;
                }
                public void MedirTemperatura(float _drop)
                {
                    Console.WriteLine("Sensor: administrando objetos...");
                }
            }




            

        
    }
    
}
