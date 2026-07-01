#### [DiGi\.Scripting\.CSharp](index.md 'index')

## DiGi\.Scripting\.CSharp\.Classes Namespace
### Classes

<a name='DiGi.Scripting.CSharp.Classes.Script'></a>

## Script Class

Represents a C\# script implementation that can be compiled and executed using the Roslyn scripting API\.

```csharp
public class Script : DiGi.Scripting.Classes.Script
```

Inheritance [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject') → [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') → [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject') → [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject') → [DiGi\.Scripting\.Classes\.Script](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.script 'DiGi\.Scripting\.Classes\.Script') → Script
### Constructors

<a name='DiGi.Scripting.CSharp.Classes.Script.Script(DiGi.Scripting.Classes.Code,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_)'></a>

## Script\(Code, IEnumerable\<VariableType\>, IEnumerable\<VariableType\>\) Constructor

Initializes a new instance of the [Script](DiGi.Scripting.CSharp.Classes.md#DiGi.Scripting.CSharp.Classes.Script 'DiGi\.Scripting\.CSharp\.Classes\.Script') class\.

```csharp
public Script(DiGi.Scripting.Classes.Code? code, System.Collections.Generic.IEnumerable<DiGi.Scripting.Classes.VariableType>? inputVariableTypes, System.Collections.Generic.IEnumerable<DiGi.Scripting.Classes.VariableType>? outputVariableTypes);
```
#### Parameters

<a name='DiGi.Scripting.CSharp.Classes.Script.Script(DiGi.Scripting.Classes.Code,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_).code'></a>

`code` [DiGi\.Scripting\.Classes\.Code](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.code 'DiGi\.Scripting\.Classes\.Code')

The source code to be executed\.

<a name='DiGi.Scripting.CSharp.Classes.Script.Script(DiGi.Scripting.Classes.Code,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_).inputVariableTypes'></a>

`inputVariableTypes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Scripting\.Classes\.VariableType](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.variabletype 'DiGi\.Scripting\.Classes\.VariableType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of variable types used as inputs\.

<a name='DiGi.Scripting.CSharp.Classes.Script.Script(DiGi.Scripting.Classes.Code,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_).outputVariableTypes'></a>

`outputVariableTypes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Scripting\.Classes\.VariableType](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.variabletype 'DiGi\.Scripting\.Classes\.VariableType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of variable types expected as outputs\.

<a name='DiGi.Scripting.CSharp.Classes.Script.Script(DiGi.Scripting.CSharp.Classes.Script)'></a>

## Script\(Script\) Constructor

Initializes a new instance of the [Script](DiGi.Scripting.CSharp.Classes.md#DiGi.Scripting.CSharp.Classes.Script 'DiGi\.Scripting\.CSharp\.Classes\.Script') class by copying an existing script\.

```csharp
public Script(DiGi.Scripting.CSharp.Classes.Script? script);
```
#### Parameters

<a name='DiGi.Scripting.CSharp.Classes.Script.Script(DiGi.Scripting.CSharp.Classes.Script).script'></a>

`script` [Script](DiGi.Scripting.CSharp.Classes.md#DiGi.Scripting.CSharp.Classes.Script 'DiGi\.Scripting\.CSharp\.Classes\.Script')

The source script to copy\.

<a name='DiGi.Scripting.CSharp.Classes.Script.Script(System.Text.Json.Nodes.JsonObject)'></a>

## Script\(JsonObject\) Constructor

Initializes a new instance of the [Script](DiGi.Scripting.CSharp.Classes.md#DiGi.Scripting.CSharp.Classes.Script 'DiGi\.Scripting\.CSharp\.Classes\.Script') class from a JSON object\.

```csharp
public Script(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Scripting.CSharp.Classes.Script.Script(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON representation of the script\.
### Properties

<a name='DiGi.Scripting.CSharp.Classes.Script.Imports'></a>

## Script\.Imports Property

Gets or sets the set of namespaces to be imported during script execution\.

```csharp
public System.Collections.Generic.HashSet<string>? Imports { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')

<a name='DiGi.Scripting.CSharp.Classes.Script.References'></a>

## Script\.References Property

Gets or sets the set of assembly references required for script compilation and execution\.

```csharp
public System.Collections.Generic.HashSet<string>? References { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')
### Methods

<a name='DiGi.Scripting.CSharp.Classes.Script.Execute(DiGi.Scripting.Classes.Data)'></a>

## Script\.Execute\(Data\) Method

Executes the C\# script using the provided input data\.

```csharp
public override DiGi.Scripting.Classes.Response? Execute(DiGi.Scripting.Classes.Data? inputData=null);
```
#### Parameters

<a name='DiGi.Scripting.CSharp.Classes.Script.Execute(DiGi.Scripting.Classes.Data).inputData'></a>

`inputData` [DiGi\.Scripting\.Classes\.Data](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.data 'DiGi\.Scripting\.Classes\.Data')

The data to be passed into the script as globals\.

#### Returns
[DiGi\.Scripting\.Classes\.Response](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.response 'DiGi\.Scripting\.Classes\.Response')  
A [DiGi\.Scripting\.Classes\.Response](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.response 'DiGi\.Scripting\.Classes\.Response') containing the execution results or any encountered exceptions\.