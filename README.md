# [ValidaZione](https://github.com/joc-luis/ValidaZione)

## Status :skull_and_crossbones:
The library is in testing mode, is not secure for production mode.
## Install
```
dotnet add package ValidaZione
```

## Use

### Import
```cs
using ValidaZione;
```

### Create an object
```cs
Validazione validazione = new Validazione(Language.En);
Validazione validazione = new Validazione(Language.Es);
```

### Add like scoped
```csharp
builder.Services.AddScopped<IValidazion>(v => new Validazione(Language.Fr));


public PersonController(IValidazione validazione) : ControllerBase
{
    _validazione = validazione;
}


public async Task<ActionResult> Store(Person person){

    _validazione.Field("name", person.Name).Between(3, 20);
    _validazione.PassOrException();
}
```

### Validate string
```cs
validazione.Field("Test", "testing").Min(3).Max(10).Alpha();
```

### Validate numbers
```cs
validazione.Field("Test", 4).Between(1, 10);
validazione.Field("Test2", 5.07).Between(1, 10);
```

### Validate lists or arrays
```cs
validazione.Field("Test", new int[] {1, 2, 3}).Between(1, 10);
validazione.Field("Test2", new List<Person>(){ new Person()}).Distinct();
```

### Validate dates
```cs
validazione.Field("Test", DateTime.Now).Before(DateTime.Now.AddDays(1));
```

### Validate booleans
```cs
validazione.Field("Test", true).Accepted();
validazione.Field("Test", false).Declined();
```

### Pass validation
```cs
if(validazione.Pass()){
  //Save data
}
```

### Launch a exception
```cs
try
{
 
    validazione.PassOrException();
    
}
catch(ValidazioneException e){

    Console.WriteLine(e.Message);
    
    foreach(var field in e.Fields){
        field.Errors.ForEach(error => {
            Console.WriteLine(error);
        });
    }
}
```
### Get errors by field
```cs
var fields = validazione.ErrorsByField();
```

### Get all errors
```cs
var errors = validazione.Errors();
```

## Create your custom error messages
### Use the interface
```csharp
public class MyCustomLang : ILang {

    public string FieldName { get; set; }
    
    public string Accepted(){
  
        return "Debes aceptar cederme tu alma.";
    }
 }
```

### Set in the constructor
```csharp
Validazione validazione = new Validazione(new MyCustomLang())
```


## License
[MIT](https://opensource.org/license/mit/)

## External resources
[Icon by Paul J.](https://www.flaticon.com/free-icons/rules)


[Validation messages](https://github.com/Laravel-Lang/lang)
