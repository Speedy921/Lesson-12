using Lesson_12;

Console.WriteLine("*****Fun with Encapsulation****\n");
Employee emp = new Employee("Marvin", 45, 123, 1000, "111-11-1111", EmployeePayTypeEnum.Salaried);
Console.WriteLine(emp.Pay);
emp.GiveBonus(1000);
Console.WriteLine(emp.Pay);

//Использовать методы get/set для взаимодействия
//с именем сотрудника, предоставленого обьектом
emp.Name="Marv";
Console.WriteLine("Employee is named: {0}", emp.Name);
Console.ReadLine();

//Длина 15  символов! На консоль выводится сообщение об ошибке.
Employee emp2 = new Employee();
emp2.Name="Xena the warrior princess";
Console.ReadLine();

Employee joe = new Employee();
joe.Age++;

