using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceExample
{
    public class Service1 : IService1
    {
        public string HelloWorld()
        {
            return string.Format("Hello world!");
        }

        public string GetName(string Name)
        {
            return "Hello " + Name;
        }

        public string GetAverage(int M1, int M2, int M3)
        {
            double Avg = (M1 + M2 + M3) / 3.0;
            return Avg.ToString();
        }

        public int GetMax(int[] ar)
        {
            int Max = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > Max)
                {
                    Max = ar[i];
                }
            }
            return Max;
        }

        public string DoesStudentPass(Student S)
        {
            double Avg = (S.M1 + S.M2 + S.M3) / 3.0;
            if (Avg < 60)
                return S.StudentName + " Fails";
            else
                return S.StudentName + " Passes";
        }
    }
}
