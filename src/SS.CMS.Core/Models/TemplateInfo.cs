using SS.CMS.Core.Common;
using SS.CMS.Data;
using SS.CMS.Plugin;

namespace SS.CMS.Core.Models
{
    [Table("siteserver_Template")]
    public class TemplateInfo : Entity
    {
        [TableColumn]
        public int SiteId { get; set; }

        [TableColumn]
        public string TemplateName { get; set; }

        [TableColumn]
        private string TemplateType { get; set; }

        public TemplateType Type
        {
            get => TemplateTypeUtils.GetEnumType(TemplateType);
            set => TemplateType = value.Value;
        }

        [TableColumn]
        public string RelatedFileName { get; set; }

        [TableColumn]
        public string CreatedFileFullName { get; set; }

        [TableColumn]
        public string CreatedFileExtName { get; set; }

        [TableColumn]
        private string IsDefault { get; set; }

        public bool Default
        {
            get => IsDefault == "True";
            set => IsDefault = value.ToString();
        }

        public string Content { get; set; }
    }
}
