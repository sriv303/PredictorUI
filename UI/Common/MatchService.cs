using Newtonsoft.Json;
using PredictorUI.Models;
using System.Diagnostics;

namespace PredictorUI.Common
{
    public class MatchService
    {
        string workingDirectory = "C:\\Users\\Abhi\\Documents\\Schoolwork\\Computer Science\\ScorePredictor\\Server";
        public string PredictScore(int id)
        {
            var settings = new JsonSerializerSettings
            {
                StringEscapeHandling = StringEscapeHandling.EscapeHtml
            };
            return RunPythonScriptAndGetOutput(id);
        }

        private string RunPythonScriptAndGetOutput(int matchId)
        {
            ProcessStartInfo start = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = string.Format("\"{0}\" \"{1}\"", $"{workingDirectory}\\startup.py", matchId),
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                WorkingDirectory = workingDirectory

            };

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string stderr = process.StandardError.ReadToEnd(); // Capture any errors
                    string result = reader.ReadToEnd(); // Capture the output
                    return result;
                }
            }
        }

        public MatchReport TranformScoreCard(MatchDetails matchDetails)
        {


            var scoreCard = matchDetails.ScoreCard;
            var balls = JsonConvert.DeserializeObject<List<Ball>>(scoreCard);

            var firstInningsOvers = balls.Where(b => b.Innings == 1).GroupBy(i => i.OverNumber).Select(s => new Over { Balls = s.ToList() }).ToList();
            var secondInningsOvers = balls.Where(b => b.Innings == 2).GroupBy(i => i.OverNumber).Select(s => new Over { Balls = s.ToList() }).ToList();

            var matchReport = new MatchReport
            {
                MatchDate = matchDetails.MatchDate,
                MatchId = matchDetails.Id,
                VenueName = matchDetails.Venue.Name,
                TeamAInnings = new Innings { Overs = firstInningsOvers },
                TeamBInnings = new Innings { Overs = secondInningsOvers }
            };

            return matchReport;

        }


    }
}
