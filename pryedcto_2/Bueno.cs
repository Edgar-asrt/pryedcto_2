﻿namespace Proyecto
{

    //2.-Condicionar el objeto para poder moverlo a diferentes direcciones así como
    //agregar o eliminar el mismo objeto para aumentar la cantidad del mismo


    public class Bueno
    {


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
        
    }
}