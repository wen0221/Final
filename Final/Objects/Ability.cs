using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Student Name:Wen Ma,
 Student ID:300903179

     */
namespace Final.Objects
{
    public class Ability
    {
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Endurance { get; set; }
        public string Intellect { get; set; }
        public string Education { get; set; }
        public string SocialStanding { get; set; }

       

        enum ability
        {
            Strength=1, Dexterity=2, Endurance=3, Intellect=4, Education=5, SocialStanding=6
        }
       
    }
}
