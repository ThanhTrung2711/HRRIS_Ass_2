Option Explicit On
Option Strict On

' Name:        Validation.vb
' Description: Validate data from Customer table
' Author:      Nguyen Thanh Trung
' Date:        17/03/2017
' Subject name: ISYS2116 –Information Systems Solutions and Design
' Semester 1 of 2017
' Tutor: Mr.Ashish Das

Imports System.Text.RegularExpressions
Public Class Validation

    'isNumeric(ByVal strVal As String) is a Public Function (can be accessed from outside of Validation.vb, cannot be accessed from outside if it was declared Private).
    'It accepts a single parameter (strVal) which is defined as a String. Furthermore, this parameter is passed by value meaning that the function receives a copy of the variable and not the actual location of the variable. Thus, any changes that you make to strVal will not be reflected in the actual variable. If you wanted to be able to change the value of the strVal, then you should pass it by reference i.e. ByRef.
    'Finally, since we are dealing with a function here (a function returns a value, while a subroutine does not), we need to specify the type of the return value. This is done by the As Boolean keywords.

    ''' <summary>
    ''' This function will take a string and check if it is numeric or not. Returns false if not numeric.
    ''' </summary>
    ''' <param name="strVal">Value to test</param>
    ''' <returns>False if string is not numeric</returns>
    ''' <remarks>Do not pass array, and string is byval, not ref.</remarks>
    Public Function isNumericVal(ByVal strVal As String) As Boolean

        Try
            ' call inbuild function from dot net to check if value is a number.
            Return IsNumeric(strVal)
        Catch ex As Exception

            ' take no action just print and leave.
            Debug.Print("Error: " & ex.Message)

            Return False
        End Try

    End Function

    ' Ref: http://stackoverflow.com/questions/336210/regular-expression-for-alphanumeric-and-underscores

    ''' <summary>
    ''' This function will take a string and check if it consists of or using both letters and numerals.
    ''' </summary>
    ''' <param name="strVal">Value to test</param>
    ''' <returns>False if string contains symbols</returns>
    ''' <remarks>Do not pass array, and string is byval, not ref.</remarks>
    Public Function isAlphaNumericVal(ByVal strVal As String) As Boolean

        Dim pattern As Regex = New Regex("^[a-zA-Z0-9 _]*$")

        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' This function will take a string and check if it is an Email or not. Returns false if not a proper Email.
    ''' </summary>
    ''' <param name="strVal">Value to test </param>
    ''' <returns>False if the string is not a proper email </returns>
    ''' <remarks>Do not pass array, and string is byval, not ref.</remarks>

    Public Function isEmailVal(ByVal strVal As String) As Boolean

        Dim pattern As Regex = New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function

    Public Function isNameVal(ByVal strVal As String) As Boolean

        Dim pattern As Regex = New Regex("^[a-zA-Z ]*$")

        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function

    Public Function isAddressVal(ByVal strVal As String) As Boolean

        Dim pattern As Regex = New Regex("^[a-zA-Z0-9 _,.]*$")

        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function

    Public Function isPhoneVal(ByVal strVal As String) As Boolean

        Dim pattern As Regex = New Regex("^[0]+[0-9]*$")

        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function
    Public Function isNumGuestVal(ByVal strVal As String) As Boolean

        Dim pattern As Regex = New Regex("^[1-3]*$")

        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function
    Public Function isTypeVal(ByVal txttype As String) As Boolean

        If txttype = "Luxury" Or txttype = "Economy" Or txttype = "Family" Or txttype = "Single" Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
