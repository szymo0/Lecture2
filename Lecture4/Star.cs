using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    public class Star
    {
        public Point Location { get; protected set; }
        public int ActualBrightness { get; protected set; }
        public int MaxBirghtness { get; protected set; }
        public float Radius { get; protected set; }

        private int _factory = 1;
        public void ChangeStarBrightness()
        {
            if (ActualBrightness == MaxBirghtness)
                _factory = -1;
            if (ActualBrightness == 0)
                _factory = 1;

            ActualBrightness += _factory * 1;
        }

        public static Star CreateRandomStart(int maxX, int maxY, int maxBrightnes, int maxRadious)
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            var star = new Star();
            star.Location = new Point(random.Next(1, maxX - 1), random.Next(1, maxY - 1));
            star.MaxBirghtness = maxBrightnes;
            star.ActualBrightness = random.Next(1, star.MaxBirghtness);
            star.Radius = random.Next(1, maxRadious);
            return star;
        }

        public int GetTransparency()
        {
            var transparency = (ActualBrightness * 255) / MaxBirghtness;
            return transparency;
        }

    }
}
