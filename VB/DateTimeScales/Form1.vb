Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace DateTimeScales
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
			Me.ordersTableAdapter.Fill(Me.nwindDataSet.Orders)

			Me.comboBox1.SelectedIndex = 0
		End Sub

		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
			Select Case comboBox1.SelectedIndex
				Case 0
					CType(Me.chartControl1.Diagram, XYDiagram).AxisX.DateTimeScaleMode = DateTimeScaleMode.Manual
					CType(Me.chartControl1.Diagram, XYDiagram).AxisX.DateTimeMeasureUnit = DateTimeMeasurementUnit.Day
					CType(Me.chartControl1.Diagram, XYDiagram).AxisX.DateTimeGridAlignment = DateTimeMeasurementUnit.Day
				Case 1
					CType(Me.chartControl1.Diagram, XYDiagram).AxisX.DateTimeScaleMode = DateTimeScaleMode.AutomaticAverage
				Case 2
					CType(Me.chartControl1.Diagram, XYDiagram).AxisX.DateTimeScaleMode = DateTimeScaleMode.AutomaticIntegral
			End Select
		End Sub

	End Class
End Namespace
