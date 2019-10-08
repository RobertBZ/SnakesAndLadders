using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core
{
    public static class UtilPlayer
    {
        public static int SnakeHeadVerify(int positionPlayer, Snake snake)
        {
            if(positionPlayer == snake.Head)
            {
                positionPlayer = snake.Tail;
            }
            return positionPlayer;
        }
        public static int LadderTailVerify(int positionPlayer, Ladder ladder)
        {
            if (positionPlayer == ladder.Tail)
            {
                positionPlayer = ladder.Head;
            }
            return positionPlayer;
        }
        public static int BounceEndPositionPlayer(int positionPlayer, int endPositionBoard)
        {
            if (positionPlayer > endPositionBoard)
            {
                positionPlayer = endPositionBoard - (positionPlayer - endPositionBoard);
            }
            return positionPlayer;
        }
        public static Player FirstPlayerVerify(Player player1, Player player2)
        {
            var rand = new Random();
            player1.Turn = rand.Next(1, 7);
            Thread.Sleep(500);
            player2.Turn = rand.Next(1, 7);
            if (player1.Turn > player2.Turn)
            {
                var currentPlayer = player1;
                return currentPlayer;
            }
            else 
            {
                if(player1.Turn == player2.Turn)
                {
                    return FirstPlayerVerify(player1, player2);
                }
                else
                {
                    var currentPlayer = player2;
                    return currentPlayer;
                }
                    
            }
        }
    }
}
