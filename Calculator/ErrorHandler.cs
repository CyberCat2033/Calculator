namespace Calculator;

internal static class ErrorHandler
{
    #region Public Methods

    public static void DivideByZeroException(TextBox txt)
    {
        Logic.Clear(txt);
        DialogResult ErrorDivide = MessageBox.Show(
            Dict.Translate("Divide"),
            Dict.Translate("Error"),
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Error);
        if (ErrorDivide == DialogResult.No)
        {
            MessageBox.Show(
            Dict.Translate("FUCK"),
            Dict.Translate("FUCKER"),
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Error);
        }
        if (ErrorDivide == DialogResult.No)
        {
            MessageBox.Show(
            Dict.Translate("FUCK"),
            Dict.Translate("FUCKER"),
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }
    }

    public static void OverLoadExeption(string exc, TextBox txt)
    {
        MessageBox.Show(
            Dict.Translate(exc),
            Dict.Translate("Error"),
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        Logic.Clear(txt);
        
    }

    #endregion

}