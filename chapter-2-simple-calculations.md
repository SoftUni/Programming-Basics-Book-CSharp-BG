# Глава 2. Прости пресмятания с числа

В настоящата глава ще се запознаем със следните концепции и програмни техники:
- какво представлява системната конзола;
- как да прочитаме числа от системната конзола;
- типовете данни и променливи, които са ни необходими при обработка на числа и операциите между тях;
- как да изведем резултат (число) на системната конзола;
- извършване на прости аритметични операции: събиране, изваждане, умножение, деление, съединяване на низ.

## Видео
<div class="video-player">
  Гледайте видео-урок по тази глава тук: <a target="_blank" href="https://www.youtube.com/watch?v=0f7c9RIZGaE">https://www.youtube.com/watch?v=0f7c9RIZGaE</a>.
</div>


## Системна конзола
Обикновено наричана само "конзола", системната, или още компютърната конзола, представлява устройството, чрез което подаваме команди на компютъра и получаваме резултатите от тяхното изпълнение. В повечето случаи системната конзола представлява текстови терминал, т.е. приема и визуализира само текст, без графични елементи като например бутони, менюта и т.н. 

## Четене на числа от конзолата

За да прочетем цяло (не дробно) число от конзолата е необходимо да декларираме променлива, да посочим типа на числото, както и да използваме стандартната команда за четене на информация от системната конзола:

```csharp
var num = int.Parse(Console.ReadLine());
```

### Пример: Пресмятане на лице на квадрат със страна **а**

```csharp
Console.Write("a = ");              
var a = int.Parse(Console.ReadLine());
var area = a * a;
Console.Write("Square area = ");
Console.WriteLine(area);
```

Ето как би работила програмата при квадрат със размер на страната 3:

![squareArea](/assets/chapter-2-images/squareArea.jpg)

#### Тестване в Judge системата

