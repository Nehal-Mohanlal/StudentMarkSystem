using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksSytem
{
    public abstract class Students : IComparable 
    {

        int studentNumber;
        String StudentName;
        int average;
        String results;
        double fees;
        double Payment;
        string type; 

        protected Students(int studentNumber, string studentName, int average, String results, double fees, string type)
        {
            this.StudentNumber = studentNumber;
            this.StudentName1 = studentName;
            this.Average = average;
            this.Results = results;
            this.Fees = fees;
            this.type = type;
           // this.Payment1 = payment;
        }

        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string StudentName1 { get => StudentName; set => StudentName = value; }
        public int Average { get => average; set => average = value; }
        public String Results { get => results; set => results = value; }
        public double Fees { get => fees; set => fees = value; }
        public double Payment1 { get => Payment; set => Payment = value; }

        public string Type { get => type; set => type = value; }

        public abstract double CaclulatePayment();

        public Students()
        {

        }
        public override string ToString()
        {
            return StudentNumber + StudentName1 + average + results + fees + Payment1; 

        }

        public int CompareTo(object obj)
        {
            Students studentobj = obj as Students;
            return this.StudentNumber.CompareTo(studentobj.StudentNumber);
            
        }
    }
}
