using Atomas2.Contracts.Items;
using Atomas2.Contracts.Modules;
using Atomas2.Core;
using Atomas2.Models.Items;

namespace Atomas2.Modules
{
    public class ItemModule : IItemModule
    {
        private static int MaxAtom = 1;
        private static int ProgressionMarker = 4;
        public IItem GetNextItem()
        {
            return ItemSelector.GetNextItem(ProgressionMarker);
        }

        public void UpdateMax(int Max)
        {
            if (Max > MaxAtom) {

                MaxAtom = Max;
                ProgressionMarker = 2 * MaxAtom / 3 + 1;

             } else {

                throw new Exception("Don't try to break it");
            }
        }
    }
}
