
namespace pryedcto_2
{
    
    public class Jairo
    {
        // Propiedad pública que representa la velocidad de la banda
        public float Velocidad { get; set; }

       
        public void Comenzar()
        {
            Console.WriteLine("Inicio del movimiento de la banda.");

            Velocidad = 10.0f; // Asigna una velocidad inicial

            Console.WriteLine("La banda está en movimiento: " + Velocidad);

            Velocidad = 0.0f; // Detiene la banda

            Console.WriteLine("La velocidad está disminuyendo gradualmente.");
            Console.WriteLine("Se ha detenido por completo la banda.");
        }

        // Método que calcula la flexión basada en la velocidad
        public void Flexion()
        {
            float flexion = Velocidad * 0.5f; // Cálculo de ejemplo

            Console.WriteLine("La banda se encuentra en movimiento, no se puede flexionar.");
            Console.WriteLine($"La banda se ha detenido, calculando flexión... {flexion}");
        }

        // Clase interna que representa un sensor de flexión
        public class SensorDeFlexion
        {
            private string _nombre;  
            private float _velocidad;   

            // Constructor que inicializa el nombre y velocidad del sensor
            public SensorDeFlexion(string nombre, float velocidad)
            {
                _nombre = nombre;
                _velocidad = velocidad;
            }

            // Método 
            public void DetectarFlexion()
            {
                float flexion = _velocidad * 0.5f; // Cálculo básico de flexión

               
                if (_velocidad > 0)
                {
                    Console.WriteLine($"{_nombre}: La banda se encuentra en movimiento, no se puede flexionar.");
                }
                else
                {
                    Console.WriteLine($"{_nombre}: La banda se ha detenido, calculando flexión... {flexion}");
                }
            }
        }
    }

    // Clase  Herencia que hereda de Jairo
    public class jairo2 : Jairo
    {
        // Método que llama a los métodos heredados de la clase base (Jairo)
        public void IniciarJairo()
        {
            base.Comenzar(); // Llama a Comenzar() desde la clase base Jairo
            base.Flexion();  // Llama a Flexion() desde la clase base Jairo
        }

        // Método que prueba el sensor de flexión
        public void ProbarSensorDeFlexion()
        {
            // Crea una instancia del sensor con velocidad 0
            var sensor = new Jairo.SensorDeFlexion("Sensor de Flexión activado", 0.0f);

            // Llama al método para detectar flexión
            sensor.DetectarFlexion();
        }
    }
}
