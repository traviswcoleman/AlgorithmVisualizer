using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualizer.Business.Common;
public static class MathExtensions
{
    /// <summary>
    /// Similar to P5.js map
    /// </summary>
    /// <param name="input">The value to map</param>
    /// <param name="inRangeLB">The input range lower bound</param>
    /// <param name="inRangeUB">The input range upper bound</param>
    /// <param name="outRangeLB">The output range lower bound</param>
    /// <param name="outRangeUB">The output range upper bound</param>
    /// <returns></returns>
    public static float Map(float input, float inRangeLB, float inRangeUB, float outRangeLB, float outRangeUB)
    {
        return ((input - inRangeLB) / (inRangeUB)) * (outRangeUB - outRangeLB) + outRangeLB;
    }
}
