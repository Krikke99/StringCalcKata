# kata-stringcalculator

![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)
[![Language](https://img.shields.io/github/languages/top/krikke99/StringCalcKata?style=flat)](https://github.com/krikke99/StringCalcKata)
[![Last commit](https://img.shields.io/github/last-commit/krikke99/StringCalcKata.svg?style=flat)](https://github.com/krikke99/StringCalcKata/commits)
[![GitHub commit activity](https://img.shields.io/github/commit-activity/m/krikke99/StringCalcKata)](https://github.com/krikke99/StringCalcKata/commits)
[![Github Stars](https://img.shields.io/github/stars/krikke99/StringCalcKata?style=flat&logo=github)](https://github.com/krikke99/StringCalcKata/stargazers)
[![Github Forks](https://img.shields.io/github/forks/krikke99/StringCalcKata?style=flat&logo=github)](https://github.com/krikke99/StringCalcKata/network/members)
[![Github Watchers](https://img.shields.io/github/watchers/krikke99/StringCalcKata?style=flat&logo=github)](https://github.com/krikke99/StringCalcKata)
[![GitHub contributors](https://img.shields.io/github/contributors/krikke99/StringCalcKata)](https://github.com/krikke99/StringCalcKata/graphs/contributors)

## Credits

Author: **Roy Osherove** - **TDD Kata 1 - String Calculator**

Source: [Go to original source](https://osherove.com/tdd-kata-1)

---

## Clarification

The japanese pronunciation is "katà", not "kata"!
"kata" means "shoulder".

Ref: [Judo Kata - Pedagogy](https://en.wikipedia.org/wiki/Judo#Pedagogy)

- **Randori** (Free practice)
- **Katà** (Forms)

---

## Before you start:

- Try not to read ahead.
- Do one task at a time. The trick is to learn to work incrementally.
- Make sure you only test for correct inputs. there is no need to test for invalid inputs for this kata

## String Calculator Katà

### 1. Create a simple String calculator with a method signature:

`int Add(string numbers)`

### 2. Add up to two numbers

The method can take up to two numbers, separated by commas, and will return their sum.

- For example "" or `"1"` or `"1,2"` as inputs.
- For an empty string it will return 0

#### Hints:

- Start with the simplest test case of an empty string and move to one and two numbers.
- Remember to solve things as simply as possible so that you force yourself to write tests you did not think about.
- Remember to refactor after each passing test

### 3. Unknown amount of numbers

Allow the Add method to handle an unknown amount of numbers

### 4. Allow the Add method to handle new lines between numbers (instead of commas).

The following input is ok: `"1\n2,3"` (will equal 6)

The following input is NOT ok: `"1,\n"` (not need to prove it - just clarifying)

### 5. Support different delimiters

To change a delimiter, the beginning of the string will contain a separate line that looks like this: `"//[delimiter]\n[numbers…]"`

For example `"//;\n1;2"` should return three where the default delimiter is ‘;’ .

The first line is optional. all existing scenarios should still be supported

### 6. Negatives not allowed

Calling Add with a negative number will throw an exception `"negatives not allowed"` - and the negative that was passed.

If there are multiple negatives, show all of them in the exception message.

---

**STOP HERE if you are a beginner.**

**Continue if you can finish the steps so far in less than 30 minutes.**

---

### 7. Numbers bigger than 1000

... should be ignored, so adding 2 + 1001 = 2

### 8. Delimiters can be of any length

With the following format: "//[delimiter]\n" for example: "//[***]\n1**_2_**3" should return 6

### 9. Allow multiple delimiters

Like this: `"//[delim1][delim2]\n"` for example `"//[\*][%]\n1\*2%3"` should return 6.

---

Make sure you can also handle multiple delimiters with length longer than one char
