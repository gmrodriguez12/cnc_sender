using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_CNC
{
    public class GrblCommand
    {
        public string Line { get; set; }
        public Dictionary<string, Element> Helper { get; set; }
        public string CodeResult { get; set; }
        public int RepeatCount { get; set; }

        public bool JustBuilt
        {
            get { return Helper != null; }
        }

        public GrblCommand(string line)
        {
            if (!string.IsNullOrEmpty(line))
            {
                Line = line.ToUpper().Trim();
                RepeatCount = 0;
            }
        }

        public GrblCommand(string line, int repeat)
        {
            if (!string.IsNullOrEmpty(line))
            {
                Line = line.ToUpper().Trim();
                RepeatCount = repeat;
            }
        }

        public GrblCommand(IEnumerable<Element> elements)
        {
            Line = string.Empty;
            foreach(Element elm in elements)
            {
                Line = Line + elm.ToString() + " ";
            }

            Line = Line.TrimEnd().ToUpper();
        }

        public GrblCommand(Element first, GrblCommand toappend)
        {
            Line = $"{first} {toappend.Line}";
        }

        public bool IsGrblCommand
        {
            get { return Line.StartsWith("$"); } //TODO mejorar forma de validar grbl command
        }

        public enum CommandStatus
		{ Queued, WaitingResponse, ResponseGood, ResponseBad, InvalidResponse }

        public CommandStatus Status
        {
            get
            {
                if (CodeResult == null)
                    return CommandStatus.Queued;
                else if (CodeResult.Length == 0)
                    return CommandStatus.WaitingResponse;
                else if (CodeResult.StartsWith("OK"))
                    return CommandStatus.ResponseGood;
                else if (CodeResult.StartsWith("ERROR"))
                    return CommandStatus.ResponseBad;
                else
                    return CommandStatus.InvalidResponse;
            }
        }

        private void Add(Element element)
        {
            Helper.Add(element.Command, element);
        }

        public void BuildHelper()
        {
            if (JustBuilt)
                return;

            try
            {
                Helper = new Dictionary<string, Element>();
                char cmd = '\0';
                string num = "";
                bool comment = false;
                bool oldspace = false;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                if (!IsGrblCommand)
                {
                    foreach(char c in Line)
                    {
                        if (c == ';') 
                            break;

                        if (c == '(')
                            comment = true;

                        bool space = c == ' ' ? true : false;
                        if (!comment)
                        {
                            if (space && !oldspace)
                                sb.Append(' ');
                            else if (!space)
                                sb.Append(c);
                        }
                        oldspace = space;
                        
                        if(!comment)
                        {
                            if(Char.IsLetter(c))
                            {
                                if (cmd != '\0')
                                    Add(new Element(cmd.ToString(), Decimal.Parse(num, System.Globalization.NumberFormatInfo.InvariantInfo)));

                                cmd = c;
                                num = "";
                            }
                            else if(Char.IsNumber(c) || c == '.' || c == '-')
                            {
                                num += c;
                            }
                        }

                        Line = sb.ToString();

                        if (cmd != '\0')
                            Add(new Element(cmd.ToString(), Decimal.Parse(num, System.Globalization.NumberFormatInfo.InvariantInfo)));
                    }
                }
            }
            catch
            {
                //TODO Ver como sacar este catch empty
            }
        }
    }
}
