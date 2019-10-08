using Core;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SkakesAndLedders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creando tablero...Espere por favor");
            Board board = new Board(50);

            var snakes = DrawBoard.DrawSnakes(4, 20, 5);
            Thread.Sleep(500);
            var ladders = DrawBoard.DrawLadders(4, 20 ,5);

            var match = new Match(board, snakes, ladders);


            Player player1 = new Player();
            Player player2 = new Player();
            player1.NamePlayer = "player1";
            player2.NamePlayer = "player2";
            var currentPlayer = UtilPlayer.FirstPlayerVerify(player1, player2);

            Console.Clear();
            Console.WriteLine("Iniciando....");
            Console.WriteLine("Empieza jugador: {0}", currentPlayer.NamePlayer);
            Thread.Sleep(1000);
            Console.Clear();
            while (currentPlayer.Position != board.Size)
            {
                Console.WriteLine("turno de : {0}", currentPlayer.NamePlayer);
                if(currentPlayer.NamePlayer == "player1")
                {
                    match.MovePlayer(currentPlayer);
                    Console.WriteLine("Posicion : {0}", currentPlayer.Position);
                    Console.ReadKey();
                    currentPlayer = player2;
                }
                else
                {
                    match.MovePlayer(currentPlayer);
                    Console.WriteLine("Posicion : {0}", currentPlayer.Position);
                    Console.ReadKey();
                    currentPlayer = player1;
                }
            }
            Console.Clear();
            Console.WriteLine("ganador {0}", currentPlayer.NamePlayer);
            Console.ReadKey();
        }
    }
}
