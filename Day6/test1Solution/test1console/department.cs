using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1console
{
    public class department
    {
        int deptid;
        string name;    


        public department(int deptid, string name)
        {
            this.deptid = deptid;   
            this.name = name;   
        }

        public int getDeptid() { return deptid; }       
        public string getName() { return name; }    
            


    }
}
