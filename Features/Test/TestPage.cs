using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using FoundationNetCore.Features.Shared;
using System.ComponentModel.DataAnnotations;

namespace FoundationNetCore.Features.Test
{
    [ContentType(DisplayName = "Test page",
        GUID = "8D3B0A08-FC20-4C27-8B37-D6E5BEEB47C8",
        Description = "Used for home page of all sites",
        AvailableInEditMode = true,
        GroupName = Global.GroupNames.Content)]
    [ImageUrl("~/assets/icons/cms/pages/home.png")]
    public class TestPage: FoundationPageData
    {
        [CultureSpecific]
        [Display(Name = "Top content area", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual ContentArea TopContentArea { get; set; }
    }
}
