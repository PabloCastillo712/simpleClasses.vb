Module Module1



    Sub Main()

        Dim myNewCar As Car = New Car
        
        myNewCar.Make = "Oldsmobile"
        myNewCar.Make = "Cutlas Supreme"
        myNewCar.Make = 1986
        myNewCar.Make = "Silver"


        With myNewCar
            .Make = "Olds"
            .Model = "Cutlas"
            .Year = 1986
            .Color = "Silver"
        End With

        Console.WriteLine("{0}- {1} - {2}", myNewCar.Make, myNewCar.Model, myNewCar.Year.ToString())

        Console.WriteLine(determineMarketValue(myNewCar))

        Console.ReadLine()


    End Sub

    Function determineMarketValue(ByVal myCar As Car) As Double
        ' Super secret formula

        Return 100.0





    End Function


End Module
Public Class Car

    Public Make As String
    Public Model As String
    Public Year As Integer
    Public Color As String

    Public Function determineMarketValue() As Double
        ' Super secret formula

        Return 100.0

    End Function



End Class
