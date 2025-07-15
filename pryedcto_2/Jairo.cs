namespace pryedcto_2
{
    public class Jairo
    {
        public float velocidadd;
        public void Comenzar()
        {
            Console.WriteLine("Inicio del movimiento de la banda.");
            velocidadd = 10.0f;
            Console.WriteLine("La banda esta en movimiento: " + velocidadd);
            velocidadd = 0.0f;
            Console.WriteLine("La velocidad  esta disminullendo gradualmente.");
            Console.WriteLine("Se a detenido por completo la banda");
        }
        public void flexion()
        {
            float flexion = velocidadd * 0.5f; // Ejemplo de cálculo de flexión

            Console.WriteLine("La banda se encuentra en movimiento, no se puede flexionar.");
            

            Console.WriteLine($"la banda se ah detenido, calculando flexion.....{flexion}");

            Console.WriteLine("La flexion de la banda es....");
           
        }


    }
    public class Jairo2
    {
        public void iniciojairo()
        {
            Jairo jairo = new Jairo();
            jairo.Comenzar();
            jairo.flexion();
        }
    }
    


}
