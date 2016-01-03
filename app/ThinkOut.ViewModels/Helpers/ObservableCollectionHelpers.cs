using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace ThinkOut.ViewModels
{
    public static class ObservableCollectionHelpers
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> enumerable)
        {
            var col = new ObservableCollection<T>();
            foreach (var cur in enumerable)
            {
                col.Add(cur);
            }
            return col;
        }
    }
}

