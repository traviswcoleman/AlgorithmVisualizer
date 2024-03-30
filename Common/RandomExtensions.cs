using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualizer.Business.Common;
public static class RandomExtensions
{
    public static float NextFloat(this Random random)
    {
        return (float)random.NextDouble();
    }

    public static float NextFloat(this Random random, float start, float end)
    {
        float lb = Math.Min(start, end);
        float ub = Math.Max(start, end);
        return (float)(random.NextDouble() * (ub - lb) + lb);
    }
}
