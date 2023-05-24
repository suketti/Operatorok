using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorok
{
    public class Expression
    {
        int firstNum;
        string operand;
        int secondNum;


        public Expression(int firstNum, string operand, int secondNum)
        {
            this.firstNum = firstNum;
            this.operand = operand;
            this.secondNum = secondNum;
        }

        public int FirstNum { get => firstNum; set => firstNum = value; }
        public string Operand { get => operand; set => operand = value; }
        public int SecondNum { get => secondNum; set => secondNum = value; }
    }
}
