using System;
using System.Collections.Generic;
using System.Text;

public class Song
{
    private string _name;
    private string _title;
    private string _artist;
    private string _album;
    private string _language;

    public Song(string name, string title, string artist, string album, string language)
    {
        Name = name;
        Title = title;
        Artist = artist;
        Album = album;
        Language = language;
    }

    public string Name { get => _name; set => _name = value; }
    public string Title { get => _title; set => _title = value; }
    public string Artist { get => _artist; set => _artist = value; }
    public string Album { get => _album; set => _album = value; }
    public string Language { get => _language; set => _language = value; }
    
    public void PlaySong() {
        Console.WriteLine("Song playing..");
    }

    public Song AddSong(string songDetails) {
        string[] splited = songDetails.Split(',');
        return new Song(splited[0], splited[1], splited[2], splited[3], splited[4]);
    }

    public bool RemoveSong(List<Song> songList, int index)
    {
        if (songList.Count >= index)
        {
            songList.RemoveAt(index - 1);
            return true;
        }
        return false;
    }

    public int SongCount(List<Song> songList) {
        return songList.Count;
    }
}

