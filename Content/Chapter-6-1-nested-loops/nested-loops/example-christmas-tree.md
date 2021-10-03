### Пример: коледна елха

Да се напише програма, която въвежда число **n** (1 ≤ n ≤ 100) и печата коледна елха с височина **n+1**.

|Вход|Изход|Вход|Изход|
|---|---|---|---|
|1|<code>&nbsp;&nbsp;&#124;&nbsp;&nbsp;</code><br><code>\*&nbsp;&#124;&nbsp;\*</code>|2|<code>&nbsp;&nbsp;&nbsp;&#124;&nbsp;&nbsp;&nbsp;</code><br><code>&nbsp;\*&nbsp;&#124;&nbsp;\*&nbsp;</code><br><code>\*\*&nbsp;&#124;&nbsp;\*\*</code>|

|Вход|Изход|Вход|Изход|
|---|---|---|---|
|3|<code>&nbsp;&nbsp;&nbsp;&nbsp;&#124;&nbsp;&nbsp;&nbsp;&nbsp;</code><br><code>&nbsp;&nbsp;\*&nbsp;&#124;&nbsp;\*&nbsp;&nbsp;</code><br><code>&nbsp;\*\*&nbsp;&#124;&nbsp;\*\*&nbsp;</code><br><code>\*\*\*&nbsp;&#124;&nbsp;\*\*\*</code>|4|<code>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&#124;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</code><br><code>&nbsp;&nbsp;&nbsp;\*&nbsp;&#124;&nbsp;\*&nbsp;&nbsp;&nbsp;</code><br><code>&nbsp;&nbsp;\*\*&nbsp;&#124;&nbsp;\*\*&nbsp;&nbsp;</code><br><code>&nbsp;\*\*\*&nbsp;&#124;&nbsp;\*\*\*&nbsp;</code><br><code>\*\*\*\*&nbsp;&#124;&nbsp;\*\*\*\*</code>|

#### Насоки и подсказки

От примерите виждаме, че **елхата** може да бъде **разделена** на **три** логически части. **Първата** част са **звездичките и празните места преди и след тях**, **средната** част е **` | `**, а **последната** част са отново **звездички**, като този път **празни** места има само **преди** тях. Разпечатването може да бъде постигнато само с **един цикъл** и конструктора **`new string(…)`**, който ще използваме един път за звездичките и един път за интервалите. 

![](/assets/chapter-6-images/07.Christmas-tree-01.png)

#### Тестване в Judge системата

Тествайте решението си тук: [https://judge.softuni.org/Contests/Practice/Index/512#6](https://judge.softuni.org/Contests/Practice/Index/512#6).