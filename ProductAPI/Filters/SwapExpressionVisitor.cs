using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProductAPI.Filters
{
    public class SwapExpressionVisitor : System.Linq.Expressions.ExpressionVisitor
    {
        private readonly Expression from, to;
        public SwapExpressionVisitor(Expression from, Expression to)
        {
            this.from = from;
            this.to = to;
        }
        public override Expression Visit(Expression node)
        {
            return node == from ? to : base.Visit(node);
        }
        public static Expression Swap(Expression body, Expression from, Expression to)
        {
            return new SwapExpressionVisitor(from, to).Visit(body);
        }
    }
}
