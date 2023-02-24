using System;

using R5T.T0150;


namespace R5T.T0162
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class EventIdentityName : IdentityName, IStrongTypeMarker
    {
        public EventIdentityName(string value)
            : base(value)
        {
        }
    }
}
