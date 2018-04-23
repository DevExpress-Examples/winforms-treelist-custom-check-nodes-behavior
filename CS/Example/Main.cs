using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using System;
using System.ComponentModel;
using System.Linq;

namespace Example
{
    public partial class Main : XtraForm
    {
        public Main()
        {
            InitializeComponent();
            InitializeTreeList(treeList1);
            treeList1.ExpandAll();
            TreeListCheckHelper treeListCheckHelper = new TreeListCheckHelper(treeList1);
        }

        void InitializeTreeList(TreeList treeList)
        {
            BindingList<Customer> customerList = new BindingList<Customer>();
            int recordsID = 0, levels = 4;
            for(int i = 1; i < 20; i++)
                customerList.Add(new Customer("Customer" + i, i % levels, recordsID++));
            treeList.RootValue = 0;
            treeList.ParentFieldName = "ParentID";
            treeList.KeyFieldName = "ID";
            treeList.DataSource = customerList;
        }
    }
}