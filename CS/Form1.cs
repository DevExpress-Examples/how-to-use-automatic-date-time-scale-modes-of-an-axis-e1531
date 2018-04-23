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
                    axis.DateTimeScaleMode = DateTimeScaleMode.Manual;
                    axis.DateTimeMeasureUnit = DateTimeMeasurementUnit.Day;
                    axis.DateTimeGridAlignment = DateTimeMeasurementUnit.Day;
                    break;
                case 1:
                    axis.DateTimeScaleMode = DateTimeScaleMode.AutomaticAverage;
                    break;
                case 2:
                    axis.DateTimeScaleMode = DateTimeScaleMode.AutomaticIntegral;
                    break;
            }
        }

    }
}
