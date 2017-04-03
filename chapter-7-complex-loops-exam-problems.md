
# Глава 7. По-сложни цикли - изпитни задачи
Вече научихме как може да изпълним даден блок от команди повече от веднъж използвайки for-цикъл. В предходната глава разгледахме още няколко циклични конструкци, които да ни помогнат да решим по-сложни проблеми.
- Цикли със стъпка
- Вложени цикли
- while цикли
- do-while цикли.
- Безкрайни цикли и излизане от цикъл (break оператор)
- Конструкцията try-catch

Нека затвърдим знанията си като решим няколко по-сложни задачи с цикли, давани на приемни изпити.

## Генератор за тъпи пароли
Да се напише програма, която въвежда две цели числа **n** и **l** и генерира по азбучен ред всички възможни **“тъпи” пароли**, които се състоят от следните **5 символа**:
-	Символ 1: цифра от **1** до **n**.
-	Символ 2: цифра от **1** до **n**.
-	Символ 3: малка буква измежду първите **l** букви на латинската азбука.
-	Символ 4: малка буква измежду първите **l** букви на латинската азбука.
-	Символ 5: цифра от **1** до **n, по-голяма от първите 2 цифри.**

### Входни данни
Входът се чете от конзолата и се състои от **две цели числа: n** и **l** в интервала **[1…9]**, по едно на ред.

### Изходни данни
На конзолата трябва да се отпечатат **всички “тъпи” пароли по азбучен ред**, разделени с **интервал**.

### Примерен вход и изход
<div style="display:inline-block;margin-right:2%;width:90%;">
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
<td style="border:1px solid black;">2<br />4</td>
<td style="border:1px solid black;">11aa2 11ab2 11ac2 11ad2 11ba2 11bb2 11bc2 11bd2 11ca2 11cb2 11cc2 11cd2 11da2 11db2 11dc2 11dd2</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="background:none;background-color:#ffffff;border:1px solid black;">3<br />1</td>
<td style="background:none;background-color:#ffffff;border:1px solid black;">11aa2 11aa3 12aa3 21aa3 22aa3</td>
</tr>
<tr>
<td style="border:1px solid black;">3<br />2</td>
<td style="border:1px solid black;">11aa2 11aa3 11ab2 11ab3 11ba2 11ba3 11bb2 11bb3 12aa3 12ab3 12ba3 12bb3 21aa3 21ab3 21ba3 21bb3 22aa3 22ab3 22ba3 22bb3</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="background:none;background-color:#ffffff;border:1px solid black;">4<br />2</td>
<td style="background:none;background-color:#ffffff;border:1px solid black;">11aa2 11aa3 11aa4 11ab2 11ab3 11ab4 11ba2 11ba3 11ba4 11bb2 11bb3 11bb4 12aa3 12aa4 12ab3 12ab4 12ba3 12ba4 12bb3 12bb4 13aa4 13ab4 13ba4 13bb4 21aa3 21aa4 21ab3 21ab4 21ba3 21ba4 21bb3 21bb4 22aa3 22aa4 22ab3 22ab4 22ba3 22ba4 22bb3 22bb4 23aa4 23ab4 23ba4 23bb4 31aa4 31ab4 31ba4 31bb4 32aa4 32ab4 32ba4 32bb4 33aa4 33ab4 33ba4 33bb4</td>
</tr>
</tbody>
</table>
</div>

### Насоки и подсказки

Програмата, която решава този проблем, можем да разделим мислено на три части:<br>

  1.  	**Прочитане на входните данни** – в настоящата задача това включва прочитането на числото n, последвано от n на брой цели числа, всяко на отделен ред.
  2.  	**Обработка на входните данни** – използване на вложени цикли за преминаване през всеки възможен символ за всеки от петте символа на паролата.
  3.  	**Извеждане на резултат** – отпечатване на всяка "тъпа" парола, която отговаря на условията.<br>

