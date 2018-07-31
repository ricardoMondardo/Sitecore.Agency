using System;

namespace Agency.Foundation.Orm.Models
{
    public class SitecoreItem
    {
        public virtual Guid Id { get; set; }

        public virtual Guid TemplateId { get; set; }

        public virtual string SitecorePath { get; set; }

        public virtual string Name { get; set; }

        public virtual string DisplayName { get; set; }

        public virtual string Icon { get; set; }

        public virtual string Url { get; set; }

        public virtual int SortOrder { get; set; }
    }
}