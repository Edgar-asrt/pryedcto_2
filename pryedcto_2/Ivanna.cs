// Archivo corregido y organizado

using Proyecto;

namespace pryedcto_2
{
    public class Ivanna
    {
        protected string _nombre;
        protected Bueno _bueno;

        public Ivanna(string nombre = "Ivanna")
        {
            _nombre = nombre;
            _bueno = new Bueno();
        }

        public virtual bool detectarObjeto()
        {
            Console.WriteLine("Sensor: Se detectó objeto...");
            return true;
        }

        public virtual void contador(float objetosDetectados)
        {
            float cajasActuales = _bueno.cajas;

            if (objetosDetectados == cajasActuales)
                Console.WriteLine("Sensor: Cantidad correcta de objetos.");
            else if (objetosDetectados > cajasActuales)
                Console.WriteLine("Sensor: Hay demasiados objetos.");
            else
                Console.WriteLine("Sensor: Faltan objetos.");
        }

        // ✅ Método que centraliza sensores
        public void ActivarSensores()
        {
            SensoresManager manager = new SensoresManager();
            manager.IniciarSensores();
        }
    }

    public class SensorMovimiento : Ivanna
    {
        private int _cantidadObjetos;

        public SensorMovimiento(string nombre, int cantidadObjetos) : base(nombre)
        {
            _cantidadObjetos = cantidadObjetos;
        }

        public void detectarMovimiento()
        {
            Console.WriteLine($"Sensor de Movimiento '{_nombre}': Se detectó {_cantidadObjetos} objetos.");
        }
    }

    public class SensorVelocidad : Ivanna
    {
        private float _velocidad;

        public SensorVelocidad(string nombre, float velocidad) : base(nombre)
        {
            _velocidad = velocidad;
        }

        public void CalcularVelocidad()
        {
            Console.WriteLine($"Sensor de Velocidad '{_nombre}': Calculando velocidad: {_velocidad} m/s...");
        }
    }

    public class SensoresManager
    {
        public void IniciarSensores()
        {
            var sensorMov = new SensorMovimiento("Movimiento01", 5);
            sensorMov.detectarMovimiento();
            sensorMov.contador(5);

            var sensorVel = new SensorVelocidad("Velocidad01", 2.5f);
            sensorVel.CalcularVelocidad();
        }
    }
}
