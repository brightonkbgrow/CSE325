using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Grow
{
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public DesktopMaterial Material { get; set; }

        public const int MinWidth = 24;
        public const int MaxWidth = 96;
        public const int MinDepth = 12;
        public const int MaxDepth = 48;

        public Desk(int width, int depth, int numberOfDrawers, DesktopMaterial material)
        {

            if (width < MinWidth || width > MaxWidth)
                throw new ArgumentOutOfRangeException(nameof(width), $"Width must be between {MinWidth} and {MaxWidth}.");
            if (depth < MinDepth || depth > MaxDepth)
                throw new ArgumentOutOfRangeException(nameof(depth), $"Depth must be between {MinDepth} and {MaxDepth}.");


            Width = width;
            Depth = depth;
            NumberOfDrawers = numberOfDrawers;
            Material = material;
        }
    }

    public enum DesktopMaterial
    {
        Laminate,
        Pine,
        Oak,
        Rosewood,
        Veneer
    }
}