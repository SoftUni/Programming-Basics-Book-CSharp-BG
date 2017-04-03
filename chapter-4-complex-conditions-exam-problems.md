# Глава 4. По-сложни проверки - изпитни задачи

## 1.Навреме за изпит

_Трета задача от междинния изпит на 6 март 2016. Тествайте решението си на URL адрес: [**https://judge.softuni.bg/Contests/Practice/Index/169#2**](https://judge.softuni.bg/Contests/Practice/Index/169#2)._

Студент трябва да отиде **на изпит в определен час** (например в 9:30 часа). Той идва в изпитната зала в даден **час на пристигане** (например 9:40). Счита се, че студентът е дошъл **навреме**, ако е пристигнал в часа на изпита или до половин час преди това. Ако е пристигнал по-рано повече от 30 минути, той е **подранил**. Ако е дошъл след часа на изпита, той е **закъснял**. 

Напишете програма, която въвежда време на изпит и време на пристигане и отпечатва дали студентът е дошъл **навреме**, дали е **подранил** или е **закъснял** както и **с колко часа или минути** е подранил или закъснял.

### Входни данни

От конзолата се четат **4 цели числа** (по едно на ред):

- Първият ред съдържа **час на изпита** – цяло число от 0 до 23.
- Вторият ред съдържа **минута на изпита** – цяло число от 0 до 59.
- Третият ред съдържа **час на пристигане** – цяло число от 0 до 23.
- Четвъртият ред съдържа **минута на пристигане** – цяло число от 0 до 59.

### Изходни данни

На първият ред отпечатайте:

- &quot;**Late**&quot;, ако студентът пристига по-късно от часа на изпита.
- &quot;**On time**&quot;, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
- &quot;**Early**&quot;, ако студентът пристига повече от 30 минути преди часа на изпита.

Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:

- &quot;**mm minutes before the start**&quot; за идване по-рано с по-малко от час.
- &quot;**hh:mm hours before the start**&quot; за подраняване с 1 час или повече. Минутите винаги печатайте с 2 цифри, например &quot;1:05&quot;.
- &quot;**mm minutes after the start**&quot; за закъснение под час.
- &quot;**hh:mm hours after the start**&quot; за закъснение от 1 час или повече. Минутите винаги печатайте с 2 цифри, например &quot;1:03&quot;.

### Примерен вход и изход

<div style="display:inline-block;margin-right:2%;width:31.5%;">
<table>
<thead>
<tr style="background-color:#d9d9d9;">
<th style="border:1px solid black;background-color:#d9d9d9;">Вход</th>
<th style="border:1px solid black;background-color:#d9d9d9;">Изход</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">9<br />30<br />9<br />50</td>
<td style="border:1px solid black;">Late<br />20 minutes after the start</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="background:none;background-color:#ffffff;border:1px solid black;">9<br />00<br />8<br />30</td>
<td style="background:none;background-color:#ffffff;border:1px solid black;">On time<br />30 minutes before the start</td>
</tr>
<tr>
<td style="border:1px solid black;">16<br />00<br />15<br />00</td>
<td style="border:1px solid black;">Early<br />1:00 hours before the start</td>
</tr>
</tbody>
</table>
</div>
<div style="display:inline-block;margin-right:2%;width:31.5%;">
<table>
<thead>
<tr style="background-color:#d9d9d9;">
<th style="border:1px solid black;background-color:#d9d9d9;">Вход</th>
<th style="border:1px solid black;background-color:#d9d9d9;">Изход</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">9<br />00<br />10<br />30</td>
<td style="border:1px solid black;">Late<br />1:30 hours after the start</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="border:1px solid black;background:none;background-color:#ffffff;">14<br />00<br />13<br />55</td>
<td style="border:1px solid black;background:none;background-color:#ffffff;">On time<br />5 minutes before the start</td>
</tr>
<tr>
<td style="border:1px solid black;">11<br />30<br />8<br />12</td>
<td style="border:1px solid black;">Early<br />3:18 hours before the start</td>
</tr>
</tbody>
</table>
</div>
<div style="display:inline-block;width:31.5%">
<table>
<thead>
<tr style="background-color:#d9d9d9;">
<th style="border:1px solid black;background-color:#d9d9d9;">Вход</th>
<th style="border:1px solid black;background-color:#d9d9d9;">Изход</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">10<br />00<br />10<br />00</td>
<td style="border:1px solid black;">On time<br /><br /><br /></td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="border:1px solid black;background:none;background-color:#ffffff;">11<br />30<br />10<br />55</td>
<td style="border:1px solid black;background:none;background-color:#ffffff;">Early<br />35 minutes before the start<br /><br /></td>
</tr>
<tr>
<td style="border:1px solid black;">11<br />30<br />12<br />23</td>
<td style="border:1px solid black;">Late<br />59 minutes after the start<br /><br /></td>
</tr>
</tbody>
</table>
</div>

### Насоки и подсказки

<table><tr><td><img src="/assets/alert-icon.png" style="max-width:50px" /></td>
<td>Препоръчително е да се прочита няколко пъти заданието на дадена задача, като се водят записки, преди да се подходи към писането на код.</td>
</tr></table>

#### 1. Обработка на входните данни

Съгласно заданието очакваме да ни бъдат подадени в 4 поредни реда различни цели числа. Разглеждаме зададените параметри. Можем да се спрем на <strong>int</strong> като тип на параметрите ни, който удовлетворява очакваните стойности. Едновременно четем входа и парсваме стринговата стойност към цяло число.

```cs
int examHours = int.Parse(Console.ReadLine());
int examMinutes = int.Parse(Console.ReadLine());
int arrivalHours = int.Parse(Console.ReadLine());
int arrivalMinutes = int.Parse(Console.ReadLine());
```

Разглеждаме очакваният изход. Можем да създадем променливи, които да съдържат различните видове изходни данни, с цел да избегнем използването на т.нар. "magic strings" в кода.

```cs 
string late = "Late";
string onTime = "On time";
string early = "Early";
```

#### 2. Изчисления

След това започваме да разписваме логиката за изчисление на резултата. Трябва да изчислим времето на изпита в минути за по-лесно и точно сравнение.

```cs
int examTime = (examHours * 60) + examMinutes;
```

Нека изчислим по същата логика и времето на пристигане на студента.
```cs 
int arrivalTime = (arrivalHours * 60) + arrivalMinutes;
```

Остава ни да пресметнем каква е разликата в двете времена, за да можем да определим кога и с какво време спрямо изпита е пристигнал студента.

```cs 
int totalMinutesDifference = arrivalTime - examTime;
```

След което ни остава да направим необходимите проверки и да изведем резултата от изчисленията ни. Нека разделим изхода на 2 части. Първо да покажем как е пристигнал студентът - дали е подранил, закъснял или е навреме. За целта ще се спрем на <strong>if - else if</strong> конструкция. С цел да си спестим една допълнителна проверка (<strong>else</strong>) можем по подразбиране да приемем, че студентът е закъснял. След което съгласно условието проверяваме ако разликата във времената е повече от 30 минути приемаме, че е подранил. Ако не влезнем в първото условие, то следва да проверим само дали разликата е по-малка или равна на 0, с което проверяваме условието, студента да е дошъл в рамките на от 0 до 30 мин. преди изпита. При всички останали случаи приемаме, че студентът е закъснял, което сме направили по подразбиране, и не е нужна допълнителна проверка.

```cs
string studentArrival = late;
if (totalMinutesDifference < -30)
{
    studentArrival = early;
}
else if (totalMinutesDifference <= 0)
{
    studentArrival = onTime;
}
```

За финал ни остава да разберем и покажем и с каква разлика от времето на изпита е пристигнал, както и дали тази разлика е преди или след изпита. Правим проверка дали разликата ни е над 1 час, за да изпишем съответно часове и минути в желаният по задание формат, или е под 1 час за да покажем само минути като формат и описание. 

След което ни остава последна проверка дали времето на пристигане на студента е преди или след началото на изпита.

```cs
string result = string.Empty;
if (totalMinutesDifference != 0)
{
    int hoursDifference = Math.Abs(totalMinutesDifference / 60);
    int minutesDifference = Math.Abs(totalMinutesDifference % 60);

    if (hoursDifference > 0)
    {
        result = string.Format("{0}:{1:00} hours", hoursDifference, minutesDifference);
    }
    else
    {
        result = minutesDifference + " minutes";
    }

    if (totalMinutesDifference < 0)
    {
        result += " before the start";
    }
    else
    {
        result += " after the start";
    }
}
```

#### 3. Показване на резултата

И накрая остава да изведем резултата на конзолата. Тъй като по задание ако студентът е дошъл точно на време (без 1 минута разлика) не трябва да изваждаме втори резултат, правим проверка дали да изваждаме вторият резултат.
```cs 
Console.WriteLine(studentArrival);
if (!string.IsNullOrEmpty(result))
{
    Console.WriteLine(result);
}
```

### Тестване в Judge системата

Може да тествате вашето решение на URL адрес: [**https://judge.softuni.bg/Contests/Practice/Index/169#2**](https://judge.softuni.bg/Contests/Practice/Index/169#2).

## 2.Пътешествие

_Трета задача от междинния изпит на 26 март 2016. Тествайте решението на адрес: [**https://judge.softuni.bg/Contests/Practice/Index/179#2**](https://judge.softuni.bg/Contests/Practice/Index/179#2)._

Странно, но повечето хора си плануват от рано почивката. Млад програмист разполага с **определен бюджет** и свободно време в даден **сезон**.

Напишете програма, която да приема **на входа бюджета и сезона**, а **на изхода** да изкарва, **къде ще почива** програмиста и **колко ще похарчи**.

**Бюджета определя дестинацията, а сезона определя колко от бюджета ще изхарчи**. Ако е **лято** ще почива на **къмпинг**, а **зимата в хотел**. Ако е в **Европа**, **независимо от сезона** ще почива в **хотел**. Всеки **къмпинг** или **хотел**, ** според дестинацията**, има **собствена цена**, която отговаря на даден **процент от бюджета**:

- При **100лв. или по-малко** – някъде в **България**
  - **Лято** – **30%** от бюджета
  - **Зима** – **70%** от бюджета
- При **1000лв. или по малко** – някъде на **Балканите**
  - **Лято** – **40%** от бюджета
  - **Зима** – **80%** от бюджета
- При **повече от 1000лв**. – някъде из **Европа**
  - При пътуване из Европа, независимо от сезона ще похарчи **90% от бюджета**.

### Входни данни

Входът се чете от конзолата и се състои от **два реда** :

- **Първи ред** – Бюджет, **реално число** в интервала **[10.00...5000.00]**.
- **Втори ред** – Един от двата възможни сезона: **&quot;summer&quot; **или** &quot;winter&quot;**

### Изходни данни

На конзолата трябва да се отпечатат **два реда**.

- **Първи ред** – „**Somewhere in [дестинация]**&quot; измежду &quot;**Bulgaria**&quot;, &quot;**Balkans**&quot; и &quot;**Europe**&quot;
- **Втори ред** – &quot;{**Вид почивка**} – {**Похарчена сума**}&quot;
  - **Почивката** може да е между &quot;**Camp**&quot; и &quot;**Hotel**&quot;
  - **Сумата** трябва да е **закръглена с точност до вторият знак след запетаята**.

### Примерен вход и изход

<div style="display:inline-block">
<table>
<thead>
<tr style="background-color:#d9d9d9;">
<th style="border:1px solid black;background-color:#d9d9d9;">Вход</th>
<th style="border:1px solid black;background-color:#d9d9d9;">Изход</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">50<br />summer</td>
<td style="border:1px solid black;">Somewhere in Bulgaria<br />Camp - 15.00</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="border:1px solid black;background:none;background-color:#ffffff;">75<br />winter</td>
<td style="border:1px solid black;background:none;background-color:#ffffff;">Somewhere in Bulgaria<br />Hotel - 52.50</td>
</tr>
<tr>
<td style="border:1px solid black;">312<br />summer</td>
<td style="border:1px solid black;">Somewhere in Balkans<br />Camp - 124.80</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="border:1px solid black;background:none;background-color:#ffffff;">678.53<br />winter</td>
<td style="border:1px solid black;background:none;background-color:#ffffff;">Somewhere in Balkans<br />Hotel - 542.82</td>
</tr>
<tr>
<td style="border:1px solid black;">1500<br />summer</td>
<td style="border:1px solid black;">Somewhere in Europe<br />Hotel - 1350.00</td>
</tr>
</tbody>
</table>
</div>

### Насоки и подсказки

#### 1. Обработка на входнните данни

Прочитайки внимателно условието разбираме, че очакваме 2 реда с входни данни. Първият параметър е реално число, за което е хубаво да изберем подходящ тип на променливата. За по-голяма точност на изчисленията нека се спрем на <strong>decimal</strong> като тип за бюджета, а за сезона си е обикновен <strong>string</strong>. 

<table><tr><td><img src="/assets/alert-icon.png" style="max-width:50px" /></td>
<td>Винаги преценявайте какъв тип стойност ви се подава при входнни данни, както и към какъв тип трябва да бъдат парснати тези данни, за да работят правилно създадените от вас програмнни конструкции!</td>
</tr></table>

```cs 
decimal budget = decimal.P...................;
string season = ..................;
```

#### 2. Изчисления

Нека си създадем и инициализираме нужните ни за логиката и изчисленията променливи.

```cs
string destinationResult = string.Empty;
string holidayInformation = .........;
decimal moneySpent = 0.00M;
```

Можем и подобно на примера в предната задача да си инициализираме променливите с някои от изходните резултати с цел да спестим допълнително инициализиране в конкретният случай. 

Разглеждаме отново условието на задачата. Нека се спрем на един от възможните начини и подходи за изчисленията и логическата схема. Основното ни разпределение за това къде ще почиваме се определя от стойността на подаденият бюджет, т.е. основната ни логика е: ако бюджета е по-малък от дадена стойност, или ако е по-малък от друга стойност, или е повече от дадени гранични стойност. Спрямо това как си подредим логическата схема (в какъв ред ще обхождаме граничните стойности) ще имаме повече или по-малко проверки в условията. Помислете защо!

След това за всяка от подсхемите се прави проверка спрямо стойността на подаденият сезон, за да се определи какъв процент от бюджета ще бъде похарчен, както и къде ще почиваме - в хотел или на къмпинг.

Например един от възможните подходи и схеми за решение е:
```cs 
if (budget <= 100.00M)
{
    destinationResult = "Bulgaria";
    if (season.Equals("summer"))
    {
        moneySpent = 0.30M * budget;
        holidayInformation = string.Format("Camp - {0:F2}", moneySpent);
    }
    else
    {
        moneySpent = ...............;
        holidayInformation = string.Format("Hotel - {0:F2}", moneySpent);
    }
}
else if (budget <= 1000.00M)
{
    destinationResult = .........;
    if (season.Equals("......"))
    {
        moneySpent = .................;
        holidayInformation = ..........................;
    }
    else
    {
        moneySpent = ................;
        holidayInformation = ...........................;
    }
}
else
{
    destinationResult = ........;
    moneySpent = ........;
    holidayInformation = ..........;
}

```

Винаги можем да инициализираме дадена стойност на параметъра и след това да направим само една проверка дали има нужда да бъде сменена. Спестява ни една логическа стъпка.

Например схемата:

```cs
destinationResult = "Bulgaria";
if (season.Equals("summer"))
{
moneySpent = 0.30M * budget;
holidayInformation = string.Format("Camp - {0:F2}", moneySpent);
}
else
{
moneySpent = ...............;
holidayInformation = string.Format("Hotel - {0:F2}", moneySpent);
}
```

може да бъде изчислена и по следният начин:


```cs
destinationResult = "Bulgaria";
moneySpent = 0.70M * budget;
holidayInformation = string.Format("Hotel - {0:F2}", moneySpent);

if (season.Equals("summer"))
{
moneySpent = 0.30M * budget;
holidayInformation = string.Format("Camp - {0:F2}", moneySpent);
}
```

#### 3. Показване на резултата

Остава да покажем изчисленият резултат на конзолата:

```cs
Console.WriteLine("Somewhere in {0}", destinationResult);
Console.WriteLine(holidayInformation);
```

### Тестване в Judge системата

Може да тествате вашето решение на URL адрес: [**https://judge.softuni.bg/Contests/Practice/Index/179#2**](https://judge.softuni.bg/Contests/Practice/Index/179#2). 

## 3.Операции между числа

_Трета задача от междинния изпит на 26 март 2016. Тествайте решението си на URL адрес: [**https://judge.softuni.bg/Contests/Practice/Index/181#2**](https://judge.softuni.bg/Contests/Practice/Index/181#2)._

Напишете програма, която чете **две цели числа (N1 и N2)** и **оператор** с който да се **извърши** дадена **математическа операция** с тях. Възможните операции са: **Събиране (+)**, **Изваждане (-)**, **Умножение (\*)**, **Деление (/)** и **Модулно деление (%)**. При **събиране**, **изваждане** и **умножение** на конзолата **трябва да се отпечатат резултата** и дали той е **четен** или **нечетен**. При **обикновеното деление** – **резултата**. При **модулното деление** – **остатъка**. Трябва да се има предвид, че **делителят може да е равен на 0 (нула)**, а **на нула не се дели**. В този случай трябва да се отпечата **специално съобщениe**.

### Входни данни

От конзолата се прочитат **3 реда**:

- **N1** – **цяло число** в интервала **[0...40 000]**
- **N2** – **цяло число** в интервала **[0...40 000]**
- **Оператор** – **един символ** измеду: &quot;**+**&quot;, &quot;**-**&quot;, &quot;**\***&quot;, &quot;**/**&quot;, &quot;**%**&quot;

### Изходни данни

Да се отпечата на конзолата **един ред**:

- Ако операцията е **събиране**, **изваждене** или **умножение**:
  - **&quot;{N1} {оператор} {N2} = {резултат} – {even/odd}&quot;**
- Ако операцията е **деление**:
  - **&quot;{N1} / {N2} = {резултат}&quot;** – резултатът е **форматиран **до** вторият знак след десетичната запетая**
- Ако операцията е **модулно деление**:
  - **&quot;{N1} % {N2} = {остатък}&quot;**
- В случай на **деление с 0(нула)**:
  - **&quot;Cannot divide {N1} by zero&quot;**


### Примерен вход и изход

<div>
<table style="display:inline-block;vertical-align:top;margin-right:2%;width:31.5%">
<thead>
<tr style="background-color:#d9d9d9;">
<th style="border:1px solid black;background-color:#d9d9d9;">Вход</th>
<th style="border:1px solid black;background-color:#d9d9d9;">Изход</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">10<br />12<br />+</td>
<td style="border:1px solid black;">10 + 12 = 22 - even</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="border:1px solid black;background:none;background-color:#ffffff;">10<br />1<br />-</td>
<td style="border:1px solid black;background:none;background-color:#ffffff;">10 - 1 = 9 - odd</td>
</tr>
<tr>
<td style="border:1px solid black;">7<br />3<br />*</td>
<td style="border:1px solid black;">7 * 3 = 21 - odd</td>
</tr>
</tbody>
</table>

<table style="display:inline-block;vertical-align:top;margin-right:2%;width:31.5%">
<thead>
<tr style="background-color:#d9d9d9;">
<th style="border:1px solid black;background-color:#d9d9d9;">Вход</th>
<th style="border:1px solid black;background-color:#d9d9d9;">Изход</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">123<br />12<br />/</td>
<td style="border:1px solid black;">123 / 12 = 10.25</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="border:1px solid black;background:none;background-color:#ffffff;">10<br />3<br />%</td>
<td style="border:1px solid black;background:none;background-color:#ffffff;">10 % 3 = 1</td>
</tr>
</tbody>
</table>

<table style="display:inline-block;vertical-align:top;width:31.5%">
<thead>
<tr style="background-color:#d9d9d9;">
<th style="border:1px solid black;background-color:#d9d9d9;">Вход</th>
<th style="border:1px solid black;background-color:#d9d9d9;">Изход</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">112<br />0<br />/</td>
<td style="border:1px solid black;">Cannot divide 122 by zero</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="border:1px solid black;background:none;background-color:#ffffff;">10<br />0<br />%</td>
<td style="border:1px solid black;background:none;background-color:#ffffff;">Cannot divide 10 by zero</td>
</tr>
</tbody>
</table>
</div>

### Насоки и подсказки

#### 1. Обработка на входнните данни

След прочитане на условието разбираме, че очакваме 3 реда с входни данни. Първите 2 реда са с цели числа в указаният от заданието диапазон, а на третият очакваме даден аритметичен символ. 

```cs
decimal N1 = .................................;
decimal N2 = .................................;
string nOperator = ..................;
```

#### 2. Изчисления

Нека си създадем и инициализираме нужните ни за логиката и изчисленията променливи. В единият ще пазим резултатът от изчисленията, а другият ще използваме за крайният изход на програмата ни.

```cs
decimal result = ......;
string output = .......;
```

Прочитаме внимателно условието и ни прави впечатление за случаите, в които не трябва да правим никакви изчисления, а просто да изведем резултат. Следователно за първа проверка може да направим е дали второто число е 0 (нула), както и дали операцията е деление или модулно деление, след което да инициализираме резултата:

```cs 
if (N2 == 0 && (nOperator.Equals("/") || nOperator.Equals("%")))
{
    output = string.Format("Cannot divide {0} by zero", N1);
}
```

Друга опция ни е изкараният резултат да го сложим като стойност при инициализацията на <strong>output</strong> параметъра и да правим само една проверка дали трябва да го заменим и преизчислим този резултат. Спрямо това кой подход изберем следващата ни проверка ще бъде или обикновен <strong>else</strong> или единичен <strong>if</strong>. 

В тялото на тази проверка може да разделим логиката спрямо структурата на очакваният резултат с допълнителни проверки за начина на изчисление на резултата спрямо подаденият оператор. Преглеждайки отново условието можем да видим, че за <strong>събиране (+)</strong>, <strong>изваждене (-)</strong> или <strong>умножение (*)</strong> очакваният резултат има обща структура: <strong>"{N1} {оператор} {N2} = {резултат} – {even/odd}"</strong>, докато за <strong>деление (/)</strong> и за <strong>модулно деление (%)</strong> резултатът има отделна специфична структура.

```cs 
else
{
    if (nOperator.Equals("+"))
    {
        result = N1 + N2;
    }
    else if (nOperator.Equals("-"))
    {
        result = ..........;
    }
    else if (nOperator.Equals(...))
    {
        result = ... * ...;
    }

    output = string.Format(
        "{0} {1} {2} = {3} - {4}",
        N1,
        nOperator,
        N2,
        result,
        result % 2 == 0 ? "even" : "odd");

    if (nOperator.Equals("/"))
    {
        result = ............;
        output = string.Format("{0} {1} {2} = {3:F2}", ........................);
    }
    else if (nOperator.Equals(.....))
    {
        result = ... % ...;
        output = string.Format("{0} {1} {2} = {3}", ........................);
    }
}
```

При кратки и ясни проверки е възможно да се използва тернарни оператори. Например при проверката за четно и нечетно число в горният пример. Нека разгледаме възможната проверка с и без тернарен оператор.

Без използване на тернарен оператор:

```cs
string numberIs = string.Empty;

if (result % 2 == 0)
{
numberIs = "even";
}
else
{
numberIs = "odd";
}
```

С изполване на тернарен оператор:

```cs
string numberIs = result % 2 == 0 ? "even" : "odd";
```

#### 3. Показване на резултата

Накрая ни остава да покажем изчисленият резултат на конзолата:

```cs 
Console.WriteLine(output);
```

### Тестване в Judge системата

Може да тествате вашето решение на URL адрес: [**https://judge.softuni.bg/Contests/Practice/Index/181#2**](https://judge.softuni.bg/Contests/Practice/Index/181#2).

## 4.Билети за мач

_Трета задача от междинния изпит на 17 юли 2016. Тествайте решението си на URL адрес: [**https://judge.softuni.bg/Contests/Practice/Index/233#2**](https://judge.softuni.bg/Contests/Practice/Index/233#2)._

Когато пуснали **билетите за Евро 2016**, **група запалянковци** решили да си закупят. **Билетите имат две категории с различни цени**:

- **VIP** – **499.99** лева.
- **Normal** – **249.99** лева.

Запалянковците **имат определен бюджет**, a **броят на хората** в групата **определя какъв процент от бюджета** трябва **да се задели за транспорт**:

- **От 1 до 4** – **75% от бюджета**.
- **От 5** до **9** – **60% от бюджета**.
- **От 10 до 24** – **50% от бюджета**.
- **От 25 до 49** – **40% от бюджета**.
- **50 или повече** – **25% от бюджета**.

**Напишете програма**, която да **пресмята дали с останалите пари от бюджета** могат да си **купят билети за избраната категория**. И **колко пари** ще им **останат или ще са им нужни**.

### Входни данни

Входът се чете от **конзолата** и съдържа **точно 3 реда**:

- На **първия** ред е **бюджетът** – **реално число в интервала [1 000.00 ... 1 000 000.00]**
- На **втория** ред е **категорията** – &quot;**VIP**&quot; или &quot;**Normal**&quot;
- На **третия** ред е **броят на хората в групата** – **цяло число в интервала [1 ... 200]**

### Изходни данни

Да се **отпечата** на конзолата **един ред**:

- Ако **бюджетът е достатъчен**:
  - &quot;**Yes! You have {N} leva left.**&quot; – където **N са останалите пари** на групата.
- Ако **бюджетът НЕ Е достатъчен**:
  - &quot;**Not enough money! You need {М} leva.**&quot; – където **М е сумата, която не достига**.

**Сумите** трябва да са **форматирани с точност до два знака след десетичната запетая**.

### Примерен вход и изход

<div>
<table style="display:inline-block;vertical-align:top;margin-right:2%;width:47.4%">
<thead>
<tr style="background-color:#d9d9d9;">
<th style="border:1px solid black;background-color:#d9d9d9;">Вход</th>
<th style="border:1px solid black;background-color:#d9d9d9;">Изход</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">1000<br />Normal<br />1</td>
<td style="border:1px solid black;">Yes! You have 0.01 leva left.</td>
</tr>
<tr>
<td colspan="2" style="border:1px solid black;background-color:#d9d9d9;"><strong>Обяснения</strong></td>
</tr>
<tr>
<td colspan="2" style="border:1px solid black;"><strong>1 човек : 75% от бюджета</strong> отиват <strong>за транспорт</strong>. <strong>Остават</strong>: 1000 – 750 = <strong>250</strong>.<br /> Категория <strong>Normal</strong>: билетът <strong>струва 249.99 * 1 = 249.99</strong><br />249.99 &lt; 250: остават му 250 – 249.99 = <strong>0.01</strong></td>
</tr>
</tbody>
</table>

<table style="display:inline-block;vertical-align:top;margin-right:2%;width:47.4%">
<thead>
<tr style="background-color:#d9d9d9;">
<th style="border:1px solid black;background-color:#d9d9d9;">Вход</th>
<th style="border:1px solid black;background-color:#d9d9d9;">Изход</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">30000<br />VIP<br />49</td>
<td style="border:1px solid black;">Not enough money! You need 6499.51 leva.</td>
</tr>
<tr>
<td colspan="2" style="border:1px solid black;background-color:#d9d9d9;"><strong>Обяснения</strong></td>
</tr>
<tr>
<td colspan="2" style="border:1px solid black;"><strong>49 човека: 40% от бюджета</strong> отиват <strong>за транспорт</strong>.<br /> <strong>Остават</strong>: 30000 – 12000 = <strong>18000</strong>.<br /> Категория <strong>VIP</strong>: билетът струва 499.99 * 49.<br /> <strong>24499.510000000002 &lt; 18000</strong>.<br /> <strong>Не стигат</strong> 24499.51 - 18000 = <strong>6499.51</strong>
</td>
</tr>
</tbody>
</table>
</div>

### Насоки и подсказки

#### 1. Обработка на входнните данни

Прочитаме внимателно условието и разглеждаме какво се очаква да получим като входни данни, какво се очаква да върнем като резултат, както и кои са основните стъпки при възможното разбиване на логическата схема.

Като за начало нека си обработим и запазим входните данни в подходящи за това параметри:

```cs
decimal budget = ............................;
string ticketType = ...................;
int people = .........................;
```

#### 2. Изчисления

Нека си създадем и инициализираме нужните ни за изчисленията променливи:

```cs
decimal transportCharges = .....;
decimal moneyForTickets = .....;
decimal moneyDifference = .....;
```

Нека отново прегледаме условието. Трябва да направим две различни блок изчисления. От първите изчисления трябва да разберем каква част от бюджета ще трябва да заделим за транспорт. За логиката на тези изчисления забелязваме, че има значение единствено броят на хората в групата. Следователно ще направим логическата разбивка спрямо броят на запалянковците.
Ще използваме условна конструкция - поредица <strong>if-else if-else if-......</strong>.

```cs
if (people <= 4)
{
    transportCharges = 0.75M * budget;
}
else if (people <= ....)
{
    transportCharges = 0.60M * budget;
}
else if (people <= ....)
{
    transportCharges = ..........;
}
else if (.............)
{
    transportCharges = ..........;
}
else if (..... >= .....)
{
    transportCharges = ..........;
}
```

От вторите изчисления трябва да намерим каква сума ще ни е необходима за закупуване на билети за групата. Според условието това ни зависи единствено от типа на билетите, които трябва да закупим. Нека използваме <strong>switch-case</strong> условна конструкция.

```cs
switch (ticketType)
{
    case "Normal":
        moneyForTickets = ................;
        break;
    case "VIP":
        moneyForTickets = ................;
        break;
    default:
        moneyForTickets = people * 249.99M;
        break;
}
```

След като сме изчислили какви са ни транспортните разходи и разходите за билети ни остава да изчислим крайният резултат и да разберем ще успее ли групата от запалянковци да отиде на Евро 2016 или няма да успее при така подадените параметри. За извеждането на резултата, за да си спестим една проверка (<strong>else</strong>) в конструкцията приемаме, че групата по подразбиране ще може да отиде на Евро 2016.

```cs
moneyDifference = budget - transportCharges - moneyForTickets;
string result = string.Format(
    "Yes! You have {0:F2} leva left.",
    decimal.Round(moneyDifference, 2));

if (moneyDifference < 0)
{
    result = string.Format(
        "Not enough money! You need {0:F2} leva.",
        Math.Abs(decimal.Round(moneyDifference, 2)));
}
```

#### 3. Показване на резултата

Накрая ни остава да покажем изчисленият резултат на конзолата:

```cs
Console.WriteLine(result);
```

### Тестване в Judge системата

Може да тествате вашето решение на URL адрес: [**https://judge.softuni.bg/Contests/Practice/Index/233#2**](https://judge.softuni.bg/Contests/Practice/Index/233#2).

## 5.Хотелска стая

_Трета задача от междинния изпит на 28 август 2016. Тествайте решението си на URL адрес: [**https://judge.softuni.bg/Contests/Practice/Index/274#2**](https://judge.softuni.bg/Contests/Practice/Index/274#2)._

Хотел предлага **2 вида стаи**: **студио и апартамент**.

Напишете програма, която изчислява **цената за целия престой за студио и апартамент**. **Цените** зависят от **месеца** на престоя:

<div>
<table style="display:inline-block;vertical-align:top;margin-right:2%;width:31.5%;">
<thead>
<tr style="background-color:#d9d9d9;">
<th style="background-color:#d9d9d9;border:1px solid black;">Май и октомври</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">Студио – <strong>50</strong> лв./нощувка</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="background:none;background-color:#ffffff;border:1px solid black;">Апартамент – <strong>65</strong> лв./нощувка</td>
</tr>
</tbody>
</table>

<table style="display:inline-block;vertical-align:top;margin-right:2%;width:31.5%">
<thead>
<tr style="background-color:#d9d9d9;">
<th style="background-color:#d9d9d9;border:1px solid black;">Юни и септември</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">Студио – <strong>75.20</strong> лв./нощувка</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="background:none;background-color:#ffffff;border:1px solid black;">Апартамент – <strong>68.70</strong> лв./нощувка</td>
</tr>
</tbody>
</table>

<table style="display:inline-block;vertical-align:top;width:31.5%;">
<thead>
<tr style="background-color:#d9d9d9;">
<th style="background-color:#d9d9d9;border:1px solid black;">Юли и август</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">Студио – <strong>76</strong> лв./нощувка</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="background:none;background-color:#ffffff;border:1px solid black;">Апартамент – <strong>77</strong> лв./нощувка</td>
</tr>
</tbody>
</table>
</div>

Предлагат се и следните **отстъпки**:

- За **студио**, при **повече** от **7** нощувки през **май и октомври**: **5% намаление**.
- За **студио**, при **повече** от **14** нощувки през **май и октомври**: **30% намаление**.
- За **студио**, при **повече** от **14** нощувки през **юни и септември**: **20% намаление**.
- За **апартамент**, при **повече** от **14** нощувки, **без значение от месеца: 10% намаление**.

### Входни данни

Входът се чете от **конзолата** и съдържа **точно 2 реда**:

- На **първия** ред е **месецът** – **May**, **June**, **July**, **August**, **September** или **October**
- На **втория** ред е **броят на нощувките** – **цяло число в интервала** **[0...200]**

### Изходни данни

Да се **отпечатат** на конзолата **2 реда**:

- На **първия ред**: &quot;**Apartment: { цена за целият престой } lv**&quot;.
- На **втория ред**: &quot;**Studio: { цена за целият престой } lv**&quot;.

**Цената за целия престой да е форматирана с точност до два знака след десетичната запетая**.

### Примерен вход и изход

<div>
<table style="display:inline-block;">
<thead>
<tr style="background-color:#d9d9d9;">
<th style="background-color:#d9d9d9;border:1px solid black;">Вход</th>
<th style="background-color:#d9d9d9;min-width:190px;border:1px solid black;">Изход</th>
<th colspan="2" style="background-color:#d9d9d9;border:1px solid black;">Обяснения</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">May<br />15</td>
<td style="border:1px solid black;min-width:190px;">Apartment: 877.50 lv.<br />Studio: 525.00 lv.</td>
<td colspan="2" style="border:1px solid black;"><strong>През май</strong>, при повече от <strong>14</strong> нощувки, намаляваме цената на студиото с <strong>30%</strong> (50 – 15 = 35), а на апартамента – с <strong>10%</strong> (65 – 6.5 =58.5).<br /> Целият престой <strong>в апартамент</strong> – <strong>877.50 лв.</strong><br /> Целият престой <strong>в студио</strong> – <strong>525.00 лв.</strong>
</td>
</tr>
<tr style="background-color:#d9d9d9;">
<td style="background-color:#d9d9d9;font-weight:700;border:1px solid black;">Вход</td>
<td style="background-color:#d9d9d9;font-weight:700;border:1px solid black;min-width:190px;">Изход</td>
<td style="background-color:#d9d9d9;font-weight:700;border:1px solid black;">Вход</td>
<td style="background-color:#d9d9d9;font-weight:700;border:1px solid black;">Изход</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="background:none;background-color:#ffffff;border:1px solid black;">June<br />14</td>
<td style="background:none;background-color:#ffffff;border:1px solid black;min-width:190px;">Apartment: 961.80 lv.<br />Studio: 1052.80 lv.</td>
<td style="background:none;background-color:#ffffff;border:1px solid black;">August<br />20</td>
<td style="background:none;background-color:#ffffff;border:1px solid black;">Apartment: 1386.00 lv.<br />Studio: 1520.00 lv.</td>
</tr>
</tbody>
</table>

### Насоки и подсказки

#### 1. Обработка на входнните данни

Съгласно условието на задачата очакваме да получим 2 реда входни данни - на първият ред месеца през който се планува престой, а на вторият ред броят на нощувките.

Нека си обработим и запазим входните данни в подходящи за това параметри:

```cs 
string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());
```

#### 2. Изчисления

След това да си създадем и инициализираме нужните ни за изчисленията променливи:

```cs 
decimal studioPrice = 50.00M;
decimal apartmentPrice = 65.00M;
decimal studioRent = 0.00M;
decimal apartmentRent = 0.00M;
```

Нека отново прегледаме условието. Забеляваме, че основната ни логика зависи от това какъв месец ни е подаден, като същевременно и зависим от броят на нощувките.

Като цяло има различни подходи и начини да се направят въпросните проверки, но нека се спрем на основна условна конструкция <strong>switch-case</strong>, като в различните <strong>case</strong> блокове ще използваме съответно условни конструкции <strong>if</strong> и <strong>if-else</strong>.

Нека започнем с първата група месеци: Май и Октомври. За тези два месеца цената на престой ни е еднаква и за двата типа настаняване - в студио и в апартамент. Съответно ни остава само да направим вътрешна проверка спрямо броят нощувки, за да преизчислим ако се налага с колко да се промени съответната цена.

```cs
switch (month)
{
    case "May":
    case "October":
        studioPrice = 50.00M;
        apartmentPrice = 65.00M;

        studioRent = studioPrice * nights;
        apartmentRent = apartmentPrice * nights;

        if (nights > 14)
        {
            studioRent *= 0.70M;
            apartmentRent *= 0.90M;
        }
        else if (nights > 7)
        {
            studioRent *= 0.95M;
        }

        break;
    ...............
```

Съответно за последващите месеци и групи от месеци логиката и изчисленията ни ще са донякъде идентични. 

```cs
    case "June":
    case "September":
        studioPrice = .......;
        apartmentPrice = .......;

        studioRent = ...........;
        apartmentRent = ...........;

        if (nights > 14)
        {
            studioRent ...........;
            apartmentRent ...........;
        }

        break;
    case "July":
    case "August":
        studioPrice = .......;
        apartmentPrice = .......;

        studioRent = ...........;
        apartmentRent = ...........;

        if (.........)
        {
            ..............
        }

        break;
    default:
        break;
}
```

След като имаме изчислени какви ще са ни съответните цени и крайна стойност за престоя нека да си извадим крайните изчисления в изходните ни параметри - <strong>studioInfo</strong> и <strong>apartmentInfo</strong>.

```cs
string studioInfo = string.Format(
    "Studio: {0:F2} lv.", decimal.Round(studioRent, 2));
string apartmentInfo = string.Format(
    "Apartment: {0:F2} lv.", decimal.Round(apartmentRent, 2));
```

#### 3. Показване на резултата

Накрая ни остава да покажем изчислените резултати на конзолата:

```cs
Console.WriteLine(apartmentInfo);
Console.WriteLine(studioInfo);
```

### Тестване в Judge системата

Може да тествате вашето решение на URL адрес: [**https://judge.softuni.bg/Contests/Practice/Index/274#2**](https://judge.softuni.bg/Contests/Practice/Index/274#2).
