using System;

public class Song
{
	public string title;
	public string artist;
	public int duration;
	// static is attributes that belongs to class
	public static int songCount = 0;
	
	public Song(string aTitle, string aArtist, int aDuration)
	{
		title = aTitle;
		artist = aArtist;
		duration = aDuration;
		songCount++;
	}

	public int getSongCount()
	{
		return songCount;
	}
}
