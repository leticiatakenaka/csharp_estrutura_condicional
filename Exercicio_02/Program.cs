//Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

Console.Write("Digite um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

string mensagem = NumeroPar(numero) ? $"{numero} é par" : $"{numero} é ímpar";

Console.WriteLine(mensagem);

bool NumeroPar(int n)
{
    return n % 2 == 0;
}