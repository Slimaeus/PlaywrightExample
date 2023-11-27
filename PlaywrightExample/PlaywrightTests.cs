using Microsoft.Playwright;

namespace PlaywrightExample;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class PlaywrightTests : PageTest
{


    [Test]
    public async Task MyTestMethod4()
    {
        await Page.GotoAsync("https://playwright.dev");
        var page10 = await Page.RunAndWaitForPopupAsync(async () =>
        {
            await Page.GetByRole(AriaRole.Link, new() { NameString = "Star microsoft/playwright on GitHub" }).ClickAsync();
        });
        await page10.WaitForURLAsync("https://github.com/microsoft/playwright");
        await page10.GetByRole(AriaRole.Button, new() { NameString = "Search or jump to..." }).ClickAsync();
        await page10.GetByLabel("Search").FillAsync("repo:microsoft/playwright Browser");
        Thread.Sleep(2000);
        await page10.GetByLabel("Search").PressAsync("Enter");
        await page10.WaitForURLAsync("https://github.com/search?q=repo%3Amicrosoft%2Fplaywright%20Browser&type=issues");
        await page10.GetByRole(AriaRole.Link, new() { NameString = "[BUG] Browser install hangs infinitely" }).ClickAsync();
        await page10.WaitForURLAsync("https://github.com/microsoft/playwright/issues/28189");
        await page10.GetByRole(AriaRole.Cell, new() { NameString = "Does a manual download work? curl -O -v https://playwright.azureedge.net/builds/chromium/1084/chromium-mac.zip Copy or via the browser." }).GetByRole(AriaRole.Button, new() { NameString = "Copy" }).ClickAsync();
        await page10.Locator("#issuecomment-1814993529").GetByRole(AriaRole.Button, new() { NameString = "Show options" }).ClickAsync();
        await page10.GetByRole(AriaRole.Menuitem, new() { NameString = "Copy link" }).ClickAsync();
        await page10.GetByText("bjorne01@MC-N365497 ~ % curl -O -v https://playwright.azureedge.net/builds/chrom").ClickAsync(new LocatorClickOptions
        {
            Button = MouseButton.Right,
        });
        await page10.GetByText("bjorne01@MC-N365497 ~ % curl -O -v https://playwright.azureedge.net/builds/chrom").ClickAsync();
        await page10.GetByRole(AriaRole.Link, new() { NameString = "Sign up for free" }).ClickAsync();
        await page10.WaitForURLAsync("https://github.com/join?source=comment-repo");
        Assert.Pass();
    }

    [Test]
    public async Task MyTestMethod23()
    {
        await Page.GotoAsync("https://playwright.dev");
        var page9 = await Page.RunAndWaitForPopupAsync(async () =>
        {
            await Page.GetByRole(AriaRole.Link, new() { NameString = "Star microsoft/playwright on GitHub" }).ClickAsync();
        });
        await page9.WaitForURLAsync("https://github.com/microsoft/playwright");
        Thread.Sleep(2000);
        await page9.Locator("get-repo summary").GetByText("Code").ClickAsync();
        Thread.Sleep(2000);
        await page9.GetByRole(AriaRole.Button, new() { NameString = "Copy to clipboard" }).ClickAsync();
        Assert.Pass();
    }
    [Test]
    public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
    {
        await Page.GotoAsync("https://playwright.dev");

        // Expect a title "to contain" a substring.
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

        // create a locator
        var getStarted = Page.Locator("text=Get Started");

        // Expect an attribute "to be strictly equal" to the value.
        await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

        // Click the get started link.
        await getStarted.ClickAsync();

        // Expects the URL to contain intro.
        await Expect(Page).ToHaveURLAsync(new Regex(".*intro"));
    }

