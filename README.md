# ¿String es una tipo por valor o un tipo por referencia?
string es un tipo por referencia

# ¿Qué secuencias de escape tiene el tipo string?
- \a: campana(alerta)
- \b:	Retroceso
- \f:	Avance de página
- \n:	Nueva línea
- \r:	Retorno de carro
- \t:	Tabulación horizontal
- \v:	Tabulación vertical
- \\':	Comilla simple
- \\":	Comillas dobles
- \\\\:	Barra diagonal inversa
- \?:	Signo de interrogación literal

## ¿Qué sucede cuando utiliza el carácter @?
- cuando usamos el prefijo @ estamos indicando que la cadena debe intepretarse literalemente, es decir que por ejemplo las secuencias de escape no produciran caracteres especiales si no que se mostraran literalmente

## ¿Qué sucede cuando utiliza el carácter $?
- cuando usamos el prefijo $ nos permite interpolar cadenas, esto significa que podemos imprimir los valores de las variables dentro de la cadena incluyendo estas mismas dentro de llaves {}, por ejemplo si tuviesemos lo siguiente.

    int x = 2;
    Console.WriteLine($"valor de la variable: {x}");


    lo que veriamos por consola seria: "valor de la variable: 2"