Тествайте решението си тук: [https://judge.softuni.bg/Contests/Practice/Index/504#0](https://judge.softuni.bg/Contests/Practice/Index/504#0)

## Пресмятания в програмирането

За компютрите знаем, че са машини, които обработват данни. Всички **данни** се записват в компютърната памет (RAM памет) в **променливи**.
Всяка една **променлива** в C# има **име**, **тип** и **стойност**. Ето как бихме дефинирали една променлива, като едновременно с декларацията й, присвояваме и стойност:

![declaring variables](/assets/chapter-2-images/declaringVariables.png)

След тяхната обработка, данните се записват отново в променливи.

## Типове данни и променливи

В програмирането, всяка една променлива съхранява определена **стойност** от даден **тип**. Типовете данни могат да бъдат например: **число**, **буква**, **текст** (стринг), **дата**, **цвят**, *8картинка**, **списък** и др.
Ето няколко примера за типове данни:
- Тип **цяло число**: 1, 2, 3, 4, 5, …
- Тип **дробно число**: 0.5, 3.14, -1.5, …
- Тип **буква от азбуката** (символ): 'a', 'b', 'c', …
- Тип **текст** (стринг): "Здрасти", "Hi", "Beer", …
- Тип **ден от седмицата**: Monday, Tuesday, …

## Четене на дробно число от конзолата

За да прочетем **дробно число** от конзолата е необходимо отново да **декларираме променлива**, да посочим **типа на числото**, както и да използваме стандартната команда за четене на информация от системната конзола:

```csharp
var num = double.Parse(Console.ReadLine());
```

### Пример: Прехвърляне от инчове в сантиметри

```csharp
Console.Write("Inches = ");              
var inches = double.Parse(Console.ReadLine());
var centimeters = inches * 2.54;
Console.Write("Centimeters = ");
Console.WriteLine(centimeters);
```

Сега нека стартираме програмата и да се уверим, че при подаване на стойност в инчове, получаваме коректен резултат в сантиметри:

![inchesToCm](/assets/chapter-2-images/inchesToCm.jpg)

#### Тестване в Judge системата

Тествайте решението си тук: [https://judge.softuni.bg/Contests/Practice/Index/504#1](https://judge.softuni.bg/Contests/Practice/Index/504#1)

## Четене и печатане на текст

За да прочетем текст (стринг) от конзолата, отново **декларираме нова променлива** и използваме стандартната **команда за четене на информация от системната конзола**:

```csharp
var str = Console.ReadLine();
```

Обърнете внимание, че при четене на текст не се декларира по никакъв начин тип "стринг"(текст). Това е така, защото по подразбиране методът ```Console.ReadLine()``` връща като резултат текст. Допълнително, вие можете да зададете текстът да бъде прехвърлен в цяло число чрез ```int.Parse()``` или дробно число чрез ```double.Parse()```. Ако това не се направи, за програмата **всяко едно число** ще бъде просто **текст**, с който **не биха могли да се извършват** аритметични операции.

### Пример: Поздрав по име

```csharp           
var name = Console.ReadLine();
Console.WriteLine("Hello, {0}!", name);
```

В случая, изразът **`{0}`** се замества с първия подаден аргумент -  в примера - променливата **`name`**:

![greetingByName](/assets/chapter-2-images/greetingByName.jpg)

#### Тестване в Judge системата

Тествайте решението си тук: [https://judge.softuni.bg/Contests/Practice/Index/504#2](https://judge.softuni.bg/Contests/Practice/Index/504#2)

## Съединяване на текст и числа

При печат на конзолата на текст, числа и други данни, ние **можем да ги съединим**, като използваме шаблони **`{0}`**, **`{1}`**, **`{2}`**,... В програмирането тези шаблони се наричат **placeholders**.

```csharp
var firstName = Console.ReadLine();
var lastName = Console.ReadLine();
var age = int.Parse(Console.ReadLine());
var town = Console.ReadLine();
Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.",
  firstName, lastName, age, town);
```

Ето резултатът, който ще получим, след изпълнение на този пример:

![placeholdersInAction](/assets/chapter-2-images/placeholders.jpg)

Обърнете внимание, как всяка една променлива трябва да бъде подадена в **реда, в който искаме да се печата**. По същество,  шаблонът (placeholder) **приема променливи от всякакъв вид**. **Не се допуска** да има шаблони, които да имат една и съща поредност, т.е. два или повече шаблона под номер 2. В такъв случай, вашата програма няма да се компилира. 

#### Тестване в Judge системата

Тествайте решението си тук: [https://judge.softuni.bg/Contests/Practice/Index/504#3](https://judge.softuni.bg/Contests/Practice/Index/504#3)

## Аритметични операции събиране и изваждане

### Събиране на числа (оператор **`+`**)

```csharp
var a = 5;
var b = 7;
var sum = a + b; // резултатът е 12
```

### Изваждане на числа (оператор **`-`**)

```csharp
var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());
var result = a - b;
Console.WriteLine(result);
```
Съответно, ето и резултатът от изпълението на програмата, при числа 10 и 3:

![subtracting](/assets/chapter-2-images/subtracting.jpg)

## Аритметични операции умножение и деление

### Умножение на числа (оператор **`*`**)

```csharp
var a = 5;
var b = 7;
var product = a * b; // 35
```

### Деление на числа (оператор /)

```csharp
var a = 25;
var i = a / 4;      // извършваме т.нер целочислено деление:
                    // резултатът от тази операция ще бъде 6 – дробната част се отрязва, 
                    // тъй като извършваме деление с цели числа
var f = a / 4.0;    // 6.25 – дробно деление. Изрично сме указали числото 4 да се интерпретира
                    // като дробно, като сме добавили 0 след десетичната запетая
var error = a / 0;  // Грешка: деление на 0
```

### Особености при деление на числа в C#

В тази секция ще обърнем внимание на някои особености.

При **деление на цели числа** резултатът е **цяло число**:

```csharp
var a = 25;
Console.WriteLine(a / 4);  // Целочислен резултат: 6
Console.WriteLine(a / 0);  // Грешка: деление на 0
var error = a / 0;  // Грешка: деление на 0
```
При **деление на дробни числа** резултатът е **дробно число**:

```csharp
var a = 15;
Console.WriteLine(a / 2.0);   // Дробен резултат: 7.5
Console.WriteLine(a / 0.0);   // Резултат: Infinity
Console.WriteLine(0.0 / 0.0); // Резултат: NaN (Not a Number), 
                              // резултатът от операцияте не представлява числена стойност
```

## Съединяване на текст и число

Терминът за съединяване на текст и/или числа е **конкатенация**. Ето как можем да съединяваме текст и число с оператора **`+`**:

```csharp
var firstName = "Maria";
var lastName = "Ivanova";
var age = 19;
var str = firstName + " " + lastName + " @ " + age;
Console.WriteLine(str);  // Maria Ivanova @ 19
```

Още един пример:

```csharp
var a = 1.5;
var b = 2.5;
var sum = "The sum is: " + a + b;
Console.WriteLine(sum);  // The sum is: 1.52.5
```

## Числени изрази

В програмирането можем да пресмятаме и числови изрази:

```csharp
var expr = (3 + 5) * (4 – 2);
```
В сила е стандартното правило, че **умножение и деление се извършват винаги преди събиране и изваждане**. При наличие на **израз в скоби, то той се изчислява пръв**. 

### Пример: Изчисляване на лице на трапец

```csharp
var b1 = double.Parse(Console.ReadLine());
var b2 = double.Parse(Console.ReadLine());
var h = double.Parse(Console.ReadLine());
var area = (b1 + b2) * h / 2.0;
Console.WriteLine("Trapezoid area = " + area);
```

#### Тестване в Judge системата

Тествайте решението си тук: https://judge.softuni.bg/Contests/Practice/Index/504#4

### Пример: Периметър и лице на кръг 

Нека напишем една програма, която при въвеждане **радиуса r** на кръг, **изчислява лицето и периметъра** на кръга / окръжността.

Формули:
- Лице = π * r * r
- Периметър = 2 * π * r
- π ≈ 3.14159265358979323846…

```csharp
Console.Write("Enter circle radius. r = ");
var r = double.Parse(Console.ReadLine());
Console.WriteLine("Area = " + Math.PI * r * r); // Math.PI - вградена в C# константа за π
Console.WriteLine("Perimeter = " + 2 * Math.PI * r);
```
Нека изпробваме програмата с **радиус `r = 10`**:

![circleArea](/assets/chapter-2-images/circleArea.jpg)

#### Тестване в Judge системата

Тествайте решението си тук: [https://judge.softuni.bg/Contests/Practice/Index/504#5](https://judge.softuni.bg/Contests/Practice/Index/504#5)

### Пример: Лице на правоъгълник в равнината

Правоъгълник е зададен с **координатите на два от своите срещуположни ъгъла**. Да се пресметнат **площта и периметъра** му:

<img alt="rectangleArea" src="/assets/chapter-2-images/rectangleArea.png" width="250" height="200" />


```csharp
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());

//Изчисляване страните на правоъгълника:
double width = Math.Max(x1, x2) - Math.Min(x1, x2);
double height = Math.Max(y1, y2) - Math.Min(y1, y2);

Console.WriteLine("Area = " + width * height);
Console.WriteLine("Perimeter = " + 2 * (width + height));
```

При стартиране на програмата със стойностите от координатната система в условието, получаваме следния резултат:

![rectangleAreaExample](/assets/chapter-2-images/rectangleAreaExample.jpg)

#### Тестване в Judge системата

Тествайте решението си тук: [https://judge.softuni.bg/Contests/Practice/Index/504#6](https://judge.softuni.bg/Contests/Practice/Index/504#6)

## Какво научихме от тази глава?

- Как да **въвеждаме текст**: **`var str = Console.ReadLine();`**

- Как да **въвеждаме цяло число**: **`var num = int.Parse(Console.ReadLine());`**

- Как да **извършваме пресмятания с числа** и да **използваме съответни оператори за това** [+, -, \*, /, ()]: **`var sum = 5 + 3;`**

- Извеждане на **текст по шаблон**: **`Console.WriteLine("{0} + {1} = {2}", 3, 5, 3 + 5);`**

## Упражнения: Прости пресмятания

Нека затвърдим наученото в тази глава с няколко задачи.

### Празно Visual Studio решение (Blank Solution)

Създайте празно решение **(Blank Solution)** във Visual Studio. Решенията (solutions) във Visual Studio обединяват **група проекти.** Тази възможност е **изключително удобна**, когато искаме да** работим по няколко проекта** и бързо да превключваме между тях или искаме да **обединим логически няколко взаимосвързани проекта**.
В настоящото практическо занимание ще използваме **Blank Solution с няколко проекта** за да организираме решенията на задачите от упражненията – всяка задача в отделен проект и всички проекти в общ solution.

*	Стартирайте Visual Studio.
* Създайте нов **Blank Solution:** [**File**] -> [**New**] -> [**Project**].

![](/assets/chapter-2-images/problems/01newBlankSolution.png)

Изберете от диалоговия прозорец [**Templates**] -> [**Other Project Types**] -> [**Visual Studio Solutions**] -> [**Blank Solution**] и дайте подходящо име на проекта, например “Simple-Calculations”:

<p align="center">
<img alt="namingTheSolution" src="/assets/chapter-2-images/problems/02namingTheSolution.png" />
</p>

Сега имате създаден **празен Visual Studio Solution** (с 0 проекта в него):

![](/assets/chapter-2-images/problems/03blankSolution.png)

Целта на този blank solution e да добавяте в него **по един проект за всяка задача** от упражненията.

### Задача:	Пресмятане на лице на квадрат

Първата задача от тази тема е следната: да се **напише конзолна програма, която въвежда цяло число `a` и пресмята лицето на квадрат със страна `a`**. Задачата е тривиално лесна: **въвеждате число** от конзолата, **умножавате го само по себе си** и **печатате получения резултат** на конзолата.

Създаваме **нов проект** в съществуващото Visual Studio решение. В **Solution Explorer** кликнете с десен бутон на мишката върху **  Solution 'Simple-Calculations'**. Изберете [**Add**] -> [**New Project…**]:

![](/assets/chapter-2-images/problems/02SquareArea/01newProject.png)

Ще се отвори **диалогов прозорец** за избор на **тип проект** за създаване. Изберете **C# конзолно приложение** с име “Square-Area”:

![](/assets/chapter-2-images/problems/02SquareArea/02namingTheProject.png)

Вече имаме solution с едно конзолно приложение в него. Остава да напишем **кода за решаване на задачата**. За целта отиваме в тялото на метода **`Main(string[] args)`** и пишем следния код:

![](/assets/chapter-2-images/problems/02SquareArea/03code.png)

Кодът въвежда цяло число с **`a = int.Parse(Console.ReadLine())`**, след това изчислява **`area = a * a`** и накрая печата стойността на променливата **area**. **Стартираме** програмата с [**Ctrl+F5**] и я **тестваме** с различни входни стойности:

![](/assets/chapter-2-images/problems/02SquareArea/04result.png)

#### Тестване в Judge системата

Тествайте решението си тук:** [https://judge.softuni.bg/Contests/Practice/Index/504#0](https://judge.softuni.bg/Contests/Practice/Index/504#0). Трябва да получите 100 точки (напълно коректно решение):

![](/assets/chapter-2-images/problems/02SquareArea/05resultSubmission_1.png)

![](/assets/chapter-2-images/problems/02SquareArea/05resultSubmission_2.png)

### Задача:	От инчове към сантиметри

Да се напише програма, която **чете от конзолата число** (не непременно цяло) и преобразува числото от **инчове в сантиметри.** За целта **умножава инчовете по 2.54** (защото 1 инч = 2.54 сантиметра).

Първо създаваме **нов C# конзолен проект** в решението “Simple-Calculations”. Кликаме с мишката върху решението в **Solution Explorer** и избираме [**Add**] -> [**New Project…**]:

![](/assets/chapter-2-images/problems/03inchesToCm/01newProject.png)

Избираме [**Visual C#**] -> [**Windows**] -> [**Console Application**] и задайте име “Inches-to-Centimeters”:

![](/assets/chapter-2-images/problems/03inchesToCm/02nameTheProject.png)

Следва да напишем **кода на програмата**:

![](/assets/chapter-2-images/problems/03inchesToCm/03code.png)

**Стартираме програмата,** както обикновено с [**Ctrl+F5**]:

![](/assets/chapter-2-images/problems/03inchesToCm/04result.png)

Изненада! Какво става? Програмата не работи правилно… Всъщност това не е ли предходната програма?
Във Visual Studio **текущият активен проект** в един solution е маркиран в получерно и може да се сменя:

![](/assets/chapter-2-images/problems/03inchesToCm/05surprise.png)

За да включим режим на **автоматично преминаване към текущия проект**, кликаме върху главния solution с десния бутон на мишката и избираме [**Set StartUp Projects…**]:

![](/assets/chapter-2-images/problems/03inchesToCm/06startupPorject_1.png)

Ще се появи диалогов прозорец, от който трябва да се избере [**Startup Project**] -> [**Current Selection**]:

![](/assets/chapter-2-images/problems/03inchesToCm/06startupPorject_2.png)

Сега отново **стартираме програмата**, както обикновено с [**Ctrl+F5**]. Този път ще се стартира **текущата отворена програма**, която преобразува инчове в сантиметри. Изглежда работи коректно:

![](/assets/chapter-2-images/problems/03inchesToCm/07resultCorrect.png)

Сега **да превключим към преходната програма** (лице на квадрат). Това става с двоен клик на мишката върху файла **``Program.cs``** от предходния проект **“Square-Area”** в панела [**Solution Explorer**] на Visual Studio:

![](/assets/chapter-2-images/problems/03inchesToCm/08switchProjects.png)

Натискаме пак [**Ctrl+F5**]. Този път трябва да се стартира другият проект:

![](/assets/chapter-2-images/problems/03inchesToCm/07resultCorrect_4.png)

Превключваме обратно към проекта **“Inches-to-Centimeters”** и го стартираме с [**Ctrl+F5**]:

![](/assets/chapter-2-images/problems/03inchesToCm/07resultCorrect_2.png)

**Превключването между проектите** е много лесно, нали? Просто избираме файла със сорс кода на програмата, кликваме го два пъти с мишката и при стартиране тръгва програмата от този файл.

Да тестваме с дробни числа, например с **2.5**:

![](/assets/chapter-2-images/problems/03inchesToCm/07resultCorrect_3.png)

<table><tr><td><img src="/assets/alert-icon.png" style="max-width:50px" /></td>
<td>В зависимост от регионалните настройки на операционната система, е възможно вместо <strong>десетична точка</strong> (US настройки) да се използва <strong>десетична запетая</strong> (BG настройки).</td>
</tr></table>

Ако програмата очаква десетична точка и бъде въведено число с десетична запетая или на обратно (бъде въведена десетична точка, когато се очаква десетична запетая), ще се получи следната грешка:

![](/assets/chapter-2-images/problems/03inchesToCm/09result_exception.png)

Препоръчително е **да променим настройките на компютъра си**, така че да се използва **десетична точка**:

![](/assets/chapter-2-images/problems/03inchesToCm/10changeWinSettings_1.png)

![](/assets/chapter-2-images/problems/03inchesToCm/10changeWinSettings_2.png)

#### Тестване в Judge системата

Тествайте решението си тук: [https://judge.softuni.bg/Contests/Practice/Index/504#1](https://judge.softuni.bg/Contests/Practice/Index/504#1).

Решението би трябвало да бъде прието като напълно коректно:

![](/assets/chapter-2-images/problems/03inchesToCm/11judgeResult.png)

### Задача: Поздрав по име

Да се напише програма, която **чете от конзолата име на човек** и отпечатва **`Hello, <name>!`**, където **`<name>`** е въведеното преди това име.

Първо създаваме **нов C# конзолен проект** с име “Greeting” в решението **“Simple-Calculations”**:

![](/assets/chapter-2-images/problems/04greetingByName/01newProject.png)

**Следва да напишем кода** на програмата. Ако се затруднявате, може да ползвате примерния код по-долу:

![](/assets/chapter-2-images/problems/04greetingByName/02code.png)

**Стартираме** програмата с [**Ctrl+F5**] и я тестваме дали работи:

![](/assets/chapter-2-images/problems/04greetingByName/03result.png)

#### Тестване в Judge системата

Тествайте решението си тук:  [https://judge.softuni.bg/Contests/Practice/Index/504#2](https://judge.softuni.bg/Contests/Practice/Index/504#2)

### Задача:	Съединяване на текст и числа

Напишете C# програма, която прочита от конзолата име, фамилия, възраст и град и печата съобщение от следния вид: **`You are <firstName> <lastName>, a <age>-years old person from <town>`**.

Добавяме към текущото Visual Studio решение още един конзолен C# проект с име “Concatenate-Data”.	**Пишем кода**, който чете входните данни от конзолата:

![](/assets/chapter-2-images/problems/05concatenateData/01code.png)

**Кодът**, който отпечатва описаното в условието на задачата съобщение, трябва да се допише.

![](/assets/chapter-2-images/problems/05concatenateData/01code_2.png)

На горната картинка кодът е нарочно даден размазан, за да помислите как да си го напишете сами.

Следва да се тества решението локално с [**Ctrl+F5**] и въвеждане на примерни входни данни.

#### Тестване в Judge системата

Тествайте решението си тук: [https://judge.softuni.bg/Contests/Practice/Index/504#3](https://judge.softuni.bg/Contests/Practice/Index/504#3)

### Задача:	Лице на трапец

Напишете програма, която чете от конзолата три числа **b1, b2 и h и пресмята лицето на трапец** с основи **b1 и b2 и височина h. Формулата за лице на трапец е (b1 + b2) * h / 2**.

На фигурата по-долу е показан трапец със страни 8 и 13 и височина 7. Той има лице **(8 + 13) * 7 / 2 = 73.5**.

![](/assets/chapter-2-images/problems/06trapezoidArea/mockUp.png)

Отново трябва да добавим към текущото Visual Studio решение още един **конзолен C# проект** с име ""Trapezoid-Area" и да напишем **кода, който чете входните данни от конзолата, пресмята лицето на трапеца и го отпечатва**:

![](/assets/chapter-2-images/problems/06trapezoidArea/code.png)

Кодът на картинката е нарочно размазан, за да си го доизмислите и допишете сами.

**Тествайте** решението локално с [**Ctrl+F5**] и въвеждане на примерни данни.

#### Тестване в Judge системата

Тествайте решението си тук: [https://judge.softuni.bg/Contests/Practice/Index/504#4](https://judge.softuni.bg/Contests/Practice/Index/504#4)

//TODO:
### 7.	Периметър и лице на кръг

Напишете програма, която чете от конзолата **число r** и пресмята и отпечатва **лицето и периметъра на кръг** / окръжност с радиус r.

| вход  |           изход                                          |    
|:-----:|:--------------------------------------------------------:|
| 3     | Area = 28.2743338823081 <br> Perimeter = 18.8495559215388|
| 4.5   | Area = 63.6172512351933 <br> Perimeter = 28.2743338823081|

За изчисленията можете да използвате следните формули:
-	**``area = Math.PI * r * r``**
-	**``perimeter = 2 * Math.PI * r``**

Тествайте решението си в judge системата: https://judge.softuni.bg/Contests/Practice/Index/504#5.

### 8.	Лице на правоъгълник в равнината

**Правоъгълник** е зададен с **координатите** на два от своите срещуположни ъгъла (x1, y1) – (x2, y2). Да се пресметнат **площта и периметъра** му. **Входът** се чете от конзолата. Числата **x1, y1, x2 и y2** са дадени по едно наред. **Изходът** се извежда на конзолата и трябва да съдържа два реда с по една число на всеки от тях – лицето и периметъра.

<!--- ВЕРТИКАЛНА ТАБЛИЦА, ПО-ДОЛУ Е ХОРИЗОНТАЛНАТА, ЧЕТЕ СЕ ПО-ТРУДНО
|вход                                       |    изход            |
|:-----------------------------------------:|:-------------------:|
|60     <br> 20     <br>     10 <br>     50 |1500        <br> 160 |
|30     <br> 40     <br>     70 <br>    -10 |2000        <br> 180 |
|600.25 <br> 500.75 <br> 100.50 <br> -200.5 |350449.6875 <br> 2402|
-->

<p align="center">
<img alt="rectangleMockUp" src ="/assets/chapter-2-images/problems/08rectangleAreaAndP/rectangleMockUp.png" />
</p>

Тествайте решението си в judge системата: https://judge.softuni.bg/Contests/Practice/Index/504#6.

|               вход                        |       изход         |
|:-----------------------------------------:|:-------------------:|
|60 <br> 20 <br> 10 <br> 50                 |1500 <br> 160        |
|30 <br> 40 <br> 70 <br> -10                |2000 <br> 180        |
|600.25 <br> 500.75 <br> 100.50 <br> -200.5 |350449.6875 <br> 2402|

### 9.	Лице на триъгълник

Напишете програма, която чете от конзолата **страна и височина на триъгълник** и пресмята неговото лице. Използвайте **формулата** за лице на триъгълник: **area = a * h / 2**. Закръглете резултата до **2 знака след десетичната точка използвайки Math.Round(area, 2)**.

|       вход           |         изход         |
|:--------------------:|:---------------------:|
| 20 <br> 30           | Triangle area = 300   |
| 15 <br> 35           | Triangle area = 262.5 |
| 7.75 <br> 8.45       | Triangle area = 32.74 |
| 1.23456 <br> 4.56789 | Triangle area = 2.82  |

Тествайте решението си в **judge системата**: https://judge.softuni.bg/Contests/Practice/Index/504#7.

### 10.	Конзолен конвертор: от градуси °C към градуси °F

Напишете програма, която чете **градуси по скалата на Целзий** (°C) и ги преобразува до **градуси по скалата на Фаренхайт** (°F). Потърсете в Интернет подходяща [формула](http://bfy.tw/3rGh "Търсене в Google"), с която да извършите изчисленията. Закръглете резултата до **2 знака след десетичната точка**. Ето няколко примера:

| вход | изход |
|:----:|:-----:|
|  25  |   77  |
|   0  |   32  |
| -5.5 |  22.1 |
| 32.3 | 90.14 |

Тествайте решението си в **judge системата**: https://judge.softuni.bg/Contests/Practice/Index/504#8.

### 11.	Конзолен конвертор: от радиани в градуси

Напишете програма, която чете **ъгъл в [радиани](https://bg.wikipedia.org/wiki/Радиан)** (rad) и го преобразува в **[градуси](https://bg.wikipedia.org/wiki/Градус_(ъгъл))** (deg). Потърсете в Интернет подходяща формула. Числото **π** в C# програми е достъпно чрез **``Math.PI``**. Закръглете резултата до най-близкото цяло число използвайки **``Math.Round()``**. Ето няколко примера:

|  вход  | изход |
|:------:|:-----:|
| 3.1416 |  180  |       
| 6.2832 |  360  | 
| 0.7854 |   45  | 
| 0.5236 |   30  |

Тествайте решението си в **judge системата**: https://judge.softuni.bg/Contests/Practice/Index/504#9.

### 12.	Конзолен конвертор: USD към BGN

Напишете програма за **конвертиране на щатски долари** (USD) **в български лева** (BGN). **Закръглете** резултата до **2 цифри** след десетичната запетая. Използвайте фиксиран курс между долар и лев: **1 USD = 1.79549 BGN**.

|  вход  |    изход  |
|:------:|:---------:|
|   20   | 35.91 BGN |      
|   100  | 179.55 BGN|
|  12.5  | 22.44 BGN |

Тествайте решението си в **judge системата**: https://judge.softuni.bg/Contests/Practice/Index/504#10.

### 13.	* Конзолен междувалутен конвертор

Напишете програма за **конвертиране на парична сума от една валута в друга**. Трябва да се поддържат следните валути: **BGN, USD, EUR, GBP**. Използвайте следните фиксирани валутни курсове:

|  Курс  |   USD   |   EUR   |   GBP   |
|:------:|:-------:|:-------:|:-------:|
| 1 BGN  | 1.79549 | 1.95583 | 2.53405 |

**Входът** e **сума за конвертиране** + **входна валута** + **изходна валута**. **Изходът** е едно число – преобразуваната сума по посочените по-горе курсове, закръглен до **2 цифри** след десетичната точка. Примери:

|         вход       |   изход  |
|:------------------:|:--------:|
|   20<br>USD<br>BGN |35.91 BGN |     
|  100<br>BGN<br>EUR |51.13 EUR | 
| 12.35<br>EUR<br>GBP| 9.53 GBP |  
|150.35<br>USD<br>EUR|138.02 EUR|
 
Тествайте решението си в **judge системата**: https://judge.softuni.bg/Contests/Practice/Index/504#11.

### 14.	** Пресмятане с дати: 1000 дни на Земята

Напишете програма, която въвежда **рождена дата** във формат "**dd-MM-yyyy**" и пресмята датата, на която се навършват **1000 дни** от тази рождена дата и я отпечатва в същия формат.

|   вход   |	 изход  |
|:--------:|:--------:|
|25-02-1995|20-11-1997|
|07-11-2003|02-08-2006|
|30-12-2002|24-09-2005|
|01-01-2012|26-09-2014|
|14-06-1980|10-03-1983|

**Подсказки**: потърсете информация за типа **``DateTime``** в C# и по-конкретно разгледайте методите **``ParseExact(str, format)``**, **``AddDays(count)``** и **``ToString(format)``**. С тяхна помощ може да решите задачата, без да е необходимо да изчислявате дни, месеци и високосни години.
Тествайте решението си в **judge системата**: https://judge.softuni.bg/Contests/Practice/Index/504#12. Не печатайте нищо допълнително на конзолата освен изискваната дата!

## Упражнения: графични и уeb приложения

### Графично приложение: конвертор от BGN към EUR

Създайте **графично приложение** (GUI application), което пресмята стойността в **евро** (EUR) на парична сума, зададена в **лева** (BGN). При промяна на стойността в лева, равностойността в евро трябва да се преизчислява автоматично. Използвайте курс лева / евро: **1.95583**.

<p align="center">
<img alt="model" src ="/assets/chapter-2-images/problems/GUIcurrencyConverter/00model.png" />
</p>

1.	Добавете към текущото Visual Studio решение още един проект. Този път създайте **Windows Forms** приложение със C# с име "**``BGN-to-EUR-Converter``**":

<p align="center">
<img alt="model" src ="/assets/chapter-2-images/problems/GUIcurrencyConverter/01winFormsInstr.png" />
</p>

2.	Подредете следните UI контролите във формата:
• **``NumericUpDown``** с име **``numericUpDownAmount``** – ще въвежда сумата за конвертиране
•	**``Label``** с име **``labelResult``** – ще показва резултата след конвертиране
•	Още два Label компонента, служещи единствено за статично изобразяване на текст
Графичният редактор за потребителски интерфейс може да изглежда по подобен начин:

<p align="center">
<img alt="model" src ="/assets/chapter-2-images/problems/GUIcurrencyConverter/02winFormsInstrLabels.png" />
</p>

3.	Задайте настройки на фòрмата и на отделните контроли:



|                                             Настройка                                                 | скрийн|
|:------------------------------------------------------------------------------------------------------|:-----:|
|**``FormConverter``**:<br>Text = "BGN to EUR",<br>Font.Size = 12,<br>MaximizeBox = False,<br>MinimizeBox = False,<br>FormBorderStyle = FixedSingle | <img alt="formConverter" src ="/assets/chapter-2-images/problems/GUIcurrencyConverter/03formConverter.png" /> |
|**``numericUpDownAmount``**:<br>Value = 1,<br>Minimum = 0,<br>Maximum = 10000000,<br>TextAlign = Right,<br>DecimalPlaces = 2 | <img alt="numUpDown" src ="/assets/chapter-2-images/problems/GUIcurrencyConverter/05numericUpDownAmount.png" /> |
|**``labelResult``**:<br>AutoSize = False,<br>BackColor = PaleGreen,<br>TextAlign = MiddleCenter,<br>Font.Size = 14,<br>Font.Bold = True| <img alt="labelResult" src ="/assets/chapter-2-images/problems/GUIcurrencyConverter/06labelResult.png" /> |

4.	Дефинирайте **обработчици на събития** по контролите:

<p align="center">
<img alt="model" src ="/assets/chapter-2-images/problems/GUIcurrencyConverter/07events.png" />
</p>

Хванете следните събития:
- **``FormConverter.Load``** (кликнете върху формата с мишката 2 пъти)
- **``numericUpDownAmount.ValueChanged``** (кликнете върху **``NumericUpDown``** контролата 2 пъти)
- **``numericUpDownAmount.KeyUp``** (изберете **``Events``** от таблото **``Properties``** и кликнете 2 пъти върху **``KeyUp``**)
Събитието **``Form.Load``** се изпълнява при стартиране на програмата, преди да се появи прозореца на приложението. Събитието **``NumericUpDown.ValueChanged``** се изпълнява при промяна на стойността в полето за въвеждане на число. Събитието **``NumericUpDown.KeyUp``** се изпълнява след натискане на клавиш в полето за въвеждане на число. При всяко от тези събития ще преизчисляваме резултата.

За **хващане на събитие** ползвайте иконката със събитията в **Properties**  прозореца във Visual Studio:

<p align="center">
<img alt="model" src ="/assets/chapter-2-images/problems/GUIcurrencyConverter/08properties.png" />
</p>

Сложете следния **C# код** за обработка на събитията:
```cs
private void FormConverter_Load(object sender, EventArgs e)
{
  ConvertCurrency();
}

private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
{
  ConvertCurrency();
}

private void numericUpDownAmount_KeyUp(object sender, KeyEventArgs e)
{
  ConvertCurrency();
}
```

Всички прихванати събития извикват метода **``ConvertCurrency()``**, който конвертира зададената сума от лева в евро и показва резултата в зелената кутийка.

5.	**Напишете кода** (програмната логика) за конвертиране от лева към евро: 

```cs
private void ConvertCurrency()
{
  var amountBGN = this.numericUpDownAmount.Value;
  var amountEUR = amountBGN * 1.95583m;
  this.labelResult.Text = 
    amountBGN + " BGN = " + 
    Math.Round(amountEUR, 2) + " EUR";
}
```

6.	**Стартирайте проектa** с [Ctrl+F5] и тествайте дали работи правилно.

### *** Графично приложение: хвани бутона!

Създайте забавно графично приложение **„хвани бутона“**: една форма съдържа един бутон. При преместване на курсора на мишката върху бутона той се премества на случайна позиция. Така се създава усещане, че **„бутонът бяга от мишката и е трудно да се хване“**. При „хващане“ на бутона се извежда съобщение-поздрав.

<p align="center">
<img alt="model" src ="/assets/chapter-2-images/problems/catchTheButton/model.png" />
</p>

* Подсказка: напишете обработчик за събитието **``Button.MouseEnter``** и премествайте бутона на случайна позиция. Използвайте генератор за случайни числа **``Random``**. Позицията на бутона се задава от свойството **``Location``**. За да бъде новата позиция на бутона в рамките на формата, можете да направите изчисления спрямо размера на формата, достъпен от свойството **``ClientSize``**. Можете да ползвате следния код за ориентир:

```cs
private void buttonCatchMe_MouseEnter(object sender, EventArgs e)
{
    Random rand = new Random();
    var maxWidth = this.ClientSize.Width - buttonCatchMe.ClientSize.Width;
    var maxHeight = this.ClientSize.Height - buttonCatchMe.ClientSize.Height;
    this.buttonCatchMe.Location = new Point(
        rand.Next(maxWidth), rand.Next(maxHeight));
}
```


