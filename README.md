"Better C#" or, to put it more accurately, a more convenient C# – my library of small functions that makes c# programming easier. Written from when I write "Hello Wrold" first time, so some code may be shitty, uncommented, buggy or not optimal.
There are simple, but often used methods that everybody writes from scratch and include in their personal libraries like this. But why would you invent another wheel if Titanium library exist, the big collection of detailed and very functional "wheel" functions?

**WARNING!** It is NOT backward compatible, so don't update it after you started using it in your project. Some function may be deleted, reworked (parametr removal, renaming or even just order changing; behaviour changing) even if there's no serious need for it. There's no "that strange shitty костыльный spaghetti code is here because of historical reasons, for compatibility purposes" and never will be. If function become obsolete, it's usually gets immidiatly mercilessly removed. If I see that some change will make function more convinient, but change its behaviour I'll always do it – don't expect that after update all functions will work the same even if there's no syntax errors. Never update without reading changelog. That's just personal library I decided to publish after all.

Readme's and repository is currently WIP

Look at the library folder if you need more detailed description

And please, let me know if something simmilar to this library is already exist

## Titanium Core [Titanium]
Basic functions, mostly types/classes/convertions related


## Titanium Console [Titanium.Console]
[low development activity]
Adds convinient and beautiful way to display menus, progressbars and other things in the console. Get a very customizable, easy and beautiful way to get data from user

## Titanium Forms [Titanium.Forms]
[low development activity]
Additional functionality for basic winforms controls or classes

## Titanium WPF [Titanium.WPF]
Additional functionality for basic WPF controls or classes

## Internet
