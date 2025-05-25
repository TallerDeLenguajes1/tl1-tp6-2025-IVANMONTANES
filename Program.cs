/*
// pedimos la cadena al usuario //
Console.WriteLine("=============== LONGITUD CADENA ==================");
string cadena = string.Empty;
Console.WriteLine("ingrese la cadena:");
cadena = Console.ReadLine();
// mostramos la longitud de la cadena //
int longitudCadena = cadena.Length;
Console.WriteLine($"Longitud de la cadena: {longitudCadena} caracteres");
// pedimos una segunda cadena //
Console.WriteLine("=============== CONCATENAR CADENAS ==================");
string cadena2 = string.Empty;
Console.WriteLine("ingrese otra cadena:");
cadena2 = Console.ReadLine();
// concatenamos ambas cadenas usando + //
Console.WriteLine("Cadena Concatenada:" + cadena + cadena2);
// extraemos una subcadena de la cadena ingresada (la primera) //
Console.WriteLine("=============== EXTRAER SUBCADENA ==================");
int indice = default;
do
{
    Console.WriteLine($"ingrese el indice desde donde desea obtener la subcadena de la palabra {cadena}:");
} while (!int.TryParse(Console.ReadLine(), out indice));
// verificamos que el indice ingresado sea mayor o igual que 0 y menor que el lenght de la cadena //
if (!(indice >= 0 && indice < cadena.Length))
{
    Console.WriteLine("no se puede obtener una subcadena con ese indice");
}
else
{
    // usamos el metodo substring //
    string subcadena = cadena.Substring(indice);
    Console.WriteLine($"Subcadena: {subcadena}");
}

// menu de operaciones //
bool salirMenu = false;
while (!salirMenu)
{
    Console.WriteLine("=============== OPERACIONES ==================");
    Console.WriteLine("1: SUMAR");
    Console.WriteLine("2: RESTAR");
    Console.WriteLine("3: MULTIPLICAR");
    Console.WriteLine("4: DIVIDIR");
    string cadenaOpcion = Console.ReadLine();
    // tratamos de convertir la cadena a un numero //
    int opcion;
    int.TryParse(cadenaOpcion, out opcion);
    // cuando se ingrese una de las opciones //
    if (opcion >= 1 && opcion <= 4)
    {
        // cargamos el primer numero //
        double numero1 = default;
        bool numero1Cargado = false;
        do
        {
            Console.WriteLine("ingrese el primer numero:");
            numero1Cargado = double.TryParse(Console.ReadLine(), out numero1);
            if (!numero1Cargado)
            {
                Console.WriteLine("No se pudo realizar la conversion a un numero");
            }
        } while (!numero1Cargado);

        // cargamos el segundo numero //
        double numero2 = default;
        bool numero2Cargado = false;
        do
        {
            Console.WriteLine("ingrese el segundo numero:");
            numero2Cargado = double.TryParse(Console.ReadLine(), out numero2);
            if (!numero2Cargado)
            {
                Console.WriteLine("No se pudo realizar la conversion a un numero");
            }
        } while (!numero2Cargado);

        // realizamos las operaciones //
        switch (opcion)
        {
            case 1:
                Console.WriteLine($"La suma de {numero1:f2} y de {numero2:f2} es igual a: {numero1 + numero2:f2}");
                break;

            case 2:
                Console.WriteLine($"La resta de {numero1:f2} y de {numero2:f2} es igual a: {numero1 - numero2:f2}");
                break;

            case 3:
                Console.WriteLine($"el producto de {numero1:f2} y de {numero2:f2} es igual a: {numero1 * numero2:f2}");
                break;

            case 4:
                if (numero2 == 0)
                {
                    Console.WriteLine("no se puede dividir entre 0");
                }
                else
                {
                    Console.WriteLine($"el cociente de {numero1:f2} y {numero2:f2} es igual a {numero1 / numero2:f2} ");
                }
                break;
        }
    }
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

// recorremos la cadena (la primera) usando un ciclo foreach //
Console.WriteLine("=================== CADENA CON FOREACH ===================");
int indiceCadena = 0;
foreach (var caracter in cadena)
{
    Console.WriteLine($"{indiceCadena}: {caracter}");
    indiceCadena++;
}

// pedimos una nueva cadena y buscamos si aparece en la cadena (la primera) //
Console.WriteLine("=================== BUSCAR OCURRENCIA ===================");
Console.WriteLine("ingrese una palabra:");
string palabra = Console.ReadLine();
int retornoIndexOf = cadena.IndexOf(palabra);
// verificamos que se haya encontrado //
if (retornoIndexOf != -1)
{
    Console.WriteLine("========= CADENA ENCONTRADA ===========");
    Console.WriteLine($"cadena ingresada: {palabra}");
    Console.WriteLine($"cadena donde se busco: {cadena}");
    Console.WriteLine($"encontrada en el indice {retornoIndexOf}");
}
else
{
    Console.WriteLine("========== CADENA NO ENCONTRADA ==========");
    Console.WriteLine($"cadena ingresada: {palabra}");
    Console.WriteLine($"cadena donde se busco: {cadena}");
}

// convertimos la cadena (la primera) a mayuscula //
Console.WriteLine("=================== CADENA EN MAYUSCULA ===================");
string cadenaMayuscula = cadena.ToUpper();
Console.WriteLine($"cadena en mayuscula: {cadenaMayuscula}");

// convertimos la cadena (la primera) a minuscula //
Console.WriteLine("=================== CADENA EN MINUSCULA ===================");
string cadenaMinuscula = cadena.ToLower();
Console.WriteLine($"cadena en mayuscula: {cadenaMinuscula}");

Console.WriteLine("=================== SPLIT ===================");
// pedimos una cadena separada por los caracteres (- / _ o espacio)//
Console.WriteLine("ingrese una cadena de caracteres:");
string cadenaSeparadas = Console.ReadLine();
char[] separadores = [' ', '/', '-', '_'];
string[] retornoSplit = cadenaSeparadas.Split(separadores,StringSplitOptions.RemoveEmptyEntries);
// mostramos el resultado con un foreach //
foreach (var elemento in retornoSplit)
{
    Console.WriteLine(elemento);
}*/

