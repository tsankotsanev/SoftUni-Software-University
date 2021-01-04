<h1 id="упражнение-условни-конструкции">Упражнение: Условни конструкции</h1>
<p>Задачи за упражнение към курса <a href="https://softuni.bg/trainings/3038/programming-basics-with-c-sharp-july-2020">"Основи на програмирането" @ СофтУни</a>.</p>
<p>Тествайте решенията си в <strong>judge системата</strong>: https://judge.softuni.bg/Contests/2376</p>
<h2 id="сумиране-на-секунди">Сумиране на секунди </h2>
<p>Трима спортни състезатели финишират за някакъв <strong>брой секунди</strong> (между <strong>1</strong> и <strong>50</strong>). Да се напише програма, която чете времената на състезателите в секунди, въведени от потребителя и пресмята <strong>сумарното им време</strong> във формат "<strong>минути:секунди</strong>". Секундите да се изведат с <strong>водеща нула</strong> (2 "02", 7 "07", 35 "35").</p>
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
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>35</p>
<p>45</p>
<p>44</p></td>
<td>2:04</td>
<td></td>
<td><p>22</p>
<p>7</p>
<p>34</p></td>
<td>1:03</td>
<td></td>
<td><p>50</p>
<p>50</p>
<p>49</p></td>
<td>2:29</td>
<td></td>
<td><p>14</p>
<p>12</p>
<p>10</p></td>
<td>0:36</td>
</tr>
</tbody>
</table>
<h3 id="насоки">Насоки:</h3>
<ol type="1">
<li><p>Прочетете входните данни (<strong>секундите на състезателите</strong>):</p></li>
</ol>
<p><img src="media/image1.png" style="width:5.46944in;height:0.87014in" /></p>
<ol start="2" type="1">
<li><p>Създайте <strong>нова променлива</strong>, в която да съхранявате <strong>сбора от секундите на тримата състезатели</strong>:</p></li>
</ol>
<p><img src="media/image2.png" style="width:5.47917in;height:0.2701in" /></p>
<ol start="3" type="1">
<li><p>След като сте намерили <strong>сбора от секундите</strong> трябва да ги <strong>превърнете в минути и секунди</strong> (например, ако сборът е <strong>85 секунди това са 1 минута и 25 секунди, защото 1 минута има 60 секунди</strong>). Създайте си <strong>две нови променливи</strong>. В първата изчислете, <strong>колко минути е сбора от секунди</strong>, като <strong>разделите сбора на 60</strong>. Във втората променлива <strong>изчислете секундите с помощта на деление с остатък (%)</strong>. Използвайте <strong>деление с остатък (%)</strong>, за да вземете <strong>остатъка при деление с 60</strong>, което са останалите секунди. Например имате общ сбор от 134 секунди (2 минути и 14 секунди) <strong>след целочисленото деление (/) на 60 ще получим 2, а след делението с остатък (%) ще получим оставащите секунди(14).</strong></p></li>
</ol>
<p><img src="media/image3.png" style="width:3.375in;height:0.53125in" /></p>
<ol start="4" type="1">
<li><p>След като вече знаете <strong>колко минути и секунди</strong> е общия сбор, трябва да ги принтираме в правилния формат <strong>(минути : секунди</strong>), като ако секундите са <strong>по-малки от 10</strong> трябва да отпечатаме <strong>0 преди секундите</strong>, в противен случай просто си отпечатваме <strong>резултата в дадения формат</strong>. За целта <strong>направете проверка</strong> (if). За принтирането може да използвате <strong>шаблон</strong>.</p></li>
</ol>
<p><img src="media/image4.png" style="width:5.12068in;height:2.10909in" /></p>
<h2 id="бонус-точки">Бонус точки</h2>
<p>Дадено е <strong>цяло число</strong> – начален брой точки. Върху него се начисляват <strong>бонус точки</strong> по правилата, описани по-долу. Да се напише програма, която пресмята <strong>бонус точките, които получава числото</strong> и <strong>общия брой точки</strong> (числото + бонуса).</p>
<ul>
<li><blockquote>
<p>Ако числото е <strong>до 100</strong> включително, бонус точките са <strong>5</strong>.</p>
</blockquote></li>
<li><p>Ако числото е <strong>по-голямо от 100</strong>, бонус точките са <strong>20%</strong> от числото.</p></li>
<li><p>Ако числото е <strong>по-голямо от 1000</strong>, бонус точките са <strong>10%</strong> от числото.</p></li>
<li><p>Допълнителни бонус точки (начисляват се отделно от предходните):</p>
<ul>
<li><p>За <strong>четно</strong> число + 1 т.</p></li>
<li><p>За число, което <strong>завършва на 5</strong> + 2 т.</p></li>
</ul></li>
</ul>
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
<th></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>20</td>
<td><p>6</p>
<p>26</p></td>
<td></td>
<td>175</td>
<td><p>37</p>
<p>212</p></td>
<td></td>
<td>2703</td>
<td><p>270.3</p>
<p>2973.3</p></td>
<td></td>
<td>15875</td>
<td><p>1589.5</p>
<p>17464.5</p></td>
</tr>
</tbody>
</table>
<h3 id="насоки-1">Насоки:</h3>
<ol type="1">
<li><p>Прочетете входните данни (<strong>числото</strong>):</p></li>
</ol>
<p><img src="media/image5.png" style="width:4.675in;height:0.24933in" /></p>
<ol start="2" type="1">
<li><p>Създайте си <strong>нова променлива от тип double</strong>, в която ще си изчислявате <strong>натрупаните бонус точки</strong>, като и дадете <strong>начална стойност 0.0</strong>.</p></li>
</ol>
<p><img src="media/image6.png" style="width:2.29992in;height:0.31054in" /></p>
<ol start="3" type="1">
<li><p>Направете <strong>if-else-if конструкция</strong> за първите <strong>три проверки</strong>, за да проверите големината числото и да изчислите бонуса.</p></li>
</ol>
<p><img src="media/image7.png" style="width:1.88868in;height:2.47356in" /></p>
<ol start="4" type="1">
<li><p>Направете <strong>нова if-else-if конструкция</strong>, за да извършите проверките и <strong>изчислите допълнителния бонус</strong>.</p>
<ul>
<li><p>aко числото <strong>е четно към до момента натрупания бонус добавете 1</strong></p></li>
<li><p>ако <strong>завършва на 5 към бонуса добавете 2</strong></p></li>
</ul></li>
</ol>
<blockquote>
<p>За да проверите дали едно число <strong>е четно трябва да го разделите на 2 и ако получавате остатък при делението 0</strong>, то значи числото е <strong>четно</strong>, но ако <strong>получите остатък 1</strong>, това означава, че числото е <strong>нечетно</strong>. Например числото 34 е четно, защото 34 / 2 = 17 и остатъкът е 0, а числото 35 е нечетно, защото 35 / 2 = 17 с остатък 1.</p>
<p>За да проверите дали едно число завършва на 5 трябва <strong>да разделите числото на 10</strong> и ако <strong>получите остатък при делението 5</strong>, то значи числото завършва на 5. Например числото 245 / 10 = 24 с остатък 5.</p>
</blockquote>
<p><img src="media/image8.png" style="width:2.25275in;height:1.6301in" /></p>
<ol start="5" type="1">
<li><p>Принтирайте <strong>на два реда</strong> резултатите. На първия ред <strong>натрупания бонус</strong>, а на втория <strong>крайното число</strong>, което ще намерите като <strong>съберете началния брой точки и бонуса</strong>.</p></li>
</ol>
<p><img src="media/image9.png" style="width:3.65727in;height:0.50747in" /></p>
<h2 id="информация-за-скоростта">Информация за скоростта</h2>
<p>Да се напише програма, която <strong>чете скорост</strong> <strong>(реално число)</strong>, въведена от потребителя и отпечатва <strong>информация за скоростта</strong>. При скорост <strong>до 10</strong> (включително) отпечатайте “<strong>slow</strong>”. При скорост <strong>над 10</strong> и <strong>до 50</strong> отпечатайте “<strong>average</strong>”. При скорост <strong>над 50</strong> и <strong>до 150</strong> отпечатайте “<strong>fast</strong>”. При скорост <strong>над 150</strong> и <strong>до 1000</strong> отпечатайте “<strong>ultra fast</strong>”. При по-висока скорост отпечатайте “<strong>extremely fast</strong>”. Примери:</p>
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
<td>8</td>
<td>slow</td>
<td></td>
<td>49.5</td>
<td>average</td>
<td></td>
<td>126</td>
<td>fast</td>
<td></td>
<td>160</td>
<td>ultra fast</td>
<td></td>
<td>3500</td>
<td>extremely fast</td>
</tr>
</tbody>
</table>
<h3 id="насоки-2">Насоки:</h3>
<ol type="1">
<li><p>Прочетете входните данни (<strong>скоростта</strong>): <img src="media/image10.png" style="width:4.4886in;height:0.83806in" /></p></li>
<li><p>Използвайте <strong>if</strong>-<strong>else</strong>-<strong>if</strong> конструкция, за да проверите <strong>стойностите за скоростта</strong>.</p></li>
</ol>
<blockquote>
<p><img src="media/image11.png" style="width:4.10666in;height:4.87539in" /></p>
</blockquote>
<h2 id="конвертор-за-мерни-единици">Конвертор за мерни единици</h2>
<p>Да се напише програма, която <strong>преобразува разстояние</strong> между следните <strong>3 мерни единици</strong>: <strong>mm</strong>, <strong>cm</strong>, m. Използвайте съответствията от таблицата по-долу:</p>
<table>
<thead>
<tr class="header">
<th><strong>входна единица</strong></th>
<th><strong>изходна единица</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>1</strong> meter (<strong>m</strong>)</td>
<td><strong>1000</strong> millimeters (<strong>mm</strong>)</td>
</tr>
<tr class="even">
<td><strong>1</strong> meter (<strong>m</strong>)</td>
<td><strong>100</strong> centimeters (<strong>cm</strong>)</td>
</tr>
</tbody>
</table>
<p>Входните данни се състоят от три реда, въведени от потребителя:</p>
<ul>
<li><p><strong>Първи ред:</strong> число за преобразуване - <strong>реално число</strong></p></li>
<li><p><strong>Втори ред:</strong> входна мерна единица - <strong>текст</strong></p></li>
<li><p><strong>Трети ред:</strong> изходна мерна единица (за резултата) - <strong>текст</strong></p></li>
</ul>
<p>На конзолата да се отпечата <strong>резултатът от преобразуването</strong> на мерните единици <strong>форматиран</strong> до <strong>третия знак след десетичната запетая</strong>.</p>
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
<td><p>12</p>
<p>mm</p>
<p>m</p></td>
<td>0.012</td>
<td></td>
<td><p>150</p>
<p>m</p>
<p>cm</p></td>
<td>15000.000</td>
<td></td>
<td><p>45</p>
<p>cm</p>
<p>mm</p></td>
<td>450.000</td>
</tr>
</tbody>
</table>
<h2 id="време-15-минути">Време + 15 минути</h2>
<p>Да се напише програма, която <strong>чете час и минути</strong> от 24-часово денонощие, въведени от потребителя и изчислява колко ще е <strong>часът след 15 минути</strong>. Резултатът да се отпечата във формат <strong>часове:минути</strong>. Часовете винаги са между 0 и 23, а минутите винаги са между 0 и 59. Часовете се изписват с една или две цифри. Минутите се изписват винаги с по две цифри, с <strong>водеща нула,</strong> когато е необходимо.</p>
<h3 id="примерен-вход-и-изход-1">Примерен вход и изход</h3>
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
<td><p>1</p>
<p>46</p></td>
<td>2:01</td>
<td></td>
<td><p>0</p>
<p>01</p></td>
<td>0:16</td>
<td></td>
<td><p>23</p>
<p>59</p></td>
<td>0:14</td>
<td></td>
<td><p>11</p>
<p>08</p></td>
<td>11:23</td>
<td></td>
<td><p>12</p>
<p>49</p></td>
<td>13:04</td>
</tr>
</tbody>
</table>
<h1 id="примерни-изпитни-задачи">Примерни изпитни задачи</h1>
<h2 id="годзила-срещу-конг">Годзила срещу Конг</h2>
<p>Снимките за дългоочаквания филм "Годзила срещу Конг" започват. Сценаристът Адам Уингард ви моли да <strong>напишете програма</strong>, която да изчисли, <strong>дали предвидените средства са достатъчни</strong> за снимането на филма. За снимките ще бъдат нужни <strong>определен брой статисти, облекло</strong> за всеки един статист и <strong>декор.</strong></p>
<p>Известно е, че:</p>
<ul>
<li><blockquote>
<p>Декорът за филма е <strong>на стойност 10% от бюджета.</strong></p>
</blockquote></li>
<li><blockquote>
<p>При <strong>повече от 150 статиста, има отстъпка за облеклото на стойност 10%.</strong></p>
</blockquote></li>
</ul>
<h3 id="вход">Вход</h3>
<p>От конзолата се четат <strong>3 реда</strong>:</p>
<ol type="1">
<li><blockquote>
<p><strong>Бюджет за филма – реално число в интервала [1.00 … 1000000.00]</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>Брой на статистите – цяло число в интервала [1 … 500]</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>Цена за облекло на един статист – реално число в интервала [1.00 … 1000.00]</strong></p>
</blockquote></li>
</ol>
<h3 id="изход">Изход</h3>
<p>На конзолата трябва да се отпечатат <strong>два реда</strong>:</p>
<ul>
<li><p>Ако парите за декора и дрехите <strong>са повече от бюджета</strong>:</p>
<ul>
<li><p>"<strong>Not enough money!"</strong></p></li>
<li><p><strong>"Wingard needs {парите недостигащи за филма} leva more."</strong></p></li>
</ul></li>
<li><p>Ако парите за декора и дрехите са <strong>по малко или равни на бюджета</strong>:</p>
<ul>
<li><p><strong>"Action!"</strong></p></li>
<li><p>"<strong>Wingard starts filming with {останалите пари} leva left."</strong></p></li>
</ul></li>
</ul>
<p>Резултатът трябва да е <strong>форматиран до втория знак</strong> след десетичната запетая.</p>
<h3 id="section"></h3>
<h3 id="примерен-вход-и-изход-2">Примерен вход и изход</h3>
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
<td><p>20000</p>
<p>120</p>
<p>55.5</p></td>
<td><p>Action!</p>
<p>Wingard starts filming with 11340.00 leva left.</p></td>
<td><p>Сума за декор: 10% от 20000 = 2000 лв.</p>
<p>Сума за облекло: 120 * 55.5 = 6660 лв.</p>
<p>Обща сума за филма: 2000 + 6660 = 8660 лв.</p>
<p>20000 – 8660 = 11340 лева остават.</p></td>
</tr>
<tr class="even">
<td><p>15437.62</p>
<p>186</p>
<p>57.99</p></td>
<td><p>Action!</p>
<p>Wingard starts filming with 4186.33 leva left.</p></td>
<td><p>Сума за декор: 10% от 15437.62 = 1543.762 лв.</p>
<p>Сума за облекло: 186 * 57.99 = 10786.14 лв.</p>
<p>Статистите са повече от 150 следователно има 10% отстъпка на облеклото.</p>
<p>10% от 10786.14 е 1078.614</p>
<p>10786.14 – 1078.614 = 9707.526 лв. за облекло</p>
<p>Обща сума за филма: 1543.762 + 9707.526 = 11251.288</p>
<p>15437.62 – 11251.288 = 4186.331 лева остават</p></td>
</tr>
<tr class="odd">
<td><p>9587.88</p>
<p>222</p>
<p>55.68</p></td>
<td><p>Not enough money!</p>
<p>Wingard needs 2495.77 leva more.</p></td>
<td><p>Сума за декор: 10% от 9587.88 = 958.788 лв.</p>
<p>Сума за облекло: 11124.864 лв.</p>
<p>Обща сума за филма: 958.788 + 11124.864 = 12083.652</p>
<p>9587.88 – 12083.652 = 2495.77 лева не достигат</p></td>
</tr>
</tbody>
</table>
<h2 id="световен-рекорд-по-плуване">Световен рекорд по плуване</h2>
<p>Иван решава да подобри Световния рекорд по плуване на дълги разстояния. <strong>На конзолата се въвежда рекордът в секунди, който Иван трябва да подобри, разстоянието в метри, което трябва да преплува и времето в секунди, за което плува разстояние от 1 м.</strong> Да се напише програма, която изчислява дали се е справил със задачата, като се има предвид, че: <strong>съпротивлението на водата го забавя на всеки 15 м. с 12.5 секунди.</strong> Когато се изчислява колко пъти Иванчо ще се забави, в резултат на съпротивлението на водата, <strong>резултатът трябва да се закръгли надолу до най-близкото цяло число.</strong></p>
<p><strong>Да се изчисли времето в секунди, за което Иванчо ще преплува разстоянието и разликата спрямо Световния рекорд.</strong></p>
<h3 id="вход-1">Вход</h3>
<p>От конзолата се четат <strong>3 реда</strong>:</p>
<ol type="1">
<li><p><strong>Рекордът в секунди – реално число в интервала [0.00 … 100000.00]</strong></p></li>
<li><p><strong>Разстоянието в метри – реално число в интервала [0.00 … 100000.00]</strong></p></li>
<li><p><strong>Времето в секунди, за което плува разстояние от 1 м.</strong> <strong>- реално число в интервала [0.00 … 1000.00]</strong></p></li>
</ol>
<h3 id="изход-1">Изход</h3>
<p>Отпечатването на конзолата зависи от резултата:</p>
<ul>
<li><p>Ако <strong>Иван е подобрил Световния рекорд</strong> отпечатваме:</p>
<ul>
<li><p><strong>"</strong> <strong>Yes, he succeeded! The new world record is {времето на Иван} seconds."</strong></p></li>
</ul></li>
<li><p>Ако <strong>НЕ е подобрил рекорда</strong> отпечатваме:</p>
<ul>
<li><p><strong>"No, he failed! He was {недостигащите секунди} seconds slower."</strong></p></li>
</ul></li>
</ul>
<p><strong>Резултатът трябва да се форматира до втория знак след десетичната запетая</strong>.</p>
<h3 id="примерен-вход-и-изход-3">Примерен вход и изход</h3>
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
<td><p>10464</p>
<p>1500</p>
<p>20</p></td>
<td>No, he failed! He was 20786.00 seconds slower.</td>
<td><p><strong>Иван трябва да преплува 1500 м.: 1500 * 20 = 30000 сек.</strong></p>
<p><strong>На всеки 15 м. към времето му се добавят 12.5 сек.:</strong></p>
<p><strong>1500 / 15 = 100 * 12.5 = 1250 сек.</strong></p>
<p><strong>Общо време: 30000 + 1250 = 31250 сек.</strong></p>
<p><strong>10464 &lt; 31250</strong></p>
<p><strong>Времето, което не му е стигнало за да подобри рекорда:</strong></p>
<p><strong>31250 – 10464 = 20786 сек.</strong></p></td>
</tr>
<tr class="even">
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
<td><strong>Обяснения</strong></td>
</tr>
<tr class="odd">
<td><p>55555.67</p>
<p>3017</p>
<p>5.03</p></td>
<td>Yes, he succeeded! The new world record is 17688.01 seconds.</td>
<td><p><strong>Иван трябва да преплува 3017 м.: 3017 * 5.03 = 15175.51 сек.</strong></p>
<p><strong>На всеки 15 м. към времето му се добавят 12.5 сек.:</strong></p>
<p><strong>3017/ 15 = 201 * 12.5 = 2512.50 сек.</strong></p>
<p><strong>Общо време: 15175.51 + 2512.50 = 17688.01 сек.</strong></p>
<p><strong>Рекордът е подобрен: 55555.67 &gt; 17688.01</strong></p></td>
</tr>
</tbody>
</table>
<h2 id="стипендии">*Стипендии</h2>
<p>Учениците могат да кандидатстват за <strong>социална стипендия</strong> или за <strong>стипендия за отличен успех</strong>. Изискване за социална стипендия - <strong>доход на член от семейството по-малък от минималната работна заплата и успех над 4.5</strong>. Размер на социалната стипендия - <strong>35% от минималната работна заплата</strong>. Изискване за стипендия за отличен успех - <strong>успех над 5.5, включително</strong>. Размер на стипендията за отличен успех - <strong>успехът на ученика, умножен по коефициент 25</strong>.</p>
<p>Напишете програма, която при въведени <strong>доход</strong>, <strong>успех</strong> и <strong>минимална</strong> <strong>работна</strong> <strong>заплата</strong>, дава информация дали ученик има право да получава стипендия, и стойността на стипендията, която <strong>е по-висока</strong> за него.</p>
<h3 id="вход-2">Вход</h3>
<p>Потребителят въвежда <strong>3 числа</strong>, по едно на ред:</p>
<ol type="1">
<li><p><strong>Доход в лева - реално число в интервала [0.00..6000.00]</strong></p></li>
<li><p><strong>Среден успех -</strong> <strong>реално число в интервала [2.00...6.00]</strong></p></li>
<li><p><strong>Минимална работна заплата - реално число в интервала [0.00..1000.00]</strong></p></li>
</ol>
<h3 id="изход-2">Изход</h3>
<ul>
<li><p>Ако ученикът <strong>няма право да получава стипендия</strong>, се извежда:</p></li>
</ul>
<p><strong>"You cannot get a scholarship!"</strong></p>
<ul>
<li><p>Ако ученикът има право да получава <strong>само</strong> социална стипендия:<br />
<strong>"You get a Social scholarship {стойност на стипендия} BGN"</strong></p></li>
<li><p>Ако ученикът <strong>има право да получава само стипендия за отличен успех</strong>:</p></li>
</ul>
<p><strong>"You get a scholarship for excellent results {стойност на стипендията} BGN"</strong></p>
<ul>
<li><p><strong>Ако ученикът има право да получава и двата типа стипендии, ще получи по-голямата по сума, а ако са равни ще получи тази за отличен успех.</strong></p></li>
</ul>
<p><strong>Резултатът се закръгля до по-малкото цяло число.</strong></p>
<h3 id="примерен-вход-и-изход-4">Примерен вход и изход</h3>
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
<td><p>480.00</p>
<p>4.60</p>
<p>450.00</p></td>
<td>You cannot get a scholarship!</td>
<td><p>Доходът от 480 лв. е по-висок от минималната работна заплата 450 лв. → ученикът не може да получава социална стипендия.</p>
<p>Успех 4.60 &lt; 5.50 → ученикът не може да получава стипендия за отличен успех.</p></td>
</tr>
<tr class="even">
<td><p>300.00</p>
<p>5.65</p>
<p>420.00</p></td>
<td>You get a Social scholarship 147 BGN</td>
<td><p>300 лв. &lt; 420 лв. и 5.65 &gt;4.50 → ученикът може да получава социална стипендия 35% * 420 лв. = 147 лв.</p>
<p>Успех 5.65 &gt; 5.50 → ученикът може да получава стипендия за отличен успех 5.65 * 25 = 141.25 лв.</p>
<p>147 лв. &gt; 141.25 лв. → ученикът ще получава социална стипендия.</p></td>
</tr>
</tbody>
</table>
