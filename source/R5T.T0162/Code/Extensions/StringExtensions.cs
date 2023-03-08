using System;


namespace R5T.T0162.Extensions
{
    public static class StringExtensions
    {
        public static MethodIdentityName ToMethodIdentityName(this string value)
        {
            var methodIdentityName = Instances.StringOperator.ToMethodIdentityName_WithoutValidation(value);
            return methodIdentityName;
        }

        public static TypeIdentityName ToTypeIdentityName(this string value)
        {
            var typeIdentityName = Instances.StringOperator.ToTypeIdentityName_WithoutValidation(value);
            return typeIdentityName;
        }
    }
}
