using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Data;

namespace CSharp_Project.Models
{

    public class Songs
    {
        private DataSet ds;

        public Songs()
        {
            ds = new DataSet("playlist");

            DataTable dtSongs = new DataTable("songs");

            DataColumn dcId = new DataColumn("id");
            DataColumn dcArtist = new DataColumn("artist");
            DataColumn dcSong = new DataColumn("song");
            DataColumn dcDuration = new DataColumn("duration");
            DataColumn dcCategory = new DataColumn("category");
            DataColumn dcYear = new DataColumn("year");
            DataColumn dcLink = new DataColumn("link");

            ds.Tables.Add(dtSongs);
            dtSongs.Columns.Add(dcId);
            dtSongs.Columns.Add(dcArtist);
            dtSongs.Columns.Add(dcSong);
            dtSongs.Columns.Add(dcDuration);
            dtSongs.Columns.Add(dcCategory);
            dtSongs.Columns.Add(dcYear);
            dtSongs.Columns.Add(dcLink);

            ds.ReadXml(HttpContext.Current.Server.MapPath("~/App_Data/songs.xml"));
        }
        public DataRow[] GetSongs()
        {
            DataRow[] drArray = ds.Tables[0].Select();
            return drArray;
        }
        public DataRow GetSong(string id)
        {
            DataRow[] drArray = ds.Tables[0].Select("id='" + id + "'");
            return drArray[0];
        }

        public void AddSong()
        {
            DataRow dr = ds.Tables[0].NewRow();
            string a = HttpContext.Current.Request.Form["link"].ToString();
            string b = a.Replace("watch?v=", "embed/");

            dr["id"] = HttpContext.Current.Request.Form["id"];
            dr["artist"] = HttpContext.Current.Request.Form["artist"];
            dr["song"] = HttpContext.Current.Request.Form["song"];
            dr["duration"] = HttpContext.Current.Request.Form["duration"];
            dr["category"] = HttpContext.Current.Request.Form["category"];
            dr["year"] = HttpContext.Current.Request.Form["year"];
            dr["link"] = HttpContext.Current.Request.Form["link"];
            dr["link"] = b + (b.IndexOf("autoplay") < 0 ? "?autoplay=1" : "");

            ds.Tables[0].Rows.Add(dr);

            SaveSongs();
        }
        public void EditSong(string id)
        {
            DataRow dr = GetSong(id);
            
            string a = HttpContext.Current.Request.Form["link"].ToString();
            string b = a.Replace("watch?v=", "embed/");

            dr["artist"] = HttpContext.Current.Request.Form["artist"];
            dr["song"] = HttpContext.Current.Request.Form["song"];
            dr["duration"] = HttpContext.Current.Request.Form["duration"];
            dr["category"] = HttpContext.Current.Request.Form["category"];
            dr["year"] = HttpContext.Current.Request.Form["year"];
            dr["link"] = HttpContext.Current.Request.Form["link"];
            dr["link"] = b + (b.IndexOf("autoplay") < 0 ? "?autoplay=1" : "");

            SaveSongs();
        }

        public void DeleteSong(string id)
        {
            DataRow drSong = GetSong(id);
            drSong.Delete();

            SaveSongs();
        }

        public void SaveSongs()
        {
            ds.WriteXml(HttpContext.Current.Server.MapPath("~/App_Data/songs.xml"));
        }
    }

}