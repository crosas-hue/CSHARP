int queElegir;
int contador13 = 13;
int num;
int numSuma = 13;


int imp = 0;
int par = 0;
int parSuma = 0;
int impSuma = 0;
int contador1 = 1;


int multiplo = 0;
string jugador1 = null;
string jugador2 = null;


int saldo = 500;
int retirar = 0;
int depositar = 0;
int accion = 0;

int edad = 0;
int ingresos = 0;
string referencia = null;
string infracciones = null;


Console.WriteLine("Que ejercicio quieres hacer? ");
queElegir = Convert.ToInt32(Console.ReadLine());
switch (queElegir)
{
    case 1:
        Console.Write("Introduce numero");
        num = Convert.ToInt32(Console.ReadLine());
        while (contador13 < num)
        {
            contador13++;
            numSuma += contador13;


        }
        Console.WriteLine(numSuma);

        break;
    case 2:
        Console.WriteLine("Introduce un numero");
        num = Convert.ToInt32(Console.ReadLine());
        while (contador1 <= num)
        {

            if (contador1 % 2 == 0)
            {
                par++;
                parSuma += contador1;
            }
            else
            {
                imp++;
                impSuma += contador1;
            }

            if (contador1 % 13 == 0)
            {
                multiplo++;
            }
            contador1++;




        }
        Console.WriteLine($" Numeros pares: {par} \n Numeros impares: {imp} \n Suma de numeros pares: {parSuma} \n Suma de numeros impares: {impSuma} \n Numeros multiples de 13: {multiplo}");





        break;
    case 3:
        Console.WriteLine("Jugador 1:");
        Console.Write("  Introduce un numero del 0-2: ");
        jugador1 = Console.ReadLine();
        Console.WriteLine("Jugador 2:");
        Console.Write("  Introduce un numero del 0-2: ");
        jugador2 = Console.ReadLine();
        if (jugador1 == "0")
        {
            Console.WriteLine("Jugador 1 a elegido piedra");
        }
        else if (jugador1 == "1")
        {
            Console.WriteLine("Jugador 1 a elegido papel");
        }
        else
        {
            Console.WriteLine("Jugador 1 a elegido tijera");
        }

        if (jugador2 == "0")
        {
            Console.WriteLine("Jugador 2 a elegido piedra");
        }
        else if (jugador2 == "1")
        {
            Console.WriteLine("Jugador 2 a elegido papel");
        }
        else
        {
            Console.WriteLine("Jugador 2 a elgido tijera");
        }

        if (jugador1 == "0" && jugador2 == "1")
        {
            Console.WriteLine("Jugador 2 gana");
        }
        else if (jugador1 == "1" && jugador2 == "0")
        {
            Console.WriteLine("Jugador 1 gana");
        }
        else if (jugador1 == "1" && jugador2 == "2")
        {
            Console.WriteLine("Jugador 2 gana");
        }
        else if (jugador1 == "2" && jugador2 == "1")
        {
            Console.WriteLine("Jugador 1 gana");
        }
        else if (jugador1 == "0" && jugador2 == "2")
        {
            Console.WriteLine("Jugador 1 gana");
        }
        else if (jugador1 == "2" && jugador2 == "0")
        {
            Console.WriteLine("Jugador 2 gana");
        }
        else if (jugador1 == "0" && jugador2 == "0")
        {
            Console.WriteLine("Empate");
        }
        else if (jugador1 == "1" && jugador2 == "1")
        {
            Console.WriteLine("Empate");
        }
        else if (jugador1 == "2" && jugador2 == "2")
        {
            Console.WriteLine("Empate");
        }

        break;
    case 4:
        Console.WriteLine("Que accion quieres realizar?\n -Introduce 1 si quieres ver el saldo\n -Introduce 2 si quieres depositar dinero\n -Introduce  3 si quieres retirar dinero");
        accion = Convert.ToInt32(Console.ReadLine());
        if (accion == 1)
        {
            Console.WriteLine($"Este es tu  saldo actual: {saldo}");
        }
        else if (accion == 2)
        {
            Console.WriteLine("Cuanto dinero quieres depositar");
            depositar = Convert.ToInt32(Console.ReadLine());
            saldo = saldo + depositar;
            Console.WriteLine($"Ya lo tienes depositado, tu saldo actual es de {saldo}");
        }
        else if (accion == 3)
        {
            Console.WriteLine("Cuanto dinero quieres retirar");
            retirar = Convert.ToInt32(Console.ReadLine());
            if (retirar > saldo)
            {
                Console.WriteLine("No puedes retirar mas dinero del que tienes en la cuenta espabilao!");
            }
            else
            {
                saldo = saldo - retirar;
                Console.WriteLine($"Ya lo tienes retirado, tu saldo actual es de {saldo}");
            }

        }
        break;
    case 5:
        Console.WriteLine("Introduce tu edad");
        edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresos mensuales?");
        ingresos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Referencia de alquiler anterior positiva? (Si/No)");
        referencia = Console.ReadLine();

        Console.WriteLine("Numero de infracciones graves en los ultimos 5 años? (Indica el numero)");
        infracciones = Console.ReadLine();

        if (edad > 25 && edad < 65 && ingresos >= 2500 && referencia == "Si" && infracciones == "1" || infracciones == "0")
        {
            Console.WriteLine("Si puedes alquilar");
        }
        else
        {
            Console.WriteLine("No puedes alquilar");
        }
        break;
}
