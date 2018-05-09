using System;

namespace Composite
{
    public class TreeItemLeaf : TreeItemBase
    {
        private string _text;
        public TreeItemLeaf(string text) => _text = text;
        public override string GetText(int depth) => $"{new String(TAB_CHAR, depth)}- {_text}";

        public override void Add(TreeItemBase treeItem) => throw new NotSupportedException();
        public override void Remove(TreeItemBase treeItem) => throw new NotSupportedException();
    }
}