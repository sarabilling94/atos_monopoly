using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atosprogramm_Monopoly
{
    public class Position
    {
        private int position { get; set; }
        private int column { get; set; }
        private int row { get; set; }

        public Position(int position, int column, int row)
        {
            this.position = position;
            this.column = column;
            this.row = row;
        }

        public void setPosition(int position)
        {
            this.position = position;
        }

        public void setColumn(int column)
        {
            this.column = column;
        }

        public void setRow(int row)
        {
            this.row = row;
        }

        public int getPosition()
        {
            return this.position;
        }

        public int getColumn()
        {
            return this.column;
        }

        public int getRow()
        {
            return this.row;
        }
    }
}
