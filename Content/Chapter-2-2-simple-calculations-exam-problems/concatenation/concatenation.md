## Конкатенация

При използване на оператора **`+`** между променливи от тип текст (или между текст и число) се извършва т.нар. конкатенация (слепване на низове).

```csharp
var firstName = "Ivan";
var lastName = "Ivanov";
var age = 19;
var str = firstName + " " + lastName + " is " + age + " years old";
// Ivan Ivanov is 19 years old
```