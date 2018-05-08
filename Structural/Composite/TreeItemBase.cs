using System.Collections.Generic;

namespace Composite
{
    /// <summary>
    /// Component
    /// </summary>
    public abstract class TreeItemBase
    {
        protected const char TAB_CHAR = ' ';
        protected const int TAB_SIZE = 3;
        public abstract void Add(TreeItemBase c);
        public abstract void Remove(TreeItemBase c);
        public abstract string GetText(int depth);
    }
}