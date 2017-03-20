using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.Utils.Numerics
{
    public static class MathExtension
    {
        /// <summary>
        /// Doubles a <see cref="byte" /> value.
        /// </summary>
        /// <param name="value">The value beign doubled</param>
        /// <returns>An <see cref="ushort"/> with a doubled value.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static ushort Double(byte value)
        {
            uint c = (uint)value + value;
            return (ushort)c;
        }

        /// <summary>
        /// Doubles a <see cref="sbyte" /> value.
        /// </summary>
        /// <param name="value">The value beign doubled</param>
        /// <returns>An <see cref="int"/> with a doubled value.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static short Double(sbyte value)
        {
            int x = value + value;
            return (short)x;
        }

        /// <summary>
        /// Doubles a <see cref="ushort" /> value.
        /// </summary>
        /// <param name="value">The value beign doubled</param>
        /// <returns>An <see cref="uint"/> with a doubled value.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static uint Double(ushort value) => (uint)value + value;

        /// <summary>
        /// Doubles a <see cref="short" /> value.
        /// </summary>
        /// <param name="value">The value beign doubled</param>
        /// <returns>An <see cref="int"/> with a doubled value.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int Double(short value) => value + value;

        /// <summary>
        /// Doubles a <see cref="uint" /> value.
        /// </summary>
        /// <param name="value">The value beign doubled</param>
        /// <returns>An <see cref="ulong"/> with a doubled value.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static ulong Double(uint value) => value + value;

        /// <summary>
        /// Doubles a <see cref="int" /> value.
        /// </summary>
        /// <param name="value">The value beign doubled</param>
        /// <returns>An <see cref="long"/> with a doubled value.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static long Double(int value) => value + value;

        /// <summary>
        /// Doubles a <see cref="ulong" /> value.
        /// </summary>
        /// <param name="value">The value beign doubled</param>
        /// <returns>An <see cref="double"/> with a doubled value.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static double Double(ulong value) => value + value;

        /// <summary>
        /// Doubles a <see cref="long" /> value.
        /// </summary>
        /// <param name="value">The value beign doubled</param>
        /// <returns>An <see cref="double"/> with a doubled value.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static double Double(long value) => value + value;

        /// <summary>
        /// Doubles a <see cref="float" /> value.
        /// </summary>
        /// <param name="value">The value beign doubled</param>
        /// <returns>An <see cref="float"/> with a doubled value.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static float Double(float value) => value + value;

        /// <summary>
        /// Doubles a <see cref="double" /> value.
        /// </summary>
        /// <param name="value">The value beign doubled</param>
        /// <returns>An <see cref="double"/> with a doubled value.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static double Double(double value) => value + value;

        /// <summary>
        /// Doubles a <see cref="decimal" /> value.
        /// </summary>
        /// <param name="value">The value beign doubled</param>
        /// <returns>An <see cref="decimal"/> with a doubled value.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static decimal Double(decimal value) => value + value;
    }
}
