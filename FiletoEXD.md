#### Introduction ####

This AppScan® eXtension improves explore coverage by turning a Directory listing file into an EXD (Explore Data) file.

#### Details ####

  * Written By: Denis Rand (http://www.cirt.dk)

  * Version: 1.0

  * Description: FiletoEXD works by taking a directory listing from a file created on either Linux or Windows and importing it directly into AppScan. This means that you can save alot of time and probably get better coverage, in scenarios where the application includes files that are not linked from the site.

  * Supported AppScan Version: AppScan v7.5 and above.

  * Version Notes: none

  * Developer Comments: none

  * Installation: download the eXtension zip package, launch AppScan, go to Tools->Extensions->Extension Manager and choose install, then point to the zip package.

  * Execution: Getting the directory list: On Windows you should use "DIR /B /S > test.txt", on Linux:

```
#!/usr/bin/perl
# Run this way : ./file.pl "/pathtoWeb"
use File::Find
my @files;
find(sub { push @files, $File::Find::name}, $ARGV[0]);
print "$_\n" for (@files)
```


#### Screenshot ####

**FiletoEXD in action:**

![http://filetoexd.googlecode.com/files/FiletoEXD.jpg](http://filetoexd.googlecode.com/files/FiletoEXD.jpg)

