Legend:
<details>
<summary><a name="example">whatTypeExtending.FunctionName(mandatory, [type]parameters, optional_parametrs_count) → return_type_if_not_obvious
<br>&ensp;↳ whatTypeExtending.ChildMethod(mandatory, optional_count) → returns</a></summary>
Description. Types (symbol replacing "[type]" in example): " - string, @ - char, [] - IEnumerable or its child type, # - int, $ - float or simmilar, ? - bool,  % - float or simmilar with value betwen 0 and 1, - - enum, > - Generic type, ^ - function

Parameters:

```cs
type name, type name = default_value_if_optional
```
Description

Child methods:

Child methods are either the same method but with different parameters or similar method with a bit altered behavior. Most of the time, they call the main method.

```cs
whatTypeExtending.FunctionName(type name, type name = default_value_if_optional)
```
</details>

<br>
<br>

# Highlights

[String.Slice(Start, End, SliceReturnSourceIfNotFound, DefaultValueIfNotFound, LastStart, LastEnd, IncludeStart, IncludeEnd, throwException) → string](#stringslice)
<br>
A very handy and flexible method for slicing strings. It can slice by index, string, regex, or char conditions. Return is very customizable too.

# TypesFuncs
Class for type conversions and other type related functions.

## Parsing (region)
Here are the functions for parsing types to other types.

## IsType
Checks if types are satisfy some conditions

<details>
<summary><a name="charisdigit">char.IsDigit()</a></summary>
Checks if the char is a digit
</details>

<details>
<summary><a name="charisdoublet">char.IsDoubleT()</a></summary>
Checks if the char is one of allowed symbols for double type
</details>

## ToType

<!-- --- INT --- -->
### Int


<details>
<summary><a name="chartointt">char.ToIntT()</a></summary>
Converts char to int
</details>
<details>
<summary><a name="stringtointt">string.ToIntT(3)</a></summary>
Parameters:

```cs
bool CanBeNegative = true, bool StopIfNumberEnded = false, int? ExceptionValue = null
```
Removes all non-digit symbols from the string and converts it to int. If the string doesn't contain any digit, returns ExceptionValue or throws an exception.
</details>

<details>
<summary><a name="stringtolongt">string.ToLongT(3)</a></summary>
Parameters:

```cs
bool CanBeNegative = true, bool StopIfNumberEnded = false, long? ExceptionValue = null
```
Removes all non-digit symbols from the string and converts it to long. If the string doesn't contain any digit, returns ExceptionValue or throws an exception.
</details>

<details>
<summary><a name="stringtonintt">string.ToNIntT(2)</a></summary>
Parameters:

```cs
bool CanBeNegative = true, bool StopIfNumberEnded = false
```
Returns int? if the string contains a number, otherwise returns null
</details>

<details>
<summary><a name="stringfindint">string.FindInt(1)</a></summary>
Parameters:

```cs
char thousandSeparator = ' '
```
Searches for INT in string. Throws IndexOutOfRangeException if no any int found in this string.
</details>

<details>
<summary><a name="stringfindintbetween">string.FindIntBetween(LeftStr", (RightStr"))</a></summary>
Parameters:

```cs
string LeftStr, string RightStr = null
```
Searches for INT between two strings
</details>


<!-- --- STRING --- -->
### String

<details>
<summary><a name="stringtoindex">string.ToIndex((Lower?))</a></summary>
Parameters:

```cs
bool Lower = true
```
Int to subscript numbers string
</details>


<details>
<summary><a name="stringtovisiblestring">string.ToVisibleString()</a></summary>
Removes all controls characters
</details>

