// See https://aka.ms/new-console-template for more informatio
using Event;
using static Event.Event;

int age = Convert.ToInt32(Console.ReadLine());

bool ableToDrive = Driver.AbleToDrive(age);

Console.WriteLine(ableToDrive);
