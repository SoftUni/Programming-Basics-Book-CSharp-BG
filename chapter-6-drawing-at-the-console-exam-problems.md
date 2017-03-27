# Глава 6. Чертане на фигурки с цикли - изпитни задачи
В тази глава ще решим няколко задачи, включващи чертане на фигури с цикли, и ще разгледаме най-често срещаните бъгове.
## Чертане на крепост
*Пета задача от междинния изпит на 6 март 2016.*

Зададена ни е следната задача :
Да се напише програма, която прочита от конзолата цяло число **n** и чертае крепост с ширина **2 * n** колони и височина **n** реда. Лявата и дясната колона във вътрешността си са широки **n / 2**.

### Входни данни
Входът е цяло число **n** в интервала **[3…1000].**
### Изходни данни
Да се отпечатат на конзолата **n** текстови реда, изобразяващи **крепостта**, точно както в примерите.
### Примерен вход и изход
Следват няколко тестови примера, които ще са главният ни ориентир за писането на кода:

<div style="display:inline-block; border: 1px solid blue">Вход</div>
<div style="display:inline-block; border: 1px solid green">Изход</div>

<div style="display:inline-block; border: 1px solid blue">3</div>
<div style="display:inline-block; border: 1px solid green"><img src="assets/chapter-6-images/fort/fort-output-3.png" width="100px"></div>

<div style="display:inline-block; border: 1px solid blue">Вход</div>
<div style="display:inline-block; border: 1px solid green">Изход</div>

<div style="display:inline-block; border: 1px solid blue">4</div>
<div style="display:inline-block; border: 1px solid green"><img src="assets/chapter-6-images/fort/fort-output-4.png" width="100px"></div>

<div style="display:inline-block; border: 1px solid blue">Вход</div>
<div style="display:inline-block; border: 1px solid green">Изход</div>

<div style="display:inline-block; border: 1px solid blue">5</div>
<div style="display:inline-block; border: 1px solid green"><img src="assets/chapter-6-images/fort/fort-output-5.png" width="100px"></div>

<div style="display:inline-block; border: 1px solid blue">Вход</div>
<div style="display:inline-block; border: 1px solid green">Изход</div>

<div style="display:inline-block; border: 1px solid blue">8</div>
<div style="display:inline-block; border: 1px solid green"><img src="assets/chapter-6-images/fort/fort-output-8.png" width="100px"></div>

### Насоки и подсказки
За да "обединим" примерите в един алгоритъм, ще трябва да изследваме какво се повтаря във всеки пример. Разлгеждайки тестовите примери по редове, може да  разграничим различни групирания от редове.

<img src="assets/chapter-6-images/fort/fort-input-5-explanation.png">

<img src="assets/chapter-6-images/fort/fort-input-8-explanation.png">

Общи за примерите са три групи редове :
- таван
- стени
- основи

**Таванът** винаги се състои само от **един** ред, а пък **основите** винаги - от **два**. Oсновите се рисуват както на последният ред, така и на предпоследният.

Забелязваме, че броят на редовете, на които са нарисувани стени, е различен за различните примери. Използвайки условието, можем да изчислим броят на стените:

```
редове за цялата крепост: n
редове за покрив: 1
редове за основи: 2
редове за стени: n - 3
```
Редовете за стените ще са равни на височината на цялата крепост **(n)** без височината на покрива и основите.


#### Рисуване на покрива
След като сме установили нужният брой от редове за всяка "част" от крепостта, ще започнем да пишем кодът, който ще я "рисува".

За тази цел, ще разделим тавана на няколко части, които са по лесни за рисуване:

<img src="assets/chapter-6-images/fort/fort-roof-8-explanation.png">

<img src="assets/chapter-6-images/fort/fort-roof-5-explanation.png">

