Module Module1

    Sub Main()
        Dim col1() As String = {" a ", " d ", " g "}
        Dim col2() As String = {" b ", " e ", " h "}
        Dim col3() As String = {" c ", " f ", " i "}
        Dim character, input As String
        Dim TurnNumber As Integer = 0
        Dim gamerunning As Boolean = True
        Dim gamewon As Boolean = False
        Dim repeat As Boolean = False

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("                                      " & "Welcome to Nabila's Tic Tac Toe Game!")
        Console.WriteLine("")
        Console.WriteLine("                                      " & "You can quit anytime by typing quit. Enjoy!")
        Console.WriteLine("")
        Console.WriteLine("Enter player 1's name:")
        Dim player1 As String = Console.ReadLine
        Console.WriteLine("Enter player 2's name:")
        Dim player2 As String = Console.ReadLine


        Do
            Console.Clear()
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("                                      " & "Welcome to Nabila's Tic Tac Toe Game!")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("                                                 " & " " & " _ " & " " & " _ " & " " & " _ ")
            Console.WriteLine("")
            Console.WriteLine("                                                 " & "|" & col1(0) & "|" & col2(0) & "|" & col3(0) & "|")
            Console.WriteLine("                                                 " & " " & " _ " & " " & " _ " & " " & " _ ")
            Console.WriteLine("")
            Console.WriteLine("                                                 " & "|" & col1(1) & "|" & col2(1) & "|" & col3(1) & "|")
            Console.WriteLine("                                                 " & " " & " _ " & " " & " _ " & " " & " _ ")
            Console.WriteLine("")
            Console.WriteLine("                                                 " & "|" & col1(2) & "|" & col2(2) & "|" & col3(2) & "|")
            Console.WriteLine("                                                 " & " " & " _ " & " " & " _ " & " " & " _ ")
            Console.WriteLine("")
            Console.WriteLine("")
            Do
                If (TurnNumber Mod 2) = 0 Then

                    Console.WriteLine("                                   " & "O's Turn ({0}).Enter position:", player1)
                    character = " O "
                    input = Console.ReadLine
                    input = LCase(input)


                Else Console.WriteLine("                                  " & "X's Turn ({0}).Enter position:", player2)
                    character = " X "
                    input = Console.ReadLine
                    input = LCase(input)

                End If

                repeat = False
                Select Case input
                    Case "a"
                        If col1(0) = " a " Then
                            col1(0) = character

                        Else Console.WriteLine("                                            " & "Position is already occupied!")
                            repeat = True
                        End If
                    Case "b"

                        If col2(0) = " b " Then
                            col2(0) = character

                        Else Console.WriteLine("                                            " & "Position is already occupied!")
                            repeat = True
                        End If
                    Case "c"

                        If col3(0) = " c " Then
                            col3(0) = character

                        Else Console.WriteLine("                                            " & "Position is already occupied!")
                            repeat = True
                        End If
                    Case "d"

                        If col1(1) = " d " Then
                            col1(1) = character

                        Else Console.WriteLine("                                            " & "Position is already occupied!")
                            repeat = True
                        End If
                    Case "e"

                        If col2(1) = " e " Then
                            col2(1) = character

                        Else Console.WriteLine("                                            " & "Position is already occupied!")
                            repeat = True
                        End If
                    Case "f"

                        If col3(1) = " f " Then
                            col3(1) = character

                        Else Console.WriteLine("                                            " & "Position is already occupied!")
                            repeat = True
                        End If
                    Case "g"

                        If col1(2) = " g " Then
                            col1(2) = character

                        Else Console.WriteLine("                                            " & "Position is already occupied!")
                            repeat = True
                        End If
                    Case "h"

                        If col2(2) = " h " Then
                            col2(2) = character

                        Else Console.WriteLine("                                            " & "Position is already occupied!")
                            repeat = True
                        End If
                    Case "i"
                        If col3(2) = " i " Then
                            col3(2) = character

                        Else Console.WriteLine("                                            " & "Position is already occupied!")
                            repeat = True
                        End If
                    Case "quit"
                        If character = " O " Then
                            Console.WriteLine("                                             " & "O ({0}) quits! X ({1}) wins the game!", player1, player2)
                            Console.ReadLine()
                            gamerunning = False
                        ElseIf character = " X " Then
                            Console.WriteLine("                                             " & "X ({0}) quits! O ({1}) wins the game!", player2, player1)
                            Console.ReadLine()
                            gamerunning = False
                        End If
                    Case Else
                        Console.WriteLine("                                             " & "Invalid input!")
                        repeat = True

                End Select
                Console.WriteLine("")
            Loop Until repeat = False Or gamerunning = False

            TurnNumber += 1
            If TurnNumber >= 9 Then
                gamerunning = False

            End If

            Console.Clear()

            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("                                      " & "Welcome to Nabila's Tic Tac Toe Game!")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("                                                 " & " " & " _ " & " " & " _ " & " " & " _ ")
            Console.WriteLine("")
            Console.WriteLine("                                                 " & "|" & col1(0) & "|" & col2(0) & "|" & col3(0) & "|")
            Console.WriteLine("                                                 " & " " & " _ " & " " & " _ " & " " & " _ ")
            Console.WriteLine("")
            Console.WriteLine("                                                 " & "|" & col1(1) & "|" & col2(1) & "|" & col3(1) & "|")
            Console.WriteLine("                                                 " & " " & " _ " & " " & " _ " & " " & " _ ")
            Console.WriteLine("")
            Console.WriteLine("                                                 " & "|" & col1(2) & "|" & col2(2) & "|" & col3(2) & "|")
            Console.WriteLine("                                                 " & " " & " _ " & " " & " _ " & " " & " _ ")

            Console.WriteLine()

            Console.WriteLine()

            'checking if game has been won

            'checking rows
            For Index = 0 To 2
                If col1(Index) = " X " And col2(Index) = " X " And col3(Index) = " X " Then
                    Console.WriteLine("                                                 " & "X ({0}) Won!!!!", player2)
                    gamewon = True
                ElseIf col1(Index) = " O " And col2(Index) = " O " And col3(Index) = " O " Then
                    Console.WriteLine("                                                 " & "O ({0}) Won!!!!", player1)
                    gamewon = True

                End If
            Next
            'checking col 1
            If col1(0) = " X " And col1(1) = " X " And col1(2) = " X " Then
                Console.WriteLine("                                                     " & "X ({0}) Won!!!!", player2)
                gamewon = True
            ElseIf col1(0) = " O " And col1(1) = " O " And col1(2) = " O " Then
                Console.WriteLine("                                                     " & "O ({0}) Won!!!!", player1)
                gamewon = True

            End If

            'checking col 2
            If col2(0) = " X " And col2(1) = " X " And col2(2) = " X " Then
                Console.WriteLine("                                                     " & "X ({0}) Won!!!!", player2)
                gamewon = True
            ElseIf col2(0) = " O " And col2(1) = " O " And col2(2) = " O " Then
                Console.WriteLine("                                                     " & "O ({0}) Won!!!!", player1)
                gamewon = True

            End If

            'checking col 3
            If col3(0) = " X " And col3(1) = " X " And col3(2) = " X " Then
                Console.WriteLine("                                                     " & "X ({0}) Won!!!!", player2)
                gamewon = True
            ElseIf col3(0) = " O " And col3(1) = " O " And col3(2) = " O " Then
                Console.WriteLine("                                                     " & "O ({0}) Won!!!!", player1)
                gamewon = True

            End If

            'checking y=x diagonal
            If col3(0) = " X " And col2(1) = " X " And col1(2) = " X " Then
                Console.WriteLine("                                                     " & "X ({0}) Won!!!!", player2)
                gamewon = True
            ElseIf col3(0) = " O " And col2(1) = " O " And col1(2) = " O " Then
                Console.WriteLine("                                                     " & "O ({0}) Won!!!!", player1)
                gamewon = True

            End If

            'checking y=-x diagonal
            If col1(0) = " X " And col2(1) = " X " And col3(2) = " X " Then
                Console.WriteLine("                                                     " & "X ({0}) Won!!!!", player2)
                gamewon = True
            ElseIf col1(0) = " O " And col2(1) = " O " And col3(2) = " O " Then
                Console.WriteLine("                                                     " & "O ({0}) Won!!!!", player1)
                gamewon = True

            End If

            If TurnNumber = 9 And gamewon = False Then
                Console.WriteLine("                                                     " & "It is a draw!!!")
            End If
        Loop Until gamerunning = False Or gamewon = True
    End Sub
End Module
