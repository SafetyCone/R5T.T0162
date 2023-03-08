using System;


namespace R5T.T0162
{
    public class StringOperator : IStringOperator
    {
        #region Infrastructure

        public static IStringOperator Instance { get; } = new StringOperator();


        private StringOperator()
        {
        }

        #endregion
    }
}
