#### [DiGi\.Scripting](DiGi.Scripting.Overview.md 'DiGi\.Scripting\.Overview')

## DiGi\.Scripting\.Interfaces Namespace
### Interfaces

<a name='DiGi.Scripting.Interfaces.IInput'></a>

## IInput Interface

Represents a marker interface for script input variables, extending [IVariable](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IVariable 'DiGi\.Scripting\.Interfaces\.IVariable')\.

```csharp
public interface IInput : DiGi.Scripting.Interfaces.IVariable, DiGi.Scripting.Interfaces.IScriptingObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Input](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Input 'DiGi\.Scripting\.Classes\.Input')  
↳ [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput')  
↳ [ISerializableInput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.ISerializableInput 'DiGi\.Scripting\.Interfaces\.ISerializableInput')

Implements [IVariable](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IVariable 'DiGi\.Scripting\.Interfaces\.IVariable'), [IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Scripting.Interfaces.IOutput'></a>

## IOutput Interface

Defines a marker interface for script output variables, extending [IVariable](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IVariable 'DiGi\.Scripting\.Interfaces\.IVariable')\.

```csharp
public interface IOutput : DiGi.Scripting.Interfaces.IVariable, DiGi.Scripting.Interfaces.IScriptingObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput')  
↳ [ISerializableOutput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.ISerializableOutput 'DiGi\.Scripting\.Interfaces\.ISerializableOutput')

Implements [IVariable](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IVariable 'DiGi\.Scripting\.Interfaces\.IVariable'), [IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Scripting.Interfaces.IScript'></a>

## IScript Interface

Defines the contract for a script object that is both scripting\-compatible and serializable,
inheriting from [IScriptingSerializableObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingSerializableObject 'DiGi\.Scripting\.Interfaces\.IScriptingSerializableObject')\.

```csharp
public interface IScript : DiGi.Scripting.Interfaces.IScriptingSerializableObject, DiGi.Scripting.Interfaces.IScriptingObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [Script](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script 'DiGi\.Scripting\.Classes\.Script')

Implements [IScriptingSerializableObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingSerializableObject 'DiGi\.Scripting\.Interfaces\.IScriptingSerializableObject'), [IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.Scripting.Interfaces.IScriptingObject'></a>

## IScriptingObject Interface

Marker interface for objects that are compatible with the scripting system\.

```csharp
public interface IScriptingObject : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Code 'DiGi\.Scripting\.Classes\.Code')  
↳ [Input](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Input 'DiGi\.Scripting\.Classes\.Input')  
↳ [Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response')  
↳ [Script](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script 'DiGi\.Scripting\.Classes\.Script')  
↳ [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput')  
↳ [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput')  
↳ [Variable](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Variable 'DiGi\.Scripting\.Classes\.Variable')  
↳ [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType')  
↳ [IInput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IInput 'DiGi\.Scripting\.Interfaces\.IInput')  
↳ [IOutput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IOutput 'DiGi\.Scripting\.Interfaces\.IOutput')  
↳ [IScript](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScript 'DiGi\.Scripting\.Interfaces\.IScript')  
↳ [IScriptingSerializableObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingSerializableObject 'DiGi\.Scripting\.Interfaces\.IScriptingSerializableObject')  
↳ [ISerializableInput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.ISerializableInput 'DiGi\.Scripting\.Interfaces\.ISerializableInput')  
↳ [ISerializableOutput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.ISerializableOutput 'DiGi\.Scripting\.Interfaces\.ISerializableOutput')  
↳ [IVariable](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IVariable 'DiGi\.Scripting\.Interfaces\.IVariable')

Implements [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Scripting.Interfaces.IScriptingSerializableObject'></a>

## IScriptingSerializableObject Interface

Defines a contract for an object that is both compatible with the scripting system \([IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject')\) and serializable \([DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\)\.

```csharp
public interface IScriptingSerializableObject : DiGi.Scripting.Interfaces.IScriptingObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [Code](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Code 'DiGi\.Scripting\.Classes\.Code')  
↳ [Script](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script 'DiGi\.Scripting\.Classes\.Script')  
↳ [VariableType](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.VariableType 'DiGi\.Scripting\.Classes\.VariableType')  
↳ [IScript](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScript 'DiGi\.Scripting\.Interfaces\.IScript')

Implements [IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.Scripting.Interfaces.ISerializableInput'></a>

## ISerializableInput Interface

Defines a script input variable that is serializable, combining the properties of [IInput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IInput 'DiGi\.Scripting\.Interfaces\.IInput') and [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

```csharp
public interface ISerializableInput : DiGi.Scripting.Interfaces.IInput, DiGi.Scripting.Interfaces.IVariable, DiGi.Scripting.Interfaces.IScriptingObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput')

Implements [IInput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IInput 'DiGi\.Scripting\.Interfaces\.IInput'), [IVariable](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IVariable 'DiGi\.Scripting\.Interfaces\.IVariable'), [IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.Scripting.Interfaces.ISerializableOutput'></a>

## ISerializableOutput Interface

Defines a script output variable that is serializable, combining the properties of [IOutput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IOutput 'DiGi\.Scripting\.Interfaces\.IOutput') and [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

```csharp
public interface ISerializableOutput : DiGi.Scripting.Interfaces.IOutput, DiGi.Scripting.Interfaces.IVariable, DiGi.Scripting.Interfaces.IScriptingObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput')

Implements [IOutput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IOutput 'DiGi\.Scripting\.Interfaces\.IOutput'), [IVariable](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IVariable 'DiGi\.Scripting\.Interfaces\.IVariable'), [IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.Scripting.Interfaces.IVariable'></a>

## IVariable Interface

Defines a script variable that possesses a name and a value\. This interface extends [IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject')\.

```csharp
public interface IVariable : DiGi.Scripting.Interfaces.IScriptingObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Input](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Input 'DiGi\.Scripting\.Classes\.Input')  
↳ [SerializableInput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableInput 'DiGi\.Scripting\.Classes\.SerializableInput')  
↳ [SerializableOutput](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.SerializableOutput 'DiGi\.Scripting\.Classes\.SerializableOutput')  
↳ [IInput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IInput 'DiGi\.Scripting\.Interfaces\.IInput')  
↳ [IOutput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IOutput 'DiGi\.Scripting\.Interfaces\.IOutput')  
↳ [ISerializableInput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.ISerializableInput 'DiGi\.Scripting\.Interfaces\.ISerializableInput')  
↳ [ISerializableOutput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.ISerializableOutput 'DiGi\.Scripting\.Interfaces\.ISerializableOutput')

Implements [IScriptingObject](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IScriptingObject 'DiGi\.Scripting\.Interfaces\.IScriptingObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Scripting.Interfaces.IVariable.Name'></a>

## IVariable\.Name Property

Gets the name of the variable\.

```csharp
string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Scripting.Interfaces.IVariable.Value'></a>

## IVariable\.Value Property

Gets the value associated with the variable\.

```csharp
object? Value { get; }
```

#### Property Value
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')