using EntityFrameworkIntegrationTesting.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EntityFrameworkIntegrationTesting.Queries
{
    public class ScaryMonstersQuery
    {
        private MonsterContext _context;

        public ScaryMonstersQuery(MonsterContext context)
        {
            _context = context;
        }

        public IEnumerable<Monster> Execute()
        {
            return _context.Monsters
                .FromSql("SELECT Id, Name, IsScary, Colour FROM Monsters WHERE IsScary = {0}", true);
        }
        
    }
}
