using System;

using R5T.T0132;


namespace R5T.T0162
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public MethodIdentityName ToMethodIdentityName_WithoutValidation(string value)
        {
            var methodIdentityName = new MethodIdentityName(value);
            return methodIdentityName;
        }

        public TypeIdentityName ToTypeIdentityName_WithoutValidation(string value)
        {
            var typeIdentityName = new TypeIdentityName(value);
            return typeIdentityName;
        }
    }
}
