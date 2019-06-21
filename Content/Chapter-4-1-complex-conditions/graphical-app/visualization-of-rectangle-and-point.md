#### Визуализация на правоъгълника и точката

Остава да се имплементира най-сложната част: визуализация на правоъгълника и точката в контролата **`pictureBox`** с преоразмеряване. Може да си помогнем с **кода по-долу**, който прави малко изчисления и рисува син правоъгълник и тъмносиньо кръгче (точката) според зададените във формата координати. За съжаление сложността на кода надхвърля изучавания до момента материал и е сложно да се обясни в детайли как точно работи. Оставени са коментари за ориентация. Това е пълната версия на действието **`Draw()`**:

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

  // Calculate the scale factor (ratio) for the diagram holding the
  // rectangle and point in order to fit them well in the picture box
  var minX = Min(x1, x2, x);
  var maxX = Max(x1, x2, x);
  var minY = Min(y1, y2, y);
  var maxY = Max(y1, y2, y);
  var diagramWidth = maxX - minX;
  var diagramHeight = maxY - minY;
  var ratio = 1.0m;
  var offset = 10;
  if (diagramWidth != 0 && diagramHeight != 0)
  {
    var ratioX = (pictureBox.Width - 2 * offset - 1) / diagramWidth;
    var ratioY = (pictureBox.Height - 2 * offset - 1) / diagramHeight;
    ratio = Math.Min(ratioX, ratioY);
  }

  // Calculate the scaled rectangle coordinates
  var rectLeft = offset + (int)Math.Round((Math.Min(x1, x2) - minX) * ratio);
  var rectTop = offset + (int)Math.Round((Math.Min(y1, y2) - minY) * ratio);
  var rectWidth = (int)Math.Round(Math.Abs(x2 - x1) * ratio);
  var rectHeight = (int)Math.Round(Math.Abs(y2 - y1) * ratio);
  var rect = new Rectangle(rectLeft, rectTop, rectWidth, rectHeight);

  // Calculate the scalled point coordinates
  var pointX = (int)Math.Round(offset + (x - minX) * ratio);
  var pointY = (int)Math.Round(offset + (y - minY) * ratio);
  var pointRect = new Rectangle(pointX - 2, pointY - 2, 5, 5);

  // Draw the rectangle and point
  pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
  using (var g = Graphics.FromImage(pictureBox.Image))
  {
    // Draw diagram background (white area)
    g.Clear(Color.White);

    // Draw the rectangle (scalled to the picture box size)
    var pen = new Pen(Color.Blue, 3);
    g.DrawRectangle(pen, rect);

    // Draw the point (scalled to the picture box size)
    pen = new Pen(Color.DarkBlue, 5);
    g.DrawEllipse(pen, pointRect);
  }
}

private decimal Min(decimal val1, decimal val2, decimal val3)
{
  return Math.Min(val1, Math.Min(val2, val3));
}

private decimal Max(decimal val1, decimal val2, decimal val3)
{
  return Math.Max(val1, Math.Max(val2, val3));
}
```

В горния код се срещат доста **преобразувания на типове**, защото се работи с различни типове числа (десетични числа, реални числа и цели числа) и понякога се изисква да се преминава между тях.