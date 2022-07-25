using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1evaluationOnClass
{
    interface car
    {
        float GetMilage();
    }

    class SUV : car
    {
        public float GetMilage()
        {
            float Milage = 14;
            return Milage;        }
    }

    class SEDAN : car
    {
        public float GetMilage()
        {
            float Milage = 18;
            return Milage;
        }
    }
    class HATCHBACK : car
    {
        public float GetMilage()
        {
            float mileage = 25;
            return mileage;
        }
    }
    class mileage
    {
        public static void Main(String[] args)
        {
            HATCHBACK car1 = new HATCHBACK();
            SEDAN car2 = new SEDAN();
            Console.WriteLine(car1.GetMilage());
            Console.WriteLine(car2.GetMilage());

            Console.ReadKey();
        }
    }

    
}

