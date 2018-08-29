### Графично приложение: \*\*\* Хвани бутона!

Създайте забавно графично приложение **„хвани бутона“**: една форма съдържа един бутон. При преместване на курсора на мишката върху бутона той се премества на случайна позиция. Така се създава усещане, че **„бутонът бяга от мишката и е трудно да се хване“**. При „хващане“ на бутона се извежда съобщение-поздрав.

![](/assets/chapter-2-images/14.Catch-the-button-01.png)

**Подсказка**: напишете обработчик за събитието **``Button.MouseEnter``** и премествайте бутона на случайна позиция. Използвайте генератор за случайни числа **``Random``**. Позицията на бутона се задава от свойството **``Location``**. За да бъде новата позиция на бутона в рамките на формата, можете да направите изчисления спрямо размера на формата, който е достъпен от свойството **``ClientSize``**. Можете да ползвате следния примерен код:

```csharp
private void buttonCatchMe_MouseEnter(object sender, EventArgs e)
{
    Random rand = new Random();
    var maxWidth = this.ClientSize.Width - buttonCatchMe.ClientSize.Width;
    var maxHeight = this.ClientSize.Height - buttonCatchMe.ClientSize.Height;
    this.buttonCatchMe.Location = new Point(
        rand.Next(maxWidth), rand.Next(maxHeight));
}
```