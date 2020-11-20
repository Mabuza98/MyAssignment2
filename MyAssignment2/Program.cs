using System;

namespace MyAssignment2
{
    class Program
    {
        public class program
        {
            public static void Main()
            {
                string FirstSentence = " bottles of milk on the wall, ";
                string SecondSentence = "bottles of milk.";
                string EndSentence1 = " take one down and pass it around, ";
                string EndSentence2 = " bottles of milk on the wall. ";

                for (int i = 99; i >= 0; i--)
                {
                    if (i > 0)
                        Console.WriteLine(i + FirstSentence + i + SecondSentence);
                    else if (i == 0)
                        Console.WriteLine(EndSentence1 + i + EndSentence2);
                }
            }
        }
    }
}