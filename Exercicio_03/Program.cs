//Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
//Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
//ordem crescente ou decrescente. 

Console.Write("Digite o primeiro valor: ");
int valor1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
int valor2 = int.Parse(Console.ReadLine());

string mensagem = NumerosMultiplos(valor1, valor2) ? "Os números são múltiplos" : "Os números não são múltiplos";
Console.WriteLine(mensagem);

bool NumerosMultiplos (int valor1, int valor2) =>
    valor1 % valor2 == 0 || valor2 % valor1 == 0;
