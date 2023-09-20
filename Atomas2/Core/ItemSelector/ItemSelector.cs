using Atomas2.Contracts.Atom;
using Atomas2.Contracts.Items;
using Atomas2.Core.Factories;

using Atomas2.Models.Items;
using ProbabalisticEvents;
using System.Collections.Immutable;


namespace Atomas2.Core
{
    public class ItemSelector
    {

        private static Random Random = new Random();
        private static int Error { get => Random.Next(-2, 4); }
        public static int ProgressionMarker { get; set; } = 4;


        private static ProbabalisticEventSelector<IItem> Selector = ProbabalisticEventSelector<IItem>.Create(

                () => ItemFactory.Create(ProgressionMarker + Error), //Default create atom.


                //Power Creation.

                (0.0001, () => ItemFactory.Create((int)PowerTypes.AntiMatter)),

                (0.001, () => ItemFactory.Create((int)PowerTypes.DarkMinus)),

                (0.01, () => ItemFactory.Create((int)PowerTypes.DarkPlus)),

                (0.01, () => ItemFactory.Create((int)PowerTypes.Neutrino)),

                (0.05, () => ItemFactory.Create((int)PowerTypes.Minus)),

                (0.07, () => ItemFactory.Create((int)PowerTypes.Plus))

            );

        public static IItem GetNextItem() => Selector.GetAndExecute();


    }
}
