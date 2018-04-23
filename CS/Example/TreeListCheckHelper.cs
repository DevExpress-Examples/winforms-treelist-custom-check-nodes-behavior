using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Example
{
    class TreeListCheckHelper
    {
        public TreeListCheckHelper(TreeList treeList)
        {
            treeList.OptionsSelection.MultiSelect = true;
            treeList.OptionsView.ShowCheckBoxes = true;
            treeList.OptionsBehavior.AllowIndeterminateCheckState = false;
            treeList.BeforeCheckNode += treeList1_BeforeCheckNode;
        }

        private bool AnyChildIsChecked(TreeListNode node)
        {
            foreach(TreeListNode childNode in node.Nodes)
                if(childNode.CheckState == CheckState.Checked)
                    return true;
            return false;
        }
        private void treeList1_BeforeCheckNode(object sender, CheckNodeEventArgs e)
        {
            TreeListNode node = e.Node;
            if(node.Checked)
                node.UncheckAll();
            else node.CheckAll();
            while(node.ParentNode != null)
            {
                node = node.ParentNode;
                node.CheckState = AnyChildIsChecked(node) ? CheckState.Checked : CheckState.Unchecked;
            }
        }
    }
}