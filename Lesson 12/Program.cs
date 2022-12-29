using Lesson_12;

Console.WriteLine("*****Fun with Encapsulation****\n");
Employee emp = new Employee("Marvin", 456, 30000);
emp.GiveBonus(1000);
emp.DisplayStats();

//Использовать методы get/set для взаимодействия
//с именем сотрудника, предоставленого обьектом
emp.SetName("Marv");
Console.WriteLine("Employee is named: {0}", emp.GetName());
Console.ReadLine();