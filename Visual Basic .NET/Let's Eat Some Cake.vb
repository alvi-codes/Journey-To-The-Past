Imports System
Module Program
    Sub Main()
        Console.WriteLine("")
        Console.Write("Number of cakes made this week: ")
        Dim number_of_cakes As Integer = Console.ReadLine
        Dim cake As SINGLE_CAKE_COST
        Dim cake_costs(number_of_cakes), t_flour, t_sugar, t_milk, t_bakingpowder As Double
        Dim t_eggs As Integer
        For i = 1 To number_of_cakes
            Console.WriteLine("")
            Console.WriteLine("Enter the item amounts for Cake " & i & "-")
            Console.Write("Flour: ")
            cake.flour = Console.ReadLine
            t_flour += cake.flour
            Console.Write("Sugar: ")
            cake.sugar = Console.ReadLine
            t_sugar += cake.sugar
            Console.Write("Eggs: ")
            cake.eggs = Console.ReadLine
            t_eggs += cake.eggs
            Console.Write("Milk: ")
            cake.milk = Console.ReadLine
            t_milk += cake.milk
            Console.Write("Baking Powder: ")
            cake.bakingpowder = Console.ReadLine
            t_bakingpowder += cake.bakingpowder
            cake.calculate_total_cost()
            cake_costs(i) = cake.total
        Next
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.WriteLine("")
        For i = 1 To number_of_cakes
            Console.WriteLine("Cost of Cake {0}: Tk.{1}", i, cake_costs(i))
        Next
        Console.WriteLine("")
        Console.WriteLine("Total")
        Console.WriteLine("Flour: Tk.{0}", t_flour * 30)
        Console.WriteLine("Sugar: Tk.{0}", t_sugar * 25)
        Console.WriteLine("Eggs: Tk.{0}", t_eggs * 4)
        Console.WriteLine("Milk: Tk.{0}", t_milk * 32)
        Console.WriteLine("Baking Powder: Tk.{0}", t_bakingpowder * 20)
        Console.ForegroundColor = ConsoleColor.White
    End Sub
    Public Structure SINGLE_CAKE_COST
        Dim flour, sugar, milk, total, bakingpowder As Double
        Dim eggs As Integer
        Sub calculate_total_cost()
            total = (flour * 30) + (sugar * 25) + (eggs * 4) + (milk * 32) + (20 * bakingpowder)
        End Sub
    End Structure
End Module