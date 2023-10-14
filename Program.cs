
// 1. Imprimir 1-255​

static void PrintNumbers()
{
    for (int i = 1; i <= 255; i++)
    {
        Console.WriteLine($"Número {i}");
    }
}

PrintNumbers();

Console.WriteLine("-------------------------------------------");

// 2. Imprimir números impares entre 1-255​

static void PrintOdds()
{
    for (int i = 1; i <= 255; i++)
    {
        if (i % 2 != 0) 
        {
            Console.WriteLine($"Número Impar {i}");
        }
    }
}

PrintOdds();

Console.WriteLine("-------------------------------------------");

// 3. Imprimir Suma​ entre 0 y 255

static void PrintSum()
{     
    int suma = 0;    
    for (int i = 0; i <= 255; i++)
    {
        suma += i;
        Console.WriteLine($"Nuevo número: {i} Suma: {suma}");
    }
}

PrintSum();

Console.WriteLine("-------------------------------------------");

// 4. Iterar a través de una matriz​

static void LoopArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = i;
        Console.WriteLine($"Número {i+1}: {i}");
    }
}

int[] numerosArray = new int[5];
LoopArray(numerosArray);

Console.WriteLine("-------------------------------------------");

// 5. Encuentra el valor máximo

static int FindMax(int[] numbers)
{
    int max = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max) {
            max = numbers[i];
        }
    }

    return max;
}

int[] numerosEnteros = new int[] {-4, 7, 4, -9, 2, 0, 4, -6, 0, 3, -4};
int numeroMayor = FindMax(numerosEnteros);
Console.WriteLine($"El número mayor es: {numeroMayor}");

Console.WriteLine("-------------------------------------------");

// 6. Obtén el Promedio​

static void GetAverage(int[] numbers)
{
    double promedio;
    double suma = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        suma += numbers[i];
    }

    //promedio = Math.Round(suma / numbers.Length);
    promedio = (int)(suma / numbers.Length);
    Console.WriteLine($"El promedio es: {promedio}");
}

int[] numerosEnteros2 = new int[] { 1, 7, 3, 9, 2, 5, 7, 6, 8, 3, 9 };
GetAverage(numerosEnteros2);

Console.WriteLine("-------------------------------------------");

// 7. Lista con números impares​

static List<int> OddList()
{
    List<int> listaImpares = new List<int>();
    for (int i = 1; i <= 255; i++)
    {
        if (i % 2 != 0)
        {
            listaImpares.Add(i);
        }
    }

    return listaImpares;
}

List<int> nuevaLista = OddList();

int j = 1;
foreach (int impar in nuevaLista) 
{
    Console.WriteLine($"El impar número {j}: {impar}");
    j++;
}

Console.WriteLine("-------------------------------------------");

// 8. Mayor que Y​

static int GreaterThanY(List<int> numbers, int y)
{
    int contador = 0;
    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] > y)
        {
            contador++;
        }
    }

    return contador;
}

int y = 6;
int total = GreaterThanY(numerosEnteros2.ToList(), y);
Console.WriteLine($"Cantidad de números mayores que {y}: {total}");

Console.WriteLine("-------------------------------------------");

// 9. Haz Cuadrar los Valores​

static void SquareArrayValues(List<int> numbers)
{
    foreach (int multiplo in numbers)
    {
        Console.WriteLine($"El número multiplicado al cuadrado: {multiplo * multiplo}");
    }
}  

SquareArrayValues(numerosEnteros2.ToList());

Console.WriteLine("-------------------------------------------");

// 10. Elimina los Números Negativos​

static void EliminateNegatives(List<int> numbers)
{
    for (int i = 0; i < numbers.Count; i++) 
    {
        if (numbers[i] < 0) 
        {
            numbers.RemoveAt(i);
            numbers.Insert(i, 0);
        }
    }

    foreach (int positivo in numbers)
    {
        if (positivo == 0) 
        {
            Console.WriteLine($"El número negativo eliminado: {positivo}");
        }
        else
        {
            Console.WriteLine($"El número no negativo: {positivo}");
        }
    }
}

EliminateNegatives(numerosEnteros.ToList());

Console.WriteLine("-------------------------------------------");
