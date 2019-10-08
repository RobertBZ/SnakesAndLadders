using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core
{
    public static class DrawShape
    {
        public static Shape GetShape(Shape shape,int lowerLimit, int upperLimit)
        {
            var rand = new Random();
            int limit = rand.Next(lowerLimit, upperLimit);
            Thread.Sleep(500);
            int lower = rand.Next(lowerLimit, upperLimit);
            if (limit > lower)
            {
                shape.Head = limit;
                shape.Tail = lower;
            }
            else
            {
                GetShape(shape,lowerLimit, upperLimit);
            }
            return shape;
        }

    }
}
