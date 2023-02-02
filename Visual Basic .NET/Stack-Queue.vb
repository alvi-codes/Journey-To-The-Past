Imports System
Module Program
    Dim NULL As Integer = -1
    Public Structure NODE
        Dim Data As String
        Dim Pointer As String
    End Structure
    Public Structure STACK
        Dim Top, FLP, Temporary As Integer
        Dim Stack_Array() As NODE
        Sub Initialize(ByVal size As Integer)
            ReDim Stack_Array(size - 1)
            For i = 0 To UBound(Stack_Array) - 1
                Stack_Array(i).Data = ""
                Stack_Array(i).Pointer = i + 1
            Next
            FLP = 0
            Top = NULL
            Stack_Array(UBound(Stack_Array)).Pointer = NULL
            Stack_Array(UBound(Stack_Array)).Data = ""
        End Sub
        Sub Push(ByVal data As String)
            If FLP = NULL Then
                Console.WriteLine("The new data '" & data & "' could not be added since the stack is full !")
                Return
            End If
            Temporary = FLP
            FLP = Stack_Array(FLP).Pointer
            Stack_Array(Temporary).Data = data
            Stack_Array(Temporary).Pointer = Top
            Top = Temporary
        End Sub
        Sub Pop()
            If Top = NULL Then
                Console.WriteLine("There is nothing to pop since the stack is empty !")
                Return
            End If
            Console.WriteLine("The top data '{0}' has been popped out of the stack !", Stack_Array(Top).Data)
            Temporary = Top
            Top = Stack_Array(Top).Pointer
            Stack_Array(Temporary).Data = ""
            Stack_Array(Temporary).Pointer = FLP
            FLP = Temporary
        End Sub
        Sub Peek()
            If Top = NULL Then
                Console.WriteLine("It's an empty stack !")
                Return
            End If
            Console.WriteLine(Stack_Array(Top).Data)
        End Sub
        Sub Print()
            If Top = NULL Then
                Console.WriteLine("The Stack is empty !")
                Return
            End If
            Temporary = Top
            Do
                Console.WriteLine(Stack_Array(Temporary).Data)
                Temporary = Stack_Array(Temporary).Pointer
            Loop Until Temporary = NULL
        End Sub
    End Structure
    Public Structure QUEUE
        Dim Queue_Array() As NODE
        Dim Temporary, FLP, Head, Tail As Integer
        Sub Initialize(ByVal size As Integer)
            ReDim Queue_Array(size - 1)
            For i = 0 To UBound(Queue_Array) - 1
                Queue_Array(i).Data = ""
                Queue_Array(i).Pointer = i + 1
            Next
            Queue_Array(UBound(Queue_Array)).Pointer = NULL
            Queue_Array(UBound(Queue_Array)).Data = ""
            Tail = NULL
            Head = NULL
            FLP = 0
        End Sub
        Sub Enqueue(ByVal data As String)
            If FLP = NULL Then
                Console.WriteLine("The Queue is full, hence no more datas could be added to it !")
                Return
            End If
            Temporary = FLP
            FLP = Queue_Array(FLP).Pointer
            Queue_Array(Temporary).Data = data
            Queue_Array(Temporary).Pointer = NULL
            If Head = NULL And Tail = NULL Then
                Head = Temporary
                Tail = Temporary
                Return
            End If
            Queue_Array(Tail).Pointer = Temporary
            Tail = Temporary
        End Sub
        Sub Dequeue()
            If Head = NULL And Tail = NULL Then
                Console.WriteLine("There is nothing to remove since the Queue is already empty !")
                Return
            End If
            Temporary = Head
            Head = Queue_Array(Head).Pointer
            Queue_Array(Temporary).Data = ""
            Queue_Array(Temporary).Pointer = FLP
            FLP = Temporary
        End Sub
        Sub Print_Recursively(ByVal pointer As Integer)
            If pointer = NULL Then
                Return
            End If
            Console.WriteLine(Queue_Array(pointer).Data)
            Print_Recursively(Queue_Array(pointer).Pointer)
        End Sub
        Sub Print()
            Dim current_ptr As Integer = Head
            While current_ptr <> NULL
                Console.WriteLine(Queue_Array(current_ptr).Data)
                current_ptr = Queue_Array(current_ptr).Pointer
            End While
        End Sub
    End Structure

    Sub Main()
        'Dim command As STACK
        'command.Initialize(5)
        'command.Peek()
        'command.Print()
        'command.Push("A")
        'command.Peek()
        'command.Pop()
        'command.Print()
        'command.Peek()
        'command.Push("A")
        'command.Push("b")
        'command.Push("c")
        'command.Push("d")
        'command.Push("E")
        'command.Push("F")
        'command.Peek()
        'command.Print()
        'command.Pop()
        'command.Peek()

        ''Dim test As QUEUE
        ''test.Initialize(3)
        ''test.Enqueue("A")
        ''test.Enqueue("B")
        ''test.Enqueue("C")
        ''test.Enqueue("D")
        ''test.Print_Recursively(test.Head)
        ''test.Print()
        ''Console.WriteLine("After removing the first node: ")
        ''test.Dequeue()
        ''test.Print(test.Head)
    End Sub
End Module
