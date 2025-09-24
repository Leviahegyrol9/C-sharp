using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Röplabda
{
    public class Team
    {
        public string TeamName { get; set; }
        public List<int> Points { get; set; }

        public Team(string teamName, List<int> points)
        {
            TeamName = teamName;
            Points = points;
        }
    }
}
