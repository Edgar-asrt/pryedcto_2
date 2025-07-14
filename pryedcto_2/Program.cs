using Proyecto;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace pryedcto_2
{
    public class Instancia
    {
        public Edgar edgar = new Edgar();
        public Datos Datos = new Datos(10, 50, 20);  
        public Ivanna ivanna = new Ivanna();
        public Bueno Bueno = new Bueno();
        public Jairo Jairo = new Jairo();   

        public void Edgar()
        {
            Ensendido encender = new Ensendido();
            encender.ensender();
            Datos.Mostrar();
        }
        public void Ivanna()
        {
           Sensores sensores = new Sensores();
           sensores.IniciarSensores();
        }
        public void extraccionB()
        {
            Bueno bueno = new Bueno();
            bueno.Mover1();
        }
        public void partejairo()
        {Jairo jairo = new Jairo();
            jairo.Comenzar();
            jairo.flexion();

        }


    }
   internal class Program
    {
       
        static void Main(string[] args)
        {

            Instancia instancia = new Instancia();
            instancia.Edgar();
            instancia.extraccionB();
            instancia.Ivanna();
            instancia.partejairo();
            

        }
    }
}
