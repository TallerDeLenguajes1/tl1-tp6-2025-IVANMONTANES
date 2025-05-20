// < > //
// menu de operaciones //
bool salirMenu = false;
while (!salirMenu)
{
    // agregamos las nuevas opciones al menu //
    Console.WriteLine("=============== OPERACIONES ==================");
    Console.WriteLine("1: SUMAR");
    Console.WriteLine("2: RESTAR");
    Console.WriteLine("3: MULTIPLICAR");
    Console.WriteLine("4: DIVIDIR");
    Console.WriteLine("5: VALOR ABSOLUTO");
    Console.WriteLine("6: CUADRADO DE UN NUMERO");
    Console.WriteLine("7: RAIZ CUADRADA DE UN NUMERO");
    Console.WriteLine("8: SENO");
    Console.WriteLine("9: COSENO");
    Console.WriteLine("10: PARTE ENTERA");
    Console.WriteLine("eliga una opcion:");
    string cadenaOpcion = Console.ReadLine();
    // tratamos de convertir la cadena a un numero //
    int opcion;
    int.TryParse(cadenaOpcion, out opcion);
    // cuando se ingrese una de las opciones //
    if (opcion >= 1 && opcion <= 10)
    {
        // tomamos 2 casos diferentes las operaciones que requieren 2 numeros y las que requieren 1 //
        Console.WriteLine("============================");
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
            // logica para pedir el numero //
            // variables para cargar el numero //
            string cadenaNumero = string.Empty;
            double numero = 0;
            bool numeroCargado;
            do
            {
                Console.WriteLine("ingrese un numero:");
                cadenaNumero = Console.ReadLine();
                numeroCargado = double.TryParse(cadenaNumero, out numero);
                if (!numeroCargado)
                {
                    Console.WriteLine("No se pudo cargar el numero");
                }
            } while (!numeroCargado);

            // logica para aplicar cada operacion //
            switch (opcion)
            {
                case 5: Console.WriteLine($"VALOR ABSOLUTO = {Math.Abs(numero)}"); break;

                case 6: Console.WriteLine($"CUADRADO = {Math.Pow(numero, 2)}"); break;

                // verificamos si el numero es mayor que 0 para calcular la raiz cuadrada //

                case 7:
                    if (numero >= 0)
                    {
                        Console.WriteLine($"RAIZ CUADRADA: {Math.Sqrt(numero)}"); break;
                    }
                    else
                    {
                        Console.WriteLine("NO EXISTE LA RAIZ CUADRADA DE UN NUMERO NEGATIVO");
                    }
                    break;


                case 8: Console.WriteLine($"SENO = {Math.Sin(numero)}"); break;

                case 9: Console.WriteLine($"COSENO = {Math.Cos(numero)}"); break;

                case 10: Console.WriteLine($"PARTE ENTERA = {Math.Floor(numero)}"); break;
            }
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

Console.WriteLine("=================== MAXIMO Y MINIMO =================");
// solicitamos 2 numeros //
double numero1_2 = 0;
double numero2_2 = 0;
string cadenaNumero1_2 = string.Empty;
string cadenaNumero2_2 = string.Empty;
bool primerNumeroCargado_2 = false;
bool segundoNumeroCargado_2 = false;
// cargamos el primer numero//
while (!primerNumeroCargado_2)
{
    Console.WriteLine("ingrese el primer numero");
    cadenaNumero1_2 = Console.ReadLine();
    primerNumeroCargado_2 = double.TryParse(cadenaNumero1_2, out numero1_2);
    if (!primerNumeroCargado_2)
    {
        Console.WriteLine("No se pudo cargar el numero");
    }
}
// cargamos el segundo numero //
while (!segundoNumeroCargado_2)
{
    Console.WriteLine("ingrese el segundo numero");
    cadenaNumero2_2 = Console.ReadLine();
    segundoNumeroCargado_2 = double.TryParse(cadenaNumero2_2, out numero2_2);
    if (!segundoNumeroCargado_2)
    {
        Console.WriteLine("No se pudo cargar el numero");
    }
}

// determinamos el minimo y el maximo //
if (numero1_2 == numero2_2)
{
    Console.WriteLine("Son Iguales");
}
else
{

    Console.WriteLine($"MAXIMO = {Math.Max(numero1_2, numero2_2)}");
    Console.WriteLine($"MINIMO = {Math.Min(numero1_2, numero1_2)}");
}
 Console.WriteLine("=====================================================");
Console.WriteLine("Saliendo...");