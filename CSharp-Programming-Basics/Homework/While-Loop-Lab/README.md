<p><strong>Лаб: Повторения с цикли – While-цикъл</strong></p>
<p>Задачи за упражнение и домашно към курса <a href="https://softuni.bg/courses/programming-basics">"Основи на програмирането" в СофтУни</a>.</p>
<p><strong>Тествайте</strong> решението си в <strong>judge системата</strong>: <a href="https://judge.softuni.bg/Contests/2383">https://judge.softuni.bg/Contests/2383</a></p>
<h2 id="четене-на-думи">Четене на думи</h2>
<p>Напишете програма, която чете текст от конзолата(стринг) и го принтира, докато не получи командата "<strong>Stop</strong>".<br />
<strong>Примерен вход и изход</strong></p>
<table>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Nakov</p>
<p>SoftUni</p>
<p>Sofia</p>
<p>Bulgaria</p>
<p>SomeText</p>
<p>Stop</p>
<p>AfterStop</p>
<p>Europe</p>
<p>HelloWorld</p></td>
<td><p>Nakov</p>
<p>SoftUni</p>
<p>Sofia</p>
<p>Bulgaria</p>
<p>SomeText</p></td>
<td></td>
<td><p>Sofia</p>
<p>Berlin</p>
<p>Moscow<br />
Athens</p>
<p>Madrid</p>
<p>London</p>
<p>Paris</p>
<p>Stop</p>
<p>AfterStop</p></td>
<td><p>Sofia</p>
<p>Berlin</p>
<p>Moscow<br />
Athens</p>
<p>Madrid</p>
<p>London</p>
<p>Paris</p></td>
</tr>
</tbody>
</table>
<h2 id="парола">Парола</h2>
<p>Напишете програма, която първоначално прочита име и парола на потребителски профил. След това чете парола за вход, при въвеждане на грешна парола, потребителя да се подкани да въведе нова парола.</p>
<h3 id="примерен-вход-и-изход">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Nakov</p>
<p>1234</p>
<p>pass</p>
<p>1324</p>
<p>1234</p></td>
<td>Welcome Nakov!</td>
<td></td>
<td><p>Gosho</p>
<p>secret</p>
<p>secret</p></td>
<td>Welcome Gosho!</td>
</tr>
</tbody>
</table>
<h3 id="насоки">Насоки</h3>
<ol type="1">
<li><p>Инициализирайте две променливи <strong>username и password</strong>, които ще съдържат потребителското име и паролата:</p></li>
</ol>
<p><img src="media/image1.png" style="width:3.31458in;height:0.48429in" /></p>
<ol start="2" type="1">
<li><p>Инициализирайте променлива <strong>input</strong>, която ще държи въведената от потребителя парола за вход:</p></li>
</ol>
<p><img src="media/image2.png" style="width:3.04375in;height:0.23125in" /></p>
<ol start="3" type="1">
<li><p>В <strong>while</strong> цикъл, до въвеждане на валидна парола, четете нова:</p></li>
</ol>
<p><img src="media/image3.png" style="width:2.69792in;height:0.8168in" /></p>
<ol start="4" type="1">
<li><p>Когато се въведе <strong>валидна парола</strong> <strong>принтирайте съобщението за успешен вход</strong>:</p></li>
</ol>
<p><img src="media/image4.png" style="width:3.75in;height:2.07367in" /></p>
<h2 id="сума-от-числа">Сума от числа</h2>
<p>Напишете програма, която чете цяло число от конзолата и на всеки следващ ред цели числа, докато тяхната сума стане по-голяма или равна на първоначалното число.. След приключване да се отпечата <strong>сумата на въведените числа</strong>.</p>
<p><strong>Примерен вход и изход</strong></p>
<table>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>100</p>
<p>10</p>
<p>20</p>
<p>30</p>
<p>40</p></td>
<td>100</td>
<td></td>
<td><p>20</p>
<p>1</p>
<p>2</p>
<p>3</p>
<p>4</p>
<p>5</p>
<p>6</p></td>
<td>21</td>
</tr>
</tbody>
</table>
<h2 id="редица-числа-2k1">Редица числа 2K+1</h2>
<p>Напишете програма, която чете число <strong>n</strong>, въведено от потребителя, и отпечатва <strong>всички числа ≤ n от редицата</strong>: 1, 3, 7, 15, 31, …. Всяко следващо число се изчислява като умножим <strong>предишното</strong> с <strong>2</strong> и добавим <strong>1</strong>.</p>
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
</tr>
</thead>
<tbody>
<tr class="odd">
<td>3</td>
<td><p>1</p>
<p>3</p></td>
<td></td>
<td>8</td>
<td><p>1</p>
<p>3</p>
<p>7</p></td>
<td></td>
<td>17</td>
<td><p>1</p>
<p>3</p>
<p>7</p>
<p>15</p></td>
<td></td>
<td>31</td>
<td><p>1</p>
<p>3</p>
<p>7</p>
<p>15</p>
<p>31</p></td>
</tr>
</tbody>
</table>
<h3 id="насоки-1">Насоки</h3>
<ol type="1">
<li><p>Прочетете от конзолата цяло число.</p></li>
</ol>
<p><img src="media/image5.png" style="width:3.6875in;height:0.215in" /></p>
<ol start="2" type="1">
<li><p>Създайте променлива от тип <strong>цяло число</strong>, която ще е брояч и има <strong>първоначална стойност 1</strong>.</p></li>
</ol>
<p><img src="media/image6.png" style="width:0.9375in;height:0.23611in" /></p>
<ol start="3" type="1">
<li><p>Създайте <strong>while</strong> цикъл, който се повтаря докато <strong>брояча е по-малък</strong> или равен на числото, което сте прочели от конзолата.</p></li>
</ol>
<p><img src="media/image7.png" style="width:1.80556in;height:1.14182in" /></p>
<ol start="4" type="1">
<li><p>При всяко повторение на цикъла <strong>принтирайте стойността на брояча</strong> и му <strong>прибавяйте дадената стойност</strong>.</p></li>
</ol>
<p><img src="media/image8.png" style="width:2in;height:0.96055in" /></p>
<h2 id="баланс-по-сметка">Баланс по сметка</h2>
<p>Напишете програма, която пресмята колко общо пари има в сметката, след като направите определен брой вноски. На всеки ред ще получавате сумата, която трябва да внесете в сметката, <strong>до получаване на команда "NoMoreMoney"</strong> . При всяка получена сума на конзолата трябва да се извежда <strong>"Increase: "</strong> + сумата и тя да се <strong>прибавя в сметката</strong>. Ако получите число <strong>по-малко от 0</strong> на конзолата трябва да се изведе <strong>"Invalid operation!"</strong> и <strong>програмата да приключи</strong>. Когато програмата приключи трябва да се принтира <strong>"Total: "</strong> + общата сума в сметката закръглена до втория знак след десетичната запетая.</p>
<h3 id="примерен-вход-и-изход-2">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>5.51</p>
<p>69.42</p>
<p>100</p>
<p>NoMoreMoney</p></td>
<td><p>Increase: 5.51</p>
<p>Increase: 69.42</p>
<p>Increase: 100</p>
<p>Total: 174.93</p></td>
<td></td>
<td><p>120</p>
<p>45.55</p>
<p>-150</p></td>
<td><p>Increase: 120</p>
<p>Increase: 45.55</p>
<p>Invalid operation!</p>
<p>Total: 165.55</p></td>
</tr>
</tbody>
</table>
<h2 id="най-голямо-число">Най-голямо число</h2>
<p>Напишете програма, която до получаване на <strong>командата "Stop",</strong> чете <strong>цели числа</strong>, въведени от потребителя, и намира <strong>най-голямото</strong> измежду тях. Въвежда се по едно число на ред.</p>
<h3 id="примерен-вход-и-изход-3">Примерен вход и изход</h3>
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
<td><p>100</p>
<p>99</p>
<p>80</p>
<p>70</p>
<p>Stop</p></td>
<td>100</td>
<td></td>
<td><p>-10</p>
<p>20</p>
<p>-30</p>
<p>Stop</p></td>
<td>20</td>
<td></td>
<td><p>45</p>
<p>-20</p>
<p>7</p>
<p>99</p>
<p>Stop</p></td>
<td>99</td>
<td></td>
<td><p>999</p>
<p>Stop</p></td>
<td>999</td>
<td></td>
<td><p>-1</p>
<p>-2</p>
<p>Stop</p></td>
<td>-1</td>
</tr>
</tbody>
</table>
<h2 id="най-малко-число">Най-малко число</h2>
<p>Напишете програма, която до получаване на <strong>командата "Stop",</strong> чете <strong>цели числа</strong>, въведени от потребителя, и намира <strong>най-малкото</strong> измежду тях. Въвежда се по едно число на ред.</p>
<h3 id="примерен-вход-и-изход-4">Примерен вход и изход</h3>
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
<td><p>100</p>
<p>99</p>
<p>80</p>
<p>70</p>
<p>Stop</p></td>
<td>70</td>
<td></td>
<td><p>-10</p>
<p>20</p>
<p>-30</p>
<p>Stop</p></td>
<td>-30</td>
<td></td>
<td><p>45</p>
<p>-20</p>
<p>7</p>
<p>99</p>
<p>Stop</p></td>
<td>-20</td>
<td></td>
<td><p>999</p>
<p>Stop</p></td>
<td>999</td>
<td></td>
<td><p>-1</p>
<p>-2</p>
<p>Stop</p></td>
<td>-2</td>
</tr>
</tbody>
</table>
<h2 class="list-paragraph" id="section"></h2>
<p><strong>8. Завършване – част 2</strong></p>
<p>Напишете програма, която изчислява <strong>средната оценка</strong> на ученик от цялото му обучение. На първия ред ще получите <strong>името на ученика</strong>, а на всеки следващ ред неговите годишни оценки. Ученикът преминава в следващия клас, <strong>ако годишната му оценка е по-голяма или равна на 4.00</strong>. <strong>Ако ученикът бъде скъсан повече от един път, то той бива изключен и програмата приключва,</strong> като се отпечатва <strong>името на ученика и в кой клас бива изключен</strong>.</p>
<p>При успешно завършване на <strong>12-ти</strong> клас да се отпечата :</p>
<p>"<strong>{име на ученика} graduated. Average grade:</strong> <strong>{средната оценка от цялото обучение}</strong>"</p>
<p><strong>В случай, че ученикът е изключен от училище,</strong> да се отпечата<strong>:</strong></p>
<p>"<strong>{име на ученика} has been excluded at {класа, в който е бил изключен} grade</strong>"</p>
<p><strong>Стойността трябва да бъде форматирана до втория знак</strong> след десетичната запетая.</p>
<h3 id="примерен-вход-и-изход-5">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th></th>
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Gosho</p>
<p>5</p>
<p>5.5</p>
<p>6</p>
<p>5.43</p>
<p>5.5</p>
<p>6</p>
<p>5.55</p>
<p>5</p>
<p>6</p>
<p>6</p>
<p>5.43</p>
<p>5</p></td>
<td>Gosho graduated. Average grade: 5.53</td>
<td></td>
<td><p>Mimi</p>
<p>5</p>
<p>6</p>
<p>5</p>
<p>6</p>
<p>5</p>
<p>6</p>
<p>6</p>
<p>2</p>
<p>3</p></td>
<td>Mimi has been excluded at 8 grade</td>
</tr>
</tbody>
</table>
<h1 id="section-1"></h1>
<h1 id="примерна-изпитна-задача">Примерна изпитна задача </h1>
<h2 id="преместване">*Преместване</h2>
<p>На осемнадесетия си рожден ден на Хосе взел решение, че ще се изнесе да живее на квартира. Опаковал багажа си в <strong>кашони</strong> и намерил подходяща обява за апартамент под наем. Той започва да пренася своя багаж <strong>на части</strong>, защото не може да пренесе целия наведнъж. Има ограничено <strong>свободно пространство</strong> в новото си жилище, където може да разположи вещите, така че мястото да бъде подходящо за живеене.</p>
<p>Напишете <strong>програма, която изчислява свободния обем от жилището на Хосе, който остава след като пренесе багажа си.</strong></p>
<p><strong>Бележка: Един кашон е с точни размери: 1m. x 1m. x 1m.</strong></p>
<h3 id="вход">Вход</h3>
<p>Потребителят въвежда следните данни на отделни редове:</p>
<ol type="1">
<li><p><strong>Широчина на свободното пространство - цяло число в интервала [1...1000]</strong></p></li>
<li><p><strong>Дължина на свободното пространство - цяло число в интервала [1...1000]</strong></p></li>
<li><p><strong>Височина на свободното пространство - цяло число в интервала [1...1000]</strong></p></li>
<li><p>На следващите редове <strong>(до получаване на команда "Done") -</strong> <strong>брой кашони, които се пренасят в квартирата - цели числа в интервала [1...10000];</strong></p></li>
</ol>
<p><strong>Програмата трябва да приключи прочитането на данни при команда "Done"</strong> <strong>или ако свободното място свърши.</strong></p>
<h3 id="изход">Изход</h3>
<p>Да се <strong>отпечата</strong> на конзолата <strong>един</strong> от следните редове:</p>
<ul>
<li><p>Ако стигнете до командата <strong>"Done"</strong> и има още свободно място:</p></li>
</ul>
<blockquote>
<p><strong>"{брой свободни куб. метри} Cubic meters left."</strong></p>
</blockquote>
<ul>
<li><p>Ако свободното място свърши преди да е дошла команда <strong>"Done":</strong></p></li>
</ul>
<blockquote>
<p><strong>"No more free space! You need {брой недостигащи куб. метри} Cubic meters more."</strong></p>
</blockquote>
<p><strong>Примерен вход и изход</strong></p>
<table>
<thead>
<tr class="header">
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
<th><strong>Обяснение</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>10</p>
<p>10</p>
<p>2</p>
<p>20</p>
<p>20</p>
<p>20</p>
<p>20</p>
<p>122</p></td>
<td>No more free space! You need 2 Cubic meters more.</td>
<td>10 * 10 * 2 = <strong>200 кубични метра.</strong><br />
20 + 20 + 20 + 20 + 122 = <strong>202</strong> <strong>кубични метра.<br />
</strong>200 - 202 = <strong>2 недостигащи</strong> кубични метра</td>
</tr>
<tr class="even">
<td><p>10</p>
<p>1</p>
<p>2</p>
<p>4</p>
<p>6</p>
<p><strong>Done</strong></p></td>
<td>10 Cubic meters left.</td>
<td>10 * 1 * 2 = <strong>20 кубични метра.</strong><br />
4 + 6 = <strong>10</strong> <strong>кубични метра.<br />
</strong>20 - 10 = <strong>10 кубични метра.</strong></td>
</tr>
</tbody>
</table>
