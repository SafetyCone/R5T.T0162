using System;


namespace R5T.T0162.Z000
{
    public class TokenSeparators : ITokenSeparators
    {
        #region Infrastructure

        public static ITokenSeparators Instance { get; } = new TokenSeparators();


        private TokenSeparators()
        {
        }

        #endregion
    }
}
