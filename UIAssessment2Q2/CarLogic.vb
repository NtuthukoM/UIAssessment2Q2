Imports System.Text

Public Class CarLogic
    Private _contactName As String
    Public Property ContactName() As String
        Get
            Return _contactName
        End Get
        Set(ByVal value As String)
            _contactName = value
        End Set
    End Property

    Private _contactNumber As String
    Public Property ContactNumber() As String
        Get
            Return _contactNumber
        End Get
        Set(ByVal value As String)
            _contactNumber = value
        End Set
    End Property

    Private _makeModel As String
    Public Property MakeModel() As String
        Get
            Return _makeModel
        End Get
        Set(ByVal value As String)
            _makeModel = value
        End Set
    End Property

    Private _province As String
    Public Property Province() As String
        Get
            Return _province
        End Get
        Set(ByVal value As String)
            _province = value
        End Set
    End Property

    Private _Year As String
    Public Property Year() As String
        Get
            Return _Year
        End Get
        Set(ByVal value As String)
            _Year = value
        End Set
    End Property

    Public Function CheckForNumeric(contactNumber As String) As Boolean
        Dim i As Integer
        Dim thisChar As Char
        Dim asciiValue As Integer
        Dim isValid As Boolean
        isValid = True
        For i = 0 To Len(contactNumber) - 1
            thisChar = contactNumber.Chars(i)
            asciiValue = Convert.ToByte(thisChar)
            If asciiValue < 48 Then isValid = False
            If asciiValue > 57 Then isValid = False
        Next i
        If isValid Then
            Return True
        Else
            Return False
        End If
        Throw New NotImplementedException()
    End Function

    Public Function DisplayChoice() As String
        Dim choice = New StringBuilder()
        choice.Append(MakeModel + ",")
        If Not String.IsNullOrEmpty(Province) Then
            choice.Append(Province + ",")
        End If
        If Not String.IsNullOrEmpty(Year) Then
            choice.Append(Year)
        End If
        Return choice.ToString()
    End Function

End Class
