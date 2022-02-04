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
		// Достаём веб страницу
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
		var web = new HtmlWeb();
        web.OverrideEncoding = Encoding.GetEncoding("windows-1251");
		var doc = web.Load("http://fkn.omsu.ru/academics/Schedule/schedule2_1.htm");
		// Парсим таблицу HTML
		foreach (HtmlNode table in doc.DocumentNode.SelectNodes("//table")) {
            // Счёт столбцов и строк
            int colcount = 0;
            int rowcount = 0;
        // Счёт новой строки, обнуление счёта столбца, обозначение новой строки в выводе в консоль 
        foreach (HtmlNode row in table.SelectNodes("tr")) {
            rowcount++;
            colcount = 0;
            Console.WriteLine("_______________________NewRow_______________________");
        // Обработка ячеек
        foreach (HtmlNode cell in row.SelectNodes("th|td")) {
            colcount++;
            Console.WriteLine("cell: " + cell.InnerText);
            // Берём атрибуты ячейки и выводим
            if(cell.HasAttributes){
                foreach (HtmlAttribute atr in cell.Attributes){
                    Console.Write("atrib:" + atr.Name + " = " + atr.Value + " ");
                }
                Console.Write("\n");
            }
            }
        }
    }
    // DateTime timeStart = ChangeTime(DateTime.Now);
	}
}