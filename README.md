# WCF-Web-Services-With-Client-Example
ASP.NET MVC client that consumes a WCF web service and displays the results

The WCF service contract declares the following methods:

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

I used this Youtube video from Ripon Datta as a guide to create the client and provided my own web service implementations.

https://www.youtube.com/watch?v=GQsLaLOAKIk

Thanks Ripon!
