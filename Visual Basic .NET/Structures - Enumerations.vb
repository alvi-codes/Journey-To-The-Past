Imports System
Module Program

    Enum SUBJECTS
        Computing = 9608
        English = 1123
        Bangla = 1971
    End Enum

    Sub Main()

        Console.WriteLine("Enter the subject code of your choice:")
        Dim input As Integer = Console.ReadLine

        Dim ChoosenSubject As SUBJECTS
        ChoosenSubject = CType(input, SUBJECTS)

        If ChoosenSubject = SUBJECTS.Bangla Then
            Console.WriteLine("You subject is BANGLA")
        ElseIf ChoosenSubject = SUBJECTS.Computing Then
            Console.WriteLine("Your subject is COMPUTING")
        ElseIf ChoosenSubject = SUBJECTS.English Then
            Console.WriteLine("Your subject is ENGLISH")
        End If

    End Sub

End Module
