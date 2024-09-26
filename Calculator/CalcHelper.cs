namespace Calculator;

public static class CalcHelper
{
    #region Variables

    private const sbyte MaxDegr = 20;
    public static byte TypeOfOperation;
    public static bool IsSecondNumber { set; private get; } = false;
    public static bool IsResult { get; private set; } = false;
    public static decimal FirstNumber { set; private get; }
    public static decimal SecondNumber { set; private get; }
    public static decimal Result { private set; get; }

    #endregion

    #region Public Methods

    public static decimal Calculate(TextBox txt)
    {
        try
        {
            Result = TypeOfOperation switch
            {
                1 => FirstNumber + SecondNumber,
                2 => FirstNumber - SecondNumber,
                3 => FirstNumber * SecondNumber,
                4 => FirstNumber / SecondNumber,
                5 => Pow(FirstNumber, (sbyte)SecondNumber),
                _ => 0,
            };
            ResultSwitch();

        }

        catch (OverflowException exc)
        {
            if (exc.Message.Contains("Value"))
            { exc = new OverflowException("Large num"); }
            ErrorHandler.OverLoadExeption(exc.Message, txt);
        }

        catch (DivideByZeroException)
        {
            ErrorHandler.DivideByZeroException(txt);
        }

        return Result;
    }

    public static void Parse(TextBox txt)
    {
        if (string.IsNullOrWhiteSpace(txt.Text)) { return; }
        if (IsResult)
        {
            ResultSwitch();
            IsSecondNumber = true;

        }
        else
        {
            if (IsSecondNumber)
            { SecondNumber = decimal.Parse(txt.Text); }
            else
            { FirstNumber = decimal.Parse(txt.Text); }

            IsSecondNumber = !IsSecondNumber;
        }

        txt.Clear();
    }

    public static void Parse(TextBox txt, Operation oper)
    {
        Parse(txt);
        TypeOfOperation = (byte)oper;
    }

    public static void Clear()
    {
        IsResult = false;
        IsSecondNumber = false;
        FirstNumber = 0;
        SecondNumber = 0;
        Result = 0;
        TypeOfOperation = 0;
    }

    #endregion

    #region Private Methods

    private static decimal Pow(decimal number, sbyte degr)
    {
        if (Math.Abs(degr) > MaxDegr)
        {
            throw new OverflowException("Large deg");
        }

        if (number == 0 && degr != 0)
        {
            return 0;
        }

        decimal result = 1;

        if (degr >= 0)
        {
            for (sbyte i = 0; i < degr; i++)
            {
                result *= number;
            }
        }
        else
        {
            result /= Pow(number, Math.Abs(degr));
        }

        return result;


    }

    private static void ResultSwitch()
    {
        IsResult = !IsResult;
        FirstNumber = Result;
    }

    #endregion
}