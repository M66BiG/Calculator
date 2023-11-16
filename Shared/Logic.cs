namespace Calculator.Shared;

internal class Logic
{
    public void Compute(string input)
    {
        input = input.Replace(" ", "");
        char[] ops = ['+','-', '*', '/', '%'];
        char[] numf = ['1','2','3','4','5','6','7','8','9','0',',','.'];
        char[] testing = ['(', ')'];

        List<string> operators = CreateSnippets(input, ops);
        List<string> numbers = CreateSnippets(input, numf);
        List<string> test = CreateSnippets(input, testing);

        numbers.ForEach(number => { Console.WriteLine($"{number}"); });
        Console.WriteLine();
        operators.ForEach(operators => { Console.WriteLine($"{operators}"); });
        Console.WriteLine();
        test.ForEach(operators => { Console.WriteLine($"{operators}"); });

        //return Convert.ToInt32(input);
    }

    private List<string> CreateSnippets(string input ,char[] x)
    {
        return input.Split(x).ToList();
    }

}
