using System;
using System.Collections.Generic;

namespace Sample_Personality_Test
{
    public class Questions
    {
        // Instance members.
        private Questions()
        {
        }

        public Questions(string prompt, string left, string right, int affirmative, int negative)
        {
            Prompt = prompt;
            Left = left;
            Right = right;
            Affirmative = affirmative;
            Negative = negative; 
        }

        public string Prompt { private set; get; }

        public string Left { private set; get; }

        public string Right { private set; get; }

        public int Affirmative { private set; get; }

        public int Negative { private set; get; }

        // Static members.
        static Questions()
        {
            List<Questions> all = new List<Questions>
            {

                new Questions("What would you do if you and your friends were trapped by a dragon?", "Try to save everyone",
                              "Save Yourself",0,3),
                new Questions("You get to choose one more class, you choose", "Library Science",
                              "Herbology",1,2),
                new Questions("What's your best trait?", "Intelligence",
                              "Bravery",2,0),
                new Questions("What's your best trait?", "Kindness",
                              "Ambition",1,3)
            };
            All = all;
        }
        
     public static IList<Questions> All { private set; get; }
    }

}
