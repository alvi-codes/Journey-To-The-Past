Imports System

Module Module1

    Sub Main()
        Dim choice, amount, money, AccNum, Account, deposit, withdrawal, TransferNum, TransferDep, TransferWit, NewAmount, age, pin, confirmpin As Integer
        Dim name1, name2, pass, choose, branch, log As String
        Dim chance As Integer = 5
        Dim phone As Long 'this is a form of integer, but you can store bigger numbers here
        'a phone number is too large for integer

        Do
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("                                                 Welcome to Mastermind's Bank!")
            Console.WriteLine("")
            Console.WriteLine("What would you like to do?")
            Console.WriteLine("1. Create New account" & " " & "2. Third party transactions" & " " & "3. Check account information" & " " & "4.Log Out")
            Console.WriteLine("Please enter the number of your choice:")
            choice = Console.ReadLine
            Console.Clear()

            If choice = 1 Then
                Console.WriteLine("Welcome to our Account Creation page! You'll have an account created after filling in some details.")
                Console.WriteLine("Enter your first name:")
                name1 = Console.ReadLine
                Console.WriteLine("Enter your last name:")
                name2 = Console.ReadLine

                Do
                    Console.WriteLine("Enter your age:")
                    age = Console.ReadLine
                    If age < 18 Then
                        Console.WriteLine("")
                        Console.WriteLine("Sorry, you need to be atleast 18 years to open an account!")
                    End If
                Loop Until age > 17


                Console.Clear()
                Do
                    Console.WriteLine("Enter your pin number:")
                    Console.WriteLine("Note:pin must be atleast 5 digits long")
                    pin = Console.ReadLine

                    If Len(CStr(pin)) > 4 Then
                        Do
                            Console.WriteLine("")
                            Console.WriteLine("Please enter your pin again to confirm the pin:")
                            confirmpin = Console.ReadLine
                            If confirmpin = pin Then
                                Console.WriteLine("")
                                Console.WriteLine("Pin successfully registered!")
                            Else
                                Console.WriteLine("")
                                Console.WriteLine("Pin does not match! Please check again")

                            End If
                        Loop Until confirmpin = pin

                        Console.ReadLine()
                        Console.Clear()

                    Else
                        Console.WriteLine("")
                        Console.WriteLine("Pin number is too short")
                        Console.WriteLine("Try entering another pin")
                    End If
                Loop Until Len(CStr(pin)) > 4

                Do
                    Console.WriteLine("Enter your Contact Number: ")
                    phone = Console.ReadLine

                    If Len(CStr(phone)) <> 10 Then
                        Console.WriteLine("")
                        Console.WriteLine("The phone number seems incorrect! Enter a valid phone number of 11 digits")
                    Else Console.WriteLine("Your contact number has been saved")
                    End If
                Loop Until Len(CStr(phone)) = 10



                Console.ReadLine()
                Console.Clear()
                Console.WriteLine("Your account has been succesfully created!)")
                AccNum = 101
                Console.WriteLine("Your account number is:" & AccNum)


                Do
                    Console.WriteLine("Please enter the amount of money you wish to deposit:")
                    amount = Console.ReadLine
                    If amount >= 1000 Then
                        Console.WriteLine("")
                        Console.WriteLine("Your amount has been saved. Thankyou for choosing our bank!")
                        Console.WriteLine("Kindly deposit" & " " & "$" & " " & amount & " " & "in the deposit counter if you are depositing in cash.")
                    Else Console.WriteLine("")
                        Console.WriteLine("Sorry the amount is too low. You must deposit a minimum of $1000 to open your account")
                    End If
                Loop Until amount >= 1000

                money = amount
                Console.ReadLine()
                Console.Clear()

            ElseIf choice = 2 Then
                Console.WriteLine("Welcome to the transactions page:")

                Do
                    Console.WriteLine("")
                    Console.WriteLine("Enter your account number:")
                    Account = Console.ReadLine
                    If Account <> AccNum Then
                        Console.WriteLine("")
                        Console.WriteLine("Account number not valid")
                        Console.WriteLine("Please check if you have created an account or try entering another account number!")
                    End If
                Loop Until Account = AccNum


                Console.Clear()
                Do
                    Console.WriteLine("")
                    Console.WriteLine("Enter your pin number")
                    Console.WriteLine("Your account will automatically lock down if you enter the wrong pin 5 times")
                    pass = Console.ReadLine
                    If pass <> pin Then

                        chance = chance - 1
                        Console.WriteLine("")
                        Console.WriteLine("The pin you entered is incorrect. Please try again.")
                        Console.WriteLine("You have" & " " & chance & " " & "remaining chances.")

                    End If

                Loop Until pass = pin Or chance = 0


                Console.Clear()

                If chance = 0 Then
                    Console.WriteLine(" ")
                    Console.WriteLine("You've entered wrong pin 5 times. Your account has been locked down!")
                    Console.ReadLine()
                    Console.Clear()
                Else
                    Console.Clear()
                    Console.WriteLine("Welcome to your account!")
                    Console.WriteLine("Do you wish to deposit money from third parties or withdraw money for transferring to third parties?")

                    Do
                        Console.WriteLine("Please enter deposit or withdraw:")
                        choose = Console.ReadLine
                        choose = LCase(choose)
                        If choose = "deposit" Then

                            Console.Clear()
                            Console.WriteLine("Enter the branch name you wish to transfer from:")
                            branch = Console.ReadLine
                            Console.WriteLine("Enter the account number from which you wish to transfer the money:")
                            TransferNum = Console.ReadLine
                            Console.WriteLine("Enter the amount of money you wish to transfer:")
                            TransferDep = Console.ReadLine
                            deposit = deposit + TransferDep
                            NewAmount = money + TransferDep
                            money = NewAmount
                            Console.WriteLine("Amount" & " " & "$" & TransferDep & " " & "succesfully transferred to your account from:" & branch & "," & TransferNum)

                        ElseIf choose = "withdraw" Then

                            Console.Clear()
                            Console.WriteLine("Enter the branch name you wish to transfer to:")
                            branch = Console.ReadLine
                            Console.WriteLine("Enter the account number to which you wish to transfer the money:")
                            TransferNum = Console.ReadLine
                            Console.WriteLine("Enter the amount of money you wish to transfer:")
                            TransferWit = Console.ReadLine
                            withdrawal = withdrawal + TransferWit
                            NewAmount = money - TransferWit
                            money = NewAmount
                            Console.WriteLine("")
                            Console.WriteLine("Amount" & " " & "$" & TransferWit & " " & "succesfully transferred to your account from:" & branch & "," & TransferNum)
                        Else
                            Console.WriteLine("")
                            Console.WriteLine("Invalid input. Choose between deposit and withdraw.")
                        End If
                    Loop Until choose = "deposit" Or choose = "withdraw"
                End If

                Console.ReadLine()
                Console.Clear()

            ElseIf choice = 3 Then
                Do
                    Console.WriteLine("")
                    Console.WriteLine("Enter your account number:")
                    Account = Console.ReadLine
                    If Account <> AccNum Then
                        Console.WriteLine("")
                        Console.WriteLine("Account number not valid")
                        Console.WriteLine("Please check if you have created an account or try entering another account number!")
                    End If
                Loop Until Account = AccNum


                Console.Clear()
                Do
                    Console.WriteLine("")
                    Console.WriteLine("Enter your pin number")
                    Console.WriteLine("Your account will automatically lock down if you enter the wrong pin 5 times")
                    pass = Console.ReadLine
                    If pass <> pin Then

                        chance = chance - 1
                        Console.WriteLine("")
                        Console.WriteLine("The pin you entered is incorrect. Please try again.")
                        Console.WriteLine("You have" & " " & chance & " " & "remaining chances.")

                    End If

                Loop Until pass = pin Or chance = 0


                Console.Clear()

                If chance = 0 Then
                    Console.WriteLine(" ")
                    Console.WriteLine("You have entered wrong pin 5 times. Your account has been locked down")
                    Console.ReadLine()
                    Console.Clear()
                Else
                    Console.WriteLine("Welcome to your account!")
                    Console.WriteLine("You current account information:")
                    Console.WriteLine("Account holder name:" & name1 & " " & name2)
                    Console.WriteLine("Amount deposited when account was created:" & "$" & amount)
                    If NewAmount > 0 Then
                        Console.WriteLine("Total amount currently in account=" & "$" & NewAmount)
                    Else Console.WriteLine("Total amount currently in account= $0")
                        Console.WriteLine("Bank overdraft=" & "$" & NewAmount)
                    End If
                    Console.WriteLine("Total depositions from third parties:" & "$" & deposit)
                    Console.WriteLine("Total withdrawals from third parties" & "$" & withdrawal)

                End If

                Console.ReadLine()
                Console.Clear()


            ElseIf choice = 4 Then
                Console.WriteLine("Are you sure you want to log out?")
                log = Console.ReadLine
                log = LCase(log)
                If log = "yes" Then
                    Console.WriteLine("Logging out")
                    Console.ReadLine()
                    Console.Clear()
                End If
            Else Console.WriteLine("Invalid choice! Try entering another number")

            End If

        Loop Until log = "yes"



    End Sub

End Module
