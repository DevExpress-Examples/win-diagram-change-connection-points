Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports System

Namespace dxSample

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Private r As Random = New Random()

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub barEditItem1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim editItem = TryCast(sender, BarEditItem)
            Dim value = Convert.ToInt32(editItem.EditValue)
            Dim points As PointFloat() = New PointFloat(value - 1) {}
            For i As Integer = 0 To value - 1
                points(i) = New PointFloat() With {.X = Convert.ToSingle(r.NextDouble()), .Y = If(r.Next(0, 2) = 0, 0, 1)}
            Next

            diagramShape1.ConnectionPoints = New DevExpress.XtraDiagram.PointCollection(points)
        End Sub
    End Class
End Namespace
