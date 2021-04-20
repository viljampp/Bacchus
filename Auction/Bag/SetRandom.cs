﻿using System;
using System.Collections;
using System.Linq;
namespace Auction.Bag {
    public static class SetRandom {
        public static void Values(object o) {
            if (o is null) return;
            if (o is IList list) setValuesForList(list);
            else setValuesForProperties(o);
        }
        private static void setValuesForProperties(object o) {
            if (o is null) return;
            foreach (var p in GetClass.Properties(o.GetType())) {
                if (!p.CanWrite) return;
                var v = GetRandom.Value(p.PropertyType);
                p.SetValue(o, v);
            }
        }
        private static void setValuesForList(IList l) {
            if (l is null) return;
            var t = getListElementsType(l);
            for (var c = 0; c <= GetRandom.UInt8(3, 5); c++) {
                var v = GetRandom.Value(t);
                l.Add(v);
            }
        }
        private static Type getListElementsType(IList list) {
            return Safe.Run(() => {
                var t = list.GetType();
                var types =
                (from method in t.GetMethods()
                    where method.Name == "get_Item"
                    select method.ReturnType
                ).Distinct().ToArray();
                return types[0];
            }, null);
        }
    }
}



