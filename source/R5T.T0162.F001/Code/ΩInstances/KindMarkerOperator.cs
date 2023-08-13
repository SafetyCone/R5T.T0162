using System;


namespace R5T.T0162.F001
{
    public class KindMarkerOperator : IKindMarkerOperator
    {
        #region Infrastructure

        public static IKindMarkerOperator Instance { get; } = new KindMarkerOperator();


        private KindMarkerOperator()
        {
        }

        #endregion
    }
}
