using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSity
{
    public class Enemy :Tank
    {
        public Enemy(bool isPlayr, int startRow, int startCol, char sumbol) : base(isPlayr, startRow, startCol, sumbol)
        {
        }
    }
}
