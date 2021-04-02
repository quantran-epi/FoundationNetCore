using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using FoundationNetCore.Cms.Settings;
using FoundationNetCore.Infrastructure;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoundationNetCore.Features.Settings
{
    [SettingsContentType(DisplayName = "SearchSettings",
        GUID = "d4171337-70a4-476a-aa3c-0d976ac185e8",
        SettingsName = "Search Settings")]
    public class SearchSettings : SettingsBase
    {
        [CultureSpecific]
        [SelectOne(SelectionFactoryType = typeof(SearchOptionSelectionFactory))]
        [Display(Name = "Search option", GroupName = Global.GroupNames.SearchSettings, Order = 50)]
        public virtual string SearchOption { get; set; }
    }

    public class SearchOptionSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new ISelectItem[]
            {
                new SelectItem { Text = "Quick search", Value = "QuickSearch" },
                new SelectItem { Text = "Auto search", Value = "AutoSearch" }
            };
        }
    }
}