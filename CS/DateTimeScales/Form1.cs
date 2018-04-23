using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace DateTimeScales {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);

            this.comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            switch (comboBox1.SelectedIndex) {
                case 0:
                    ((XYDiagram)this.chartControl1.Diagram).AxisX.DateTimeScaleMode = DateTimeScaleMode.Manual;
                    ((XYDiagram)this.chartControl1.Diagram).AxisX.DateTimeMeasureUnit = DateTimeMeasurementUnit.Day;
                    ((XYDiagram)this.chartControl1.Diagram).AxisX.DateTimeGridAlignment = DateTimeMeasurementUnit.Day;
                    break;
                case 1:
                    ((XYDiagram)this.chartControl1.Diagram).AxisX.DateTimeScaleMode = DateTimeScaleMode.AutomaticAverage;
                    break;
                case 2:
                    ((XYDiagram)this.chartControl1.Diagram).AxisX.DateTimeScaleMode = DateTimeScaleMode.AutomaticIntegral;
                    break;
            }
        }

    }
}
