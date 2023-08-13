using System;

using R5T.T0131;
using R5T.T0162;
using R5T.T0162.Extensions;


namespace R5T.T0162.Z000
{
    /// <summary>
    /// <inheritdoc cref="T0162.Documentation.See_IDStringsInMSDocs" path="/summary"/>
    /// </summary>
    /// <remarks>
    /// Provides a constant (for use in switch statements), static instance (for memory efficiency), and instance properties (for instance-based access).
    /// Prior work: R5T.F0121, R5T.T0162.Z000.
    /// </remarks>
    [ValuesMarker]
    public partial interface IKindMarkers : IValuesMarker
    {
        /// <summary>
        /// '!'
        /// </summary>
        public const char Error_Constant = '!';

        /// <inheritdoc cref="Error_Constant"/>
        public static readonly IKindMarker Error_Instance = Error_Constant.ToKindMarker();

        /// <inheritdoc cref="Error_Constant"/>
        public IKindMarker Error => Error_Instance;

        /// <summary>
        /// 'E'
        /// </summary>
        public const char Event_Constant = 'E';

        /// <inheritdoc cref="Event_Constant"/>
        public static readonly IKindMarker Event_Instance = Event_Constant.ToKindMarker();

        /// <inheritdoc cref="Event_Constant"/>
        public IKindMarker Event => Event_Instance;

        /// <summary>
        /// 'F'
        /// </summary>
        public const char Field_Constant = 'F';

        /// <inheritdoc cref="Field_Constant"/>
        public static readonly IKindMarker Field_Instance = Field_Constant.ToKindMarker();

        /// <inheritdoc cref="Field_Constant"/>
        public IKindMarker Field => Field_Instance;

        /// <summary>
        /// 'M'
        /// </summary>
        public const char Method_Constant = 'M';

        /// <inheritdoc cref="Method_Constant"/>
        public static readonly IKindMarker Method_Instance = Method_Constant.ToKindMarker();

        /// <inheritdoc cref="Method_Constant"/>
        public IKindMarker Method => Method_Instance;

        /// <summary>
        /// 'N'
        /// </summary>
        public const char Namespace_Constant = 'N';

        /// <inheritdoc cref="Namespace_Constant"/>
        public static readonly IKindMarker Namespace_Instance = Namespace_Constant.ToKindMarker();

        /// <inheritdoc cref="Namespace_Constant"/>
        public IKindMarker Namespace => Namespace_Instance;

        /// <summary>
        /// 'P'
        /// </summary>
        public const char Property_Constant = 'P';

        /// <inheritdoc cref="Property_Constant"/>
        public static readonly IKindMarker Property_Instance = Property_Constant.ToKindMarker();

        /// <inheritdoc cref="Property_Constant"/>
        public IKindMarker Property => Property_Instance;

        /// <summary>
        /// 'T'
        /// </summary>
        public const char Type_Constant = 'T';

        /// <inheritdoc cref="Type_Constant"/>
        public static readonly IKindMarker Type_Instance = Type_Constant.ToKindMarker();

        /// <inheritdoc cref="Type_Constant"/>
        public IKindMarker Type => Type_Instance;
    }
}
