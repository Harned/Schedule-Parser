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
		// parse HTML table
		foreach (HtmlNode table in doc.DocumentNode.SelectNodes("//table")) {
            int colcount = 0;
            int rowcount = 0;
            // Console.WriteLine("Found: " + table.Id);
        foreach (HtmlNode row in table.SelectNodes("tr")) {
            rowcount++;
            colcount = 0;
            Console.WriteLine("_______________________NewRow_______________________");
        foreach (HtmlNode cell in row.SelectNodes("th|td")) {
            colcount++;
            Console.WriteLine("cell: " + cell.InnerText);
            if(cell.HasAttributes){
                foreach (HtmlAttribute atr in cell.Attributes){
                    Console.Write("atrib:" + atr.Name + " = " + atr.Value + " ");
                }
                Console.Write("\n");
            }
            }
        }
    }
    DateTime timeStart = ChangeTime(DateTime.Now);
	}
}