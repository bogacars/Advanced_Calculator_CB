'Carson Bogart
'RCET0265
'Fall 2022
'Advanced Calculator
'


Option Explicit On
Option Strict On
Option Compare Text
Module AdvancedCalculator
    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim end1 As Boolean = False
        Dim end2 As Boolean = False
        Dim decision As Boolean = False
        Dim userInput As String
        Dim leave As Boolean = False
        Dim selector As Integer

        'loop will run until "Q" is entered
        'user selects firstNumber
        Do Until leave = True
            Console.WriteLine("Enter two numbers, or press Q to quit")
            Console.WriteLine("Enter the first number")
            Do While end1 = False
                Try
                    userInput = Console.ReadLine()
                    firstNumber = CInt(userInput)
                    Console.WriteLine("You entered " & firstNumber)
                    end1 = True
                Catch
                    If userInput = "Q" Then
                        end1 = True
                        leave = True
                    Else
                        Console.WriteLine(userInput & " was entered")
                        Console.WriteLine("Enter a whole number")
                        end1 = False
                    End If
                End Try
            Loop
            'user selects secondNumber
            If leave <> True Then
                Console.WriteLine("Please enter a second number")
                Do While end2 = False
                    Try
                        userInput = Console.ReadLine()
                        secondNumber = CInt(userInput)
                        Console.WriteLine("You entered " & secondNumber)
                        end2 = True
                    Catch
                        If userInput = "Q" Then
                            end2 = True
                            leave = True
                        Else
                            Console.WriteLine(secondNumber & " was enetered")
                            Console.WriteLine("Enter a whole number")
                            end2 = False
                        End If
                    End Try
                Loop
                'Menu will continue to run unitl "Q" is pressed
                If leave <> True Then
                    Console.WriteLine("Choose the operation that is desired:")
                    'userInput will choose the operation desired
                    Console.WriteLine("1. Add")
                    Console.WriteLine("2. Subtract")
                    Console.WriteLine("3. Multiply")
                    Console.WriteLine("4. Divide")
                    Do While decision = False
                        'depending on userInput will chose the if or elsIf operation
                        Try
                            userInput = (Console.ReadLine())
                            selector = CInt(userInput)
                            If selector = 1 Then
                                Console.WriteLine("You have chose to add")
                                Console.WriteLine(firstNumber & "+" & secondNumber & "=" & firstNumber + secondNumber)
                                decision = True
                            ElseIf selector = 2 Then
                                Console.WriteLine("You have chose to subtract")
                                Console.WriteLine(firstNumber & "-" & secondNumber & "=" & firstNumber - secondNumber)
                                decision = True
                            ElseIf selector = 3 Then
                                Console.WriteLine("You have chose to multiply")
                                Console.WriteLine(firstNumber & "*" & secondNumber & "=" & firstNumber * secondNumber)
                                decision = True
                            ElseIf selector = 4 Then
                                Console.WriteLine("You have chose to divide and conquer")
                                Console.WriteLine(firstNumber & "/" & secondNumber & "=" & firstNumber / secondNumber)
                                decision = True
                            Else
                                decision = False
                                Console.WriteLine("Choose the operation that is desired:")
                                Console.WriteLine("1. Add")
                                Console.WriteLine("2. Subtract")
                                Console.WriteLine("3. Multiply")
                                Console.WriteLine("4. Divide")
                            End If

                        Catch
                            If userInput = "Q" Then
                                decision = True
                                leave = True
                            Else
                                Console.WriteLine("Choose the operation that is desired:")
                                Console.WriteLine("1. Add")
                                Console.WriteLine("2. Subtract")
                                Console.WriteLine("3. Multiply")
                                Console.WriteLine("4. Divide")
                                decision = False
                            End If

                        End Try
                    Loop
                    'setting these false prevents the code running forever
                    end1 = False
                    end2 = False
                    decision = False
                End If
            End If
        Loop
        Console.WriteLine("You pressed Q see you later")
        Console.WriteLine("Press enter to close")
        Console.ReadLine()
    End Sub

End Module

