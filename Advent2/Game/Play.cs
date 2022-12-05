using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2.Game
{
    public enum Shape
    {
        Rock, Paper, Scissors
    }

    public enum Result {  Win, Lose, Draw, Error };

    public class Play
    {

        const int WIN_POINTS = 6;
        const int DRAW_POINTS = 3;
        const int LOSE_POINTS = 0;

        const int ROCK_POINTS = 1;
        const int PAPER_POINTS = 2;
        const int SCISSORS_POINTS = 3;
        public Shape PlayerShape { get; set; }
        public Shape OpponentShape { get; set; }

        public int GetScore()
        {
            return GetPoints(PlayerShape) + GetResultPoints(GetResult());
        }

        int GetPoints(Shape shape)
        {
            switch (PlayerShape)
            {
                case Shape.Rock:
                    return ROCK_POINTS;
                    break;
                case Shape.Paper:
                    return PAPER_POINTS;
                    break;
                case Shape.Scissors:
                    return SCISSORS_POINTS;
                    break;
                default:
                    throw new ArgumentException("Invalid argument 'shape'.  Must be Rock, Paper, or Scissors");
                    break;
            }
        }

        int GetResultPoints(Result result)
        {
            switch (result)
            {
                case Result.Win:
                    return WIN_POINTS;
                    break;
                case Result.Lose:
                    return LOSE_POINTS;
                    break;
                case Result.Draw:
                    return DRAW_POINTS;
                    break;
                case Result.Error:
                    return 0;
                    break;
                default:
                    return 0;
                    break;
            }
        }

        Result GetResult()
        {
            switch (PlayerShape)
            {
                case Shape.Rock:
                    if (OpponentShape == Shape.Rock)
                        return Result.Draw;
                    if (OpponentShape == Shape.Paper)
                        return Result.Lose;
                    if (OpponentShape == Shape.Scissors)
                        return Result.Win;

                    return Result.Error;
                    break;


                case Shape.Paper:
                    if (OpponentShape == Shape.Rock)
                        return Result.Win;
                    if (OpponentShape == Shape.Paper)
                        return Result.Draw;
                    if (OpponentShape == Shape.Scissors)
                        return Result.Lose;

                    return Result.Error;
                    break;
                
                
                case Shape.Scissors:
                    if (OpponentShape == Shape.Rock)
                        return Result.Lose;
                    if (OpponentShape == Shape.Paper)
                        return Result.Win;
                    if (OpponentShape == Shape.Scissors)
                        return Result.Draw;

                    return Result.Error;
                    break;
                default:
                    throw new Exception("Invalid shape state");
            }
        }
    }
}
