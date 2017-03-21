using System.Collections.Generic;

namespace Client
{
    public class User
    {

        public List<int> bestScores;
        public List<float> bestTimes;
        public string Name { get; set; }
        
        
        public User()
        {
            
            bestScores = new List<int>(10);
            bestTimes  = new List<float>(10);

        }
    }
}
