Imports System

Module Module8
    Const NULL = -1
    'Public Class Node
    '    Public data As String
    '    Public ptr As Integer
    'End Class
    Public MustInherit Class LinkedLists
        Public Class Node
            Public data As String
            Public ptr As Integer
        End Class
        Public head As Integer
        Public flp As Integer
        Public list() As Node
        Public Sub New()
            head = NULL
            flp = 0
        End Sub
        Public Sub New(ByVal size As Integer)
            ReDim list(size - 1)
            head = NULL
            flp = 0
            For i = 0 To UBound(list) - 1
                list(i) = New Node
                list(i).data = ""
                list(i).ptr = i + 1
            Next
            list(UBound(list)) = New Node
            list(UBound(list)).data = ""
            list(UBound(list)).ptr = NULL
        End Sub
        Public Overridable Sub insert(ByVal data As String)
            Console.WriteLine(data & " has been inserted into the linked list")
        End Sub
        Public Overridable Sub delete(ByVal data As String)
            Console.WriteLine(data & " has been deleted from the linked list")
        End Sub
        Public Overridable Sub print()
            Console.WriteLine("the linked list has been printed")
        End Sub
    End Class
    Public Class Stacks
        Inherits LinkedLists
        Public Sub New(ByVal data As Integer)
            MyBase.New(data)
        End Sub
        Public Overrides Sub insert(data As String)
            Console.WriteLine(data & " has been pushed into the stack")
        End Sub
        Public Overrides Sub delete(data As String)
            Console.WriteLine(data & " has been pop from the stack")
        End Sub
        Public Overrides Sub print()
            Console.WriteLine("the stack has been printed")
        End Sub
    End Class
    Public Class Queues
        Inherits LinkedLists
        Public tail As Integer
        Sub New(ByVal data As Integer)
            MyBase.New(data)
            tail = NULL
        End Sub
        Public Overrides Sub insert(data As String)
            Console.WriteLine(data & " has been enqueued into the queue")
        End Sub
        Public Overrides Sub delete(data As String)
            Console.WriteLine(data & " has been dequeued from the queue")
        End Sub
        Public Overrides Sub print()
            Console.WriteLine("the queue has been printed")
        End Sub
    End Class
    Sub main()
        Dim l As New Stacks(5)
        l.insert("A")
    End Sub
End Module
