using EPiServer.DataAnnotations;
using FoundationNetCore.Cms.Settings;
using FoundationNetCore.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace FoundationNetCore.Features.Settings
{
    [SettingsContentType(DisplayName = "LabelSettings",
        GUID = "c17375a6-4a01-402b-8c7f-18257e944527",
        SettingsName = "Site Labels")]
    public class LabelSettings : SettingsBase
    {
        [CultureSpecific]
        [Display(Name = "My account", GroupName = Global.GroupNames.SiteLabels, Order = 10)]
        public virtual string MyAccountLabel { get; set; }

        [CultureSpecific]
        [Display(Name = "Search", GroupName = Global.GroupNames.SiteLabels, Order = 30)]
        public virtual string SearchLabel { get; set; }
    }
}