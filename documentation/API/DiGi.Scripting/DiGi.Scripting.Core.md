#### [DiGi\.Scripting](index.md 'index')

## DiGi\.Scripting\.Core Namespace
### Classes

<a name='DiGi.Scripting.Core.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Scripting.Core.Create.Data_TInput_(thisSystem.Collections.Generic.IEnumerable_TInput_)'></a>

## Create\.Data\<TInput\>\(this IEnumerable\<TInput\>\) Method

Converts a collection of [IInput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IInput 'DiGi\.Scripting\.Interfaces\.IInput') objects into a [Data&lt;TInput&gt;\(this IEnumerable&lt;TInput&gt;\)](DiGi.Scripting.Core.md#DiGi.Scripting.Core.Create.Data_TInput_(thisSystem.Collections.Generic.IEnumerable_TInput_) 'DiGi\.Scripting\.Core\.Create\.Data\<TInput\>\(this System\.Collections\.Generic\.IEnumerable\<TInput\>\)') object\.

```csharp
public static DiGi.Scripting.Classes.Data? Data<TInput>(this System.Collections.Generic.IEnumerable<TInput> inputs)
    where TInput : DiGi.Scripting.Interfaces.IInput;
```
#### Type parameters

<a name='DiGi.Scripting.Core.Create.Data_TInput_(thisSystem.Collections.Generic.IEnumerable_TInput_).TInput'></a>

`TInput`

The type of input variables, which must implement [IInput](DiGi.Scripting.Interfaces.md#DiGi.Scripting.Interfaces.IInput 'DiGi\.Scripting\.Interfaces\.IInput')\.
#### Parameters

<a name='DiGi.Scripting.Core.Create.Data_TInput_(thisSystem.Collections.Generic.IEnumerable_TInput_).inputs'></a>

`inputs` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TInput](DiGi.Scripting.Core.md#DiGi.Scripting.Core.Create.Data_TInput_(thisSystem.Collections.Generic.IEnumerable_TInput_).TInput 'DiGi\.Scripting\.Core\.Create\.Data\<TInput\>\(this System\.Collections\.Generic\.IEnumerable\<TInput\>\)\.TInput')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of input variables to be converted\.

#### Returns
[Data](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Data 'DiGi\.Scripting\.Classes\.Data')  
A [Data&lt;TInput&gt;\(this IEnumerable&lt;TInput&gt;\)](DiGi.Scripting.Core.md#DiGi.Scripting.Core.Create.Data_TInput_(thisSystem.Collections.Generic.IEnumerable_TInput_) 'DiGi\.Scripting\.Core\.Create\.Data\<TInput\>\(this System\.Collections\.Generic\.IEnumerable\<TInput\>\)') instance containing the name\-value pairs from the inputs, or `null` if the input collection is null\.

<a name='DiGi.Scripting.Core.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Scripting.Core.Query.Execute(thisDiGi.Scripting.Classes.Script,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.Data_,DiGi.Scripting.Enums.ThreadingMode)'></a>

## Query\.Execute\(this Script, IEnumerable\<Data\>, ThreadingMode\) Method

Executes a [Script](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script 'DiGi\.Scripting\.Classes\.Script') against multiple sets of input data using the specified threading mode\.

```csharp
public static System.Collections.Generic.List<DiGi.Scripting.Classes.Response?>? Execute(this DiGi.Scripting.Classes.Script? script, System.Collections.Generic.IEnumerable<DiGi.Scripting.Classes.Data>? inputDatas, DiGi.Scripting.Enums.ThreadingMode threadingMode=DiGi.Scripting.Enums.ThreadingMode.Parallel);
```
#### Parameters

<a name='DiGi.Scripting.Core.Query.Execute(thisDiGi.Scripting.Classes.Script,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.Data_,DiGi.Scripting.Enums.ThreadingMode).script'></a>

`script` [Script](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script 'DiGi\.Scripting\.Classes\.Script')

The script to execute\.

<a name='DiGi.Scripting.Core.Query.Execute(thisDiGi.Scripting.Classes.Script,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.Data_,DiGi.Scripting.Enums.ThreadingMode).inputDatas'></a>

`inputDatas` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Data](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Data 'DiGi\.Scripting\.Classes\.Data')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [Data](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Data 'DiGi\.Scripting\.Classes\.Data') objects providing inputs for each execution\.

<a name='DiGi.Scripting.Core.Query.Execute(thisDiGi.Scripting.Classes.Script,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.Data_,DiGi.Scripting.Enums.ThreadingMode).threadingMode'></a>

`threadingMode` [ThreadingMode](DiGi.Scripting.Enums.md#DiGi.Scripting.Enums.ThreadingMode 'DiGi\.Scripting\.Enums\.ThreadingMode')

The [ThreadingMode](DiGi.Scripting.Enums.md#DiGi.Scripting.Enums.ThreadingMode 'DiGi\.Scripting\.Enums\.ThreadingMode') used to control the parallelism of the execution\. Defaults to Parallel\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response') objects containing the results, or null if the script, input data, or threading mode is invalid\.

<a name='DiGi.Scripting.Core.Query.Execute(thisDiGi.Scripting.Classes.Script,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.Data_,System.Threading.Tasks.ParallelOptions)'></a>

## Query\.Execute\(this Script, IEnumerable\<Data\>, ParallelOptions\) Method

Executes a [Script](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script 'DiGi\.Scripting\.Classes\.Script') against multiple sets of input data using the provided parallel options\.

```csharp
public static System.Collections.Generic.List<DiGi.Scripting.Classes.Response?>? Execute(this DiGi.Scripting.Classes.Script? script, System.Collections.Generic.IEnumerable<DiGi.Scripting.Classes.Data>? inputDatas, System.Threading.Tasks.ParallelOptions parallelOptions);
```
#### Parameters

<a name='DiGi.Scripting.Core.Query.Execute(thisDiGi.Scripting.Classes.Script,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.Data_,System.Threading.Tasks.ParallelOptions).script'></a>

`script` [Script](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script 'DiGi\.Scripting\.Classes\.Script')

The script to execute\.

<a name='DiGi.Scripting.Core.Query.Execute(thisDiGi.Scripting.Classes.Script,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.Data_,System.Threading.Tasks.ParallelOptions).inputDatas'></a>

`inputDatas` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Data](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Data 'DiGi\.Scripting\.Classes\.Data')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [Data](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Data 'DiGi\.Scripting\.Classes\.Data') objects providing inputs for each execution\.

<a name='DiGi.Scripting.Core.Query.Execute(thisDiGi.Scripting.Classes.Script,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.Data_,System.Threading.Tasks.ParallelOptions).parallelOptions'></a>

`parallelOptions` [System\.Threading\.Tasks\.ParallelOptions](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.paralleloptions 'System\.Threading\.Tasks\.ParallelOptions')

The [System\.Threading\.Tasks\.ParallelOptions](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.paralleloptions 'System\.Threading\.Tasks\.ParallelOptions') used to configure the parallel loop\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response') objects containing the results, or null if the script or input data is null\.

<a name='DiGi.Scripting.Core.Query.Execute(thisDiGi.Scripting.Classes.Script,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.Data_,System.Threading.Tasks.ParallelOptions,System.Func_DiGi.Scripting.Classes.Response,bool_,DiGi.Scripting.Classes.Response)'></a>

## Query\.Execute\(this Script, IEnumerable\<Data\>, ParallelOptions, Func\<Response,bool\>, Response\) Method

Executes a [Script](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script 'DiGi\.Scripting\.Classes\.Script') against multiple sets of input data with the ability to stop execution based on a response predicate\.

```csharp
public static System.Collections.Generic.List<DiGi.Scripting.Classes.Response?>? Execute(this DiGi.Scripting.Classes.Script? script, System.Collections.Generic.IEnumerable<DiGi.Scripting.Classes.Data>? inputDatas, System.Threading.Tasks.ParallelOptions? parallelOptions, System.Func<DiGi.Scripting.Classes.Response?,bool>? stopFunc, out DiGi.Scripting.Classes.Response? stopResponse);
```
#### Parameters

<a name='DiGi.Scripting.Core.Query.Execute(thisDiGi.Scripting.Classes.Script,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.Data_,System.Threading.Tasks.ParallelOptions,System.Func_DiGi.Scripting.Classes.Response,bool_,DiGi.Scripting.Classes.Response).script'></a>

`script` [Script](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Script 'DiGi\.Scripting\.Classes\.Script')

The script to execute\.

<a name='DiGi.Scripting.Core.Query.Execute(thisDiGi.Scripting.Classes.Script,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.Data_,System.Threading.Tasks.ParallelOptions,System.Func_DiGi.Scripting.Classes.Response,bool_,DiGi.Scripting.Classes.Response).inputDatas'></a>

`inputDatas` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Data](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Data 'DiGi\.Scripting\.Classes\.Data')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [Data](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Data 'DiGi\.Scripting\.Classes\.Data') objects providing inputs for each execution\.

<a name='DiGi.Scripting.Core.Query.Execute(thisDiGi.Scripting.Classes.Script,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.Data_,System.Threading.Tasks.ParallelOptions,System.Func_DiGi.Scripting.Classes.Response,bool_,DiGi.Scripting.Classes.Response).parallelOptions'></a>

`parallelOptions` [System\.Threading\.Tasks\.ParallelOptions](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.paralleloptions 'System\.Threading\.Tasks\.ParallelOptions')

The [System\.Threading\.Tasks\.ParallelOptions](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.paralleloptions 'System\.Threading\.Tasks\.ParallelOptions') used to configure the parallel loop\.

<a name='DiGi.Scripting.Core.Query.Execute(thisDiGi.Scripting.Classes.Script,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.Data_,System.Threading.Tasks.ParallelOptions,System.Func_DiGi.Scripting.Classes.Response,bool_,DiGi.Scripting.Classes.Response).stopFunc'></a>

`stopFunc` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A function that takes a [Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response') and returns true if the overall execution should stop\.

<a name='DiGi.Scripting.Core.Query.Execute(thisDiGi.Scripting.Classes.Script,System.Collections.Generic.IEnumerable_DiGi.Scripting.Classes.Data_,System.Threading.Tasks.ParallelOptions,System.Func_DiGi.Scripting.Classes.Response,bool_,DiGi.Scripting.Classes.Response).stopResponse'></a>

`stopResponse` [Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response')

When this method returns, contains the [Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response') that triggered the stop condition, if any\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [Response](DiGi.Scripting.Classes.md#DiGi.Scripting.Classes.Response 'DiGi\.Scripting\.Classes\.Response') objects containing the results, or null if the script or input data is null\.