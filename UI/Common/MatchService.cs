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
                //specifying parameters for pythons script
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
                    var stderr = process.StandardError.ReadToEnd(); // Capture any errors
                    var result = reader.ReadToEnd(); // Capture the output
                    return result.TrimEnd(['\r', '\n']);  //remove new line characters from the output
                }
            }
        }

        public MatchReport TranformScoreCard(MatchDetails matchDetails)

        //returning type match report
        {


            var scoreCard = matchDetails.ScoreCard;
            var balls = JsonConvert.DeserializeObject<List<Ball>>(scoreCard);
            //deserializing scorecard json string into list of ball objects

            var teamA = JsonConvert.DeserializeObject<List<string>>(matchDetails.StrTeamABatsmen);
            //Deseralizing team a json string into list of player names
            var teamB = JsonConvert.DeserializeObject<List<string>>(matchDetails.StrTeamBBatsmen);
            //Deseralizing team b json string into list of player names


            var firstInningsOvers = balls.Where(b => b.Innings == 1).GroupBy(i => i.OverNumber).Select(s => new Over { Balls = s.ToList() }).ToList();
            //Getting all balls inthe first innings and converting them to over objects
            var secondInningsOvers = balls.Where(b => b.Innings == 2).GroupBy(i => i.OverNumber).Select(s => new Over { Balls = s.ToList() }).ToList();
            //Getting all balls inthe second innings and converting them to over objects

            var matchReport = new MatchReport
            {
                MatchDate = matchDetails.MatchDate,
                MatchId = matchDetails.Id,
                VenueName = matchDetails.Venue.Name,
                TeamAInnings = new Innings { Overs = firstInningsOvers, Team = teamA },
                TeamBInnings = new Innings { Overs = secondInningsOvers, Team = teamB }
            };

            return matchReport;

        }


    }
}
