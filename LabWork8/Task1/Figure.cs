using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Figure
    {
        public abstract int GetSquareOfFigure();
        public abstract int GetPerimetеr();
        public abstract string GetInformationOfFigure();

        public abstract string NameOfFigure { get; }
    }
}
