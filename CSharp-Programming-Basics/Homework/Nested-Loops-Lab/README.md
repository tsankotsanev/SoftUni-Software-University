<h1 id="лаб-вложени-цикли">Лаб: Вложени цикли</h1>
<p>Задачи за упражнение в клас и за домашно към курса <a href="https://softuni.bg/courses/programming-basics">"Основи на програмирането" @ СофтУни</a>.</p>
<p><strong>Тествайте</strong> решенията си в <strong>Judge системата</strong>: https://judge.softuni.bg/Contests/2385</p>
<h2 id="часовник">Часовник</h2>
<p>Напишете програма, която отпечатва <strong>часовете в денонощието от 0:0 до 23:59</strong>, всеки на отделен ред. Часовете трябва да се изписват във формат <strong>"{час}:{минути}"</strong>.</p>
<h3 id="примерен-вход-и-изход">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><em>(няма вход)</em></td>
<td><p>0:0</p>
<p>0:1</p>
<p>0:2</p>
<p>0:3</p>
<p>0:4</p>
<p>0:5</p>
<p>0:6</p>
<p>0:7</p>
<p>0:8</p>
<p>0:9</p>
<p>0:10</p>
<p>...</p>
<p>23:50</p>
<p>23:51</p>
<p>23:52</p>
<p>23:53</p>
<p>23:54</p>
<p>23:55</p>
<p>23:56</p>
<p>23:57</p>
<p>23:58</p>
<p>23:59</p></td>
</tr>
</tbody>
</table>
<h3 id="насоки">Насоки</h3>
<ol type="1">
<li><p>Създайте 2 вложени for-цикъла, с които да итерирате през всяка една минута и час от денонощието:</p></li>
</ol>
<blockquote>
<p><img src="media/image1.png" style="width:3.97149in;height:1.98958in" /></p>
</blockquote>
<ol start="2" type="1">
<li><p>Отпечатайте резултата:</p></li>
</ol>
<blockquote>
<p><img src="media/image2.png" style="width:4.90069in;height:2.15031in" /></p>
</blockquote>
<h2 id="таблица-за-умножение">Таблица за умножение</h2>
<p>Отпечатайте на конзолата таблицата за умножение за числата от 1 до 10 във формат:<br />
<strong>"{първи множител} * {втори множител} = {резултат}"</strong>.</p>
<h3 id="примерен-вход-и-изход-1">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><em>(няма вход)</em></td>
<td><p>1 * 1 = 1</p>
<p>1 * 2 = 2</p>
<p>1 * 3 = 3</p>
<p>1 * 4 = 4</p>
<p>1 * 5 = 5</p>
<p>1 * 6 = 6</p>
<p>1 * 7 = 7</p>
<p>1 * 8 = 8</p>
<p>1 * 9 = 9</p>
<p>1 * 10 = 10</p>
<p>...</p>
<p>10 * 1 = 10</p>
<p>10 * 2 = 20</p>
<p>10 * 3 = 30</p>
<p>10 * 4 = 40</p>
<p>10 * 5 = 50</p>
<p>10 * 6 = 60</p>
<p>10 * 7 = 70</p>
<p>10 * 8 = 80</p>
<p>10 * 9 = 90</p>
<p>10 * 10 = 100</p></td>
</tr>
</tbody>
</table>
<h3 id="насоки-1">Насоки</h3>
<ol start="3" type="1">
<li><p>Създайте 2 вложени for-цикъла, с които да итерирате всяка възможна стойност на двата множителя от 1 до 10:</p></li>
</ol>
<p><img src="media/image3.png" style="width:3.94792in;height:1.9932in" /></p>
<ol start="4" type="1">
<li><p>Намерете произведението на двата множителя и отпечатайте резултата:</p></li>
</ol>
<blockquote>
<p><img src="media/image4.png" style="width:4.9009in;height:1.80208in" /></p>
</blockquote>
<h2 id="комбинации">Комбинации</h2>
<p>Напишете програма, която изчислява <strong>колко решения в естествените числа</strong> (включително и нулата) има уравнението:</p>
<p><strong>x1 + x2 + x3 = n</strong></p>
<p><strong>Числото n е цяло число и се въвежда от конзолата.</strong></p>
<h3 id="примерен-вход-и-изход-2">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
<th><strong>Обяснения</strong></th>
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>25</td>
<td>351</td>
<td><p>Генерираме всички комбинации от 3 числа, като първата е:</p>
<p>0+0+0=0, но понеже не е равна на 25, продължаваме:</p>
<p>0+0+1=1 – също не е 25 и т.н.</p>
<p>Стигаме до първата валидна комбинация:</p>
<p>0 + 0 + 25 = 25, увеличаваме броя на валидни комбинации с 1,втората валидна комбинация е:</p>
<p>0 + 1 + 24 = 25</p>
<p>Третата:</p>
<p>0 + 2 + 23 = 25 и т.н.</p>
<p>След генериране на всички възможни комбинации, броят на валидните е 351.</p></td>
<td>20</td>
<td>231</td>
<td>5</td>
<td>21</td>
</tr>
</tbody>
</table>
<h3 id="насоки-2">Насоки</h3>
<ol type="1">
<li><p>Прочетете входните данни – едно цяло число, въведено от потребителя и го запаметете в променлива:</p></li>
</ol>
<p><img src="media/image5.png" style="width:3.92708in;height:0.25336in" /></p>
<ol start="2" type="1">
<li><p>Създайте 3 вложени for-цикъла, с които да итерирате всяка възможна стойност на едно от 3те числа в уравнението:</p></li>
</ol>
<p><img src="media/image6.png" style="width:4.00658in;height:2.875in" /></p>
<ol start="3" type="1">
<li><p>Направете проверка в най-вътрешния вложен цикъл за стойностите на <strong>x1</strong>, <strong>x2</strong>, <strong>x3</strong> във всяка една итерация. За да бъде валидно уравнението, техният сбор трябва да е равен на <strong>n</strong>. Създайте променлива <strong>validCombinationsCount</strong>, която да пази броя на валидните комбинации и добавяйте към нея всеки път, когато генерирате такава:</p></li>
</ol>
<p><img src="media/image7.png" style="width:4.83333in;height:3.00653in" /></p>
<ol start="4" type="1">
<li><p>Накрая принтирайте броя на валидните комбинации (<strong>validCombinationsCount</strong>).</p></li>
</ol>
<h2 id="сума-от-две-числа">Сума от две числа</h2>
<p>Напишете програма която проверява <strong>всички възможни комбинации от двойка числа</strong> <strong>в интервала от две дадени числа</strong>. На изхода се отпечатва, <strong>коя поред е комбинацията</strong> чиито <strong>сбор от числата</strong> <strong>е равен</strong> на дадено <strong>магическо число</strong>. Ако няма <strong>нито една комбинация</strong> отговаряща на условието се отпечатва <strong>съобщение, че не е намерено</strong>.</p>
<h3 id="вход">Вход</h3>
<p>Входът се чете от конзолата и се състои от <strong>три реда</strong>:</p>
<ul>
<li><p><strong>Първи ред</strong> – <strong>начало на интервала</strong> – <strong>цяло число</strong> в интервала <strong>[1...999]</strong></p></li>
<li><p><strong>Втори ред</strong> – <strong>край на интервала</strong> – <strong>цяло число</strong> в интервала <strong>[по-голямо от първото число...1000]</strong></p></li>
<li><p><strong>Трети ред – магическото число – цяло число</strong> в интервала <strong>[1...10000]</strong></p></li>
</ul>
<h3 id="изход">Изход</h3>
<p>На конзолата трябва да се отпечата <strong>един ред,</strong> според резултата:</p>
<ul>
<li><p>Ако <strong>е намерена</strong> <strong>комбинация</strong> чиито <strong>сбор на числата е равен на магическото число</strong></p>
<ul>
<li><p>"Combination N:{пореден номер} ({първото число} + {второ число} = {магическото число})"</p></li>
</ul></li>
<li><p>Ако <strong>не е намерена</strong> комбинация отговаряща на условието</p>
<ul>
<li><p>"{броят на всички комбинации} combinations - neither equals {магическото число}"</p></li>
</ul></li>
</ul>
<h3 id="примерен-вход-и-изход-3">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
<th><strong>Обяснения</strong></th>
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>1</p>
<p>10</p>
<p>5</p></td>
<td>Combination N:4 (1 + 4 = 5)</td>
<td><p>Всички комбинации от две числа между 1 и 10 са:</p>
<p>1 1, 1 2, 1 3, <strong>1 4</strong>, 1 5, ... 2 1, 2 2, ... 4 9, 4 10, 5 1 ... 10 9, 10 10</p>
<p>Първата комбинация, чиито сбор на числата е равен на магическото число 5 е <strong>четвъртата (1 и 4)</strong></p></td>
<td><p>88</p>
<p>888</p>
<p>1000</p></td>
<td>Combination N:20025 (112 + 888 = 1000)</td>
</tr>
<tr class="even">
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
<td><strong>Обяснения</strong></td>
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
</tr>
<tr class="odd">
<td><p>23</p>
<p>24</p>
<p>20</p></td>
<td>4 combinations - neither equals 20</td>
<td><p>Всички комбинации от две числа между 23 и 24 са: 23 23, 23 24, 24 23, 24 24 (общо 4)</p>
<p>Няма двойки числа, чиито сбор е равен на магическото 20</p></td>
<td><p>88</p>
<p>888</p>
<p>2000</p></td>
<td>641601 combinations - neither equals 2000</td>
</tr>
</tbody>
</table>
<h2 id="пътуване">Пътуване</h2>
<p>Ани обича да пътува и иска тази година да посети <strong>няколко</strong> различни дестинации. Като си избере дестинация, ще прецени <strong>колко пари ще й трябват</strong>, за да отиде до там и ще започне да <strong>спестява</strong>. Когато е спестила <strong>достатъчно</strong>, ще може да пътува.</p>
<p>От <strong>конзолата всеки път ще се четат първо дестинацията и минималния бюджет</strong>, който ще е нужен за пътуването.</p>
<p>След това ще се четат <strong>няколко суми</strong>, които Ани спестява като работи и <strong>когато успее да събере достатъчно за пътуването, ще заминава, като на конзолата трябва да се изпише:</strong></p>
<p><strong>"Going to {дестинацията}!"</strong></p>
<p>Когато е посетила всички дестинации, които иска, <strong>вместо дестинация ще въведе "End"</strong> и програмата ще приключи.</p>
<h3 id="примерен-вход-и-изход-4">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Greece</p>
<p>1000</p>
<p>200</p>
<p>200</p>
<p>300</p>
<p>100</p>
<p>150</p>
<p>240</p>
<p>Spain</p>
<p>1200</p>
<p>300</p>
<p>500</p>
<p>193</p>
<p>423</p>
<p>End</p></td>
<td><p>Going to Greece!</p>
<p>Going to Spain!</p></td>
<td><p>France</p>
<p>2000</p>
<p>300</p>
<p>300</p>
<p>200</p>
<p>400</p>
<p>190</p>
<p>258</p>
<p>360</p>
<p>Portugal</p>
<p>1450</p>
<p>400</p>
<p>400</p>
<p>200</p>
<p>300</p>
<p>300</p>
<p>Egypt</p>
<p>1900</p>
<p>1000</p>
<p>280</p>
<p>300</p>
<p>500</p>
<p>End</p></td>
<td><p>Going to France!</p>
<p>Going to Portugal!</p>
<p>Going to Egypt!</p></td>
</tr>
</tbody>
</table>
<h2 id="сграда">Сграда</h2>
<p>Напишете програма, която извежда на конзолата номерата на стаите в една сграда (в низходящ ред), като са изпълнени следните условия:</p>
<ul>
<li><p>На <strong>всеки четен етаж има само офиси</strong></p></li>
<li><p>На <strong>всеки нечетен етаж има само апартаменти</strong></p></li>
<li><p>Всеки <strong>апартамент</strong> се означава по следния начин : <strong>А</strong>{<strong>номер на етажа</strong>}{<strong>номер на апартамента</strong>}, <strong>номерата на апартаментите започват от 0.</strong></p></li>
<li><p>Всеки <strong>офис</strong> се означава по следния начин : <strong>О</strong>{<strong>номер на етажа</strong>}{<strong>номер на офиса</strong>}, <strong>номерата на</strong> <strong>офисите</strong> <strong>също започват от 0.</strong></p></li>
<li><p><strong>На последният етаж винаги има апартаменти</strong> и те са по-големи от останалите, за това <strong>пред номера им пише 'L', вместо 'А'. Ако има само един етаж, то има само големи апартаменти!</strong></p></li>
</ul>
<p>От конзолата се прочитат две <strong>цели числа - броят на етажите и броят на стаите за един етаж.</strong></p>
<h3 id="примерен-вход-и-изход-5">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
<th><strong>Обяснения</strong></th>
<th></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>6</p>
<p>4</p></td>
<td><p>L60 L61 L62 L63</p>
<p>A50 A51 A52 A53</p>
<p>O40 O41 O42 O43</p>
<p>A30 A31 A32 A33</p>
<p>O20 O21 O22 O23</p>
<p>A10 A11 A12 A13</p></td>
<td>Имаме общо 6 етажа, с по 4 стаи на етаж. Нечетните етажи имат само апартаменти, а четните само офиси.</td>
<td></td>
</tr>
<tr class="even">
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
</tr>
<tr class="odd">
<td><p>9</p>
<p>5</p></td>
<td><p>L90 L91 L92 L93 L94</p>
<p>O80 O81 O82 O83 O84</p>
<p>A70 A71 A72 A73 A74</p>
<p>O60 O61 O62 O63 O64</p>
<p>A50 A51 A52 A53 A54</p>
<p>O40 O41 O42 O43 O44</p>
<p>A30 A31 A32 A33 A34</p>
<p>O20 O21 O22 O23 O24</p>
<p>A10 A11 A12 A13 A14</p></td>
<td><p>4</p>
<p>4</p></td>
<td><p>L40 L41 L42 L43</p>
<p>A30 A31 A32 A33</p>
<p>O20 O21 O22 O23</p>
<p>A10 A11 A12 A13</p></td>
</tr>
</tbody>
</table>
<h1 id="примерна-изпитна-задача">Примерна изпитна задача</h1>
<h2 id="билети-за-кино">*Билети за кино</h2>
<p>Вашата задача е да <strong>напишете програма</strong>, която да изчислява <strong>процента на билетите за всеки тип от продадените билети</strong>: студентски(<strong>student</strong>), стандартен(<strong>standard</strong>) и детски(<strong>kid</strong>), за всички прожекции. Трябва да изчислите и <strong>колко процента от залата е запълнен</strong>а за <strong>всяка една прожекция.</strong></p>
<h3 id="вход-1">Вход</h3>
<p>Входът е поредица от <strong>цели числа</strong> и <strong>текст</strong>:</p>
<ul>
<li><p>На първия ред до получаване на командата "<strong>Finish</strong>" - име на филма – <strong>текст</strong></p></li>
<li><p>На втори ред – свободните места в салона за всяка прожекция – <strong>цяло число [1 … 100]</strong></p></li>
<li><p>За всеки филм, се чете по един ред до изчерпване на свободните места в залата или до получаване на командата "<strong>End</strong>":</p>
<ul>
<li><p>Типа на закупения билет - текст ("<strong>student", "standard", "kid"</strong>)</p></li>
</ul></li>
</ul>
<h3 id="изход-1">Изход</h3>
<p>На конзолата трябва да се печатат <strong>следните редове</strong>:</p>
<ul>
<li><p>След всеки филм да се отпечата, колко процента от кино залата е пълна</p></li>
</ul>
<p><strong>"{името на филма} - {процент запълненост на залата}% full."</strong></p>
<ul>
<li><p>При получаване на командата "Finish" да се отпечатат четири реда:</p>
<ul>
<li><p><strong>"Total tickets: {общият брой закупени билети за всички филми}"</strong></p></li>
<li><p><strong>"{процент на студентските билети}% student tickets."</strong></p></li>
<li><p><strong>"{процент на стандартните билети}% standard tickets."</strong></p></li>
<li><p><strong>"{процент на детските билети}% kids tickets."</strong></p></li>
</ul></li>
</ul>
<h3 id="примерен-вход-и-изход-6">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
<th><strong>Обяснения</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Taxi</p>
<p>10</p>
<p>standard</p>
<p>kid</p>
<p>student</p>
<p>student</p>
<p>standard</p>
<p>standard</p>
<p>End</p>
<p>Scary Movie</p>
<p>6</p>
<p>student</p>
<p>student</p>
<p>student</p>
<p>student</p>
<p>student</p>
<p>student</p>
<p>Finish</p></td>
<td><p>Taxi - 60.00% full.</p>
<p>Scary Movie - 100.00% full.</p>
<p>Total tickets: 12</p>
<p>66.67% student tickets.</p>
<p>25.00% standard tickets.</p>
<p>8.33% kids tickets.</p></td>
<td><p>Първи филм – Taxi, местата в залата са 10</p>
<p>Купуват се 3 стандарти, 2 студентски, 1 детски билет и получаваме командата End.</p>
<p>Общо 6 билета от 10 места -&gt; 60% от залата е заета.</p>
<p>Втори филм – Scary Movie, места в залата са 6</p>
<p>Купуват се 6 студентски билета и местата в залата свършват.</p>
<p>Общо 6 билета от 6 места -&gt; 100% от залата е заета.</p>
<p>Получаваме командата Finish</p>
<p>Общо закупените билети за всички филми са 12.</p>
<p>За всички филми са закупени общо:</p>
<p>8 студентски билета. 8 билета от общо 12 е 66.67%</p>
<p>3 стандартни билета. 3 билета от общо 12 е 25%</p>
<p>1 детски билет. 1 билет от общо 12 е 8.33%</p></td>
</tr>
<tr class="even">
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
<td><strong>Обяснения</strong></td>
</tr>
<tr class="odd">
<td><p>The Matrix</p>
<p>20</p>
<p>student</p>
<p>standard</p>
<p>kid</p>
<p>kid</p>
<p>student</p>
<p>student</p>
<p>standard</p>
<p>student</p>
<p>End</p>
<p>The Green Mile</p>
<p>17</p>
<p>student</p>
<p>standard</p>
<p>standard</p>
<p>student</p>
<p>standard</p>
<p>student</p>
<p>End</p>
<p>Amadeus</p>
<p>3</p>
<p>standard</p>
<p>standard</p>
<p>standard</p>
<p>Finish</p></td>
<td><p>The Matrix - 40.00% full.</p>
<p>The Green Mile - 35.29% full.</p>
<p>Amadeus - 100.00% full.</p>
<p>Total tickets: 17</p>
<p>41.18% student tickets.</p>
<p>47.06% standard tickets.</p>
<p>11.76% kids tickets.</p></td>
<td><p>Първи филм – The Matrix, местата в залата са 20</p>
<p>Купуват се 2 стандартни, 4 студентски, 2 детски билета и получаваме командата End.</p>
<p>Общо 8 билета от 20 места -&gt; 41.18% от залата е заета</p>
<p>Втори филм - The Green Mile, местата в залата са 17</p>
<p>Купуват се 3 стандартни, 3 студентски билета и получаваме командата End.</p>
<p>Общо 6 билета от 17 места -&gt; 47.06% от залата е заета</p>
<p>Трети филм – Amadeus, местата в залата са 3</p>
<p>Купуват се 3 стандартни билета и местата в залата свършват.</p>
<p>Общо 3 билета от 3 места -&gt; 100% от залата е заета.</p>
<p>Получаваме командата Finish</p>
<p>Общо закупените билети за всички филми са 17.</p>
<p>За всички филми са закупени общо:</p>
<p>7 студентски билета. 7 билета от общо 17 е 41.18%</p>
<p>8 стандартни билета. 8 билета от общо 17 е 47.06%</p>
<p>2 детски билета. 2 билета от общо 17 е 11.76%</p></td>
</tr>
</tbody>
</table>
