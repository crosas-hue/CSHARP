
        int queElegir;

        Console.WriteLine("¿ Que ejercicio quieres hacer? (1-4): ");
        // Conversión segura de texto a entero
        queElegir = Convert.ToInt32(Console.ReadLine());

        switch (queElegir)
        {
            case 1:
        //EJERCICIO 1: Mínimo, Máximo y Mostrar Lista 
        Random aleatorio1 = new Random();

        // 'llistaC'
        int[] llistaC = new int[55];

        Console.WriteLine("--- Lista de números generados ---");

        // 1. GENERAR, LLENAR Y MOSTRAR
        for (int i = 0; i < 55; i++)
        {
            // Generamos número entre 22 y 1559
            llistaC[i] = aleatorio1.Next(22, 1560);

            // Aquí mostramos el número por pantalla 
            Console.Write(llistaC[i] + " ");
        }

        Console.WriteLine(); 
        Console.WriteLine("----------------------------------");

        // 2. BÚSQUEDA 
        int masPequeno = llistaC[0];
        int masGrande = llistaC[0];

        for (int i = 0; i < 55; i++)
        {
            int numeroActual = llistaC[i];

            // "Gestión del valor más pequeño" 
            if (numeroActual < masPequeno)
            {
                masPequeno = numeroActual;
            }

            //"Gestión del valor más grande"
            if (numeroActual > masGrande)
            {
                masGrande = numeroActual;
            }
        }

        Console.WriteLine("Valor más pequeño: " + masPequeno);
        Console.WriteLine("Valor más grande: " + masGrande);
        break;

    case 2:
                // EJERCICIO 2: El Controlador 
                Random aleatorio2 = new Random();
                List<int> listaC2 = new List<int>(); // Uso de Listas dinámicas 

                for (int i = 0; i < 333; i++)
                {
                    listaC2.Add(aleatorio2.Next(1, 1000));
                }

                // Cálculo de la media 
                double suma = 0;
                foreach (int n in listaC2) suma += n;
                double media = suma / listaC2.Count;

                int multiplosDeCuatro = 0;
                int mayoresQueMedia = 0;

                foreach (int n in listaC2)
                {
                    if (n % 4 == 0) multiplosDeCuatro++; // Múltiplos de 4 
                    if (n > media) mayoresQueMedia++; // Mayores que la media 
                }

                Console.WriteLine("Media: " + media);
                Console.WriteLine("Múltiplos de 4: " + multiplosDeCuatro);
                Console.WriteLine("Mayores que la media: " + mayoresQueMedia);
                break;

            case 3:
                // EJERCICIO 3: Contador de Vocales 
                Console.WriteLine("Introduce una frase: ");
                string frase = Console.ReadLine().ToLower();

                int cuentaA = 0, cuentaE = 0, cuentaI = 0, cuentaO = 0, cuentaU = 0;

                for (int x = 0; x < frase.Length; x++) // Uso de Lengt
                {
                    char letra = frase[x];
                    // Comprobación manual (sin funciones externas) 
                    if (letra == 'a') cuentaA++;
                    else if (letra == 'e') cuentaE++;
                    else if (letra == 'i') cuentaI++;
                    else if (letra == 'o') cuentaO++;
                    else if (letra == 'u') cuentaU++;
                }

                Console.WriteLine("A: " + cuentaA + " E: " + cuentaE + " I: " + cuentaI + " O: " + cuentaO + " U: " + cuentaU);
                break;

            case 4:
        // EJERCICIO 4: Cajero Automático Interactivo 
        double saldo = 1000; // Saldo base inicial

        // Menú para preguntar qué quieres hacer
        Console.WriteLine("\n--- CAJERO AUTOMÁTICO ---");
        Console.WriteLine("Saldo inicial: " + saldo + " euros");
        Console.WriteLine("¿Qué quieres hacer?");
        Console.WriteLine("1. Ver Saldo");
        Console.WriteLine("2. Sacar Dinero");
        Console.WriteLine("3. Ingresar Dinero");
        Console.Write("Elige una opción: ");

        // Leemos la opción del usuario
        int opcionCajero = Convert.ToInt32(Console.ReadLine());

        if (opcionCajero == 1)
        {
            // Opción: Ver saldo
            MirarSaldo(saldo);
        }
        else if (opcionCajero == 2)
        {
            // Opción: Sacar dinero
            Console.Write("¿Cuánto dinero quieres sacar?: ");
            double cantidadSacar = Convert.ToDouble(Console.ReadLine()); // Preguntamos cantidad
            saldo = TreureSaldo(saldo, cantidadSacar); // Actualizamos saldo
        }
        else if (opcionCajero == 3)
        {
            // Opción: Ingresar dinero
            Console.Write("¿Cuánto dinero quieres ingresar?: ");
            double cantidadIngresar = Convert.ToDouble(Console.ReadLine()); // Preguntamos cantidad
            saldo = AfegirSaldo(saldo, cantidadIngresar); // Actualizamos saldo
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
        break;
}


// Función 1: Muestra el saldo 
static void MirarSaldo(double dineroActual)
{
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("-> Tu saldo actual es: " + dineroActual + " euros.");
    Console.WriteLine("-----------------------------------");
}

// Función 2: Saca dinero y avisa 
static double TreureSaldo(double dineroActual, double cantidadRetirar)
{
    // Verificamos si hay saldo suficiente
    if (cantidadRetirar <= dineroActual)
    {
        double dineroRestante = dineroActual - cantidadRetirar;
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("   Operación aceptada.");
        Console.WriteLine("   Has retirado: " + cantidadRetirar + " euros.");
        Console.WriteLine("-> SALDO RESTANTE: " + dineroRestante + " euros.");
        Console.WriteLine("-----------------------------------");
        return dineroRestante;
    }
    else
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("X ERROR: Fondos insuficientes.");
        Console.WriteLine("-> Tu saldo sigue siendo: " + dineroActual + " euros.");
        Console.WriteLine("-----------------------------------");
        return dineroActual;
    }
}

// Función 3: Ingresa dinero y avisa 
static double AfegirSaldo(double dineroActual, double cantidadIngresar)
{
    double dineroRestante = dineroActual + cantidadIngresar;
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("   Operación aceptada.");
    Console.WriteLine("   Has ingresado: " + cantidadIngresar + " euros.");
    Console.WriteLine("-> SALDO RESTANTE: " + dineroRestante + " euros.");
    Console.WriteLine("-----------------------------------");
    return dineroRestante;
}

