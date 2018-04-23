<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesLabel4 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.label1 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.NwindDataSet = New WindowsApplication1.nwindDataSet()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New WindowsApplication1.nwindDataSetTableAdapters.OrdersTableAdapter()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartControl1
        '
        Me.ChartControl1.DataAdapter = Me.OrdersTableAdapter
        Me.ChartControl1.DataSource = Me.OrdersBindingSource
        XyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram2.AxisX.Range.SideMarginsEnabled = True
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram2.AxisY.Range.SideMarginsEnabled = True
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram2
        Me.ChartControl1.Legend.Visible = False
        Me.ChartControl1.Location = New System.Drawing.Point(12, 53)
        Me.ChartControl1.Name = "ChartControl1"
        Series2.ArgumentDataMember = "OrderDate"
        Series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        SideBySideBarSeriesLabel3.LineVisible = True
        Series2.Label = SideBySideBarSeriesLabel3
        Series2.Name = "Series 1"
        Series2.ValueDataMembersSerializable = "Freight"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        SideBySideBarSeriesLabel4.LineVisible = True
        Me.ChartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel4
        Me.ChartControl1.Size = New System.Drawing.Size(796, 394)
        Me.ChartControl1.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(24, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(158, 13)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Choose a date-time scale mode:"
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"Manual", "AutomaticAverage", "AutomaticIntegral"})
        Me.comboBox1.Location = New System.Drawing.Point(188, 16)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(140, 21)
        Me.comboBox1.TabIndex = 6
        '
        'NwindDataSet
        '
        Me.NwindDataSet.DataSetName = "nwindDataSet"
        Me.NwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.NwindDataSet
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 470)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.ChartControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents OrdersTableAdapter As WindowsApplication1.nwindDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents NwindDataSet As WindowsApplication1.nwindDataSet
    Friend WithEvents OrdersBindingSource As System.Windows.Forms.BindingSource

End Class
