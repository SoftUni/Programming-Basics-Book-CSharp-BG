#### Конфигуриране на контролите

Задаваме следните **настройки на контролите**:

* **За главната форма** (**`Form`**), която съдържа всички контроли:
  * **`(name)`** = **`FormConverter`**
  * **`Text`** = "**`Currency Converter`**"
  * **`Font.Size`** = **`12`**
  * **`MaximizeBox`** = **`False`**
  * **`MinimizeBox`** = **`False`**
  * **`FormBorderStyle`** = **`FixedSingle`**
<br>

* За **полето за въвеждане на число** (**`NumericUpDown`**):
  * **`(name)`** = **`numericUpDownAmount`**
  * **`Value`** = **`1`**
  * **`Minimum`** = **`0`**
  * **`Maximum`** = **`1000000`**
  * **`TextAlign`** = **`Right`**
  * **`DecimalPlaces`** = **`2`**
<br>  

* За **падащия списък с валутите** (**`ComboBox`**):
  * **`(name)`** = **`comboBoxCurrency`**
  * **`DropDownStyle`** = **`DropDownList`**
  * **`Items`** =
    * **EUR**
    * **USD**
    * **GBP**
<br> 

* За **текстовия блок за резултата** (**`Label`**):
  * **`(name)`** = **`labelResult`**
  * **`AutoSize`** = **`False`**
  * **`BackColor`** = **`PaleGreen`**
  * **`TextAlign`** = **`MiddleCenter`**
  * **`Font.Size`** = **`14`**
  * **`Font.Bold`** = **`True`**