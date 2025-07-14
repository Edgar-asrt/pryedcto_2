using Proyecto;

namespace pryedcto_2
{
    public class Ivanna
    {

        public class Sensores
        {
            private string _nombre;

            private Bueno _Bueno = new Bueno();

        
        
            private Bueno _bueno = new Bueno();
            public bool detectarObjeto()
            {
                Console.WriteLine("Sensor: Se detectó objeto...");
                return true;
            }

            public Sensores(string _nombre)
            {
                this._nombre = _nombre;
            }
            public class SensorMovimiento : Sensores
            {

                private int _cantidadObjetos;

                public SensorMovimiento(string _nombre)
                    :base(_nombre)
                {
                    this._nombre = "Sensor de Movimiento";
                    this._cantidadObjetos = _cantidadObjetos;
                }

                public void detectarObjeto(int _cantidadObjetos)
                {
                    Console.WriteLine("Sensor {0} : Se detectó objeto..." + _nombre);
                }

                float cajasActuales = _bueno.cajas;


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

                public SensorVelocidad(string _nombre)
                    : base(_nombre)
                {
                    this._nombre = "Sensor de Movimiento";
                    this._velocidad = _velocidad;
                }
                public void CalcularVelocidad(float _velocidad)
                {
                    Console.WriteLine("Sensor: Calculando velocidad...");
                }
            }
            public Ivanna()
            {


            public class SensorTolva : Sensores
            {
                private int _drop;
                public SensorTolva(string _nombre)
                    : base(_nombre)
                {
                    this._nombre = "Sensor de Tolva";
                    this._drop = _drop;
                }
                public void MedirTemperatura(float _drop)
                {
                    Console.WriteLine("Sensor: administrando objetos...");
                }
            }




            }

        
    }
    public class Sensores: Ivanna
    {
        private Bueno _bueno = new Bueno();
        public void IniciarSensores()
        {
           base.detectarObjeto();
           base.Velocidad();
           base.contador(_bueno.cajas);    
        }
    }
}
