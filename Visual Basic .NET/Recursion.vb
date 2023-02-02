Imports System
Module Program
    Sub Main()
        Console.WriteLine("FACTORIAL:")
        Console.WriteLine(FACTORIAL(5))
        Console.WriteLine("")
        Console.WriteLine("EXPONENTS:")
        Console.WriteLine(EXPONENTS(5, 3))
        Console.WriteLine("")
        Console.WriteLine("PRINT_NAME:")
        PRINT_NAME("Alvi", 5)
        Console.WriteLine("")
        Dim array() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        Console.WriteLine("PRINT_ARRAY:")
        PRINT_ARRAY(array, 0)
        Console.WriteLine("")
        Console.WriteLine("PRINT_REVERSE_ARRAY:")
        PRINT_REVERSE_ARRAY(array, LBound(array))
        Console.WriteLine("")
        Console.WriteLine("ADD_UP_THE_ARRAY:")
        ADD_UP_THE_ARRAY(array, 0)
        Console.WriteLine("")
        Console.WriteLine("DENARY_TO_BINARY:")
        DENARY_TO_BINARY(29)
    End Sub
    Function FACTORIAL(ByVal n As Integer)
        If n = 0 Then
            Return 1
        Else
            Return n * FACTORIAL(n - 1)
        End If
    End Function
    Function EXPONENTS(ByVal base As Integer, ByVal power As Integer)
        If power = 0 Then
            Return 1
        Else
            Return base * EXPONENTS(base, power - 1)
        End If
    End Function
    Sub PRINT_NAME(ByVal name As String, ByVal repeats As Integer)
        If repeats = 0 Then
            Return
        Else
            Console.WriteLine(name)
            PRINT_NAME(name, repeats - 1)
        End If
    End Sub
    Sub PRINT_ARRAY(ByVal array As Array, ByVal index As Integer)
        If index = array.Length Then
            Return
        Else
            Console.WriteLine(array(index))
            PRINT_ARRAY(array, index + 1)
        End If
    End Sub
    Sub PRINT_REVERSE_ARRAY(ByVal array As Array, ByVal index As Integer)
        If index = array.Length Then
            Return
        Else
            PRINT_REVERSE_ARRAY(array, index + 1)
            Console.WriteLine(array(index))
        End If
    End Sub
    Dim sum As Integer
    Sub ADD_UP_THE_ARRAY(ByVal array As Array, ByVal index As Integer)
        If index = array.Length Then
            Console.WriteLine(sum)
            Return
        Else
            sum += array(index)
            ADD_UP_THE_ARRAY(array, index + 1)
        End If
    End Sub
    Sub DENARY_TO_BINARY(ByVal number As Integer)
        If number = 0 Then
            Return
        Else
            DENARY_TO_BINARY(number \ 2)
            Console.WriteLine(number Mod 2)
        End If
    End Sub
End Module