    [Test]
    public async Task MyTest()
    {
        await Page.GotoAsync("http://playwright.dev/");
        var page1 = await Page.RunAndWaitForPopupAsync(async () =>
        {
            await Page.GetByRole(AriaRole.Link, new() { NameString = "Star microsoft/playwright on GitHub" }).ClickAsync();
        });
        await Page.WaitForURLAsync("https://github.com/microsoft/playwright");
        await page1.WaitForLoadStateAsync();
        await page1.Locator("header[role=\"banner\"]:has-text(\"Toggle navigation Sign up Product Actions Automate any workflow Packages Host an\")").GetByRole(AriaRole.Link, new() { NameString = "Homepage" }).ClickAsync();
        await page1.WaitForURLAsync("https://github.com/");
        await page1.GetByRole(AriaRole.Textbox, new() { NameString = "Email address Email address" }).ClickAsync();
        await page1.GetByRole(AriaRole.Textbox, new() { NameString = "Email address Email address" }).FillAsync("fasdlkfas");
        await page1.GetByRole(AriaRole.Textbox, new() { NameString = "Email address Email address" }).PressAsync("Enter");
        await page1.GetByRole(AriaRole.Button, new() { NameString = "Sign up for GitHub" }).First.ClickAsync();
        await page1.GetByRole(AriaRole.Link, new() { NameString = "Start a free enterprise trial" }).First.ClickAsync();
        await page1.WaitForURLAsync("https://github.com/organizations/enterprise_plan?ref_cta=Start+a+free+enterprise+trial&ref_loc=Home+campaign+hero&ref_page=%2F");
        await page1.GetByRole(AriaRole.Link, new() { NameString = "Enterprise Server Manage and deploy GitHub Enterprise on your own servers, including AWS, Azure, or GC" }).ClickAsync();
        await page1.WaitForURLAsync("https://enterprise.github.com/trial?ref_cta=Start+a+free+enterprise+trial&ref_loc=Home+campaign+hero&ref_page=%2F&source=pricing-card-enterprise");
        await page1.GetByRole(AriaRole.Link, new() { NameString = "Contact Sales Team" }).ClickAsync();
        await page1.WaitForURLAsync("https://github.com/enterprise/contact");
        await page1.GetByText("By submitting this form, I agree to be contacted by GitHub Sales. Contact Sales").ClickAsync();
        await Page.GetByRole(AriaRole.Link, new() { NameString = "Get started" }).ClickAsync();
        await Page.WaitForURLAsync("http://playwright.dev/docs/intro");
        await Page.GetByRole(AriaRole.Navigation, new() { NameString = "Breadcrumbs" }).Locator("li:has-text(\"Getting Started\")").ClickAsync();
        var page2 = await Page.RunAndWaitForPopupAsync(async () =>
        {
            await Page.GetByRole(AriaRole.Link, new() { NameString = "GitHub repository" }).ClickAsync();
        });
        await Page.WaitForURLAsync("https://github.com/microsoft/playwright");
        await page2.WaitForLoadStateAsync();
        await page2.Locator("#repository-container-header").GetByRole(AriaRole.Link, new() { NameString = "playwright" }).ClickAsync();
        await page2.WaitForURLAsync("https://github.com/microsoft/playwright");
        await page2.GetByRole(AriaRole.Link, new() { NameString = "pavelfeldman" }).ClickAsync();
        await page2.WaitForURLAsync("https://github.com/microsoft/playwright/commits?author=pavelfeldman");
        await page2.Locator("li:has-text(\"feat(vrt): bring back wait for font loading (#28226) pavelfeldman committed Nov \")").ClickAsync();
        await page2.GetByRole(AriaRole.Link, new() { NameString = "feat(vrt): bring back wait for font loading (" }).ClickAsync();
        await page2.WaitForURLAsync("https://github.com/microsoft/playwright/commit/3f55587dd89a9e21bb3bdd4e24d33fffeb5563bc");
        await page2.GetByRole(AriaRole.Cell, new() { NameString = "241" }).Nth(1).ClickAsync();
        await page2.WaitForURLAsync("https://github.com/microsoft/playwright/commit/3f55587dd89a9e21bb3bdd4e24d33fffeb5563bc#diff-2a1420a8cda3282f1ceabd2ac7ba17d81bfcd8848a521312bb9ac50a1aa37dc4R241");
        await page2.GetByRole(AriaRole.Link, new() { NameString = "screenshotter.ts" }).ClickAsync();
        await page2.WaitForURLAsync("https://github.com/microsoft/playwright/commit/3f55587dd89a9e21bb3bdd4e24d33fffeb5563bc#diff-2a1420a8cda3282f1ceabd2ac7ba17d81bfcd8848a521312bb9ac50a1aa37dc4");
        await page2.GetByRole(AriaRole.Link, new() { NameString = "page-screenshot.spec.ts" }).ClickAsync();
        await page2.WaitForURLAsync("https://github.com/microsoft/playwright/commit/3f55587dd89a9e21bb3bdd4e24d33fffeb5563bc#diff-e8b29db5b4f79afc20dc4ec3b794b027021dc81035ac43315b567ef5e3c70a24");
    }


