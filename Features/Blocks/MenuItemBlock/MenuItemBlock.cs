﻿using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static FoundationNetCore.Global;

namespace FoundationNetCore.Features.Blocks.MenuItemBlock
{
    [ContentType(DisplayName = "Menu Item Block",
           GUID = "a6d0242a-3946-4a80-9eec-4d9b2e5fc2d0",
           Description = "Used to create a menu item",
           GroupName = GroupNames.Content)]
    [ImageUrl("~/assets/icons/cms/blocks/CMS-icon-block-23.png")]
    public class MenuItemBlock : BlockData
    {
        [CultureSpecific]
        [Display(Description = "Name in menu", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Name { get; set; }

        [CultureSpecific]
        [Display(Description = "Link", GroupName = SystemTabNames.Content, Order = 20)]
        public virtual Url Link { get; set; }

        [UIHint(UIHint.Image)]
        [Display(Name = "Menu item image", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual ContentReference MenuImage { get; set; }

        [Display(Name = "Teaser text", GroupName = SystemTabNames.Content, Order = 50)]
        public virtual XhtmlString TeaserText { get; set; }

        [Display(Name = "Label", GroupName = SystemTabNames.Content, Order = 60)]
        public virtual string ButtonText { get; set; }

        [Display(Name = "Button link", GroupName = SystemTabNames.Content, Order = 70)]
        public virtual Url ButtonLink { get; set; }

        //[JsonIgnore]
        //[EditorDescriptor(EditorDescriptorType = typeof(CollectionEditorDescriptor<GroupLinkCollection>))]
        //[ClientEditor(ClientEditingClass = "foundation/MenuChildItems")]
        //[Display(Name = "Child items", GroupName = SystemTabNames.Content, Order = 80)]
        //public virtual IList<GroupLinkCollection> ChildItems { get; set; }
    }
}