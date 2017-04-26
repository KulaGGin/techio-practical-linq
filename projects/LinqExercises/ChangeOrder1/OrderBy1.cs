﻿using System.Collections.Generic;
using System.Linq;

namespace ChangeOrder1
{
    //// START UNCOMMENT ////
    //public interface Name
    //{
    //    string First { get; }
    //    string Middle { get; }
    //    string Last { get; }
    //}
    //// END UNCOMMENT ////
    //// START SOLUTION ////
    public interface Name
    {
        string First { get; }
        string Middle { get; }
        string Last { get; }
    }
    //// END SOLUTION ////

    public static class OrderBy1
    {
        // Return the provided list of names, ordered by Last, in
        // descending order.
        public static IEnumerable<Name> SortNames(IEnumerable<Name> names)
        {
            // Uncomment:
            // return names.???();
            //// START SOLUTION ////
            return names.OrderByDescending(_ => _.Last);
            //// END SOLUTION ////
        }
    }
}