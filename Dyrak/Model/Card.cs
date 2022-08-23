
namespace Dyrak.Model
{
    class Card 
    {
        public string Suit { get; set; }
        public string Value { get; set; }
        public object Name { get; internal set; }

        private string[] suits = { "Diamonds", "Hearts", "Spades", "Clubs" };

        private string[] cards = {"6", "7", "8", "9", "10", "Jack", "Queen ", "King", "Ace" };

        public Card()
        {
            Random random = new Random();
            int minRandom = 0;
            int maxRandom = 9;
            int maxVRandom = 4;
            int n = random.Next(minRandom, maxRandom);
            int v = random.Next(minRandom, maxVRandom);
            Suit = suits[v];
            Value = cards[n];

        }
        public override string ToString()
        {
            return $"{Value}-{Suit}";
        }

    }
}
