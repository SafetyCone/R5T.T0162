using System;

using R5T.T0150;


namespace R5T.T0162
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class PropertyIdentityName : IdentityName, IStrongTypeMarker
    {
        public PropertyIdentityName(string value)
            : base(value)
        {
        }
    }
}
