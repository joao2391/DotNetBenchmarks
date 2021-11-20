# DotNet.Benchmarks

DotNet.Benchmarks is a repo to show benchmarks over dotnet features.

### Benchmarks

#### DataStructs
Every method printed contains a for loop that iterates 1000 times.

![DataStructs benchmarks result](https://github.com/joao2391/DotNetBenchmarks/blob/master/DotNet.Benchmarks/DotNet.Benchmarks/DataStructs/assets/Result_CollvsArray.PNG "DataStructs benchmarks result")

-----------------------------------------------------------------------

#### Interface
Every method printed contains a sum and returns its result.

![Interface benchmarks result](https://github.com/joao2391/DotNetBenchmarks/blob/master/DotNet.Benchmarks/DotNet.Benchmarks/Interfaces/assets/Result_Interface.PNG "Interface benchmarks result")

-----------------------------------------------------------------------

#### Loops
Every method printed contains a for loop that iterates 1000 times.

##### For vs Foreach

![For vs Foreach benchmarks result](https://github.com/joao2391/DotNetBenchmarks/blob/master/DotNet.Benchmarks/DotNet.Benchmarks/Loops/assets/ResultForVersusForeach.PNG "For vs Foreach benchmarks result")

##### While vs For vs DoWhile

![While vs For vs DoWhile benchmarks result](https://github.com/joao2391/DotNetBenchmarks/blob/master/DotNet.Benchmarks/DotNet.Benchmarks/Loops/assets/ResultLoopComparison.PNG "While vs For vs DoWhile benchmarks result")

-----------------------------------------------------------------------

#### String

All benchmarks was made using this text:
> "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."

#### String Concat

![String Concat benchmarks result](https://github.com/joao2391/DotNetBenchmarks/blob/master/DotNet.Benchmarks/DotNet.Benchmarks/String/assets/ResultStringComparison.PNG "String Concat benchmarks result")

#### String Methods

![String Methods benchmarks result](https://github.com/joao2391/DotNetBenchmarks/blob/master/DotNet.Benchmarks/DotNet.Benchmarks/String/assets/ResultStringMethods.PNG "String Methods benchmarks result")

-----------------------------------------------------------------------

#### Tasks
Every method printed contains a for loop that iterates 1000 times.

##### For vs Foreach

![For vs Foreach benchmarks result](https://github.com/joao2391/DotNetBenchmarks/blob/master/DotNet.Benchmarks/DotNet.Benchmarks/Loops/assets/ResultForVersusForeach.PNG "For vs Foreach benchmarks result")

##### Async await vs async result

![Async await vs async result benchmarks result](https://github.com/joao2391/DotNetBenchmarks/blob/master/DotNet.Benchmarks/DotNet.Benchmarks/Tasks/assets/Result_AsyncAwait.PNG "Async await vs async result benchmarks result")

##### ConfigureAwait(false) vs await

![ConfigureAwait(false) vs await](https://github.com/joao2391/DotNetBenchmarks/blob/master/DotNet.Benchmarks/DotNet.Benchmarks/Tasks/assets/Result_AwaitConfigureFalse.PNG "ConfigureAwait(false) vs await result benchmarks result")

##### ConfigureAwait(true) vs await

![ConfigureAwait(true) vs await](https://github.com/joao2391/DotNetBenchmarks/blob/master/DotNet.Benchmarks/DotNet.Benchmarks/Tasks/assets/Result_AwaitConfigureTrue.PNG "ConfigureAwait(true) vs await result benchmarks result")

##### ConfigureAwait(true) vs ConfigureAwait(false)

![ConfigureAwait(true) vs ConfigureAwait(false)](https://github.com/joao2391/DotNetBenchmarks/blob/master/DotNet.Benchmarks/DotNet.Benchmarks/Tasks/assets/Result_ConfigureAwait.PNG "ConfigureAwait(true) vs ConfigureAwait(false) result benchmarks result")

-----------------------------------------------------------------------

### Types

#### Object vs Dynamic vs Class

Every method contains a instance of "ClassToTest" with Id, name and address properties.

![Object vs Dynamic vs Class](https://github.com/joao2391/DotNetBenchmarks/blob/master/DotNet.Benchmarks/DotNet.Benchmarks/Types/assets/Result_ObjectComparison.PNG "Object vs Dynamic vs Class result benchmarks result")

#### Struct vs Class vs Dynamic

Every method contains a instance of "StructToTest" with Id, name and address properties.

![Struct vs Class vs Dynamic](https://github.com/joao2391/DotNetBenchmarks/blob/master/DotNet.Benchmarks/DotNet.Benchmarks/Types/assets/Result_StructComparison2.PNG "Struct vs Class vs Dynamic result benchmarks result")


## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
[MIT](https://choosealicense.com/licenses/mit/)
