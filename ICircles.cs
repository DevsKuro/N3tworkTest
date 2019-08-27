using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3tworkTest
{
    public interface IIdentifiable
    {
        string GetId();

    }

    public interface ICircles
    {
        IIdentifiable[] CalculateCollisions(IIdentifiable[] shapes);
        IIdentifiable[] CalculateCircleCollisions(IIdentifiable[] circles);
    }

    class Circle : ICircles
    {
        string id;
        string position;
        string radius;
        public IIdentifiable[] CalculateCircleCollisions(IIdentifiable[] circles)
        {
            for (int i = 0; i < circles.Length; i++)
            {
                for (int j = 0; j < circles.Length; j++)
                {
                    if(i != j)
                    {

                    }
                }
            }
            return null;
        }

        public IIdentifiable[] CalculateCollisions(IIdentifiable[] shapes) { return null; }

        //First we have to identify the object
        //if is a circle create a new object, else throw an notImplemented exception or ignore it
        //After assigning values of each object (circles) they have to go to an array of circles
        //Going through the array the data of each object must be contrast with the other elements to check
        //If a flag is rise by the following circumstances, both object name must be added to a new result array
        //if the starting point is the same 
        //if the starting point is within the area of another circle 

    }
}