    [Test]
    public async Task MyTestMethod2()
    {
        await Page.GotoAsync("http://playwright.dev/");
        var page1 = await Page.RunAndWaitForPopupAsync(async () =>
        {
            await Page.GetByRole(AriaRole.Link, new() { NameString = "Star microsoft/playwright on GitHub" }).ClickAsync();
        });
        await page1.WaitForURLAsync("https://github.com/microsoft/playwright");
        await page1.Locator("header[role=\"banner\"]:has-text(\"Toggle navigation Sign up Product Actions Automate any workflow Packages Host an\")").GetByRole(AriaRole.Link, new() { NameString = "Homepage" }).ClickAsync();
        await page1.WaitForURLAsync("https://github.com/");
        await page1.GetByRole(AriaRole.Textbox, new() { NameString = "Email address Email address" }).ClickAsync();
        await page1.GetByRole(AriaRole.Textbox, new() { NameString = "Email address Email address" }).FillAsync("fasdlkfas");
        await page1.GetByRole(AriaRole.Textbox, new() { NameString = "Email address Email address" }).PressAsync("Enter");
        await page1.GetByRole(AriaRole.Button, new() { NameString = "Sign up for GitHub" }).First.ClickAsync();
        await page1.GetByRole(AriaRole.Link, new() { NameString = "Start a free enterprise trial" }).First.ClickAsync();
        await page1.WaitForURLAsync("https://github.com/organizations/enterprise_plan?ref_cta=Start+a+free+enterprise+trial&ref_loc=Home+campaign+hero&ref_page=%2F");
        await page1.GetByRole(AriaRole.Link, new() { NameString = "Enterprise Server Manage and deploy GitHub Enterprise on your own servers, including AWS, Azure, or GC" }).ClickAsync();
        await page1.WaitForURLAsync("https://enterprise.github.com/trial?ref_cta=Start+a+free+enterprise+trial&ref_loc=Home+campaign+hero&ref_page=%2F&source=pricing-card-enterprise");
        await page1.GetByRole(AriaRole.Link, new() { NameString = "Contact Sales Team" }).ClickAsync();
        await page1.WaitForURLAsync("https://github.com/enterprise/contact");
        await page1.GetByText("By submitting this form, I agree to be contacted by GitHub Sales. Contact Sales").ClickAsync();
        await Page.GetByRole(AriaRole.Link, new() { NameString = "Get started" }).ClickAsync();
        await Page.WaitForURLAsync("http://playwright.dev/docs/intro");
        await Page.GetByRole(AriaRole.Navigation, new() { NameString = "Breadcrumbs" }).Locator("li:has-text(\"Getting Started\")").ClickAsync();
        var page2 = await Page.RunAndWaitForPopupAsync(async () =>
        {
            await Page.GetByRole(AriaRole.Link, new() { NameString = "GitHub repository" }).ClickAsync();
        });
        await page2.WaitForURLAsync("https://github.com/microsoft/playwright");
        await page2.Locator("#repository-container-header").GetByRole(AriaRole.Link, new() { NameString = "playwright" }).ClickAsync();
        await page2.WaitForURLAsync("https://github.com/microsoft/playwright");
        await page2.GetByRole(AriaRole.Link, new() { NameString = "pavelfeldman" }).ClickAsync();
        await page2.WaitForURLAsync("https://github.com/microsoft/playwright/commits?author=pavelfeldman");
        await page2.Locator("li:has-text(\"feat(vrt): bring back wait for font loading (#28226) pavelfeldman committed Nov \")").ClickAsync();
        await page2.GetByRole(AriaRole.Link, new() { NameString = "feat(vrt): bring back wait for font loading (" }).ClickAsync();
        await page2.WaitForURLAsync("https://github.com/microsoft/playwright/commit/3f55587dd89a9e21bb3bdd4e24d33fffeb5563bc");
        await page2.GetByRole(AriaRole.Cell, new() { NameString = "241" }).Nth(1).ClickAsync();
        await page2.WaitForURLAsync("https://github.com/microsoft/playwright/commit/3f55587dd89a9e21bb3bdd4e24d33fffeb5563bc#diff-2a1420a8cda3282f1ceabd2ac7ba17d81bfcd8848a521312bb9ac50a1aa37dc4R241");
        await page2.GetByRole(AriaRole.Link, new() { NameString = "screenshotter.ts" }).ClickAsync();
        await page2.WaitForURLAsync("https://github.com/microsoft/playwright/commit/3f55587dd89a9e21bb3bdd4e24d33fffeb5563bc#diff-2a1420a8cda3282f1ceabd2ac7ba17d81bfcd8848a521312bb9ac50a1aa37dc4");
        await page2.GetByRole(AriaRole.Link, new() { NameString = "page-screenshot.spec.ts" }).ClickAsync();
        await page2.WaitForURLAsync("https://github.com/microsoft/playwright/commit/3f55587dd89a9e21bb3bdd4e24d33fffeb5563bc#diff-e8b29db5b4f79afc20dc4ec3b794b027021dc81035ac43315b567ef5e3c70a24");
        var page4 = await Page.RunAndWaitForPopupAsync(async () =>
        {
            await Page.GetByRole(AriaRole.Link, new() { NameString = "Star microsoft/playwright on GitHub" }).ClickAsync();
        });
        await page4.WaitForURLAsync("https://github.com/microsoft/playwright");
        await page4.GetByRole(AriaRole.Navigation, new() { NameString = "Global" }).GetByRole(AriaRole.Link, new() { NameString = "Pricing" }).ClickAsync();
        await page4.WaitForURLAsync("https://github.com/pricing");
        await page4.GetByRole(AriaRole.Heading, new() { NameString = "Get the complete developer platform." }).ClickAsync();
        await page4.GetByRole(AriaRole.Heading, new() { NameString = "Get the complete developer platform." }).ClickAsync();
        await page4.GetByRole(AriaRole.Navigation, new() { NameString = "Global" }).GetByRole(AriaRole.Link, new() { NameString = "Pricing" }).ClickAsync(new LocatorClickOptions
        {
            Modifiers = new[] { KeyboardModifier.Control },
        });
        //await Page5.GotoAsync("https://github.com/pricing");
        await page4.GetByRole(AriaRole.Link, new() { NameString = "Homepage" }).ClickAsync();
        await page4.WaitForURLAsync("https://github.com/");
        await page4.GetByRole(AriaRole.Link, new() { NameString = "Developer API" }).ClickAsync();
        await page4.WaitForURLAsync("https://docs.github.com/en/get-started/exploring-integrations/about-building-integrations");
        await page4.GetByRole(AriaRole.Link, new() { NameString = "About creating GitHub Apps" }).ClickAsync();
        await page4.WaitForURLAsync("https://docs.github.com/en/apps/creating-github-apps/about-creating-github-apps/about-creating-github-apps");
        await page4.GetByText("In order to build a GitHub App, you first need to register a GitHub App. For mor").ClickAsync();
        await page4.GetByRole(AriaRole.Link, new() { NameString = "Registering a GitHub App" }).ClickAsync();
        await page4.WaitForURLAsync("https://docs.github.com/en/apps/creating-github-apps/registering-a-github-app/registering-a-github-app");
        await page4.GetByTestId("minitoc").GetByRole(AriaRole.Link, new() { NameString = "Next steps" }).ClickAsync();
        await page4.WaitForURLAsync("https://docs.github.com/en/apps/creating-github-apps/registering-a-github-app/registering-a-github-app#next-steps");
        await page4.GetByRole(AriaRole.Button, new() { NameString = "Select language: current language is English" }).ClickAsync();
        await page4.GetByTestId("sidebar-hamburger").ClickAsync();
        await page4.GetByRole(AriaRole.Button, new() { NameString = "OAuth apps" }).ClickAsync();
        await page4.GetByRole(AriaRole.Button, new() { NameString = "Building OAuth apps" }).ClickAsync();
        await page4.GetByRole(AriaRole.Link, new() { NameString = "Creating an OAuth app" }).ClickAsync();
        await page4.WaitForURLAsync("https://docs.github.com/en/apps/oauth-apps/building-oauth-apps/creating-an-oauth-app");
        await page4.GetByRole(AriaRole.Button, new() { NameString = "Select GitHub product version: current version is free-pro-team@latest" }).ClickAsync();
        await page4.GetByRole(AriaRole.Menuitemradio, new() { NameString = "Enterprise Server 3.8" }).ClickAsync();
        await page4.WaitForURLAsync("https://docs.github.com/en/enterprise-server@3.8/apps/oauth-apps/building-oauth-apps/creating-an-oauth-app");
        Assert.Pass();
    }
}
