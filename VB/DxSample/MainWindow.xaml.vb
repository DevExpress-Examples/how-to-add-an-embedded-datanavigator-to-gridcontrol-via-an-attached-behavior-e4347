Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows

Namespace DxSample
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			gridControl1.ItemsSource = DataHelper.GetData()
		End Sub
	End Class
End Namespace
