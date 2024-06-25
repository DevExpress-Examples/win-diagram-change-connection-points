<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/583004106/22.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1136806)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# DiagramControl for WinForms - Change a Shape's Connection Points at Runtime

This example modifies a shape's [ConnectionPoints](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramItem.ConnectionPoints) collection at runtime. To illustrate this behavior, we added a trackbar that changes the number and position of connection points.

![image](https://user-images.githubusercontent.com/65009440/210053843-0fd57843-b601-4bd5-b7af-e9938c66a2f0.png)

The `ConnectionPoints` collection does not have public members that allow you to add or remove items. To accomplish this task, create a new point collection and assign it to the [ConnectionPoints](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramItem.ConnectionPoints) property:

```cs
PointFloat[] points = new PointFloat[...];
shape.ConnectionPoints = new DevExpress.Diagram.Core.DiagramPointCollection(points);
```

## Files to Review

- [Form1.cs](/CS/Form1.cs) (VB: [Form1.vb](/VB/Form1.vb))

## Documentation

- [Connectors](https://docs.devexpress.com/WindowsForms/116884/controls-and-libraries/diagrams/diagram-items/connectors)
- [DiagramItem.ConnectionPoints](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramItem.ConnectionPoints)

## More Examples

- [Diagram Control for WinForms - Create Custom Shapes with Connection Points](https://github.com/DevExpress-Examples/winforms-diagram-create-custom-shapes-with-connection-points)
- [Diagram Control for WinForms - Create Custom Shapes with Connection Points in XAML](https://github.com/DevExpress-Examples/diagramcontrol-how-to-create-custom-shapes-with-connection-points-using-xaml-markup-t381372)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=win-diagram-change-connection-points&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=win-diagram-change-connection-points&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
