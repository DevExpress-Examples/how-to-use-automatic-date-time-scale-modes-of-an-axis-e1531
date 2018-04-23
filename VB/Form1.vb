Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts


Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) _
    Handles MyBase.Load
        Me.OrdersTableAdapter.Fill(Me.NwindDataSet.Orders)

        Me.comboBox1.SelectedIndex = 0
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) _
    Handles comboBox1.SelectedIndexChanged
        Dim axis As AxisX
        axis = CType(Me.ChartControl1.Diagram, XYDiagram).AxisX

        Select Case comboBox1.SelectedIndex
            Case 0
                axis.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual
                axis.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day
                axis.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Day
            Case 1
                axis.DateTimeScaleOptions.ScaleMode = ScaleMode.Automatic
                axis.DateTimeScaleOptions.AggregateFunction = AggregateFunction.Average
            Case 2
                axis.DateTimeScaleOptions.ScaleMode = ScaleMode.Automatic
                axis.DateTimeScaleOptions.AggregateFunction = AggregateFunction.Sum
        End Select
    End Sub
End Class
