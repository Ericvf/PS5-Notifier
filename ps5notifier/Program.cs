using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;
using TelegramBotsApp;

namespace ps5notifier
{
    public class Program
    {
        public static RetailStoreLink[] GetSources() => new[] {
            new RetailStoreLink(){
                Store = "Bol .com",
                Name = "Sony Playstation 5 Console",
                Url = "https://www.bol.com/nl/p/sony-playstation-5-console/9300000004162282/",
                ExcludeText = "Niet leverbaar",
                IncludeText = "In winkelwagen",
            },
            new RetailStoreLink(){
                Store = "Bol .com",
                Name = "Sony Playstation 5 All Digital Console",
                Url = "https://www.bol.com/nl/p/sony-playstation-5-all-digital-console/9300000004162392/",
                ExcludeText = "Niet leverbaar",
                IncludeText = "In winkelwagen",
            }
            ,new RetailStoreLink()
            {
                Store = "Coolblue",
                Name = "PlayStation 5 Digital Edition",
                Url = "https://www.coolblue.nl/product/865867/playstation-5-digital-edition.html",
                ExcludeText = "Tijdelijk uitverkocht",
                IncludeText = "In mijn winkelwagen",
            }
            ,new RetailStoreLink()
            {
                Store = "Coolblue",
                Name = "PlayStation 5 Digital Edition + Sony PlayStation 5 DualSense draadloze controller",
                Url = "https://www.coolblue.nl/product/884830/playstation-5-digital-edition-sony-playstation-5-dualsense-draadloze-controller.html",
                ExcludeText = "Tijdelijk uitverkocht",
                IncludeText = "In mijn winkelwagen",
            },
            new RetailStoreLink()
            {
                Store = "Coolblue",
                Name = "PlayStation 5 + Ratchet & Clank: Rift Apart PS5 + SteelSeries Arctis 3 2019 Wit",
                Url = "https://www.coolblue.nl/product/884876/playstation-5-ratchet-clank-rift-apart-ps5-steelseries-arctis-3-2019-wit.html",
                ExcludeText = "Tijdelijk uitverkocht",
                IncludeText = "In mijn winkelwagen",
            },
            new RetailStoreLink()
            {
                Store = "Coolblue",
                Name = "PlayStation 5 + Sony PlayStation 5 DualSense draadloze controller",
                Url = "https://www.coolblue.nl/product/873655/playstation-5-sony-playstation-5-dualsense-draadloze-controller.html",
                ExcludeText = "Tijdelijk uitverkocht",
                IncludeText = "In mijn winkelwagen",
            },
            new RetailStoreLink()
            {
                Store = "Coolblue",
                Name = "PlayStation 5 Digital Edition + DualSense controller + SteelSeries Arctis 3 2019 Wit",
                Url = "https://www.coolblue.nl/product/884831/playstation-5-digital-edition-dualsense-controller-steelseries-arctis-3-2019-wit.html",
                ExcludeText = "Tijdelijk uitverkocht",
                IncludeText = "In mijn winkelwagen",
            },
            new RetailStoreLink()
            {
                Store = "Coolblue",
                Name = "PlayStation 5 + Assassin's Creed: Valhalla PS5 + PlayStation 5 DualSense Controller",
                Url = "https://www.coolblue.nl/product/883789/playstation-5-assassin-s-creed-valhalla-ps5-playstation-5-dualsense-controller.html",
                ExcludeText = "Tijdelijk uitverkocht",
                IncludeText = "In mijn winkelwagen",
            },new RetailStoreLink()
            {
                Store = "Coolblue",
                Name = "Playstation 5 + Marvel's Spider-Man-Miles Morales PS5 + PlayStation 5 DualSense Controller",
                Url = "https://www.coolblue.nl/product/884071/playstation-5-marvel-s-spider-man-miles-morales-ps5-playstation-5-dualsense-controller.html",
                ExcludeText = "Tijdelijk uitverkocht",
                IncludeText = "In mijn winkelwagen",
            },
            new RetailStoreLink()
            {
                Store = "Mediamarkt",
                Name = "SONY PlayStation 5 Disk Edition",
                Url = "https://www.mediamarkt.nl/nl/product/_sony-playstation-5-disk-edition-1664768.html",
                ExcludeText = "Product tijdelijk niet op voorraad",
                IncludeText = "Bestel nu",
            },new RetailStoreLink()
            {
                Store = "Mediamarkt",
                Name = "SONY PlayStation 5 Digital Edition",
                Url = "https://www.mediamarkt.nl/nl/product/_sony-playstation-5-digital-edition-1665134.html",
                ExcludeText = "Product tijdelijk niet op voorraad",
                IncludeText = "Bestel nu",
            },new RetailStoreLink()
            {
                Store = "Mediamarkt",
                Name = "SONY PlayStation 5 Disk Edition + Extra Controller & Accessoirespakket",
                Url = "https://www.mediamarkt.nl/nl/product/_sony-playstation-5-disk-edition-extra-controller-accessoirespakket-1690683.html",
                ExcludeText = "Product tijdelijk niet op voorraad",
                IncludeText = "Bestel nu",
            },
             //new PlaystationSource()
             //{
             //   Store = "Amazon DE",
             //   Name = "Sony PlayStation 5 inklusive Ratchet & Clank: Rift Apart ",
             //   Url = "`",
             //   ExcludeText = "Momenteel niet verkrijgbaar",
             //},
             //new PlaystationSource()
             //{
             //   Store = "Amazon DE",
             //   Name = "Sony PlayStation 5 - Digital Edition ",
             //   Url = "https://www.amazon.de/-/nl/dp/B08H98GVK8/",
             //   ExcludeText = "Momenteel niet verkrijgbaar",
             //},
             //new PlaystationSource()
             //{
             //   Store = "Amazon DE",
             //   Name = "Sony PlayStation 5",
             //   Url = "https://www.amazon.de/-/nl/dp/B08H93ZRK9/",
             //   ExcludeText = "Momenteel niet verkrijgbaar",
             //},
             new RetailStoreLink()
             {
                Store = "BCC",
                Name = "Sony PlayStation 5",
                Url = "https://www.bcc.nl/gaming/playstation/playstation-4-console/playstation-5-console-digital-edition/292649",
                ExcludeText = "Pagina niet gevonden",
             },
             new RetailStoreLink()
             {
                Store = "Wehkamp",
                Name = "Sony PlayStation 5",
                Url = "https://www.wehkamp.nl/sony-playstation-5-16644186/",
                IncludeText = "in winkelmandje"
             },
             new RetailStoreLink()
             {
                Store = "Wehkamp",
                Name = "Sony PlayStation 5 Digital Edition",
                Url = "https://www.wehkamp.nl/sony-playstation-5-digital-edition-16644185/",
                IncludeText = "in winkelmandje"
             },
        };

