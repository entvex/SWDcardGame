using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    public enum Colors
    {
        Red = 1,
        Blue = 2,
        Green =3,
        Yellow =4
    }

    public class Card
    {

        Card(Colors col , int No )
        {
            CardCol = col;
            CardNo = No;
        }

        public Colors CardCol { get; }
        int CardNo { get; }

        

        public int GetCardValue()
        {
            return (int) CardCol* CardNo;
        }

        public void PrintCard()
        {
            Console.WriteLine(CardCol + " " + CardNo);
        }
    }


}

