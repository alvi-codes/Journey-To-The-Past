Imports System
Module Program
    Dim NULL As Integer = -1
    Public Structure NODE
        Dim Data As Integer
        Dim Left_Pointer As Integer
        Dim Right_Pointer As Integer
    End Structure
    Public Structure TREE
        Dim Array() As NODE
        Dim Root, FLP, Temporary, Current, Previous As Integer
        Sub Initialize(ByVal size As Integer)
            ReDim Array(size - 1)
            For i = 0 To (UBound(Array) - 1)
                Array(i).Data = 0
                Array(i).Left_Pointer = NULL
                Array(i).Right_Pointer = i + 1
            Next
            Array(UBound(Array)).Data = 0
            Array(UBound(Array)).Left_Pointer = NULL
            Array(UBound(Array)).Right_Pointer = NULL
            FLP = 0
            Root = NULL
        End Sub
        Sub Insert(ByVal new_data As Integer)
            If FLP = NULL Then
                Console.WriteLine("The new data could not be added - There is no more free space in the free list")
                Return
            End If
            Temporary = FLP
            FLP = Array(FLP).Right_Pointer
            Array(Temporary).Data = new_data
            Array(Temporary).Left_Pointer = NULL
            Array(Temporary).Right_Pointer = NULL
            If Root = NULL Then
                Root = Temporary
                Return
            End If
            Current = Root
            Previous = NULL
            While Current <> NULL
                If new_data > Array(Current).Data Then
                    Previous = Current
                    Current = Array(Current).Right_Pointer
                Else
                    Previous = Current
                    Current = Array(Current).Left_Pointer
                End If
            End While
            If new_data > Array(Previous).Data Then
                Array(Previous).Right_Pointer = Temporary
            Else
                Array(Previous).Left_Pointer = Temporary
            End If
        End Sub
        Sub Descending_Order_Print(ByVal pointer As Integer) 'Reversing the LMR(ascending order) print logic to print all datas in descending order
            If pointer <> NULL Then
                Descending_Order_Print(Array(pointer).Right_Pointer)
                Console.WriteLine(Array(pointer).Data)
                Descending_Order_Print(Array(pointer).Left_Pointer)
            End If
        End Sub
        Sub Print_LMR(ByVal Current As Integer)
            If Current <> NULL Then
                Print_LMR(Array(Current).Left_Pointer)
                Console.WriteLine(Array(Current).Data)
                Print_LMR(Array(Current).Right_Pointer)
            End If
        End Sub
        Sub Print_LRM(ByVal Current As Integer)
            If Current <> NULL Then
                Print_LRM(Array(Current).Left_Pointer)
                Print_LRM(Array(Current).Right_Pointer)
                Console.WriteLine(Array(Current).Data)
            End If
        End Sub
        Sub Print_MLR(ByVal Current As Integer)
            If Current <> NULL Then
                Console.WriteLine(Array(Current).Data)
                Print_MLR(Array(Current).Left_Pointer)
                Print_MLR(Array(Current).Right_Pointer)
            End If
        End Sub
        Sub Find_Maximum()
            Current = Root
            Previous = NULL
            Do
                Previous = Current
                Current = Array(Current).Right_Pointer
            Loop Until Current = NULL
            Console.WriteLine("The maximum value in the Tree is '{0}' which resides at index '{1}' !", Array(Previous).Data, Previous)
        End Sub
        Sub Recursive_Maximum(ByVal pointer As Integer)
            Dim next_node As Integer = Array(pointer).Right_Pointer
            If next_node = NULL Then
                Console.WriteLine("The maximum value in the Tree is '{0}' which resides at index '{1}' !", Array(pointer).Data, pointer)
                Return
            End If
            Recursive_Maximum(Array(pointer).Right_Pointer)
        End Sub
        Sub Find_Minimum()
            Current = Root
            Previous = NULL
            Do
                Previous = Current
                Current = Array(Current).Left_Pointer
            Loop Until Current = NULL
            Console.WriteLine("The minimum value in the Tree is '{0}' which resides at index '{1}' !", Array(Previous).Data, Previous)
        End Sub
        Sub Recursive_Minimum(ByVal pointer As Integer)
            Dim next_node As Integer = Array(pointer).Left_Pointer
            If next_node = NULL Then
                Console.WriteLine("The minimum value in the Tree is '{0}' which resides at index '{1}' !", Array(pointer).Data, pointer)
                Return
            End If
            Recursive_Minimum(Array(pointer).Left_Pointer)
        End Sub
        Sub Search(ByVal data As String)
            If Root = NULL Then
                Console.WriteLine("Nothing to search for since the tree does not exist !")
                Return
            End If
            Current = Root
            While Current <> NULL
                If Array(Current).Data = data Then
                    Console.WriteLine("The  data '{0}' has been found at index '{1}' of the tree ! ", data, Current)
                    Return
                End If
                If data < Array(Current).Data Then
                    Current = Array(Current).Left_Pointer
                Else
                    Current = Array(Current).Right_Pointer
                End If
            End While
            Console.WriteLine("The data '{0}' does not exist in the tree !", data)
        End Sub
        Sub Mirror_Tree(ByVal pointer As Integer) '***Erroneous Code***' /// Works properly for : 5,43,667,6,4
            If Array(pointer).Right_Pointer = NULL And Array(pointer).Left_Pointer = NULL Then
                Return
            End If
            Mirror_Tree(Array(pointer).Left_Pointer)
            Mirror_Tree(Array(pointer).Right_Pointer)
            Temporary = Array(pointer).Right_Pointer
            Array(pointer).Right_Pointer = Array(pointer).Left_Pointer
            Array(pointer).Left_Pointer = Temporary
        End Sub
    End Structure
    Sub Main()
        Dim command As TREE
        command.Initialize(5)
        Console.WriteLine("Inputs:")
        For i = 0 To 4
            command.Insert(Console.ReadLine())
        Next
        'Console.WriteLine("")
        'Console.WriteLine("Reversing the LMR print logic to print all datas in descending order:")
        'command.Reverse_LMR(command.Root)
        'Console.WriteLine("")
        'Console.WriteLine("Print-LMR:")
        'command.Print_LMR(command.Root)
        'Console.WriteLine("")
        'Console.WriteLine("Print-LRM:")
        'command.Print_LRM(command.Root)
        'Console.WriteLine("")
        'Console.WriteLine("Print-MLR:")
        'command.Print_MLR(command.Root)
        'Console.WriteLine("")
        'Console.WriteLine("Maximum:")
        'command.Find_Maximum()
        'Console.WriteLine("")
        'Console.WriteLine("Maximum by Recursion:")
        'command.Recursive_Maximum(command.Root)
        'Console.WriteLine("")
        'Console.WriteLine("Minimum:")
        'command.Find_Minimum()
        'Console.WriteLine("")
        'Console.WriteLine("Minimum by Recursion:")
        'command.Recursive_Minimum(command.Root)
        'Console.WriteLine("")
        'Console.WriteLine("Searches:")
        'command.Search(99)
        'command.Search(50)
        'command.Search(0)

        Console.WriteLine("")
        command.Print_LMR(command.Root)
        Console.WriteLine("")
        '***Erroneous Code***' /// Works properly for : 5,43,667,6,4
        command.Mirror_tree(command.Root)
        command.Print_LMR(command.Root)
    End Sub
End Module
