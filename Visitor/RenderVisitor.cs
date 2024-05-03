﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using template_method;
namespace Visitor
{
    public class RenderVisitor : IVisitor
    {
        public void Visit(HTMLElement element)
        {
            element.Render();
        }
    }

}