// pedimos que ingrese una operacion combinada //

Console.WriteLine("ingrese una operacion combinada de 2 terminos:");
string operacionCombinadaSimple = Console.ReadLine();
// usamos split para separar los numeros //
char[] separadores = ['+', '*', '-','/',' '];
string[] numeros = operacionCombinadaSimple.Split(separadores, StringSplitOptions.RemoveEmptyEntries);
// usamos split para obtener el operador aritmetico//
char[] separadores2 = ['0','1', '2', '3', '4', '5', '6', '7', '8', '9', ',', '.',' '];
string[] signo = operacionCombinadaSimple.Split(separadores2, StringSplitOptions.RemoveEmptyEntries);
bool fallo1 = false,fallo2=false;
double numero1 = default, numero2 = default;
if (numeros.Length == 2)
{
    fallo1 = double.TryParse(numeros[0], out numero1);
    fallo2 = double.TryParse(numeros[1], out numero2);
    if (fallo1 && fallo2)
    {
        if (signo.Length == 1 && numeros.Length == 2)
        {
            // usamos split para que no se vean los espacios en blanco en caso de haber insertado muchos //
            char[] separadores3 = [' '];
            string[] operacionFormateada = operacionCombinadaSimple.Split(separadores3, StringSplitOptions.RemoveEmptyEntries);
            // concatenamos los elementos //
            string concatenado = string.Empty;
            int contador = 0;
            foreach (var elemento in operacionFormateada)
            {
                concatenado = string.Concat(concatenado, elemento);
                if (contador < operacionFormateada.Length-1)
                {
                    concatenado = string.Concat(concatenado, " ");
                }
                contador++;
            }
            switch (signo[0])
            {
                case "+": Console.WriteLine($"{concatenado} = {numero1 + numero2}"); break;

                case "-": Console.WriteLine($"{concatenado} = {numero1 - numero2}"); break;

                case "*": Console.WriteLine($"{concatenado} = {numero1 * numero2}"); break;

                case "/":
                    if (numero2 != 0)
                    {
                        Console.WriteLine($"{concatenado} = {numero1 / numero2}");
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
            Console.WriteLine("ingrese una ecuacion simple de 2 terminos");
        }
    }
    else
    {
        Console.WriteLine("uno o ambos terminos no son numeros");
    }
}
else
{
    Console.WriteLine("ingrese una ecuacion simple de 2 terminos");
}
    