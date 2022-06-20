using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    public enum Colors
    {
        Blanc, Bleu, Vert, Jaune, Orange, Rouge, Marron
    }

    public enum Sizes
    {
        XS, S, M, L, XL
    }
    public class Label
    {
        public string? Text { get; set; }
        public Colors Color { get; set; }
        public Sizes Size { get; set; }
}
}
