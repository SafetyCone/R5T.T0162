using System;


namespace R5T.T0162.Extensions
{
    public static class StringExtensions
    {
        public static IIdentityName ToIdentityName(this string value)
        {
            return Instances.StringOperator.ToIdentityName(value);
        }

        public static IMethodIdentityName ToMethodIdentityName(this string value)
        {
            return Instances.StringOperator.ToMethodIdentityName_WithoutValidation(value);
        }

        public static ITypeIdentityName ToTypeIdentityName(this string value)
        {
            return Instances.StringOperator.ToTypeIdentityName_WithoutValidation(value);
        }
    }
}
