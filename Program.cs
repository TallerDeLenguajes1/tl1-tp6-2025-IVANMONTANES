// pedimos la cadena al usuario //
string cadena = string.Empty;
Console.WriteLine("ingrese la cadena:");
cadena = Console.ReadLine();
// mostramos la longitud de la cadena //
int longitudCadena = cadena.Length;
Console.WriteLine($"Longitud de la cadena: {longitudCadena} caracteres");
// pedimos una segunda cadena //
string cadena2 = string.Empty;
Console.WriteLine("ingrese otra cadena:");
cadena2 = Console.ReadLine();
// concatenamos ambas cadenas usando + //
Console.WriteLine("Cadena Concatenada:" + cadena + cadena2);
// extraemos una subcadena de la cadena ingresada (la primera) //
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

