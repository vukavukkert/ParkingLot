using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    class Car
    {
        public string colour;
        public string model;
        public string mark;
        public string number;
        public string arrivaltime;


        public Car(string colour = "неизвестно", string model = "неизвестно", string mark = "неизвестно", string number = "неизвестно", string arrivaltime = "неизвестно")
        {
            this.colour = colour;
            this.model = model;
            this.mark = mark;
            this.number = number;
            this.arrivaltime = arrivaltime;
        }

        public void Display()
        {
            Console.WriteLine($" Марка: {mark}, Модель : {model}, Цвет: {colour}, Номер: {number}, Время прибытия {arrivaltime}");
        }
    }
}
