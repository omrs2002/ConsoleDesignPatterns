
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPatterns.Visitor.Employees
{
    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    public interface IVisitor
    {
        void Visit(Element element);
    }
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }



}
