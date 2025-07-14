using Proyecto;

namespace pryedcto_2
{
    public class Ivanna
    {
        
        
            private Bueno _bueno = new Bueno();
            public bool detectarObjeto()
            {
                Console.WriteLine("Sensor: Se detectó objeto...");
                return true;
            }

            public bool Velocidad()
            {
                Console.WriteLine("Sensor: Calculando velocidad...");
                return true;
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
            public Ivanna()
            {

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
