using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0162
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class IdentityName : TypedString, IStrongTypeMarker
    {
        public IdentityName(string value)
            : base(value)
        {
        }
    }
}
