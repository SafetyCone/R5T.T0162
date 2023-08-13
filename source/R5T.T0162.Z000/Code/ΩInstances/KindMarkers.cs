using System;


namespace R5T.T0162.Z000
{
    public class KindMarkers : IKindMarkers
    {
        #region Infrastructure

        public static IKindMarkers Instance { get; } = new KindMarkers();


        private KindMarkers()
        {
        }

        #endregion
    }
}
