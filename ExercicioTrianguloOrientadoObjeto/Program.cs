namespace ExercicioTrianguloOrientadoObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo valores = new Triangulo();

            Console.WriteLine(" ------- Triângulos -------");
            Console.WriteLine(" -- Digite um valor para X: ");
            valores.valorXis = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(" -- Digite um valor para Y: ");
            valores.valorYpsolon = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" -- Digite um valor para Z: ");
            valores.valorZeh = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Verificando os valores...{valores.VerificarTriangulo()}");
            Console.ReadLine();
        }
    }
}