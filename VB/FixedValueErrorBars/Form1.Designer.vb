Namespace ErrorBarsWin
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim pointSeriesView1 As New DevExpress.XtraCharts.PointSeriesView()
            Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            Me.productsTableAdapter = New ErrorBarsWin.nwindDataSetTableAdapters.ProductsTableAdapter()
            Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New ErrorBarsWin.nwindDataSet()
            DirectCast(Me.chartControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(pointSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' chartControl
            ' 
            Me.chartControl.DataAdapter = Me.productsTableAdapter
            Me.chartControl.DataBindings = Nothing
            Me.chartControl.DataSource = Me.productsBindingSource
            xyDiagram1.AxisX.Tickmarks.MinorVisible = False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            Me.chartControl.Diagram = xyDiagram1
            Me.chartControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartControl.Legend.Name = "Default Legend"
            Me.chartControl.Location = New System.Drawing.Point(0, 0)
            Me.chartControl.Name = "chartControl"
            series1.ArgumentDataMember = "ProductName"
            series1.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() { New DevExpress.XtraCharts.DataFilter("CategoryID", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 3)})
            series1.Name = "List Price"
            series1.ValueDataMembersSerializable = "UnitPrice"
            series1.View = pointSeriesView1
            Me.chartControl.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.chartControl.Size = New System.Drawing.Size(754, 369)
            Me.chartControl.TabIndex = 0
            chartTitle1.Text = "Range of Prices"
            Me.chartControl.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
            ' 
            ' productsTableAdapter
            ' 
            Me.productsTableAdapter.ClearBeforeFill = True
            ' 
            ' productsBindingSource
            ' 
            Me.productsBindingSource.DataMember = "Products"
            Me.productsBindingSource.DataSource = Me.nwindDataSet
            Me.productsBindingSource.Position = 0
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(754, 369)
            Me.Controls.Add(Me.chartControl)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(pointSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private chartControl As DevExpress.XtraCharts.ChartControl
        Private productsTableAdapter As nwindDataSetTableAdapters.ProductsTableAdapter
        Private nwindDataSet As nwindDataSet
        Private productsBindingSource As System.Windows.Forms.BindingSource
    End Class
End Namespace

