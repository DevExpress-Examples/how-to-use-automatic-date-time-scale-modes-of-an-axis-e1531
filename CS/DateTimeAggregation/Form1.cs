using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;

namespace DateTimeAggregation {


    public partial class Form1 : Form {

        const string title = "Measure Unit: ";
        List<ComboBoxItem> gridAlignmentItems;
        protected XYDiagram Diagram { get { return chartControl1.Diagram as XYDiagram; } }
        protected AxisX AxisX { get { return Diagram.AxisX; } }
        Series SeriesGBP { get { return chartControl1.Series[0]; } }

        public Form1() {
            InitializeComponent();
            LoadSeries(SeriesGBP, "GbpUsdRate.xml", "GBPUSD", "GBP");
            gridAlignmentItems = CreateGridAlignmentComboBoxItems();
            FillScaleMode();
            FillMeasureUnit();
            FillFunctions();
            cbMeasureUnit.SelectedIndex = 1;
        }


        List<ComboBoxItem> CreateGridAlignmentComboBoxItems() {
            return new List<ComboBoxItem>() {
                new ComboBoxItem("Auto", SetAutoGridAlignment),
                new ComboBoxItem("Year", SetYearGridAlignment),
                new ComboBoxItem("Quarter", SetQuarterGridAlignment),
                new ComboBoxItem("Month", SetMonthGridAlignment),
                new ComboBoxItem("Week", SetWeekGridAlignment),
                new ComboBoxItem("Day", SetDayGridAlignment),                           
            };
        }

        void FillScaleMode() {
            List<ComboBoxItem> scaleModeItems = new List<ComboBoxItem>() {
                new ComboBoxItem("Automatic", SetAutomaticScaleMode),
                new ComboBoxItem("Manual", SetManualScaleMode),
                new ComboBoxItem("Continuous", SetContinuousScaleMode),
            };

            cbScaleMode.Properties.Items.AddRange(scaleModeItems);
            cbScaleMode.SelectedIndex = 1;
        }

        void FillMeasureUnit() {
            List<ComboBoxItem> measureUnitItems = new List<ComboBoxItem>() {               
                new ComboBoxItem("Year", SetYearMeasureUnit),
                new ComboBoxItem("Quarter", SetQuarterMeasureUnit),
                new ComboBoxItem("Month", SetMonthMeasureUnit),
                new ComboBoxItem("Week", SetWeekMeasureUnit),
                new ComboBoxItem("Day", SetDayMeasureUnit),  
                     
            };

            cbMeasureUnit.Properties.Items.AddRange(measureUnitItems);
        }

        void FillFunctions() {
            List<ComboBoxItem> aggregateFunctionItems = new List<ComboBoxItem>() {
                new ComboBoxItem("Average", SetAverageFunctionItems),
                new ComboBoxItem("Minimum", SetMinimumFunctionItems),
                new ComboBoxItem("Maximum", SetMaximumFunctionItems),
                new ComboBoxItem("Sum", SetSumFunctionItems),
                new ComboBoxItem("Count", SetCountFunctionItems),                
            };

            cbAggregateFunction.Properties.Items.AddRange(aggregateFunctionItems);
            cbAggregateFunction.SelectedIndex = 0;
        }

        void LoadSeries(Series series, string xmlFile, string name, string shortName) {
            LoadPoints(series, AssemblyHelper.GetEmbeddedResourceStream(typeof(ComboBoxItem).Assembly, xmlFile, false));
            series.Name = name;
        }

        void LoadPoints(Series series, Stream xmlStream) {
            if (series != null && xmlStream != null) {
                XmlDocument document = new XmlDocument();
                document.Load(xmlStream);
                series.Points.BeginUpdate();
                series.Points.Clear();
                if (document != null) {
                    XmlNodeList elements = document.DocumentElement.GetElementsByTagName("CurrencyRate");
                    foreach (XmlNode element in elements) {
                        DateTime date = DateTime.Parse(element.ChildNodes[0].InnerText);
                        double rate = double.Parse(element.ChildNodes[1].InnerText, CultureInfo.InvariantCulture);
                        series.Points.Add(new SeriesPoint(date, rate));
                    }
                }
                series.Points.EndUpdate();
            }
        }


        void ResetAxisOptions() {
            AxisX.DateTimeScaleOptions.GridSpacing = 1;
            AxisX.Tickmarks.MinorVisible = false;
            AxisX.Label.Angle = 0;
            SetAxisXGridAuto();
        }

        void SetAxisXGridAuto() {
            AxisX.DateTimeScaleOptions.AutoGrid = true;
        }
        void ScaleOptionConditions() {
            cbGridAlignment.Enabled = true;
            cbMeasureUnit.Enabled = true;
            cbAggregateFunction.Enabled = true;

            switch (AxisX.DateTimeScaleOptions.ScaleMode) {
                case ScaleMode.Automatic: {
                        cbGridAlignment.Enabled = false;
                        cbMeasureUnit.Enabled = false;
                    }
                    break;
                case ScaleMode.Manual: {
                        cbGridAlignment.Enabled = true;
                        cbMeasureUnit.Enabled = true;
                        cbAggregateFunction.Enabled = true;
                        break;
                    }
                case ScaleMode.Continuous: {
                        cbAggregateFunction.Enabled = false;
                        cbMeasureUnit.Enabled = false;
                    }
                    break;

            }
        }