Примерите ни показват, че покривът може да бъде разделен на **кули** и **междинна част**. Всяка кула се състои от начало **"/"**, среда **"^"** и край **"\\"**. Броят на символите за начало и край винаги е равен на едно. Като допълнение можем да забележим, че броят на средите "^" е равен на  n/2.
Следователно, символите в една кула ще бъдат `Math.floor(n/2) + 2`.
**Забележка** : Math.floor - приравнява надолу.
<img src="assets/chapter-6-images/fort/fort-code-1.png">
TODO: Add Console.Write explanation
Тъй като **towerWidth** е целочислен тип данни (int), остатъкът при деление се премахва и не се налага да закръгляваме надолу.

Можем да изчислим размерът на междинната част:

```
Междинна широчина = широчина на крепост - 2*широчина на кула
Междинна широчина = 2*n - 2*широчина на кула
```
<img src="assets/chapter-6-images/fort/fort-code-2.png">
След като сме нарисували и междинният покрив на замъкът, ни остава само да нарисуваме още една кула.

TODO: Add Console.WriteLine()

<img src="assets/chapter-6-images/fort/fort-roof-4-explanation.png">

Когато рисуваме покриви с **n<=4** ще забележим, че средната част от покрива липсва.

#### Рисуване на стените
Трябва да нарисуваме редовете, така че да направим височината на кепостта ни **n**.
Вече знаем, че ни трябва 1 ред за покрив и 2 за основи, значи ще ни трябват `n-3` реда за стени.

<img src="assets/chapter-6-images/fort/fort-code-3.png">

Един ред от стената се състои от символ **"|"** в началото, няколко интервала и символ **"|"** в края. Следователно, броят на интервалите ще бъде равен на `широчината на крепоста - 2` или `2*n - 2`.

<img src="assets/chapter-6-images/fort/fort-code-4.png">
На края на всеки ред се налага по някакъв начин да отиваме на нов ред. За тази цел използваме `Console.WriteLine()`. Извикан без параметри, този метод само ни праща на нов ред.

#### Рисуване на основите

В частта на основите влизат последните два реда.

Предпоследният ред е подобен на обикновен ред за стена, но по средата той съдържа няколко символа за междинна част. Широчината на междинната част на основите е равна на широчината на междинната част на покрива. Преди и след междинната част състояща се от **"_"**, ще трябва да рисуваме няколко интервала.

`Брой интервали = широчина на крепоста - широчина на междинна част - 2`

<img src="assets/chapter-6-images/fort/fort-code-5.png">

Ще разделим интервалите на две части, и ще рисуваме половината преди междинната част и половината след междинната част.

TODO: Да се добави обяснение защо интервалите винаги ще могат да се делят на 2

Последният ред от крепоста ни, наподобява първият. Него можем да направим като вземем кодът, който рисува първият ред и променим някои от символите.
<img src="assets/chapter-6-images/fort/fort-code-6.png">
### Тестване в Judge системата
TODO: Add adress

## Пеперуда
*Пета задача от междинния изпит на 26 март 2016.*
Да се напише програма, която прочита от конзолата цяло число **n** и чертае пеперуда с ширина **2 * n - 1** колони и височина **2 * (n - 2) + 1** реда като в примерите по-долу.  Лявата и дясната ѝ част са широки **n - 1**.

### Входни данни
Входът е цяло число **n** в интервала **[3…1000]**.
### Изходни данни
Да се отпечатат на конзолата **2 * (n - 2) + 1**  текстови реда, изобразяващи пеперудата.
### Примерен вход и изход

<div style="display:inline-block; border: 1px solid blue">Вход</div>
<div style="display:inline-block; border: 1px solid green">Изход</div>

<div style="display:inline-block; border: 1px solid blue">3</div>
<div style="display:inline-block; border: 1px solid green"><img src="assets/chapter-6-images/butterfly/butterfly-input-3.png" width="100px"></div>

<div style="display:inline-block; border: 1px solid blue">Вход</div>
<div style="display:inline-block; border: 1px solid green">Изход</div>

