//Songs songs = new Songs(Server.MapPath(@"..\App_Data\songs.xml"));
//DataRow[] drArray = songs.GetSongs();

/*

public class Songs
{
    DataSet ds;

    public Songs(string path)
    {
        ds = new DataSet("playlist");

        DataTable dtSongs = new DataTable("songs");

        DataColumn dcId = new DataColumn("id");
        DataColumn dcArtist = new DataColumn("artist");
        DataColumn dcSong = new DataColumn("song");
        DataColumn dcDuration = new DataColumn("duration");
        DataColumn dcCategory = new DataColumn("category");
        DataColumn dcYear = new DataColumn("year");

        ds.Tables.Add(dtSongs);
        dtSongs.Columns.Add(dcId);
        dtSongs.Columns.Add(dcArtist);
        dtSongs.Columns.Add(dcSong);
        dtSongs.Columns.Add(dcDuration);
        dtSongs.Columns.Add(dcCategory);
        dtSongs.Columns.Add(dcYear);

        ds.ReadXml(path);
    }

    public DataRow[] GetSongs()
    {
        return ds.Tables[0].Rows;
    }
}
*/
