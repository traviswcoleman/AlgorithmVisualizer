using AlgorithmVisualizer.Contracts.Models;

using AlgorithmVisualizer.Business.CodingChallenges.Challenge;

using Microsoft.Extensions.DependencyInjection;
using AlgorithmVisualizer.Business.Common;

namespace AlgorithmVisualizer.Business.CodingChallenges;
public static class ChallengesFactory
{
    private static readonly Dictionary<string, IDrawable> _allDrawables;

    static ChallengesFactory()
    {
        IEnumerable<Type> types = typeof(ChallengesFactory).Assembly.GetTypes().Where(type => type.IsSubclassOf(typeof(BaseDrawable)));
        _allDrawables = [];
        foreach(Type type in types)
        {
            IDrawable? drawable = Activator.CreateInstance(type) as IDrawable;
            if(drawable is not null)
            {
                _allDrawables.Add(drawable.Name, drawable);
            }
        }
    }

    public static IDrawable? GetDrawable(string name)
    {
        return _allDrawables.TryGetValue(name, out IDrawable? value) ? value : null;
    }

    public static IEnumerable<string> ListCodingChallenges()
    {
        return _allDrawables.Keys;
    }
}
