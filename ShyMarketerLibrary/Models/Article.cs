using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyMarketerLibrary.Models
{
    public class Article
    {
        public int id { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanySector { get; set; }
        public string? AboutCompanyText { get; set; }
        public string? CompanyLink { get; set; }
        public string? ArticleTitle { get; set; }
        public string? ArticlePunchLine { get; set; }
        public string? ArticleText { get; set; }
        public string? ArticleTargetAudience { get; set; }
        public string? ArticleImage { get; set; }

    }
}
