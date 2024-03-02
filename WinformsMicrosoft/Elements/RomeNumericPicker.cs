using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsMicrosoft.Elements
{
    public class RomeNumericPicker : System.Windows.Forms.NumericUpDown
    {
        public decimal Maximum { get; set; } = 3;
        public decimal Minimum { get; set; } = 1;


        public override string Text
        {
            get
            {
                return ToRoman((int)base.Value);
            }
            set
            {
                base.Value = FromRoman(value);
            }
        }

        private string ToRoman(int num)
        {
            switch(num)
            {
                case 1: return "I";
                case 2: return "II";
                case 3: return "III";
                default: return "";
            }
        }

        private int FromRoman(string roman)
        {
            switch(roman)
            {
                case "I": return 1;
                case "II": return 2;
                case "III": return 3;
                default: return 1;
            }
        }

    }
}
