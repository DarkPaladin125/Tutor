// Author: Sady Sell Neto
// Copyright (C) 2016

#include <iostream>
#include <string>
#include <exception>
#include <stdexcept>
using namespace std;

int main() {

    // C++ is a case-sensitive language. X is different from x.

    // In C++, variables are declared like in C.
    // They can be unassigned or assigned right away.
    //   However, not assigning a variable may be a bad practice.
    //   Some compilers, depending on their flags, might treat them as errors.
    int var = 5;
    cout << var << endl;

    // In C++, constants are declared like in C.
    // They must be assigned right away.
    const int ten = 10;
    cout << ten << endl;

    // C++ basic data types:

    // Integral types will always have an "int" keyword.
    // Signedness is controlled by "signed" (default) and "unsigned" modifier
    //   keywords.
    // Its range is controlled by: "short" (half) and "long" (double) modifier
    //   keywords.
    // It its possible to combine de "long" modifier twice.
    // When using any of the above modifiers, you can omit the "int" keyword.
    // Examples:
    int _int1 = 0;
    cout << _int1 << endl;

    unsigned long _int2 = 1uL;
    cout << _int2 << endl;

    short _int3 = 2;
    cout << _int3 << endl;

    // C++ also introduces the "bool" integral type:
    // (You have to insert the "boolalpha" manipulator for ostream objects
    //   if they are to print "true" and "false"; otherwise, they will print
    //   "1" and "0").
    bool _bool = true;
    cout << boolalpha << _bool << endl;

    // For single-byte data types, use "char". The "char" type in C++ is
    //   actually an int, as are character literals.
    // To display a char as an integer in ostream objects, append a plus sign
    //    before the variable's name (for instance, +var).
    char _sbyte = 3;
    cout << +_sbyte << endl;

    unsigned char _byte = 4u;
    cout << +_byte << endl;

    // C++ has "float" and "double" for floating-point types.
    // It also has "long double" for even extended range and precision,
    //   however, operations involving long double expressions are very slow.
    double _double = 0.5;
    cout << _double << endl;

    float _float = 0.05f;
    cout << _float << endl;

    // C++ has "char" type (actually an int) to character type:
    char _char = 'a';
    cout << _char << endl;

    // Placing "#include <string>", you can use the "string" type.
    // It must be qualified as std::string. You can avoid that by using
    //   "using namespace std;" statement.
    // Otherwise, it has to be a pointer to (includes an array of) char.
    string _string = "abc";
    cout << _string << endl;

    const char* _string2 = "def";
    cout << _string2 << endl;

    // C++17 will have support to nullable types by using the 
    //   "std::optional" class. Boost framwework already has this support.

    // C++ has pointers:
    int* _ptr1 = &var;
    cout << _ptr1 << endl;

    // Pointers to void are pointers that can point to anything, including
    //   other pointers:
    void* _ptr2 = &_ptr1;
    cout << _ptr2 << endl;

    // "nullptr" is a C++11 constant that replaces C's stdlib's NULL.
    void* _ptr3 = nullptr;
    cout << _ptr3 << endl;

    // C++11 onwards allows type inference using the "auto" keyword:
    auto _inference = 100;
    cout << _inference << endl;

    // C++11 onwards also allows "decltype" keyword on an identifier.
    //   It evaluates to the identifer's type.
    decltype(_inference) _decltype = 200;
    cout << _decltype << endl;

    // Type conversions:

    // C++ maintains C-like cast:
    double _cast = 300.5;
    cout << (int)_cast << endl;

    // And intrdouces functional cast:
    cout << int(_cast) << endl;

    // For further casting, there are four operators:

    exception _dnyamic_cast1("Dynamic cast example 1");
    out_of_range _dyamic_cast2("Dynamic cast example 2");

    // dynamic_cast: perform safe casting between pointers, returning nullptr
    //   if the cast isn't possible.
    cout << (dynamic_cast<exception*>(&_dyamic_cast2) != nullptr ? "Sucess" : "Failure") << endl;
    cout << (dynamic_cast<out_of_range*>(&_dnyamic_cast1) != nullptr ? "Sucess" : "Failure") << endl;

    // static_cast: perform coversion between types without checking safety.
    //   Unsucessful conversion can lead to undefined behavior.
    // Use like dynamic_cast (except it doesn't need to be between pointers).

    // reinterpret_cast: perform binary copy between operands, disregarding type.
    //   Unsucessful conversion can lead to undefined behavior.
    // Use like dynamic_cast (except it doesn't need to be between pointers).

    // const_cast: adds or removes const to operand. Const operands turned into
    //   non-const because of the cast will cause undefined behavior if
    //   modified.
    cout << const_cast<char*>(_string2) << endl;

    return 0;

}
