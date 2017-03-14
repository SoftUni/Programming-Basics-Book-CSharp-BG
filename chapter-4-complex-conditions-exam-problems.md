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
<tr>
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
<tr>
<td style="border:1px solid black;background:none;">9<br />00<br />8<br />30</td>
<td style="border:1px solid black;background:none;">On time<br />30 minutes before the start</td>
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
<tr>
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
<tr>
<td style="border:1px solid black;background:none;">14<br />00<br />13<br />55</td>
<td style="border:1px solid black;background:none;">On time<br />5 minutes before the start</td>
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
<tr>
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
<tr>
<td style="border:1px solid black;background:none;">11<br />30<br />10<br />55</td>
<td style="border:1px solid black;background:none;">Early<br />35 minutes before the start<br /><br /></td>
</tr>
<tr>
<td style="border:1px solid black;">11<br />30<br />12<br />23</td>
<td style="border:1px solid black;">Late<br />59 minutes after the start<br /><br /></td>
</tr>
</tbody>
</table>
</div>

### Насоки и подсказки

TODO

### Тестване в Judge системата

Може да тествате вашето решение на URL адрес: [**https://judge.softuni.bg/Contests/Practice/Index/169#2**](https://judge.softuni.bg/Contests/Practice/Index/169#2).

## 2.Пътешествие

_Трета задача от междинния изпит на 26 март 2016. Тествайте решението на адрес: [**https://judge.softuni.bg/Contests/Compete/Index/179#2**](https://judge.softuni.bg/Contests/Compete/Index/179#2)._

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
<tr>
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
<tr>
<td style="border:1px solid black;background:none;">75<br />winter</td>
<td style="border:1px solid black;background:none;">Somewhere in Bulgaria<br />Hotel - 52.50</td>
</tr>
<tr>
<td style="border:1px solid black;">312<br />summer</td>
<td style="border:1px solid black;">Somewhere in Balkans<br />Camp - 124.80</td>
</tr>
<tr>
<td style="border:1px solid black;background:none;">678.53<br />winter</td>
<td style="border:1px solid black;background:none;">Somewhere in Balkans<br />Hotel - 542.82</td>
</tr>
<tr>
<td style="border:1px solid black;">1500<br />summer</td>
<td style="border:1px solid black;">Somewhere in Europe<br />Hotel - 1350.00</td>
</tr>
</tbody>
</table>
</div>

### Насоки и подсказки

TODO
### Тестване в Judge системата

Може да тествате вашето решение на URL адрес: [**https://judge.softuni.bg/Contests/Compete/Index/179#2**](https://judge.softuni.bg/Contests/Compete/Index/179#2). 

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
<tr>
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
<tr>
<td style="border:1px solid black;background:none;">10<br />1<br />-</td>
<td style="border:1px solid black;background:none;">10 - 1 = 9 - odd</td>
</tr>
<tr>
<td style="border:1px solid black;">7<br />3<br />*</td>
<td style="border:1px solid black;">7 * 3 = 21 - odd</td>
</tr>
</tbody>
</table>

<table style="display:inline-block;vertical-align:top;margin-right:2%;width:31.5%">
<thead>
<tr>
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
<tr>
<td style="border:1px solid black;background:none;">10<br />3<br />%</td>
<td style="border:1px solid black;background:none;">10 % 3 = 1</td>
</tr>
</tbody>
</table>

<table style="display:inline-block;vertical-align:top;width:31.5%">
<thead>
<tr>
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
<tr>
<td style="border:1px solid black;background:none;">10<br />0<br />%</td>
<td style="border:1px solid black;background:none;">Cannot divide 10 by zero</td>
</tr>
</tbody>
</table>
</div>

### Насоки и подсказки

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
<tr>
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
<tr>
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
<td colspan="2" style="border:1px solid black;"><strong>49 човека: 40% от бюджета</strong> отиват <strong>за транспорт</strong>.<br /> <strong>Остават</strong>: 30000 – 12000 = <strong>18000</strong>.<br /> Категория <strong>VIP</strong>: билетите струват 499.99 * 49.<br /> <strong>24499.510000000002 &lt; 18000</strong>.<br /> <strong>Не стигат</strong> 24499.51 - 18000 = <strong>6499.51</strong>
</td>
</tr>
</tbody>
</table>
</div>

### Насоки и подсказки

TODO

### Тестване в Judge системата

Може да тествате вашето решение на URL адрес: [**https://judge.softuni.bg/Contests/Practice/Index/233#2**](https://judge.softuni.bg/Contests/Practice/Index/233#2).

## 5.Хотелска стая

_Трета задача от междинния изпит на 28 август 2016. Тествайте решението си на URL адрес: [**https://judge.softuni.bg/Contests/Practice/Index/274#2**](https://judge.softuni.bg/Contests/Practice/Index/274#2)._

Хотел предлага **2 вида стаи**: **студио и апартамент**.

Напишете програма, която изчислява **цената за целия престой за студио и апартамент**. **Цените** зависят от **месеца** на престоя:

<div>
<table style="display:inline-block;vertical-align:top;margin-right:2%;width:31.5%;">
<thead>
<tr>
<th style="background-color:#d9d9d9;border:1px solid black;">Май и октомври</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">Студио – <strong>50</strong> лв./нощувка</td>
</tr>
<tr>
<td style="background:none;border:1px solid black;">Апартамент – <strong>65</strong> лв./нощувка</td>
</tr>
</tbody>
</table>

<table style="display:inline-block;vertical-align:top;margin-right:2%;width:31.5%">
<thead>
<tr>
<th style="background-color:#d9d9d9;border:1px solid black;">Юни и септември</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">Студио – <strong>75.20</strong> лв./нощувка</td>
</tr>
<tr>
<td style="background:none;border:1px solid black;">Апартамент – <strong>68.70</strong> лв./нощувка</td>
</tr>
</tbody>
</table>

<table style="display:inline-block;vertical-align:top;width:31.5%;">
<thead>
<tr>
<th style="background-color:#d9d9d9;border:1px solid black;">Юли и август</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">Студио – <strong>76</strong> лв./нощувка</td>
</tr>
<tr>
<td style="background:none;border:1px solid black;">Апартамент – <strong>77</strong> лв./нощувка</td>
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
<tr>
<th style="background-color:#d9d9d9;border:1px solid black;">Вход</th>
<th style="background-color:#d9d9d9;min-width:160px;border:1px solid black;">Изход</th>
<th colspan="2" style="background-color:#d9d9d9;border:1px solid black;">Обяснения</th>
</tr>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td style="border:1px solid black;">May<br />15</td>
<td style="border:1px solid black;">Apartment: 877.50 lv.<br />Studio: 525.00 lv.</td>
<td colspan="2"><strong>През май</strong>, при повече от <strong>14</strong> нощувки, намаляваме цената на студиото с <strong>30%</strong> (50 – 15 = 35), а на апартамента – с <strong>10%</strong> (65 – 6.5 =58.5).<br /> Целият престой <strong>в апартамент</strong> – <strong>877.50 лв.</strong><br /> Целият престой <strong>в студио</strong> – <strong>525.00 лв.</strong>
</td>
</tr>
<tr>
<td style="background-color:#d9d9d9;font-weight:700;border:1px solid black;">Вход</td>
<td style="background-color:#d9d9d9;font-weight:700;border:1px solid black;">Изход</td>
<td style="background-color:#d9d9d9;font-weight:700;border:1px solid black;">Вход</td>
<td style="background-color:#d9d9d9;font-weight:700;border:1px solid black;">Изход</td>
</tr>
<tr>
<td style="background:none;border:1px solid black;">June<br />14</td>
<td style="background:none;border:1px solid black;">Apartment: 961.80 lv.<br />Studio: 1052.80 lv.</td>
<td style="background:none;border:1px solid black;">August<br />20</td>
<td style="background:none;border:1px solid black;">Apartment: 1386.00 lv.<br />Studio: 1520.00 lv.</td>
</tr>
</tbody>
</table>

### Насоки и подсказки

TODO

### Тестване в Judge системата

Може да тествате вашето решение на URL адрес: [**https://judge.softuni.bg/Contests/Practice/Index/274#2**](https://judge.softuni.bg/Contests/Practice/Index/274#2).
