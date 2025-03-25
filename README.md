# JogoXadrezCsharp

📝 Descrição do código – Classe JogoDaVelha em C#
Este código implementa um jogo da velha em modo console utilizando a linguagem C#. O jogo é para dois jogadores (X e O), alternando as jogadas até que haja um vencedor ou empate.

🔧 Funcionamento geral
O jogo utiliza uma matriz 3x3 de caracteres (tabuleiro) para representar o estado atual do jogo.

Os números de 1 a 9 representam as posições disponíveis para jogar.

A cada rodada, o jogador atual (X ou O) escolhe uma posição digitando um número de 1 a 9.

O jogo valida a entrada, atualiza o tabuleiro e alterna o jogador após cada jogada válida.

O loop principal continua até que:

Um jogador vença (três símbolos iguais em linha, coluna ou diagonal); ou

O número máximo de jogadas (9) seja atingido, caracterizando um empate.

🧩 Funções do código
Main():

Gerencia o fluxo principal do jogo, interação com o jogador, validações e alternância de turno.

MostrarTabuleiro():

Exibe visualmente o estado atual do tabuleiro formatado no console.

FazerJogada(int escolha):

Verifica se a posição escolhida está livre e, se sim, marca o símbolo do jogador atual.

VerificarVencedor():

Avalia se o jogador atual venceu o jogo, verificando:

Três iguais em uma linha

Três iguais em uma coluna

Três iguais em uma diagonal

✅ Características importantes
Utiliza Console.Clear() para limpar a tela entre os turnos.

Apresenta mensagens de erro amigáveis caso a entrada seja inválida ou a posição já esteja ocupada.

Faz uso de operador ternário para alternar os jogadores ('X' ↔ 'O').

Boa organização e legibilidade do código com funções bem separadas por responsabilidade.


