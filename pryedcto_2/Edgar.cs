namespace pryedcto_2
{
    // Clase principal Edgar
    public class Edgar
    {
        public Edgar()
        {
        }

        public void Inicio()
        {
            Console.WriteLine("Inicianlizando maquina.");
        }

        public void MensajeInicio()
        {
            Console.WriteLine("El programa comenzará pronto.");
        }
    }

    // Clase para encender la banda, hereda de Edgar
    public class Encendido : Edgar
    {
        public void Encender()
        {
            base.Inicio();
            Console.WriteLine("La banda se ha encendido.");
        }
    }

    // Clase para demostrar herencia y sobrecarga de métodos
    public class HerenciaEdgar : Edgar
    {
        public void MostrarMensajes()
        {
            base.Inicio();
            base.MensajeInicio();
        }
    }

    // Clase Motor con propiedades y método para mostrar datos
    public class Motor
    {
        public int Velocidad { get; set; }
        public int Aceleracion { get; set; }
        public int Frenado { get; set; }

        public Motor(int velocidad, int aceleracion, int frenado)
        {
            Velocidad = velocidad;
            Aceleracion = aceleracion;
            Frenado = frenado;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Velocidad: {Velocidad}, Aceleración: {Aceleracion}, Frenado: {Frenado}");
        }
    }

    // Clase Datos que hereda de Motor y agrega un mensaje adicional
    public class Datos : Motor
    {
        public Datos(int velocidad, int aceleracion, int frenado) : base(velocidad, aceleracion, frenado)
        {
        }

        public void Mostrar()
        {
            base.MostrarDatos();
            Console.WriteLine("Datos del motor mostrados correctamente.");
        }
    }
}

