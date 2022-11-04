using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    //Now we will make our static VehicleFactory class.
    //It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter
    //Call this functionality in the Main method.

        //Create a static VehicleFactory class:
        //Add a GetVehicle method that will return an IVehicle based on the amount of tires it’s given as a parameter:
        //Make the method static
        //A return type of IVehicle
        //1 string parameter

    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numOfWheels)
        {
            //if(numOfWheels == 4)
            //{
            //    return new Car();
            //}
            //else if(numOfWheels == 2)
            //{
            //    return new Motorcycle();
            //}
            //else
            //{
            //    return new Car();
            //}

            switch (numOfWheels)
            {
                case 4:
                    return new Car();

                case 2:
                    return new Motorcycle();

                default:
                    return new Car();
            }    
        }
    }
}
