namespace GameLogic
{
    public class Player
    {

        private string id;
        private string name;
        private int health = 3000;

        public string Id
        {
            get
            {
                return id;
            }

            set { id = value; }

        }

        public string Name
        {
            get
            {
                return name;
            }

            set { name = value; }

        }
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value < 0)
                {
                    health = 0;
                }
                else
                {
                    health = value;
                }

            }
        } 


        public List<Card> Deck { get; set; } = new List<Card>();


        public Player(string id, string name)
        {
            this.Id = id;
            this.Name = name;

        }

        public void AddToDeck(Card card)
        {
            Deck.Add(card);
        }


    }
}