        void SetAxisXGridAlignment(DateTimeGridAlignment gridAlignment) {
            AxisX.DateTimeScaleOptions.AutoGrid = false;
            AxisX.DateTimeScaleOptions.GridAlignment = gridAlignment;
        }

        void SetAxisXAggregateFunction(AggregateFunction aggregateFunction) {
            AxisX.DateTimeScaleOptions.AggregateFunction = aggregateFunction;
        }

        void SetAutomaticScaleMode() {
            ResetAxisOptions();
            AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Automatic;
            UpdateGridAlignment(1);
        }

        void SetManualScaleMode() {
            AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual;
            UpdateGridAlignment(2);
        }

        void SetContinuousScaleMode() {
            AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous;
            UpdateGridAlignment(3);
        }

        void SetYearMeasureUnit() {
            AxisX.Label.DateTimeOptions.Format = DateTimeFormat.Custom;
            AxisX.Label.DateTimeOptions.FormatString = "yyyy";
            AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Year;
            UpdateGridAlignment(1);
        }
        void SetQuarterMeasureUnit() {
            ResetAxisOptions();
            AxisX.Label.DateTimeOptions.Format = DateTimeFormat.QuarterAndYear;
            AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Quarter;
            UpdateGridAlignment(2);
        }
        void SetMonthMeasureUnit() {
            ResetAxisOptions();
            AxisX.Label.DateTimeOptions.Format = DateTimeFormat.MonthAndYear;
            AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Month;
            UpdateGridAlignment(3);
        }
        void SetWeekMeasureUnit() {
            ResetAxisOptions();
            AxisX.Label.DateTimeOptions.Format = DateTimeFormat.Custom;
            AxisX.Label.DateTimeOptions.FormatString = "d MMMM yyyy";
            AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Week;
            UpdateGridAlignment(4);
        }
        void SetDayMeasureUnit() {
            ResetAxisOptions();
            AxisX.Label.DateTimeOptions.Format = DateTimeFormat.Custom;
            AxisX.Label.DateTimeOptions.FormatString = "d";
            AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day;
            UpdateGridAlignment(5);
        }


        void UpdateGridAlignment(int itemsCount) {
            itemsCount = Math.Max(itemsCount, 1) + 1;
            int selectedIndex = Math.Max(cbGridAlignment.SelectedIndex, 0);
            cbGridAlignment.Properties.Items.Clear();
            cbGridAlignment.Properties.Items.AddRange(gridAlignmentItems.GetRange(0, itemsCount));
            cbGridAlignment.SelectedIndex = Math.Min(itemsCount - 1, selectedIndex);
            ScaleOptionConditions();
            ExecuteSelectedItemAction(cbGridAlignment);

        }

        void SetDayGridAlignment() {
            SetAxisXGridAlignment(DateTimeGridAlignment.Day);
        }
        void SetWeekGridAlignment() {
            SetAxisXGridAlignment(DateTimeGridAlignment.Week);
        }
        void SetMonthGridAlignment() {
            SetAxisXGridAlignment(DateTimeGridAlignment.Month);
        }
        void SetQuarterGridAlignment() {
            SetAxisXGridAlignment(DateTimeGridAlignment.Quarter);
        }
        void SetYearGridAlignment() {
            SetAxisXGridAlignment(DateTimeGridAlignment.Year);
        }
        void SetAutoGridAlignment() {
            SetAxisXGridAuto();
        }
        void SetCountFunctionItems() {
            SetAxisXAggregateFunction(AggregateFunction.Count);
        }
        void SetSumFunctionItems() {
            SetAxisXAggregateFunction(AggregateFunction.Sum);
        }
        void SetMaximumFunctionItems() {
            SetAxisXAggregateFunction(AggregateFunction.Maximum);
        }
        void SetMinimumFunctionItems() {
            SetAxisXAggregateFunction(AggregateFunction.Minimum);
        }
        void SetAverageFunctionItems() {
            SetAxisXAggregateFunction(AggregateFunction.Average);
        }

        void ExecuteSelectedItemAction(ComboBoxEdit comboBox) {
            ComboBoxItem item = comboBox.SelectedItem as ComboBoxItem;
            if (item != null) {
                Action itemAction = item.Action;
                if (itemAction != null)
                    itemAction();
            }
        }

        void ComboBoxSelectedValueChanged(object sender, EventArgs e) {
            ComboBoxEdit comboBox = sender as ComboBoxEdit;
            if (comboBox != null)
                ExecuteSelectedItemAction(comboBox);
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            AxisX.DateTimeScaleOptions.WorkdaysOnly = ((CheckEdit)sender).Checked;
        }
    }

    public class ComboBoxItem {
        string titleText;

        public Action Action { get; private set; }

        public ComboBoxItem(string titleText, Action action) {
            this.titleText = titleText;
            Action = action;
        }
        public override string ToString() {
            return titleText;
        }
    }
}
