using System.Globalization;

namespace Calculator;

public static class Dict
{
    #region Variables

    public static string? language;

    #endregion

    #region Dictionarys

    private static Dictionary<string, string> RuDictionary = new Dictionary<string, string>()
    {
        { "Error", "Ошибка"},
        { "Divide",  "Нельзя делить на ноль"},
        { "FUCK", "Иди НАХУЙ" },
        { "FUCKER", "Ты МУДАК?" },
        { "Large num", "Число чересчур БОЛЬШОЕ"},
        { "Large deg", "Степень чересчур БОЛЬШАЯ" },
        { ".", "," },
        { "Calc", "Калькулятор" }


    };

    private static Dictionary<string, string> EnDictionary = new Dictionary<string, string>()
    {
        { "Error", "Error"},
        { "Divide",  "Cannot divide by zero"},
        { "FUCK", "Go FUCK yourself!" },
        { "FUCKER", "Are YOU a FUCKER?" },
        { "Large num", "The number is tooooo LARGE"},
        { "Large deg", "The degre is tooooo LARGE" },
        { ".", "." },
        { "Calc", "Calculator" }

    };

    #endregion  

    #region Public Methods

    public static void Language_Choser()
    {
        CultureInfo currentCulture = CultureInfo.CurrentCulture;
        language = currentCulture.TwoLetterISOLanguageName;
    }

    public static string Translate(string key)
    {
        if (RuDictionary.ContainsKey(key))
        {
            switch (language)
            {
                case "ru":
                    return RuDictionary[key];
                default:
                case "en":
                    return EnDictionary[key];
            }
        }
        else
        {
            throw new Exception("FUUUUUUCK");
        }


    }

    #endregion
}