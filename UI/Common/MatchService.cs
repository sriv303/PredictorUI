using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PredictorUI.Models;

namespace PredictorUI.Common
{
    public class MatchService
    {
        string pythonScriptPath = "C:\\Users\\Abhi\\Documents\\Schoolwork\\Computer Science\\ScorePredictor\\Server\\test.py";
        public void PredictScore(MatchInputs input)
        {
            var settings=new JsonSerializerSettings();
            settings.StringEscapeHandling=StringEscapeHandling.EscapeHtml;
            //var p = new Venue { Name = "WACA", Country="AUS" };
            var strInput = JsonConvert.SerializeObject(input);
            strInput = $"'{strInput}'";
            RunPythonScriptAndGetOutput(pythonScriptPath, strInput);
        }


      
     
        public string RunPythonScriptAndGetOutput(string scriptPath, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "python";
            start.Arguments = string.Format("\"{0}\" \"{1}\"", scriptPath, args);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            start.CreateNoWindow = true;

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
