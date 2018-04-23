namespace DateTimeAggregation {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.cbAggregateFunction = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbGridAlignment = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbScaleMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbMeasureUnit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAggregateFunction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGridAlignment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbScaleMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMeasureUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkEdit1);
            this.panel1.Controls.Add(this.cbAggregateFunction);
            this.panel1.Controls.Add(this.cbGridAlignment);
            this.panel1.Controls.Add(this.cbScaleMode);
            this.panel1.Controls.Add(this.cbMeasureUnit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 93);
            this.panel1.TabIndex = 0;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(569, 21);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Only work days";
            this.checkEdit1.Size = new System.Drawing.Size(109, 19);
            this.checkEdit1.TabIndex = 12;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // cbAggregateFunction
            // 
            this.cbAggregateFunction.Location = new System.Drawing.Point(429, 22);
            this.cbAggregateFunction.Name = "cbAggregateFunction";
            this.cbAggregateFunction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAggregateFunction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbAggregateFunction.Size = new System.Drawing.Size(100, 20);
            this.cbAggregateFunction.TabIndex = 11;
            this.cbAggregateFunction.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedValueChanged);
            // 
            // cbGridAlignment
            // 
            this.cbGridAlignment.Location = new System.Drawing.Point(429, 56);
            this.cbGridAlignment.Name = "cbGridAlignment";
            this.cbGridAlignment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGridAlignment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbGridAlignment.Size = new System.Drawing.Size(100, 20);
            this.cbGridAlignment.TabIndex = 10;
            this.cbGridAlignment.SelectedValueChanged += new System.EventHandler(this.ComboBoxSelectedValueChanged);
            // 
            // cbScaleMode
            // 
            this.cbScaleMode.Location = new System.Drawing.Point(153, 21);
            this.cbScaleMode.Name = "cbScaleMode";
            this.cbScaleMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbScaleMode.Properties.DropDownRows = 6;
            this.cbScaleMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbScaleMode.Size = new System.Drawing.Size(100, 20);
            this.cbScaleMode.TabIndex = 9;
            this.cbScaleMode.SelectedValueChanged += new System.EventHandler(this.ComboBoxSelectedValueChanged);
            // 
            // cbMeasureUnit
            // 
            this.cbMeasureUnit.Location = new System.Drawing.Point(153, 60);
            this.cbMeasureUnit.Name = "cbMeasureUnit";
            this.cbMeasureUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMeasureUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbMeasureUnit.Size = new System.Drawing.Size(100, 20);
            this.cbMeasureUnit.TabIndex = 2;
            this.cbMeasureUnit.SelectedValueChanged += new System.EventHandler(this.ComboBoxSelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aggregate Function:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grid Alignment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Scale Mode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Measure Unit:";
            // 
            // chartControl1
            // 
            this.chartControl1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.MinorCount = 3;
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Title.Visibility =  DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.EnableAxisXZooming = true;
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Visibility =  DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(0, 93);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.Name = "Orders";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(1082, 577);
            this.chartControl1.TabIndex = 0;
            chartTitle1.Text = "Date-Time Data Aggregation";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 670);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAggregateFunction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGridAlignment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbScaleMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMeasureUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbAggregateFunction;
        private DevExpress.XtraEditors.ComboBoxEdit cbGridAlignment;
        private DevExpress.XtraEditors.ComboBoxEdit cbScaleMode;
        private DevExpress.XtraEditors.ComboBoxEdit cbMeasureUnit;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}