За прочитане на входните данни ще декларираме две променливи : **n** и **l**, от целочислен тип `int`.
```c#
var n = int.Parse(Console.ReadLine());
var l = int.Parse(Console.ReadLine());
```
Нека приемем имена за променливите, които ще съхраняват символите на паролата: **d1**, **d2**, **d3**, от тип `int`, за цифровите символи; и **l1**, **l2**, от тип `char` - за буквените. За улеснение ще пропуснем изричното уточняване на типа като го заместим с ключовата дума `var`.

Необходимо е да вложим пет **for** цикъла един в друг, по един за всяка променлива. За да гарантираме условието последната цифра, **d3**, да бъде по-голяма от първите две, ще използваме вградената функция `Math.Max`. Да видим и кода.
```c#
for (var d1 = 1; d1 <= n; d1++)
            for (var d2 = 1; d2 <= n; d2++)
                for (var l1 = 'a'; l1 < 'a' + l; l1++)
                    for (var l2 = 'a'; l2 < 'a' + l; l2++)
                        for (var d3 = Math.Max(d1, d2) + 1; d3 <= n; d3++)
                        {
                            Console.Write("{0}{1}{2}{3}{4} ", 
                                d1, d2, l1, l2, d3);
                        }
        Console.WriteLine();
```

### Тестване в Judge системата
Може да тествате вашето решение на URL адрес: https://judge.softuni.bg/Contests/515/7-2-Complex-Loops-Exam-Problems
//TODO - EDIT THE LINK WHEN PROBLEMS ARE IN JUDGE. Дотогава - https://judge.softuni.bg/Contests/Practice/Index/169#5


## Магически числа
Да се напише програма, която въвежда едно цяло **„магическо“** число и изкарва **всички** възможни **6-цифрени числа**, за които **произведението на неговите цифри е равно на „магическото“ число**.
<br/><br/>Пример: „Магическо число“ -> 2
-	111112 -> 1 * 1 * 1 * 1 * 1 * 2 = 2
-	111121 -> 1 * 1 * 1 * 1 * 2 * 1 = 2
-	111211 -> 1 * 1 * 1 * 2 * 1 * 1 = 2
-	112111 -> 1 * 1 * 2 * 1 * 1 * 1 = 2
-	121111 -> 1 * 2 * 1 * 1 * 1 * 1 = 2
-	211111 -> 2 * 1 * 1 * 1 * 1 * 1 = 2


### Входни данни
Входът се чете от конзолата и се състои от **едно цяло число** в интервала **[1…600000]**.

### Изходни данни
На конзолата трябва да се отпечатат **всички “магически” числа**, разделени с **интервал**.
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
<td style="border:1px solid black;">2</td>"<td style="border:1px solid black;">111112 111121 111211 112111 121111 211111</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="background:none;background-color:#ffffff;border:1px solid black;">8</td>
<td style="background:none;background-color:#ffffff;border:1px solid black;">111118 111124 111142 111181 111214 111222 111241 111412 111421 111811 112114 112122 112141 112212 112221 112411 114112 114121 114211 118111 121114 121122 121141 121212 121221 121411 122112 122121 122211 124111 141112 141121 141211 142111 181111 211114 211122 211141 211212 211221 211411 212112 212121 212211 214111 221112 221121 221211 222111 241111 411112 411121 411211 412111 421111 811111</td>
</tr>
<tr>
<td style="border:1px solid black;">531441</td>
<td style="border:1px solid black;">999999</td>
</tr>
</tbody>
</table>
</div>

### Насоки и подсказки
Решението на задачата за магическите числа следва същата концепция. Следвайки тези стъпки, опитайте да решите задачата сами.
-	Задайте променлива от целочислен тип `int` и прочетете входа от конзолата.
-	Вложете **шест for-цикъла** един в друг, по един за всяка цифра на търсените шестцифрени числа.
-	В последния цикъл, чрез `if` конструкция, проверете дали произведението на шестте цифри е равно на магическото число.



