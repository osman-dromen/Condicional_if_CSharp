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

        Console.WriteLine("Ejemplo del condicional IF con operadores lógicos");
        string nombre = "";
        bool carnet= false;
        string aux = "";

        Console.WriteLine("Escriba su nombre porfavor");
        nombre = Console.ReadLine();
        Console.WriteLine("Escriba su edad porfavor");
        edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Tienes carnet (si/no)");
        aux = Console.ReadLine();
        if (aux == "si") carnet = true;
        if (edad >= 18 && carnet)  Console.WriteLine($"{nombre} su edad de {edad} y teniendo carnet, tiene derecho a conducir el vehiculo");
        else  Console.WriteLine($"{nombre} su edad de {edad} y al no tener carnet, NO tiene derecho a conducir el vehiculo");






    }
}