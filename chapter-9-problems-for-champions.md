# Глава 9. Задачи за шампиони (част I)

В настоящата глав ще предложим на читателя няколко малко по-трудни задачи, които имат за цел да развият алгоритмични умения и програмни техники за решаване на задачи с по-висока сложност. Задачите са върхи изучавания в книгата учебен материал, но по трудност надвишават обучайните задачи от приемните изпити в СофтУни. Ако искате да сте шампиони по основи на програмирането, ви препоръчваме да се научите да решавате такива по-сложни задачи, за да ви е лесно по изпитите.

* Magic Dates
* Five Special Letters

## Crossing sequences

Judge Link: https://judge.softuni.bg/Contests/Practice/Index/5#3

**_Raw_**

We’re dealing with two sequences: the Tribonacci sequence, where every number is the sum of the previous three, and the number spiral, defined by walking over a grid of numbers as a spiral (right, down, left, up, right, down, up, left, …) and writing down the current number every time we take a turn. Find the first number that appears in both sequences.

Example

Let the Tribonacci sequence start with 1, 2 and 3. It will therefore contain the numbers 1, 2, 3, 6, 11, 20, 37, 68, 125, 230, 423, 778, 1431, 2632, 4841, 8904, 16377, 30122, 55403, 101902, and so on.
Also, let the number spiral start with 5 and have a step of 2; it then contains he numbers 5, 7, 9, 13, 17, 23, 29, 37, etc. Since 37 is the first number that is both in the Tribonacci sequence and in the spiral, it is the answer.

Input

The input data should be read from the console.
•	On the first three lines of input, you will read three integers, representing the three initial numbers of the Tribonacci sequence.
•	On the next two lines of input, you will read two integers, representing the initial number and the step of each grid cell for the number spiral.
The input data will always be valid and in the format described. There is no need to check it.

Output

The output must be printed on the console.
On the single line of output you must print the smallest number that appears in both sequences. If no number in the range [1 … 1 000 000] exists that appears in both sequences, print "No".

Constraints

* All numbers in the input will be in the range [1 … 1 000 000].
* Allowed work time for your program: 0.25 seconds.
* Allowed memory: 16 MB.

Examples


TODO: описание

TODO: картинка

### Входни данни

### Изходни данни

### Примерен вход и изход

### Насоки и подсказки

### Тестване в Judge системата


## Magic Dates

Judge Link: https://judge.softuni.bg/Contests/Practice/Index/6#3

**_Raw_**

Consider we are given a date in format dd-mm-yyyy, e.g. 17-03-2007. We calculate the weight of this date by joining together all its digits, multiplying each digit by each of the other digits and finally sum all obtained products. In our case we will have 8-digits: 17032007, so the weight is 1*7 + 1*0 + 1*3 + 1*2 + 1*0 + 1*0 + 1*7 + 7*0 + 7*3 + 7*2 + 7*0 + 7*0 + 7*7 + 0*3 + 0*2 + 0*0 + 0*0 + 0*7 + 3*2 + 3*0 + 3*0 + 3*7 + 2*0 + 2*0 + 2*7 + 0*0 + 0*7 + 0*7 = 144.

Your task is to write a program that finds all magic dates: dates between two fixed years matching given magic weight. The dates should be printed in increasing order in format dd-mm-yyyy. We use the traditional calendar (years have 12 months, each having 28, 29, 30 or 31 days, etc.)

Input

The input data should be read from the console. It consists of 3 lines:
•	The first line holds an integer number – start year.
•	The first line holds an integer number – end year.
•	The first line holds an integer number – magic weight.
The input data will always be valid and in the format described. There is no need to check it explicitly.

Output

The output should be printed on the console as a sequence of dates in format dd-mm-yyyy in alphabetical order. Each string should stay on a separate line. In case no magic dates exist, print “No”.

Constraints

* The start and end year are integers in the range [1900-2100].
* The magic weight is an integer number in range [1…1000].
* Allowed working time for your program: 0.25 seconds.
* Allowed memory: 16 MB.

Examples


TODO: описание

TODO: картинка

### Входни данни

### Изходни данни

### Примерен вход и изход

### Насоки и подсказки

### Тестване в Judge системата


## Five Special Letters

Judge Link: https://judge.softuni.bg/Contests/Practice/Index/7#3

**_Raw_**

We are given two numbers: start and end. Write a program to generate all sequences of 5 letters, each from the set { 'a', 'b', 'c', 'd', 'e' }, such that the weight of these 5 letters is a number in the range [start … end] inclusively. Print them in alphabetical order, in a single line, separated by a space.

The weight of a single letter is calculated as follows:  weight('a') = 5; weight('b') = -12;  weight('c') = 47;  weight('d') = 7;  weight('e') = -32. The weight of a sequence of letters c1c2…cn is the calculated by first removing all repeating letters (from right to left) and then calculate the formula:
weight(c1c2…cn) = 1*weight(c1) + 2*weight(c2) + … + n*weight(cn)

For example, the weight of "bcddc" is calculated as follows: First we remove the repeating letters and we get "bcd". Then we apply the formula: 1*weight('b') + 2*weight('c') + 3*weight('d') = 1*(-12) + 2*47 + 3*7 = 103. Another example: weight("cadea") = weight("cade") = 1*47 + 2*5 + 3*7 - 4*32 = -50.

Input

The input data should be read from the console. It will consist of 2 lines:
•	The number start stays at the first line.
•	The number end stays at the second line.
The input data will always be valid and in the format described. There is no need to check it explicitly.

Output

The output should be printed on the console as a sequence of strings in alphabetical order. Each string should be separated than the next string by a single space. In case no 5-letter strings exist with a weight in the specified range, print “No”.

Constraints

* The numbers start and end will be an integers in the range [-10000…10000].
* Allowed working time for your program: 0.25 seconds.
* Allowed memory: 16 MB.

Examples


TODO: описание

TODO: картинка

### Входни данни

### Изходни данни

### Примерен вход и изход

### Насоки и подсказки

### Тестване в Judge системата
