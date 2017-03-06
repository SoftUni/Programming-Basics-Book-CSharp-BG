# Глава 2. Прости пресмятания с числа

В настоящата глава ще се запознаем със следните концепции и програмни техники:
- какво представлява системната конзола;
- как да прочитаме числа от системната конзола;
- типовете данни и променливи, които са ни необходими при обработка на числа и операциите между тях;
- как да изведем резултат (число) на системната конзола;
- извършване на прости аритметични операции: събиране, изваждане, умножение, деление, съединяване на низ.


TODO

## Четене на числа от конзолата

Четене на цяло число:

var num = int.Parse(Console.ReadLine());

Пример: пресмятане на лице на квадрат със страна а:

Console.Write("a = ");              
var a = int.Parse(Console.ReadLine());
var area = a * a;
Console.Write("Square = ");
Console.WriteLine(area);

Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/151#0

## Пресмятания в програмирането

Компютрите са машини, които обработват данни
Данните се записват в компютърната памет в променливи
Променливите имат име, тип и стойност
Дефиниране на променлива и присвояване на стойност:

TODO: image

След обработка данните се записват отново в променливи

## Типове данни и променливи

Променливите съхраняват стойност от даден тип
Число, буква, текст (стринг), дата, цвят, картинка, списък, …
Типове данни – примери:
Тип цяло число: 1, 2, 3, 4, 5, …
Тип дробно число: 0.5, 3.14, -1.5, …
Тип буква от азбуката (символ): 'a', 'b', 'c', …
Тип текст (стринг): "Здрасти", "Hi", "Beer", …
Тип ден от седмицата: понеделник, вторник, …

## Четене на дробно число от конзолата

Четене на дробно число от конзолата:

var num = double.Parse(Console.ReadLine());

Пример: прехвърляне от инчове в сантиметри:

Console.Write("Inches = ");              
var inches = double.Parse(Console.ReadLine());
var centimeters = inches * 2.54;
Console.Write("Centimeters = ");
Console.WriteLine(centimeters);

Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/151#1

## Четене и печатане на текст

Четене на текст (стринг) от конзолата:

var str = Console.ReadLine();

Пример: поздрав по име:

Console.Write("Enter your name: ");              
var name = Console.ReadLine();
Console.WriteLine("Hello, {0}!", name);

Изразът {0} се замества спървия аргумент (в случая name)

Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/151#2

## Съединяване на текст и числа

При печат на текст, числа и други данни, можем да ги съединим, използвайки шаблони {0}, {1}, {2}, …

var firstName = Console.ReadLine();
var lastName = Console.ReadLine();
var age = int.Parse(Console.ReadLine());
var town = Console.ReadLine();
Console.WriteLine(
  "You are {0} {1}, a {2}-years old person from {3}.",
  firstName, lastName, age, town);

Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/151#3

## Аритметични операции събиране и изваждане

### Събиране на числа (оператор +)

var a = 5;
var b = 7;
var sum = a + b; // 12

### Изваждане на числа (оператор -)

var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());
var result = a - b;
Console.WriteLine(result);

## Аритметични операции умножение и деление

### Умножение на числа (оператор *)

var a = 5;
var b = 7;
var product = a * b; // 35

### Деление на числа (оператор /)

var a = 25;
var i = a / 4;      // 6 – дробната част се отрязва
var f = a / 4.0;    // 6.25 – дробно делене
var error = a / 0;  // Грешка: деление на 0

### Особености при деление на числа в C#

При деление на цели числа резултатът е цяло число:

var a = 25;
Console.WriteLine(a / 4);  // Целочислен резултат: 6
Console.WriteLine(a / 0);  // Грешка: деление на 0

При деление на дробни числа резултатът е дробно число:

var a = 15;
Console.WriteLine(a / 2.0);  // Дробен резултат: 7.5
Console.WriteLine(a / 0.0);  // Резултат: Infinity
Console.WriteLine(0.0 / 0.0); // Резултат: NaN

## Съединяване на текст и число

Ето как можем да съединяваме текст и число с оператора `+`:

var firstName = "Maria";
var lastName = "Ivanova";
var age = 19;
var str = firstName + " " + lastName + " @ " + age;
Console.WriteLine(str);  // Maria Ivanova @ 19

Още един пример:

var a = 1.5;
var b = 2.5;
var sum = "The sum is: " + a + b;
Console.WriteLine(sum);  // The sum is 1.52.5

## Числени изрази

В програмирането можем да пресмятаме числени изрази:

var expr = (3 + 5) * (4 – 2);

Пример: изчисляване на лице на трапец:

var b1 = double.Parse(Console.ReadLine());
var b2 = double.Parse(Console.ReadLine());
var h = double.Parse(Console.ReadLine());
var area = (b1 + b2) * h / 2.0;
Console.WriteLine("Trapezoid area = " + area);

Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/151#4

## Периметър и лице на кръг – пример

Напишете програма, която въвежда радиуса r на кръг и изчислява лицето и периметъра на кръга / окръжността
Лице = π * r * r
Периметър = 2 * π * r
π ≈ 3.14159265358979323846…

Console.Write("Enter circle radius. r = ");
var r = double.Parse(Console.ReadLine());
Console.WriteLine("Area = " + Math.PI * r * r);
Console.WriteLine("Perimeter = " + 2 * Math.PI * r);

Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/151#5

## Лице на правоъгълник в равнината – пример

Правоъгълник е зададен с координатитена два от своите срещуположни ъгъла
Да се пресметнат площта и периметъра му

TODO: image

double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double width = Math.Max(x1, x2) - Math.Min(x1, x2);
double height = Math.Max(y1, y2) - Math.Min(y1, y2);
Console.WriteLine("Area = {0}", width * height);
Console.WriteLine("Perimeter = {0}", 2 * (width + height));

TODO: judge link

## Какво научихме от тази глава?

Въвеждане на текст

var str = Console.ReadLine();

Въвеждане на число

var num = int.Parse(Console.ReadLine());

Пресмятания с числа: +, -, *, /, ()

var sum = 5 + 3;

Извеждане на текст по шаблон

Console.WriteLine("{0} + {1} = {2}", 3, 5, 3 + 5);

## Упражнения: Прости пресмятания

TODO: да се следва файла "2. Simple-Calculations-Exercises.docx"

### 0.	Празно Visual Studio решение (Blank Solution)
### 1.	Пресмятане на лице на квадрат
### 2.	От инчове към сантиметри
### 3.	Поздрав по име
### 4.	Съединяване на текст и числа
### 5.	Лице на трапец
### 6.	Периметър и лице на кръг
### 7.	Лице на правоъгълник в равнината
### 8.	Лице на триъгълник
### 9.	Конзолен конвертор: от градуси °C към градуси °F
### 10.	Конзолен конвертор: от радиани в градуси
### 11.	Конзолен конвертор: USD към BGN
### 12.	* Конзолен междувалутен конвертор
### 13.	** Пресмятане с дати: 1000 дни на Земята

## Упражнения: графични и уeb приложения

TODO: да се следва файла "2. Simple-Calculations-Exercises.docx"

### Графично приложение: конвертор от BGN към EUR

TODO: да се следва файла "2. Simple-Calculations-Exercises.docx"

### *** Графично приложение: хвани бутона!

TODO: да се следва файла "2. Simple-Calculations-Exercises.docx"
