using System;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// A reserve auction has a minimum reserve price that must be met before
    /// the bid is considered worthy.
    /// </summary>
    public class ReserveAuction : Auction
    {
 
        //constructor  ReserveAuction(int reservePrice)

        public ReserveAuction(int reservePrice)
        {
            this.ReservePrice = reservePrice;
        }

        private int ReservePrice { get; set; }

        //override the parent's PlaceBiD method

        public override bool PlaceBid(Bid offeredBid)
        {
            if (offeredBid.BidAmount >= ReservePrice)
            {
                return base.PlaceBid(offeredBid);
            }
            else
            {
                Console.WriteLine("Bid did not match or exceed reserve price.");
                return false;
            }

        }

        //bids are only considerd if they equal or exceed the reserve price
       
    }
}
