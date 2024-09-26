namespace Calculator;

public static class Logic
{
    #region Variables

    private const sbyte MaxLength = 7;
    private const sbyte MaxResLength = 10;
    public static string Decimal_char { get; set; } = ".";

    #endregion

    #region Public Methods

    public static void PosOrNeg(TextBox txt)
    {
        if (!String.IsNullOrWhiteSpace(txt.Text) && txt.Text != "0")
        {
            txt.Text = txt.Text.Contains('-')
                 ? txt.Text[1..] : txt.Text = '-' + txt.Text;
        }
    }

    public static void BackSpace(TextBox txt)
    {
        if (CalcHelper.IsResult)
        { return; }

        txt.Text = txt.Text.Length > 1 ? txt.Text[..^1] : "0";
    }

    public static void Decimal(TextBox txt)
    {
        if (CalcHelper.IsResult)
        { return; }

        if (!txt.Text.Contains(Decimal_char) && !String.IsNullOrWhiteSpace(txt.Text) && txt.Text.Length < MaxLength)
        { txt.Text += Decimal_char; }
    }

    public static void Equals(TextBox txt)
    {
        CalcHelper.Parse(txt);
        decimal result = CalcHelper.Calculate(txt);
        string type = result.ToString().Length > MaxResLength ? "E" : $"0{Decimal_char}###";
        txt.Text = result.ToString(type);
    }

    public static void Clear(TextBox txt)
    {
        txt.Clear();
        txt.Text = "0";
        CalcHelper.Clear();

    }

    public static void Concat(TextBox txt, char number)
    {
        if (txt.Text.Length > MaxLength)
        { return; }

        if (txt.Text == "0")
        { txt.Clear(); }

        if (CalcHelper.IsResult)
        {
            Clear(txt);
            txt.Clear();
        }

        txt.Text += number;
        
        
    }

    #endregion

}
