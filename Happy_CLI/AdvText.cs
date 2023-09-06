using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Happy_CLI
{
    public class AdvText
    {
        private int _posLeft;
        private int _posTop;
        /// <summary>
        /// 
        /// </summary>
        public enum Align
        {
            LEFT = 0,
            RIGHT,
            CENTRT,
            TOP,
            BOTTOM,
        }
        public AdvText() { }
        /// <summary>
        /// text printing. No new line
        /// </summary>
        /// <param name="text">Input Text</param>
        public void write(string text)
        {
            Console.Write(text);
        }
        /// <summary>
        /// Color text printing. No new line
        /// </summary>
        /// <param name="text">Input Text</param>
        /// <param name="fcolor">Foreground Color</param>
        public void write(string text, ConsoleColor fcolor)
        {
            Console.ForegroundColor = fcolor;
            Console.Write(text);
            Console.ResetColor();
        }
        /// <summary>
        /// Color text printing. No new line
        /// </summary>
        /// <param name="text">Input Text</param>
        /// <param name="fcolor">Foreground Color</param>
        /// <param name="bcolor">Background Color</param>
        public void write(string text, ConsoleColor fcolor, ConsoleColor bcolor)
        {
            Console.ForegroundColor = fcolor;
            Console.BackgroundColor = bcolor;
            Console.Write(text);
            Console.ResetColor();
        }
        /// <summary>
        /// new line
        /// </summary>
        public void newLine()
        {
            Console.WriteLine();
        }
        /// <summary>
        /// Color text printing.new line
        /// </summary>
        /// <param name="text">Input Text</param>
        /// <param name="fcolor">Foreground Color</param>
        public void writeLine(string text, ConsoleColor fcolor)
        {
            Console.ForegroundColor = fcolor;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        /// <summary>
        /// text printing. new line
        /// </summary>
        /// <param name="text"></param>
        public void writeLine(string text)
        {
            Console.WriteLine(text);
        }
        /// <summary>
        /// Color text printing. new line
        /// </summary>
        /// <param name="text">Input Text</param>
        /// <param name="fcolor">Foreground Color</param>
        /// <param name="bcolor">Background Color</param>
        public void writeLine(string text, ConsoleColor fcolor, ConsoleColor bcolor)
        {
            Console.ForegroundColor = fcolor;
            Console.BackgroundColor = bcolor;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        /// <summary>
        /// Repeat a character
        /// </summary>
        /// <param name="ch">the character</param>
        /// <param name="count">Number of characters printed</param>
        /// <param name="newLine">Go to new line</param>
        public void RepeatCharacter(char ch, int count, bool newLine = true)
        {
            string tempo = string.Empty;
            tempo = tempo.PadLeft(count, ch);
            if (newLine)
            {
                Console.WriteLine(tempo);
            }
            else
            {
                Console.Write(tempo);
            }
        }
        /// <summary>
        /// Repeat a character
        /// </summary>
        /// <param name="ch">the character</param>
        /// <param name="count">Number of characters printed</param>
        /// <param name="fcolor">Foreground Color</param>
        /// <param name="newLine">Go to new line</param>
        public void RepeatCharacterColor(char ch, int count, ConsoleColor fcolor, bool newLine = true)
        {
            string tempo = string.Empty;
            tempo = tempo.PadLeft(count, ch);
            if (newLine)
            {
                this.writeLine(tempo, fcolor);
            }
            else
            {
                this.write(tempo, fcolor);
            }
        }
        /// <summary>
        /// Repeat a character
        /// </summary>
        /// <param name="ch">the character</param>
        /// <param name="count">Number of characters printed</param>
        /// <param name="fcolor">Foreground Color</param>
        /// <param name="bcolor">Background Color</param>
        /// <param name="newLine">Go to new line</param>
        public void RepeatCharacterColor(char ch, int count, ConsoleColor fcolor, ConsoleColor bcolor, bool newLine = true)
        {
            string tempo = string.Empty;
            tempo = tempo.PadLeft(count, ch);
            if (newLine)
            {
                this.writeLine(tempo, fcolor, bcolor);
            }
            else
            {
                this.write(tempo, fcolor, bcolor);
            }
        }
        /// <summary>
        /// Repeat a character in position
        /// </summary>
        /// <param name="ch"></param>
        /// <param name="count"></param>
        /// <param name="fColor"></param>
        /// <param name="bColor"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        public void RepeatCharacterColor(char ch, int count, ConsoleColor fColor, ConsoleColor bColor, int left, int top)
        {
            string tempo = string.Empty;
            tempo = tempo.PadLeft(count, ch);
            this.positionText(tempo, left, top, fColor, bColor);
        }
        /// <summary>
        /// Print text in position
        /// </summary>
        /// <param name="text">Input Text</param>
        /// <param name="left">Left position</param>
        /// <param name="top"> Top position</param>
        public void positionText(string text, int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(text);
        }
        /// <summary>
        /// Print text in position
        /// </summary>
        /// <param name="text">Input Text</param>
        /// <param name="left">Left position</param>
        /// <param name="top"> Top position</param>
        /// <param name="fcolor">Foreground Color</param>
        public void positionText(string text, int left, int top, ConsoleColor fcolor)
        {
            Console.SetCursorPosition(left, top);
            this.write(text, fcolor);
        }
        /// <summary>
        /// Print text in position
        /// </summary>
        /// <param name="text">Input Text</param>
        /// <param name="left">Left position</param>
        /// <param name="top"> Top position</param>
        /// <param name="fcolor">Foreground Color</param>
        /// <param name="bcolor"> Background Color</param>
        public void positionText(string text, int left, int top, ConsoleColor fcolor, ConsoleColor bcolor)
        {
            Console.SetCursorPosition(left, top);
            this.write(text, fcolor, bcolor);
        }
        /// <summary>
        /// Set Position Left For 'positionTextAt'
        /// </summary>
        public int posLeft
        {
            get { return this._posLeft; }
            set { this._posLeft = value; }
        }
        /// <summary>
        /// Set Position Top For 'positionTextAt'
        /// </summary>
        public int posTop
        {
            get { return this._posTop; }
            set { this._posTop = value; }
        }
        /// <summary>
        /// Print text in continuous position
        /// </summary>
        /// <param name="text">Input Text</param>
        /// <param name="left">Left Position</param>
        /// <param name="top">Top Position</param>
        public void positionTextAt(string text, int left, int top)
        {
            int Left = this._posLeft + left;
            int Top = this._posTop + top;
            this.positionTextAt(text, Left, Top);
        }
        /// <summary>
        /// Print text in continuous position
        /// </summary>
        /// <param name="text">Input Text</param>
        /// <param name="left">Left Position</param>
        /// <param name="top">Top Position</param>
        /// <param name="fColor">ForGround Color</param>
        public void positionTextAt(string text, int left, int top, ConsoleColor fColor)
        {
            int Left = this._posLeft + left;
            int Top = this._posTop + top;
            this.positionText(text, Left, Top, fColor);
        }
        /// <summary>
        /// Print text in continuous position
        /// </summary>
        /// <param name="text">Input Text</param>
        /// <param name="left">Left Position</param>
        /// <param name="top">Top Position</param>
        /// <param name="fColor">ForGround Color</param>
        /// <param name="bColor">Background Color</param>
        public void positionTextAt(string text, int left, int top, ConsoleColor fColor, ConsoleColor bColor)
        {
            int Left = this._posLeft + left;
            int Top = this._posTop + top;
            this.positionText(text, Left, Top, fColor, bColor);
        }
        /// <summary>
        /// Flashing text
        /// </summary>
        /// <param name="text">Text</param>
        /// <param name="timer">Timer</param>
        /// <param name="fColor">Forground Color</param>
        /// <param name="bColor">Backgound Color</param>
        public void FlashingText(string text, int timer, ConsoleColor fColor, ConsoleColor bColor)
        {
            try
            {
                if (timer > 0)
                {
                    int Timer = timer / 2;
                    while (true)
                    {
                        Thread.Sleep(Timer);
                        Console.Clear();
                        Thread.Sleep(Timer);
                        this.write(text, fColor, bColor);

                    }
                }
                else
                {
                    this.write("The numeric value of the timer is not correct", fColor, bColor);
                }

            }
            catch (DivideByZeroException e)
            {
                this.write("Divide by zero error ", fColor, bColor);
            }
        }
        /// <summary>
        /// Flashing Text
        /// </summary>
        /// <param name="text">Text</param>
        /// <param name="timer">Timer</param>
        /// <param name="fColor">Forground Color</param>
        /// <param name="bColor">Backgound Color</param>
        /// <param name="left">Left Position</param>
        /// <param name="top">Top Position</param>
        public void FlashingText(string text, int timer, ConsoleColor fColor, ConsoleColor bColor, int left, int top)
        {
            try
            {
                if (timer > 0)
                {
                    int Timer = timer / 2;
                    while (true)
                    {
                        Thread.Sleep(Timer);
                        Console.Clear();
                        Thread.Sleep(Timer);
                        this.positionText(text, left, top, fColor, bColor);

                    }
                }
                else
                {
                    this.write("The numeric value of the timer is not correct", fColor, bColor);
                }

            }
            catch (DivideByZeroException e)
            {
                this.write("Divide by zero error ", fColor, bColor);
            }
            catch (Exception e)
            {
                this.write(e.Message.ToString(), fColor, bColor);
            }
        }
        /// <summary>
        ///  Text Arrow
        /// </summary>
        /// <param name="text">Text</param>
        /// <param name="countArrow">Count Arrow</param>
        /// <param name="arrowColor">Arrow Color</param>
        /// <param name="textColor">Text Color</param>
        /// <param name="newLine">New Line</param>
        public void arrow(string text, int countArrow, ConsoleColor arrowColor, ConsoleColor textColor, bool newLine = false)
        {
            if (!(countArrow <= 0))
            {
                string arrowLeft = string.Empty.PadLeft(countArrow, '>');
                string arrowRight = string.Empty.PadLeft(countArrow, '<');
                this.write(arrowLeft, arrowColor);
                this.write(text, textColor);
                this.write(arrowRight, arrowColor);
                if (newLine)
                {
                    Console.WriteLine();
                }
            }
            else
            {
                this.write("The numeric value is not valid", textColor);
            }

        }
        /// <summary>
        /// Text Arrow
        /// </summary>
        /// <param name="text">Text</param>
        /// <param name="countArrow">Count Arrow</param>
        /// <param name="arrowColor">Arrow Color</param>
        /// <param name="textColor">Text Color</param>
        /// <param name="left">Left</param>
        /// <param name="top">Top</param>
        /// <param name="newLine">New Line</param>
        public void arrow(string text, int countArrow, ConsoleColor arrowColor, ConsoleColor textColor, int left, int top, bool newLine = false)
        {
            if (countArrow >= 0)
            {
                if ((left >= 0) && (top >= 0))
                {
                    string arrowLeft = string.Empty.PadLeft(countArrow, '>');
                    string arrowRight = string.Empty.PadLeft(countArrow, '<');
                    this.positionText(arrowLeft, left, top, arrowColor);
                    this.positionText(text, (left + arrowLeft.Length), top, textColor);
                    this.positionText(arrowRight, (left + arrowLeft.Length + text.Length), top, arrowColor);
                    if (newLine)
                    {
                        Console.WriteLine();
                    }
                }
                else
                {
                    this.write("The numeric left or top value is not valid", textColor);
                }

            }
            else
            {
                this.write("The numeric value is not valid", textColor);
            }
        }
        /// <summary>
        /// Title line 
        /// </summary>
        /// <param name="text">Text</param>
        /// <param name="lineType">Line Type</param>
        /// <param name="lineColor">Line Color</param>
        /// <param name="textFColor">Forground Text</param>
        /// <param name="align">Align</param>
        public void TitleLine(string text, char lineType, ConsoleColor lineColor, ConsoleColor textFColor, Align align)
        {
            int maxWidth = Console.WindowWidth;
            int countLine = 0;
            int div = 0;

            string temp = "[" + text + "]";
            string line = string.Empty;
            countLine = maxWidth - temp.Length;
            div = countLine / 2;

            if (align == Align.LEFT)
            {
                line = string.Empty.PadLeft(countLine, lineType);
                this.write(temp, textFColor);
                this.write(line, lineColor);

            }
            else if (align == Align.RIGHT)
            {
                line = string.Empty.PadLeft(countLine, lineType);
                this.write(line, lineColor);
                this.write(temp, textFColor);
            }
            else if (align == Align.CENTRT)
            {
                line = string.Empty.PadLeft(div, lineType);
                this.write(line, lineColor);
                this.write(temp, textFColor);
                this.write(line, lineColor);
            }
        }
        /// <summary>
        /// Title line 
        /// </summary>
        /// <param name="text">Text</param>
        /// <param name="lineType">Line Type</param>
        /// <param name="lineColor">Line Color</param>
        /// <param name="textFColor">Forground Text</param>
        /// <param name="textBColor">Background Text</param>
        /// <param name="align">Align</param>
        public void TitleLine(string text, char lineType, ConsoleColor lineColor, ConsoleColor textFColor, ConsoleColor textBColor, Align align)
        {
            int maxWidth = Console.WindowWidth;
            int countLine = 0;
            int div = 0;

            string temp = "[" + text + "]";
            string line = string.Empty;
            countLine = maxWidth - temp.Length;
            div = countLine / 2;

            if (align == Align.LEFT)
            {
                line = string.Empty.PadLeft(countLine, lineType);
                this.write(temp, textFColor, textBColor);
                this.write(line, lineColor);

            }
            else if (align == Align.RIGHT)
            {
                line = string.Empty.PadLeft(countLine, lineType);
                this.write(line, lineColor);
                this.write(temp, textFColor, textBColor);
            }
            else if (align == Align.CENTRT)
            {
                line = string.Empty.PadLeft(div, lineType);
                this.write(line, lineColor);
                this.write(temp, textFColor, textBColor);
                this.write(line, lineColor);
            }
        }



    }
}
