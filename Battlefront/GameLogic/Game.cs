using Newtonsoft.Json;
using System.Drawing;
using System.Numerics;

namespace GameLogic
{
     class YugiohCard
     {

        public int atk;
        public int def;
        public string name;
        public string desc;

     }

    public class Game
    {
        private int totalCards;
        private string jsonFilePath = @"cards.json";
        private string imageFolderPath = @"images";
        private string[] imageLocation;

        public List<Player> players { get; set; } = new List<Player>();
        public List<Card> GameCards { get; set; } = new List<Card>();


        public void AddPlayer(Player player)
        {
            players.Add(player);

        }

        public List<Player> GetPlayers()
        {
            return players;
        }

        /// <summary>
        /// This method gets data from the json file and the images from the images folder and creates a list of cards
        /// </summary>
        public void ShuffleCard()
        {
            imageLocation = System.IO.Directory.GetFiles(imageFolderPath, "*.jpg");
            totalCards = imageLocation.Length;

            if (totalCards > 0)
            {
                Image[] imageArray = new Image[totalCards]; 

                string json = File.ReadAllText(jsonFilePath);
                List<YugiohCard> yugiohCard = JsonConvert.DeserializeObject<List<YugiohCard>>(json);

                for (int i = 0; i < totalCards; i++)
                {
                    string characterName = Path.GetFileNameWithoutExtension(imageLocation[i]);

                    string[] characterNameArray = characterName.Split('_');
                    if (characterName.Length > 0)
                    {
                        string imagePath = imageLocation[i];
                        characterName = characterNameArray[0];
                        Image originalImage = Image.FromFile(imagePath);

                        if (yugiohCard != null)
                        {

                            YugiohCard card = yugiohCard.Find(x =>
                            {
                                return x.name.Contains(characterName);
                            });

                            if (card != null)
                            {

                                Card newCard = new Card(card.name, card.atk, card.def, originalImage);
                                GameCards.Add(newCard);

                            }

                        }
                    }
                }

            }
        }

    }
}
