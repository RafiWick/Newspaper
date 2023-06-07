using Newspaper.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<Article> Articles { get; set; } = new List<Article>();

        public int ArticleCount()
        {
            return Articles.Count();
        }
        public int ReporterCount()
        {
            var reporterList = Articles.Select(a => a.Reporter).Distinct();
            return reporterList.Count();
        }
        public List<string> ReporterNames()
        {
            var reporterList = Articles.Select(a => a.Reporter).Distinct();
            return reporterList.Select(r => r.Name).ToList();
        }
    }
}
