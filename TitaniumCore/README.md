Code for Copilot:
```cs

```

Legend:
<details>
<summary><a name="example">whatTypeExtending.FunctionName(mandatory, parameters, optional_parametrs_count) → return_type_if_not_obvious
<br>&ensp;↳ whatTypeExtending.ChildMethod(mandatory, optional_count) → returns</a></summary>
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

# TypesFuncs
Class for type conversions and other type related functions.

## Parsing (region)
Here are the functions for parsing types to other types.

## IsType
Checks if types are satisfy some conditions

<details>
<summary><a name="isdigit">char.IsDigit()</a></summary>
Checks if the char is a digit
</details>

<details>
<summary>char.IsDoubleT()</summary>
Checks if the char is one of allowed symbols for double type
</details>

## ToType

### Int


<details>
<summary>char.ToIntT()</summary>
Converts char to int
</details>
<details>
<summary>string.ToIntT(3)</summary>
Parameters:

```cs
bool CanBeNegative = true, bool StopIfNumberEnded = false, int? ExceptionValue = null
```
Removes all non-digit symbols from the string and converts it to int. If the string doesn't contain any digit, returns ExceptionValue or throws an exception.
</details>

<details>
<summary>string.ToLongT(3)</summary>
Parameters:

```cs
bool CanBeNegative = true, bool StopIfNumberEnded = false, long? ExceptionValue = null
```
Removes all non-digit symbols from the string and converts it to long. If the string doesn't contain any digit, returns ExceptionValue or throws an exception.
</details>

<br>
<br>

# IO

Class for input-output actions, like file writting. Functions:

<details>
<summary>CopyAll (string, string, (bool, List, bool))
<br> &ensp; ↳ DirectoryInfo.CopyAllTo(SourcePath, TargetPath)</summary>
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
<summary>RemoveAll</summary>
Removes all files and directories in the folder
Parameters:

```cs
string FolderPath, bool RemoveSelf = true, List<Regex>? ExceptList = null
```
</details>

<details>
<summary>RemoveAll(Folder path, 2)</summary>
#### RenameAll
Renames all files in the Directory (not recursive)
Parameters: 

```cs
string FolderPath, Func<string, string> Rename, List<Regex>? ExceptList = null
```
</details>

<details>
<summary>DirectoryInfo.MoveAllTo(Target path, 4);
<br>&ensp;↳ MoveAllTo(SourcePath, TargetPath)</summary>
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
