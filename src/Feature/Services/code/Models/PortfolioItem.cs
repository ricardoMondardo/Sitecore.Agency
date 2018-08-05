﻿using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;

namespace Agency.Feature.Services.Models
{
    public class PortfolioItem : SitecoreItem
    {
        public string Client { get; set; }
        public string Category { get; set; }
        [SitecoreField("Project Name")]
        public string ProjectName { get; set; }
        [SitecoreField("Project Title")]
        public string ProjecTitle { get; set; }
        public DateTime Date { get; set; }
        public Image Image { get; set; }
    }
}