using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace AspIT.Utils.Collections
{
    /// <summary>
    /// A dictionary specialized for unit testing. Inherits <see cref="OrderedDictionary"/>.
    /// Is immutable.
    /// </summary>
    /// <typeparam name="TKey">The type of test values.</typeparam>
    /// <typeparam name="TValue">The type of result of the testing of the test value. 
    /// Must be a value type.</typeparam>
    public class TestDictionary<TKey, TValue> : OrderedDictionary where TValue : struct
    {

        #region Fields
        /// <summary>
        /// Contains all test values that did not pass a test, along with their index in this 
        /// <see cref="TestDictionary{TKey, TValue}"/>.
        /// </summary>
        protected OrderedDictionary failedTestValues;

        /// <summary>
        /// Indicates whether function members on this instance was invoked
        /// </summary>
        protected bool testWasRun;
        #endregion


        #region Constructors
        /// <summary>
        /// Initializes a new instance of this type with the provided collection of test values and
        /// initial test result values.
        /// </summary>
        /// <param name="testValues">A collection of values to use as test data.</param>
        /// <param name="testResults">A collection of initial test result values.</param>
        /// <exception cref="ArgumentException"/>
        /// <exception cref="ArgumentNullException"/>
        /// <exception cref="ArgumentOutOfRangeException"/>
        public TestDictionary(List<TKey> testValues, List<TValue> testResults = null) : base()
        {
            int numberOfTestValues;
            if (testValues == null)
            {
                throw new ArgumentNullException(nameof(testValues));
            }
            numberOfTestValues = testValues.Count;
            if (testResults != null)
            {
                if (testResults.Count != numberOfTestValues)
                {
                    throw new ArgumentException(nameof(testResults), @"Number of test results must 
                        equal the number of test values");
                }
            }
            else
            {
                testResults = new List<TValue>(numberOfTestValues);
                foreach (TValue testResult in testResults)
                {
                    testResults.Add(default(TValue));
                }
            }
            this.Add(testValues, testResults);
        }
        #endregion


        #region Methods
        /// <summary>
        /// Adds the specified range og test values and the specified range of test results to the
        /// dictionary. They must have equal length.
        /// </summary>
        /// <param name="testValues">The list of test values.</param>
        /// <param name="testResults">The list of test results.</param>
        /// <exception cref="ArgumentNullException"/>
        /// <exception cref="ArgumentOutOfRangeException"/>
        public virtual void Add(List<TKey> testValues, List<TValue> testResults)
        {
            string argEx = nameof(testValues) + " or " + nameof(testResults);
            if (testValues == null || testResults == null)
            {
                throw new ArgumentNullException(argEx);
            }
            else if (testValues.Count != testResults.Count)
            {
                throw new ArgumentOutOfRangeException(argEx, "Both lists must have equal length");
            }
            else if (testValues.Count < 1 || testResults.Count < 1)
            {
                throw new ArgumentOutOfRangeException(argEx, "No values to test.");
            }
            int i = 0, length = testValues.Count;
            while (i < length)
            {
                base.Add(testValues[i], testResults[i]);
                i++;
            }

        }

        /// <summary>
        /// Replaces a test result at the specified index with the provided new test result.
        /// </summary>
        public virtual void ReplaceTestResultAt(int index, TValue newTestResult)
        {
            this[index] = newTestResult;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"Count: {base.Count.ToString()}";
        }

        /// <summary>
        /// Determines if all test result are the same. Uses value equality.
        /// </summary>
        /// <param name="expectedTestResult">The expected test result value.</param>
        /// <returns>A <see cref="bool"/> indicating whether or not all test result values are 
        /// equal.</returns>
        public virtual bool AllTestResultsAreSame(TValue expectedTestResult)
        {
            foreach (TValue testResult in base.Values)
            {
                if (!testResult.Equals(expectedTestResult))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Gets the key element at the specified index.
        /// </summary>
        /// <param name="index">The index of the key.</param>
        /// <returns>The key at the index</returns>
        public virtual TKey GetTestValueAt(int index)
        {
            TKey[] keyArray = new TKey[base.Keys.Count];
            Keys.CopyTo(keyArray, 0);
            return keyArray[index];
        }
        #endregion


        #region Properties
        /// <summary>
        /// Gets a <see cref="OrderedDictionary"/> containing all failed test values, with their
        /// corresponding key index in this <see cref="TestDictionary{TKey, TValue}"/>.
        /// </summary>
        public virtual OrderedDictionary FailedTestValues
        {
            get
            {
                if (testWasRun)
                {
                    return failedTestValues;
                }
                else return default(OrderedDictionary);
            }
        }
        #endregion


        #region Indexers
        /// <summary>
        /// Gets or sets the <see cref="TValue"/> to or from the provided index.
        /// </summary>
        /// <param name="index">The index in <see cref="OrderedDictionary.Values"/>.</param>
        /// <returns>The <see cref="TValue"/> at the specified index.</returns>
        /// <exception cref="IndexOutOfRangeException"/>
        public new virtual TValue this[int index]
        {
            get
            {
                if (index < 0)
                {
                    throw new IndexOutOfRangeException(nameof(index));
                }
                return (TValue)base[index];
            }
            set
            {
                if (index < 0)
                {
                    throw new IndexOutOfRangeException(nameof(index));
                }
                base[index] = value;
            }
        }

        /// <summary>
        /// This indexer is not supported. It hides the inherited indexer.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException"/>
        public new TValue this[object key]
        {
            get
            {
                throw new NotSupportedException();
            }
            set
            {
                throw new NotSupportedException();
            }
        }
        #endregion
    }
}