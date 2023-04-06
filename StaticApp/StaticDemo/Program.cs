




using StaticDemo;


string firstName = RequestUserData.GetFirstName("Please Enter your first name: ");

DisplayMessage.WelComeMessage(firstName);


double firstNumber = RequestUserData.GetNumber("Enter your first double number: ");
double secondNumber = RequestUserData.GetNumber("Enter your Second double number: ");

bool  isValidNumbers = Calculate.CheckDataValidity(firstNumber, secondNumber);

double multiply = Calculate.Multiply(firstNumber, secondNumber);
double add = Calculate.Add(firstNumber, secondNumber);
double subtract = Calculate.Subtract(firstNumber, secondNumber);


DisplayMessage.DisplayResult($"Addition of {firstNumber} and {secondNumber} is {add}");
DisplayMessage.DisplayResult($"Subtraction of {firstNumber} and {secondNumber} is {subtract}");
DisplayMessage.DisplayResult($"Multiplication of {firstNumber} and {secondNumber} is {multiply}");


if (isValidNumbers == true )
{

    double divide = Calculate.Divide(firstNumber, secondNumber);
    DisplayMessage.DisplayResult($"division of {firstNumber} and {secondNumber} is {divide}");
}
else
{
    DisplayMessage.DisplayResult($"{firstNumber}/{secondNumber}  operation is not possible ");
}

