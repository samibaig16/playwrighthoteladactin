using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using PuppeteerSharp;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace playwrright
{
    public class TestExecution
    {

        [Test]
        [Category("AdactinHotel")]
        public async Task AdactinHotelApp()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = false,
                    SlowMo = 30
                });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();
            Thread.Sleep(3000);
            await page.GotoAsync("https://adactinhotelapp.com/");
            await page.FillAsync("#username", "samibaig16");
            await page.FillAsync("#password", "89O570");
            await page.ClickAsync("#login");

            await page.TypeAsync("#location", "Sydney");
            await page.TypeAsync("#hotels", "Hotel Creek");
            await page.TypeAsync("#room_type", "Standard");
            await page.TypeAsync("#room_nos", "Standard");
            await page.TypeAsync("#datepick_in", "21/05/2023");
            await page.TypeAsync("#datepick_out", "28/05/2023");
            await page.TypeAsync("#adult_room", "3 - Three");
            await page.TypeAsync("#child_room", "3 - Three");
            await page.ClickAsync("#Submit");

            await page.ClickAsync("#radiobutton_0");
            await page.ClickAsync("#continue");

            await page.FillAsync("#first_name", "samibaig16");
            await page.FillAsync("#last_name", "89O570");
            await page.FillAsync("#address", "Gulistan e Johar BLock 2 A100");
            await page.FillAsync("#cc_num", "4782001100991122");
            await page.SelectOptionAsync("#cc_type", "VISA");
            await page.SelectOptionAsync("#cc_exp_month", "January");
            await page.SelectOptionAsync("#cc_exp_year", "2025");
            await page.FillAsync("#cc_cvv", "415");
            await page.ClickAsync("#book_now");
            await page.ClickAsync("#my_itinerary");
            await page.CheckAsync("input[name='ids[]'][value='851303']");
            await page.CheckAsync("input[name='ids[]'][value='851305']");
            await page.ClickAsync("input.reg_button[value='Cancel Selected']");
            await page.Keyboard.PressAsync("Enter");
            await page.FillAsync("#order_id_text", "C216967N79");
            await page.ClickAsync("#search_hotel_id");
            await page.CheckAsync("input[name='ids[]'][value='851321']");
            await page.ClickAsync("input.reg_button[value='Cancel Selected']");
            await page.ClickAsync("#logout");

        }
        [Test]
        [Category("Signup")]
        public async Task SignupAdactinHotelApp()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = false,
                    SlowMo = 30
                });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();
            Thread.Sleep(3000);
            await page.GotoAsync("https://adactinhotelapp.com/");
            var anchorElement = await page.QuerySelectorAsync("td.login_register a");

            // Check if the anchor element is not null before clicking
            if (anchorElement != null)
            {
                await anchorElement.ClickAsync();
                await page.FillAsync("#username", "samibaig17");
                await page.FillAsync("#password", "samitester99");
                await page.FillAsync("#re_password", "samitester99");
                await page.FillAsync("#full_name", "Sami Baig");
                await page.FillAsync("#email_add", "samibaig22000@gmail.com");
                Thread.Sleep(5000);
                await page.ClickAsync("#tnc_box");
                await page.ClickAsync("#Submit");
                // Continue with the rest of your test logic...
            }
        }

    }
}

