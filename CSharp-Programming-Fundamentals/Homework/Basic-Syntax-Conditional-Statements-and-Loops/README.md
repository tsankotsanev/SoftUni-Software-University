<h1 id="exercise-intro-and-basic-syntax">Exercise: Intro and Basic Syntax</h1>
<p>Problems for exercises and homework for the <u><a href="https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019">"C# Fundamentals" course @ SoftUni</a><br />
</u>You can check your solutions in <a href="https://judge.softuni.bg/Contests/1204"><u>Judge</u></a></p>
<h2 id="ages">Ages</h2>
<p>Write a program that determines whether based on the given age a person is: baby, child, teenager, adult, elder. The bounders are:</p>
<ul>
<li><p><strong>0-2 – baby;</strong></p></li>
<li><p><strong>3-13 – child;</strong></p></li>
<li><p><strong>14-19 – teenager;</strong></p></li>
<li><p><strong>20-65 – adult;</strong></p></li>
<li><p><strong>&gt;=66 – elder;</strong></p></li>
<li><p>All the values are <strong>inclusive</strong>.</p></li>
</ul>
<h3 id="examples">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>20</td>
<td>adult</td>
</tr>
<tr class="even">
<td>1</td>
<td>baby</td>
</tr>
<tr class="odd">
<td>100</td>
<td>elder</td>
</tr>
</tbody>
</table>
<h2 id="divison">Divison</h2>
<p>You will be given an integer and you have to print on the console whether that number is divisible by the following numbers: 2, 3, 6, 7, 10. You should <strong>always take the bigger division</strong>. If the number is divisible by both <strong>2</strong> and <strong>3</strong> it is also divisible by <strong>6</strong> and you should print only the division by 6. If a number is divisible by <strong>2</strong> it is sometimes also divisible by <strong>10</strong> and you should print the division by 10. If the number is not divisible by any of the given numbers print “<strong>Not divisible”.</strong> Otherwise print “<strong>The number is divisible by {number}</strong>”.</p>
<h3 id="examples-1">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>30</td>
<td>The number is divisible by 10</td>
</tr>
<tr class="even">
<td>15</td>
<td>The number is divisible by 3</td>
</tr>
<tr class="odd">
<td>12</td>
<td>The number is divisible by 6</td>
</tr>
<tr class="even">
<td>1643</td>
<td>Not divisible</td>
</tr>
</tbody>
</table>
<h2 id="vacation">Vacation</h2>
<p>You are given a group of people, type of the group, on which day of the week they are going to stay. Based on that information calculate how much they have to pay and print that price on the console. Use the table below. In each cell is the price for a <strong>single person</strong>. The output should look like that: “<strong>Total price: {price}</strong>”. The price should be formatted to the second decimal point.</p>
<table>
<thead>
<tr class="header">
<th></th>
<th><strong>Friday</strong></th>
<th><strong>Saturday</strong></th>
<th><strong>Sunday</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Students</strong></td>
<td>8.45</td>
<td>9.80</td>
<td>10.46</td>
</tr>
<tr class="even">
<td><strong>Business</strong></td>
<td>10.90</td>
<td>15.60</td>
<td>16</td>
</tr>
<tr class="odd">
<td><strong>Regular</strong></td>
<td>15</td>
<td>20</td>
<td>22.50</td>
</tr>
</tbody>
</table>
<p>There are also discounts based on some conditions:</p>
<ul>
<li><p><strong>Students –</strong> if the group is bigger than or equal to 30 people you should reduce the <strong>total</strong> price by 15%</p></li>
<li><p><strong>Business –</strong> if the group is bigger than or equal to 100 people <strong>10</strong> of them can stay <strong>for free.</strong></p></li>
<li><p><strong>Regular –</strong> if the group is bigger than or equal to 10 and less than or equal to 20 reduce the <strong>total</strong> price by 5%</p></li>
</ul>
<blockquote>
<p><strong>You should reduce the prices in that EXACT order</strong></p>
</blockquote>
<h3 id="examples-2">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>30</p>
<p>Students</p>
<p>Sunday</p></td>
<td>Total price: 266.73</td>
</tr>
<tr class="even">
<td><p>40</p>
<p>Regular</p>
<p>Saturday</p></td>
<td>Total price: 800.00</td>
</tr>
</tbody>
</table>
<h2 id="print-and-sum">Print and Sum</h2>
<p>Write a program to display numbers from given start to given end and their sum. All the numbers will be integers. On the first line you will receive the start, on the second the end.</p>
<h3 id="examples-3">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>5</p>
<p>10</p></td>
<td><p>5 6 7 8 9 10</p>
<p>Sum: 45</p></td>
</tr>
<tr class="even">
<td><p>0</p>
<p>26</p></td>
<td><p>0 1 2 … 26</p>
<p>Sum: 351</p></td>
</tr>
<tr class="odd">
<td><p>50</p>
<p>60</p></td>
<td><p>50 51 52 53 54 55 56 57 58 59 60</p>
<p>Sum: 605</p></td>
</tr>
</tbody>
</table>
<h2 id="login">Login</h2>
<p>You will be given a string representing an username. The password will be that username reversed. Until you receive the correct password print on the console “<strong>Incorrect password. Try again.</strong>”. When you receive the correct password print “<strong>User {username} logged in.</strong>” However on the fourth try if the password is still not correct print “<strong>User {username} blocked!</strong>” and end the program.</p>
<h3 id="examples-4">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Acer</p>
<p>login</p>
<p>go</p>
<p>let me in</p>
<p>recA</p></td>
<td><p>Incorrect password. Try again.</p>
<p>Incorrect password. Try again.</p>
<p>Incorrect password. Try again.</p>
<p>User Acer logged in.</p></td>
</tr>
<tr class="even">
<td><p>momo</p>
<p>omom</p></td>
<td>User momo logged in.</td>
</tr>
<tr class="odd">
<td><p>sunny</p>
<p>rainy</p>
<p>cloudy</p>
<p>sunny</p>
<p>not sunny</p></td>
<td><p>Incorrect password. Try again.</p>
<p>Incorrect password. Try again.</p>
<p>Incorrect password. Try again.</p>
<p>User sunny blocked!</p></td>
</tr>
</tbody>
</table>
<h2 id="strong-number">Strong Number</h2>
<p>Write a program to check if a given number is a strong number or not. A number is strong if the sum of the Factorial of each digit is equal to the number. For example 145 is a strong number, because <strong>1! + 4! + 5! = 145.</strong> Print "<strong>yes</strong>" if the number is strong and “<strong>no</strong>” if the number is not strong.</p>
<h3 id="examples-5">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>2</td>
<td>yes</td>
</tr>
<tr class="even">
<td>3451</td>
<td>no</td>
</tr>
<tr class="odd">
<td>40585</td>
<td>yes</td>
</tr>
</tbody>
</table>
<h2 id="vending-machine">Vending Machine</h2>
<p>You task is to calculate the total price of a purchase from a vending machine. Until you receive “<strong>Start</strong>” you will be given different coins that are being inserted in the machine. You have to sum them in order to have the total money inserted. There is a problem though. Your vending machine only works with <strong>0.1</strong>, <strong>0.2</strong>, <strong>0.5, 1, and 2</strong> coins. If someone tries to insert some other coins you have to display “<strong>Cannot accept {money}</strong>” and <strong>not</strong> add it to the total money. On the next few lines until you receive “<strong>End</strong>” you will be given products to purchase. Your machine has however only “<strong>Nuts</strong>”, “<strong>Water</strong>”, “<strong>Crisps</strong>”, “<strong>Soda</strong>”, “<strong>Coke</strong>”. The prices are: <strong>2.0</strong>, <strong>0.7</strong>, <strong>1.5</strong>, <strong>0.8</strong>, <strong>1.0</strong> respectively. If the person tries to purchase a not existing product print “<strong>Invalid product</strong>”. Be careful that the person may try to purchase a product they don’t have the money for. In that case print “<strong>Sorry, not enough money</strong>”. If the person purchases a product successfully print “<strong>Purchased {product name}</strong>”. After the “End” command print the money that are left formatted to the second decimal point in the format “<strong>Change: {money left}</strong>”.</p>
<h3 id="examples-6">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>1</p>
<p>1</p>
<p>0.5</p>
<p>0.6</p>
<p>Start</p>
<p>Coke</p>
<p>Soda</p>
<p>Crisps</p>
<p>End</p></td>
<td><p>Cannot accept 0.6</p>
<p>Purchased coke</p>
<p>Purchased soda</p>
<p>Sorry, not enough money</p>
<p>Change: 0.70</p></td>
</tr>
</tbody>
</table>
<h2 id="triangle-of-numbers">Triangle of Numbers</h2>
<p>Write a program, which receives a number – <strong>n</strong>, and prints a triangle from <strong>1 to n</strong> as in the exampls.</p>
<h3 id="constraints">Constraints</h3>
<ul>
<li><p><strong>n</strong> will be in the interval [<strong>1...20]</strong>.</p></li>
</ul>
<h3 id="examples-7">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th></th>
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th></th>
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>3</td>
<td><p>1</p>
<p>2 2</p>
<p>3 3 3</p></td>
<td></td>
<td>5</td>
<td><p>1</p>
<p>2 2</p>
<p>3 3 3</p>
<p>4 4 4 4</p>
<p>5 5 5 5 5</p></td>
<td></td>
<td>6</td>
<td><p>1</p>
<p>2 2</p>
<p>3 3 3</p>
<p>4 4 4 4</p>
<p>5 5 5 5 5</p>
<p>6 6 6 6 6 6</p></td>
</tr>
</tbody>
</table>
<h2 id="padawan-equipment"><strong>*Padawan Equipment</strong></h2>
<p>Yoda is starting his newly created Jedi academy. So, he asked master Ivan Cho to <strong>buy</strong> the <strong>needed equipment</strong>. The number of <strong>items</strong> depends on <strong>how many students will sign up</strong>. The equipment for the Padawan contains <strong>lightsabers, belts and robes</strong>.</p>
<p>You will be given <strong>the amount of money Ivan Cho has</strong>, the <strong>number of students</strong> and the <strong>prices of each item</strong>. You have to help Ivan Cho <strong>calculate</strong> if the <strong>money</strong> he has is <strong>enough to buy all of the equipment</strong>, or how much more money he needs.<br />
Because the lightsabres sometimes brake, Ivan Cho should <strong>buy 10% more</strong>, <strong>rounded up</strong> to the next integer. Also, every <strong>sixth belt is free</strong>.</p>
<h3 id="input-constraints">Input / Constraints</h3>
<p>The input data should be read from the console. It will consist of <strong>exactly 5 lines</strong>:</p>
<ul>
<li><blockquote>
<p>The <strong>amount of money</strong> Ivan Cho has – <strong>floating-point number</strong> in <strong>range [0.00…1,000.00]</strong></p>
</blockquote></li>
<li><blockquote>
<p>The <strong>count of students – integer in range [0…100]</strong></p>
</blockquote></li>
<li><blockquote>
<p>The <strong>price of lightsabers</strong> for a <strong>single sabre – floating-point number</strong> in <strong>range [0.00…100.00]</strong></p>
</blockquote></li>
<li><blockquote>
<p>The <strong>price of robes</strong> for a <strong>single robe – floating-point number</strong> in <strong>range [0.00…100.00]</strong></p>
</blockquote></li>
<li><blockquote>
<p>The <strong>price of belts</strong> for a <strong>single</strong> <strong>belt – floating-point number</strong> in <strong>range [0.00…100.00]</strong></p>
</blockquote></li>
</ul>
<p>The <strong>input data will always be valid</strong>. <strong>There is no need to check it explicitly</strong>.</p>
<h3 id="output">Output</h3>
<p>The output should be printed on the console.</p>
<ul>
<li><p><strong>If the calculated price of the equipment is less or equal to the money Ivan Cho has:</strong></p>
<ul>
<li><p>"<strong>The money is enough - it would cost {the cost of the equipment}lv.</strong>"</p></li>
</ul></li>
<li><p><strong>If the calculated price of the equipment is more than the money Ivan Cho has:</strong></p>
<ul>
<li><p>"<strong>Ivan Cho will need {neededMoney}lv more.</strong>"</p></li>
</ul></li>
<li><p><strong>All prices</strong> must be <strong>rounded to two digits after the decimal point.</strong></p></li>
</ul>
<h3 id="examples-8">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th><strong>Comments</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>100</p>
<p>2</p>
<p>1.0</p>
<p>2.0</p>
<p>3.0</p></td>
<td>The money is enough - it would cost 13.00lv.</td>
<td><p>Needed equipment for 2 padawans :</p>
<p>sabresPrice*(studentsCount + 10%) + robesPrice * (studentsCount) + beltsPrice*(studentsCount-freeBelts)</p>
<p>1*(3) + 2*(2) + 3*(2) = 13.00</p>
<p>13.00 &lt;= 100 – the money will be enough.</p></td>
</tr>
<tr class="even">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
<td><strong>Comments</strong></td>
</tr>
<tr class="odd">
<td><p>100</p>
<p>42</p>
<p>12.0</p>
<p>4.0</p>
<p>3.0</p></td>
<td>Ivan Cho will need 737.00lv more.</td>
<td><p>Needed equipment for 42 padawans:</p>
<p>12*47 + 4*42 + 3*35 = 837.00</p>
<p>837 &gt; 100 – need 737.00 lv. more.</p></td>
</tr>
</tbody>
</table>
<p><em>...May the force<br />
be with you...</em></p>
<h2 id="rage-expenses">*Rage Expenses</h2>
<p>As a MOBA challenger player, Pesho has the bad habit to trash his PC when he loses a game and rage quits. His gaming setup consists of <strong>headset, mouse, keyboard and display</strong>. You will receive Pesho`s <strong>lost games count</strong>.</p>
<p>Every <strong>second</strong> lost game, Pesho trashes his <strong>headset.</strong></p>
<p>Every <strong>third</strong> lost game, Pesho trashes his <strong>mouse</strong>.</p>
<p>When Pesho trashes <strong>both</strong> <strong>his mouse and headset</strong> in the <strong>same</strong> lost game, he also trashes his <strong>keyboard</strong>.</p>
<p><strong>Every</strong> <strong>second time, when he trashes his keyboard</strong>, he also trashes his <strong>display</strong>.</p>
<p>You will receive the price of each item in his gaming setup. Calculate his rage expenses for renewing his gaming equipment.</p>
<h3 id="input-constraints-1">Input / Constraints</h3>
<ul>
<li><p>On the first input line - <strong>lost games count</strong> – integer in the range <strong>[0, 1000]</strong>.</p></li>
<li><p>On the second line – <strong>headset price</strong> - floating point number in range <strong>[0, 1000]</strong>.</p></li>
<li><p>On the third line – <strong>mouse price</strong> - floating point number in range <strong>[0, 1000]</strong>.</p></li>
<li><p>On the fourth line – <strong>keyboard price</strong> - floating point number in range <strong>[0, 1000]</strong>.</p></li>
<li><p>On the fifth line – <strong>display price</strong> - floating point number in range <strong>[0, 1000]</strong>.</p></li>
</ul>
<h3 id="output-1">Output</h3>
<ul>
<li><p>As output you must print Pesho`s total expenses: <strong>"Rage expenses: {expenses} lv."</strong></p></li>
</ul>
<ul>
<li><p>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong>.</p></li>
</ul>
<h3 id="examples-9">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th><strong>Comment</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>7</p>
<p>2</p>
<p>3</p>
<p>4</p>
<p>5</p></td>
<td>Rage expenses: 16.00 lv.</td>
<td><p>Trashed headset -&gt; 3 times</p>
<p>Trashed mouse -&gt; 2 times</p>
<p>Trashed keyboard -&gt; 1 time</p>
<p>Total: 6 + 6 + 4 = 16.00 lv;</p></td>
</tr>
<tr class="even">
<td><p>23</p>
<p>12.50</p>
<p>21.50</p>
<p>40</p>
<p>200</p></td>
<td>Rage expenses: 608.00 lv.</td>
<td></td>
</tr>
</tbody>
</table>
