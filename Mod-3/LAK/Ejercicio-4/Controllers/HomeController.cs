using Microsoft.AspNetCore.Mvc;
using PollBall.Services;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PollBall.Controllers
{
    public class HomeController : Controller
    {
        private IPollResultsService _pollResults;

        public HomeController(IPollResultsService pollResults)
        {
            _pollResults = pollResults;
        }
        public IActionResult Index()
        {
            if (Request.Query.ContainsKey("submitted"))
            {
                StringBuilder results = new StringBuilder();
                SortedDictionary<SelectedGame, int> voteList = _pollResults.GetVoteResult();

                foreach (var gameVotes in voteList)
                {
                    results.Append($"Game name: {gameVotes.Key}. Votes: {gameVotes.Value}{Environment.NewLine}");
                }

                return Content(results.ToString());
            }
            else
            {
                return Redirect("poll-questions.html");
            }
        }
    }
}
