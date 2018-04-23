Imports DevExpress.XtraCharts
Imports System
Imports System.Windows.Forms
Namespace ErrorBarsWin
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub FormOnLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)
'            #Region "#FixedValueErrorBars"
            Dim view As PointSeriesView = CType(chartControl.Series(0).View, PointSeriesView)
            view.Indicators.Add(New FixedValueErrorBars With {.NegativeError = 7, .PositiveError = 10, .Direction = ErrorBarDirection.Both, .ShowInLegend = True, .Name = "Unit Price Range"})
'            #End Region ' #FixedValueErrorBars
        End Sub
    End Class
End Namespace
