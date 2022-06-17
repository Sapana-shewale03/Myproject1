using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.oops
{
    class Carobj
    {
        public long modelno;
        public string carname;
        public string car_color;
        public double prize;
        static void Main(string[] args)
        {
            Carobj car = new Carobj();
            car.modelno = 1434;
            car.carname = "baleno";
            car.car_color = "black";
            car.prize = 34545.55;

            Carobj car1 = new Carobj();
            car1.modelno = 4342;
            car1.carname = "Alcazar";
            car1.car_color = "blue";
            car1.prize = 343544.43;

            Carobj car2 = new Carobj();
            car2.modelno = 43434;
            car2.carname = "Ciaz";
            car2.car_color = "White";
            car2.prize = 4354545;
            Console.WriteLine(car.modelno + " " + car.carname + " " + car.car_color + " " + car.prize);
            Console.WriteLine(car1.modelno + " " + car1.carname + " " + car1.car_color + " " + car1.prize);
            Console.WriteLine(car2.modelno + " " + car2.carname + " " + car2.car_color + " " + car2.prize);

        }
    }

    /////// code for students
    class student
    {
        public int id;
        public string name;
        public int m1;
        public int m2;
        public int m3;
        int total;
        float perc;
        public void studdetail()
        {
            Console.WriteLine("enter id\t name \t  m1 \t  m2 \t m3\t");

            id = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            m1 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            m3 = Convert.ToInt32(Console.ReadLine());
            total = m1 + m2 + m3;


        }

        public float calculateperc()
        {
            return perc = total / 3;
        }

        public void display()
        {
            Console.WriteLine("enter detail " + id + " " + name + " " + m1 + " " + m2 + " " + m3);


        }

        static void Main(string[] args)
        {
           student st = new student();
            st.studdetail();
            st.display();
            Console.WriteLine("Total perc is " + st.calculateperc());
        }


    }
}
