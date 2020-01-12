using System;
using System.Collections.Generic;
using System.Text;

namespace Board
{
    class Position
    {
        public int Row { get; set; }
        public int Collumn { get; set; }

        public Position(int line, int collumn)
        {
            this.Row = line;
            this.Collumn = collumn;
        }
        public override string ToString()
        {
            return Row +" ,"+Collumn;
        }
    }
}
