using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace HW_2
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string key = "952eb1f3";
            string Url = $"http://www.omdbapi.com/?apikey={key}"; //copy your address
            string jsonData;
            string title = movieTitle.Value;

            var fullUrl = new StringBuilder(Url);
            fullUrl.Append($"&t={title}");

            HttpWebRequest request = WebRequest.Create(fullUrl.ToString()) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                jsonData = reader.ReadToEnd();
            }
            var result = JsonConvert.DeserializeObject<Movie>(jsonData);
            
            ttl.InnerHtml = result.Title;
            year.InnerHtml = result.Year;
            release.InnerHtml = result.Released;
            genre.InnerHtml = result.Genre;
            director.InnerHtml = result.Director;
            actors.InnerHtml = result.Actors;
            lang.InnerHtml = result.Language;
            country.InnerHtml = result.Country;
        }
    }
}