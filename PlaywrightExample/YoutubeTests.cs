namespace PlaywrightExample;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class YoutubeTests : PageTest
{

    [Test]
    public async Task MyTestMethod()
    {
        await Page.GotoAsync("https://www.youtube.com/");
        await Page.GetByPlaceholder("Search").ClickAsync();
        await Page.GetByPlaceholder("Search").FillAsync("Stay");
        await Page.GetByPlaceholder("Search").PressAsync("Enter");
        await Page.WaitForURLAsync(Page.Url);
        await Page.Locator("ytd-video-preview").First.ClickAsync();
        await Page.WaitForURLAsync(Page.Url);
        await Page.GotoAsync(Page.Url.Replace("https://www.youtube.com/watch", "https://www.youtubepp.com/watch"));
        await Expect(Page).ToHaveURLAsync(new Regex("y2mate"));
    }
}
