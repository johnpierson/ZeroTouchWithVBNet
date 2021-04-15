Imports Autodesk.DesignScript.Runtime
Imports Point = Autodesk.DesignScript.Geometry.Point


Public Module VbNodes
    Public Function CreatePoint(Optional x As Double = 0, Optional y As Double = 0, Optional z As Double = 0)
        ' Return
        Dim newPoint As Point = Nothing
        newPoint = Point.ByCoordinates(x,y,z)
        Return newPoint
    End Function

    <MultiReturn({"x", "y", "z"})>
    Public Function DesconstructPoint(point As Point)
        ' Step 1: create a Dictionary.
        Dim dictionary As New Dictionary(Of String, Double)

        dictionary.Add("x",point.X)
        dictionary.Add("y",point.Y)
        dictionary.Add("z",point.Z)

        Return dictionary
    End Function

End Module
