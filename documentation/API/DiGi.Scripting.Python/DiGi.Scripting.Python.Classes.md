## DiGi\.Scripting\.Python\.Classes Namespace
### Classes

<a name='DiGi.Scripting.Python.Classes.Script'></a>

## Script Class

Provides an implementation of [DiGi\.Scripting\.Classes\.Script](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.script 'DiGi\.Scripting\.Classes\.Script') for executing Python scripts using the IronPython engine\.

```csharp
public class Script : DiGi.Scripting.Classes.Script
```

Inheritance [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject') → [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') → [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject') → [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject') → [DiGi\.Scripting\.Classes\.Script](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.script 'DiGi\.Scripting\.Classes\.Script') → Script
### Constructors

<a name='DiGi.Scripting.Python.Classes.Script.Script(DiGi.Scripting.Classes.Code,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_)'></a>

## Script\(Code, IEnumerable\<VariableType\>, IEnumerable\<VariableType\>\) Constructor

Initializes a new instance of the [Script](DiGi.Scripting.Python.Classes.md#DiGi.Scripting.Python.Classes.Script 'DiGi\.Scripting\.Python\.Classes\.Script') class with specified code and variable definitions\.

```csharp
public Script(DiGi.Scripting.Classes.Code? code, System.Collections.Generic.IEnumerable<DiGi.Scripting.Classes.VariableType> inputVariableTypes, System.Collections.Generic.IEnumerable<DiGi.Scripting.Classes.VariableType> outputVariableTypes);
```
#### Parameters

<a name='DiGi.Scripting.Python.Classes.Script.Script(DiGi.Scripting.Classes.Code,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_).code'></a>

`code` [DiGi\.Scripting\.Classes\.Code](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.code 'DiGi\.Scripting\.Classes\.Code')

The source code to be executed\.

<a name='DiGi.Scripting.Python.Classes.Script.Script(DiGi.Scripting.Classes.Code,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_).inputVariableTypes'></a>

`inputVariableTypes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Scripting\.Classes\.VariableType](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.variabletype 'DiGi\.Scripting\.Classes\.VariableType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of expected input variable types\.

<a name='DiGi.Scripting.Python.Classes.Script.Script(DiGi.Scripting.Classes.Code,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_).outputVariableTypes'></a>

`outputVariableTypes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Scripting\.Classes\.VariableType](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.variabletype 'DiGi\.Scripting\.Classes\.VariableType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of expected output variable types\.

<a name='DiGi.Scripting.Python.Classes.Script.Script(DiGi.Scripting.Python.Classes.Script)'></a>

## Script\(Script\) Constructor

Initializes a new instance of the [Script](DiGi.Scripting.Python.Classes.md#DiGi.Scripting.Python.Classes.Script 'DiGi\.Scripting\.Python\.Classes\.Script') class by copying an existing script\.

```csharp
public Script(DiGi.Scripting.Python.Classes.Script? script);
```
#### Parameters

<a name='DiGi.Scripting.Python.Classes.Script.Script(DiGi.Scripting.Python.Classes.Script).script'></a>

`script` [Script](DiGi.Scripting.Python.Classes.md#DiGi.Scripting.Python.Classes.Script 'DiGi\.Scripting\.Python\.Classes\.Script')

The source script to copy from\.

<a name='DiGi.Scripting.Python.Classes.Script.Script(System.Text.Json.Nodes.JsonObject)'></a>

## Script\(JsonObject\) Constructor

Initializes a new instance of the [Script](DiGi.Scripting.Python.Classes.md#DiGi.Scripting.Python.Classes.Script 'DiGi\.Scripting\.Python\.Classes\.Script') class from a JSON object\.

```csharp
public Script(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Scripting.Python.Classes.Script.Script(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON representation of the script\.
### Methods

<a name='DiGi.Scripting.Python.Classes.Script.Execute(DiGi.Scripting.Classes.Data)'></a>

## Script\.Execute\(Data\) Method

Executes the Python script using the provided input data\.

```csharp
public override DiGi.Scripting.Classes.Response Execute(DiGi.Scripting.Classes.Data? inputData=null);
```
#### Parameters

<a name='DiGi.Scripting.Python.Classes.Script.Execute(DiGi.Scripting.Classes.Data).inputData'></a>

`inputData` [DiGi\.Scripting\.Classes\.Data](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.data 'DiGi\.Scripting\.Classes\.Data')

The data to be passed as inputs to the script\. Can be null\.

#### Returns
[DiGi\.Scripting\.Classes\.Response](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.response 'DiGi\.Scripting\.Classes\.Response')  
A [DiGi\.Scripting\.Classes\.Response](https://learn.microsoft.com/en-us/dotnet/api/digi.scripting.classes.response 'DiGi\.Scripting\.Classes\.Response') containing either the resulting output variables or an exception encountered during execution\.