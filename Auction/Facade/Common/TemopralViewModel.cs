using System;
using System.ComponentModel;
using Auction.Core;
namespace Auction.Facade.Common
{
    public abstract class TemporalViewModel : RootObject
    {
        [DisplayName("Valid From")]
        public DateTime? ValidFrom { get; set; }

        [DisplayName("Valid To")]
        public DateTime? ValidTo { get; set; }
    }
}
