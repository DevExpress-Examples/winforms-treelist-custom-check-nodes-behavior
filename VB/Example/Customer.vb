Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Linq
Imports System.Runtime.CompilerServices

Namespace Example
	Public Class Customer
		Implements INotifyPropertyChanged
		Private firstName_Renamed As String
		Private id_Renamed As Integer
		Private parentID_Renamed As Integer

		Public Sub New()
			FirstName = "FirstName"
			ParentID = 0
			id_Renamed = 0
		End Sub

		Public Sub New(ByVal firstName As String, ByVal parentID As Integer, ByVal id As Integer)
			Me.FirstName = firstName
			Me.ParentID = parentID
			Me.id_Renamed = id
		End Sub

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub NotifyPropertyChanged(<CallerMemberName> Optional ByVal propertyName As String = "")
            If PropertyChangedEvent IsNot Nothing Then
                PropertyChangedEvent.Invoke(Me, New PropertyChangedEventArgs(propertyName))
            End If
        End Sub

        Public Property FirstName() As String
			Get
				Return firstName_Renamed
			End Get
			Set(ByVal value As String)
				If value <> firstName_Renamed Then
					firstName_Renamed = value
					NotifyPropertyChanged()
				End If
			End Set
		End Property
		Public ReadOnly Property ID() As Integer
			Get
				Return id_Renamed
			End Get
		End Property
		Public Property ParentID() As Integer
			Get
				Return parentID_Renamed
			End Get
			Set(ByVal value As Integer)
				If value <> parentID_Renamed Then
					parentID_Renamed = value
					NotifyPropertyChanged()
				End If
			End Set
		End Property
	End Class
End Namespace