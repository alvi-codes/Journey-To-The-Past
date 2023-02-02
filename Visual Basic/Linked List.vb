Imports System
Module Program
    Const NULL = -1
    Sub Main()
        'Dim command As LINKED_LIST
        ''command.INITIALIZE()
        ''command.INSERT()
        ''command.SEARCH()
        ''command.DELETE()
        ''command.PRINT()
        'Dim test As LINKED_LIST
        'test.INITIALIZE(5)
        'test.PRINT()
        'test.INSERT("A")
        'test.INSERT("D")
        'test.INSERT("C")
        'test.INSERT("B")
        'test.INSERT("E")
        '' l.PRINT()
        'Console.WriteLine("")
        'test.REVERSE_THE_LINKED_LIST_USING_RECURSION(test.HEAD)
        'Console.WriteLine("")
        'test.PRINT()
        ''l.reverse_print()
        'Console.WriteLine("")
        'test.RECURSIVELY_REVERSE_PRINT(test.HEAD)
        'Console.WriteLine("")
        'test.DELETE("D")
        'test.REVERSE_THE_LINKED_LIST_USING_RECURSION(test.HEAD)
        'test.PRINT()
    End Sub
    Public Structure NODE
        Dim DATA As String
        Dim PTR As Integer
    End Structure
    Public Structure LINKED_LIST
        Dim HEAD, FLP As Integer
        Dim list() As NODE
        Sub INITIALIZE(ByVal SIZE As Integer)
            ReDim list(SIZE - 1)
            For i = 0 To UBound(list) - 1
                list(i).DATA = ""
                list(i).PTR = i + 1
            Next
            list(UBound(list)).PTR = NULL
            list(UBound(list)).DATA = ""
            FLP = 0
            HEAD = NULL
        End Sub
        Sub INSERT(ByVal NEW_DATA As String)
            If FLP = NULL Then
                Console.WriteLine("The LINKED_LIST has no more empty space !")
                Return
            End If
            Dim TEMPORARY As Integer = FLP
            FLP = list(FLP).PTR
            list(TEMPORARY).PTR = NULL
            list(TEMPORARY).DATA = NEW_DATA
            If HEAD = NULL Then
                HEAD = TEMPORARY
                Return
            End If
            If NEW_DATA < list(HEAD).DATA Then
                list(TEMPORARY).PTR = HEAD
                HEAD = TEMPORARY
                Return
            End If
            Dim CURRENT As Integer = HEAD
            Dim PREVIOUS As Integer = NULL
            Dim FOUND As Boolean = False
            While CURRENT <> NULL And FOUND = False
                If (list(CURRENT).DATA > NEW_DATA) Then
                    FOUND = True
                Else
                    PREVIOUS = CURRENT
                    CURRENT = list(CURRENT).PTR
                End If
            End While
            If CURRENT = NULL Then
                list(PREVIOUS).PTR = TEMPORARY
                list(TEMPORARY).PTR = NULL
            Else
                list(PREVIOUS).PTR = TEMPORARY
                list(TEMPORARY).PTR = CURRENT
            End If
        End Sub
        Sub DELETE(ByVal OLD_DATA As String)
            If HEAD = NULL Then
                Console.WriteLine("*NOTHING TO DELETE* -- The LINKED_LIST is empty !")
                Return
            End If
            Dim CURRENT As Integer = HEAD
            Dim PREVIOUS As Integer = NULL
            Dim FOUND As Boolean = False
            While CURRENT <> NULL And FOUND = False
                If list(CURRENT).DATA = OLD_DATA Then
                    FOUND = True
                Else
                    PREVIOUS = CURRENT
                    CURRENT = list(CURRENT).PTR
                End If
            End While
            If FOUND = False Then
                Console.WriteLine("The data requested to be deleted does not exist in the LINKED_LIST !")
                Return
            End If
            If CURRENT = HEAD Then
                HEAD = list(HEAD).PTR
                list(CURRENT).DATA = ""
                list(CURRENT).PTR = FLP
                FLP = CURRENT
            End If
            If list(CURRENT).PTR = NULL Then
                list(PREVIOUS).PTR = NULL
                list(CURRENT).DATA = ""
                list(CURRENT).PTR = FLP
                FLP = CURRENT
                Return
            End If
            list(PREVIOUS).PTR = list(CURRENT).PTR
            list(CURRENT).DATA = ""
            list(CURRENT).PTR = FLP
            FLP = CURRENT
        End Sub
        Sub SEARCH(ByVal FIND As String)
            Dim Found_Flag As Boolean = False
            For i = 0 To UBound(list)
                If list(i).DATA = FIND Then
                    Console.WriteLine("The data '{0}' resites in index {1} of the Linked List !", FIND, i)
                    Found_Flag = True
                End If
            Next
            If Found_Flag = False Then
                Console.WriteLine("The data '{0}' does not exist in the Linked List !", FIND)
            End If
        End Sub
        Sub PRINT()
            If HEAD = NULL Then
                Console.WriteLine("*NOTHING TO PRINT* -- The LINKED_LIST is empty !")
                Return
            End If
            Dim CURRENT As Integer = HEAD
            While CURRENT <> NULL
                Console.WriteLine(list(CURRENT).DATA)
                CURRENT = list(CURRENT).PTR
            End While
        End Sub
        Sub REVERSE_PRINT()
            Dim reverse(UBound(list)) As String
            Dim current As Integer = HEAD
            If current = NULL Then
                Console.WriteLine("*NOTHING TO PRINT* -- The LINKED_LIST is empty !")
                Exit Sub
            Else
                For i = 0 To UBound(list)
                    reverse(i) = list(current).DATA
                    current = list(current).PTR
                Next
            End If
            For i = UBound(list) To 0 Step -1
                Console.WriteLine(reverse(i))
            Next
        End Sub
        Sub RECURSIVELY_REVERSE_PRINT(ByVal pointer As Integer)
            If pointer = NULL Then
                Return
            End If
            RECURSIVELY_REVERSE_PRINT(list(pointer).PTR)
            Console.WriteLine(list(pointer).DATA)
        End Sub
        Sub REVERSE_THE_LINKED_LIST_USING_RECURSION(ByVal last_node As Integer)
            If list(last_node).PTR = NULL Then
                HEAD = last_node
                Return
            End If
            REVERSE_THE_LINKED_LIST_USING_RECURSION(list(last_node).PTR)
            list(list(last_node).PTR).PTR = last_node
            list(last_node).PTR = NULL
        End Sub
    End Structure
End Module
 