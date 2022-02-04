using System;
namespace unixtimehelper{
public class group
{
	// Перевод времени из таймштампа в гринвич
	public static DateTime UtcToDateTime( double unixTimeStamp )  
    {
        // Unix timestamp is seconds past epoch
        DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        dateTime = dateTime.AddSeconds( unixTimeStamp ).ToLocalTime();
        return dateTime;
    }
    // Переворд даты в таймштамп
    public static double DateTimeToUtc( DateTime realTime )  
    {
        // Unix timestamp is seconds past epoch
        double unixTimeStamp = ((DateTimeOffset)realTime).ToUnixTimeSeconds();
        return unixTimeStamp;
    }
    // Перевод времени из таймштампа в Омское
    public static DateTime UtcToOmsk( double unixTimeStamp )  
    {
        // Unix timestamp is seconds past epoch
        DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
        dateTime = dateTime.AddSeconds( unixTimeStamp ).ToLocalTime();
        return dateTime;
    }
    // Изменение времени без изменения даты
    public static DateTime ChangeTime(DateTime dateTime, int hours = 0, int minutes = 0, int seconds = 0)
    {
        return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, hours, minutes, seconds, 0, dateTime.Kind);
    }
}
}