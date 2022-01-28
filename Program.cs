using System.ComponentModel;
using System;
using HtmlAgilityPack;
using System.Linq;
using System.Text;
using static unixtimehelper.group;
					
public class Program
{
	// description: Showing here how to parse complex web HTML table using HTML Agility Pack C#
	public static void Main()
	{
		// declare object of HtmlDocument
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
		var web = new HtmlWeb();
        web.OverrideEncoding = Encoding.GetEncoding("windows-1251");
		var doc = web.Load("http://fkn.omsu.ru/academics/Schedule/schedule2_1.htm");
		// Using LINQ to parse HTML table smartly 
		foreach (HtmlNode table in doc.DocumentNode.SelectNodes("//table")) {
            // Console.WriteLine("Found: " + table.Id);
        foreach (HtmlNode row in table.SelectNodes("tr")) {
            Console.WriteLine("row");
        foreach (HtmlNode cell in row.SelectNodes("th|td")) {
            Console.WriteLine("cell: " + cell.InnerText);
            }
        }
    }
    DateTime timeStart = ChangeTime(DateTime.Now);
	}
}