using System;
using static unixtimehelper.group;
// Предметы
public class Subject{
    string name = "Неизвестнвй предмет";
    string teacher = "Преподаватель неизвестен";
    DateTime timeStart = ChangeTime(DateTime.Now);
    DateTime timeStop = ChangeTime(DateTime.Now);
    // int rowspan = 1;
    // int colspan = 1;
    int room = 0;
    int building = 0;
    int subjectType = 0;
    int startWeek = 0;
    int endWeek = 0;
    int weekDay = 0;
    int group = 0;
    int subgroup = 0;

}
// Группы
public class Group{
    string groupName = "Неизвестная группа";
    int groupid = 0;
}
