## Plain English Specs
| Spec | Input | Output |
|:---  | :---  | :----  |
|Replacer should replace whole words only | `FindAndReplace("Hello world", "world", "universe")`|`"Hello universe"`|
|Add to the method so it takes partial matches into account | `FindAndReplace("I am walking my cat to the cathedral", "cat", "dog")`|`"I am walking my dog to the doghedral"`|
