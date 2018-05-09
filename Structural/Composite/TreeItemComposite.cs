using System;
using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    public class TreeItemComposite : TreeItemBase
    {
        private string _text;
        private List<TreeItemBase> _childItems;
        public TreeItemComposite(string text)
        {
            _text = text;
            _childItems = new List<TreeItemBase>();
        }

        public override void Add(TreeItemBase treeItem) => this._childItems.Add(treeItem);
        public override void Remove(TreeItemBase treeItem) => this._childItems.Remove(treeItem);

        public override string GetText(int depth = 0)
        {
            var tab = new String(TAB_CHAR, depth);
            var childItemsTexts = _childItems.Select(child => $"{child.GetText(depth + TAB_SIZE)}");
            var childItemsJoinedString = String.Join("\n", childItemsTexts);
            var text = $"{tab}+ {_text}\n{childItemsJoinedString}";
            return text;
        }
    }
}