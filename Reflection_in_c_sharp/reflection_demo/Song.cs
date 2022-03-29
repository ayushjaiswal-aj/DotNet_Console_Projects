using System;
using System.Collections.Generic;
using System.Text;

public abstract class Song
{
    public void ResumeSong() {
        Console.WriteLine("Song Playing..");
    }
    abstract public Song PlaySong();
    abstract public bool StopSong();
    abstract public bool RemoveSong();
    abstract public int SongCount();
}
