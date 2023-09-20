using Atomas2.Contracts.Items;

namespace Atomas2.Contracts.Modules
{
    public interface IItemModule
    {
        public IItem GetNextItem();

        public void UpdateMax(int Max);
    }
}
