using static System.Net.Mime.MediaTypeNames;

namespace Calculator;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Init();
    }

    private void Init()
    {
        Dict.Language_Choser();
        Logic.Decimal_char = Dict.Translate(".");
        Equals.Click += Button_Click;
        Substract.Click += Button_Click;
        Add.Click += Button_Click;
        Divide.Click += Button_Click;
        Multiply.Click += Button_Click;
        Clear.Click += Button_Click;
        Pow.Click += Button_Click;
        Decimal.Text = Dict.Translate(".");
        Text = Dict.Translate("Calc");

        foreach (Control control in TL_Panel.Controls)
        {
            control.Click += CursorPosChanger;
        }
    }

    #region Constants

    private const byte MaxTextSize = 67;
    private const byte TextTextBoxScale = 15;
    private const byte ButtonTextScale = 45;
    private const byte MaxButtonTextSize = 32;

    #endregion

    #region Private Methods

    private void KeyboardFunc(PreviewKeyDownEventArgs e)
    {
        #region Dictionaries
        Dictionary<Keys, Action> keyMap = new Dictionary<Keys, Action>()
    {
        { Keys.Enter, Equals.PerformClick },
        { Keys.Oemplus, Equals.PerformClick },
        { Keys.OemQuestion, Divide.PerformClick },
        { Keys.Divide, Divide.PerformClick },
        { Keys.Add, Add.PerformClick },
        { Keys.OemMinus, Substract.PerformClick },
        { Keys.Subtract, Substract.PerformClick },
        { Keys.Multiply, Multiply.PerformClick },
        { Keys.C, Clear.PerformClick },
        { Keys.Back, BackSpace.PerformClick },
        { Keys.Delete, BackSpace.PerformClick },
        { Keys.OemPeriod, Decimal.PerformClick },
        { Keys.NumPad0, Zero.PerformClick },
        { Keys.D0, Zero.PerformClick },
        { Keys.NumPad1, One.PerformClick },
        { Keys.D1, One.PerformClick },
        { Keys.NumPad2, Two.PerformClick },
        { Keys.D2, Two.PerformClick },
        { Keys.NumPad3, Three.PerformClick },
        { Keys.D3, Three.PerformClick },
        { Keys.NumPad4, Four.PerformClick },
        { Keys.D4, Four.PerformClick },
        { Keys.NumPad5, Five.PerformClick },
        { Keys.D5, Five.PerformClick },
        { Keys.NumPad6, Six.PerformClick },
        { Keys.D6, Six.PerformClick },
        { Keys.NumPad7, Seven.PerformClick },
        { Keys.D7, Seven.PerformClick },
        { Keys.NumPad8, Eight.PerformClick },
        { Keys.D8, Eight.PerformClick },
        { Keys.NumPad9, Nine.PerformClick },
        { Keys.D9, Nine.PerformClick },
    };

        Dictionary<Keys, Action> shiftKeyMap = new Dictionary<Keys, Action>()
    {
        { Keys.D8, Multiply.PerformClick },
        { Keys.D6, Pow.PerformClick },
        { Keys.Oemplus, Add.PerformClick },
        { Keys.OemQuestion, Decimal.PerformClick},
    };
        #endregion

        if (e.Modifiers == Keys.Shift && shiftKeyMap.ContainsKey(e.KeyCode))
        {
            shiftKeyMap[e.KeyCode]();
            return;
        }

        if (keyMap.ContainsKey(e.KeyCode))
        {
            keyMap[e.KeyCode]();
        }
    }

    private void Button_Click(object sender, EventArgs e)
    {

        Button clickedButton = (Button)sender;

        if (!Button_const(clickedButton))
        {
            clickedButton.Enabled = false;
        }

        foreach (Control control in TL_Panel.Controls)
        {
            if (control != clickedButton)
            {
                control.Enabled = true;
            }
        }
    }

    private bool Button_const(Button button) => button.Text is "C" or "=";

    private void Form1_ResizeBeg(object sender, EventArgs e)
    {
        TEXT.Font = FontResizer(TextTextBoxScale, MaxTextSize);

        foreach (Control control in TL_Panel.Controls)
        {
            control.Font = FontResizer(ButtonTextScale, MaxButtonTextSize);
        }

    }

    private Font FontResizer(byte Text_Scale, byte MaxTextSize)
        => new Font(TEXT.Font.FontFamily, (Width / Text_Scale) < MaxTextSize ? Width / Text_Scale : MaxTextSize);

    private void KeyPreview_Handler(object sender, PreviewKeyDownEventArgs e) => KeyboardFunc(e);

    private void TEXT_MouseClick(object sender, MouseEventArgs e) => UpdateCursorPosition();

    private void CursorPosChanger(object sender, EventArgs e) => UpdateCursorPosition();

    private void UpdateCursorPosition() => TEXT.Select(TEXT.Text.Length, 0);

    #endregion

    #region Button_Click events

    private void Zero_Click(object sender, EventArgs e)
    {
        Logic.Concat(TEXT, '0');

    }

    private void One_Click(object sender, EventArgs e)
    {
        Logic.Concat(TEXT, '1');
    }

    private void Two_Click(object sender, EventArgs e)
    {
        Logic.Concat(TEXT, '2');

    }

    private void Three_Click(object sender, EventArgs e)
    {
        Logic.Concat(TEXT, '3');

    }

    private void Four_Click(object sender, EventArgs e)
    {
        Logic.Concat(TEXT, '4');

    }

    private void Five_Click(object sender, EventArgs e)
    {
        Logic.Concat(TEXT, '5');
    }

    private void Six_Click(object sender, EventArgs e)
    {
        Logic.Concat(TEXT, '6');
    }

    private void Seven_Click(object sender, EventArgs e)
    {
        Logic.Concat(TEXT, '7');
    }

    private void Eight_Click(object sender, EventArgs e)
    {
        Logic.Concat(TEXT, '8');
    }

    private void Nine_Click(object sender, EventArgs e)
    {
        Logic.Concat(TEXT, '9');
    }

    private void Divide_Click(object sender, EventArgs e)
    {
        CalcHelper.Parse(TEXT, Operation.Divide);


    }

    private void Multiply_Click(object sender, EventArgs e)
    {
        CalcHelper.Parse(TEXT, Operation.Multiply);

    }

    private void Add_Click(object sender, EventArgs e)
    {
        CalcHelper.Parse(TEXT, Operation.Add);

    }

    private void Substract_Click(object sender, EventArgs e)
    {
        CalcHelper.Parse(TEXT, Operation.Subtract);
    }

    private void Decimal_Click(object sender, EventArgs e)
    {
        Logic.Decimal(TEXT);
    }

    private void PosOrNeg_Click(object sender, EventArgs e)
    {
        Logic.PosOrNeg(TEXT);
    }

    private void Clear_Click(object sender, EventArgs e)
    {
        Logic.Clear(TEXT);
    }

    private void BackSpace_Click(object sender, EventArgs e)
    {
        Logic.BackSpace(TEXT);
    }

    private void Equals_Click(object sender, EventArgs e)
    {
        Logic.Equals(TEXT);
    }

    private void Pow_Click(object sender, EventArgs e)
    {
        CalcHelper.Parse(TEXT, Operation.Pow);
    }

    #endregion

}

