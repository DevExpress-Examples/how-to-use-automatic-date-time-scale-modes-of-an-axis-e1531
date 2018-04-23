using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);

            this.comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            AxisX axis = ((XYDiagram)this.chartControl1.Diagram).AxisX;

            switch (comboBox1.SelectedIndex) {
                case 0:
                    axis.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual;
                    axis.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day;
                    axis.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Day;
                    break;
                case 1:
                    axis.DateTimeScaleOptions.ScaleMode = ScaleMode.Automatic;
                    axis.DateTimeScaleOptions.AggregateFunction = AggregateFunction.Average;
                    break;
                case 2:
                    axis.DateTimeScaleOptions.ScaleMode = ScaleMode.Automatic;
                    axis.DateTimeScaleOptions.AggregateFunction = AggregateFunction.Sum;
                    break;
            }
        }

    }
}
