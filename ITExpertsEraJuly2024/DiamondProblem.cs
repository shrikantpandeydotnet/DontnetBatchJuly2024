using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraJuly2024
{
    public class DiamondProblem
    {
        public virtual void ParentMethod()
        {
            Console.WriteLine("I am a parent method");
        }
    }

    public class ChildDiamond1 :DiamondProblem
    {
        public override void ParentMethod()
        {
            Console.WriteLine("I am a child diamond1");
        }
    }

    public class ChildDiamond2 : DiamondProblem
    {
        public override void ParentMethod()
        {
            Console.WriteLine("I am a child diamond2");
        }
    }

    public class GrandChildDiamond : ChildDiamond1
    {
        public override void ParentMethod()
        {
            Console.WriteLine("I am a grand child diamond1");
        }
    }

    // GrandChildDiamond obj = new GrandChildDiamond(); obj.ParentMethod();
}
