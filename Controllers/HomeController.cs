using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Website.Helpers;
using Website.Models;

namespace Website.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        int Age = AboutMeHelper.Calculate(new DateTime(2001, 4, 6));
        int DeveloperAge = AboutMeHelper.Calculate(new DateTime(2023, 2, 28));
        string ElementarySchoolBio = AboutMeHelper.ElementarySummarized();
        string MiddleSchoolBio = AboutMeHelper.MiddleSummarized();
        string HighSchoolBio = AboutMeHelper.HighSummarized();
        string SpeedrunningBio = AboutMeHelper.SpeedrunnerSummarized();
        string[] GOWTimes = AboutMeHelper.GodOfWarResults();
        string DGTimes = AboutMeHelper.DaysGoneResult();
        string[] HPTimes = AboutMeHelper.HarryPotterResults();
        string[] GameNames = AboutMeHelper.GameNames();
        string[] Category = AboutMeHelper.Categories();
        string TPAnyPercentNoAmiibo = AboutMeHelper.TwilightPrincessAnyPercentNoAmiiboResults();
        string[] TPAnyPercent = AboutMeHelper.TwilightPrincessAnyPercentWithAmiiboResults();
        string TP100Percent = AboutMeHelper.TwilightPrincess100PercentResult();
        string[] TPGoronMinesRTA = AboutMeHelper.TwilightPrincessGoronMinesRTAResults();
        string TPGlitchless = AboutMeHelper.TwilightPrincessGlitchlessMasterSwordResult();
        string[] TPAllDungeons = AboutMeHelper.TwilightPrincessAllDungeonsResults();
        

        AboutMeModel model = new AboutMeModel()
        {
            MyAge = Age,
            DeveloperAge = DeveloperAge,
            ElementaryBio = ElementarySchoolBio,
            MiddleBio = MiddleSchoolBio,
            HighBio = HighSchoolBio,
            SpeedrunnerBio = SpeedrunningBio,
            GameName = GameNames,
            Category = Category,
            GodOfWarRecords = GOWTimes,
            DaysGoneRecords = DGTimes,
            HarryPotterRecords = HPTimes,
            TPAnyPercentRecords = TPAnyPercentNoAmiibo,
            TPAnyPercentWithAmiiboRecords = TPAnyPercent,
            TP100PercentRecords = TP100Percent,
            TPAllDungeonsRecords = TPAllDungeons,
            TPGoronMinesRTARecords = TPGoronMinesRTA,
            TPGlitchlessRecords = TPGlitchless
        };
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
