using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Threading.Tasks;
using MyMadnessLeague.Models;

namespace MyMadnessLeague.Repository
{
    public interface IMatchUpRepository
    {
        //int GetMatchUp();
        void Add(MatchUp Game);
        IEnumerable<MatchUp> PastMatchups();
        IEnumerable<MatchUp> All();
    }
}