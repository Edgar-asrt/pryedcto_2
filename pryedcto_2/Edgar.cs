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
                Console.WriteLine("El programa comenzará pronto");
            }
        

        public class ensendido
        {
            public void ensender()
            {
                Console.WriteLine("La banda se ha encendido");
            }
            public ensendido()
            {
            
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
    }
}

