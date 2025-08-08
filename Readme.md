<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575848/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1531)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Charts for WinForms - Date-Time Scale Modes of an Axis

This example demonstrates how to control and optimize the appearance of date‑time [axes](https://docs.devexpress.com/WindowsForms/5799/controls-and-libraries/chart-control/axes/axis-scale-types) in WinForms charts, particularly focused on managing data aggregation and scale presentation.

The application displays combo boxes that allow you to change **date-time scale modes** of an [axis](https://docs.devexpress.com/WindowsForms/5799/controls-and-libraries/chart-control/axes/axis-scale-types).

![Chart - Date-Time-intervals](chart-date-time-intervals.png)

When the [ScaleOptionsBase.ScaleMode](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ScaleOptionsBase.ScaleMode) property is set to `Manual`, you define the [DateTimeScaleOptions.GridAlignment](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.DateTimeScaleOptions.GridAlignment), [DateTimeScaleOptions.MeasureUnit](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.DateTimeScaleOptions.MeasureUnit), and [ScaleGridOptionsBase.AggregateFunction](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ScaleGridOptionsBase.AggregateFunction) properties.

When the [ScaleOptionsBase.ScaleMode](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ScaleOptionsBase.ScaleMode) property is set to `Automatic`, a chart uses automatic date-time scale mode and the appropriate [ScaleGridOptionsBase.AggregateFunction](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ScaleGridOptionsBase.AggregateFunction).

The date-time scale on the X-axis applies data aggregation automatically in `Manual` and `Automatic` modes. If you wish not to divide axis scale into intervals and do not apply aggregation to chart data, set the [ScaleOptionsBase.ScaleMode](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ScaleOptionsBase.ScaleMode) property to `Continuous`.

## Files to Review

* [Form1.cs](./CS/DateTimeAggregation/Form1.cs) (VB: [Form1.vb](./VB/DateTimeAggregation/Form1.vb))

## Documentation

- [Axis Scale Types](https://docs.devexpress.com/WindowsForms/5799/controls-and-libraries/chart-control/axes/axis-scale-types)
- [Data Aggregation](https://docs.devexpress.com/WindowsForms/6247/controls-and-libraries/chart-control/data-representation/data-aggregation)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-charts-use-automatic-date-time-scale-modes-of-an-axis&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-charts-use-automatic-date-time-scale-modes-of-an-axis&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
