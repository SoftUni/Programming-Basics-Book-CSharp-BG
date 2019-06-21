#### Добавяне на контроли

Подреждаме следните UI контроли във формата:

* **`NumericUpDown`** с име **`numericUpDownAmount`** – ще въвежда сумата за конвертиране
*	**`Label`** с име **`labelResult`** – ще показва резултата след конвертиране
*	Още два **`Label`** компонента, служещи единствено за статично изобразяване на текст

Графичният редактор за потребителски интерфейс може да изглежда по подобен начин:

![](/assets/chapter-2-images/13.Currency-converter-03.png)

Задаваме следните настройки на формата и на отделните контроли:

|                                             Настройка                                                 | Снимка|
|:-----------------------------------------------------------------------------------------------------:|:-----:|
|**``FormConverter``**:<br>Text = "BGN to EUR",<br>Font.Size = 12,<br>MaximizeBox = False,<br>MinimizeBox = False,<br>FormBorderStyle = FixedSingle | <img alt="formConverter" src ="/assets/chapter-2-images/13.Currency-converter-04.png" /> |
|**``numericUpDownAmount``**:<br>Value = 1,<br>Minimum = 0,<br>Maximum = 10000000,<br>TextAlign = Right,<br>DecimalPlaces = 2 | <img alt="numUpDown" src ="/assets/chapter-2-images/13.Currency-converter-05.png" /> |
|**``labelResult``**:<br>AutoSize = False,<br>BackColor = PaleGreen,<br>TextAlign = MiddleCenter,<br>Font.Size = 14,<br>Font.Bold = True| <img alt="labelResult" src ="/assets/chapter-2-images/13.Currency-converter-06.png" /> |