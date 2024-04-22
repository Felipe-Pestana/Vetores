int numero;
int[] numeros = new int[5];


for (int i = 0; i < 5; i++)
{
    numero = int.Parse(Console.ReadLine());
    numeros[i] = numero;
    //numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("valor: " + numeros[i]);
}
