<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575848/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1531)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DateTimeAggregation/Form1.cs) (VB: [Form1.vb](./VB/DateTimeAggregation/Form1.vb))
<!-- default file list end -->
# Charts - How to use automatic date-time scale modes of an axis

This example demonstrates how to use **date-time scale modes** of an [axis](https://docs.devexpress.com/WindowsForms/5799/controls-and-libraries/chart-control/axes/axis-scale-types) (both manual and automatic).

The data aggregation is enabled automatically for the date-time scale on the X-axis in both manual (default mode) and automatic scale modes.

When the [ScaleOptionsBase.ScaleMode](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ScaleOptionsBase.ScaleMode) property is set to `Manual`, you can manually define the [DateTimeScaleOptions.GridAlignment](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.DateTimeScaleOptions.GridAlignment), [DateTimeScaleOptions.MeasureUnit](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.DateTimeScaleOptions.MeasureUnit), and [ScaleGridOptionsBase.AggregateFunction](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ScaleGridOptionsBase.AggregateFunction) properties.

To use the automatic date-time scale mode, set the [ScaleOptionsBase.ScaleMode](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ScaleOptionsBase.ScaleMode) property to `Automatic` and choose the appropriate [ScaleGridOptionsBase.AggregateFunction](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ScaleGridOptionsBase.AggregateFunction).

If you wish axis scale is not divided into intervals and therefore aggregation cannot be applied to chart data, set the [ScaleOptionsBase.ScaleMode](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ScaleOptionsBase.ScaleMode) property to `Continuous`.

## Documentation

- [Axis Scale Types](https://docs.devexpress.com/WindowsForms/5799/controls-and-libraries/chart-control/axes/axis-scale-types)
- [Data Aggregation](https://docs.devexpress.com/WindowsForms/6247/controls-and-libraries/chart-control/data-representation/data-aggregation)

## More Examples

- [How to obtain values calculated for automatic axis date-time scale modes](https://github.com/DevExpress-Examples/how-to-obtain-values-calculated-for-automatic-axis-date-time-scale-modes-e1529)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-use-automatic-date-time-scale-modes-of-an-axis-e1531&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-use-automatic-date-time-scale-modes-of-an-axis-e1531&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
