<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/583004106/22.2.3%2B)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# DiagramControl for WinForms - How to change a shape's connection points at runtime

This example shows how to use the [ConnectionPoints](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDiagram.DiagramItem.ConnectionPoints) property to change the number of a shape's connection points at runtime.

The `ConnectionPoints` collection does not have public members that allow adding or removing items from it. You need to re-initialize it instead:
```cs
PointFloat[] points = new PointFloat[...];
shape.ConnectionPoints = new DevExpress.Diagram.Core.DiagramPointCollection(points);
```

## Files to Review

- [Form1.cs](/CS/Form1.cs) (VB: [Form1.vb](/VB/Form1.vb))

## Documentation

[Connectors](https://docs.devexpress.com/WindowsForms/116884/controls-and-libraries/diagrams/diagram-items/connectors)

## More Examples

[How to: Create Custom Shapes with Connection Points](https://docs.devexpress.com/WindowsForms/118080/controls-and-libraries/diagrams/examples/how-to-create-custom-shapes-with-connection-points)

[How to: Create Custom Shapes with Connection Points Using XAML](https://docs.devexpress.com/WindowsForms/118076/controls-and-libraries/diagrams/examples/how-to-create-custom-shapes-with-connection-points-using-xaml)
