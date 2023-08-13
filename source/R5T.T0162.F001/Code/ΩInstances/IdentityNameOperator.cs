using System;


namespace R5T.T0162.F001
{
    public class IdentityNameOperator : IIdentityNameOperator
    {
        #region Infrastructure

        public static IIdentityNameOperator Instance { get; } = new IdentityNameOperator();


        private IdentityNameOperator()
        {
        }

        #endregion
    }
}
