using System;


namespace R5T.T0162.Z000
{
    public class MemberKindMarkers : IMemberKindMarkers
    {
        #region Infrastructure

        public static IMemberKindMarkers Instance { get; } = new MemberKindMarkers();


        private MemberKindMarkers()
        {
        }

        #endregion
    }
}
