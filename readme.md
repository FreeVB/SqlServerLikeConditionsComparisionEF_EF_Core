## Comparing SqlClient, EF6, EF Core Like condition

#### Quirk in EF Core unit testing
Seems that System.ComponentModel.Annotations when added automatically the incorrect version is installed. Delete it, add from NuGet if the following exception appears during testing.
>Could not load file or assembly 'System.ComponentModel.Annotations, Version=4.1.0.0
