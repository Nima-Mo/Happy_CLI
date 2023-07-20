namespace Happy_CLI
{
    public class AdvText
    {
        private int _posLeft;
        private int _posTop;

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
        public void positionText(string text, int left, int top,ConsoleColor fcolor)
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
        public void positionText(string text, int left, int top, ConsoleColor fcolor,ConsoleColor bcolor)
        {
            Console.SetCursorPosition(left, top);
            this.write(text, fcolor,bcolor);
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
            Console.SetCursorPosition(Left, Top);
            Console.Write(text);
        }
        /// <summary>
        /// Print text in continuous position
        /// </summary>
        /// <param name="text">Input Text</param>
        /// <param name="left">Left Position</param>
        /// <param name="top">Top Position</param>
        /// <param name="fColor">ForGround Color</param>
        public void positionTextAt(string text, int left, int top,ConsoleColor fColor)
        {
            int Left = this._posLeft + left;
            int Top = this._posTop + top;
            Console.SetCursorPosition(Left, Top);
            Console.ForegroundColor = fColor;
            Console.Write(text);
            Console.ResetColor();
        }
        /// <summary>
        /// Print text in continuous position
        /// </summary>
        /// <param name="text">Input Text</param>
        /// <param name="left">Left Position</param>
        /// <param name="top">Top Position</param>
        /// <param name="fColor">ForGround Color</param>
        /// <param name="bColor">Background Color</param>
        public void positionTextAt(string text, int left, int top, ConsoleColor fColor,ConsoleColor bColor)
        {
            int Left = this._posLeft + left;
            int Top = this._posTop + top;
            Console.SetCursorPosition(Left, Top);
            Console.ForegroundColor = fColor;
            Console.BackgroundColor = bColor;
            Console.Write(text);
            Console.ResetColor();
        }

    }
}
