using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Board
    {
        public int Size { get; set; }
        public Board(int size)
        {
            this.Size = size;
        }
    }
}
