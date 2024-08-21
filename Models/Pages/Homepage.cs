using EPiServer.Core;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace hemsida1.Models.Pages
{
    [ContentType(DisplayName = "Homepage",
                 GUID = "f3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b1b",
                 Description = "Homepage for my website")]
    public class Homepage : PageData
    {
        [Display(Name = "Headline",
                 GroupName = SystemTabNames.Content,
                 Order = 10)]
        public virtual string Headline { get; set; }

        [Display(Name = "Main Content",
                 GroupName = SystemTabNames.Content,
                 Order = 20)]
        public virtual XhtmlString MainContent { get; set; }

        [Display(Name = "Body",
                 GroupName = SystemTabNames.Content,
                 Order = 30)]
        public virtual XhtmlString Body { get; set; }
    }
}
