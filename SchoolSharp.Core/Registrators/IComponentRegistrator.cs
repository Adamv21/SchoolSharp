using SchoolSharp.Abstractions;
using SchoolSharp.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SchoolSharp.Core.Registrators
{
    public interface IComponentRegistrator
    {
        IEnumerable<ComponentRegistrationInfo> GatherFittings(ISchoolPlatformClient client);
    }

    public class AssemblyComponentRegistrator : IComponentRegistrator
    {
        private readonly Assembly assembly;


        public AssemblyComponentRegistrator(Assembly assembly)
        {
            assembly.GuardNotNull(nameof(assembly));
            this.assembly = assembly;
        }

        public IEnumerable<ComponentRegistrationInfo> GatherFittings(ISchoolPlatformClient client)
        {

            client.GuardNotNull(nameof(client));
            List<ComponentRegistrationInfo> result = new List<ComponentRegistrationInfo>();

            var components = assembly.GetTypes().Where(c => !c.IsAbstract && c.GetCustomAttribute<AutoRegisterComponent>() != null);
            foreach(var component in components)
            {
                var attribute = component.GetCustomAttribute<AutoRegisterComponent>();

                result.Add(new ComponentRegistrationInfo()
                {
                    ImplementationType = component,
                    InterfaceType = attribute.InterfaceType
                });
            }

            return result;
        }
    }
}
