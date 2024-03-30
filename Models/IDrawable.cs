using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualizer.Contracts.Models;
public interface IDrawable
{
    public string Name { get; }
    public string? SourceUrl { get; }
    public void Setup(Graphics graphics);
    public bool Draw(Graphics graphics, TimeSpan deltaTime);
    public Color GetBackgroundColor();

}
