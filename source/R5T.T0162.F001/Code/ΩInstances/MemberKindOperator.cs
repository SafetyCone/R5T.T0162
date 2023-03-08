using System;


namespace R5T.T0162.F001
{
    public class MemberKindOperator : IMemberKindOperator
    {
        #region Infrastructure

        public static IMemberKindOperator Instance { get; } = new MemberKindOperator();


        private MemberKindOperator()
        {
        }

        #endregion
    }
}


namespace R5T.T0162.F001.Internal
{
    public class MemberKindOperator : IMemberKindOperator
    {
        #region Infrastructure

        public static IMemberKindOperator Instance { get; } = new MemberKindOperator();


        private MemberKindOperator()
        {
        }

        #endregion
    }
}
