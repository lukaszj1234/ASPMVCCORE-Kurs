﻿using KursASPMVC.Infrastructure;
using KursASPMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Moq;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KursASPMVC.Tests
{
    public class PageLinkTagHelperTest
    {
        [Fact]
        public void Can_Generate_Page_Links()
        {
            //Arrange
            var urlHelper = new Mock<IUrlHelper>();
            urlHelper.SetupSequence(x =>
                x.Action(It.IsAny<UrlActionContext>()))
            .Returns("Test/Page1")
            .Returns("Test/Page2")
            .Returns("Test/Page3");
            var urlHelperFactory = new Mock<IUrlHelperFactory>();
            urlHelperFactory.Setup(f =>
                f.GetUrlHelper(It.IsAny<ActionContext>()))
                .Returns(urlHelper.Object);
            PageLinkTagHelper helper =
                new PageLinkTagHelper(urlHelperFactory.Object)
                {
                    PageModel = new PagingInfo
                    {
                        CurrentPage = 2,
                        TotalItems = 28,
                        ItemsPerPage = 10
                    },
                    PageAction = "Test"
                };
            TagHelperContext ctx = new TagHelperContext(
                new TagHelperAttributeList(),
                new Dictionary<object, object>(),"");
            var content = new Mock<TagHelperContent>();
            TagHelperOutput output = new TagHelperOutput("div",
                new TagHelperAttributeList(),
                    (cache, encoder) => Task.FromResult(content.Object));
            //Act
            helper.Process(ctx, output);
            var stringContent = output.Content.GetContent();
            //Assert
            Assert.Equal(@"<a href=""Test/Page1"">1</a>"
                + @"<a href=""Test/Page2"">2</a>"
                + @"<a href=""Test/Page3"">3</a>",
                output.Content.GetContent());
        }

    }
}