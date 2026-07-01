#### [DiGi\.Scripting](index.md 'index')

## DiGi\.Scripting\.Classes Namespace
### Classes

<a name='DiGi.Scripting.Classes.Code'></a>

## Code Class

Wraps script source code as a serializable string value\.

```csharp
public sealed class Code : DiGi.Core.Classes.SerializableObject, DiGi.Scripting.Interfaces.IScriptingSerializableObject, DiGi.Scripting.Interfaces.IScriptingObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Code

Implements [IScriptingSerializableObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingSerializableObject 'DiGi\.Scripting\.Interfaces\.IScriptingSerializableObject'), [IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Scripting.Classes.Code.Code(DiGi.Scripting.Classes.Code)'></a>

## Code\(Code\) Constructor

Initializes a new instance of the [Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Code 'DiGi\.Scripting\.Classes\.Code') class by copying another [Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Code 'DiGi\.Scripting\.Classes\.Code') instance\.

```csharp
public Code(DiGi.Scripting.Classes.Code? code);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Code.Code(DiGi.Scripting.Classes.Code).code'></a>

`code` [Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Code 'DiGi\.Scripting\.Classes\.Code')

The source [Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Code 'DiGi\.Scripting\.Classes\.Code') object to copy from\.

<a name='DiGi.Scripting.Classes.Code.Code(string)'></a>

## Code\(string\) Constructor

Initializes a new instance of the [Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Code 'DiGi\.Scripting\.Classes\.Code') class with the specified source code\.

