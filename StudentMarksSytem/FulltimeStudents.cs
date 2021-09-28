using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksSytem
{
   public class FulltimeStudents: Students
    {

        public FulltimeStudents(int StudNum, string StudName, int mark, string result, double fees, string type) : base(StudNum, StudName, mark, result, fees, type)
        {
            this.Payment1 = CaclulatePayment(); 
        }
        public FulltimeStudents()
        {

        }

        public  override double CaclulatePayment()
        {
            Payment1 = Fees - (Fees * 0.15);
            return Payment1; 
        }
        
    }
}