<div style="display:inline-block; border: 1px solid blue">5</div>
<div style="display:inline-block; border: 1px solid green"><img src="assets/chapter-6-images/butterfly/butterfly-input-5.png" width="100px"></div>

<div style="display:inline-block; border: 1px solid blue">Вход</div>
<div style="display:inline-block; border: 1px solid green">Изход</div>

<div style="display:inline-block; border: 1px solid blue">7</div>
<div style="display:inline-block; border: 1px solid green"><img src="assets/chapter-6-images/butterfly/butterfly-input-7.png" width="100px"></div>

### Насоки и подсказки
Примерният вход и изход ни показват, че има 2 вида редове:
1. Редове от звездички
2. Редове от тирета

Всеки един от тези редове е разделен от интервал на две еднакви части съставени от **n - 1** символа. В началото или в края на всяка една от тези части има наклонена една черта. Без наклонената черта ни остават **n - 2** символа, които са или звезда или тире. Може да сведем изрисуването на един единствен ред до следното:
```
Рисуване на n-2 звезди или тирета
Рисуване на \ /
Рисуване на n-2 звезди или тирета
```
След като знаем как да нарисуваме един ред, ще разгледаме каква е логиката зад различните типове редове или по точно ще видим дали един ред се състои от звездички или от черти. Ако номерацията на редовете ни започва от 0, ще забележим, че редовете, които са кратни на 2 **(четните редове)** включват звезди, а редовече, които не са кратни на 2 **(нечетните редове)** включват тирета.

Освен това, по средата на пеперудата има специален ред, който се състои от интервали и един единствен символ **@**. Преди символът **@** ще трябва да нарисуваме толкова интервали, колкото е размерът на едното крило на пеперудата. По условие, той ни е зададен като **n - 1**.

Височината на фигурката, която рисуваме трябва да е **2 &#42; (n-1) + 1**. Без специалният среден ред, получаваме височината само на крилата на пеперудата, която е равна на **2 &#42; (n-2)**. Следователно **n-2** е броят на редовете, които трябва да нарисуваме преди специалният ред както и след специалният среден ред. 

Можем да стигнем до същото заключение като забележим, че фигурките образувани само от звезди или тирета са квадрати. Следователно височината на едната част би била равна на широчината на едно крило или на **n-2**.

### Тестване в Judge системата


## Знак "Стоп"

Да се напише програма, която прочита от конзолата **цяло число N** и чертае **предупредителен знак STOP** с размери като в примерите по-долу.

### Входни данни

Входът е **цяло число N** в интервала **[3…1000]**.

### Изходни данни

Да се отпечатат на конзолата текстови редове, изобразяващи **предупредителния знак STOP**, точно както в примерите.

### Примерен вход и изход

<div style="display:inline-block; border: 1px solid blue">Вход</div>
<div style="display:inline-block; border: 1px solid green">Изход</div>

<div style="display:inline-block; border: 1px solid blue">3</div>
<div style="display:inline-block; border: 1px solid green"><img src="assets/chapter-6-images/butterfly/stop-input-3.png" width="100px"></div>

<div style="display:inline-block; border: 1px solid blue">Вход</div>
<div style="display:inline-block; border: 1px solid green">Изход</div>

<div style="display:inline-block; border: 1px solid blue">5</div>
<div style="display:inline-block; border: 1px solid green"><img src="assets/chapter-6-images/butterfly/stop-input-5.png" width="100px"></div>

<div style="display:inline-block; border: 1px solid blue">Вход</div>
<div style="display:inline-block; border: 1px solid green">Изход</div>

<div style="display:inline-block; border: 1px solid blue">7</div>
<div style="display:inline-block; border: 1px solid green"><img src="assets/chapter-6-images/butterfly/stop-input-8.png" width="100px"></div>

### Насоки и подсказки

### Тестване в Judge системата


## TODO: да се добавят още 2-3 изпитни задачи за чертане на фигурки