        public static ApplicationSettings GetSettings()
        {
            var settings = new ApplicationSettings();
            
            new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build()
                .Bind(settings);

            return settings;
        }

        public static async Task Main(string[] args)
        {
            var appSettings = GetSettings();

            var api = new TelegramBotAPI(appSettings.ApiKey);

            var webClient = new System.Net.WebClient();

            var sources = GetSources();

            while (true)
            {
                foreach (var item in sources)
                {
                    try
                    {
                        var webPage = await webClient
                            .DownloadStringTaskAsync(item.Url)
                            .ContinueWith(r => r.Result);

                        var validExclusion = string.IsNullOrEmpty(item.ExcludeText) || !webPage.Contains(item.ExcludeText, StringComparison.OrdinalIgnoreCase);
                        var validInclusion = string.IsNullOrEmpty(item.IncludeText) || webPage.Contains(item.IncludeText, StringComparison.OrdinalIgnoreCase);
                        var isValid = validExclusion && validInclusion;

                        Console.WriteLine($"{(isValid ? "v" : "x")} {item.Store} - [{item.Name}]({item.Url})");

                        if (isValid)
                        {
                            var message = $"{(isValid ? "🔵" : "🔴")} {item.Store} - [{item.Name}]({item.Url})";
                            await api.SendMarkdownMessageAsync(appSettings.ChatId, message, true, false);
                        }
                    }
                    catch (Exception ex)
                    {
                        var message = $"🔴 {item.Store} - {item.Name} [{ex.Message?.Substring(0, 15)}]";
                        Console.WriteLine(message);
                    }
                }

                await Task.Delay(1000 * 60);
            }
        }
    }
}
