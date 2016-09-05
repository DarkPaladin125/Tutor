// Author: Sady Sell Neto
// Copyright(C) 2016

using System;

static class Program {
    public static void Main() {

        // C# is a case-sensitive language. X is different from x.

        // In C#, variables are declared like in C.
        // They must be assigned right away.
        // You can use the default operator to assign the default value for
        //   a given type (usually used with generic types).
        int var = 5;
        Console.WriteLine(var);

        int dvar = default(int);
        Console.WriteLine(dvar);

        // In C#, constants are declared like in C.
        // They must be assigned right away.
        const int ten = 10;
        Console.WriteLine(ten);

        // C#'s (acutally .NET framework's) type system:
        // There are two kinds of types:
        // Value types are basic data types. Assigning one variable to another
        //   does copy the value to the other. Chaning the other has no impact
        //   on the original.
        //   Default value for these types is zero.
        // Reference types act like pointers. Assinging one variable to another
        //   will only make them reference the same region. Therefore, changiing
        //   one of them will also change the other.
        //   Default values for these types is null.
        // Both of them are objects and have methods.

        // C# basic types:

        // sbyte (System.SByte), 1-byte signed integer:
        sbyte _sbyte = 1;
        Console.WriteLine(_sbyte);

        // byte (System.Byte), 1-byte unsigned integer:
        byte _byte = 2;
        Console.WriteLine(_byte);

        // short (System.Int16), 2-byte signed integer:
        short _short = 3;
        Console.WriteLine(_short);

        // ushort (System.UInt16), 2-byte unsigned integer:
        ushort _ushort = 4;
        Console.WriteLine(_ushort);

        // int (System.Int32), 4-byte signed integer:
        int _int = 5;
        Console.WriteLine(_int);

        // uint (System.UInt32), 4-byte unsigned integer:
        uint _uint = 6u;
        Console.WriteLine(_uint);

        // long (System.Int64), 8-byte signed integer:
        long _long = 7L;
        Console.WriteLine(_long);

        // ulong (System.UInt64), 8-byte unsigned integer:
        ulong _ulong = 8uL;
        Console.WriteLine(_ulong);

        // bool (System.Boolean), 1-byte true or false value:
        bool _bool = true;
        Console.WriteLine(_bool);

        // float (System.Single), single-precision floating-point type:
        float _float = 0.9f;
        Console.WriteLine(_float);

        // double (System.Double), double-precision floating-point type:
        double _double = 0.01;
        Console.WriteLine(_double);

        // decimal (System.Decimal), floating-point type focusing on decimal
        //   part:
        decimal _decimal = 0.02m;
        Console.WriteLine(_decimal);

        // char (System.Char), unicode character:
        char _char = 'a';
        Console.WriteLine(_char);

        // string (System.String), unicode string (reference type):
        string _string = "abc";
        Console.WriteLine(_string);

        // object (System.Object), any object (reference type):
        object _object = new object();
        Console.WriteLine(_object);

        // Null reference:
        object _null = null;
        Console.WriteLine(_null);

        // Nullable types:
        // Nullable types are types that can have the null value assigned.
        // All reference types are nullable.
        // Value types can be turned into nullable appending a "?" after their
        //   type. (T? is an alias to System.Nullable<T>)
        int? _nullable = 100;
        Console.WriteLine(_nullable);

        _nullable = null;
        Console.WriteLine(_nullable);

        // C# has pointer types, but they will not be covered.

        // Type inference with the "var" keyword:
        var _inference = 200;
        Console.WriteLine(_inference);

        // Dynamic variables with the "dynamic" keyowrd (C#6):
        dynamic _dynamic = 300;
        _dynamic = "def";
        Console.WriteLine(_dynamic);

        // Type conversions:

        // C# maintains C-like cast:
        double _cast = 300.5;
        Console.WriteLine((int)_cast);

        // And introduces the "as" operator for safe casts between nullable
        //   types:
        object _as1 = new object();
        string _as2 = "ghi";

        Console.WriteLine(_as2 as object != null ? "Success" : "Failure");
        Console.WriteLine(_as1 as string != null ? "Success" : "Failure");

    }
}
