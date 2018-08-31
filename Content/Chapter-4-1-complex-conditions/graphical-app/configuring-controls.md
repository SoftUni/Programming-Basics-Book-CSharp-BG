#### Конфигуриране на контролите

Задаваме следните препоръчителни настройки на контролите:

* За **главната форма (`Form`)**, която съдържа всички контроли:
  *	(name) = **`FormPointAndRectangle`**
  *	**`Text`** = **`Point and Rectangle`**
  *	**`Font.Size`** = **`12`**
  *	**`Size`** = **`700`**, **`410`**
  *	**`MinimumSize`** = **`500`**, **`400`**
  *	**`FormBorderStyle`** = **`FixedSingle`**
* За **полетата за въвеждане на число (`NumericUpDown`)**:
  *	(name) = **`numericUpDownX1`**; **`numericUpDownY1`**; **`numericUpDownX2`**; **`numericUpDownY2`**; **`numericUpDownX`**; **`numericUpDownY`**
  *	**`Value`** = **`2`**; **`-3`**; **`12`**; **`3`**; **`8`**; **`-1`**
  *	**`Minimum`** = **`-100000`**
  *	**`Maximum`** = **`100000`**
  *	**`DecimalPlaces`** = **`2`**
* За **бутона (`Button`)** за **визуализация** на правоъгълника и точката:
  *	(name) = **`buttonDraw`**
  *	**Text** = **`Draw`**
* За **текстовия блок за резултата (`Label`)**:
  *	(name) = **`labelLocation`**
  *	**`AutoSize`** = **`false`**
  *	**`BackColor`** = **`PaleGreen`**
  *	**`TextAlign`** = **`MiddleCenter`**
* За **полето с чертежа (`PictureBox`)**:
  *	(name) = **`pictureBox`**
  *	**`Anchor`** = **`Top`**, **`Bottom`**, **`Left`**, **`Right`**