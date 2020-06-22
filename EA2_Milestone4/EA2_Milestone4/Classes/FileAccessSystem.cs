using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA2_Milestone4.Classes
{
    class FileAccessSystem
    {

        /*
         Preset
        {"Score":200600,"Name":"ABC","TimeFinish":"00:02:45","Difficulty":"Hard","GameSize":16}
        {"Score":195600,"Name":"DEF","TimeFinish":"00:03:30","Difficulty":"Hard","GameSize":16}
        {"Score":99400,"Name":"GHI","TimeFinish":"00:01:05","Difficulty":"Medium","GameSize":12}
        {"Score":89400,"Name":"JKL","TimeFinish":"00:01:40","Difficulty":"Medium","GameSize":12}
        {"Score":32100,"Name":"MNO","TimeFinish":"00:00:16","Difficulty":"Easy","GameSize":9}
        {"Score":28100,"Name":"PQR","TimeFinish":"00:00:40","Difficulty":"Easy","GameSize":9}

        End. Have to have space, as the program reads per new line
         */
        //Tips
        /*
         * 
         * 
         */
        public String getLibrary(String filename)
        {
            //purpose, to find the Directory of just the project.
            //so essentially, it just goes to the project itself, so going to the SaveFile.txt in this project
            //it has to be typed as "\\SaveData\\SaveFile.txt"
            var parent = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            return (parent + filename);
        }

        public List<PlayerStats> getScoreCards()
        {
            List<PlayerStats> players = new List<PlayerStats>();
            foreach (var item in getSaveFile().Split('\n'))
            {
                if(item.Length>2)
                {
                    players.Add(JsonConvert.DeserializeObject<PlayerStats>(item));
                }
            }
            return players;
        }

        public string getSaveFile()
        {
            //just in case file gets deleted
            if (!File.Exists(getLibrary("\\SaveData\\PlayerScores.txt")))
            {
                File.Create(getLibrary("\\SaveData\\PlayerScores.txt")).Close();
            }
            return File.ReadAllText(getLibrary("\\SaveData\\PlayerScores.txt"));
        }

        public void savePlayerScore(string SaveData)
        {
            File.AppendAllText(getLibrary("\\SaveData\\PlayerScores.txt"), SaveData + Environment.NewLine);
        }
        public void savePlayerScore(PlayerStats player)
        {
            File.AppendAllText(getLibrary("\\SaveData\\PlayerScores.txt"), JsonConvert.SerializeObject(player, Formatting.None) + Environment.NewLine);
        }

        public void savePlayerList(List<PlayerStats> players)
        {
            foreach (var item in players)
            {
                File.AppendAllText(getLibrary("\\SaveData\\PlayerScores.txt"), JsonConvert.SerializeObject(item, Formatting.None)+Environment.NewLine);
            }
        }
    }
}
