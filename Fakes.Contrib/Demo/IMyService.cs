﻿using System.Collections.Generic;

namespace Demo
{
    public interface IMyService
    {
        void DoSomething();
        void DoSomething(MyClass obj);
        void DoSomethingDifferent(MyClass obj);
        void DoSomehtingOnMultiple(IEnumerable<MyClass> items);
        void DoSomehtingDifferentOnMultiple(IEnumerable<MyClass> items);
    }
}