public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        if (operation == null)
            throw new ArgumentNullException("The argument operation is null.");
        
        if (operation.Trim() == "")
            throw new ArgumentException("The argument operation is empty.");
        
        try
        {
            return operation switch
            {
                "+" => $"{operand1} + {operand2} = {SimpleOperation.Addition(operand1, operand2)}",
                "*" => $"{operand1} * {operand2} = {SimpleOperation.Multiplication(operand1, operand2)}",
                "/" => $"{operand1} / {operand2} = {SimpleOperation.Division(operand1, operand2)}",
                _ => throw new ArgumentOutOfRangeException("The operation does not exist.")
             };
        }
        catch (DivideByZeroException e)
        {
            return "Division by zero is not allowed.";
        }
    }
}