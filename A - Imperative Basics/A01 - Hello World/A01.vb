' Author: Sady Sell Neto
' Copyright (C) 2016

Imports System

' This is a VB.NET line comment.
REM This is also a VB.NET line comment.
' VB.NET has no block comment.

' Entry point in VB.NET: Main method.
' It can have any access modifier and belong to a Class or a Structure or a
'   Module. It must be Shared (Module members are automatically Shared).
' Valid signatures:
' Sub Main()
' Sub Main(args As String())
' Function Main() As Integer
' Function Main(args As String()) As Integer

' If you use the args parameter, you will be able to access command line
'   options. Also, by using a Function instead of a Sub, you can return an exit
'   code.

Class Program

    Public Shared Sub Main()

        Console.WriteLine("Hello, world!")

    End Sub

End Class
