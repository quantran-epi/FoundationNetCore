using EPiServer.Core;
using FoundationNetCore.Features.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoundationNetCore.Features.Header
{
    public interface IHeaderViewModelFactory
    {
        HeaderViewModel CreateHeaderViewModel(IContent content, HomePage homePage);
        //HeaderLogoViewModel CreateHeaderLogoViewModel();
        void AddMyAccountMenu(HomePage homePage, HeaderViewModel viewModel);
    }
}
