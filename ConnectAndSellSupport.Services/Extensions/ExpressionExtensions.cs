using System;
using System.Linq.Expressions;

namespace ConnectAndSellSupport.Services.Extensions
{
    public static class ExpressionExtensions
    {
        public static Expression<Func<T, bool>> AndAlso<T>(
            this Expression<Func<T, bool>> expr1,
            Expression<Func<T, bool>> expr2)
        {
            var parameter = Expression.Parameter(typeof(T));

            var leftVisitor = new SubstitutionExpressionVisitor(expr1.Parameters[0], parameter);
            var left = leftVisitor.Visit(expr1.Body);

            var rightVisitor = new SubstitutionExpressionVisitor(expr2.Parameters[0], parameter);
            var right = rightVisitor.Visit(expr2.Body);

            return Expression.Lambda<Func<T, bool>>(
                Expression.AndAlso(left, right), parameter);
        }

        private class SubstitutionExpressionVisitor : ExpressionVisitor
        {
            private readonly Expression _oldValue;
            private readonly Expression _newValue;

            public SubstitutionExpressionVisitor(Expression oldValue, Expression newValue)
            {
                _oldValue = oldValue;
                _newValue = newValue;
            }

            public override Expression Visit(Expression node)
            {
                return node == _oldValue ? _newValue : base.Visit(node);
            }
        }
    }
}
