<h1 id="лаб-условни-конструкции">Лаб: Условни конструкции</h1>
<p>Задачи за упражнение в клас и за домашно към курса <a href="https://softuni.bg/courses/programming-basics">"Основи на програмирането" @ СофтУни</a>.</p>
<p>Тествайте решенията си в <strong>Judge</strong> системата: <a href="https://judge.softuni.bg/Contests/2369">https://judge.softuni.bg/Contests/2369</a></p>
<h2 id="празно-visual-studio-решение-blank-project">Празно Visual Studio решение (Blank Project)</h2>
<p>Създайте празно решение (<strong>Blank Solution</strong>) във Visual Studio. Решенията (solutions) във Visual Studio обединяват <strong>група проекти</strong>. Тази възможност е изключително удобна, когато искаме да работим по няколко проекта и бързо да превключваме между тях или искаме да обединим логически няколко взаимосвързани проекта.</p>
<p>В настоящото практическо занимание ще използваме <strong>Blank Solution с няколко проекта,</strong> за да организираме решенията на задачите от упражненията – всяка задача в отделен проект и всички проекти в общ solution.</p>
<ol type="1">
<li><p>Стартирайте Visual Studio.</p></li>
<li><p>Създайте нов проект: [Create a new project].</p></li>
</ol>
<p><img src="media/image1.png" style="width:6.37539in;height:4.4197in" alt="A screenshot of a social media post Description automatically generated" /></p>
<ol start="3" type="1">
<li><p>Изберете [Black solution], ако не го виждате, в търсачката изпишете ["Blank solution"].</p></li>
</ol>
<blockquote>
<p><img src="media/image2.png" style="width:6.29049in;height:4.36506in" alt="A screenshot of a cell phone Description automatically generated" /></p>
</blockquote>
<ol start="4" type="1">
<li><p>Задайте подходящо име на проекта, например "<strong>Conditional-Statements</strong>":</p></li>
</ol>
<p><img src="media/image3.png" style="width:6.23591in;height:4.58294in" alt="A screenshot of a cell phone Description automatically generated" /></p>
<p>Сега имате създаден <strong>празен Visual Studio Solution</strong> (с 0 проекта в него):</p>
<p><img src="media/image4.png" style="width:5.97491in;height:3.04271in" alt="A screenshot of a social media post Description automatically generated" /></p>
<p>Целта на този blank solution e да добавяте в него <strong>по един проект за всяка задача</strong> от упражненията.</p>
<h2 id="проверка-за-отлична-оценка">Проверка за отлична оценка</h2>
<p>Първата задача от тази тема е да се напише <strong>конзолна програма</strong>, която <strong>чете оценка</strong> (десетично число), въведена от потребителя и отпечатва "<strong>Excellent!",</strong> ако оценката е <strong>5.50</strong> или по-висока.</p>
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
<td>6</td>
<td>Excellent!</td>
<td></td>
<td>5</td>
<td><em>(няма изход)</em></td>
<td></td>
<td>5.50</td>
<td>Excellent!</td>
<td></td>
<td>5.49</td>
<td><em>(няма изход)</em></td>
</tr>
</tbody>
</table>
<h3 id="насоки">Насоки:</h3>
<ol type="1">
<li><p>Създайте <strong>нов C# конзолен проект</strong> с име "<strong>ExcellentResult</strong>" в <strong>Blanc Project</strong> с име " <strong>Conditional-Statements</strong> ", като натиснем с десен бутон на мишката в/у <strong>Solution Condition-Statements-&gt;</strong> <strong>add -&gt; New Project...</strong>:</p></li>
</ol>
<blockquote>
<p><img src="media/image5.png" style="width:4.7086in;height:2.70558in" alt="A screenshot of a social media post Description automatically generated" /></p>
<p><img src="media/image6.png" style="width:5.34709in;height:3.71555in" alt="A screenshot of a cell phone Description automatically generated" /> <img src="media/image7.png" style="width:5.35701in;height:3.71217in" alt="A screenshot of a cell phone Description automatically generated" /></p>
</blockquote>
<ol start="2" type="1">
<li><p>Вече имате създаден клас със <strong>Main метод</strong></p></li>
</ol>
<blockquote>
<p><img src="media/image8.png" style="width:3.76219in;height:2.3611in" alt="A screenshot of a cell phone Description automatically generated" /></p>
</blockquote>
<ol start="3" type="1">
<li><p>Отидете в тялото на метода <strong>Main(string[]</strong> <strong>args)</strong> (между къдравите скоби). Създайте една променлива, в която да запазите <strong>реално</strong> <strong>число</strong> – оценката, което ще прочетете от конзолата:</p></li>
</ol>
<blockquote>
<p><img src="media/image9.png" style="width:5.46973in;height:2.47829in" alt="A screenshot of a cell phone Description automatically generated" /></p>
</blockquote>
<ol start="4" type="1">
<li><p>Направете проверка за стойността на оценката. Ако тя е по-голяма или равна на 5.50 отпечатайте изхода по условие:</p></li>
</ol>
<blockquote>
<p><img src="media/image10.png" style="width:5.54312in;height:2.00046in" /></p>
</blockquote>
<ol start="5" type="1">
<li><p>Стартирайте програмата с <strong>Ctrl + F5</strong> и я <strong>тествайте</strong> с различни входни стойности:</p></li>
</ol>
<blockquote>
<p><img src="media/image11.png" style="width:2.48958in;height:1.21875in" /><img src="media/image12.png" style="width:3.00379in;height:1.21911in" /></p>
</blockquote>
<h2 id="намиране-на-по-голямото-число">Намиране на по-голямото число</h2>
<p>Да се напише програма, която чете <strong>две цели числа</strong> въведени от потребителя и отпечатва <strong>по-голямото от двете</strong>.</p>
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
<td><p>5</p>
<p>3</p></td>
<td>5</td>
<td></td>
<td><p>3</p>
<p>5</p></td>
<td>5</td>
<td></td>
<td><p>10</p>
<p>10</p></td>
<td>10</td>
<td></td>
<td><p>-5</p>
<p>5</p></td>
<td>5</td>
</tr>
</tbody>
</table>
<h3 id="насоки-1">Насоки:</h3>
<ol type="1">
<li><p>Прочетете две цели числа от конзолата:</p></li>
</ol>
<p><img src="media/image13.png" style="width:4.432in;height:1.18187in" alt="A screenshot of a cell phone Description automatically generated" /></p>
<ol start="2" type="1">
<li><p>Сравнете, дали първото число <strong>num1</strong> e по-голямо от второто <strong>num2</strong>. Отпечатайте по-голямото число.</p></li>
</ol>
<p><img src="media/image14.png" style="width:3.60417in;height:2.4375in" alt="A screenshot of a cell phone Description automatically generated" /></p>
<h2 id="четно-или-нечетно">Четно или нечетно</h2>
<p>Да се напише програма, която чете <strong>цяло число</strong> въведено от потребителя и отпечатва на конзолата, дали е <strong>четно</strong> или <strong>нечетно</strong>.</p>
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
<td>2</td>
<td>even</td>
<td></td>
<td>3</td>
<td>odd</td>
<td></td>
<td>25</td>
<td>odd</td>
<td></td>
<td>1024</td>
<td>even</td>
</tr>
</tbody>
</table>
<h3 id="насоки-2">Насоки:</h3>
<ol type="1">
<li><p>Първо добавете <strong>нов конзолен проект</strong> към съществуващия проект</p></li>
<li><p>Прочетете eдно цяло число от конзолата:</p></li>
</ol>
<blockquote>
<p><img src="media/image15.png" style="width:4.48333in;height:1.71734in" alt="A screenshot of a cell phone Description automatically generated" /></p>
</blockquote>
<ol start="3" type="1">
<li><p>Проверете, дали числото е четно, като използвате модуло оператора с 2 и проверите, дали има остатък от целочисленото деление. Отпечатайте изхода по условие – текста "<strong>even</strong>":</p></li>
</ol>
<blockquote>
<p><img src="media/image16.png" style="width:4.49803in;height:1.97679in" alt="A screenshot of a cell phone Description automatically generated" /></p>
</blockquote>
<ol start="4" type="1">
<li><p>В противен случай отпечатайте "<strong>odd</strong>":</p></li>
</ol>
<blockquote>
<p><img src="media/image17.png" style="width:4.48333in;height:2.87798in" alt="A screenshot of a cell phone Description automatically generated" /></p>
</blockquote>
<h2 id="число-от-100-до-200">Число от 100 до 200</h2>
<p>Да се напише програма, която <strong>чете цяло число</strong>, въведено от потребителя и проверява, дали е <strong>под 100</strong>, <strong>между 100 и 200</strong> или <strong>над 200</strong>. Да се отпечатат съответно съобщения, като в примерите по-долу:</p>
<h3 id="примерен-вход-и-изход-2">Примерен вход и изход</h3>
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
<td>95</td>
<td>Less than 100</td>
<td></td>
<td>120</td>
<td>Between 100 and 200</td>
<td></td>
<td>210</td>
<td>Greater than 200</td>
</tr>
</tbody>
</table>
<h2 id="познай-паролата">Познай паролата</h2>
<p>Да се напише програма, която <strong>чете парола</strong> (един ред с произволен текст), въведена от потребителя и проверява, дали въведеното <strong>съвпада</strong> с фразата "<strong>s3cr3t!P@ssw0rd</strong>". При съвпадение да се изведе "<strong>Welcome</strong>". При несъвпадение да се изведе "<strong>Wrong password!</strong>".</p>
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
</tr>
</thead>
<tbody>
<tr class="odd">
<td>qwerty</td>
<td>Wrong password!</td>
<td></td>
<td>s3cr3t!P@ssw0rd</td>
<td>Welcome</td>
<td></td>
<td>s3cr3t!p@ss</td>
<td>Wrong password!</td>
</tr>
</tbody>
</table>
<h2 id="лица-на-фигури">Лица на фигури</h2>
<p>Да се напише програма, в която потребителят <strong>въвежда вида и размерите на геометрична</strong> фигура и пресмята лицето й. Фигурите са четири вида: квадрат (<strong>square</strong>), правоъгълник (<strong>rectangle</strong>), кръг (<strong>circle</strong>) и триъгълник (<strong>triangle</strong>). На първия ред на входа се чете вида на фигурата (<strong>square</strong>, <strong>rectangle</strong>, <strong>circle</strong> или <strong>triangle</strong>).</p>
<ul>
<li><p>Ако фигурата е <strong>квадрат</strong>, на следващия ред се чете едно число - дължина на страната му.</p></li>
<li><p>Ако фигурата е <strong>правоъгълник</strong>, на следващите два реда четат две числа - дължините на страните му.</p></li>
<li><p>Ако фигурата е <strong>кръг</strong>, на следващия ред чете едно число - радиусът на кръга.</p></li>
<li><p>Ако фигурата е <strong>триъгълник</strong>, на следващите два реда четат две числа - дължината на страната му и дължината на височината към нея.</p></li>
</ul>
<p>Резултатът да се закръгли до <strong>3 цифри след десетичната точка</strong>.</p>
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
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>square</p>
<p>5</p></td>
<td>25.000</td>
<td></td>
<td><p>rectangle</p>
<p>7</p>
<p>2.5</p></td>
<td>17.500</td>
<td></td>
<td><p>circle</p>
<p>6</p></td>
<td>113.097</td>
<td></td>
<td><p>triangle</p>
<p>4.5</p>
<p>20</p></td>
<td>45.000</td>
</tr>
</tbody>
</table>
<h1 id="примерна-изпитна-задача">Примерна изпитна задача</h1>
<h2 id="магазин-за-детски-играчки">Магазин за детски играчки</h2>
<p>Петя има магазин за детски играчки. Тя получава голяма поръчка, която трябва да изпълни. С парите, които ще спечели иска да отиде на екскурзия. Да се напише програма, която пресмята печалбата от поръчката.</p>
<p><strong>Цени на играчките:</strong></p>
<ul>
<li><p><strong>Пъзел - 2.60 лв.</strong></p></li>
<li><p><strong>Говореща кукла - 3 лв.</strong></p></li>
<li><p><strong>Плюшено мече - 4.10 лв.</strong></p></li>
<li><p><strong>Миньон - 8.20 лв.</strong></p></li>
<li><p><strong>Камионче - 2 лв.</strong></p></li>
</ul>
<p>Ако поръчаните играчки са <strong>50 или повече</strong> магазинът прави <strong>отстъпка 25%</strong> <strong>от общата цена</strong>. От спечелените пари Петя трябва да даде <strong>10% за наема</strong> на магазина. Да се пресметне дали парите ще ѝ стигнат да отиде на екскурзия.</p>
<p>От конзолата се четат <strong>6 реда</strong>:</p>
<ol type="1">
<li><p><strong>Цена на екскурзията - реално число в интервала [1.00 … 10000.00]</strong></p></li>
<li><p><strong>Брой пъзели - цяло число в интервала [0… 1000]</strong></p></li>
<li><p><strong>Брой говорещи кукли - цяло число в интервала [0 … 1000]</strong></p></li>
<li><p><strong>Брой плюшени мечета - цяло число в интервала [0 … 1000]</strong></p></li>
<li><p><strong>Брой миньони - цяло число в интервала [0 … 1000]</strong></p></li>
<li><p><strong>Брой камиончета - цяло число в интервала [0 … 1000]</strong></p></li>
</ol>
<p>На конзолата се отпечатва:</p>
<ul>
<li><p>Ако <strong>парите са достатъчни</strong> се отпечатва:</p>
<ul>
<li><p><strong>"Yes! {оставащите пари} lv left."</strong></p></li>
</ul></li>
<li><p>Ако <strong>парите НЕ са достатъчни</strong> се отпечатва:</p>
<ul>
<li><p><strong>"Not enough money! {недостигащите пари} lv needed."</strong></p></li>
</ul></li>
</ul>
<p><strong>Резултатът трябва да се форматира до втория знак след десетичната запетая</strong>.</p>
<h3 id="примерен-вход-и-изход-5">Примерен вход и изход</h3>
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
<td><p>40.8</p>
<p>20</p>
<p>25</p>
<p>30</p>
<p>50</p>
<p>10</p></td>
<td>Yes! 418.20 lv left.</td>
<td><p><strong>Сума</strong>: 20 * 2.60 + 25 * 3 + 30 * 4.10 + 50 * 8.20 + 10 * 2 = <strong>680</strong> лв.</p>
<p><strong>Брой на играчките</strong>: 20 + 25 + 30 + 50 + 10 = <strong>135</strong></p>
<p><strong>135 &gt; 50 =&gt; 25% отстъпка</strong>; 25% от 680 = <strong>170 лв. отстъпка</strong></p>
<p><strong>Крайна цена</strong>: 680 – 170 = <strong>510</strong> лв.</p>
<p><strong>Наем</strong>: 10% от 510 лв. = <strong>51</strong> лв.</p>
<p><strong>Печалба</strong>: 510 – 51 = <strong>459</strong> лв.</p>
<p><strong>459 &gt; 40.8</strong> =&gt; 459 – 40.8 = <strong>418.20</strong> лв. <strong>остават</strong></p></td>
</tr>
<tr class="even">
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
<td><strong>Обяснения</strong></td>
</tr>
<tr class="odd">
<td><p>320</p>
<p>8</p>
<p>2</p>
<p>5</p>
<p>5</p>
<p>1</p></td>
<td>Not enough money! 238.73 lv needed.</td>
<td><p><strong>Сума</strong>: <strong>90.3</strong> лв.</p>
<p><strong>Брой на играчките</strong>: <strong>21</strong></p>
<p><strong>21 &lt; 50 =&gt; няма отстъпка</strong></p>
<p><strong>Наем</strong>: 10% от 90.3 = <strong>9.03</strong> лв.</p>
<p><strong>Печалба</strong>: 90.3 – 9.03 = <strong>81.27</strong> лв.</p>
<p><strong>81.27 &lt; 320</strong> =&gt; 320 – 81.27 = <strong>238.73</strong> лв. <strong>не достигат</strong></p></td>
</tr>
</tbody>
</table>
