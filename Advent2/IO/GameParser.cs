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
                Shape opponent = GetShape(line[0]);
                Play play = new Play() { PlayerShape = GetPlayerShape(opponent, GetResult(line[2])), OpponentShape = opponent };
                plays.Add(play);
            }
            return plays;
        }


        static Shape GetShape(char c)
        {
            switch(c)
            {
                case 'A':
                    return Shape.Rock;
                case 'B':
                    return Shape.Paper;
                case 'C':
                    return Shape.Scissors;
                default:
                    throw new ArgumentException("Invalid argument 'c'. Must be ABC or XYZ");
            }
        }


        static Result GetResult(char c)
        {
            switch(c)
            {
                case 'X':
                    return Result.Lose;
                case 'Y':
                    return Result.Draw;
                case 'Z':
                    return Result.Win;
                default:
                    return Result.Error;
            }
        }
        static Shape GetPlayerShape(Shape opponent, Result result)
        {
            switch (opponent)
            {
                case Shape.Rock:
                    if (result == Result.Lose)
                        return Shape.Scissors;
                    if (result == Result.Draw)
                        return Shape.Rock;
                    if (result == Result.Win)
                        return Shape.Paper;
                    break;
                case Shape.Paper:
                    if (result == Result.Lose)
                        return Shape.Rock;
                    if (result == Result.Draw)
                        return Shape.Paper;
                    if (result == Result.Win)
                        return Shape.Scissors;
                    break;
                case Shape.Scissors:
                    if (result == Result.Lose)
                        return Shape.Paper;
                    if (result == Result.Draw)
                        return Shape.Scissors;
                    if (result == Result.Win)
                        return Shape.Rock;
                    break;
            }
            throw new ArgumentException();
        }
    }
}
