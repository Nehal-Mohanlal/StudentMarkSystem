using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksSytem
{
    public class PartTimeStudents : Students
    {
        public PartTimeStudents(int StudNum, string StudName, int mark, string result, double fees, string type) : base(StudNum, StudName , mark , result , fees, type)
        {
            this.Payment1 = CaclulatePayment(); 

        }
        public PartTimeStudents()
        {

        }

        public override double CaclulatePayment()
        {
            Payment1 = Fees - (Fees * 0.10);
            return Payment1; 
        }
    }
}