<details>
<summary><a name="doubletostringt">double.ToStringT(Accuracy#)</a></summary>
Parameters:

```cs
int Accuracy = 3
```
Converts a double to a string, trimming the fractional part until zeros start
</details>

<details>
<summary><a name="ienumerabletostringt">IEnumerable.ToStringT(Separator")</a></summary>
Parameters:

```cs
string Separator = ""
```
Converts IEnumerable to string, separating elements by Separator
</details>

<details>
<summary><a name="idictionarytostringt">IDictionary.ToStringT(5)</a></summary>
Parameters:

```cs
bool Vertical = true, string ItemSeparator = default, string PairSeparator = "\n", string BeforePair = null, string AfterPair = null
```
Converts IDictionary to string
</details>

<details>
<summary><a name="bytestohex">byte[].ToHex()</a></summary>
Converts byte array to hex string
</details>



<!-- --- DOUBLE --- -->
### Double

<details>
<summary><a name="stringtodoublet">string.ToDoubleT(6)</a></summary>
Parameters:

```cs
bool CanBeNegative = true, bool StopIfNumberEnded = false, bool CanBeShortcuted = true, bool DotShouldBeAttachedToNumber = true, char Separator = '.', double? ExceptionValue = Double.NaN
```
Removes all non-digit symbols from the string and converts it to double. If the string doesn't contain any digit, returns ExceptionValue or throws an exception.
</details>

<details>
<summary><a name="stringtondoublet">string.ToNDoubleT(5)</a></summary>
Parameters:

```cs
char Separator = '.', bool CanBeNegative = true, bool CanBeShortcuted = true, bool DotShouldBeAttachedToNumber = true, bool StopIfNumberEnded = false
```
Returns double? if the string contains a number, otherwise returns null
</details>

<!-- --- FLOAT --- -->
### Float

<details>
<summary><a name="stringfindfloat">string.FindFloat(2)</a></summary>
Parameters:

```cs
char DecimalSeparator = '.', char thousandSeparator = ' '
```
Converts string to float
</details>

<!-- --- SHORT --- -->
### Short

<details>
<summary><a name="stringreadshortuntilletter">string.ReadShortUntilLetter()</a></summary>

Reads String and parses to Short until meets a letter
</details>

<!-- --- BOOL --- -->
### Bool

<details>
<summary><a name="stringtobool">string.ToBool()</a></summary>
Converts string to bool. Supports multiple languages. Optimized version
</details>

<details>
<summary><a name="stringyesbool">string.YesToBool()</a></summary>
Converts string to bool. Supports multiple languages. Less optimized, but more reliable version
</details>

<details>
<summary><a name="booltorustring">bool.ToRuString()</a></summary>
Converts bool to 
</details>

<details>

<summary><a name="randbool">RandBool(TrueProbability#)</a></summary>
Parameters:

```cs
Int32 TrueProbability = = Int32.MaxValue/2
```
Returns random bool with given probability (the range is 0 to Int32.MaxValue)
</details>

<!-- --- ARRAY --- -->
### Array

<details>
<summary><a name="stringtodoublet">string.ToDoubleT((Separator@))</a></summary>
Parameters:

```cs
char Separator = '.'
```
Converts string[,] to double[,]
</details>

<details>
<summary><a name="doubletostringt">double.ToStringT((Format"))</a></summary>
Parameters:

```cs
string Format
```
Converts double[,] to string[,]
</details>

<details>
<summary><a name="doubletostringmatrix">double.ToStringMatrix()</a></summary>
Converts double[,] to string[,]
</details>

<details>
<summary><a name="tosinglearray">ToSingleArray()</a></summary>
Parameters:

```cs
T[][,] list
```
Converts T[][,] to T[,,]
</details>


## OtherTypeFuncs

<!-- --- INT --- -->
### Int

<details>
<summary><a name="intisodd">IsOdd()</a></summary>
returns true if the number is odd
</details>

<details>
<summary><a name="intiseven">IsEven()</a></summary>
returns true if the number is even
</details>

<details>
<summary><a name="intdivrem">DivRem(divident#, divisor#, out reminder#)</a></summary>
Returns the result of the division and the reminder into the out parameter

```cs
int Divident, int Divisor, out int Reminder
```
</details>

<details>

<summary><a name="intfit">Fit((min#, max#))</a></summary>
Parameters:

```cs
int Min = = int.MinValue, int Max = = int.MaxValue
```
Fits the number into the range
</details>

<details>
<summary><a name="intfitpositive">FitPositive((max#))</a></summary>
Parameters:

```cs
int Max = int.MaxValue
```
Fits the number into the range [0, Max]
</details>

<details>
<summary><a name="intfitnegative">FitNegative((min#))</a></summary>
Parameters:

```cs
int Min = int.MinValue
```
Fits the number into the range [Min, 0]
</details>

<!-- --- STRING --- -->
### String

 <!-- SplitN -->
#### SplitN

<details>
<summary><a name="splitn">string.SplitN(Separator")
<br>&ensp;↳ string.SplitN(Separator", StringSplitOptions-)
<br>&ensp;↳ string.SplitN(Separator", count#)
<br>&ensp;↳ string.SplitN(Separator", count#, StringSplitOptions-)
<br>&ensp;↳ string.SplitN(Separator[])
<br>&ensp;↳ string.SplitN(Separator[], StringSplitOptions-)
<br>&ensp;↳ string.SplitN(Separator[], count#)
<br>&ensp;↳ string.SplitN(Separator[], count#, StringSplitOptions-)
<br>&ensp;↳ string.SplitN(Separator@)
<br>&ensp;↳ string.SplitN(Separator@, count#)
<br>&ensp;↳ string.SplitN(Separator@, StringSplitOptions-)</a></summary>
String.Split() but returns null if no any split found

Parameters:

```cs
string Separator, StringSplitOptions StringSplitOptions = StringSplitOptions.None, int count = int.MaxValue
```
String.Split() but returns null if no any split found

Child methods:

```cs
string.SplitN(string Separator, StringSplitOptions StringSplitOptions)
string.SplitN(string Separator, int count)
string.SplitN(string Separator, int count, StringSplitOptions StringSplitOptions)
string.SplitN(string[] Separator)
string.SplitN(string[] Separator, StringSplitOptions StringSplitOptions)
string.SplitN(string[] Separator, int count)
string.SplitN(string[] Separator, int count, StringSplitOptions StringSplitOptions)
string.SplitN(char Separator)
string.SplitN(char Separator, int count)
string.SplitN(char Separator, StringSplitOptions StringSplitOptions)
```
</details>

<details>
<summary><a name="stringcontainsany">string.ContainsAny(sequence[])
<br>&ensp;↳ string.ContainsAny(params sequence[])</a></summary>
Parameters:

```cs
IEnumerable<string> sequence
```
Returns true if the string contains any of the sequence elements

Child methods:

```cs
string.ContainsAny(params string[] sequence)
```
</details>

<details>
<summary><a name="stringcontainsall">string.ContainsAll(sequence[])
<br>&ensp;↳ string.ContainsAll(params sequence)</a></summary>
Parameters:

```cs
IEnumerable<string> sequence
```
Returns true if the string contains all of the sequence elements

Child methods:

```cs
string.ContainsAll(params string[] sequence)
```
</details>

<details>
<summary><a name="stringcountsymbols">string.SymbolsCount()</a></summary>
Returns the count of symbols in the string, excluding control characters
</details>

<details>
<summary><a name="doubleformattostring">double.FormatToString(FixedLength#, Align-, 1)</a></summary>
Makes s.Length be equal to FixedLength by adding filler symbols if it's too short or cutting it if it's too long

Parameters:

```cs
int FixedLength, char FillerSymbol = ' ', Positon Align, char Filler = ' '
```
</details>

<details>
<summary><a name="stringformattostring">string.FormatToString(FixedLength#, Align-, 2)</a></summary>
Makes s.Length be equal to FixedLength by adding filler symbols if it's too short or cutting it if it's too long

Parameters:

```cs
int FixedLength, char FillerSymbol = ' ', Positon Align, char Filler = ' ', int Offset = 0
```
</details>

<details>
<summary><a name="stringinsert">string.Insert(Value", Start#, (End#))</a></summary>
Inserts value between Start and End

Parameters:

```cs
string Value, int Start, int? End
```
</details>

<details>
<summary><a name="stringslice">🌟 string.Slice(Start>, End>, 7)
<br>&ensp;↳ string.Slice(Start, 7)
<br>&ensp;↳ string.SliceFromEnd(Start, 7)
</a></summary>A very powerful and flexible method for slicing strings. It can slice by index, string, regex or function.

Parameters:

```cs
Generic<int, string, Regex, Func<char,bool>> Start, //: Start of the result string:
// int: Start index of the result string (inverse direction if negative)
// string: The string inside <paramref name="s"/> that will be the start position of the result
// Regex: The string inside <paramref name="s"/> matches Regex that will be the start position of the result
// Func<char,bool>: Conditions that the start characters of the string must satisfy (by function per character)
Generic<int, string, Regex, Func<char,bool>> End, //: End of the result string:
// int: End index of the result string (inverse direction if negative). Shrinks to s.Length if it's more than it. Swaps with Start if they're mixed up (only if both are int)
// string: The string inside s that will be the end position of the result
// Regex: The string inside s matches Regex that will be the end position of the result
// Func<char,bool>: Conditions that the end characters of the string must satisfy (by function per character)
SliceReturn SliceReturnSourceIfNotFound = SliceReturn.Never, //: if Always, return s if Start or End not found
SliceReturn DefaultValueIfNotFound = SliceReturn.Never, //: if Always, return s if Start or End not found
bool LastStart = false, //: if true, the last occurance of the Start will be searched (doesn't do anything if Start is int)
bool LastEnd = true, //: if true, the last occurance of the End will be searched (doesn't do anything if End is int)
bool IncludeStart = false, //: Include Start symbols (doesn't do anything if Start is int)
bool IncludeEnd = false, //: Include End symbols (doesn't do anything if End is int)
bool throwException = false //: If false, returns null on expected errors: if source is null or empty; If start or end not found
```

Examples:

```cs
"Hello World!".Slice(0, 5) //: "Hello"
"Hello World!".Slice(-6) //: "World!"
"Hello World!".Slice("Hel", "!") //: "lo World"
"Hello World!".Slice("ll", "rld", IncludeStart: true, IncludeEnd: true) //: "llo World"
"Hello World!".Slice("nothing found") //: null
"Hello World!".Slice("nothing found", SliceReturnSourceIfNotFound: SliceReturn.Always) //: "Hello World!"
```
</details>

<details>
<summary><a name="stringindexoft">string.IndexOfT(s2", 4)
<br>&ensp;↳ string.IndexOfT(Conditions, 4) </a></summary>
Return an index of (IndexOfEnd? end : start) of s2 in s

Parameters:

```cs
string s2, int Start = 0, int End = Int32.MaxValue, bool InvertDirection = false, bool IndexOfEnd = false
```

Child methods:

```cs
string.IndexOfT(Func<char,bool>[] Conditions, int Start = 0, int End = Int32.MaxValue, bool InvertDirection = false, bool IndexOfEnd = false)
```
</details>

<details>
<summary><a name="stringmultiply">string.Multiply(count#)
<br>&ensp;↳ char.Multiply(count#) </a></summary>
Has you ever been trolled by pythonists with their "string"*3="stringstringstring"? Now you can do it in C#! 🤣
<br>
Adds the string/char to itself `count` times.
</details>

<details>
<summary><a name="stringreplace">string.Replace(Start", End", 2)
<br>&ensp;↳ string.Replace(ReplaceRule dictionary)
<br>&ensp;↳ string.Replace(OldStrings[], NewStrings[])
<br>&ensp;↳ string.ReplaceFromLast(OldString", NewString") </a></summary>

Parameters:

```cs
int Start, int? End = null, string NewString = null, bool Exception = true
```

Child methods:

```cs
string.Replace(Dictionary<string, string> ReplaceRule) //: Replaces all dictionary keys occurancies with their values
string.Replace(OldStrings[], NewStrings[]) //: Replaces all OldStrings occurancies with their NewStrings
string.ReplaceFromLast(string OldString, string NewString) //: Replaces the last occurance of OldString with NewString
```
</details>

<details>
<summary><a name="stringescape">string.Escape(Characters", EscapeSymbol")</a></summary>
Escapes string -- adds `EscapeSymbol` before each character from `Characters`

Parameters:

```cs
string Characters, string EscapeSymbol = "\\"
```

</details>


<details>
<summary><a name="stringarradd">string.Add(addiction", (ToEnd?))
<br>&ensp;↳ string.AddToStart(addiction")
<br>&ensp;↳ string.AddToEnd(addiction")</a></summary>

</a></summary>
Adds the `addiction` to the string. If `ToEnd` is true, adds it to the end, else -- to the start

Parameters:

```cs
string addiction, bool ToEnd = true
```

Child methods:

```cs
string.AddToStart(string addiction)
string.AddToEnd(string addiction)
```

</details>


<details>
<summary><a name="enumerableremove">string.Remove(RemovableString", (FromLeft?, ComparisonType-))
<br>&ensp;↳ string.RemoveFrom(FromWhere-, params RemovableStrings")
<br>&ensp;↳ string.RemoveFrom(FromWhere-, RemovableString")
<br>&ensp;↳ string.RemoveAll(RemovableString", (ComparisonType-))
<br>&ensp;↳ string.RemoveAll(RemovableStrings[]", (ComparisonType-))
<br>&ensp;↳ string.RemoveAllFrom(RemovableChars", (FromWhere-, ComparisonType-))</a></summary>
</a></summary>
Removes the RemovableString from the string

Parameters:

```cs
string RemovableString, bool FromLeft = true, StringComparison ComparisonType = StringComparison.Ordinal
```

Child methods:

```cs
string.RemoveFrom(Side FromWhere, params string RemovableStrings)
string.RemoveFrom(Side FromWhere, string RemovableString)
string.RemoveAll(string RemovableString, StringComparison ComparisonType)
string.RemoveAll(string[] RemovableStrings, StringComparison ComparisonType)
string.RemoveAllFrom(string RemovableChars, Side FromWhere, StringComparison ComparisonType)
```
</details>

<!-- --- ENUMERABLE --- -->
### Enumerable

<details>
<summary><a name="enumerablecontainsany">IEnumerable.ContainsAny(sequence[])
<br>&ensp;↳ IEnumerable.ContainsAny(params sequence[])</a></summary>
Returns true if the string contains any of the sequence elements

Parameters:

```cs
IEnumerable<string> sequence
```

Child methods:

```cs
IEnumerable.ContainsAny(params string[] sequence)
```
</details>

<details>
<summary><a name="enumerablecontainsall">IEnumerable.ContainsAll(sequence[])
<br>&ensp;↳ IEnumerable.ContainsAll(params sequence)</a></summary>
Returns true if the string contains all of the sequence elements

Parameters:

```cs
IEnumerable<string> sequence
```

Child methods:

```cs
IEnumerable.ContainsAll(params string[] sequence)
```
</details>

<details>
<summary><a name="enumerableempty">IEnumerable.Empty()</a></summary>
Returns true if the IEnumerable is empty
</details>

<details>
<summary><a name="enumerabletoarray">IEnumerable.ToArray(Convert)
<br>&ensp;↳ IEnumerable.ToArray()</a></summary>
Converts IEnumerable to array

Parameters:

```cs
Func<Src, Tgt> Convert
```

Child methods:

```cs
IEnumerable.ToArray()
```
</details>

<details>
<summary><a name="enumerablerandomshuffle">IEnumerable.RandomShuffle()
<br>&ensp;↳ IEnumerable.RandomShuffle(Random)</a></summary>
Returns a shuffled list

Parameters:

```cs
Random random
```
</details>

<details>
<summary><a name="enumerablerandomlist">List<int>.RandomList(start#, count#)</a></summary>
Returns a list of random numbers

Parameters:

```cs
int start, int count
```
</details>

<details>
<summary><a name="enumerablepop">List.Pop()</a></summary>
Removes the last element from the list and returns it
</details>

<details>
<summary><a name="enumerableswap">List.Swap(aIndex#, bIndex#)
<br>&ensp;↳ T[].Swap(aIndex#, bIndex#)</a></summary>
</a></summary>
Swaps two elements in the list

Parameters:

```cs
int aIndex, int bIndex
```

Child methods:

```cs
T[].Swap(aIndex, bIndex)
```
</details>

<details>
<summary><a name="enumerableindexof">List.IndexOf(value>)</a></summary>
Returns the index of the value in the list

Parameters:

```cs
T value
```
</details>

<details>
<summary><a name="enumerablesplit">[][].Split(arraysCount#)</a></summary>
Splits the list into arraysCount arrays

Parameters:

```cs
int arraysCount
```
</details>

<details>
<summary><a name="enumerablegetmaxindex">double[].GetMaxIndex()</a></summary>
Returns the index of the max value in the list
</details>

<details>
<summary><a name="enumerableconcat">Concat(Array1[], Array2[])</a></summary>
Concatenates two arrays

Parameters:

```cs
T[] Array1, T[] Array2
```
</details>

<details>
<summary><a name="enumerablereducedimension">[][].ReduceDimension()</a></summary>
Converts matrix to array
</details>

<details>
<summary><a name="enumerabletostringline">IEnumerable.ToStringLine(Separator", LastSeparator")
<br>&ensp;↳ IEnumerable.ToStringLine(Separator")</a></summary>
</a></summary>
Converts IEnumerable to string, separating elements by Separator and LastSeparator

Parameters:

```cs
string Separator, string LastSeparator
```

Child methods:

```cs
IEnumerable.ToStringLine(string Separator)
```
</details>

<details>
<summary><a name="enumerablefillandget">[].FillAndGet(value)</a></summary>
Fills the array with the value and returns it

Parameters:

```cs
T[] source, T value
```
</details>

<details>
<summary><a name="enumerableaddrangeandget">[].AddRangeAndGet(summand[])</a></summary>
Adds summand to the array and returns it

Parameters:

```cs
T[] array, T[] summand
```
</details>

</br>

<!-- --- SIZE --- -->
### Size

<details>
<summary><a name="sizemax">Size.Max()</a></summary>
Returns the highest dimension
</details>

<details>
<summary><a name="sizemin">Size.Min()</a></summary>
Returns the lowest dimension
</details>

<details>
<summary><a name="sizeresize">Size.Resize(NewDimensionValue#, FixedDimension-)</a></summary>
Returns the new Size with the same aspect ratio

Parameters:

```cs
int NewDimensionValue, Dimension FixedDimension
```
</details>


</br>

<!-- --- Regex --- -->

### Regex

<details>
<summary><a name="regexismatcht">Regex.IsMatchT(source", (start#))
<br>&ensp;↳ Regex.IsMatchAny(s, (start#))
<br>&ensp;↳ Regex.IsMatchAll(s, (start#))
</a></summary>
Is any of Regex matches the string

Parameters:

```cs
string s, int start = 0
```

Child methods:

```cs
IEnumerable<Regex>.IsMatchAny(s, int start = 0)
IEnumerable<Regex>.IsMatchAll(s, int start = 0)
```
</details>

<details>
<summary><a name="regexreverse">Regex.Reverse()
<br>&ensp;↳ List<Regex>.ReverseRegexes()</a></summary>
Swithes between "includes" and "excludes" modes

Child methods:

```cs
List<Regex>.ReverseRegexes()
```
</details>

<details>
<summary><a name="regexinvert">InvertRegex(string)</a></summary>
Swaps "equal" mode to "contains" mode (Adds $/^ in the start/end if they're not; Removes them if they are)

Parameters:

```cs
string S
```
</details>

<br>

<!-- --- COLOR --- -->

### Color

<details>
<summary><a name="colorchange">Color.Change((A#, R#, G#, B#))</a></summary>
Changes the color

Parameters:

```cs
byte? A = null, byte? R = null, byte? G = null, byte? B = null
```
</details>

<br>

<!-- --- GENERIC --- --->
### Generic

<details>
<summary><a name="swap">.Swap(ref a, ref b)</a></summary>
Swaps two variables

Parameters:

```cs
T a, T b
```
</details>

<details>
<summary><a name="isdefault">.IsDefault()</a></summary>
Checks if the value is default

Parameters:

```cs
T value
```
</details>

<details>
<summary><a name="todefaultifnot">.ToDefault_IfNot(predicate^)</a></summary>
Returns default if the value doesn't satisfy the predicate

Parameters:

```cs
Func<T, bool> predicate
```
</details>

<!-- --- PROCESS --- --->

### Process

<details>
<summary><a name="killall">KillProcesses((Path", Name"))</a></summary>
Kills all processes with the same name or path

Parameters:

```cs
string Path, string Name
```
</details>




</br>
</br>


# IO

Class for input-output actions, like file writting. Functions:

<details>
<summary><a name="copyall">CopyAll (SourcePath", TargetPath", (3))
<br> &ensp; ↳ DirectoryInfo.CopyAllTo(SourcePath", TargetPath", (3))</a></summary>
Copies all files, directories, subdirectories and it's content to the new folder

Parameters: 

```cs
string SourcePath, string TargetPath, bool KillRelatedProcesses = false, List<Regex>? ExceptList = null, bool DisableSyntaxCheck = false
```
Child methods:

```cs
DirectoryInfo.CopyAllTo(string TargetPath, bool KillRelatedProcesses = false, List<Regex> ExceptList = null, bool DisableSyntaxCheck = false)
```
</details>

<details>
<summary><a name="removeall">RemoveAll(Folder path", 2)</a></summary>
Removes all files and directories in the folder
Parameters:

```cs
string FolderPath, bool RemoveSelf = true, List<Regex>? ExceptList = null
```
</details>

<details>
<summary><a name="renameall">RenameAll(Folder path", 2)</a></summary>

Renames all files in the Directory (not recursive) <br>
Parameters: 

```cs
string FolderPath, Func<string, string> Rename, List<Regex>? ExceptList = null
```

</details>

<details>
<summary><a name="moveall">MoveAllTo(SourcePath", TargetPath", (4))
<br>&ensp;↳ DirectoryInfo.MoveAllTo(Target path", 4)</a></summary>
Moves all files, directories, subdirectories and it's content to the new folder
Parameters: 

```cs
string TargetPath, bool DeleteSourceDir = true, bool KillRelatedProcesses = false, List<Regex> ExceptList = null, bool DisableSyntaxCheck = false
```
Child methods:

```cs
MoveAllTo(string SourcePath, string TargetPath, bool DeleteSourceDir = true,  bool KillRelatedProcesses = false, List<Regex> ExceptList = null, bool DisableSyntaxCheck = false)
```
</details>

<br>
<br>

# ClasicFuncs

Makes extention methods or addictions to the basic classes. Functions:
```cs
bool string.IsNullOrEmpty()
bool string.IsNullOrWhiteSpace()
string string.IsInterned()
```

[test](#example)
