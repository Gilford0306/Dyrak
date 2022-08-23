
namespace Dyrak.Model
{
    internal class Deck
    {
        public List<Card> deck { get; set; }
        public List<Card> player { get; set; }
        public List<Card> bot { get; set; }

        public Deck()
        {
            deck = new List<Card>();
            while (deck.Count < 36)
            {
                Card temp = new Card();
                for (int i = 0; i < deck.Count; i++)
                {
                    if (temp.Value == deck[i].Value)
                    {
                        if (temp.Suit == deck[i].Suit)
                        {
                            deck.Remove(deck[i]);
                        }
                    }
                }
                deck.Add(temp);
            }
            player = new List<Card>();
            for (int i = 0; i < 5; i++)
            {
                player.Add(deck[0]);
                deck.RemoveAt(0);
            }
            bot = new List<Card>();
            for (int i = 0; i < 5; i++)
            {
                bot.Add(deck[0]);
                deck.RemoveAt(0);
            }

        }

        public void MovePlay()
        {
            if (deck.Count != 0 && bot.Count < 6)
            {
                bot.Add(deck[0]);
                deck.RemoveAt(0);
            }
            if (deck.Count != 0 && player.Count < 6)
            {
                player.Add(deck[0]);
                deck.RemoveAt(0);
            }
            Console.WriteLine("====+++++++==");
            Console.WriteLine("Your Card");
            Console.WriteLine("============");
            foreach (Card item in player)
            {
                Console.Write($"{item}.\n");
            }
            for (int i = 0; i < player.Count; i++)
            {
                Console.WriteLine($"Press {i + 1} - to throw {i + 1} card");
            }
            int Ch = int.Parse(Console.ReadLine());
            Ch--;
            Console.Clear();
            Console.WriteLine("Your turn");
            Console.WriteLine(player[Ch]);
            player.Remove(player[Ch]);
            Console.WriteLine("PC turn");
            Random random = new Random();
            int minRandom = 0;
            int maxRandom = bot.Count;
            int move = random.Next(minRandom, maxRandom);
            Console.WriteLine(bot[move]);
            bot.Remove(bot[move]);

        }
        public void MoveBot()
        {
            if (deck.Count != 0 && player.Count < 6)
            {
                player.Add(deck[0]);
                deck.RemoveAt(0);
            }
            if (deck.Count != 0 && bot.Count < 6)
            {
                bot.Add(deck[0]);
                deck.RemoveAt(0);
            }
            Console.WriteLine("===============");
            Console.WriteLine("PC turn");
            Random random = new Random();
            int minRandom = 0;
            int maxRandom = bot.Count;
            int move = random.Next(minRandom, maxRandom);
            Console.WriteLine(bot[move]);
            Console.WriteLine("============");
            Console.WriteLine("Your Card");
            foreach (Card item in player)
            {
                Console.Write($"{item}.\n");
            }
            for (int i = 0; i < player.Count; i++)
            {
                Console.WriteLine($"Press {i + 1} - to throw {i + 1} card");
            }
            Console.WriteLine($"Press {player.Count + 1} - to take card");
            int Chc = int.Parse(Console.ReadLine());
            Chc--;
            if (Chc > -1 && Chc < player.Count)
            {
                Console.WriteLine("Your turn");
                Console.WriteLine(player[Chc]);
                player.Remove(player[Chc]);
            }
            else
            {
                player.Add(bot[move]);
                Console.WriteLine($"You take {bot[move]}");
                bot.Remove(bot[move]);
            }
        }

    }
}
    