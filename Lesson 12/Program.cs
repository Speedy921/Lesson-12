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

//Длина 15  символов! На консоль выводится сообщение об ошибке.
Employee emp2 = new Employee();
emp2.SetName("Xena the warrior princess");
Console.ReadLine();