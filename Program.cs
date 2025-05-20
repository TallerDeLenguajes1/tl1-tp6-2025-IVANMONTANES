// < > //
// menu de operaciones //
bool salirMenu = false;
while (!salirMenu)
{
    Console.WriteLine("=============== OPERACIONES ==================");
    Console.WriteLine("1: SUMAR");
    Console.WriteLine("2: RESTAR");
    Console.WriteLine("3: MULTIPLICAR");
    Console.WriteLine("4: DIVIDIR");
    Console.WriteLine("eliga una opcion:");
    string cadenaOpcion = Console.ReadLine();
    // tratamos de convertir la cadena a un numero //
    int opcion;
    int.TryParse(cadenaOpcion, out opcion);
    // cuando se ingrese una de las opciones //
    if (opcion >= 1 && opcion <= 4)
    {
        // logica para pedir los 2 numeros //
        // variables para cargar los numeros //
        // tratamos de convertir los numeros //
        double numero1 = 0;
        double numero2 = 0;
        string cadenaNumero1 = string.Empty;
        string cadenaNumero2 = string.Empty;
        bool primerNumeroCargado = false;
        bool segundoNumeroCargado = false;

        // cargamos el primer numero//
        Console.WriteLine("============================");
        while (!primerNumeroCargado)
        {
            Console.WriteLine("ingrese el primer numero");
            cadenaNumero1 = Console.ReadLine();
            primerNumeroCargado = double.TryParse(cadenaNumero1, out numero1);
            if (!primerNumeroCargado)
            {
                Console.WriteLine("No se pudo cargar el numero");
            }
        }

        // cargamos el segundo numero //
        while (!segundoNumeroCargado)
        {
            Console.WriteLine("ingrese el segundo numero");
            cadenaNumero2 = Console.ReadLine();
            segundoNumeroCargado = double.TryParse(cadenaNumero2, out numero2);
            if (!segundoNumeroCargado)
            {
                Console.WriteLine("No se pudo cargar el numero");
            }
        }

        // logica para aplicar cada operacion //
        switch (opcion)
        {
            case 1: Console.WriteLine($"SUMA = {numero1 + numero2}"); break;

            case 2: Console.WriteLine($"RESTA = {numero1 - numero2}"); break;

            case 3: Console.WriteLine($"PRODUCTO = {numero1 * numero2}"); break;

            case 4:
                if (numero2 != 0)
                {
                    Console.WriteLine($"COCIENTE = {numero1 / numero2}");
                }
                else
                {
                    Console.WriteLine("no se puede dividir entre 0");
                }
                break;
        }
    }
    else
    {
        Console.WriteLine("no se indico una opcion valida");
    }
    Console.WriteLine("============================");
    // preguntamos al usuario si desea realizar otra operacion //
    Console.WriteLine("1 para seguir");
    string CadenaSeguir = Console.ReadLine();
    int seguir;
    int.TryParse(CadenaSeguir, out seguir);
    if (seguir != 1)
    {
        salirMenu = true;
    }
}
Console.WriteLine("SALIENDO...");
