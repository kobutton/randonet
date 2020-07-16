Imports System.Net
Imports System.Web.Http

Public Class RandomController
    Inherits ApiController

    ' GET api/values
    ''' <summary>
    ''' A random number (between 1 - 500) of random numbers 
    ''' </summary>
    ''' <returns>An Array of Random Numbers</returns>
    Public Function GetValues() As IEnumerable(Of Int32)
        Dim retList As List(Of Int32) = New List(Of Int32)
        For i = 0 To Int(500 * Rnd()) - 1 Step 1
            retList.Add(Int(1000000 * Rnd()))
        Next

        Return retList.AsEnumerable()
        ' Return New Int32() {Int(1000000 * Rnd())}
    End Function

    ' GET api/values/5
    ''' <summary>
    ''' Returns specified number of random numbers
    ''' </summary>
    ''' <param name="id">Number of random numbers to return.</param>
    ''' <returns>The Specified number of random numbers</returns>
    Public Function GetValue(ByVal id As Integer) As IEnumerable(Of Int32)
        Dim retList As List(Of Int32) = New List(Of Int32)
        For i = 0 To Int(id) - 1 Step 1
            retList.Add(Int(1000000 * Rnd()))
        Next

        Return retList.AsEnumerable()
    End Function

    ' POST api/values
    ''' <summary>
    ''' Does Nothing. It will probably stay this way.
    ''' </summary>
    ''' <param name="value"></param>
    Public Sub PostValue(<FromBody()> ByVal value As Int32)


    End Sub

    ' PUT api/values/5
    ''' <summary>
    ''' Does Nothing. Because you cant put a random string at a random number. Actually, lets make this a TODO. I'd like to break the world. 
    ''' </summary>
    ''' <param name="id">Hmmm. Maybe later?</param>
    ''' <param name="value">You Wish</param>
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/values/5
    ''' <summary>
    ''' Does Nothing. Because I don't want to know what would happen if you deleted a random number; that doesn't sound good. 
    ''' </summary>
    ''' <param name="id">HAHA</param>
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
