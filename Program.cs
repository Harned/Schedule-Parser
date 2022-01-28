using System;
using HtmlAgilityPack;
using System.Linq;
using System.Text;
					
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
		var HTMLTableTRList = from table in doc.DocumentNode.SelectNodes("//table").Cast<HtmlNode>()
            from row in table.SelectNodes("tr").Cast<HtmlNode>()
            from cell in row.SelectNodes("th|td").Cast<HtmlNode>()
            select new {/*rows = table.sdf,*/ Cell_Text = cell.InnerText, node =cell.Attributes.Count };

		// now showing output of parsed HTML table
		foreach(var cell in HTMLTableTRList) 
		{
    		Console.WriteLine("{0}", /*cell.Cell_Text,*/ cell.node);
		}
	}
}