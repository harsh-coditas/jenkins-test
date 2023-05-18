using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Helpers.PhoneSys
{
    public static class PhoneSys
    {
        public static string KeypadEquiv(string Text)
        {

            /*  translate character by character  */

            string Result = "";
            foreach (char Element in Text)
                switch (Char.ToUpper(Element))
                {
                    case '1':
                        Result += '1';
                        break;

                    case '2':
                    case 'A':
                    case 'B':
                    case 'C':
                        Result += '2';
                        break;

                    case '3':
                    case 'D':
                    case 'E':
                    case 'F':
                        Result += '3';
                        break;

                    case '4':
                    case 'G':
                    case 'H':
                    case 'I':
                        Result += '4';
                        break;

                    case '5':
                    case 'J':
                    case 'K':
                    case 'L':
                        Result += '5';
                        break;

                    case '6':
                    case 'M':
                    case 'N':
                    case 'O':
                        Result += '6';
                        break;

                    case '7':
                    case 'P':
                    case 'Q':
                    case 'R':
                    case 'S':
                        Result += '7';
                        break;

                    case '8':
                    case 'T':
                    case 'U':
                    case 'V':
                        Result += '8';
                        break;

                    case '9':
                    case 'W':
                    case 'X':
                    case 'Y':
                    case 'Z':
                        Result += '9';
                        break;

                    case '0':
                    case ' ':
                        Result += '0';
                        break;

                    default:
                        return "";
                }

            /*  done  */

            return Result;
        }

    }
}
