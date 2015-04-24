using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceExample
{
    [ServiceContract]
    public interface IService1
    {
        //Displays Hello World
        [OperationContract]
        string HelloWorld();

        //Displays Hello plus the name parameter it's passed
        [OperationContract]
        string GetName(string Name);

        //Returns the average of 3 integers
        [OperationContract]
        string GetAverage(int M1, int M2, int M3);
        
        //Returns the maximum value of an array it's passed
        [OperationContract]
        int GetMax(int[] ar);

        //Returns a string indicating whether a student has passed after being passed a student object
        [OperationContract]
        string DoesStudentPass(Student S);
    }
}