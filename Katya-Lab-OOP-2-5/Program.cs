using HtmlAgilityPack;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;

namespace Katya_Lab_OOP_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string url = "https://world-weather.ru/pogoda/russia/moscow/";

            //using (WebClient client = new WebClient())
            //{
            //    string html = client.DownloadString(url);

            //    HtmlDocument doc = new HtmlDocument();
            //    doc.LoadHtml(html);

            //    // Получение элемента с информацией о погоде
            //    HtmlNode node = doc.DocumentNode.SelectSingleNode("//div[@class='forecast-total-info-block-text']");

            //    // Получение строки с информацией о ветре
            //    string wind = node.Descendants("td").Where(d => d.InnerText.Contains("ветер")).FirstOrDefault()?.InnerText;

            //    // Извлечение силы ветра и его направления с помощью регулярных выражений
            //    Regex regex = new Regex(@"([\d,]+)\sм/c,\s(.+)");
            //    Match match = regex.Match(wind);

            //    if (match.Success)
            //    {
            //        string windSpeed = match.Groups[1].Value;
            //        string windDirection = match.Groups[2].Value;

            //        Console.WriteLine($"Сила ветра: { windSpeed}  м/c");
            //        Console.WriteLine($"Направление ветра: {windDirection}");
            //    }
            //}
            string url = "https://www.gismeteo.ru/weather-moscow-4368/";
            string html = new WebClient().DownloadString(url);

            // Найти блок с информацией о погоде
            Match weatherBlock = Regex.Match(html, @"<div class=""weather__body"".+?</div>\s*</article>");

            // Найти направление ветра
            Match windDirectionMatch = Regex.Match(weatherBlock.Value, @"<div class=""weather__info-item"" title=""Направление ветра""><svg.+?><use.+?transform=""rotate\((\d+)\)""/></svg></div>");
            string windDirection = windDirectionMatch.Groups[1].Value;

            // Найти силу ветра
            Match windSpeedMatch = Regex.Match(weatherBlock.Value, @"<div class=""weather__info-item"" title=""Скорость ветра"">([0-9]+).+?<span\sclass=""select__item-label"">м/с</span></div>");
            string windSpeed = windSpeedMatch.Groups[1].Value;

            Console.WriteLine($"Направление ветра: {windDirection}°");
            Console.WriteLine($"Сила ветра: {windSpeed} м/с");
        }
    }
}