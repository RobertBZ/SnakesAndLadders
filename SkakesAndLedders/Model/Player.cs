using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Player
    {
        public string NamePlayer { get; set; }
        public int Position { get; set; }
        public int Turn { get; set; }
        public override string ToString()
        {
            return string.Format("{0} posicion: {1}",
                this.NamePlayer,
                this.Position);
        }
    }
}
