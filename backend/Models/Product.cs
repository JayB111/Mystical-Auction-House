using System;

namespace AuctionAPI.Models
{
    public class Product
    {
        public int Id { get; set; }  // Product ID
        public string Name { get; set; }  // Name of item
        public string Description { get; set; }  // Details about the item
        public decimal StartingPrice { get; set; }  // Auction starting price
        public decimal CurrentPrice { get; set; }  // Current highest bid
        public DateTime AuctionEndTime { get; set; }  // When auction ends
        public bool IsSold { get; set; }  // True if the auction is over
        public string ImageFileName { get; set; }  // Filename for the product image
    }
}
