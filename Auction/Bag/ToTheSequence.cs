﻿using System;
namespace Auction.Bag {
    public static class ToTheSequence {
        public static void OfGrowing<T>(ref T min, ref T max) where T : IComparable {
            if (min.CompareTo(max) <= 0) return;
            var d = min;
            min = max;
            max = d;
        }

    }
}


