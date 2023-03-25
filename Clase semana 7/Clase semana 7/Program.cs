void Adivina()
{
    const int Oportunidades = 4;
    int numerocpu, numerousuario;
    byte intentos, banderacontrol;
    string linea;

    Random rand = new Random();
    do
    {
        numerocpu= Convert.ToInt32(rand.Next(1, 21));
        Console.WriteLine(numerocpu);

    } while (!(((numerocpu >= 1) & (numerocpu <= 20))));
    //Proceso
    intentos = 1; 
    banderacontrol = 0;
    do
    {
        Console.WriteLine("\tEstoy pensando en un número, ¿cuál crees que es?");
        numerousuario= Convert.ToInt32(Console.ReadLine());
        if ((numerousuario == numerocpu))
        {
            Console.WriteLine("\tYes! Adivinaste");
            banderacontrol = 1;
        }
        else
        {
            if (numerousuario > numerocpu)
            {
                Console.WriteLine("\tEl número que ingresaste es mayor al que estoy pensando:)");
            }
            else
            {
                Console.WriteLine("\tEl número que ingresaste es menor del que estoy pensando :)");
            }
        }
        intentos ++;

    } while (((intentos <= Oportunidades) & (banderacontrol == 0)));
}
void busqamayor()
{
    int mayor = 0;
    int numero = 0;
    int menor = 100;
    Random rand = new Random();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(numero);
        numero = rand.Next(100);
        if (numero > mayor)
        {
            mayor = numero;
        }
        if (numero < menor)
        {
            menor = numero;
        }
    }
    Console.WriteLine("\tEl número mayor es: " + mayor);
    Console.WriteLine("\tEl número menor es: " + menor);
}
void arreglos()
{
    int[] notas = new int[10];
    Random rnd = new Random();
    Console.WriteLine("\tCargando información");
    for (int i = 0; i < notas.Length; i++)
    {
        notas[i] = rnd.Next(100);
    }
    Console.WriteLine("\tDesplegando información");
    int mayor = 0;
    int menor = notas[0];
    int suma = 0;
    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine("\t" + notas[i]);
        if (notas[i] > mayor)
        {
            mayor = notas[i];
        }
        if (notas[i] < menor)
        {
            menor = notas[i];
        }
        suma += notas[i];
    }
    double promedio = (double)suma / notas.Length;
    Console.WriteLine("\tNota mayor: " + mayor);
    Console.WriteLine("\tNota menor: " + menor);
    Console.WriteLine("\tPromedio: " + promedio);
}
void nombres()
{
    string[] nombre = new string[10];
    nombre[0] = "jairo";
    nombre[1] = "Brandon";
    nombre[2] = "Hector";
    nombre[3] = "Yeimi";
    nombre[4] = "Fátima";
    nombre[5] = "Gerson";
    nombre[6] = "Juan";
    nombre[7] = "Pablo";
    nombre[8] = "Alay";
    nombre[9] = "Jeanpierr";

    Console.WriteLine("Los participantes son:");
    for (int i = 0; i < nombre.Length; i++)
    {
        Console.WriteLine(i + ": " + nombre[i]);
    }
    Random rand = new Random();
    int ganador1 = rand.Next(nombre.Length); // primer ganador
    int ganador2;
    do
    {
        ganador2 = rand.Next(nombre.Length); // segundo ganador diferente al primero
    } while (ganador2 == ganador1);

    Console.WriteLine("\nLos ganadores son:");
    Console.WriteLine("\tEl primer lugar se ganó una pierna de cerdo y es : " + nombre[ganador1]);
    Console.WriteLine("\tEl segundo lugar se´ganó un cerdo sin una pierna y es : " + nombre[ganador2]);
}

// busqamayor();
//Adivina();
//arreglos();
nombres();