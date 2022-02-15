namespace TestDotNetPoc.Logic
{
    //TODO: TO MOVE AN ISOLATED PROJECT SINCE THIS CLASS SHOULD NOT BE PART OF A UNIT TEST PROJECT, THIS IS ONLY FOR TESTING PURPOSES
    public class Calculator
    {
        public decimal Value { get; private set; }

        /// <summary>
        /// Sum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public decimal Add(decimal value)
        {
            return Value += value;
        }

        /// <summary>
        /// Subtraction
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public decimal Substract(decimal value)
        {
            return Value -= value;
        }

        /// <summary>
        /// Multiplication
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public decimal Multiply(decimal value)
        {
            if (Value == 0)
            {
                return Value = value;
            }

            return Value *= value;
        }

        /// <summary>
        /// Division 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public decimal Divide(decimal value)
        {
            if (Value == 0)
            {
                return Value = value;
            }

            return Value /= value;
        }
    }
}
