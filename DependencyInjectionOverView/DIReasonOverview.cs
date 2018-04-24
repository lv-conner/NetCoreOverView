using System;

/// <summary>
/// 控制反转与依赖注入
/// </summary>

namespace DependencyInjectionOverView
{
    public class A
    {
        private B bInstance;

        public A(B bInstance)
        {
            this.bInstance = bInstance;
        }

        public B BInstance { get => bInstance; set => bInstance = value; }
    }

    public class B
    {
        public B()
        {

        }
    }
}
