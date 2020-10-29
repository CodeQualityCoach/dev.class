using CQC.TLey.StructureMap.Lib.Impl;
using CQC.TLey.StructureMap.Lib.Interface;
using StructureMap;

namespace CQC.TLey.StructureMapMvc.DependencyResolution
{
    public class LoggerRegistry : Registry
    {
        public LoggerRegistry()
        {
            For<IEgovLogger>().Use<EgovLogger>();
        }
    }

    public class OnlineRegistry
    {

    }
    public class OnPremise {}
}