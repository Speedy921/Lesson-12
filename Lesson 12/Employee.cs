using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    class Employee
    {
        //поля данных 
        private string _empName;
        //метод доступа (метод get)
        public string GetName() => _empName;
        //метод изменения (метод set)
        public void SetName(string name)
        {
            //перед присванием проверить входное значение
            if(name.Length > 15)
            {
                Console.WriteLine("Erorr! Name length exceeeds 15 characters!"); //ошибка! Длина имени превышает 15 символов!
            }
            else
            {
                _empName = name;
            }
        }
        private int _empId;
        private float _currPay;

        //конструкторы
        public Employee() { }
        public Employee(string name, int id, float pay)
        {
            _empName = name;
            _empId = id;
            _currPay = pay;
        }

        //методы
        public  void GiveBonus(float amount) => _currPay += amount;
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", _empName); //имя сотрудника
            Console.WriteLine("ID: {0}", _empId); //инедетификационный номер сотрудника
            Console.WriteLine("Pay {0}", _currPay); //текущая выплата
        }
    }
}
