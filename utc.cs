using System;
namespace unixtimehelper{
public class group
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
    public static DateTime ChangeTime(DateTime dateTime, int hours = 0, int minutes = 0, int seconds = 0)
    {
        return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, hours, minutes, seconds, 0, dateTime.Kind);
    }
}
}