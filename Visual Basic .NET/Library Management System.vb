Imports System

Module Program
    Dim FILE_PATH__Task3 As String = "C:\Users\sohai\Desktop\Computer Science\VB Projects\PM 2020 (Task 3).txt"
    Dim ARRAY_Task3(500, 8) As String
    Dim FILE_PATH__Task4_OLD As String = "C:\Users\sohai\Desktop\Computer Science\VB Projects\PM 2020 (Task 4)-OLD.txt"
    Dim FILE_PATH__Task4_NEW As String = "C:\Users\sohai\Desktop\Computer Science\VB Projects\PM 2020 (Task 4)-NEW.txt"
    Dim ARRAY_Task4(10, 9) As String
    Sub Main()
        Dim choice As String
        Do
            Console.Clear()
            Console.WriteLine(" ")
            Console.WriteLine("__________________________________________________________________________________________________________________________________________")
            Console.WriteLine(" ")
            Console.WriteLine("                                                        Pre-Released Material 2020                                                        ")
            Console.WriteLine("                                                      ------------------------------                                                      ")
            Console.WriteLine("                                                               | AS-9608 |                                                                ")
            Console.WriteLine(" ")
            Console.WriteLine(" ")
            Console.WriteLine("~>  Enter '3' to proceed to TASK 3: ")
            Console.WriteLine(" ")
            Console.WriteLine("~>  Enter '4' to proceed to TASK 4: ")
            Console.WriteLine(" ")
            Console.WriteLine(" ")
            Console.WriteLine(" ")
            Console.Write("<>  Task: ")
            choice = Console.ReadLine
            If choice = "3" Then
                Console.Clear()
                Task_3()
            ElseIf choice = "4" Then
                Console.Clear()
                Task_4()
            End If
        Loop Until choice = "3" Or choice = "4"
    End Sub
    Sub Task_4()
        Dim file_reader_2 As New IO.StreamReader(FILE_PATH__Task4_OLD)
        Dim row As Integer = 0
        Do
            Dim content As String = file_reader_2.ReadLine
            Dim coloumn As Integer = 0
            Dim start_position As Integer = 0
            For i = 0 To Len(content) - 1
                If content(i) = "|" Then
                    ARRAY_Task4(row, coloumn) = Mid(content, (start_position + 1), (i - start_position))
                    start_position = i + 1
                    coloumn += 1
                End If
                If i = Len(content) - 1 Then
                    ARRAY_Task4(row, 8) = Mid(content, (start_position + 1), (i - start_position) + 1)
                End If
            Next
            row += 1
        Loop Until file_reader_2.EndOfStream
        file_reader_2.Close()
        Console.WriteLine("")
        Console.WriteLine("---------------------------------------------------------CAMBRIDGE INTERNATIONAL LIBRARY---------------------------------------------------------")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("          BOOKNAME              AUTHOR      PUBLICATIONDATE  GENRE   NUMBEROFPAGES       ISBN         LANGUAGE  AMOUNTINSTOCK ISREQUESTED BORROWS")
        Console.WriteLine("-------------------------- ---------------- --------------- -------- ------------- -----------------  --------  ------------- ----------- -------")
        Console.WriteLine("")
        For i = 1 To UBound(ARRAY_Task4)
            Do
                Dim print_line As String = " "
                print_line += ARRAY_Task4(i, 0)
                For s = 0 To 27 - Len(ARRAY_Task4(i, 0))
                    print_line += " "
                Next
                print_line += ARRAY_Task4(i, 1)
                For s = 0 To 17 - Len(ARRAY_Task4(i, 1))
                    print_line += " "
                Next
                print_line += ARRAY_Task4(i, 2)
                For s = 0 To 13 - Len(ARRAY_Task4(i, 2))
                    print_line += " "
                Next
                print_line += ARRAY_Task4(i, 3)
                For s = 0 To 12 - Len(ARRAY_Task4(i, 3))
                    print_line += " "
                Next
                print_line += ARRAY_Task4(i, 4)
                For s = 0 To 9 - Len(ARRAY_Task4(i, 4))
                    print_line += " "
                Next
                print_line += ARRAY_Task4(i, 5)
                For s = 0 To 18 - Len(ARRAY_Task4(i, 5))
                    print_line += " "
                Next
                print_line += ARRAY_Task4(i, 6)
                For s = 0 To 14 - Len(ARRAY_Task4(i, 6))
                    print_line += " "
                Next
                print_line += ARRAY_Task4(i, 7)
                For s = 0 To 12 - Len(ARRAY_Task4(i, 7))
                    print_line += " "
                Next
                print_line += ARRAY_Task4(i, 8)
                If ARRAY_Task4(i, 8) = "Yes" Then
                    Console.Write(print_line)
                    Console.Write("      ")
                ElseIf ARRAY_Task4(i, 8) = "No" Then
                    Console.Write(print_line)
                    Console.Write("       ")
                End If
                ARRAY_Task4(i, 9) = Console.ReadLine
                If i = UBound(ARRAY_Task4) Then
                    Console.WriteLine("")
                    Console.WriteLine("")
                    Console.WriteLine("")
                    Console.WriteLine("")
                    Console.WriteLine(">>> The new field 'NUMBER OF TIMES BORROWED' has been successfully added to the library's data file ! ")
                    Console.WriteLine("")
                    Console.WriteLine("")
                    Console.WriteLine("")
                    Console.WriteLine("")
                End If
                If Not IsNumeric(ARRAY_Task4(i, 9)) Then
                    Console.Clear()
                    Console.WriteLine("")
                    Console.WriteLine("---------------------------------------------------------CAMBRIDGE INTERNATIONAL LIBRARY---------------------------------------------------------")
                    Console.WriteLine("")
                    Console.WriteLine("")
                    Console.WriteLine("")
                    Console.WriteLine("")
                    Console.WriteLine("          BOOKNAME              AUTHOR      PUBLICATIONDATE  GENRE   NUMBEROFPAGES       ISBN         LANGUAGE  AMOUNTINSTOCK ISREQUESTED BORROWS")
                    Console.WriteLine("-------------------------- ---------------- --------------- -------- ------------- -----------------  --------  ------------- ----------- -------")
                    Console.WriteLine("")
                    For repeat = 1 To i - 1
                        print_line = " "
                        print_line += ARRAY_Task4(repeat, 0)
                        For s = 0 To 27 - Len(ARRAY_Task4(repeat, 0))
                            print_line += " "
                        Next
                        print_line += ARRAY_Task4(repeat, 1)
                        For s = 0 To 17 - Len(ARRAY_Task4(repeat, 1))
                            print_line += " "
                        Next
                        print_line += ARRAY_Task4(repeat, 2)
                        For s = 0 To 13 - Len(ARRAY_Task4(repeat, 2))
                            print_line += " "
                        Next
                        print_line += ARRAY_Task4(repeat, 3)
                        For s = 0 To 12 - Len(ARRAY_Task4(repeat, 3))
                            print_line += " "
                        Next
                        print_line += ARRAY_Task4(repeat, 4)
                        For s = 0 To 9 - Len(ARRAY_Task4(repeat, 4))
                            print_line += " "
                        Next
                        print_line += ARRAY_Task4(repeat, 5)
                        For s = 0 To 18 - Len(ARRAY_Task4(repeat, 5))
                            print_line += " "
                        Next
                        print_line += ARRAY_Task4(repeat, 6)
                        For s = 0 To 14 - Len(ARRAY_Task4(repeat, 6))
                            print_line += " "
                        Next
                        print_line += ARRAY_Task4(repeat, 7)
                        For s = 0 To 12 - Len(ARRAY_Task4(repeat, 7))
                            print_line += " "
                        Next
                        print_line += ARRAY_Task4(repeat, 8)
                        If ARRAY_Task4(repeat, 8) = "Yes" Then
                            print_line += "      "
                            print_line += ARRAY_Task4(repeat, 9)

                        ElseIf ARRAY_Task4(repeat, 8) = "No" Then
                            print_line += "       "
                            print_line += ARRAY_Task4(repeat, 9)

                        End If
                        Console.WriteLine(print_line)
                    Next
                End If
            Loop Until IsNumeric(ARRAY_Task4(i, 9))
        Next
        Dim file_writer_2 As New IO.StreamWriter(FILE_PATH__Task4_NEW)
        file_writer_2.WriteLine("BOOKNAME|AUTHOR|PUBLICATIONDATE|GENRE|NUMBEROFPAGES|ISBN|LANGUAGE|AMOUNTINSTOCK|ISREQUESTED|TIMESBORROWED")
        For row = 1 To UBound(ARRAY_Task4)
            Dim new_line As String = ""
            For coloumn = 0 To 8
                new_line += ARRAY_Task4(row, coloumn)
                new_line += "|"
            Next
            For coloumn = 9 To 9
                new_line += ARRAY_Task4(row, coloumn)
            Next
            file_writer_2.WriteLine(new_line)
        Next
        file_writer_2.Close()
    End Sub
    Sub Task_3()
        Dim action_number As Integer
        Do
            Console.WriteLine("")
            Console.WriteLine("------------------------------------------------------CAMBRIDGE INTERNATIONAL LIBRARY-----------------------------------------------------")
            Console.WriteLine("")
            Console.WriteLine("ACTION 1 - ADD A NEW BOOK")
            Console.WriteLine("ACTION 2 - SEARCH FOR BOOKS")
            Console.WriteLine("ACTION 3 - END THE PROGRAM")
            Console.WriteLine("")
            Console.WriteLine("Enter the desired ACTION NUMBER to proceed with (1/2/3):- ")
            Console.Write("<> Action: ")
            action_number = Console.ReadLine
            If action_number = 1 Then
                ADD_DATAS()
            ElseIf action_number = 2 Then
                COPY_DATAS_TO_ARRAY()
                SEARCH_AND_SHOW_DATAS_FROM_ARRAY()
            End If
        Loop Until action_number = 3
        Console.Clear()
        Console.WriteLine("")
        Console.WriteLine(">>> The PROGRAM has ended !")
        Console.WriteLine("")
    End Sub
    Sub ADD_DATAS()
        Dim new_line As String = ""
        Console.Clear()
        Console.WriteLine("")
        Console.WriteLine("-----------------------------------------------------------ADD NEW BOOK-----------------------------------------------------------")
        Console.WriteLine("")
        Console.WriteLine("> What is the name of the book ?")
        new_line += Console.ReadLine
        new_line += "|"
        Dim content As String
        Dim flag As Boolean
        Do
            content = ""
            Console.WriteLine("> Who wrote the book ?")
            content = Console.ReadLine
            For i = 0 To Len(content) - 1
                flag = True
                If (content(i) < "A" Or content(i) > "Z") And (content(i) < "a" Or content(i) > "z") And (content(i) <> " ") Then
                    flag = False
                    Exit For
                End If
            Next
        Loop Until flag = True
        new_line += content
        new_line += "|"
        Do
            content = ""
            Console.WriteLine("> What is the publication date of the book ? (YYYY-MM-DD)")
            content = Console.ReadLine
            flag = True
            Dim year, month, day As String
            year = ""
            month = ""
            day = ""
            For i = 0 To 3
                year += content(i)
            Next
            For i = 5 To 6
                month += content(i)
            Next
            For i = 8 To 9
                day += content(i)
            Next
            If CInt(year) > 2020 Or CInt(year) < 0 Then
                flag = False
            End If
            If CInt(month) > 12 Or CInt(month) < 1 Then
                flag = False
            End If
            If CInt(day) > 30 Or CInt(day) < 1 Then
                flag = False
            End If
        Loop Until flag = True
        new_line += content
        new_line += "|"
        Do
            content = ""
            Console.WriteLine("> Enter the book's genre : ")
            content = Console.ReadLine
            For i = 0 To Len(content) - 1
                flag = True
                If (content(i) < "A" Or content(i) > "Z") And (content(i) < "a" Or content(i) > "z") And (content(i) <> " ") Then
                    flag = False
                    Exit For
                End If
            Next
        Loop Until flag = True
        new_line += content
        new_line += "|"
        Do
            content = ""
            Console.WriteLine("> How many pages does the book have ?")
            content = Console.ReadLine
            For i = 0 To Len(content) - 1
                flag = True
                If content(i) < "0" Or content(i) > "9" Then
                    flag = False
                    Exit For
                End If
            Next
        Loop Until flag = True
        new_line += content
        new_line += "|"
        Do
            Dim odd_total, even_total, isbn_total As Integer
            odd_total = 0
            even_total = 0
            isbn_total = 0
            content = ""
            Console.WriteLine("> Enter the book's ISBN number :")
            content = Console.ReadLine
            flag = False
            Dim ISBN As String = ""
            For i = 0 To Len(content) - 1
                If content(i) >= "0" And content(i) <= "9" Then
                    ISBN += content(i)
                End If
            Next
            If Len(ISBN) = 13 Then
                Dim ISBN_array(11) As String
                For i = 0 To 11
                    ISBN_array(i) = ISBN(i)
                Next
                Dim check_digit As String = ISBN(12)
                For i = 0 To 11 Step 2
                    even_total += CInt(ISBN_array(i)) * 1
                Next
                For i = 1 To 11 Step 2
                    odd_total += CInt(ISBN_array(i)) * 3
                Next
                isbn_total = odd_total + even_total
                Dim remainder As Integer = isbn_total Mod 10
                Dim calculated_check_digit = 10 - remainder
                If calculated_check_digit = CInt(check_digit) Then
                    flag = True
                    content = ISBN
                End If
            End If
        Loop Until flag = True
        new_line += content
        new_line += "|"
        Do
            content = ""
            Console.WriteLine("> Which language is the book written in ?")
            content = Console.ReadLine
            For i = 0 To Len(content) - 1
                flag = True
                If (content(i) < "A" Or content(i) > "Z") And (content(i) < "a" Or content(i) > "z") And (content(i) <> " ") Then
                    flag = False
                    Exit For
                End If
            Next
        Loop Until flag = True
        new_line += content
        new_line += "|"
        Do
            content = ""
            Console.WriteLine("> How many copies of this book will you add ?")
            content = Console.ReadLine
            For i = 0 To Len(content) - 1
                flag = True
                If content(i) < "0" Or content(i) > "9" Then
                    flag = False
                    Exit For
                End If
            Next
        Loop Until flag = True
        new_line += content
        new_line += "|"
        Do
            content = ""
            Console.WriteLine("> Is this book requred now ? (Yes/No)")
            content = Console.ReadLine
            flag = False
            If content = "NO" Or content = "No" Or content = "no" Then
                flag = True
                new_line += "No"
            End If
            If content = "Yes" Or content = "yes" Or content = "YES" Then
                flag = True
                new_line += "Yes"
            End If
        Loop Until flag = True
        Console.Clear()
        Console.WriteLine("")
        Console.WriteLine(">>> Thank you, the library's stock has been successfully updated !")
        Console.WriteLine("")
        Dim filewriter As New IO.StreamWriter(FILE_PATH__Task3, True)
        filewriter.WriteLine(new_line)
        filewriter.Close()
    End Sub
    Sub COPY_DATAS_TO_ARRAY()
        Dim file_reader As New IO.StreamReader(FILE_PATH__Task3)
        Dim row As Integer = 0
        Do
            Dim content As String = file_reader.ReadLine
            Dim coloumn As Integer = 0
            Dim start_position As Integer = 0
            For i = 0 To Len(content) - 1
                If content(i) = "|" Then
                    ARRAY_Task3(row, coloumn) = Mid(content, (start_position + 1), (i - start_position))
                    start_position = i + 1
                    coloumn += 1
                End If
                If i = Len(content) - 1 Then
                    ARRAY_Task3(row, 8) = Mid(content, (start_position + 1), (i - start_position) + 1)
                End If
            Next
            row += 1
        Loop Until file_reader.EndOfStream
        file_reader.Close()
    End Sub
    Sub SEARCH_AND_SHOW_DATAS_FROM_ARRAY()
        Console.Clear()
        Console.WriteLine("")
        Console.WriteLine("--------------------------------------------------------------SEARCH FOR BOOKS------------------------------------------------------------")
        Console.WriteLine("")
        Console.WriteLine("Type in the author's name :")
        Dim author As String = Console.ReadLine
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("          BOOKNAME               AUTHOR      PUBLICATIONDATE  GENRE   NUMBEROFPAGES       ISBN         LANGUAGE  AMOUNTINSTOCK ISREQUESTED")
        Console.WriteLine("--------------------------- ---------------- --------------- -------- ------------- -----------------  --------  ------------- -----------")
        Console.WriteLine("")
        Dim found_flag As Boolean = False
        For i = 1 To UBound(ARRAY_Task3)
            Dim print_line As String = " "
            If Mid(ARRAY_Task3(i, 1), 1, Len(author)) = author Then
                found_flag = True
                print_line += ARRAY_Task3(i, 0)
                For s = 0 To 27 - Len(ARRAY_Task3(i, 0))
                    print_line += " "
                Next
                print_line += ARRAY_Task3(i, 1)
                For s = 0 To 17 - Len(ARRAY_Task3(i, 1))
                    print_line += " "
                Next
                print_line += ARRAY_Task3(i, 2)
                For s = 0 To 13 - Len(ARRAY_Task3(i, 2))
                    print_line += " "
                Next
                print_line += ARRAY_Task3(i, 3)
                For s = 0 To 12 - Len(ARRAY_Task3(i, 3))
                    print_line += " "
                Next
                print_line += ARRAY_Task3(i, 4)
                For s = 0 To 9 - Len(ARRAY_Task3(i, 4))
                    print_line += " "
                Next
                print_line += ARRAY_Task3(i, 5)
                For s = 0 To 18 - Len(ARRAY_Task3(i, 5))
                    print_line += " "
                Next
                print_line += ARRAY_Task3(i, 6)
                For s = 0 To 14 - Len(ARRAY_Task3(i, 6))
                    print_line += " "
                Next
                print_line += ARRAY_Task3(i, 7)
                For s = 0 To 12 - Len(ARRAY_Task3(i, 7))
                    print_line += " "
                Next
                print_line += ARRAY_Task3(i, 8)
                Console.WriteLine(print_line)
                Console.WriteLine("")
            End If
        Next
        If found_flag = True Then
            Console.WriteLine("")
            Console.WriteLine("__________________________________________________________________________________________________________________________________________")
            Console.WriteLine("")
            Console.WriteLine("")
        End If
        If found_flag = False Then
            Console.WriteLine("             X                     X                X            X          X               X             X           X            X     ")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine(">>> Sorry, curently there are no books written by '{0}' available in the library !", author)
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("__________________________________________________________________________________________________________________________________________")
            Console.WriteLine("")
            Console.WriteLine("")
        End If
    End Sub
End Module