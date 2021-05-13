
# Damien Notes
- [Got from this talk] (https://www.youtube.com/watch?v=bBpFpr-Votk&t=632s&ab_channel=JetBrainsTV)
- https://github.com/damiensawyer/NotifyPropertyChangedDemo
- The output file was created C:\Users\Damien\AppData\Local\Temp\RiderSourceGeneratedDocuments\1290A9BDF7DA2DF7E38442C0\NotifyPropertyChangedGenerator\NotifyPropertyChangedGenerator.NotifyPropertyChangedGenerator\CarModel.Notify6.cs
- Using Rider, I made changes to NotifyPropertyChangedGenerator.cs and saved it (changed the output file name). I then changed a property name on CarModel.cs. If I went to the class name of CarModel and hit f12, Rider opened up the new (generated) file. What was interesting was that the file didn't appear in the Windows explorer until I'd opened it in Rider. I guess it's cached. 

All in all. This is cool!! 

# NotifyPropertyChangedDemo
Demo generator implementing INotifyPropertyChanged based on naming conventions

A very simple generator demonstrating the basic functioning of a source generator.
The example features a generator implementing INotifyProperytyChanged interface based on naming convention adding properties with PropertyChanged event invocation for any field with *BackingField suffix in all types implementing INotifyPropertyChanged interface
- How to add a source generator
- How to traverse syntax trees, check implemented interfaces and find type members
- How to add a generated source to the target project
- How to test a source generator
- How to debug a source generator

Note that being a demo this generator completely ignores some potential problems in generated source e.g. non-class types implementing INotifyPropertyChanged, nested types or types in global namespaces focusing instead on being as simple an example as possible
