using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingSystem
{
    internal class AgentRatingService : IAgentRatingService
    {
        private readonly Dictionary<string, Agent> _agents;
        private List<Agent> _sortedAgentsCache;
        private bool _isDirty;
        private readonly object _lock = new();
        //private readonly ReaderWriterLockSlim _lock1 = new();

        public AgentRatingService()
        {
            _agents = new Dictionary<string, Agent>();
            _sortedAgentsCache = new List<Agent>();
            _isDirty = true;
        }
        public void GiveRating(String agentName, int rating)
        {
            //_lock1.EnterWriteLock();
            //try
            //{
                lock (_lock)
                {
                    if (!_agents.ContainsKey(agentName))
                        _agents[agentName] = new Agent(agentName);
                    _agents[agentName].AddRating(rating);
                    _isDirty = true;
                }
            //}
            //finally
            //{
            //    _lock1.ExitWriteLock();
            //}
        }

        public List<Agent> GetRatings()
        {
            //_lock1.EnterUpgradeableReadLock();
            //try
            //{
                lock (_lock)
                {
                    if (_isDirty)
                    {
                        _sortedAgentsCache = _agents.Values
                                              .OrderByDescending(agent => agent.GetAverageRating())
                                              .ThenBy(agent => agent.ratingCount)
                                              .ThenBy(agent => agent.LastRatedAt)
                                              .ThenBy(agent => agent.Name)
                                              .ToList();
                        _isDirty = false;
                    }
                    return _sortedAgentsCache;
                }
            //}
            //finally
            //{
            //    _lock1.EnterUpgradeableReadLock();
            //}
        }
    }
}
