﻿using System;
using Auction.Bag;
namespace Auction.Core {
    public abstract class RootObject {
        protected internal string getString(ref string field, string value = Constants.Unspecified)
        {
            if (string.IsNullOrWhiteSpace(field)) field = (value ?? string.Empty).Trim();
            return field;
        }
        protected internal string getValue(ref string field, string value) {
            if (string.IsNullOrWhiteSpace(field)) field = (value ?? string.Empty).Trim();
            return field;
        }
        protected internal T getMinValue<T>(ref T field, ref T value) where T : IComparable {
            ToTheSequence.OfGrowing(ref field, ref value);
            return field;
        }
        protected internal T getMaxValue<T>(ref T field, ref T value) where T : IComparable {
            ToTheSequence.OfGrowing(ref value, ref field);
            return field;
        }
        public virtual bool Contains(string searchString) {
            if (string.IsNullOrEmpty(searchString)) return true;
            searchString = searchString.ToLower();
            var values = GetClass.ReadWritePropertyValues(this);
            foreach (var value in values) {
                if (value is null) continue;
                if (value.ToString().ToLower().Contains(searchString)) return true;
            }

            return GetType().Name.ToLower().Contains(searchString);
        }
    }
}




