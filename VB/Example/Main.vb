Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports System
Imports System.ComponentModel
Imports System.Linq

Namespace Example
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			InitializeTreeList(treeList1)
			treeList1.ExpandAll()
			Dim treeListCheckHelper As New TreeListCheckHelper(treeList1)
		End Sub

		Private Sub InitializeTreeList(ByVal treeList As TreeList)
			Dim customerList As New BindingList(Of Customer)()
			Dim recordsID As Integer = 0, levels As Integer = 4
			For i As Integer = 1 To 19
				customerList.Add(New Customer("Customer" & i, i Mod levels, recordsID))
				recordsID += 1
			Next i
			treeList.RootValue = 0
			treeList.ParentFieldName = "ParentID"
			treeList.KeyFieldName = "ID"
			treeList.DataSource = customerList
		End Sub
	End Class
End Namespace