using static pryedcto_2.Ivanna;

namespace Proyecto
{

    //2.-Condicionar el objeto para poder moverlo a diferentes direcciones así como
    //agregar o eliminar el mismo objeto para aumentar la cantidad del mismo
    public class Bueno
    {

        public class Sensores2
        {
            private string _nombre;

            public Sensores2(string _nombre)
            {
                this._nombre = _nombre;
            }
        }
        public float cajas;
        public int direccion;
        

            public void Mover1()
            {
                Console.WriteLine("Elije la direccion");
                Console.WriteLine("Izquierda(1) o Derecha(0)");
                int direccion = int.Parse(Console.ReadLine());
                Console.WriteLine("Elije la cantidad de cajas");

                float cajas = float.Parse(Console.ReadLine());

            }
        public class SensorProximidad : Sensores2
        {
            private float _velocidad;

            public SensorProximidad(string _nombre)
                : base(_nombre)
            {

                this._velocidad = _velocidad;
            }
            public void SensorProx(float _proximi)
            {
                Console.WriteLine("Sensor de proximidad: Detectando objetos...");
            }
        }

    }
}