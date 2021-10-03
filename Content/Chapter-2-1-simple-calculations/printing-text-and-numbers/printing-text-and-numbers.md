## Печатане на текст и числа

При печат в конзолата на текст, числа и други данни, **можем да ги съединим**, като използваме шаблони **`{0}`**, **`{1}`**, **`{2}`** и т.н. В програмирането тези шаблони се наричат **placeholders**.

```csharp
var firstName = Console.ReadLine();
var lastName = Console.ReadLine();
var age = int.Parse(Console.ReadLine());
var town = Console.ReadLine();
Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.",
  firstName, lastName, age, town);
```

Ето резултатът, който ще получим, след изпълнение на този пример:

![](/assets/chapter-2-images/00.Placeholders-01.jpg)

Обърнете внимание как всяка една променлива трябва да бъде подадена в **реда, в който искаме да се печата**. По същество, шаблонът (**placeholder**) **приема променливи от всякакъв вид**.

Възможно е един и същ номер на шаблон да се използва по няколко пъти и не е задължително шаблоните да са номерирани поредно. Ето пример:

```csharp
Console.WriteLine("{1} + {1} = {0}", 1+1, 1);
```

Резултатът е:
```
1 + 1 = 2
```

### Тестване в Judge системата

Тествайте решението си тук: [https://judge.softuni.org/Contests/Practice/Index/504#3](https://judge.softuni.org/Contests/Practice/Index/504#3).
