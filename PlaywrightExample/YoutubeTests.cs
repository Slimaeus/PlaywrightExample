namespace PlaywrightExample;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class YoutubeTests : PageTest
{

    [Test]
    public async Task MyTestMethod()
    {
        // pwsh bin/Debug/net8.0/playwright.ps1 codegen playwright.dev
        await Page.GotoAsync("https://www.youtube.com/");
        var searchInput = Page.GetByPlaceholder("Search");
        await searchInput.ClickAsync();
        await searchInput.FillAsync("Stay");
        await searchInput.PressAsync("Enter");
        await Page.WaitForURLAsync(Page.Url);
        await Page.Locator("ytd-video-preview").First.ClickAsync();
        await Page.WaitForURLAsync(Page.Url);
        await Page.GotoAsync(Page.Url.Replace("https://www.youtube.com/watch", "https://www.youtubepp.com/watch"));
        await Expect(Page).ToHaveURLAsync(new Regex("y2mate"));
    }
}
