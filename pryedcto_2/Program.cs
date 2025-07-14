using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace pryedcto_2
{
    public class Instancia
    {
        public Edgar edgar = new Edgar();
        public Datos Datos = new Datos(100, 50, 20);  // ✅ ahora sí le das los parámetros requeridos


        public void Edgar()
        {
            Ensendido encender = new Ensendido();
            encender.ensender();
        }
        public void Edgar1()
        {
           Datos.Mostrar();

        }

}
   internal class Program
    {
       
        static void Main(string[] args)
        {

            Instancia instancia = new Instancia();
            instancia.Edgar();
            instancia.Edgar1();
        }
    }
}
