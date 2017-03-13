# Глава 4. По-сложни проверки - изпитни задачи

## Навреме за изпит

_Трета задача от междинния изпит на 6 март 2016. Тествайте решението си [**тук**](https://judge.softuni.bg/Contests/Practice/Index/169#2)._

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

| Вход | Изход | Вход | Изход | Вход | Изход |
| :--- | :--- | :--- | :--- | :--- | :--- |
| 9<br>30<br>9<br>50 | Late<br>20 minutes after the start | 9<br>00<br>10<br>30 | Late<br>1:30 hours after the start | 10<br>00<br>10<br>00 | On time |
| 9<br>00<br>8<br>30 | On time<br>30 minutes before the start | 14<br>00<br>13<br>55 | On time<br>5 minutes before the start | 11<br>30<br>10<br>55 | Early<br>35 minutes before the start |
| 16<br>00<br>15<br>00 | Early<br>1:00 hours before the start | 11<br>30<br>8<br>12 | Early<br>3:18 hours before the start | 11<br>30<br>12<br>29 | Late<br>59 minutes after the start |

<br />


| **Вход** | **Изход** |   | **Вход** | **Изход** |   | **Вход** | **Изход** |
| --- | --- | --- | --- | --- | --- | --- | --- |
| 9<br />30<br />9<br />50 | Late<br />20 minutes after the start |   | 9<br />00<br />10<br />30 | Late<br />1:30 hours after the start |   |  10<br />00<br />10<br />00 | On time |
| 9<br />00<br />8<br />30 | On time<br />30 minutes before the start |   | 14<br />00<br />13<br />55 | On time<br />5 minutes before the start |   | 11<br />30<br />10<br />55 | Early<br />35 minutes before the start |
| 16<br />00<br />15<br />00 | Early<br />1:00 hours before the start |   | 11<br />30<br />8<br />12 | Early<br />3:18 hours before the start |   |  11<br />30<br />12<br />29 | Late<br />59 minutes after the start |

<br />

<table style="float:left; margin-right:20px">
<thead>
<th>Вход</th>
<th>Изход</th>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td>9<br />30<br />9<br />50</td>
<td>Late<br />20 minutes after the start</td>
</tr>
<tr>
<td>9<br />00<br />8<br />30</td>
<td>On time<br />30 minutes before the start</td>
</tr>
<tr>
<td>16<br />00<br />15<br />00</td>
<td>Early<br />1:00 hours before the start</td>
</tr>
</tbody>
</table>

<table style="float:left; margin-right:20px">
<thead>
<th>Вход</th>
<th>Изход</th>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td>9<br />00<br />10<br />30</td>
<td>Late<br />1:30 hours after the start</td>
</tr>
<tr>
<td>14<br />00<br />13<br />55</td>
<td>On time<br />5 minutes before the start</td>
</tr>
<tr>
<td>11<br />30<br />8<br />12</td>
<td>Early<br />3:18 hours before the start</td>
</tr>
</tbody>
</table>


<table style="float:left; margin-right:20px">
<thead>
<th>Вход</th>
<th>Изход</th>
</thead>
<tfoot></tfoot>
<tbody>
<tr>
<td>10<br />00<br />10<br />00</td>
<td>On time</td>
</tr>
<tr>
<td>11<br />30<br />10<br />55</td>
<td>Early<br />35 minutes before the start</td>
</tr>
<tr>
<td>11<br />30<br />12<br />23</td>
<td>Late<br />59 minutes after the start</td>
</tr>
</tbody>
</table>

### Насоки и подсказки

### Тестване в Judge системата


## Пътешествие

TODO: описание

TODO: картинка

### Входни данни

### Изходни данни

### Примерен вход и изход

### Насоки и подсказки

### Тестване в Judge системата


## Операции между числа

TODO: описание

TODO: картинка

### Входни данни

### Изходни данни

### Примерен вход и изход

### Насоки и подсказки

### Тестване в Judge системата


## Билети за мач

TODO: описание

TODO: картинка

### Входни данни

### Изходни данни

### Примерен вход и изход

### Насоки и подсказки

### Тестване в Judge системата


## Хотелска стая

TODO: описание

TODO: картинка

### Входни данни

### Изходни данни

### Примерен вход и изход

### Насоки и подсказки

### Тестване в Judge системата




