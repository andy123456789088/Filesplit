# FileSplit
#### Info:
You can split a file into more little files, e.g. for transfer large files over CD.
Now you can use big files too. Currently the size of the particularly files can be maximal 512 MB.
For instance, you can split a 8 GB-file into 16 files. But, if the size is greather than 8192 MB,
you get 17 files.

#### Screenshot:

![shot](http://seite.bplaced.net/Git/Images/Shot.png)

#### Usage in your code

##### Devide a file:
```cs
Work currentIns = new Work();
currentIns.DoWork(Work.Action.Split, null, path_to_the_file, path_to_the_dir, file_size);

// path_to_the_file:  The file which should be devided
// path_to_the_dir:   The directory which contains later all files (e.g. Test.0, Test.1 usw.)
// file_size in byte: 512 MB * 1024 ^ 2 = 536870912
```

##### Put the file together
```cs
Work currentIns = new Work();
currentIns.DoWork(Work.Action.PutTogheter, string_array_with_fullnames_of_file, path_to_the_file);

// path_to_the_file:                      The file which finally is your original file
// string_array_with_fullnames_of_file:   The string-array which contains all files in the right ordner!
```


