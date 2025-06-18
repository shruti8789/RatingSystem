
Round 3: Backend Coding & LLD (1 hour)
This round blended low-level design with implementation.

Question: Design a system for rating customer support agents. Implement two methods:void giveRating(String agentName, int rating)
List<Agent> getRatings() which returns agents sorted from highest to lowest average rating.
Follow-up 1: The getRatings() call is becoming slow. How do you optimize it? (My solution involved pre-calculating and caching the sorted list, updating it only when new ratings come in).
Follow-up 2: How would you break ties in ratings? Discuss and implement alternate approaches. (We discussed tie-breaking strategies like using the total number of ratings or the timestamp of the most recent rating).
My take: The problem was a vehicle to discuss design trade-offs. The interviewer was assessing my ability to write clean code and think about scalability from the ground up.
