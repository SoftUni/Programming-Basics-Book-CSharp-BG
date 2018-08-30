#### Събития и обработчици на събития

Трябва да хванем следните **събития**, за да напишем C# кода, който ще се изпълни при настъпването им:

* Събитието **`ValueChanged`** на контролата за въвеждане на число **`numericUpDownAmount`**: 

![](/assets/chapter-3-images/14.Converter-04.png)

* Събитието **`Load`** на формата **`FormConverter`**
* Събитието **`SelectedIndexChanged`** на падащия списък за избор на валута **`comboBoxCurrency`**
  
Ще използваме следния **C# код** за обработка на събитията:

```csharp
private void FormConverter_Load(object sender, EventArgs e)
{
  this.comboBoxCurrency.SelectedItem = "EUR";
}
        
private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
{
  ConvertCurrency();
}
        
private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
{
  ConvertCurrency();
}
```

Задачата на горния код е да избере при стартиране на програмата валута “**EUR**” и при промяна на стойностите в полето за сума или при смяна на валутата, да изчисли резултата, извиквайки **`ConvertCurrency()`** метода.