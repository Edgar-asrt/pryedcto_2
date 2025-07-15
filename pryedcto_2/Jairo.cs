namespace pryedcto_2
{
    // Clase principal Jairo
    public class Jairo
    {
        public float Velocidad { get; set; }

        public void Comenzar()
        {
            Console.WriteLine("Inicio del movimiento de la banda.");
            Velocidad = 10.0f;
            Console.WriteLine("La banda está en movimiento: " + Velocidad);
            Velocidad = 0.0f;
            Console.WriteLine("La velocidad está disminuyendo gradualmente.");
            Console.WriteLine("Se ha detenido por completo la banda.");
        }

        public void Flexion()
        {
            float flexion = Velocidad * 0.5f; // Ejemplo de cálculo de flexión

            Console.WriteLine("La banda se encuentra en movimiento, no se puede flexionar.");
            Console.WriteLine($"La banda se ha detenido, calculando flexión... {flexion}");
         
        }

        // Clase interna para el sensor de flexión
        public class SensorDeFlexion
        {
            private string _nombre;
            private float _velocidad;

            public SensorDeFlexion(string nombre, float velocidad)
            {
                _nombre = nombre;
                _velocidad = velocidad;
            }

            public void DetectarFlexion()
            {
                float flexion = _velocidad * 0.5f;
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

    // Clase auxiliar para ejecutar pruebas de Jairo
    public class Jairo2
    {
        public void IniciarJairo()
        {
            Jairo jairo = new Jairo();
            jairo.Comenzar();
            jairo.Flexion();
        }

        public void ProbarSensorDeFlexion()
        {
            var sensor = new Jairo.SensorDeFlexion("Sensor de Flexión activado", 0.0f);
            sensor.DetectarFlexion();
        }
    }
}
