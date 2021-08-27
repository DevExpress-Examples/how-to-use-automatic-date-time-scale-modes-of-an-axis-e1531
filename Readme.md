<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575848/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1531)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DateTimeAggregation/Form1.cs) (VB: [Form1.vb](./VB/DateTimeAggregation/Form1.vb))
<!-- default file list end -->
# How to use automatic date-time scale modes of an axis


<p>This example demonstrates how to use <strong>date-time scale modes</strong> of an <a href="http://devexpress.com/Help/Content.aspx?help=XtraCharts&document=CustomDocument6016.htm"><u>axis</u></a> (both manual and automatic).</p>


<h3>Description</h3>

<p>The data aggregation is enabled automatically for the date-time scale on the X-axis in both manual (default mode) and automatic scale modes.</p>
<p>When the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsScaleOptionsBase_ScaleModetopic"><u>ScaleOptionsBase.ScaleMode</u></a><u> </u>property is set to<strong> Manual</strong>, you can manually define the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsDateTimeScaleOptions_GridAlignmenttopic"><u>DateTimeScaleOptions.GridAlignment</u></a>, <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsDateTimeScaleOptions_MeasureUnittopic"><u>DateTimeScaleOptions.MeasureUnit</u></a>, and <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsScaleOptionsBase_AggregateFunctiontopic"><u>ScaleOptionsBase.AggregateFunction</u></a> properties.</p>
<p><br /> To use the automatic date-time scale mode, set the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsScaleOptionsBase_ScaleModetopic"><u>ScaleOptionsBase.ScaleMode</u></a> property to <strong>Automatic</strong> and choose the appropriate <strong>ScaleOptionsBase.AggregateFunction</strong>.</p>
<p>If you wish axis scale is not divided into intervals and therefore aggregation cannot be applied to chart data, set the <strong>ScaleOptionsBase.ScaleMode</strong> property to <strong>Continuous</strong>.</p>
<p><br /> For more information on date-time scale modes, refer to <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument6247"><u>Date-Time Data Representation</u></a>.</p>
<p>&nbsp;</p>

<br/>