```csharp
public Code(string? value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Code.Code(string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The script source code\.

<a name='DiGi.Scripting.Classes.Code.Code(System.Text.Json.Nodes.JsonObject)'></a>

## Code\(JsonObject\) Constructor

Initializes a new instance of the [Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Code 'DiGi\.Scripting\.Classes\.Code') class from a JSON object\.

```csharp
public Code(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Code.Code(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the code data\.
### Properties

<a name='DiGi.Scripting.Classes.Code.Value'></a>

## Code\.Value Property

Gets the script source code value\.

```csharp
public string? Value { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Operators

<a name='DiGi.Scripting.Classes.Code.op_ImplicitDiGi.Scripting.Classes.Code(string)'></a>

## Code\.implicit operator Code\(string\) Operator

Implicitly converts a string to a [Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Code 'DiGi\.Scripting\.Classes\.Code') instance\.

```csharp
public static DiGi.Scripting.Classes.Code? implicit operator DiGi.Scripting.Classes.Code?(string? value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Code.op_ImplicitDiGi.Scripting.Classes.Code(string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string value to convert\.

#### Returns
[Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Code 'DiGi\.Scripting\.Classes\.Code')  
A new [Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Code 'DiGi\.Scripting\.Classes\.Code') instance wrapping the provided string\.

<a name='DiGi.Scripting.Classes.Code.op_Implicitstring(DiGi.Scripting.Classes.Code)'></a>

## Code\.implicit operator string\(Code\) Operator

Implicitly converts a [Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Code 'DiGi\.Scripting\.Classes\.Code') instance to its underlying string value\.

```csharp
public static string? implicit operator string?(DiGi.Scripting.Classes.Code? code);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Code.op_Implicitstring(DiGi.Scripting.Classes.Code).code'></a>

`code` [Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Code 'DiGi\.Scripting\.Classes\.Code')

The [Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Code 'DiGi\.Scripting\.Classes\.Code') object to convert\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The source code string, or null if the object is null\.

<a name='DiGi.Scripting.Classes.CodeMissingException'></a>

## CodeMissingException Class

The exception that is thrown when script source code is missing\.

```csharp
public class CodeMissingException : System.Exception
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception 'System\.Exception') → CodeMissingException
### Constructors

<a name='DiGi.Scripting.Classes.CodeMissingException.CodeMissingException()'></a>

## CodeMissingException\(\) Constructor

Initializes a new instance of the [CodeMissingException](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.CodeMissingException 'DiGi\.Scripting\.Classes\.CodeMissingException') class\.

```csharp
public CodeMissingException();
```

<a name='DiGi.Scripting.Classes.CompileException'></a>

## CompileException Class

The exception that is thrown when an error occurs during the compilation of a script\.

```csharp
public class CompileException : System.Exception
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception 'System\.Exception') → CompileException
### Constructors

<a name='DiGi.Scripting.Classes.CompileException.CompileException(string)'></a>

## CompileException\(string\) Constructor

Initializes a new instance of the [CompileException](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.CompileException 'DiGi\.Scripting\.Classes\.CompileException') class with a specified error message\.

```csharp
public CompileException(string? message);
```
#### Parameters

<a name='DiGi.Scripting.Classes.CompileException.CompileException(string).message'></a>

`message` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The message that describes the error\.

<a name='DiGi.Scripting.Classes.Data'></a>

## Data Class

A key/value store for script execution data, extending [System\.Collections\.Generic\.Dictionary&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')\.

```csharp
public class Data : System.Collections.Generic.Dictionary<string, dynamic?>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[dynamic](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/using-type-dynamic 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/programming\-guide/types/using\-type\-dynamic')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2') → Data
### Constructors

<a name='DiGi.Scripting.Classes.Data.Data()'></a>

## Data\(\) Constructor

Initializes a new instance of the [Data](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Data 'DiGi\.Scripting\.Classes\.Data') class\.

```csharp
public Data();
```

<a name='DiGi.Scripting.Classes.Data.Data(System.Collections.Generic.IDictionary_string,object_)'></a>

## Data\(IDictionary\<string,object\>\) Constructor

Initializes a new instance of the [Data](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Data 'DiGi\.Scripting\.Classes\.Data') class using an existing dictionary\.

```csharp
public Data(System.Collections.Generic.IDictionary<string,object?>? dictionary);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Data.Data(System.Collections.Generic.IDictionary_string,object_).dictionary'></a>

`dictionary` [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

The source dictionary containing values to be copied into this instance\.

<a name='DiGi.Scripting.Classes.Data.Data(System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_string,dynamic__)'></a>

## Data\(IEnumerable\<KeyValuePair\<string,dynamic\>\>\) Constructor

Initializes a new instance of the [Data](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Data 'DiGi\.Scripting\.Classes\.Data') class using a collection of key\-value pairs\.

```csharp
public Data(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,dynamic?>>? keyValuePairs);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Data.Data(System.Collections.Generic.IEnumerable_System.Collections.Generic.KeyValuePair_string,dynamic__).keyValuePairs'></a>

`keyValuePairs` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Collections\.Generic\.KeyValuePair&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[dynamic](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/using-type-dynamic 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/programming\-guide/types/using\-type\-dynamic')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.keyvaluepair-2 'System\.Collections\.Generic\.KeyValuePair\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of key\-value pairs to initialize this instance with\.
### Properties

<a name='DiGi.Scripting.Classes.Data.Dictionary'></a>

## Data\.Dictionary Property

Gets a [System\.Collections\.Generic\.Dictionary&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2') representation of the current data\.

```csharp
public System.Collections.Generic.Dictionary<string,dynamic?> Dictionary { get; }
```

#### Property Value
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[dynamic](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/using-type-dynamic 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/programming\-guide/types/using\-type\-dynamic')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

<a name='DiGi.Scripting.Classes.Input'></a>

## Input Class

Represents a script input variable, extending the base [Variable](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable 'DiGi\.Scripting\.Classes\.Variable') class and implementing [IInput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IInput 'DiGi\.Scripting\.Interfaces\.IInput')\.

```csharp
public class Input : DiGi.Scripting.Classes.Variable, DiGi.Scripting.Interfaces.IInput, DiGi.Scripting.Interfaces.IVariable, DiGi.Scripting.Interfaces.IScriptingObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Variable](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable 'DiGi\.Scripting\.Classes\.Variable') → Input

Derived  
↳ [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput')

Implements [IInput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IInput 'DiGi\.Scripting\.Interfaces\.IInput'), [IVariable](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IVariable 'DiGi\.Scripting\.Interfaces\.IVariable'), [IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Scripting.Classes.Input.Input()'></a>

## Input\(\) Constructor

Initializes a new instance of the [Input](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Input 'DiGi\.Scripting\.Classes\.Input') class\.

```csharp
protected Input();
```

<a name='DiGi.Scripting.Classes.Input.Input(DiGi.Scripting.Classes.Input)'></a>

## Input\(Input\) Constructor

Initializes a new instance of the [Input](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Input 'DiGi\.Scripting\.Classes\.Input') class by copying another input variable\.

```csharp
public Input(DiGi.Scripting.Classes.Input? input);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Input.Input(DiGi.Scripting.Classes.Input).input'></a>

`input` [Input](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Input 'DiGi\.Scripting\.Classes\.Input')

The source [Input](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Input 'DiGi\.Scripting\.Classes\.Input') object to copy from\.

<a name='DiGi.Scripting.Classes.Input.Input(DiGi.Scripting.Classes.VariableType,object)'></a>

## Input\(VariableType, object\) Constructor

Initializes a new instance of the [Input](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Input 'DiGi\.Scripting\.Classes\.Input') class using a [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType') and a value\.

```csharp
public Input(DiGi.Scripting.Classes.VariableType? variableType, object? value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Input.Input(DiGi.Scripting.Classes.VariableType,object).variableType'></a>

`variableType` [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType')

The [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType') defining the name and type of the variable\.

<a name='DiGi.Scripting.Classes.Input.Input(DiGi.Scripting.Classes.VariableType,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The initial value of the input variable\.

<a name='DiGi.Scripting.Classes.Input.Input(string,System.Type,object)'></a>

## Input\(string, Type, object\) Constructor

Initializes a new instance of the [Input](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Input 'DiGi\.Scripting\.Classes\.Input') class with a specified name, type, and value\.

```csharp
public Input(string? name, System.Type? type, object? value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Input.Input(string,System.Type,object).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.Input.Input(string,System.Type,object).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type') of the input variable\.

<a name='DiGi.Scripting.Classes.Input.Input(string,System.Type,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The initial value of the input variable\.

<a name='DiGi.Scripting.Classes.Output'></a>

## Output Class

Represents a script output variable\.

```csharp
public class Output : DiGi.Scripting.Classes.Variable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Variable](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable 'DiGi\.Scripting\.Classes\.Variable') → Output

Derived  
↳ [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput')
### Constructors

<a name='DiGi.Scripting.Classes.Output.Output()'></a>

## Output\(\) Constructor

Initializes a new instance of the [Output](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Output 'DiGi\.Scripting\.Classes\.Output') class\.

```csharp
protected Output();
```

<a name='DiGi.Scripting.Classes.Output.Output(DiGi.Scripting.Classes.Output)'></a>

## Output\(Output\) Constructor

Initializes a new instance of the [Output](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Output 'DiGi\.Scripting\.Classes\.Output') class by copying another output variable\.

```csharp
public Output(DiGi.Scripting.Classes.Output? output);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Output.Output(DiGi.Scripting.Classes.Output).output'></a>

`output` [Output](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Output 'DiGi\.Scripting\.Classes\.Output')

The source output variable to copy\.

<a name='DiGi.Scripting.Classes.Output.Output(DiGi.Scripting.Classes.VariableType,object)'></a>

## Output\(VariableType, object\) Constructor

Initializes a new instance of the [Output](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Output 'DiGi\.Scripting\.Classes\.Output') class with specified variable type and value\.

```csharp
public Output(DiGi.Scripting.Classes.VariableType? variableType, object? value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Output.Output(DiGi.Scripting.Classes.VariableType,object).variableType'></a>

`variableType` [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType')

The [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType') defining the name and type of the output variable\.

<a name='DiGi.Scripting.Classes.Output.Output(DiGi.Scripting.Classes.VariableType,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The initial value of the output variable\.

<a name='DiGi.Scripting.Classes.Output.Output(string,System.Type,object)'></a>

## Output\(string, Type, object\) Constructor

Initializes a new instance of the [Output](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Output 'DiGi\.Scripting\.Classes\.Output') class with specified name, type, and value\.

```csharp
public Output(string? name, System.Type? type, object? value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Output.Output(string,System.Type,object).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.Output.Output(string,System.Type,object).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The data type of the output variable\.

<a name='DiGi.Scripting.Classes.Output.Output(string,System.Type,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The initial value of the output variable\.

<a name='DiGi.Scripting.Classes.Response'></a>

## Response Class

Represents the result of a script execution, containing either the produced [Output](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Output 'DiGi\.Scripting\.Classes\.Output') variables or an exception if the execution failed\.

```csharp
public class Response : DiGi.Scripting.Interfaces.IScriptingObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Response

Implements [IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Scripting.Classes.Response.Response(System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.Output_)'></a>

## Response\(IEnumerable\<Output\>\) Constructor

Initializes a new instance of the [Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response') class with the specified collection of outputs\.

```csharp
public Response(System.Collections.Generic.IEnumerable<DiGi.Scripting.Classes.Output>? outputs);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Response.Response(System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.Output_).outputs'></a>

`outputs` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Output](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Output 'DiGi\.Scripting\.Classes\.Output')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [Output](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Output 'DiGi\.Scripting\.Classes\.Output') variables produced by the script\.

<a name='DiGi.Scripting.Classes.Response.Response(System.Exception)'></a>

## Response\(Exception\) Constructor

Initializes a new instance of the [Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response') class with the specified exception\.

```csharp
public Response(System.Exception? exception);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Response.Response(System.Exception).exception'></a>

`exception` [System\.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception 'System\.Exception')

The exception that occurred during script execution, or null if none\.
### Properties

<a name='DiGi.Scripting.Classes.Response.Exception'></a>

## Response\.Exception Property

Gets the exception that occurred during script execution, if any\.

```csharp
public System.Exception? Exception { get; }
```

#### Property Value
[System\.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception 'System\.Exception')

<a name='DiGi.Scripting.Classes.Response.Outputs'></a>

## Response\.Outputs Property

Gets the collection of [Output](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Output 'DiGi\.Scripting\.Classes\.Output') variables produced by the script\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.Scripting.Classes.Output>? Outputs { get; private set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Output](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Output 'DiGi\.Scripting\.Classes\.Output')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Scripting.Classes.Response.Succeeded'></a>

## Response\.Succeeded Property

Gets a value indicating whether the script execution succeeded without throwing an exception\.

```csharp
public bool Succeeded { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Scripting.Classes.Script'></a>

## Script Class

Abstract base class for language\-specific script runners, implementing [IScript](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScript 'DiGi\.Scripting\.Interfaces\.IScript')\.

```csharp
public abstract class Script : DiGi.Core.Classes.SerializableObject, DiGi.Scripting.Interfaces.IScript, DiGi.Scripting.Interfaces.IScriptingSerializableObject, DiGi.Scripting.Interfaces.IScriptingObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Script

Implements [IScript](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScript 'DiGi\.Scripting\.Interfaces\.IScript'), [IScriptingSerializableObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingSerializableObject 'DiGi\.Scripting\.Interfaces\.IScriptingSerializableObject'), [IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Scripting.Classes.Script.Script(DiGi.Scripting.Classes.Code,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_)'></a>

## Script\(Code, IEnumerable\<VariableType\>, IEnumerable\<VariableType\>\) Constructor

Initializes a new instance of the [Script](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script 'DiGi\.Scripting\.Classes\.Script') class with specified source code and variable type definitions\.

```csharp
public Script(DiGi.Scripting.Classes.Code? code, System.Collections.Generic.IEnumerable<DiGi.Scripting.Classes.VariableType>? inputVariableTypes, System.Collections.Generic.IEnumerable<DiGi.Scripting.Classes.VariableType>? outputVariableTypes);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Script.Script(DiGi.Scripting.Classes.Code,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_).code'></a>

`code` [Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Code 'DiGi\.Scripting\.Classes\.Code')

The [Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script.Code 'DiGi\.Scripting\.Classes\.Script\.Code') containing the script source\.

<a name='DiGi.Scripting.Classes.Script.Script(DiGi.Scripting.Classes.Code,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_).inputVariableTypes'></a>

`inputVariableTypes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType') defining the expected inputs\.

<a name='DiGi.Scripting.Classes.Script.Script(DiGi.Scripting.Classes.Code,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.VariableType_).outputVariableTypes'></a>

`outputVariableTypes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType') defining the expected outputs\.

<a name='DiGi.Scripting.Classes.Script.Script(DiGi.Scripting.Classes.Script)'></a>

## Script\(Script\) Constructor

Initializes a new instance of the [Script](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script 'DiGi\.Scripting\.Classes\.Script') class by copying another script instance\.

```csharp
public Script(DiGi.Scripting.Classes.Script? script);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Script.Script(DiGi.Scripting.Classes.Script).script'></a>

`script` [Script](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script 'DiGi\.Scripting\.Classes\.Script')

The source [Script](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script 'DiGi\.Scripting\.Classes\.Script') to copy from\.

<a name='DiGi.Scripting.Classes.Script.Script(System.Text.Json.Nodes.JsonObject)'></a>

## Script\(JsonObject\) Constructor

Initializes a new instance of the [Script](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script 'DiGi\.Scripting\.Classes\.Script') class from a JSON object\.

```csharp
public Script(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Script.Script(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the serialized script data\.
### Properties

<a name='DiGi.Scripting.Classes.Script.Code'></a>

## Script\.Code Property

Gets or sets the source code of the script wrapped in a [Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script.Code 'DiGi\.Scripting\.Classes\.Script\.Code') object\.

```csharp
public DiGi.Scripting.Classes.Code? Code { get; set; }
```

#### Property Value
[Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Code 'DiGi\.Scripting\.Classes\.Code')

<a name='DiGi.Scripting.Classes.Script.InputVariableTypes'></a>

## Script\.InputVariableTypes Property

Gets or sets the collection of [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType') defining the input variables for the script\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.Scripting.Classes.VariableType>? InputVariableTypes { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Scripting.Classes.Script.OutputVariableTypes'></a>

## Script\.OutputVariableTypes Property

Gets or sets the collection of [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType') defining the output variables for the script\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.Scripting.Classes.VariableType>? OutputVariableTypes { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')
### Methods

<a name='DiGi.Scripting.Classes.Script.Execute(DiGi.Scripting.Classes.Data)'></a>

## Script\.Execute\(Data\) Method

Executes the script using the provided input data\.

```csharp
public abstract DiGi.Scripting.Classes.Response? Execute(DiGi.Scripting.Classes.Data? inputData=null);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Script.Execute(DiGi.Scripting.Classes.Data).inputData'></a>

`inputData` [Data](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Data 'DiGi\.Scripting\.Classes\.Data')

The [Data](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Data 'DiGi\.Scripting\.Classes\.Data') containing inputs for execution\.

#### Returns
[Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response')  
A [Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response') object containing the result of the execution or an exception\.

<a name='DiGi.Scripting.Classes.Script.Execute_TInput_(System.Collections.Generic.IEnumerable_TInput_)'></a>

## Script\.Execute\<TInput\>\(IEnumerable\<TInput\>\) Method

Executes the script using a collection of [IInput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IInput 'DiGi\.Scripting\.Interfaces\.IInput') objects as inputs\.

```csharp
public DiGi.Scripting.Classes.Response? Execute<TInput>(System.Collections.Generic.IEnumerable<TInput>? inputs=null)
    where TInput : DiGi.Scripting.Interfaces.IInput;
```
#### Type parameters

<a name='DiGi.Scripting.Classes.Script.Execute_TInput_(System.Collections.Generic.IEnumerable_TInput_).TInput'></a>

`TInput`

A type that implements [IInput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IInput 'DiGi\.Scripting\.Interfaces\.IInput')\.
#### Parameters

<a name='DiGi.Scripting.Classes.Script.Execute_TInput_(System.Collections.Generic.IEnumerable_TInput_).inputs'></a>

`inputs` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script.Execute_TInput_(System.Collections.Generic.IEnumerable_TInput_).TInput 'DiGi\.Scripting\.Classes\.Script\.Execute\<TInput\>\(System\.Collections\.Generic\.IEnumerable\<TInput\>\)\.TInput')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of input variables\.

#### Returns
[Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response')  
A [Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response') object containing the result of the execution or an exception\.

<a name='DiGi.Scripting.Classes.SerializableInput'></a>

## SerializableInput Class

Represents a script input variable that can be serialized and deserialized\.

```csharp
public class SerializableInput : DiGi.Scripting.Classes.Input, DiGi.Scripting.Interfaces.ISerializableInput, DiGi.Scripting.Interfaces.IInput, DiGi.Scripting.Interfaces.IVariable, DiGi.Scripting.Interfaces.IScriptingObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Variable](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable 'DiGi\.Scripting\.Classes\.Variable') → [Input](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Input 'DiGi\.Scripting\.Classes\.Input') → SerializableInput

Implements [ISerializableInput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.ISerializableInput 'DiGi\.Scripting\.Interfaces\.ISerializableInput'), [IInput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IInput 'DiGi\.Scripting\.Interfaces\.IInput'), [IVariable](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IVariable 'DiGi\.Scripting\.Interfaces\.IVariable'), [IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(DiGi.Scripting.Classes.SerializableInput)'></a>

## SerializableInput\(SerializableInput\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class by copying another serializable input\.

```csharp
public SerializableInput(DiGi.Scripting.Classes.SerializableInput? serializableInput);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(DiGi.Scripting.Classes.SerializableInput).serializableInput'></a>

`serializableInput` [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput')

The source serializable input to copy from\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,byte)'></a>

## SerializableInput\(string, byte\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class with a specified name and byte value\.

```csharp
public SerializableInput(string? name, byte value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,byte).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,byte).value'></a>

`value` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')

The byte value to assign\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,byte[])'></a>

## SerializableInput\(string, byte\[\]\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class with a specified name and array of bytes\.

```csharp
public SerializableInput(string? name, byte[] value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,byte[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,byte[]).value'></a>

`value` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The byte array to assign\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,DiGi.Core.Interfaces.ISerializableObject)'></a>

## SerializableInput\(string, ISerializableObject\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class with a specified name and serializable object value\.

```csharp
public SerializableInput(string? name, DiGi.Core.Interfaces.ISerializableObject value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,DiGi.Core.Interfaces.ISerializableObject).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,DiGi.Core.Interfaces.ISerializableObject).value'></a>

`value` [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') value to assign\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,DiGi.Core.Interfaces.ISerializableObject[])'></a>

## SerializableInput\(string, ISerializableObject\[\]\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class with a specified name and array of serializable objects\.

```csharp
public SerializableInput(string? name, DiGi.Core.Interfaces.ISerializableObject[] value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,DiGi.Core.Interfaces.ISerializableObject[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,DiGi.Core.Interfaces.ISerializableObject[]).value'></a>

`value` [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') array to assign\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,double)'></a>

## SerializableInput\(string, double\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class with a specified name and double value\.

```csharp
public SerializableInput(string? name, double value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,double).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value to assign\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,double[])'></a>

## SerializableInput\(string, double\[\]\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class with a specified name and array of doubles\.

```csharp
public SerializableInput(string? name, double[] value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,double[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,double[]).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The double array to assign\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,int)'></a>

## SerializableInput\(string, int\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class with a specified name and integer value\.

```csharp
public SerializableInput(string? name, int value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,int).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,int).value'></a>

`value` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer value to assign\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,int[])'></a>

## SerializableInput\(string, int\[\]\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class with a specified name and array of integers\.

```csharp
public SerializableInput(string? name, int[] value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,int[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,int[]).value'></a>

`value` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The integer array to assign\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,long)'></a>

## SerializableInput\(string, long\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class with a specified name and long value\.

```csharp
public SerializableInput(string? name, long value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,long).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,long).value'></a>

`value` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The long value to assign\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,long[])'></a>

## SerializableInput\(string, long\[\]\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class with a specified name and array of longs\.

```csharp
public SerializableInput(string? name, long[] value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,long[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,long[]).value'></a>

`value` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The long array to assign\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,string)'></a>

## SerializableInput\(string, string\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class with a specified name and string value\.

```csharp
public SerializableInput(string? name, string value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string value to assign\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,string[])'></a>

## SerializableInput\(string, string\[\]\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class with a specified name and array of strings\.

```csharp
public SerializableInput(string? name, string[] value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,string[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,string[]).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The string array to assign\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,System.DateTime)'></a>

## SerializableInput\(string, DateTime\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class with a specified name and DateTime value\.

```csharp
public SerializableInput(string? name, System.DateTime value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,System.DateTime).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,System.DateTime).value'></a>

`value` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The DateTime value to assign\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,System.DateTime[])'></a>

## SerializableInput\(string, DateTime\[\]\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class with a specified name and array of DateTimes\.

```csharp
public SerializableInput(string? name, System.DateTime[] value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,System.DateTime[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,System.DateTime[]).value'></a>

`value` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The DateTime array to assign\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,System.Guid)'></a>

## SerializableInput\(string, Guid\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class with a specified name and Guid value\.

```csharp
public SerializableInput(string? name, System.Guid value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,System.Guid).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,System.Guid).value'></a>

`value` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The Guid value to assign\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,System.Guid[])'></a>

## SerializableInput\(string, Guid\[\]\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class with a specified name and array of Guids\.

```csharp
public SerializableInput(string? name, System.Guid[] value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,System.Guid[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the input variable\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(string,System.Guid[]).value'></a>

`value` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The Guid array to assign\.

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableInput\(JsonObject\) Constructor

Initializes a new instance of the [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput') class from a JSON object\.

```csharp
public SerializableInput(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.SerializableInput(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data\.
### Methods

<a name='DiGi.Scripting.Classes.SerializableInput.Clone()'></a>

## SerializableInput\.Clone\(\) Method

Creates a deep copy of the serializable input\.

```csharp
public DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A clone of the current instance as an [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

<a name='DiGi.Scripting.Classes.SerializableInput.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableInput\.FromJsonObject\(JsonObject\) Method

Populates the properties of the serializable input from a JSON object\.

```csharp
public bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableInput.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to read data from\.

Implements [FromJsonObject\(JsonObject\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.fromjsonobject#digi-core-interfaces-iserializableobject-fromjsonobject(system-text-json-nodes-jsonobject) 'DiGi\.Core\.Interfaces\.ISerializableObject\.FromJsonObject\(System\.Text\.Json\.Nodes\.JsonObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the operation was successful; otherwise, false\.

<a name='DiGi.Scripting.Classes.SerializableInput.ToJsonObject()'></a>

## SerializableInput\.ToJsonObject\(\) Method

Converts the serializable input to its JSON representation\.

```csharp
public System.Text.Json.Nodes.JsonObject? ToJsonObject();
```

Implements [ToJsonObject\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.tojsonobject 'DiGi\.Core\.Interfaces\.ISerializableObject\.ToJsonObject')

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') representing the current instance\.

<a name='DiGi.Scripting.Classes.SerializableOutput'></a>

## SerializableOutput Class

Represents a serializable script output variable that implements [ISerializableOutput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.ISerializableOutput 'DiGi\.Scripting\.Interfaces\.ISerializableOutput')\.

```csharp
public class SerializableOutput : DiGi.Scripting.Classes.Output, DiGi.Scripting.Interfaces.ISerializableOutput, DiGi.Scripting.Interfaces.IOutput, DiGi.Scripting.Interfaces.IVariable, DiGi.Scripting.Interfaces.IScriptingObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Variable](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable 'DiGi\.Scripting\.Classes\.Variable') → [Output](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Output 'DiGi\.Scripting\.Classes\.Output') → SerializableOutput

Implements [ISerializableOutput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.ISerializableOutput 'DiGi\.Scripting\.Interfaces\.ISerializableOutput'), [IOutput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IOutput 'DiGi\.Scripting\.Interfaces\.IOutput'), [IVariable](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IVariable 'DiGi\.Scripting\.Interfaces\.IVariable'), [IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(DiGi.Scripting.Classes.SerializableOutput)'></a>

## SerializableOutput\(SerializableOutput\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class by copying another serializable output\.

```csharp
public SerializableOutput(DiGi.Scripting.Classes.SerializableOutput? serializableOutput);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(DiGi.Scripting.Classes.SerializableOutput).serializableOutput'></a>

`serializableOutput` [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput')

The source [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') to copy from\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,byte)'></a>

## SerializableOutput\(string, byte\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class with a byte value\.

```csharp
public SerializableOutput(string? name, byte value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,byte).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,byte).value'></a>

`value` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')

The byte value to assign\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,byte[])'></a>

## SerializableOutput\(string, byte\[\]\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class with an array of bytes\.

```csharp
public SerializableOutput(string? name, byte[] value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,byte[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,byte[]).value'></a>

`value` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The byte array value to assign\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,DiGi.Core.Interfaces.ISerializableObject)'></a>

## SerializableOutput\(string, ISerializableObject\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class with an [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') value\.

```csharp
public SerializableOutput(string? name, DiGi.Core.Interfaces.ISerializableObject value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,DiGi.Core.Interfaces.ISerializableObject).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,DiGi.Core.Interfaces.ISerializableObject).value'></a>

`value` [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object value to assign\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,DiGi.Core.Interfaces.ISerializableObject[])'></a>

## SerializableOutput\(string, ISerializableObject\[\]\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class with an array of [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

```csharp
public SerializableOutput(string? name, DiGi.Core.Interfaces.ISerializableObject[] value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,DiGi.Core.Interfaces.ISerializableObject[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,DiGi.Core.Interfaces.ISerializableObject[]).value'></a>

`value` [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The serializable object array value to assign\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,double)'></a>

## SerializableOutput\(string, double\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class with a double value\.

```csharp
public SerializableOutput(string? name, double value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,double).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value to assign\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,double[])'></a>

## SerializableOutput\(string, double\[\]\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class with an array of doubles\.

```csharp
public SerializableOutput(string? name, double[] value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,double[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,double[]).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The double array value to assign\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,int)'></a>

## SerializableOutput\(string, int\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class with an integer value\.

```csharp
public SerializableOutput(string? name, int value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,int).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,int).value'></a>

`value` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer value to assign\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,int[])'></a>

## SerializableOutput\(string, int\[\]\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class with an array of integers\.

```csharp
public SerializableOutput(string? name, int[] value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,int[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,int[]).value'></a>

`value` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The integer array value to assign\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,long)'></a>

## SerializableOutput\(string, long\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class with a long value\.

```csharp
public SerializableOutput(string? name, long value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,long).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,long).value'></a>

`value` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The long value to assign\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,long[])'></a>

## SerializableOutput\(string, long\[\]\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class with an array of longs\.

```csharp
public SerializableOutput(string? name, long[] value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,long[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,long[]).value'></a>

`value` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The long array value to assign\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,string)'></a>

## SerializableOutput\(string, string\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class with a string value\.

```csharp
public SerializableOutput(string? name, string value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string value to assign\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,string[])'></a>

## SerializableOutput\(string, string\[\]\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class with an array of strings\.

```csharp
public SerializableOutput(string? name, string[] value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,string[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,string[]).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The string array value to assign\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,System.DateTime)'></a>

## SerializableOutput\(string, DateTime\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class with a DateTime value\.

```csharp
public SerializableOutput(string? name, System.DateTime value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,System.DateTime).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,System.DateTime).value'></a>

`value` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') value to assign\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,System.DateTime[])'></a>

## SerializableOutput\(string, DateTime\[\]\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class with an array of DateTimes\.

```csharp
public SerializableOutput(string? name, System.DateTime[] value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,System.DateTime[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,System.DateTime[]).value'></a>

`value` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') array value to assign\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,System.Guid)'></a>

## SerializableOutput\(string, Guid\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class with a GUID value\.

```csharp
public SerializableOutput(string? name, System.Guid value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,System.Guid).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,System.Guid).value'></a>

`value` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid') value to assign\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,System.Guid[])'></a>

## SerializableOutput\(string, Guid\[\]\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class with an array of GUIDs\.

```csharp
public SerializableOutput(string? name, System.Guid[] value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,System.Guid[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the output variable\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(string,System.Guid[]).value'></a>

`value` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid') array value to assign\.

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableOutput\(JsonObject\) Constructor

Initializes a new instance of the [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput') class from a JSON object\.

```csharp
public SerializableOutput(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.SerializableOutput(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to populate the instance\.
### Methods

<a name='DiGi.Scripting.Classes.SerializableOutput.Clone()'></a>

## SerializableOutput\.Clone\(\) Method

Creates a deep copy of the serializable output\.

```csharp
public DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A cloned instance as an [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

<a name='DiGi.Scripting.Classes.SerializableOutput.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableOutput\.FromJsonObject\(JsonObject\) Method

Populates the object's properties from a JSON object\.

```csharp
public bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Scripting.Classes.SerializableOutput.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') to read data from\.

Implements [FromJsonObject\(JsonObject\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.fromjsonobject#digi-core-interfaces-iserializableobject-fromjsonobject(system-text-json-nodes-jsonobject) 'DiGi\.Core\.Interfaces\.ISerializableObject\.FromJsonObject\(System\.Text\.Json\.Nodes\.JsonObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the operation was successful; otherwise, false\.

<a name='DiGi.Scripting.Classes.SerializableOutput.ToJsonObject()'></a>

## SerializableOutput\.ToJsonObject\(\) Method

Converts the object to a JSON representation\.

```csharp
public System.Text.Json.Nodes.JsonObject? ToJsonObject();
```

Implements [ToJsonObject\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject.tojsonobject 'DiGi\.Core\.Interfaces\.ISerializableObject\.ToJsonObject')

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') representing this instance\.

<a name='DiGi.Scripting.Classes.Variable'></a>

## Variable Class

Abstract base class for script variables, providing a link between a [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable.VariableType 'DiGi\.Scripting\.Classes\.Variable\.VariableType') and its current value\.

```csharp
public abstract class Variable : DiGi.Scripting.Interfaces.IScriptingObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.INamedObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Variable

Derived  
↳ [Input](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Input 'DiGi\.Scripting\.Classes\.Input')  
↳ [Output](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Output 'DiGi\.Scripting\.Classes\.Output')

Implements [IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject')
### Constructors

<a name='DiGi.Scripting.Classes.Variable.Variable()'></a>

## Variable\(\) Constructor

Initializes a new instance of the [Variable](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable 'DiGi\.Scripting\.Classes\.Variable') class\.

```csharp
protected Variable();
```

<a name='DiGi.Scripting.Classes.Variable.Variable(DiGi.Scripting.Classes.Variable)'></a>

## Variable\(Variable\) Constructor

Initializes a new instance of the [Variable](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable 'DiGi\.Scripting\.Classes\.Variable') class by copying another variable\.

```csharp
public Variable(DiGi.Scripting.Classes.Variable? variable);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Variable.Variable(DiGi.Scripting.Classes.Variable).variable'></a>

`variable` [Variable](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable 'DiGi\.Scripting\.Classes\.Variable')

The source [Variable](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable 'DiGi\.Scripting\.Classes\.Variable') to copy from\.

<a name='DiGi.Scripting.Classes.Variable.Variable(DiGi.Scripting.Classes.VariableType,object)'></a>

## Variable\(VariableType, object\) Constructor

Initializes a new instance of the [Variable](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable 'DiGi\.Scripting\.Classes\.Variable') class with the specified type and value\.

```csharp
public Variable(DiGi.Scripting.Classes.VariableType? variableType, object? value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Variable.Variable(DiGi.Scripting.Classes.VariableType,object).variableType'></a>

`variableType` [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType')

The [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable.VariableType 'DiGi\.Scripting\.Classes\.Variable\.VariableType') defining the variable's metadata\.

<a name='DiGi.Scripting.Classes.Variable.Variable(DiGi.Scripting.Classes.VariableType,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The initial value of the variable\.

<a name='DiGi.Scripting.Classes.Variable.Variable(string,System.Type,object)'></a>

## Variable\(string, Type, object\) Constructor

Initializes a new instance of the [Variable](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable 'DiGi\.Scripting\.Classes\.Variable') class by creating a [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable.VariableType 'DiGi\.Scripting\.Classes\.Variable\.VariableType') from the provided name and type\.

```csharp
public Variable(string? name, System.Type? type, object? value);
```
#### Parameters

<a name='DiGi.Scripting.Classes.Variable.Variable(string,System.Type,object).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the variable\.

<a name='DiGi.Scripting.Classes.Variable.Variable(string,System.Type,object).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The system [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type') of the variable\.

<a name='DiGi.Scripting.Classes.Variable.Variable(string,System.Type,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The initial value of the variable\.
### Properties

<a name='DiGi.Scripting.Classes.Variable.Name'></a>

## Variable\.Name Property

Gets the name of the variable as defined in its [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable.VariableType 'DiGi\.Scripting\.Classes\.Variable\.VariableType')\.

```csharp
public string? Name { get; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Scripting.Classes.Variable.Value'></a>

## Variable\.Value Property

Gets the current value of the variable\.

```csharp
public object? Value { get; }
```

#### Property Value
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

<a name='DiGi.Scripting.Classes.Variable.VariableType'></a>

## Variable\.VariableType Property

Gets a clone of the [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable.VariableType 'DiGi\.Scripting\.Classes\.Variable\.VariableType') associated with this variable\.

```csharp
public DiGi.Scripting.Classes.VariableType? VariableType { get; }
```

#### Property Value
[VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType')

<a name='DiGi.Scripting.Classes.VariableType'></a>

## VariableType Class

Describes a named, typed script variable\.

```csharp
public class VariableType : DiGi.Core.Classes.SerializableObject, DiGi.Core.Interfaces.INamedObject, DiGi.Core.Interfaces.IObject, DiGi.Scripting.Interfaces.IScriptingSerializableObject, DiGi.Scripting.Interfaces.IScriptingObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → VariableType

Implements [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [IScriptingSerializableObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingSerializableObject 'DiGi\.Scripting\.Interfaces\.IScriptingSerializableObject'), [IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Scripting.Classes.VariableType.VariableType(DiGi.Scripting.Classes.VariableType)'></a>

## VariableType\(VariableType\) Constructor

Initializes a new instance of the [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType') class by copying another variable type\.

```csharp
public VariableType(DiGi.Scripting.Classes.VariableType? variableType);
```
#### Parameters

<a name='DiGi.Scripting.Classes.VariableType.VariableType(DiGi.Scripting.Classes.VariableType).variableType'></a>

`variableType` [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType')

The source [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType') to copy\.

<a name='DiGi.Scripting.Classes.VariableType.VariableType(string,System.Type)'></a>

## VariableType\(string, Type\) Constructor

Initializes a new instance of the [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType') class\.

```csharp
public VariableType(string? name, System.Type? type);
```
#### Parameters

<a name='DiGi.Scripting.Classes.VariableType.VariableType(string,System.Type).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the variable\.

<a name='DiGi.Scripting.Classes.VariableType.VariableType(string,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The [Type](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType.Type 'DiGi\.Scripting\.Classes\.VariableType\.Type') of the variable\.

<a name='DiGi.Scripting.Classes.VariableType.VariableType(System.Text.Json.Nodes.JsonObject)'></a>

## VariableType\(JsonObject\) Constructor

Initializes a new instance of the [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType') class from a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')\.

```csharp
public VariableType(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Scripting.Classes.VariableType.VariableType(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize from\.
### Properties

<a name='DiGi.Scripting.Classes.VariableType.Name'></a>

## VariableType\.Name Property

Gets the name of the variable type\.

```csharp
public string? Name { get; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Scripting.Classes.VariableType.Type'></a>

## VariableType\.Type Property

Gets the system [Type](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType.Type 'DiGi\.Scripting\.Classes\.VariableType\.Type') associated with this variable type\.

```csharp
public System.Type? Type { get; }
```

#### Property Value
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')