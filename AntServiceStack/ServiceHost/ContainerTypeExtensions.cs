﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Funq;

namespace AntServiceStack.ServiceHost
{
    public static class ContainerTypeExtensions
    {
        /// <summary>
        /// Registers the type in the IoC container and
        /// adds auto-wiring to the specified type.
        /// </summary>
        /// <param name="serviceType"></param>
        /// <param name="inFunqAsType"></param>
        public static void RegisterAutoWiredType(this Container container, Type serviceType, Type inFunqAsType,
            ReuseScope scope = ReuseScope.None)
        {
            if (serviceType.IsAbstract || serviceType.ContainsGenericParameters)
                return;

            var methodInfo = typeof(Container).GetMethod("RegisterAutoWiredAs", Type.EmptyTypes);
            var registerMethodInfo = methodInfo.MakeGenericMethod(new[] { serviceType, inFunqAsType });

            var registration = registerMethodInfo.Invoke(container, new object[0]) as IRegistration;
            registration.ReusedWithin(scope);
        }

        /// <summary>
        /// Registers the type in the IoC container and
        /// adds auto-wiring to the specified type.
        /// The reuse scope is set to none (transient).
        /// </summary>
        /// <param name="serviceTypes"></param>
        public static void RegisterAutoWiredType(this Container container, Type serviceType,
            ReuseScope scope = ReuseScope.None)
        {
            //Don't try to register base service classes
            if (serviceType.IsAbstract || serviceType.ContainsGenericParameters)
                return;

            //获取到Container 的 RegisterAutoWired 方法
            //但是 都是接受泛型参数的
            //所以要把获取到的Method改成用泛型Method
            var methodInfo = typeof(Container).GetMethod("RegisterAutoWired", Type.EmptyTypes);
            var registerMethodInfo = methodInfo.MakeGenericMethod(new[] { serviceType });

            //调用泛型注册ICO
            var registration = registerMethodInfo.Invoke(container, new object[0]) as IRegistration;
            registration.ReusedWithin(scope);
        }

        /// <summary>
        /// Registers the types in the IoC container and
        /// adds auto-wiring to the specified types.
        /// The reuse scope is set to none (transient).
        /// </summary>
        /// <param name="serviceTypes"></param>
        public static void RegisterAutoWiredTypes(this Container container, IEnumerable<Type> serviceTypes,
            ReuseScope scope = ReuseScope.None)
        {
            foreach (var serviceType in serviceTypes)
                container.RegisterAutoWiredType(serviceType, scope);
        }
    }
}
