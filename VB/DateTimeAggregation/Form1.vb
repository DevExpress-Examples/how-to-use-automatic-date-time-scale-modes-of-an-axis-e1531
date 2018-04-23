Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Windows.Forms
Imports System.Xml
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors

Namespace DateTimeAggregation


	Partial Public Class Form1
		Inherits Form

		Private Const title As String = "Measure Unit: "
		Private gridAlignmentItems As List(Of ComboBoxItem)
		Protected ReadOnly Property Diagram() As XYDiagram
			Get
				Return TryCast(chartControl1.Diagram, XYDiagram)
			End Get
		End Property
		Protected ReadOnly Property AxisX() As AxisX
			Get
				Return Diagram.AxisX
			End Get
		End Property
		Private ReadOnly Property SeriesGBP() As Series
			Get
				Return chartControl1.Series(0)
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			LoadSeries(SeriesGBP, "GbpUsdRate.xml", "GBPUSD", "GBP")
			gridAlignmentItems = CreateGridAlignmentComboBoxItems()
			FillScaleMode()
			FillMeasureUnit()
			FillFunctions()
			cbMeasureUnit.SelectedIndex = 1
		End Sub


		Private Function CreateGridAlignmentComboBoxItems() As List(Of ComboBoxItem)
			Return New List(Of ComboBoxItem) (New ComboBoxItem() {New ComboBoxItem("Auto", AddressOf SetAutoGridAlignment), New ComboBoxItem("Year", AddressOf SetYearGridAlignment), New ComboBoxItem("Quarter", AddressOf SetQuarterGridAlignment), New ComboBoxItem("Month", AddressOf SetMonthGridAlignment), New ComboBoxItem("Week", AddressOf SetWeekGridAlignment), New ComboBoxItem("Day", AddressOf SetDayGridAlignment)})
		End Function

		Private Sub FillScaleMode()
			Dim scaleModeItems As New List(Of ComboBoxItem) (New ComboBoxItem() {New ComboBoxItem("Automatic", AddressOf SetAutomaticScaleMode), New ComboBoxItem("Manual", AddressOf SetManualScaleMode), New ComboBoxItem("Continuous", AddressOf SetContinuousScaleMode)})

			cbScaleMode.Properties.Items.AddRange(scaleModeItems)
			cbScaleMode.SelectedIndex = 1
		End Sub

		Private Sub FillMeasureUnit()
			Dim measureUnitItems As New List(Of ComboBoxItem) (New ComboBoxItem() {New ComboBoxItem("Year", AddressOf SetYearMeasureUnit), New ComboBoxItem("Quarter", AddressOf SetQuarterMeasureUnit), New ComboBoxItem("Month", AddressOf SetMonthMeasureUnit), New ComboBoxItem("Week", AddressOf SetWeekMeasureUnit), New ComboBoxItem("Day", AddressOf SetDayMeasureUnit)})

			cbMeasureUnit.Properties.Items.AddRange(measureUnitItems)
		End Sub

		Private Sub FillFunctions()
			Dim aggregateFunctionItems As New List(Of ComboBoxItem) (New ComboBoxItem() {New ComboBoxItem("Average", AddressOf SetAverageFunctionItems), New ComboBoxItem("Minimum", AddressOf SetMinimumFunctionItems), New ComboBoxItem("Maximum", AddressOf SetMaximumFunctionItems), New ComboBoxItem("Sum", AddressOf SetSumFunctionItems), New ComboBoxItem("Count", AddressOf SetCountFunctionItems)})

			cbAggregateFunction.Properties.Items.AddRange(aggregateFunctionItems)
			cbAggregateFunction.SelectedIndex = 0
		End Sub

		Private Sub LoadSeries(ByVal series As Series, ByVal xmlFile As String, ByVal name As String, ByVal shortName As String)
			LoadPoints(series, AssemblyHelper.GetEmbeddedResourceStream(GetType(ComboBoxItem).Assembly, xmlFile, False))
			series.Name = name
		End Sub

		Private Sub LoadPoints(ByVal series As Series, ByVal xmlStream As Stream)
			If series IsNot Nothing AndAlso xmlStream IsNot Nothing Then
				Dim document As New XmlDocument()
				document.Load(xmlStream)
				series.Points.BeginUpdate()
				series.Points.Clear()
				If document IsNot Nothing Then
					Dim elements As XmlNodeList = document.DocumentElement.GetElementsByTagName("CurrencyRate")
					For Each element As XmlNode In elements
						Dim [date] As DateTime = DateTime.Parse(element.ChildNodes(0).InnerText)
						Dim rate As Double = Double.Parse(element.ChildNodes(1).InnerText, CultureInfo.InvariantCulture)
						series.Points.Add(New SeriesPoint([date], rate))
					Next element
				End If
				series.Points.EndUpdate()
			End If
		End Sub


		Private Sub ResetAxisOptions()
			AxisX.DateTimeScaleOptions.GridSpacing = 1
			AxisX.Tickmarks.MinorVisible = False
			AxisX.Label.Angle = 0
			SetAxisXGridAuto()
		End Sub

		Private Sub SetAxisXGridAuto()
			AxisX.DateTimeScaleOptions.AutoGrid = True
		End Sub
		Private Sub ScaleOptionConditions()
			cbGridAlignment.Enabled = True
			cbMeasureUnit.Enabled = True
			cbAggregateFunction.Enabled = True

			Select Case AxisX.DateTimeScaleOptions.ScaleMode
				Case ScaleMode.Automatic
						cbGridAlignment.Enabled = False
						cbMeasureUnit.Enabled = False
				Case ScaleMode.Manual
						cbGridAlignment.Enabled = True
						cbMeasureUnit.Enabled = True
						cbAggregateFunction.Enabled = True
						Exit Select
				Case ScaleMode.Continuous
						cbAggregateFunction.Enabled = False
						cbMeasureUnit.Enabled = False

			End Select
		End Sub

		Private Sub SetAxisXGridAlignment(ByVal gridAlignment As DateTimeGridAlignment)
			AxisX.DateTimeScaleOptions.AutoGrid = False
			AxisX.DateTimeScaleOptions.GridAlignment = gridAlignment
		End Sub

		Private Sub SetAxisXAggregateFunction(ByVal aggregateFunction As AggregateFunction)
			AxisX.DateTimeScaleOptions.AggregateFunction = aggregateFunction
		End Sub

		Private Sub SetAutomaticScaleMode()
			ResetAxisOptions()
			AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Automatic
			UpdateGridAlignment(1)
		End Sub

		Private Sub SetManualScaleMode()
			AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual
			UpdateGridAlignment(2)
		End Sub

		Private Sub SetContinuousScaleMode()
			AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous
			UpdateGridAlignment(3)
		End Sub

		Private Sub SetYearMeasureUnit()
			AxisX.Label.DateTimeOptions.Format = DateTimeFormat.Custom
			AxisX.Label.DateTimeOptions.FormatString = "yyyy"
			AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Year
			UpdateGridAlignment(1)
		End Sub
		Private Sub SetQuarterMeasureUnit()
			ResetAxisOptions()
			AxisX.Label.DateTimeOptions.Format = DateTimeFormat.QuarterAndYear
			AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Quarter
			UpdateGridAlignment(2)
		End Sub
		Private Sub SetMonthMeasureUnit()
			ResetAxisOptions()
			AxisX.Label.DateTimeOptions.Format = DateTimeFormat.MonthAndYear
			AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Month
			UpdateGridAlignment(3)
		End Sub
		Private Sub SetWeekMeasureUnit()
			ResetAxisOptions()
			AxisX.Label.DateTimeOptions.Format = DateTimeFormat.Custom
			AxisX.Label.DateTimeOptions.FormatString = "d MMMM yyyy"
			AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Week
			UpdateGridAlignment(4)
		End Sub
		Private Sub SetDayMeasureUnit()
			ResetAxisOptions()
			AxisX.Label.DateTimeOptions.Format = DateTimeFormat.Custom
			AxisX.Label.DateTimeOptions.FormatString = "d"
			AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day
			UpdateGridAlignment(5)
		End Sub


		Private Sub UpdateGridAlignment(ByVal itemsCount As Integer)
			itemsCount = Math.Max(itemsCount, 1) + 1
			Dim selectedIndex As Integer = Math.Max(cbGridAlignment.SelectedIndex, 0)
			cbGridAlignment.Properties.Items.Clear()
			cbGridAlignment.Properties.Items.AddRange(gridAlignmentItems.GetRange(0, itemsCount))
			cbGridAlignment.SelectedIndex = Math.Min(itemsCount - 1, selectedIndex)
			ScaleOptionConditions()
			ExecuteSelectedItemAction(cbGridAlignment)

		End Sub

		Private Sub SetDayGridAlignment()
			SetAxisXGridAlignment(DateTimeGridAlignment.Day)
		End Sub
		Private Sub SetWeekGridAlignment()
			SetAxisXGridAlignment(DateTimeGridAlignment.Week)
		End Sub
		Private Sub SetMonthGridAlignment()
			SetAxisXGridAlignment(DateTimeGridAlignment.Month)
		End Sub
		Private Sub SetQuarterGridAlignment()
			SetAxisXGridAlignment(DateTimeGridAlignment.Quarter)
		End Sub
		Private Sub SetYearGridAlignment()
			SetAxisXGridAlignment(DateTimeGridAlignment.Year)
		End Sub
		Private Sub SetAutoGridAlignment()
			SetAxisXGridAuto()
		End Sub
		Private Sub SetCountFunctionItems()
			SetAxisXAggregateFunction(AggregateFunction.Count)
		End Sub
		Private Sub SetSumFunctionItems()
			SetAxisXAggregateFunction(AggregateFunction.Sum)
		End Sub
		Private Sub SetMaximumFunctionItems()
			SetAxisXAggregateFunction(AggregateFunction.Maximum)
		End Sub
		Private Sub SetMinimumFunctionItems()
			SetAxisXAggregateFunction(AggregateFunction.Minimum)
		End Sub
		Private Sub SetAverageFunctionItems()
			SetAxisXAggregateFunction(AggregateFunction.Average)
		End Sub

		Private Sub ExecuteSelectedItemAction(ByVal comboBox As ComboBoxEdit)
			Dim item As ComboBoxItem = TryCast(comboBox.SelectedItem, ComboBoxItem)
			If item IsNot Nothing Then
				Dim itemAction As Action = item.Action
				If itemAction IsNot Nothing Then
					itemAction()
				End If
			End If
		End Sub

		Private Sub ComboBoxSelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAggregateFunction.SelectedIndexChanged, cbGridAlignment.SelectedValueChanged, cbScaleMode.SelectedValueChanged, cbMeasureUnit.SelectedValueChanged
			Dim comboBox As ComboBoxEdit = TryCast(sender, ComboBoxEdit)
			If comboBox IsNot Nothing Then
				ExecuteSelectedItemAction(comboBox)
			End If
		End Sub

		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
			AxisX.DateTimeScaleOptions.WorkdaysOnly = (CType(sender, CheckEdit)).Checked
		End Sub
	End Class

	Public Class ComboBoxItem
		Private titleText As String

		Private privateAction As Action
		Public Property Action() As Action
			Get
				Return privateAction
			End Get
			Private Set(ByVal value As Action)
				privateAction = value
			End Set
		End Property

		Public Sub New(ByVal titleText As String, ByVal action As Action)
			Me.titleText = titleText
			Action = action
		End Sub
		Public Overrides Function ToString() As String
			Return titleText
		End Function
	End Class
End Namespace
