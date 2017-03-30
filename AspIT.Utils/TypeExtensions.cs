// Author: Mads Mikkel Rasmussen.

using System;
using System.Collections.Generic;
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
        /// Determines if a specified type is a numeric type, i.e. one of the CLR primitive numeric types, or a numeris type in <see cref="System.Numerics"/>.
        /// </summary>
        /// <param name="type">The type to check.</param>
        /// <returns>A <see cref="bool"/> that indicates whether or not the specified type was a numeric type.</returns>
        public static bool IsNumeric(this ValueType type) =>
            type is byte || type is sbyte ||
            type is ushort || type is short ||
            type is uint || type is int ||
            type is ulong || type is long ||
            type is float || type is double || type is decimal ||
            type is System.Numerics.BigInteger ||
            type is System.Numerics.Complex ||
            DefinesNumericOperators(type);

        /// <summary>
        /// Indicates whether or not a declared type defines arithmetic, relation and equality operators by overloaded operators.
        /// </summary>
        /// <param name="valueType">The type of type <see cref="ValueType"/> to check.</param>
        /// <returns>a <see cref="bool"/> indicating the result of the check.</returns>
        internal static bool DefinesNumericOperators(this ValueType valueType)
        {
            bool isWellDefinedNumericType = false;
            string[] interfaces = { "" };
            const string prefix = "op_";
            string[] operatorNames = { "Equality", "Inequality", "GreaterThan", "LessThan", "GreaterThanOrEqual", "LessThanOrEqual", "Addition", "Subtraction", "Multiply", "Division", "Multiply", "UnaryPlus", "UnaryNegation" };
            MethodInfo[] methods = valueType.GetType().GetMethods();
            Type[] implementedInterfaces = valueType.GetType().GetInterfaces();


            List<string> specialNames = new List<string>(0);
            foreach (MethodInfo methodInfo in methods)
            {
                if (methodInfo.IsSpecialName)
                {
                    specialNames.Add(methodInfo.Name);
                }
            }
            if (specialNames.Count > 0)
            {
                bool missingOperator = false;
                foreach (string operatorName in operatorNames)
                {
                    if (!specialNames.Contains(String.Concat(prefix, operatorName)))
                    {
                        missingOperator = true;
                        break;
                    }
                }
                if (!missingOperator)
                {
                    isWellDefinedNumericType = true;
                }
            }
            else
            {
                isWellDefinedNumericType = false;
            }
            return isWellDefinedNumericType;
        }
    }
}