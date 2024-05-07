using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelArtToCommitHistory.Helpers
{
    public static class MathC
    {
        public static int TransformNumber(
            int number,
            int minOriginal,
            int maxOriginal,
            int minTransformed,
            int maxTransformed
        )
        {
            double scaled = (double)(number - minOriginal) / (maxOriginal - minOriginal);
            int transformed = (int)(scaled * (maxTransformed - minTransformed) + minTransformed);

            return transformed;
        }
    }
}
