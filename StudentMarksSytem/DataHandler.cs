using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksSytem
{
    public class DataHandler 
    {


        List<Students> Students = new List<Students>();
        public delegate string checkresult(int mark); 
        

        public List<Students> InitList()
        {
            checkresult cr1 = new checkresult(result);  
            Students.Add(new FulltimeStudents(923, "Nehal", 78, cr1(78),   8.80, "F time"));
            Students.Add(new FulltimeStudents(581, "Sasuke", 97, cr1(97), 997.00, "F time"));

            Students.Add(new PartTimeStudents(165, "Naruto", 25, cr1(25), 776, "P time"));
            Students.Add(new PartTimeStudents(365, "sai", 56, cr1(56), 6764, "P time"));



            return Students; 

        }


        public string result(int mark)
        {
            if(mark < 0 && mark > 100)
            {
                return "invalid";
            }
            else if(mark > 0 && mark < 50)
            {
                return "Fail";
            }
            else if(mark>50 && mark< 75)
            {
                return "Passed"; 
            }
            else
            {
                return "Passed with distinction"; 
            }
        }
    }
}
