using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionMemoryDao();
            }
            else
            {
                dao = auctionDao;
            }
        }

        [HttpGet("ready")]
        public string Ready()
        {
            return "Server ready.";
        }

        [HttpGet()]
        public ActionResult<List<Auction>> ListAuctions(string title_like = "", double currentBid_lte = 0)
        {
            List<Auction> auction = new List<Auction>();

            if (title_like != "" && currentBid_lte > 0)
            {
                auction = dao.SearchByTitleAndPrice(title_like, currentBid_lte);
                return auction;
            }
            else if (title_like != "")
            {
                auction = dao.SearchByTitle(title_like);
                return auction;
            }
            else if (currentBid_lte > 0)
            {
                auction = dao.SearchByPrice(currentBid_lte);
                return auction;
            }
            return dao.List();
        }

        [HttpGet("{id}")]
        public ActionResult<Auction> GetAuctionById(int id)
        {
            Auction auction = dao.Get(id);

            if (auction != null)
            {
                return auction;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost()]
        public ActionResult<Auction> AddAuction(Auction auction)
        {
            Auction added = dao.Create(auction);
            return added;
        }

        //[HttpGet("filter")]
        //// GET /auctions/filter?title=<title>
        //public ActionResult<List<Auction>> GetAuctionByTitle(string title_like)
        //{
        //    List<Auction> filteredTitles = new List<Auction>();

        //    List<Auction> auctions = dao.SearchByTitle(title_like);
        //    foreach (Auction auction in auctions)
        //    {
        //        if (title_like != null)
        //        {
        //            if (auction.Title.ToLower().Equals(title_like.ToLower()))
        //            {
        //                filteredTitles.Add(auction);
        //            }
        //        }
        //    }
        //    return filteredTitles;
        //}
    }
}
