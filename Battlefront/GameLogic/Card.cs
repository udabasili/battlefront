using Newtonsoft.Json;
using System.Drawing;
using static GameLogic.Game;

namespace GameLogic
{
    public class Card
    {
        private Image imageFile;
        private int attack;
        private int defense;

        public int Width { get; } = 70;

        public int Height { get; } = 150;

        public string Name { get; set; }

        public int Attack
        {
            get { return attack; }
            set
            {
                if (value < 0)
                {
                    attack = 0;
                }
                else
                {
                    attack = value;
                }
            }
        }

        public int Defense
        {
            get { return defense; }
            set
            {
                if (value < 0)
                {
                    defense = 0;
                }
                else
                {
                    defense = value;
                }
            }
        }  

        public Image ImageFile
        {
            get { return imageFile; }
            set { imageFile = value; }
        }

        public Image ResizedImageFile { get; set; }

        /// <summary>
        /// This method resizes the image to the specified width and height
        /// </summary>
        /// <param name="image"> Image file </param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static Image ResizeImage(Image image, int width, int height)
        {

            Size newSize = new Size(width, height);
            Bitmap resizedImage = new Bitmap(newSize.Width, newSize.Height);

            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }

            return resizedImage;
        }
       

        public Card(string name, int attack, int defense, Image image)
        {
            Name = name;
            Attack = attack;
            Defense = defense;
            ImageFile = image;
            ResizedImageFile = ResizeImage(image, 200, 200);
        }

        
    }
}
