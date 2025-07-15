namespace pryedcto_2
{
    public class Edgar
    {


        public Edgar()
        {

        }
        public void inicio()
        {
            Console.WriteLine("Hola jefe");
        }
        public void Mover1()
        {
            Console.WriteLine("El programa comenzará prontoo");
        }
    }

        public class Ensendido:Edgar
        {
            public void ensender()
        { 
                base.inicio();
                Console.WriteLine("La banda se ha encendido");
            }
             
        }

        public class ErenciaEd : Edgar
        {
            public void sobrecarga()
            {
                base.inicio();
                base.Mover1();
            }
        }
    
        public class Motor
        {
        public int Velocidad { get; set; }
        public int Aceleracion { get; set; }
        public int Frenado { get; set; }

        public Motor(int velocidad, int aceleracion, int frado)
            {
                this.Velocidad = velocidad;
                this.Aceleracion = aceleracion;
                this.Frenado = frado;
            }
            public void MostrarDatos()
            {
                Console.WriteLine($"Velocidad: {Velocidad}, Aceleración: {Aceleracion}, Frenado: {Frenado}");
            }

        }
        public class Datos : Motor
        {
            public Datos(int velocidad, int aceleracion, int frado) : base(velocidad, aceleracion, frado)
            {
            
            }
            public void Mostrar()
            {
                base.MostrarDatos();
                Console.WriteLine("Datos del motor mostrados correctamente.");
            }
        
    }
}

