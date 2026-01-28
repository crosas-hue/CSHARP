
int queElegir;

int numeroENtero;
double numeroDecimal;
double numeroFinal;

int largo;
int ancho;
int areaTotal;


Console.WriteLine("Que ejercicio quieres hacer hoy?");

queElegir = Convert.ToInt32(Console.ReadLine());



switch (queElegir)
{
	case 1:
        Console.WriteLine("dame un numero entero");
        numeroENtero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("dame un numero con decimal");
        numeroDecimal = Convert.ToDouble(Console.ReadLine());

        numeroFinal = numeroENtero + numeroDecimal;
        Console.WriteLine("El numero final es " + numeroFinal);

        break;

    case 2:
        Console.WriteLine("cual es el largo?");
        largo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("cual es el ancho?");
        ancho = Convert.ToInt32(Console.ReadLine());

        areaTotal = largo * ancho;
        Console.WriteLine("El area total es " + areaTotal);
        break;



}
