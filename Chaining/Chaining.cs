﻿using System;

namespace Chaining
{

    public interface IEquationBuilder { }

    public class EquationBuilder : IEquationBuilder
    {
        public EquationBuilder(Action<string> writer)
        {

        }
    }
    
    public class MarkupEquationBuilder : IEquationBuilder
    {
        public MarkupEquationBuilder(Action<string> writer)
        {

        }
    }



    public static class Operations
    {
        public static T Value<T>(this T builder, int constant) where T : IEquationBuilder
        {
            return builder;
        }
        public static T Literal<T>(this T builder, string variable) where T : IEquationBuilder
        {
            return builder;
        }
        public static T Add<T>(this T builder) where T : IEquationBuilder
        {
            return builder;
        }
        public static T Divide<T>(this T builder) where T : IEquationBuilder
        {
            return builder;
        }
        public static T Divide<T>(this T builder, Action<T> expression) where T : IEquationBuilder
        {
            return builder;
        }

        public static MarkupEquationBuilder Bold(this MarkupEquationBuilder builder, Action<MarkupEquationBuilder> expression)
        {
            return builder;
        }

        public static T Parentheses<T>(this T builder, Action<T> expression) where T : IEquationBuilder
        {
            return builder;
        }
    }
}
