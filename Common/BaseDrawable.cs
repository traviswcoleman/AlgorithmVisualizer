using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlgorithmVisualizer.Contracts.Models;

namespace AlgorithmVisualizer.Business.Common;
public abstract class BaseDrawable : IDrawable
{
    public abstract string Name { get; }

    public abstract string? SourceUrl { get; }

    //TODO: Add mechanism to get controls
    public virtual bool Draw(Graphics graphics, TimeSpan deltaTime)
    {
        return true;
    }

    public virtual Color GetBackgroundColor()
    {
        return Color.Black;
    }

    public virtual void Setup(Graphics graphics)
    {
        
    }
}
