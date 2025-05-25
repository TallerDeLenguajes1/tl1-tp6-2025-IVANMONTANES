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