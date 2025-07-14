using Proyecto;

namespace pryedcto_2
{
    public class Instancia
    {
        public Edgar edgar = new Edgar();
        public Datos Datos = new Datos(10, 50, 20);
        public Ivanna ivanna = new Ivanna();  // Aquí se declara la clase que ya tiene ActivarSensores()
        public Bueno Bueno = new Bueno();
        public Jairo Jairo = new Jairo();

        public void EdgarInicio()
        {
            Ensendido encender = new Ensendido();
            encender.ensender();
            Datos.Mostrar();
        }

        public void IvannaInicio()
        {
            ivanna.ActivarSensores();  // ✅ Este método ya existe y funciona
        }

        public void extraccionB()
        {
            Bueno bueno = new Bueno();
            bueno.Mover1();
        }

        public void partejairo()
        {
            Jairo jairo = new Jairo();
            jairo.Comenzar();
            jairo.flexion();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Instancia instancia = new Instancia();

            instancia.EdgarInicio();
            instancia.extraccionB();
            instancia.IvannaInicio();
            instancia.partejairo();

            Console.WriteLine("\n=== Fin del Programa ===");
        }
    }
}