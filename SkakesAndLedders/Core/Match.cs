using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Match
    {
        private int SizeBoard;
        private List<Snake> SnakesList;
        private List<Ladder> LaddersList;
        public Match(Board board, List<Snake> snakes, List<Ladder> ladders)
        {
            this.SnakesList = snakes;
            this.LaddersList = ladders;
            this.SizeBoard = board.Size;
        }
        public Player MovePlayer(Player player)
        {
            var rand = new Random();
            player.Position = player.Position + rand.Next(1, 7);
            player.Position = MoveSnakeTailPlayer(player.Position);
            player.Position = MoveLadderHeadPlayer(player.Position);
            player.Position = UtilPlayer.BounceEndPositionPlayer(player.Position, SizeBoard);
            return player;
        }
        private int MoveSnakeTailPlayer(int position)
        {
            foreach (Snake snake in SnakesList)
            {
                position = UtilPlayer.SnakeHeadVerify(position, snake);
            }
            return position;
        }
        private int MoveLadderHeadPlayer(int position)
        {
            foreach (Ladder ladder in LaddersList)
            {
                position = UtilPlayer.LadderTailVerify(position, ladder);
            }
            return position;
        }
    }
}