### Тестване в Judge системата
Може да тествате вашето решение на URL адрес: https://judge.softuni.bg/Contests/515/7-2-Complex-Loops-Exam-Problems//TODO - EDIT THE LINK WHEN PROBLEMS ARE IN JUDGE. Дотогава - https://judge.softuni.bg/Contests/Practice/Index/179#5

## Специални числа
Да се напише програма, която **въвежда едно цяло число N** и генерира всички възможни **“специални” числа** от **1111** до **9999**. За да бъде **“специалнo”** едно число, то трябва да отговаря на **следното условие**:
-	**N да се дели на всяка една от неговите цифри без остатък.**

<br/>**Пример:** при **N = 16, 2418** е специално число:
-	**16 / 2** = 8 **без остатък**
-	**16 / 4** = 4 **без остатък**
-	**16 / 1** = 16 **без остатък**
-	**16 / 8** = 2 **без остатък**
 
### Входни данни
Входът се чете от конзолата и се състои от **едно цяло число** в интервала **[1…600000]**.

### Изходни данни
На конзолата трябва да се отпечатат **всички “магически” числа**, разделени с **интервал**.

### Примерен вход и изход

<div style="display:inline-block;margin-right:2%;width:31.5%;">
<table>
<thead>
<tr style="background-color:#d9d9d9;">
<th style="border:1px solid black;background-color:#d9d9d9;">Вход</th>
<th style="border:1px solid black;background-color:#d9d9d9;">Изход</th>
<th style="border:1px solid black;background-color:#d9d9d9;">Коментари</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">3</td>
<td style="border:1px solid black;">1111 1113 1131 1133 1311 1313 1331 1333 3111 3113 3131 3133 3311 3313 3331 3333</td>
<td>3 / 1 = 3 без остатък<br/>
3 / 3 = 1 без остатък<br/>
3 / 3 = 1 без остатък<br/>
3 / 3 = 1 без остатък<br/>
</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="background:none;background-color:#ffffff;border:1px solid black;">11</td>
<td colspan="2" style="background:none;background-color:#ffffff;border:1px solid black;">1111</td>
</tr>
<tr>
<td style="border:1px solid black;">16</td>
<td colspan="2" style="border:1px solid black;">1111 1112 1114 1118 1121 1122 1124 1128 1141 1142 1144 1148 1181 1182 1184 1188 1211 1212 1214 1218 1221 1222 1224 1228 1241 1242 1244 1248 1281 1282 1284 1288 1411 1412 1414 1418 1421 1422 1424 1428 1441 1442 1444 1448 1481 1482 1484 1488 1811 1812 1814 1818 1821 1822 1824 1828 1841 1842 1844 1848 1881 1882 1884 1888 2111 2112 2114 2118 2121 2122 2124 2128 2141 2142 2144 2148 2181 2182 2184 2188 2211 2212 2214 2218 2221 2222 2224 2228 2241 2242 2244 2248 2281 2282 2284 2288 2411 2412 2414 2418 2421 2422 2424 2428 2441 2442 2444 2448 2481 2482 2484 2488 2811 2812 2814 2818 2821 2822 2824 2828 2841 2842 2844 2848 2881 2882 2884 2888 4111 4112 4114 4118 4121 4122 4124 4128 4141 4142 4144 4148 4181 4182 4184 4188 4211 4212 4214 4218 4221 4222 4224 4228 4241 4242 4244 4248 4281 4282 4284 4288 4411 4412 4414 4418 4421 4422 4424 4428 4441 4442 4444 4448 4481 4482 4484 4488 4811 4812 4814 4818 4821 4822 4824 4828 4841 4842 4844 4848 4881 4882 4884 4888 8111 8112 8114 8118 8121 8122 8124 8128 8141 8142 8144 8148 8181 8182 8184 8188 8211 8212 8214 8218 8221 8222 8224 8228 8241 8242 8244 8248 8281 8282 8284 8288 8411 8412 8414 8418 8421 8422 8424 8428 8441 8442 8444 8448 8481 8482 8484 8488 8811 8812 8814 8818 8821 8822 8824 8828 8841 8842 8844 8848 8881 8882 8884 8888</td>
</tr>
</tbody>
</table>
</div>


