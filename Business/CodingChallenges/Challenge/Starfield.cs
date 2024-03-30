using System.Drawing;
using System.Runtime.Versioning;

using AlgorithmVisualizer.Contracts.Models;
using AlgorithmVisualizer.Business.Common;
using System.Drawing.Drawing2D;
using System.Numerics;

namespace AlgorithmVisualizer.Business.CodingChallenges.Challenge;

public class Starfield : BaseDrawable
{
    public override string Name => nameof(Starfield);
    public override string? SourceUrl => "https://thecodingtrain.com/challenges/1-starfield";

    private readonly Random _rand = new();
    private readonly Star[] _stars = new Star[500];

    private Matrix? _translation;

    public override void Setup(Graphics graphics)
    {
        for(int i = 0; i < _stars.Length; i++)
        {
            _stars[i] = new Star(_rand.NextFloat(-graphics.VisibleClipBounds.Width, graphics.VisibleClipBounds.Width),
                                _rand.NextFloat(-graphics.VisibleClipBounds.Height, graphics.VisibleClipBounds.Height),
                                _rand.NextFloat(0.5f,graphics.VisibleClipBounds.Width));
        }

        _translation = new Matrix(Matrix3x2.CreateTranslation(graphics.VisibleClipBounds.Width / 2.0f, graphics.VisibleClipBounds.Height / 2.0f));
    }

    public override bool Draw(Graphics graphics, TimeSpan deltaTime) {
        if (_translation == null) return true;

        graphics.Transform = _translation;
        foreach(var star in _stars)
        {
            star.Update(deltaTime, graphics.VisibleClipBounds, _rand);
            star.Show(graphics);
        }

        return false;
    }
}

internal class Star(float x, float y, float z)
{
    public float X { get; set; } = x;
    public float Y { get; set; } = y;
    public float Z { get; set; } = z;

    public void Update(TimeSpan deltaTime, RectangleF bounds, Random random)
    {
        Z -= (float)(1 * deltaTime.TotalMilliseconds);
        if(Z < 0.1)
        {
            Z = bounds.Width;
            X = random.NextFloat(-bounds.Width, bounds.Width);
            Y = random.NextFloat(-bounds.Height, bounds.Height);
        }
    }

    public void Show(Graphics graphics)
    {
        float sx = MathExtensions.Map(X / Z, 0, 1, 0, graphics.VisibleClipBounds.Width);
        float sy = MathExtensions.Map(Y / Z, 0, 1, 0, graphics.VisibleClipBounds.Height);

        float r = MathExtensions.Map(Z, 0, graphics.VisibleClipBounds.Width, 16, 0);
        graphics.FillEllipse(Brushes.White, sx, sy, r, r);
    }
}