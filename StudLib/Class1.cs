using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudLib {

    public interface ISubject

    {

        double AvgBal();

        string SubjectName { get; set; }

    }

    public class Student

    {

        public double Rating(ISubject obj)

        {

            switch (obj.SubjectName)

            {

                case "Programming":

                    return obj.AvgBal() * 10;

                    break;

                case "Administration":

                    return obj.AvgBal() * 5;

                    break;

                default:

                    return 0;

            }

        }

    }
}