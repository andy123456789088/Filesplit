# FileSplit
#### Info
You can split a file into more little files, e.g. for transfer large files over CD.
Now you can use big files too. Currently the size of the particularly files can be maximal 512 MB.
For instance, you can split a 8 GB-file into 16 files. But, if the size is greather than 8192 MB,
you get 17 files.

#### Screenshot

![shot](http://seite.bplaced.net/Git/Images/Shot.png)

#### Usage in your code
This class doesn't existing in a dll. You have to copy this class to your project if you want
to use it in your own application. 
You can add event-handlers to know about the progress and when it's finished.
```cs
Work currentIns = new Work();
currentIns.ProgressChanged += CurrentWork_ProgressChanged;
currentIns.CurrentProgressChanged += CurrentWork_CurrentProgressChanged;
currentIns.IsReady += CurrentIns_IsReady;
```

ProgressChanged: The main progress how much files are processed.  
CurrentProgress: The current progress how much bytes of the current file are processed.  
IsReady:         Raises when all files are processed.  

##### Devide a file
```cs
currentIns.DoWork(Work.Action.Split, null, path_to_the_file, path_to_the_dir, file_size);

// path_to_the_file:  The file which should be devided
// path_to_the_dir:   The directory which contains later all files (e.g. Test.0, Test.1 usw.)
// file_size in byte: 512 MB * 1024 ^ 2 = 536870912
```

##### Put the file together
```cs
currentIns.DoWork(Work.Action.PutTogheter, string_array_with_fullnames_of_file, path_to_the_file);

// path_to_the_file:                      The file which finally is your original file
// string_array_with_fullnames_of_file:   The string-array which contains all files in the right ordner!
```


