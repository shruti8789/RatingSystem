using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingSystem
{
    public class Agent
    {
        public string Name { get; private set; }
        private int totalRating;
        public int ratingCount { get; private set; }

        public DateTime LastRatedAt { get; private set; }

        public Agent(string name)
        {
            Name = name;
            totalRating = 0;
            ratingCount = 0;
        }

        public void AddRating(int rating)
        {
            if (rating < 1 || rating > 5)
                throw new Exception("Invalid rating");
            totalRating += rating;
            ratingCount++;
            LastRatedAt = DateTime.UtcNow;
        }

        public double GetAverageRating()
        {
            return ratingCount == 0 ? 0 : (double)totalRating / ratingCount;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Avg Rating: {this.GetAverageRating()}, LastratedAt: {this.LastRatedAt}";
        }
    }
}
