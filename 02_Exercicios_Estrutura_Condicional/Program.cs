//Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

Console.Write("Entre com um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine(MensagemNumeroInteiro(numero));

string MensagemNumeroInteiro(int n)
{
    if (n == 0)
        return "O número é 0";

    if (n > 0)
        return "O número é positivo";

    return "O número é negativo";
}