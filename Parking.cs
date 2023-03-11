using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    class Parking
    {
        public static List<Car> Parkinglot = new List<Car>();
        public static void RemoveCar(ref List<Car> Cars)
        {
            Console.WriteLine("Какую машину вы хотите удалить? Введите номер на машине:");
            string number = Console.ReadLine();
            bool found = false;
            int index = 0;
            foreach (Car car in Cars)
            {
                if (car.number == number)
                {
                    found = true;
                    car.Display();
                    break;
                }
                index++;
            }
            if (found == false) Console.WriteLine("Её уже нет!");
            Parkinglot.RemoveAt(index);
        }
        public static void AddCar(ref List<Car> Cars)
        {
            Console.WriteLine("Какую машину вы хотите добавить? Введите номер на машине:");
            string number = Console.ReadLine();
            bool found = false;
            int index = 0;
            foreach (Car car in Cars)
            {
                if (car.number == number)
                {
                    found = true;
                    car.Display();
                    break;
                }
                index++;
            }
            if (found == false) Console.WriteLine("Не смогли найти");
            Cars[index].arrivaltime = DateTime.Now.ToString("F");
            Parkinglot.Add(Cars[index]);
            Console.WriteLine($"Машина была добавлена! Её номер на парковке: {Parkinglot.Count - 1}");


        }
        public static void ClearAllCars()
        {
            Parkinglot.Clear();
        }
        public static void DisplayParked()
        {
            foreach (var car in Parkinglot)
            {
                car.Display();
            }
        }
    }
}
