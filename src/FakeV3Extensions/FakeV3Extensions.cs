// Copyright (c) Charlie Poole, Rob Prouse and Contributors. MIT License - see LICENSE.txt

#if SUPPORT_V3_EXTENSIONS
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml;
using NUnit.Engine.Extensibility;

namespace NUnit.Engine.Fakes
{
    [Extension]
    public class FakeV3ProjectLoaderExtension : IProjectLoader
    {
        public bool CanLoadFrom(string path) => throw new NotImplementedException();

        public IProject LoadFrom(string path) => throw new NotImplementedException();
    }

    [Extension]
    public class FakeV3ResultWriterExtension : IResultWriter
    {
        public void CheckWritability(string outputPath) => throw new NotImplementedException();

        public void WriteResultFile(XmlNode resultNode, TextWriter writer) => throw new NotImplementedException();

        public void WriteResultFile(XmlNode resultNode, string outputPath) => throw new NotImplementedException();
    }

    [Extension]
    public class FakeV3EventListenerExtension : ITestEventListener
    {
        public void OnTestEvent(string report)
        {
            if (report.Length > 63)
                report = report.Substring(0, 60) + "...";
            Console.WriteLine($"EventListener: {report}");
        }
    }

    [Extension]
    public class FakeV3ServiceExtension : IService
    {
        public IServiceLocator ServiceContext
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public ServiceStatus Status => throw new NotImplementedException();

        public void StartService() => throw new NotImplementedException();

        public void StopService() => throw new NotImplementedException();
    }
}
#endif