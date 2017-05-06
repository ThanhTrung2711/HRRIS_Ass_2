Option Explicit On
Option Strict On

' Name:        UnitTest1.vb
' Description: Class for testing Validation class
' Author:      Nguyen Thanh Trung
' Date:        04/05/2017
' Subject name: ISYS2116 –Information Systems Solutions and Design
' Semester 1 of 2017
' Tutor: Mr.Ashish Das


Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports customer.Validation


<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestIsNumericVal_01()
        Dim oValidation As New customer.Validation
        Dim sNumeric = "drrt"
        Assert.AreEqual(False, oValidation.isNumericVal(sNumeric))

    End Sub

    <TestMethod()> Public Sub TestIsNumericVal_02()
        Dim oValidation As New customer.Validation
        Dim sNumeric = "1456461"
        Assert.AreEqual(True, oValidation.isNumericVal(sNumeric))

    End Sub
    <TestMethod()> Public Sub TestisAlphaNumericVal_01()
        Dim oValidation As New customer.Validation
        Dim sAlphaNumeric = "drrt@.,"
        Assert.AreEqual(False, oValidation.isAlphaNumericVal(sAlphaNumeric))

    End Sub
    <TestMethod()> Public Sub TestisAlphaNumericVal_02()
        Dim oValidation As New customer.Validation
        Dim sAlphaNumeric = "drrt123"
        Assert.AreEqual(True, oValidation.isAlphaNumericVal(sAlphaNumeric))
    End Sub
    <TestMethod()> Public Sub TestisEmailVal_01()
        Dim oValidation As New customer.Validation
        Dim sEmail = "drrt@.,"
        Assert.AreEqual(False, oValidation.isEmailVal(sEmail))

    End Sub
    <TestMethod()> Public Sub TestisEmailVal_02()
        Dim oValidation As New customer.Validation
        Dim sEmail = "s3532890@rmit.edu.vn"
        Assert.AreEqual(True, oValidation.isEmailVal(sEmail))

    End Sub
    <TestMethod()> Public Sub TestisNameVal_01()
        Dim oValidation As New customer.Validation
        Dim sName = "Nguyen."
        Assert.AreEqual(False, oValidation.isNameVal(sName))

    End Sub
    <TestMethod()> Public Sub TestisNameVal_02()
        Dim oValidation As New customer.Validation
        Dim sName = "Trung"
        Assert.AreEqual(True, oValidation.isNameVal(sName))

    End Sub
    <TestMethod()> Public Sub TestisAddressVal_01()
        Dim oValidation As New customer.Validation
        Dim sAddress = "438 Lac Long Quan"
        Assert.AreEqual(True, oValidation.isAddressVal(sAddress))

    End Sub
    <TestMethod()> Public Sub TestisPhoneVal_01()
        Dim oValidation As New customer.Validation
        Dim sPhone = "0902771741"
        Assert.AreEqual(True, oValidation.isPhoneVal(sPhone))

    End Sub
    <TestMethod()> Public Sub TestiNumGuestVal_01()
        Dim oValidation As New customer.Validation
        Dim sNumGuest = "1"
        Assert.AreEqual(True, oValidation.isNumGuestVal(sNumGuest))

    End Sub
    <TestMethod()> Public Sub TestisTypeVal_01()
        Dim oValidation As New customer.Validation
        Dim sType = "Luxury"
        Assert.AreEqual(True, oValidation.isTypeVal(sType))

    End Sub
    <TestMethod()> Public Sub TestisTypeVal_02()
        Dim oValidation As New customer.Validation
        Dim sType = "Cheap"
        Assert.AreEqual(False, oValidation.isTypeVal(sType))

    End Sub


End Class