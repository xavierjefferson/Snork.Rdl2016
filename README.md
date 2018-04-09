
# Snork.Rdl2016

[![Latest version](https://img.shields.io/nuget/v/Snork.Rdl2016.svg)](https://www.nuget.org/packages/Snork.Rdl2016/) 

This is a type library for reading Sql Server Report Definition Language files, version 2016.  It is based on Microsoft's RDL XML Schema for Version 2016/01, found [here](https://msdn.microsoft.com/en-us/library/mt704772%28v=sql.105%29.aspx).  I've also included that same file [here](rdl2016.xsd).

# Usage

You're going to use this library with standard .NET XML serialization.  The root type to read with the serializer is Report.  Once you've read the top-level Report object, you'll have access to all the objects in the file.

I only used this to get at the report's parameters before trying to actually generate the report, but this model actually has 248 separate classes, and I'm not guaranteeing that all will work for you.


```
        Snork.Rdl2016.Report ReadAFile(string rdlFilename)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Report));
            Snork.Rdl2016.Report report;
            using (var stream = System.IO.File.OpenRead(rdlFilename))
            {
                report = (Snork.Rdl2016.Report)serializer.Deserialize(stream);
            }
            return report;
        }

```

