using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class DrawBoard
    {
        public static List<Snake> DrawSnakes(int quantity, int upperLimit, int lowerLimit)
        {
            List<Snake> SnakesList = new List<Snake>();
            for (int i = 0; i < quantity; i++)
            {
                Snake currenShape = (Snake)DrawShape.GetShape(new Snake(), lowerLimit, upperLimit);
                SnakesList.Add(currenShape);
                upperLimit = upperLimit + 10;
                lowerLimit = lowerLimit + 8;
            }
            return SnakesList;
        }
        public static List<Ladder> DrawLadders(int quantity, int upperLimit, int lowerLimit)
        {
            List<Ladder> LaddersList = new List<Ladder>();
            for (int i = 0; i < quantity; i++)
            {
                Ladder currenShape = (Ladder)DrawShape.GetShape(new Ladder(), lowerLimit, upperLimit);
                LaddersList.Add(currenShape);
                upperLimit = upperLimit + 10;
                lowerLimit = lowerLimit + 8;
            }
            return LaddersList;
        }
    }
}
