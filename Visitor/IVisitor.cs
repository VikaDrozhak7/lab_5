using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using template_method;

namespace Visitor
{
    public interface IVisitor
    {
        void Visit(HTMLElement element);
    }

}
