Imports Microsoft.VisualBasic
Imports System
Namespace DateTimeAggregation
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			Me.cbAggregateFunction = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbGridAlignment = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbScaleMode = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cbMeasureUnit = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.panel1.SuspendLayout()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbAggregateFunction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbGridAlignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbScaleMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbMeasureUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.checkEdit1)
			Me.panel1.Controls.Add(Me.cbAggregateFunction)
			Me.panel1.Controls.Add(Me.cbGridAlignment)
			Me.panel1.Controls.Add(Me.cbScaleMode)
			Me.panel1.Controls.Add(Me.cbMeasureUnit)
			Me.panel1.Controls.Add(Me.label4)
			Me.panel1.Controls.Add(Me.label3)
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(1082, 93)
			Me.panel1.TabIndex = 0
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Location = New System.Drawing.Point(569, 21)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "Only work days"
			Me.checkEdit1.Size = New System.Drawing.Size(109, 19)
			Me.checkEdit1.TabIndex = 12
'			Me.checkEdit1.CheckedChanged += New System.EventHandler(Me.checkEdit1_CheckedChanged);
			' 
			' cbAggregateFunction
			' 
			Me.cbAggregateFunction.Location = New System.Drawing.Point(429, 22)
			Me.cbAggregateFunction.Name = "cbAggregateFunction"
			Me.cbAggregateFunction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbAggregateFunction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbAggregateFunction.Size = New System.Drawing.Size(100, 20)
			Me.cbAggregateFunction.TabIndex = 11
'			Me.cbAggregateFunction.SelectedIndexChanged += New System.EventHandler(Me.ComboBoxSelectedValueChanged);
			' 
			' cbGridAlignment
			' 
			Me.cbGridAlignment.Location = New System.Drawing.Point(429, 56)
			Me.cbGridAlignment.Name = "cbGridAlignment"
			Me.cbGridAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbGridAlignment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbGridAlignment.Size = New System.Drawing.Size(100, 20)
			Me.cbGridAlignment.TabIndex = 10
'			Me.cbGridAlignment.SelectedValueChanged += New System.EventHandler(Me.ComboBoxSelectedValueChanged);
			' 
			' cbScaleMode
			' 
			Me.cbScaleMode.Location = New System.Drawing.Point(153, 21)
			Me.cbScaleMode.Name = "cbScaleMode"
			Me.cbScaleMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbScaleMode.Properties.DropDownRows = 6
			Me.cbScaleMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbScaleMode.Size = New System.Drawing.Size(100, 20)
			Me.cbScaleMode.TabIndex = 9
'			Me.cbScaleMode.SelectedValueChanged += New System.EventHandler(Me.ComboBoxSelectedValueChanged);
			' 
			' cbMeasureUnit
			' 
			Me.cbMeasureUnit.Location = New System.Drawing.Point(153, 60)
			Me.cbMeasureUnit.Name = "cbMeasureUnit"
			Me.cbMeasureUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbMeasureUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbMeasureUnit.Size = New System.Drawing.Size(100, 20)
			Me.cbMeasureUnit.TabIndex = 2
'			Me.cbMeasureUnit.SelectedValueChanged += New System.EventHandler(Me.ComboBoxSelectedValueChanged);
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(299, 25)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(103, 13)
			Me.label4.TabIndex = 6
			Me.label4.Text = "Aggregate Function:"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(299, 59)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(78, 13)
			Me.label3.TabIndex = 4
			Me.label3.Text = "Grid Alignment:"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(57, 25)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(67, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Scale Mode:"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(57, 63)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(73, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Measure Unit:"
			' 
			' chartControl1
			' 
			Me.chartControl1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.MinorCount = 3
			xyDiagram1.AxisX.Title.Text = "Date"
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.GridLines.MinorVisible = True
			xyDiagram1.AxisY.Title.Visible = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.EnableAxisXScrolling = True
			xyDiagram1.EnableAxisXZooming = True
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Legend.Visible = False
			Me.chartControl1.Location = New System.Drawing.Point(0, 93)
			Me.chartControl1.Name = "chartControl1"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			series1.Name = "Orders"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chartControl1.Size = New System.Drawing.Size(1082, 577)
			Me.chartControl1.TabIndex = 0
			chartTitle1.Text = "Date-Time Data Aggregation"
			Me.chartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1082, 670)
			Me.Controls.Add(Me.chartControl1)
			Me.Controls.Add(Me.panel1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbAggregateFunction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbGridAlignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbScaleMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbMeasureUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private WithEvents cbAggregateFunction As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbGridAlignment As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbScaleMode As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents cbMeasureUnit As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace

