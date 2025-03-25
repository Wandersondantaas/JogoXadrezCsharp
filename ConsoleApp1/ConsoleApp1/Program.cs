class JogoDaVelha
{
    static char[,] tabuleiro = {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };

    static int jogadas = 0;
    static char jogadorAtual = 'X';

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            MostrarTabuleiro();

            Console.WriteLine($"\nJogador {jogadorAtual}, escolha uma posição: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int escolha) || escolha < 1 || escolha > 9)
            {
                Console.WriteLine("Entrada inválida! Pressione Enter para tentar novamente.");
                Console.ReadLine();
                continue;
            }

            if (!FazerJogada(escolha))
            {
                Console.WriteLine("Posição já ocupada! Pressione Enter para tentar novamente.");
                Console.ReadLine();
                continue;
            }

            jogadas++;

            if (VerificarVencedor())
            {
                Console.Clear();
                MostrarTabuleiro();
                Console.WriteLine($"\nJogador {jogadorAtual} venceu!");
                break;
            }

            if (jogadas == 9)
            {
                Console.Clear();
                MostrarTabuleiro();
                Console.WriteLine("\nEmpate!");
                break;
            }

            jogadorAtual = (jogadorAtual == 'X') ? 'O' : 'X';
        }
    }

    static void MostrarTabuleiro()
    {
        Console.WriteLine(" JOGO DA VELHA\n");
        Console.WriteLine("-------------");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("| ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tabuleiro[i, j] + " | ");
            }
            Console.WriteLine("\n-------------");
        }
    }

    static bool FazerJogada(int escolha)
    {
        int linha = (escolha - 1) / 3;
        int coluna = (escolha - 1) % 3;

        if (tabuleiro[linha, coluna] == 'X' || tabuleiro[linha, coluna] == 'O')
        {
            return false;
        }

        tabuleiro[linha, coluna] = jogadorAtual;
        return true;
    }

    static bool VerificarVencedor()
    {
        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[i, 0] == jogadorAtual &&
                tabuleiro[i, 1] == jogadorAtual &&
                tabuleiro[i, 2] == jogadorAtual)
                return true;

            if (tabuleiro[0, i] == jogadorAtual &&
                tabuleiro[1, i] == jogadorAtual &&
                tabuleiro[2, i] == jogadorAtual)
                return true;
        }

        if (tabuleiro[0, 0] == jogadorAtual &&
            tabuleiro[1, 1] == jogadorAtual &&
            tabuleiro[2, 2] == jogadorAtual)
            return true;

        if (tabuleiro[0, 2] == jogadorAtual &&
            tabuleiro[1, 1] == jogadorAtual &&
            tabuleiro[2, 0] == jogadorAtual)
            return true;

        return false;
    }
}
