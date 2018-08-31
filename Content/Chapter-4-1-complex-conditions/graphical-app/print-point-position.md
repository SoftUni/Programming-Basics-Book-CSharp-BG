#### Печатане на информация къде е точката спрямо правоъгълника

Нека започнем от по-лесната част: **печат на информация къде е точката спрямо правоъгълника** (Inside, Outside или Border). Кодът трябва да изглежда така:

```csharp
private void Draw()
{
    // Get the rectangle and point coordinates from the form
    var x1 = this.numericUpDownX1.Value;
    var y1 = this.numericUpDownY1.Value;
    var x2 = this.numericUpDownX2.Value;
    var y2 = this.numericUpDownY2.Value;
    var x = this.numericUpDownX.Value;
    var y = this.numericUpDownY.Value;

    // Display the location of the point: Inside / Border / Outside
    DisplayPointLocation(x1, y1, x2, y2, x, y);
}

private void DisplayPointLocation(
    decimal x1, decimal y1, decimal x2, decimal y2, decimal x, decimal y)
{
    var left = Math.Min(x1, x2);
    var right = Math.Max(x1, x2);
    var top = Math.Min(y1, y2);
    var bottom = Math.Max(y1, y2);
    if (x > left && x < right && …)
    {
        this.labelLocation.Text = "Inside";
        this.labelLocation.BackColor = Color.LightGreen;
    }
    else if (… || y < top || y > bottom)
    {
        this.labelLocation.Text = "Outside";
        this.labelLocation.BackColor = Color.LightSalmon;
    }
    else
    {
        this.labelLocation.Text = "Border";
        this.labelLocation.BackColor = Color.Gold;
    }
}
```
Горният код взима координатите на правоъгълника и точките и проверява дали точката е вътре, вън или на страната на правоъгълника. При    визуализацията на резултата се сменя и цвета на фона на текстовия блок, който го съдържа.

Помислете как **да допишете** недовършените (нарочно) условия в **`if` проверките**! Кодът по-горе **нарочно не се компилира**, защото целта му е да помислите как и защо работи и да **допишете сами липсващите части**.