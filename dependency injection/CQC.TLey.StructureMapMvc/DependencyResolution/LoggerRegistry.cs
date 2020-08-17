using CQC.TLey.StructureMap.Lib.Impl;
using CQC.TLey.StructureMap.Lib.Interface;
using StructureMap.Configuration.DSL;

namespace CQC.TLey.StructureMapMvc.DependencyResolution
{
    public class LoggerRegistry : Registry
    {
        public LoggerRegistry()
        {
            For<IEgovLogger>().Use<EgovLogger>();
        }
    }
}