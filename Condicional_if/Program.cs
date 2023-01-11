internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejemplo de variable boolean");
        bool haceFrio;
        haceFrio = false;

        Console.WriteLine(!haceFrio);

        Console.WriteLine("Ejemplo de condicional if");

        int edad = 0;
        Console.WriteLine("Vamos a evaluar si eres mayor de edad");
        edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad, puedes pasar.");
        }
        else
        {
            Console.WriteLine("No tienes la edad permitida para entrar");
        }


    }
}