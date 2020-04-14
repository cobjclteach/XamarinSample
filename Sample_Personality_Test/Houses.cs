using System;
using System.Collections.Generic;

namespace Sample_Personality_Test
{
    public class Houses
    {
        public Houses()
        {
        }

        public Houses(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public string Name { private set; get; }

        public int Points { set; get; }

        static Houses()
        {
            List<Houses> all = new List<Houses>
            {
                new Houses("Gryffindor", 0),
                new Houses("Hufflepuff",0),
                new Houses("Ravenclaw",0),
                new Houses("Slytherin",0)
            };
            All = all;
        }
        public static IList<Houses> All { set; get; }
    }
}
