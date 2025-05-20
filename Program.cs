// logica para cargar el numero //
// variables para cargar el numero //
int numero;
bool resultadoConversion;
// bucle para cargar el numero //
do
{
    // pedimos el numero por consola //
    Console.WriteLine("Ingrese un numero");
    string numeroCadena = Console.ReadLine();
    // tratamos de convertir la cadena a un numero //
    resultadoConversion = int.TryParse(numeroCadena, out numero);
    if (!resultadoConversion)
    {
        Console.WriteLine("no se pudo convertir la cadena a un numero");
    }
} while (!resultadoConversion);

// logica para invertir el numero solamente si es mayor que 0 //
if (numero > 0)
{
    // variables que vamos a utilizar para invertir el numero //
    int resto, cociente = numero, invertido = 0;
    do
    {
        // dividimos el numero entre 10 para obtener el resto o el ultimo digito //
        resto = cociente % 10;
        // calculamos el cociente para eliminar el ultimo numero //
        cociente /= 10;
        invertido = invertido * 10 + resto;
    } while (cociente != 0);
    Console.WriteLine($"Numero Invertido: {invertido}");
}
else
{
    Console.WriteLine("el numero es menor o igual a 0");
}