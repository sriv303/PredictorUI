using Newtonsoft.Json;
using System.Diagnostics;

namespace PredictorUI.Common
{
    public class MatchService
    {
        string workingDirectory = "C:\\Users\\Abhi\\Documents\\Schoolwork\\Computer Science\\ScorePredictor\\Server";
        public void PredictScore(int id)
        {
            var settings = new JsonSerializerSettings();
            settings.StringEscapeHandling = StringEscapeHandling.EscapeHtml;
            RunPythonScriptAndGetOutput(id);
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
                WorkingDirectory= workingDirectory

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


    }
}
