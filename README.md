# NUnit 4 Extensibility

NUnit Extensibility is a mechanism developed by the NUnit team for use in extending the NUnit engine, runners, test adapters and other components. It may also be used independently from NUnit as a general extensibility approach.

The `NUnit.Extensibility` package provides the implementation of the extensibility mechanism. It is used by hosting assemblies to identify and load the extensions they support.

The `NUnit.Extensibility.Api` package provides the interfaces and attributes used to define extension points and extensions. It allows hosting assemblies and extension assemblies to interoperate successfully.