### Насоки и подсказки
Решете задачата самостоятелно използвайки наученото от предишните две. Спомнете си разликата между операторите *целочислено деление ( **/** )* и *деление с остатък ( **%** )* в C#. 

### Тестване в Judge системата
Може да тествате вашето решение на URL адрес: https://judge.softuni.bg/Contests/515/7-2-Complex-Loops-Exam-Problems
//TODO - EDIT THE LINK WHEN PROBLEMS ARE IN JUDGE

## Комбинации от букви
Да се напише програма, която да **принтира** на конзолата **всички комбинации от 3 букви в зададен интервал**, като се пропускат тези, които съдържат зададена от конзолата буква.
 
### Входни данни
Входът се чете от **конзолата** и съдържа **точно 3 реда**.
- Ред 1. Малка буква от английската азбука за начало на интервала - от **a** до **z**.
- Ред 2. Малка буква от английската азбука за край на интервала - от **първата буква** до **z**.
- Ред 3. Малка буква от английската азбука - от **a** до **z** - като комбинациите, съдържащи тази буква се пропускат..

### Изходни данни
На конзолата трябва да се отпечатат всички трибуквени комбинации, които отговарят на условието, разделени с интервал. Накрая трябва да се принтира и броят на комбинациите.

### Примерен вход и изход

<div style="display:inline-block;margin-right:2%;width:31.5%;">
<table>
<thead>
<tr style="background-color:#d9d9d9;">
<th style="border:1px solid black;background-color:#d9d9d9;">Вход</th>
<th style="border:1px solid black;background-color:#d9d9d9;">Изход</th>
<th style="border:1px solid black;background-color:#d9d9d9;">Коментари</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">a<br />b<br />c</td>
<td style="border:1px solid black;">aaa aac aca acc caa cac cca ccc 8</td>
<td>Всички възможни комбинации с буквите a, b, и c са: <br /> 
aaa aab aac aba abb abc aca acb acc baa bab bac bba bbb bbc bca bcb bcc caa cab cac cba cbb cbc cca ccb ccc <br />
Комбинациите съдържащи b не са валидни. <br />
Остават 8 валидни комбинации
</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="background:none;background-color:#ffffff;border:1px solid black;">f<br />k<br />h</td>
<td colspan="2" style="background:none;background-color:#ffffff;border:1px solid black;">fff ffg ffi ffj ffk fgf fgg fgi fgj fgk fif fig fii fij fik fjf fjg fji fjj fjk fkf fkg fki fkj fkk gff gfg gfi gfj gfk ggf ggg ggi ggj ggk gif gig gii gij gik gjf gjg gji gjj gjk gkf gkg gki gkj gkk iff ifg ifi ifj ifk igf igg igi igj igk iif iig iii iij iik ijf ijg iji ijj ijk ikf ikg iki ikj ikk jff jfg jfi jfj jfk jgf jgg jgi jgj jgk jif jig jii jij jik jjf jjg jji jjj jjk jkf jkg jki jkj jkk kff kfg kfi kfj kfk kgf kgg kgi kgj kgk kif kig kii kij kik kjf kjg kji kjj kjk kkf kkg kki kkj kkk 125</td>
</tr>
</tbody>
</table>
</div>


### Насоки и подсказки
Решете задачата самостоятелно използвайки наученото от предишните. Не забравяйте да дефинирате променлива от *целочислен тип*, която да увеличавате с едно във тялото на `if` конструкцията.
А знаете ли, че:
- можете да дефинирате *for-цикъл* с променлива от тип `char`?
    ```c#
    for (char ch = 'a'; ch < 'z'; ch++)
    ``` 
- можете да прочетете променлива от тип char от конзолата със следната конструкция:
    ```c#
     char ch = (char)Console.Read();
     ``` 
    и да обърнете главен символ към малък използвайки вградена функция в C#?
    ```c#
    Char.ToLower(ch);
    ``` 
    съответно, при прочит на символи от конзолата, директно да преобразувате главни към малки букви, обединявайки горните два реда:
    ```c#
    char ch = Char.ToLower((char)Console.Read());
    ``` 

### Тестване в Judge системата
Може да тествате вашето решение на URL адрес: https://judge.softuni.bg/Contests/515/7-2-Complex-Loops-Exam-Problems
//TODO - EDIT THE LINK WHEN PROBLEMS ARE IN JUDGE. ДОТОГАВА - https://judge.softuni.bg/Contests/Practice/Index/368#5

## Цифри
Да се напише програма, която прочита от конзолата 1 цяло число в интервала **[100...999]**, и след това го принтира определен брой пъти - модифицирайки го преди всяко принтиране по следния начин:
- Ако числото се дели на **5** без остатък, **извадете** от него **първата му цифра**.
- Ако числото се дели на **3** без остатък, **извадете** от него **втората му цифра**.
- Ако нито едно от горните условия не е вярно, **прибавете** към него **третата му цифра**.

Принтирайте на конзолата **N брой реда**, като всеки ред има **M на брой числа**, които са резултат от горните действия. Нека:
- N = сбора на първата и втората цифра на числото.
- M = сбора на първата и третата цифра на числото.
 
### Входни данни
Входът се чете от **конзолата** и е цяло число в интервала **[100...999]**.

### Изходни данни
На конзолата трябва да се отпечатат **всички цели числа**, които са резултат от дадените по-горе изчисления в съответния брой редове и колони, както в примерите.

### Примерен вход и изход

<div style="display:inline-block;margin-right:2%;width:31.5%;">
<table>
<thead>
<tr style="background-color:#d9d9d9;">
<th style="border:1px solid black;background-color:#d9d9d9;">Вход</th>
<th style="border:1px solid black;background-color:#d9d9d9;">Изход</th>
<th style="border:1px solid black;background-color:#d9d9d9;">Коментари</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">132</td>
<td style="border:1px solid black;">129 126 123 <br/>
120 119 121 <br/>
123 120 119 <br/>
121 123 120 <br/>
</td>
<td>1 +3) = 4 и (1 + 2) = 3  -> 4 реда по 3 числа на всеки ред <br/>
Входното число 132 <br/>
132 -> деление на 3 -> 132 - 3 = <br/>
= 129 -> деление на 3 -> 129 - 3 = <br/>
= 126 -> деление на 3 -> 126 - 3 = <br/>
= 123 -> деление на 3 -> 123 - 3 = <br/>
= 120 -> деление на 5 -> 120 - 1 = <br/>
..... 121 -> нито на 5, нито на 3 -> 121 + 2 = 123
</td>
</tr>
<tr style="background:none;background-color:#ffffff;">
<td style="background:none;background-color:#ffffff;border:1px solid black;">376</td>
<td colspan="2" style="background:none;background-color:#ffffff;border:1px solid black;">382 388 394 400 397 403 409 415 412 <br/>
418 424 430 427 433 439 445 442 448 <br/>
454 460 457 463 469 475 472 478 484 <br/>
490 487 493 499 505 502 508 514 520 <br/>
517 523 529 535 532 538 544 550 547 <br/>
553 559 565 562 568 574 580 577 583 <br/>
589 595 592 598 604 610 607 613 619 <br/>
625 622 628 634 640 637 643 649 655 <br/>
652 658 664 670 667 673 679 685 682 <br/>
688 694 700 697 703 709 715 712 718</td>
</tr>
</tbody>
</table>
</div>


### Насоки и подсказки
Решете задачата самостоятелно използвайки наученото от предишните. Не забравяйте, че ще е нужно да дефинирате отделна променлива за всяка цифра на входното число.

### Тестване в Judge системата
Може да тествате вашето решение на URL адрес: https://judge.softuni.bg/Contests/515/7-2-Complex-Loops-Exam-Problems
//TODO - EDIT THE LINK WHEN PROBLEMS ARE IN JUDGE. ДОТОГАВА - https://judge.softuni.bg/Contests/Practice/Index/274#5
