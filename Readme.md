<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1531)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DateTimeScales/Form1.cs) (VB: [Form1.vb](./VB/DateTimeScales/Form1.vb))
<!-- default file list end -->
# How to use automatic date-time scale modes of an axis


<p>This example demonstrates how to use <strong>date-time scale modes</strong> of an <a href="http://devexpress.com/Help/Content.aspx?help=XtraCharts&document=CustomDocument6016.htm"><u>axis</u></a> (both manual and automatic).</p>


<h3>Description</h3>

<p>Note that when the <strong>AxisXBase</strong>.<strong>DateTimeScaleMode </strong>property is set to <strong>Manual</strong>, you should manually define the <strong>AxisBase</strong>.<strong>DateTimeGridAlignment </strong>and <strong>AxisBase</strong>.<strong>DateTimeMeasureUnit </strong>properties. When using any of the <i>automatic </i>date-time scale modes, the automatically calculated values for these properties can be obtained in the special <strong>ChartControl</strong>.<strong>DateTimeMeasurementUnitsCalculated </strong>(<strong>WebChartControl</strong>.<strong>DateTimeMeasurementUnitsCalculated</strong>) event. For details on this, refer to <a data-ticket="E1529">How to obtain values calculated for automatic axis date-time scale modes</a>. For general information, refer to <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument6247"><u>Date-Time Data Representation</u></a>Date-Time Data Representation.</p><br />
<p>Since these modes belong to an axis, you should cast your diagram object to an appropriate diagram type, to access them at runtime.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-use-automatic-date-time-scale-modes-of-an-axis-e1531&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-use-automatic-date-time-scale-modes-of-an-axis-e1531&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
