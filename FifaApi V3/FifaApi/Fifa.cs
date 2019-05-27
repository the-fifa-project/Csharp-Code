using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaApi
{
    class Fifa
    {

        public List<Team> team = new List<Team>();

        public void getTeams()
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string dataJson;
            dataJson = downloader.DownloadString("http://localhost/Php-code/api/");
            team = JsonConvert.DeserializeObject<List<Team>>(dataJson);
        }

    }
}
