' Author: Sady Sell Neto
' Copyright(C) 2016

Imports System

Module Program
    Public Sub Main()

        ' VB.NET is a case-insensitive language. X and x are the same.

        ' VB.NET variables can be unassigned or assigned right away.
        ' If unassigned, they have the same value as if assigned by C#'s
        '   default operator.
        ' This is a VB.NET variable declaration:
        Dim var As Integer = 5
        Console.WriteLine(var)

        Dim dvar As Integer
        Console.WriteLine(dvar)

        ' Constants must be assigned right away.
        ' This is a VB.NET constant declaration:
        Const ten As Integer = 10
        Console.WriteLine(ten)

        ' VB.NET's (acutally .NET framework's) type system:
        ' There are two kinds of types:
        ' Value types are basic data types. Assigning one variable to another
        '   does copy the value to the other. Chaning the other has no impact
        '   on the original.
        '   Default value for these types is zero.
        ' Reference types act like pointers. Assinging one variable to another
        '   will only make them reference the same region. Therefore, changiing
        '   one of them will also change the other.
        '   Default values for these types is Nothing.
        ' Both of them are objects and have methods.

        ' VB.NET basic types:

        ' SByte (System.SByte), 1-byte signed integer:
        Dim _sbyte As SByte = 1
        Console.WriteLine(_sbyte)

        ' Byte (System.Byte), 1-byte unsigned integer:
        Dim _byte As Byte = 2
        Console.WriteLine(_byte)

        ' Short (System.Int16), 2-byte signed integer:
        Dim _short As Short = 3
        Console.WriteLine(_short)

        ' UShort (System.UInt16), 2-byte unsigned integer:
        Dim _ushort As UShort = 4
        Console.WriteLine(_ushort)

        ' Integer (System.Int32), 4-byte signed integer:
        Dim _integer As Integer = 5
        Console.WriteLine(_integer)

        ' UInteger (System.UInt32), 4-byte unsigned integer:
        Dim _uinteger As UInteger = 6UI
        Console.WriteLine(_uinteger)

        ' Long (System.Int64), 8-byte signed integer:
        Dim _long As Long = 7L
        Console.WriteLine(_long)

        ' ULong (System.UInt64), 8-byte unsigned integer:
        Dim _ulong As ULong = 8UL
        Console.WriteLine(_ulong)

        ' Boolean (System.Boolean), 1-byte True or False value:
        Dim _boolean As Boolean = True
        Console.WriteLine(_boolean)

        ' Single (System.Single), single-precision floating-point type:
        Dim _single As Single = 0.9F
        Console.WriteLine(_single)

        ' Double (System.Double), double-precision floating-point type:
        Dim _double As Double = 0.01
        Console.WriteLine(_double)

        ' Decimal (System.Decimal), floating-point type focusing on decimal
        '   part:
        Dim _decimal As Decimal = 0.02D
        Console.WriteLine(_decimal)

        ' Char (System.Char), unicode character:
        Dim _char As Char = "a"c
        Console.WriteLine(_char)

        ' String (System.String), unicode string (reference type):
        Dim _string As String = "abc"
        Console.WriteLine(_string)

        ' Object (System.Object), any object (reference type):
        Dim _object As Object = New Object()
        Console.WriteLine(_object)

        ' Null reference:
        Dim _null As Object = Nothing
        Console.WriteLine(_null)

        ' Nullable types
        ' Nullable types are types that can have the Nothing value assigned.
        ' All reference types are nullable.
        ' Value types can be turned into nullable appending a "?" after their
        '   type or identifier. (T? Is an alias to System.Nullable(Of T))
        Dim _nullable As Integer? = 100 ' Or Dim _nullable? As Integer = 100
        Console.WriteLine(_nullable)

        _nullable = Nothing
        Console.WriteLine(_nullable)

        ' VB.NET has poor support for pointer types.

        ' One can achieve type by omitting the type:
        Dim _inference = 200

        ' One can achieve dynamic types by using "Option Strict Off".
        ' Will not be covered.

        ' Type conversions:
        ' VB.NET has function-like operators for conversions. The easiest is
        '   "CType".
        Dim _cast As Double = 300.5
        Console.WriteLine(CType(_cast, Integer))

        ' CType has a lot of aliases:
        ' CBool(x) = CType(x, Boolean)
        ' CByte(x) = CType(x, Byte)
        ' CChar(x) = CType(x, Char)
        ' CDate(x) = CType(x, Date)
        ' CDbl(x) = CType(x, Double)
        ' CDec(x) = CType(x, Decimal)
        ' CInt(x) = CType(x, Integer)
        ' CLng(x) = CType(x, Long)
        ' CObj(x) = CType(x, Object)
        ' CSByte(x) = CType(x, SByte)
        ' CShort(x) = CType(x, Short)
        ' CSng(x) = CType(x, Single)
        ' CStr(x) = CType(x, String)
        ' CUInt(x) = CType(x, UInteger)
        ' CULng(x) = CType(x, ULong)
        ' CUShort(x) = CType(x, Short)

        ' For safe conversion between nullable types, use the "TryCast"
        '   Operator, that is very smiliar to the "CType" operator.

        Dim _as1 As New Object()
        Dim _as2 As String = "ghi"

        Console.WriteLine(If(TryCast(_as2, Object) IsNot Nothing, "Success", "Failure"))
        Console.WriteLine(If(TryCast(_as1, String) IsNot Nothing, "Success", "Failure"))

    End Sub
End Module
