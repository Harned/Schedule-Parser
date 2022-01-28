using System;

public class unixtime
{
	// description: Showing here how to parse complex web HTML table using HTML Agility Pack C#
	public static DateTime UtcToDateTime( double unixTimeStamp )  
    {
        // Unix timestamp is seconds past epoch
        DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        dateTime = dateTime.AddSeconds( unixTimeStamp ).ToLocalTime();
        return dateTime;
    }
    public static double DateTimeToUtc( DateTime realTime )  
    {
        // Unix timestamp is seconds past epoch
        double unixTimeStamp = ((DateTimeOffset)realTime).ToUnixTimeSeconds();
        return unixTimeStamp;
    }
    public static DateTime UtcToOmsk( double unixTimeStamp )  
    {
        // Unix timestamp is seconds past epoch
        DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
        dateTime = dateTime.AddSeconds( unixTimeStamp ).ToLocalTime();
        return dateTime;
    }
    }
