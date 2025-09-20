using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBS
{
    public class Room
    {
        public int Number { get; set; }
        public string _type = "Single";
        public string Type
        {
            set
            {
                if(value=="Single" || value=="Double" || value == "Suite")
                {
                    _type = value;
                }
                else
                {
                    MessageBox.Show("Invalide Type");
                }
            }
            get
            {
                return _type;
            }
        }
        public double PriceNight { get; set; }

        public Image Photos { get; set; }

        public Room(int Number, string Type,double PriceNight, Image Photos)
        {
            this.Number = Number;
            this.Type = Type;
            this.PriceNight =PriceNight;
            this.Photos = Photos;
        }
    }
}
