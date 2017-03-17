// Author: Mads Mikkel Rasmussen.

using System;
using System.Reflection;

#if DEBUG
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("AspIT.Utils.Tests")]
#endif

namespace AspIT.Utils
{
    /// <summary>
    /// Checks types.
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// Determines is a specified type i a numeric type.
        /// </summary>
        /// <param name="type">The type to check.</param>
        /// <returns>A <see cref="bool"/> that indicates whether or not the specified type was a numeric type.</returns>
        public static bool IsNumeric(this ValueType type) =>
            type is byte || type is sbyte ||
            type is ushort || type is short ||
            type is uint || type is int ||
            type is ulong || type is long ||
            type is float || type is double || type is decimal ||
            type is System.Numerics.BigInteger || type is System.Numerics.Complex; //||
                                                                                   //!DefinesNumericOperators(type);

        /// <summary>
        /// Indicates whether or not a declared type defines arithmetic, relation and equality operators by overloaded operators.
        /// </summary>
        /// <param name="valueType">The type of type <see cref="ValueType"/> to check.</param>
        /// <returns>a <see cref="bool"/> indicating the result of the check.</returns>
        internal static bool DefinesNumericOperators(ValueType valueType)
        {
            bool isWellDefinedNumericType = false;
            string[] operators = new string[] { "+", "-", "*", "/", "<", "<=", ">", ">=", "==", "!=" };



            return isWellDefinedNumericType;
        }
    }
}