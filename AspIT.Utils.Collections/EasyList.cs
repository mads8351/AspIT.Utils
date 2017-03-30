using System;
using System.Collections;
using System.Collections.Generic;

namespace AspIT.Utils.Collections
{
    /// <summary>
    /// Represents a linear data structure with both array and list like features.
    /// </summary>
    /// <typeparam name="T">The type of objects contained in the list.</typeparam>
    public class EasyList<T> : IList<T>
    {

        #region Fields
        /// <summary>
        /// The internal array holding data.
        /// </summary>
        protected T[] internalArray;
        #endregion


        #region Constructors
        /// <summary>
        /// Initializes a new <see cref="EasyList{T}"/> with zero elements.
        /// </summary>
        public EasyList() : this(0) { }

        /// <summary>
        /// Initializes a new <see cref="EasyList{T}"/> with the specified capacity.
        /// </summary>
        /// <param name="capacity">The desired initial capacity of the <see cref="EasyList{T}"/>.</param>
        public EasyList(int capacity) : this(PopulateInternalArrayWithDefaults((uint)capacity))
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="capacity"></param>
        public EasyList(uint capacity) : this((int)capacity)
        {

        }

        public EasyList(IEnumerable collection)
        {

        }

        public EasyList(IEnumerable<T> collection)
        {

        }
        #endregion


        #region Methods
        protected static void InitializeInstance()
        {

        }

        protected static T[] PopulateInternalArrayWithDefaults(uint capacity)
        {
            T[] array = new T[capacity];
            for (uint i = 0; i < capacity; i++)
            {
                array[i] = default(T);
            }
            return array;
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion


        #region Properties
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        #endregion


        #region Indexers
        public virtual T this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        #endregion


        #region Operators

        #endregion

    }
}
