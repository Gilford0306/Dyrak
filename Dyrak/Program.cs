using Dyrak.Model;

Deck game = new Deck();
do 
{
    if (game.player.Count == 0 || game.bot.Count == 0)
        break;
    game.MovePlay();
    Console.WriteLine("Press any key to next round");
    string key = Console.ReadLine();
    Console.Clear();
    Console.WriteLine(game.player.Count);
    Console.WriteLine(game.bot.Count);
    if (game.player.Count == 0 || game.bot.Count == 0)
        break;
    game.MoveBot();
    Console.WriteLine("Press any key to next round");
    key = Console.ReadLine();
    Console.Clear();
} while (true);
Console.WriteLine("Game Over");
if (game.player.Count == 0)
    Console.WriteLine("You win");
else
    Console.WriteLine("You lose");



