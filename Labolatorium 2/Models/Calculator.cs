namespace Labolatorium_2.Models
{
    public class Calculator
    {
        public Operators? Operator { get; set; }
            

            public double? x { get; set; }

            public double? y { get; set; }

        private Dictionary<Operators, string> _opDict = new Dictionary<Operators, string>()
        {
            { Operators.add, "+"},
            { Operators.sub, "-"},
            { Operators.mul, "&times;"},
            { Operators.div, "$divide;"}
        };

        public string Op 
        {
            get
            {
                return _opDict[Operator??Operators.add];
            }
        }

        public bool IsValid()
        {
            return Operator != null && x != null && y != null;
        }

        public double Calculate()
        {
            if (Operator == Operators.add)
            {
                return (double)(x + y);
            }
            else if (Operator == Operators.sub)
            {
                return (double)(x - y);
            }
            else if (Operator == Operators.mul)
            {
                return (double)(x * y);
            }
            else if (Operator == Operators.div)
            {
                if (y == 0)
                {
                    return double.NaN;
                }
                else
                {
                    return (double)(x / y);
                }
            }
            else
            {
                return double.NaN;
            }
        }


    }
}
