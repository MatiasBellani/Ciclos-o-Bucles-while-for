// See https://aka.ms/new-console-template for more information

// Aca voy a trabajar con los ciclos de programacion
// Comienzo con el while que significa Mientras " se cumpla la condicion sigue " cuando ya no, " corta "

Console.WriteLine(" Porfavor ingresa tu nombre");

string nombre = Console.ReadLine();

Console.WriteLine(" Buenos días  " + nombre);
/*
Console.WriteLine(" Ingresa un número no mayor a 20 y ");

double numero = double.Parse(Console.ReadLine());

while( numero < 20)
{
    Console.WriteLine(" El numero que leo es menor a 20, Por lo tanto le ire sumando 1 hasta pasar los 20");

    numero++; //Esto es lo mismo que hacer numero = numero + 1 

    Console.WriteLine(" El proximo número que voy a leer es " + numero);

}

Console.WriteLine(" Si llegaste hasta aca es porque se igualo o supero al número 20 por lo tanto no sigo con el ciclo");
*/

//Ejemplo numero 2

/*
string respuesta = "";

var contador = 0;


while(respuesta.ToUpper() != "N")
    {
    contador++;
    Console.WriteLine("Seguimos dando vueltas, esta es la vuelta número " + contador);
    Console.WriteLine(" Seguimos? S/N");
    
    respuesta = Console.ReadLine();

    
}

Console.WriteLine( "El total de vueltas que decidiste dar fueron  " + contador);

*/

// Ahora voy a implementar el for 

Console.WriteLine(" Cada caramelo sale $5");
Console.WriteLine("Ingresa la cantidad de plata que tenes");

const int saldo = 5;

double plata = double.Parse(Console.ReadLine());


var CantidadDeCaramelos = 0.0;

CantidadDeCaramelos = plata / saldo;



for (int i = 0; i < CantidadDeCaramelos; i++)
{
    Console.WriteLine( " Cantidad de caramelos que te voy dando " + i); 

}

Console.WriteLine("La cantidad de caramelos que te pude dar con esa plata son  " + CantidadDeCaramelos);


