using Advent2.Game;

namespace Advent2.IO
{
    public static class GameParser
    {
        
        public static List<Play> GetPlays(string input)
        {
            List<Play> plays = new List<Play>();
            string[] lines = input.Split(Environment.NewLine);
            foreach(string line in lines)
            {
                Play play = new Play() { PlayerShape = GetShape(line[2]), OpponentShape = GetShape(line[0]) };
                plays.Add(play);
            }
            return plays;
        }


        static Shape GetShape(char c)
        {
            switch(c)
            {
                case 'A':
                case 'X':
                    return Shape.Rock;
                case 'B':
                case 'Y':
                    return Shape.Paper;
                case 'C':
                case 'Z':
                    return Shape.Scissors;
                default:
                    throw new ArgumentException("Invalid argument 'c'. Must be ABC or XYZ");
            }
        }
    }
}
