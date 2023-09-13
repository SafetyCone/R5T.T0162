using System;

using R5T.T0131;


namespace R5T.T0162.Z000
{
    [ValuesMarker]
    public partial interface ITokenSeparators : IValuesMarker
    {
        /// <summary>
        /// <para>',' (comma)</para>
        /// </summary>
        public const char ArgumentListSeparator_Constant = ',';

        /// <inheritdoc cref="ArgumentListSeparator_Constant"/>
        public char ArgumentListSeparator => ArgumentListSeparator_Constant;

        /// <summary>
        /// <para>'@' (at-sign, a.k.a. alphasands)</para>
        /// </summary>
        public const char ByReferenceMarker_Constant = '@';

        /// <inheritdoc cref="ByReferenceMarker_Constant"/>
        public char ByReferenceMarker => ByReferenceMarker_Constant;

        /// <summary>
        /// <para>'#' (hash)</para>
        /// Separates the namespaced type name parts of an explicitly implemented name.
        /// </summary>
        public const char ExplicitImplementationNamespaceTokenSeparator_Constant = '#';

        /// <inheritdoc cref="ExplicitImplementationNamespaceTokenSeparator_Constant"/>
        public char ExplicitImplementationNamespaceTokenSeparator => ExplicitImplementationNamespaceTokenSeparator_Constant;


        /// <summary>
        /// <para>':' (colon)</para>
        /// Separates the first character (which is the kind marker_ from the rest of the identity name (which is the identity name value).
        /// </summary>
        public const char KindMarkerSeparator_Constant = ':';

        /// <inheritdoc cref="KindMarkerSeparator_Constant"/>
        public char KindMarkerSeparator => KindMarkerSeparator_Constant;


        /// <summary>
        /// <para>'{' (open-brace)</para>
        /// </summary>
        public const char TypeArgumentListOpenSeparator_Constant = '{';

        /// <inheritdoc cref="TypeArgumentListOpenSeparator_Constant"/>
        public char TypeArgumentListOpenSeparator => TypeArgumentListOpenSeparator_Constant;

        /// <summary>
        /// <para>'}' (close-brace)</para>
        /// </summary>
        public const char TypeArgumentListCloseSeparator_Constant = '}';

        /// <inheritdoc cref="TypeArgumentListCloseSeparator_Constant"/>
        public char TypeArgumentListCloseSeparator => TypeArgumentListCloseSeparator_Constant;

        /// <summary>
        /// <para>'`' (back-tick)</para>
        /// Separates the namespaced type name for type names (or namespaced typed method name for method names)
        /// from the type parameter count and then the rest of the identity name value.
        /// </summary>
        public const char TypeParameterCountSeparator_Constant = '`';

        /// <inheritdoc cref="TypeParameterCountSeparator_Constant"/>
        public char TypeParameterCountSeparator => TypeParameterCountSeparator_Constant;

        /// <summary>
        /// <para>'`1' (two back-ticks)</para>
        /// </summary>
        public const string MethodTypeParameterCountSeparator_Constant = "``";

        /// <inheritdoc cref="MethodTypeParameterCountSeparator_Constant"/>
        public string MethodTypeParameterCountSeparator => MethodTypeParameterCountSeparator_Constant;

        /// <summary>
        /// <para>'.' (period)</para>
        /// Separates tokens in a namespaced name (namespace name, namespaced type name) from each other.
        /// </summary>
        public const char NamespaceTokenSeparator_Constant = '.';

        /// <inheritdoc cref="NamespaceTokenSeparator_Constant"/>
        public char NamespaceTokenSeparator => NamespaceTokenSeparator_Constant;

        /// <summary>
        /// <para>'~' (tilde)</para>
        /// Separates the namespaced, typed, argumented, method name from its output type.
        /// Used for implicit and explicit operator methods.
        /// </summary>
        public const char OutputTypeTokenSeparator_Constant = '~';

        /// <inheritdoc cref="OutputTypeTokenSeparator_Constant"/>
        public char OutputTypeTokenSeparator => OutputTypeTokenSeparator_Constant;

        /// <summary>
        /// <para>'(' (open-parenthesis)</para>
        /// Separates the namespaced, typed, method name from its parameter list.
        /// </summary>
        public const char ParameterListOpenTokenSeparator_Constant = '(';

        /// <inheritdoc cref="ParameterListOpenTokenSeparator_Constant"/>
        public char ParameterListOpenTokenSeparator => ParameterListOpenTokenSeparator_Constant;

        /// <summary>
        /// <para>')' (close-parenthesis)</para>
        /// Closes the parameter list for a method identity name.
        /// </summary>
        public const char ParameterListCloseTokenSeparator_Constant = ')';

        /// <inheritdoc cref="ParameterListCloseTokenSeparator_Constant"/>
        public char ParameterListCloseTokenSeparator => ParameterListCloseTokenSeparator_Constant;
    }
}
