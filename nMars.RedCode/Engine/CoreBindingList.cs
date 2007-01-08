// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections;
using System.ComponentModel;
using nMars.RedCode;

namespace nMars.RedCode
{
    public interface ICoreBindingList : IBindingList
    {
        void InvalidateAll();
        void Invalidate(int index);
        void InvalidateEvents();
    }
    public interface ICoreBindingView
    {
        int this[int index] { get; }
        int Count { get; }
        bool IsFixedSize { get; }
    }


    public class CoreBindingList : ICoreBindingList
    {
        public CoreBindingList(IAsyncEngine aEngine, ICoreBindingView aView)
        {
            Engine = aEngine;
            view = aView;
        }

        private long maxVersion;
        private IAsyncEngine Engine;
        private ICoreBindingView view;
        private ListChangedEventHandler change;

        public void Invalidate(int index)
        {
            if (change != null && index >= 0 && index<Count)
                change.Invoke(this, new ListChangedEventArgs(ListChangedType.ItemChanged, index));
        }

        public void InvalidateAll()
        {
            if (change != null)
                change.Invoke(this, new ListChangedEventArgs(ListChangedType.Reset, 0));
        }

        public void InvalidateEvents()
        {
            long lmax = maxVersion;
            CoreEventRecord[] records = Engine.CoreEvents;
            for (int index = 0; index < Count;index++ )
            {
                int address = view[index];
                CoreEventRecord evn = records[address];
                long ver = evn.Version;
                if (ver > maxVersion)
                {
                    if (ver > lmax)
                    {
                        lmax = ver;
                    }
                    if (change != null)
                        change.Invoke(this, new ListChangedEventArgs(ListChangedType.ItemChanged, index));
                }
            }
            maxVersion = lmax;
        }

        public object this[int index]
        {
            get { return view[index]; }
            set { throw new NotImplementedException(); }
        }

        public bool IsFixedSize
        {
            get { return view.IsFixedSize; }
        }

        public int Count
        {
            get { return view.Count; }
        }

        #region IBindingList

        public event ListChangedEventHandler ListChanged
        {
            add { change += value; }
            remove { change -= value; }
        }

        public bool SupportsChangeNotification
        {
            get { return true; }
        }

        public bool IsReadOnly
        {
            get { return true; }
        }

        #region Not Implemented

        public object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        public object AddNew()
        {
            throw new NotImplementedException();
        }

        public void AddIndex(PropertyDescriptor property)
        {
            throw new NotImplementedException();
        }

        public void ApplySort(PropertyDescriptor property, ListSortDirection direction)
        {
            throw new NotImplementedException();
        }

        public int Find(PropertyDescriptor property, object key)
        {
            throw new NotImplementedException();
        }

        public void RemoveIndex(PropertyDescriptor property)
        {
            throw new NotImplementedException();
        }

        public void RemoveSort()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool AllowNew
        {
            get { return false; }
        }

        public bool AllowEdit
        {
            get { return false; }
        }

        public bool AllowRemove
        {
            get { return false; }
        }

        public bool SupportsSearching
        {
            get { return false; }
        }

        public bool SupportsSorting
        {
            get { return false; }
        }

        public bool IsSorted
        {
            get { throw new NotImplementedException(); }
        }

        public PropertyDescriptor SortProperty
        {
            get { throw new NotImplementedException(); }
        }

        public ListSortDirection SortDirection
        {
            get { throw new NotImplementedException(); }
        }

        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }


        #endregion

        #endregion
    }
}
