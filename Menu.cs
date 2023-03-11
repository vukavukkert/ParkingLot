using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    class Menu
    {
        private static List<Car> Cars = new List<Car>();
        public static void CarMenu(ref int num)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Добро пожаловать в меню, введите число, что бы выбрать нужную услугу! \n Добавить машину: 1 \n Найти машину: 2 \n Отобразить информацию о машине: 3 \n Добавить машину на парковку: 4 \n Удалить машину из парковки: 5 \n Очистить парковку: 6 \n Посмотреть все машины на парковке: 7 ");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1: AddCar(ref Cars); break;
                case 2: FindCar(ref Cars); break;
                case 3:
                    Console.WriteLine("Введите номер машины на парковке:");
                    int order = int.Parse(Console.ReadLine());
                    CarInfo(ref Cars, order); break;
                case 4:  Parking.AddCar(ref Cars); break;
                case 5: Parking.RemoveCar(ref Cars); break;
                case 6: Parking.ClearAllCars();break;
                case 7: Parking.DisplayParked(); break;
            }
        }

        public static void CarInfo(ref List<Car> Cars, int order)
        {
            if (order > Cars.Count + 1 && order < 0)
            {
                Console.WriteLine("Такой машины нет");
            }
            else { Cars[order].Display(); }
            
        }

        public static void FindCar(ref List<Car> Cars)
        {
            Console.WriteLine("Введите номер который указан на машине:");
            string number = Console.ReadLine();
            int index = 0;
            bool found = false;
            foreach (Car car in Cars)
            {
                if (car.number == number)
                {
                    found = true;
                    car.Display();
                    Console.WriteLine($"Положение в списке: {index}");
                    break;
                }
                index++;
            }
            if (found == false) Console.WriteLine("Не смогли найти");
        }

        public static void AddCar(ref List<Car> Cars)
        {
            Console.WriteLine("Введите параметры новой машины:");

            Console.WriteLine("Марка:");
            string mark = Console.ReadLine();
            Console.WriteLine("Модель:");
            string model = Console.ReadLine();
            Console.WriteLine("Цвет:");
            string colour = Console.ReadLine();
            Console.WriteLine("Номер:");
            string number = Console.ReadLine();
            string arrivaltime = DateTime.Now.ToString("F");
            Car newCar = new Car(colour, model, mark, number, arrivaltime);
            Cars.Add(newCar);
            Console.WriteLine($"Машина была создана! Её номер в гараже: {Cars.Count - 1}");
        }
    }
}
