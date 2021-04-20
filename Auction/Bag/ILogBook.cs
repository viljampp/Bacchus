using System;
namespace Auction.Bag {

    public interface ILogBook {
        void WriteEntry(string message);

        void WriteEntry(Exception e);
    }

}


