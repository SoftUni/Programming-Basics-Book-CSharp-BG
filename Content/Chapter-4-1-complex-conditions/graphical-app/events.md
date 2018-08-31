#### Събития

Следва да хванем следните **събития**, за да напишем C# кода, който ще се изпълни при настъпването им:

*	Събитието **`Click`** на бутона **`buttonDraw`** (извиква се при натискане на бутона).
*	Събитието **`ValueChanged`** на контролите за въвеждане на числа **`numericUpDownX1`**, **`numericUpDownY1`**, **`numericUpDownX2`**, **`numericUpDownY2`**, **`numericUpDownX`** и **`numericUpDownY`** (извиква се при промяна на стойността в контролата за въвеждане на число).
*	Събитието **`Load`** на формата **`FormPointAndRectangle`** (извиква се при стартиране на приложението, преди да се появи главната форма на екрана).
*	Събитието **`Resize`** на формата **`FormPointAndRectangle`** (извиква се при промяна на размера на главната формата).

Всички изброени по-горе събития ще изпълняват едно и също действие – **`Draw()`**, което ще визуализира правоъгълника и точката и ще показва дали тя е вътре, вън или на някоя от страните. Кодът трябва да изглежда така: 

```csharp
private void buttonDraw_Click(object sender, EventArgs e)
{
    Draw();
}

private void FormPointAndRectangle_Load(object sender, EventArgs e)
{
    Draw();
}

private void FormPointAndRectangle_Resize(object sender, EventArgs e)
{
    Draw();
}

private void numericUpDownX1_ValueChanged(object sender, EventArgs e)
{
    Draw();
}

 /* TODO: implement in the same way event handlers
    numericUpDownY1_ValueChanged, 
    numericUpDownX2_ValueChanged, 
    numericUpDownY2_ValueChanged, 
    numericUpDownX_ValueChanged and 
    numericUpDownY_ValueChanged */

private void Draw()
{
    // TODO: implement this a bit later …
}
```