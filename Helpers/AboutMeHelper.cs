using Website.Models;
namespace Website.Helpers
{
    public class AboutMeHelper
    {
        public static int Calculate(DateTime birthdate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthdate.Year;

            if (birthdate.Date > today.AddYears(-age)) age--;
            return age;
        }

        public static string ElementarySummarized()
        {
            string summary = "When I was around the age of 6, I begun learning at Muller Magnet Elementary school!\r\n            This school recieved the National award of merit for 2025!\r\n            I recieved general education here as any typical american student does.\r\n            Nothing crazy or suprising there, but I did recieve some accolades here and there.\r\n            Such as winning a science award for a robot I created with another student!\r\n            Sadly that robot wasn't ours to keep so it has been lost to time.\r\n            A memorable moment that I had here was being the only student in my 4th grade class to recieve an autograph from a hollywood celebrity for an assignment designed to be a long distance letter sent to a famous person of our choice.\r\n            Sadly no one in my class recieved one back, except me!";
            return summary;
        }

        public static string MiddleSummarized()
        {
            string summary = "By the time I was 12 or 13 I migrated over to Davidsen Middle School!\r\n            I don't have too many memories here, however I do remember getting better at my Math Skills which helped me in my future programming ventures!\r\n            Before I was ever introduced to Algebra, I struggled pretty hard with Math.\r\n            But these days Algebra remains my favorite math subject which will certaintly come in handy in this business!\r\n            I can confidently say if it weren't for my growth in algebra and math during this time, I probably couldn't grasp programming. Yet here we are!";
            return summary;
        }

        public static string HighSummarized()
        {
            string summary = "Fast forward 3 years and I entered Alonso High School!\r\n            I recieved the honor roll 4 times and acquired straight A's during my incumbency.\r\n            It is something that is still a mystery to me, but it seems as if during my time during middle school that my work ethic and mentality shifted for the better.\r\n            I also gained personal achievements as well!\r\n            I held 3 World Records doing a hobby I dabbled in during my free time when I was away from school called Speedrunning!\r\n            I also participated in some speedrunning charity events during my time as a Speedrunner!\r\n            Overall, I came out a B student with all this! All I can say is, this wasn't/isn't my final form. I intend to grow further.";
            return summary;
        }

        public static string SpeedrunnerSummarized()
        {
            string summary = "I have many hobbies! I really love to exercise to keep myself fit!\r\n        One of my bigger hobbies that I used to do was something called Speedrunning.\r\n        Which I brefly mentioned before!\r\n        This is a competitive E-sport with the goal of beating a game as fast\r\n        as humanly possible. These personal bests and records are recorded on\r\n        websites to track what the world record may be at any given point in time.\r\n        My Speedrunning career lasted for 4 years during 2017-2020. I stopped due to time constraints!\r\n        Overall, I have achieved 10 World Records during my time as a speedrunner for some pretty big games!\r\n        Below is a comprehenive list of every big game I have ran; plus some honorable mentiones!";
            return summary;
        }

        public static string[] GodOfWarResults()
        {
            string[] GodOfWarRecords = { "4:39:08", "4:34:23", "4:30:26" };
            return GodOfWarRecords;
        }

        public static string DaysGoneResult()
        {
            string DaysGoneRecord = "17:18:32";
            return DaysGoneRecord;
        }

        public static string[] TwilightPrincessAnyPercentWithAmiiboResults()
        {
            string[] TPAnyPercentAmiiboRecord = { "3:57:49", "3:46:25", "3:45:57", "3:43:58", "3:43:30", "3:42:05", "3:40:08", "3:36:09" };
            return TPAnyPercentAmiiboRecord;
        }

        public static string TwilightPrincessAnyPercentNoAmiiboResults()
        {
            string TPAnyPercentNoAmiiboRecord = "3:48:59";
            return TPAnyPercentNoAmiiboRecord;
        }

        public static string TwilightPrincess100PercentResult()
        {
            string TP100PercentResult = "8:07:48";
            return TP100PercentResult;
        }

        public static string[] TwilightPrincessGoronMinesRTAResults()
        {
            string[] TPGMRTAResults = { "1:24:36", "1:24:15", "1:22:34" };
            return TPGMRTAResults;
        }

        public static string[] TwilightPrincessAllDungeonsResults()
        {
            string[] TPAllDungeonsResults = { "4:46:09", "4:37:10", "4:32:57" };
            return TPAllDungeonsResults;
        }

        public static string TwilightPrincessGlitchlessMasterSwordResult()
        {
            string TPGlitchlessResult = "2:38:08";
            return TPGlitchlessResult;
        }

        public static string[] HarryPotterResults()
        {
            string[] HarryPotterRecords = { "1:46:14", "1:45:08", "1:43:34" };
            return HarryPotterRecords;
        }
        public static string[] GameNames()
        {
            string[] GameNames = { "God of War", "Days Gone", "The Legend of Zelda: Twilight Princess HD", "Harry Potter and the Deathly Hallows: Part 2" };
            return GameNames;
        }
        public static string[] Categories()
        {
            string[] Categories = { "Any%", "Any% (No Amiibo)", "100%", "All Dungeons", "Glitchless (Master Sword)", "Goron Mines RTA" };
            return Categories;
        }
    }
}
