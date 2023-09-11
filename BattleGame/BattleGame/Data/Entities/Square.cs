using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Data.Entities
{
    public class Square
    {
        public int Line { get; set; }

        public int Column { get; set; }

        public int Value { get; set; }

        public Square(int line, int column)
        {
            this.Line = line;
            this.Column = column;
        }

        public Square()
        {
        }
    }
}
