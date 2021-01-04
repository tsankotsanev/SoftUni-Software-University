<h1 id="упражнения-вложени-условни-конструкции">Упражнения: Вложени условни конструкции</h1>
<p>Задачи за упражнение в клас и за домашно към курса <a href="https://softuni.bg/courses/programming-basics">"Основи на програмирането" @ СофтУни</a>.</p>
<p><strong>Тествайте</strong> решението си в <strong>judge системата</strong>: <a href="https://judge.softuni.bg/Contests/2379">https://judge.softuni.bg/Contests/2379</a></p>
<h2 id="кино">Кино</h2>
<p>В една кинозала столовете са наредени в правоъгълна форма в <strong>r</strong> реда и <strong>c</strong> колони. Има три вида прожекции с билети на различни цени:</p>
<ul>
<li><p><strong>Premiere</strong> – премиерна прожекция, на цена <strong>12.00</strong> лева.</p></li>
<li><p><strong>Normal</strong> – стандартна прожекция, на цена <strong>7.50</strong> лева.</p></li>
<li><p><strong>Discount</strong> – прожекция за деца, ученици и студенти на намалена цена от <strong>5.00</strong> лева.</p></li>
</ul>
<p>Напишете програма, която чете <strong>тип прожекция</strong> (стринг), брой <strong>редове</strong> и брой <strong>колони</strong> в залата (цели числа), въведени от потребителя, и изчислява общите приходи от билети при пълна зала. Резултатът да се отпечата във формат като в примерите по-долу, с 2 знака след десетичната точка.</p>
<h3 id="примерен-вход-и-изход">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Premiere</p>
<p>10</p>
<p>12</p></td>
<td>1440.00 leva</td>
<td></td>
<td><p>Normal</p>
<p>21</p>
<p>13</p></td>
<td>2047.50 leva</td>
<td></td>
<td><p>Discount</p>
<p>12</p>
<p>30</p></td>
<td>1800.00 leva</td>
</tr>
</tbody>
</table>
<p>* <strong>Подсказка</strong>: използвайте прости проверки и елементарни изчисления. За да изведете резултата с точно 2 цифри след десетичната точка, използвайте <strong>Console.WriteLine("{0:f2} leva",</strong> <strong>income)</strong>.</p>
<h3 id="насоки">Насоки</h3>
<ol type="1">
<li><p>Прочетете входните данни от конзолата.</p></li>
</ol>
<blockquote>
<p><img src="media/image1.png" style="width:4.21172in;height:0.69748in" /></p>
</blockquote>
<ol start="2" type="1">
<li><p>Инициализирайте променлива "<strong>income</strong>" от тип "<strong>double</strong>" с начална стойност <strong>0</strong>.</p></li>
</ol>
<blockquote>
<p><img src="media/image2.png" style="width:2.28125in;height:0.3125in" /></p>
</blockquote>
<ol start="3" type="1">
<li><p>Направете серия от проверки, като за всеки тип прожекция ("<strong>Premiere</strong>, <strong>Normal</strong>, <strong>Discount</strong>"), присвоявайте съответната цена към променливата "<strong>income</strong>" и накрая отпечатайте крайния резултат.</p></li>
</ol>
<blockquote>
<p><img src="media/image3.png" style="width:3.91291in;height:3.13033in" /></p>
</blockquote>
<h2 id="лятно-облекло"> Лятно облекло</h2>
<p>Лято е с много променливо време и Виктор има нужда от вашата помощ. Напишете програма която <strong>спрямо времето от денонощието</strong> <strong>и градусите</strong> да препоръча на Виктор какви дрехи да си облече. Вашия приятел има различни планове за всеки етап от деня, които изискват и различен външен вид, тях може да видите от <strong>таблицата.</strong></p>
<p><strong>От конзолата се четат точно два реда:</strong></p>
<ul>
<li><p><strong>Градусите - цяло число в интервала [10…42]</strong></p></li>
<li><p><strong>Текст, време от денонощието - с възможности - "Morning", "Afternoon", "Evening"</strong></p></li>
</ul>
<table>
<thead>
<tr class="header">
<th><strong>Време от денонощието / градуси</strong></th>
<th>Мorning</th>
<th>Afternoon</th>
<th>Evening</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>10 &lt;= градуси &lt;= 18</td>
<td><p>Outfit = Sweatshirt</p>
<p>Shoes = Sneakers</p></td>
<td><p>Outfit = Shirt</p>
<p>Shoes = Moccasins</p></td>
<td><p>Outfit = Shirt</p>
<p>Shoes = Moccasins</p></td>
</tr>
<tr class="even">
<td>18 &lt; градуси &lt;= 24</td>
<td><p>Outfit = Shirt</p>
<p>Shoes = Moccasins</p></td>
<td><p>Outfit = T-Shirt</p>
<p>Shoes = Sandals</p></td>
<td><p>Outfit = Shirt</p>
<p>Shoes = Moccasins</p></td>
</tr>
<tr class="odd">
<td>градуси &gt;= 25</td>
<td><p>Outfit = T-Shirt</p>
<p>Shoes = Sandals</p></td>
<td><p>Outfit = Swim Suit</p>
<p>Shoes = Barefoot</p></td>
<td><p>Outfit = Shirt</p>
<p>Shoes = Moccasins</p></td>
</tr>
</tbody>
</table>
<p><strong>Да се отпечата на конзолата на един ред:</strong> <strong>"It's {градуси} degrees, get your {облекло} and {обувки}."</strong></p>
<h3 id="примерен-вход-и-изход-1">Примерен вход и изход</h3>
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
<td><p>16</p>
<p>Morning</p></td>
<td>It's 16 degrees, get your Sweatshirt and Sneakers.</td>
<td>Сутрин когато градусите са 16, Виктор си взима суичър и маратонки.</td>
<td></td>
</tr>
<tr class="even">
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
</tr>
<tr class="odd">
<td><p>22</p>
<p>Afternoon</p></td>
<td>It's 22 degrees, get your T-Shirt and Sandals.</td>
<td><p>28</p>
<p>Evening</p></td>
<td>It's 28 degrees, get your Shirt and Moccasins.</td>
</tr>
</tbody>
</table>
<h3 id="насоки-1">Насоки</h3>
<ol type="1">
<li><p>Прочетете входните данни от конзолата и инициализирайте две променливи "outfit, shoes" от тип "string", с начална стойност "".</p></li>
</ol>
<blockquote>
<p><img src="media/image4.png" style="width:4.63194in;height:0.86089in" /></p>
</blockquote>
<ol start="2" type="1">
<li><p>Направете проверка за градусите използвайки логически оператор "<strong>и</strong>" – "<strong>&amp;&amp;</strong>" - "<strong>degrees &gt;= 10 &amp;&amp; degrees &lt;= 18</strong>" и в тялото на проверката за градусите проверявайте за времето от деня "<strong>Morning</strong>, <strong>Afternoon</strong>, <strong>Evening</strong>", като за всеки етап от деня променяйте стойността на променливите "<strong>outfit</strong>, <strong>shoes</strong>".</p></li>
</ol>
<blockquote>
<p><img src="media/image5.png" style="width:5.61806in;height:2.74225in" /></p>
</blockquote>
<ol start="3" type="1">
<li><p>Отпечатайте на конзолата крайния резултат във формата описан в условието на задачата.</p></li>
</ol>
<blockquote>
<p><img src="media/image6.png" style="width:6.48264in;height:0.29999in" /></p>
</blockquote>
<h2 id="нов-дом">Нов дом</h2>
<p>Марин и Нели си купуват къща не далеч от София. Нели толкова много обича цветята, че Ви убеждава да <strong>напишете програма</strong> която да <strong>изчисли колко ще им струва</strong>, да си засадят определен брой цветя и <strong>дали наличния бюджет ще им е достатъчен. Различните цветя са с различни цени.</strong></p>
<table>
<thead>
<tr class="header">
<th><strong>цвете</strong></th>
<th><strong>Роза</strong></th>
<th><strong>Далия</strong></th>
<th><strong>Лале</strong></th>
<th><strong>Нарцис</strong></th>
<th><strong>Гладиола</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Цена на брой в лева</strong></td>
<td>5</td>
<td>3.80</td>
<td>2.80</td>
<td>3</td>
<td>2.50</td>
</tr>
</tbody>
</table>
<p><strong>Съществуват следните отстъпки:</strong></p>
<ul>
<li><p><strong>Ако Нели купи повече от 80 Рози - 10% отстъпка от крайната цена</strong></p></li>
<li><p><strong>Ако Нели купи повече от 90 Далии - 15% отстъпка от крайната цена</strong></p></li>
<li><p><strong>Ако Нели купи повече от 80 Лалета - 15% отстъпка от крайната цена</strong></p></li>
<li><p><strong>Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15%</strong></p></li>
<li><p><strong>Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20%</strong></p></li>
</ul>
<p><strong>От конзолата се четат 3 реда:</strong></p>
<ul>
<li><p><strong>Вид цветя - текст с възможности - "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"</strong></p></li>
<li><p><strong>Брой цветя - цяло число в интервала [10…1000]</strong></p></li>
<li><p><strong>Бюджет - цяло число в интервала [50…2500]</strong></p></li>
</ul>
<p>Да се <strong>отпечата</strong> на конзолата <strong>на един ред:</strong></p>
<ul>
<li><p><strong>Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."</strong></p></li>
<li><p><strong>Ако бюджета им е НЕ достатъчен -</strong> <strong>"Not enough money, you need {нужната сума} leva more."</strong></p></li>
</ul>
<p><strong>Сумата да бъде форматирана до втория знак след десетичната запетая.</strong></p>
<h3 id="примерен-вход-и-изход-2">Примерен вход и изход</h3>
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
<td><p>Roses</p>
<p>55</p>
<p>250</p></td>
<td>Not enough money, you need 25.00 leva more.</td>
<td><p>Нели иска 55 броя Рози. Цената на една роза е 5лв., следователно за 55 броя Нели ще трябва да плати: 55 * 5 = 275.</p>
<p>Тя обаче разполага с 250 лв. бюджет.<br />
Понеже 275 &gt; 250 , то не и достигат 25 лв.</p></td>
<td></td>
</tr>
<tr class="even">
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
</tr>
<tr class="odd">
<td><p>Tulips</p>
<p>88</p>
<p>260</p></td>
<td>Hey, you have a great garden with 88 Tulips and 50.56 leva left.</td>
<td><p>Narcissus</p>
<p>119</p>
<p>360</p></td>
<td>Not enough money, you need 50.55 leva more.</td>
</tr>
</tbody>
</table>
<h2 id="лодка-за-риболов">Лодка за риболов</h2>
<p>Тони и приятели много обичали да ходят за риба, те са толкова запалени по риболова, че решават да отидат на риболов с кораб. Цената за наема на кораба зависи от <strong>сезона и броя рибари.</strong></p>
<p><strong>Цената зависи от сезона:</strong></p>
<ul>
<li><blockquote>
<p><strong>Цената за наем на кораба през пролетта е 3000 лв.</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>Цената за наем на кораба през лятото и есента е 4200 лв.</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>Цената за наем на кораба през зимата е 2600 лв.</strong></p>
</blockquote></li>
</ul>
<p><strong>В зависимост от броя си групата ползва отстъпка:</strong></p>
<ul>
<li><blockquote>
<p><strong>Ако групата е до 6 човека включително – отстъпка от 10%.</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>Ако групата е от 7 до 11 човека включително – отстъпка от 15%.</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>Ако групата е от 12 нагоре – отстъпка от 25%.</strong></p>
</blockquote></li>
</ul>
<p>Рибарите ползват допълнително <strong>5% отстъпка, ако са четен брой освен ако не е есен - тогава нямат допълнителна отстъпка, която се начислява след като се приспадне отстъпката по горните критерии.</strong></p>
<p><strong>Напишете програма</strong>, която да <strong>пресмята</strong> дали рибарите ще <strong>съберат достатъчно пари.</strong></p>
<h3 id="вход">Вход</h3>
<p><strong>От конзолата се четат точно три реда.</strong></p>
<ul>
<li><blockquote>
<p><strong>Бюджет на групата – цяло число в интервала [1…8000]</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>Сезон – текст: "Spring", "Summer", "Autumn", "Winter"</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>Брой рибари – цяло число в интервала [4…18]</strong></p>
</blockquote></li>
</ul>
<h3 id="изход">Изход</h3>
<p>Да се <strong>отпечата</strong> на конзолата <strong>един ред</strong>:</p>
<ul>
<li><blockquote>
<p>Ако <strong>бюджетът е достатъчен:</strong></p>
</blockquote></li>
</ul>
<blockquote>
<p>"<strong>Yes! You have {останалите пари} leva left.</strong>"</p>
</blockquote>
<ul>
<li><blockquote>
<p>Ако <strong>бюджетът НЕ Е достатъчен</strong>:</p>
</blockquote></li>
</ul>
<blockquote>
<p>"<strong>Not enough money! You need {сумата</strong>, <strong>която</strong> <strong>не</strong> <strong>достига} leva.</strong>"</p>
</blockquote>
<p><strong>Сумите</strong> трябва да са <strong>форматирани с точност до два знака след десетичната запетая</strong>.</p>
<h3 id="примерен-вход-и-изход-3">Примерен вход и изход</h3>
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
<td><p>3000</p>
<p>Summer</p>
<p>11</p></td>
<td>Not enough money! You need 570.00 leva.</td>
<td><p>Лятото риболовния туризъм струва 4200 лв., <strong>11 рибари ползват 15% отстъпка -&gt; 4200 - 15% = 3570</strong> лв., <strong>нечетен брой са и не ползват допълнителна отстъпка,.</strong></p>
<p>3000 &lt;= 3570, следователно не им достигат 570.00 лв.</p></td>
<td></td>
</tr>
<tr class="even">
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
</tr>
<tr class="odd">
<td><p>3600</p>
<p>Autumn</p>
<p>6</p></td>
<td>Not enough money! You need 180.00 leva.</td>
<td><p>2000</p>
<p>Winter</p>
<p>13</p></td>
<td>Yes! You have 50.00 leva left.</td>
</tr>
</tbody>
</table>
<h1 id="примерни-изпитни-задачи">Примерни изпитни задачи</h1>
<h2 id="пътешествие">Пътешествие</h2>
<p>Странно, но повечето хора си плануват от рано почивката. Млад програмист разполага с <strong>определен бюджет</strong> и свободно време в даден <strong>сезон</strong>. Напишете програма, която да приема <strong>на входа бюджета и сезона</strong>, а <strong>на изхода</strong> да изкарва, <strong>къде ще почива</strong> програмиста и <strong>колко ще похарчи</strong>.</p>
<p><strong>Бюджета определя дестинацията, а</strong> <strong>сезона определя колко от бюджета ще изхарчи</strong>. Ако е <strong>лято</strong> ще почива на <strong>къмпинг</strong>, а <strong>зимата в хотел</strong>. Ако е в <strong>Европа</strong>, <strong>независимо от сезона</strong> ще почива в <strong>хотел</strong>. Всеки <strong>къмпинг</strong> или <strong>хотел</strong>, <strong>според дестинацията</strong>, има <strong>собствена цена</strong> която отговаря на даден <strong>процент от бюджета</strong>:</p>
<ul>
<li><p>При <strong>100лв. или по-малко</strong> – някъде в <strong>България</strong></p>
<ul>
<li><p><strong>Лято</strong> – <strong>30%</strong> от бюджета</p></li>
<li><p><strong>Зима</strong> – <strong>70%</strong> от бюджета</p></li>
</ul></li>
<li><p>При <strong>1000лв. или по малко</strong> – някъде на <strong>Балканите</strong></p>
<ul>
<li><p><strong>Лято</strong> – <strong>40%</strong> от бюджета</p></li>
<li><p><strong>Зима</strong> – <strong>80%</strong> от бюджета</p></li>
</ul></li>
<li><p>При <strong>повече от 1000лв</strong>. – някъде из <strong>Европа</strong></p>
<ul>
<li><p>При пътуване из Европа, независимо от сезона ще похарчи <strong>90% от бюджета</strong>.</p></li>
</ul></li>
</ul>
<h3 id="вход-1">Вход</h3>
<p>Входът се чете от конзолата и се състои от <strong>два реда</strong>, въведени от потребителя:</p>
<ul>
<li><p><strong>Първи ред</strong> – Бюджет, <strong>реално число</strong> в интервала <strong>[10.00...5000.00].</strong></p></li>
<li><p><strong>Втори ред</strong> – Един от двата възможни сезона: <strong>„summer”</strong> или <strong>“winter”</strong></p></li>
</ul>
<h3 id="изход-1">Изход</h3>
<p>На конзолата трябва да се отпечатат <strong>два реда</strong>.</p>
<ul>
<li><p><strong>Първи ред</strong> – „<strong>Somewhere in [дестинация]</strong>“ измежду “<strong>Bulgaria</strong>", <strong>"Balkans</strong>” и ”<strong>Europe</strong>”</p></li>
<li><p><strong>Втори ред</strong> – “{<strong>Вид почивка</strong>} – {<strong>Похарчена сума</strong>}“</p>
<ul>
<li><p><strong>Почивката</strong> може да е между „<strong>Camp</strong>” и „<strong>Hotel</strong>”</p></li>
<li><p><strong>Сумата</strong> трябва да е <strong>закръглена с точност до вторият знак след запетаята</strong>.</p></li>
</ul></li>
</ul>
<h3 id="примерен-вход-и-изход-4">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>50</p>
<p>summer</p></td>
<td><p>Somewhere in Bulgaria</p>
<p>Camp - 15.00</p></td>
</tr>
<tr class="even">
<td><p>75</p>
<p>winter</p></td>
<td><p>Somewhere in Bulgaria</p>
<p>Hotel - 52.50</p></td>
</tr>
<tr class="odd">
<td><p>312</p>
<p>summer</p></td>
<td><p>Somewhere in Balkans</p>
<p>Camp - 124.80</p></td>
</tr>
<tr class="even">
<td><p>678.53</p>
<p>winter</p></td>
<td><p>Somewhere in Balkans</p>
<p>Hotel - 542.82</p></td>
</tr>
<tr class="odd">
<td><p>1500</p>
<p>summer</p></td>
<td><p>Somewhere in Europe</p>
<p>Hotel - 1350.00</p></td>
</tr>
</tbody>
</table>
<h2 id="операции-между-числа">Операции между числа</h2>
<p>Напишете програма, която чете <strong>две цели числа (N1 и N2)</strong> и <strong>оператор,</strong> с който да се <strong>извърши</strong> дадена <strong>математическа операция</strong> с тях. Възможните операции са: <strong>Събиране(+)</strong>, <strong>Изваждане(-)</strong>, <strong>Умножение(*)</strong>, <strong>Деление(/)</strong> и <strong>Модулно деление(%).</strong> При <strong>събиране</strong>, <strong>изваждане</strong> и <strong>умножение</strong> на конзолата <strong>трябва да се отпечатат резултата</strong> и дали той е <strong>четен</strong> или <strong>нечетен</strong>. При <strong>обикновеното деление</strong> – <strong>резултат</strong>а. При <strong>модулното деление</strong> – <strong>остатъка</strong>. Трябва да се има предвид, че <strong>делителят може да е равен на 0(нула)</strong>, а <strong>на нула не се дели</strong>. В този случай трябва да се отпечата <strong>специално съобщениe</strong>.</p>
<h3 id="вход-2">Вход</h3>
<p>От конзолата се прочитат <strong>3 реда</strong>, въведени от потребителя:</p>
<ul>
<li><p><strong>N1</strong> – <strong>цяло число</strong> в интервала <strong>[0...40 000]</strong></p></li>
<li><p><strong>N2</strong> – <strong>цяло число</strong> в интервала <strong>[0...40 000]</strong></p></li>
<li><p><strong>Оператор</strong> – <strong>един символ</strong> измежду: „<strong>+</strong>“, „<strong>-</strong>“, „<strong>*</strong>“, „<strong>/</strong>“, „<strong>%</strong>“</p></li>
</ul>
<h3 id="изход-2">Изход</h3>
<p>Да се отпечата на конзолата <strong>един ред</strong>:</p>
<ul>
<li><p>Ако операцията е <strong>събиране</strong>, <strong>изваждане</strong> или <strong>умножение</strong>:</p>
<ul>
<li><p><strong>"{N1} {оператор} {N2} = {резултат} – {even/odd}"</strong></p></li>
</ul></li>
<li><p>Ако операцията е <strong>деление</strong>:</p>
<ul>
<li><p><strong>"{N1} / {N2} = {резултат}"</strong> – резултатът е <strong>форматиран</strong> до <strong>вторият знак след дес.запетая</strong></p></li>
</ul></li>
<li><p>Ако операцията е <strong>модулно деление</strong>:</p>
<ul>
<li><p><strong>"{N1} % {N2} = {остатък}"</strong></p></li>
</ul></li>
<li><p>В случай на <strong>деление с 0 (нула)</strong>:</p>
<ul>
<li><p><strong>"Cannot divide {N1} by zero"</strong></p></li>
</ul></li>
</ul>
<h3 id="примерен-вход-и-изход-5">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>10</p>
<p>12</p>
<p>+</p></td>
<td>10 + 12 = 22 - even</td>
<td><p>123</p>
<p>12</p>
<p>/</p></td>
<td>123 / 12 = 10.25</td>
<td><p>112</p>
<p>0</p>
<p>/</p></td>
<td>Cannot divide 112 by zero</td>
</tr>
<tr class="even">
<td><p>10</p>
<p>1</p>
<p>-</p></td>
<td>10 – 1 = 9 - odd</td>
<td><p>10</p>
<p>3</p>
<p>%</p></td>
<td>10 % 3 = 1</td>
<td><p>10</p>
<p>0</p>
<p>%</p></td>
<td>Cannot divide 10 by zero</td>
</tr>
<tr class="odd">
<td><p>7</p>
<p>3</p>
<p>*</p></td>
<td>7 * 3 = 21 - odd</td>
<td></td>
<td></td>
<td></td>
<td></td>
</tr>
</tbody>
</table>
<h2 id="хотелска-стая">Хотелска стая</h2>
<p>Хотел предлага <strong>2 вида стаи</strong>: <strong>студио и апартамент</strong>. Напишете програма, която изчислява <strong>цената за целия престой за студио и апартамент</strong>. <strong>Цените</strong> зависят от <strong>месеца</strong> на престоя:</p>
<table>
<thead>
<tr class="header">
<th><strong>Май и октомври</strong></th>
<th><strong>Юни и септември</strong></th>
<th><strong>Юли и август</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>Студио – <strong>50</strong> лв./нощувка</td>
<td>Студио – <strong>75.20</strong> лв./нощувка</td>
<td>Студио – <strong>76</strong> лв./нощувка</td>
</tr>
<tr class="even">
<td>Апартамент – <strong>65</strong> лв./нощувка</td>
<td>Апартамент – <strong>68.70</strong> лв./нощувка</td>
<td>Апартамент – <strong>77</strong> лв./нощувка</td>
</tr>
</tbody>
</table>
<p>Предлагат се и следните <strong>отстъпки</strong>:</p>
<ul>
<li><p>За <strong>студио</strong>, при <strong>повече</strong> от <strong>7</strong> нощувки през <strong>май и октомври</strong> : <strong>5% намаление</strong>.</p></li>
<li><p>За <strong>студио</strong>, при <strong>повече</strong> от <strong>14</strong> нощувки през <strong>май и октомври</strong> : <strong>30% намаление</strong>.</p></li>
<li><p>За <strong>студио</strong>, при <strong>повече</strong> от <strong>14</strong> нощувки през <strong>юни и септември</strong>: <strong>20% намаление</strong>.</p></li>
<li><p>За <strong>апартамент</strong>, при <strong>повече</strong> от <strong>14</strong> нощувки<strong>, без значение от месеца : 10% намаление.</strong></p></li>
</ul>
<h3 id="вход-3">Вход</h3>
<p>Входът се чете от <strong>конзолата</strong> и съдържа <strong>точно 2 реда</strong>, въведени от потребителя:</p>
<ul>
<li><p>На <strong>първия</strong> ред е <strong>месецът</strong> – <strong>May,</strong> <strong>June,</strong> <strong>July,</strong> <strong>August,</strong> <strong>September</strong> или <strong>October</strong></p></li>
<li><p>На <strong>втория</strong> ред е <strong>броят на нощувките</strong> – <strong>цяло число в интервала [0 ... 200]</strong></p></li>
</ul>
<h3 id="изход-3">Изход</h3>
<p>Да се <strong>отпечатат</strong> на конзолата <strong>2 реда</strong>:</p>
<ul>
<li><p>На <strong>първия ред</strong>: “<strong>Apartment: {цена за целият престой} lv.</strong>”</p></li>
<li><p>На <strong>втория ред</strong>: “<strong>Studio: {цена за целият престой} lv.</strong>“</p></li>
</ul>
<p><strong>Цената за целия престой</strong> <strong>форматирана с точност до два знака след десетичната запетая</strong>.</p>
<h3 id="примерен-вход-и-изход-6">Примерен вход и изход</h3>
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
<td><p>May</p>
<p>15</p></td>
<td><p>Apartment: 877.50 lv.</p>
<p>Studio: 525.00 lv.</p></td>
<td><p><strong>През май</strong>, при повече от <strong>14</strong> нощувки, намаляваме цената на студиото с <strong>30%</strong> (50 – 15 = 35), а на апартамента – с <strong>10%</strong> (65 – 6.5 =58.5).</p>
<p>Целият престой в <strong>апартамент</strong> – <strong>877.50 лв</strong>.</p>
<p>Целият престой в <strong>студио</strong> – <strong>525.00 лв</strong>.</p></td>
<td></td>
</tr>
<tr class="even">
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
</tr>
<tr class="odd">
<td><p>June</p>
<p>14</p></td>
<td><p>Apartment: 961.80 lv.</p>
<p>Studio: 1052.80 lv.</p></td>
<td><p>August</p>
<p>20</p></td>
<td><p>Apartment: 1386.00 lv.</p>
<p>Studio: 1520.00 lv.</p></td>
</tr>
</tbody>
</table>
<h2 id="навреме-за-изпит">Навреме за изпит</h2>
<p>Студент трябва да отиде <strong>на</strong> <strong>изпит</strong> <strong>в</strong> <strong>определен час</strong> (например в 9:30 часа). Той идва в изпитната зала в даден <strong>час на пристигане</strong> (например 9:40). Счита се, че студентът е дошъл <strong>навреме</strong>, ако е пристигнал в часа на изпита или до половин час преди това. Ако е пристигнал по-рано повече от 30 минути, той е <strong>подранил</strong>. Ако е дошъл след часа на изпита, той е <strong>закъснял</strong>. Напишете програма, която прочита време на изпит и време на пристигане и отпечатва дали студентът е дошъл <strong>навреме</strong>, дали е <strong>подранил</strong> или е <strong>закъснял</strong> и <strong>с колко часа или минути</strong> е подранил или закъснял.</p>
<h3 id="вход-4">Вход</h3>
<p>От конзолата се четат <strong>4 цели числа</strong> (по едно на ред), въведени от потребителя:</p>
<ul>
<li><p>Първият ред съдържа <strong>час на изпита</strong> – цяло число от 0 до 23.</p></li>
<li><p>Вторият ред съдържа <strong>минута на изпита</strong> – цяло число от 0 до 59.</p></li>
<li><p>Третият ред съдържа <strong>час на пристигане</strong> – цяло число от 0 до 23.</p></li>
<li><p>Четвъртият ред съдържа <strong>минута на пристигане</strong> – цяло число от 0 до 59.</p></li>
</ul>
<h3 id="изход-4">Изход</h3>
<p>На първият ред отпечатайте:</p>
<ul>
<li><p>“<strong>Late</strong>”, ако студентът пристига по-късно от часа на изпита.</p></li>
<li><p>“<strong>On time</strong>”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.</p></li>
<li><p>“<strong>Early</strong>”, ако студентът пристига повече от 30 минути преди часа на изпита.</p></li>
</ul>
<p>Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:</p>
<ul>
<li><p>“<strong>mm</strong> <strong>minutes before the start</strong>” за идване по-рано с по-малко от час.</p></li>
<li><p>“<strong>hh:mm</strong> <strong>hours before the start</strong>” за подраняване с 1 час или повече. Минутите винаги печатайте с 2 цифри, например “1:05”.</p></li>
<li><p>“<strong>mm</strong> <strong>minutes after the start</strong>” за закъснение под час.</p></li>
<li><p>“<strong>hh:mm</strong> <strong>hours after the start</strong>” за закъснение от 1 час или повече. Минутите винаги печатайте с 2 цифри, например “1:03”.</p></li>
</ul>
<h3 id="примерен-вход-и-изход-7">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
<th></th>
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
<th></th>
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>9</p>
<p>30</p>
<p>9</p>
<p>50</p></td>
<td><p>Late</p>
<p>20 minutes after the start</p></td>
<td></td>
<td><p>9</p>
<p>00</p>
<p>10</p>
<p>30</p></td>
<td><p>Late</p>
<p>1:30 hours after the start</p></td>
<td></td>
<td><p>10</p>
<p>00</p>
<p>10</p>
<p>00</p></td>
<td>On time</td>
</tr>
<tr class="even">
<td><p>9</p>
<p>00</p>
<p>8</p>
<p>30</p></td>
<td><p>On time</p>
<p>30 minutes before the start</p></td>
<td></td>
<td><p>14</p>
<p>00</p>
<p>13</p>
<p>55</p></td>
<td><p>On time</p>
<p>5 minutes before the start</p></td>
<td></td>
<td><p>11</p>
<p>30</p>
<p>10</p>
<p>55</p></td>
<td><p>Early</p>
<p>35 minutes before the start</p></td>
</tr>
<tr class="odd">
<td><p>16</p>
<p>00</p>
<p>15</p>
<p>00</p></td>
<td><p>Early</p>
<p>1:00 hours before the start</p></td>
<td></td>
<td><p>11</p>
<p>30</p>
<p>8</p>
<p>12</p></td>
<td><p>Early</p>
<p>3:18 hours before the start</p></td>
<td></td>
<td><p>11</p>
<p>30</p>
<p>12</p>
<p>29</p></td>
<td><p>Late</p>
<p>59 minutes after the start</p></td>
</tr>
</tbody>
</table>
<h1 id="допълнителна-задача">Допълнителна задача</h1>
<h2 id="волейбол">*Волейбол</h2>
<p>Влади е студент, живее в София и си ходи от време на време до родния град. Той е много запален по волейбола, но е зает през работните дни и играе <strong>волейбол</strong> само през <strong>уикендите</strong> и в <strong>празничните дни</strong>. Влади играе <strong>в София</strong> всяка <strong>събота</strong>, когато <strong>не е на работа</strong> и <strong>не си пътува до родния град</strong>, както и в <strong>2/3 от празничните дни</strong>. Той пътува до <strong>родния си град</strong> <strong>h пъти</strong> в годината, където играе волейбол със старите си приятели в <strong>неделя</strong>. Влади <strong>не е на работа 3/4 от уикендите</strong>, в които е в София. Отделно, през <strong>високосните години</strong> Влади играе с <strong>15% повече</strong> волейбол от нормалното. Приемаме, че годината има точно <strong>48 уикенда</strong>, подходящи за волейбол.</p>
<p>Напишете програма, която изчислява <strong>колко пъти Влади е играл волейбол</strong> през годината. <strong>Закръглете резултата</strong> надолу до най-близкото цяло число (например 2.15 2; 9.95 9).</p>
<p>Входните данни се въвеждат от потребителя, в следния вид:</p>
<ul>
<li><p>Първият ред съдържа думата "<strong>leap</strong>" (високосна година) или "<strong>normal</strong>" (невисокосна).</p></li>
<li><p>Вторият ред съдържа цялото число <strong>p</strong> – брой празници в годината (които не са събота и неделя).</p></li>
<li><p>Третият ред съдържа цялото число <strong>h</strong> – брой уикенди, в които Влади си пътува до родния град.</p></li>
</ul>
<h3 id="примерен-вход-и-изход-8">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th><strong>Коментари</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>leap</p>
<p>5</p>
<p>2</p></td>
<td>45</td>
<td><p>48 уикенда в годината, разделени по следния начин:</p>
<ul>
<li><blockquote>
<p>46 уикенда в София 46 * 3 / 4 <strong>34.5</strong> съботни игри в София</p>
</blockquote></li>
<li><blockquote>
<p>2 уикенда в родния си град 2 недели <strong>2</strong> игри в неделя в родния град</p>
</blockquote></li>
</ul>
<p>5 празника:</p>
<ul>
<li><blockquote>
<p>5 * 2/3 <strong>3.333</strong> игри в София в празничен ден</p>
</blockquote></li>
</ul>
<p>Общо игри през уикенди и празници в София и в родния град: 34.5 + 2 + 3.333 <strong>39.833</strong></p>
<p>Годината е високосна:</p>
<ul>
<li><blockquote>
<p>Влади играе допълнителни 15% * 39.833 <strong>5.975</strong> игри волейбол</p>
</blockquote></li>
</ul>
<p>Общо игри през цялата година:</p>
<ul>
<li><blockquote>
<p>39.833 + 5.975 = <strong>45.808</strong> игри</p>
</blockquote></li>
<li><blockquote>
<p>Резултатът е <strong>45</strong> (закръгля се надолу)</p>
</blockquote></li>
</ul></td>
</tr>
</tbody>
</table>
<table>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>normal</p>
<p>3</p>
<p>2</p></td>
<td>38</td>
<td></td>
<td><p>leap</p>
<p>2</p>
<p>3</p></td>
<td>43</td>
<td></td>
<td><p>normal</p>
<p>11</p>
<p>6</p></td>
<td>44</td>
<td></td>
<td><p>leap</p>
<p>0</p>
<p>1</p></td>
<td>41</td>
<td></td>
<td><p>normal</p>
<p>6</p>
<p>13</p></td>
<td>43</td>
</tr>
</tbody>
</table>
