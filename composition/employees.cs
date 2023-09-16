using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class employees
    {
        public virtual int salary => 1000;
        public virtual string Bonus => "none";
        
        public List<Ibonus> bouns { get; private set; } = new List<Ibonus>();
        
        public override string ToString()
        {
            return $"{Bonus}\n" +
                $"total salary = {salary}";
        }

    }

    public class Residence : Ibonus
    {
        public  string Bonus => "Residence";
        public int salary => 1000;

    }
    public class overtime : Ibonus
    {
        public  int salary => 200;
        public  string Bonus => $"overtime {2}h";
        
    }
    interface Ibonus
    {
        int salary {get;}
        string Bonus { get;}
    }
}
