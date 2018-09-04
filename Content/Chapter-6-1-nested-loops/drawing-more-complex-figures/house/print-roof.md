#### Отпечатване на покрива

След като сме изчислили дължината на покрива, завъртаме цикъл от 0 до **`roofLength`**. На всяка итерация ще:
* Изчисляваме броя **тирета**, които трябва да изрисуваме. Броят ще е равен на **`(n - stars) / 2`**. Записваме го в променлива **`padding`**.

![](/assets/chapter-6-images/09.House-05.png)

* Отпечатваме на конзолата: "**тирета**" (**`padding / 2`** на брой пъти) + "**звезди**" (**`stars`** пъти) + "**тирета**" (**`padding / 2`** пъти). 

![](/assets/chapter-6-images/09.House-06.png)

* Преди да свърши итерацията на цикъла добавяме 2 към **`stars`** (броя на **звездите**).

![](/assets/chapter-6-images/09.House-07.png)

<table><tr><td><img src="/assets/alert-icon.png" style="max-width:50px" /></td>
<td>Не е добра идея да правим събирания на много на брой символни низове по показания по-горе начин, защото това води до <strong>проблеми със скоростта</strong> (performance issues). За повече информация посетете:  <a href="https://bg.wikipedia.org/wiki/%D0%9D%D0%B8%D0%B7#String_Builder">https://bg.wikipedia.org/wiki/%D0%9D%D0%B8%D0%B7#String_Builder</a></td>
</tr></table>