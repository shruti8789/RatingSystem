using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingSystem
{
    public interface IAgentRatingService
    {
        public void GiveRating(String agentName, int rating);

        public List<Agent> GetRatings();
    }
}
