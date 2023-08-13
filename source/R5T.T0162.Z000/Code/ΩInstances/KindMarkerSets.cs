using System;


namespace R5T.T0162.Z000
{
    public class KindMarkerSets : IKindMarkerSets
    {
        #region Infrastructure

        public static IKindMarkerSets Instance { get; } = new KindMarkerSets();


        private KindMarkerSets()
        {
        }

        #endregion
    }
}
