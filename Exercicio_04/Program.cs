
Console.WriteLine("Digite a hora inicial e a hora final do jogo (formato 24 horas, separadas por um espaço):");
string[] entrada = Console.ReadLine().Split(' ');

int horaInicial = int.Parse(entrada[0]);
int horaFinal = int.Parse(entrada[1]);

int duracao = CalcularDuracao(horaInicial, horaFinal);

Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");

int CalcularDuracao(int horaInicial, int horaFinal)
{
    int duracao;

    if (horaInicial < horaFinal)
    {
        duracao = horaFinal - horaInicial;
    }
    else
    {
        duracao = 24 - horaInicial + horaFinal;
    }

    return duracao;
}
