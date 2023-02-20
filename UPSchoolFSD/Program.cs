using LuckySister.Console;
using UpSchool.Domain.Entities;

SelectionManager selectionManager= new SelectionManager();

selectionManager.AddAttendee("Aybike Boran");
selectionManager.AddAttendee("Umay Boran");
selectionManager.AddAttendee("Selcen Boran");
selectionManager.AddAttendee("Ömer Faruk Sönmez");
selectionManager.AddAttendee("Mayato Boran");

int luckyCount = 3;
selectionManager.MakeSelection(luckyCount);

List<Attendee> luckyList = selectionManager.GetLuckyList();
luckyList.ForEach(lucky => Console.WriteLine(lucky.FullName));
Console.ReadLine();
