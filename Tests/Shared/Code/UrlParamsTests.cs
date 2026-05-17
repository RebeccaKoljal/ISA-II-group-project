using System;
using Abc.Infra;
using Abc.Shared.Code;

namespace Abc.Tests.Shared.Code;

[TestClass]
public sealed class UrlParamsTests
{
    [TestMethod]
    public void ParseEmptyUrlTest()
    {
        var u = new UrlParams(new Uri("https://x.ee/page"));
        var q = u.Parse();
        Assert.AreEqual(1, q.Page);
        Assert.AreEqual(0, u.d.Count);
    }

    [TestMethod]
    public void ParseNullUrlTest()
    {
        var u = new UrlParams(null);
        var q = u.Parse();
        Assert.AreEqual(1, q.Page);
        Assert.AreEqual(0, u.d.Count);
    }

    [TestMethod]
    public void ParseSingleParamTest()
    {
        var u = new UrlParams(new Uri("https://x.ee/p?Page=5"));
        var q = u.Parse();
        Assert.AreEqual(5, q.Page);
        Assert.AreEqual("5", u.d["Page"]);
    }

    [TestMethod]
    public void ParseMultipleParamsTest()
    {
        var u = new UrlParams(new Uri("https://x.ee/p?Page=3&SortBy=Name"));
        var q = u.Parse();
        Assert.AreEqual(3, q.Page);
        Assert.AreEqual("Name", q.SortBy);
        Assert.AreEqual(2, u.d.Count);
    }

    [TestMethod]
    public void ParseUnescapesValueTest()
    {
        var u = new UrlParams(new Uri("https://x.ee/p?SearchStr=hello%20world"));
        var q = u.Parse();
        Assert.AreEqual("hello world", q.SearchStr);
    }

    [TestMethod]
    public void ParseIgnoresMalformedPairTest()
    {
        var u = new UrlParams(new Uri("https://x.ee/p?Page=2&broken&SortBy=X"));
        var q = u.Parse();
        Assert.AreEqual(2, q.Page);
        Assert.AreEqual("X", q.SortBy);
        Assert.AreEqual(2, u.d.Count);
    }
}