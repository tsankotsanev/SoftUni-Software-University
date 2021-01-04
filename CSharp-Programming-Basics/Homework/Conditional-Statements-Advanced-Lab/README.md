<h1 id="лаб-вложени-условни-конструкции">Лаб: Вложени условни конструкции</h1>
<p>Задачи за упражнение в клас и за домашно към курса <a href="https://softuni.bg/trainings/3038/programming-basics-with-c-sharp-july-2020">"Основи на програмирането" @ СофтУни</a>.</p>
<p><strong>Тествайте</strong> решението си в <strong>judge системата</strong>: <a href="https://judge.softuni.bg/Contests/2377">https://judge.softuni.bg/Contests/2377</a></p>
<h2 id="ден-от-седмицата">Ден от седмицата</h2>
<p>Напишете програма, която чете <strong>цяло</strong> <strong>число</strong>, въведено от потребителя, и отпечатва <strong>ден от седмицата</strong> (на английски език), в граници [1...7] или отпечатва "<strong>Error</strong>" в случай, че въведеното число е <strong>невалидно</strong>.</p>
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
<td>1</td>
<td>Monday</td>
</tr>
<tr class="even">
<td>2</td>
<td>Tuesday</td>
</tr>
<tr class="odd">
<td>3</td>
<td>Wednesday</td>
</tr>
<tr class="even">
<td>4</td>
<td>Thursday</td>
</tr>
<tr class="odd">
<td>5</td>
<td>Friday</td>
</tr>
<tr class="even">
<td>6</td>
<td>Saturday</td>
</tr>
<tr class="odd">
<td>7</td>
<td>Sunday</td>
</tr>
<tr class="even">
<td>-1</td>
<td>Error</td>
</tr>
</tbody>
</table>
<h3 id="насоки">Насоки</h3>
<ol type="1">
<li><p>Създайте <strong>нов проект</strong> в съществуващото Visual Studio решение. В Solution Explorer кликнете с десен бутон на мишката върху <strong>Solution</strong> реда и изберете [Add] [New Project…]:</p></li>
</ol>
<p><img src="media/image1.png" style="width:4.55464in;height:3.71984in" /></p>
<ol start="2" type="1">
<li><p>Ще се отвори диалогов прозорец за избор на тип проект за създаване. Изберете <strong>C#</strong> <strong>конзолно приложение</strong> и задайте подходящо име, например "<strong>DayOfWeek</strong>":</p></li>
</ol>
<blockquote>
<p><img src="media/image2.png" style="width:5.65841in;height:3.91615in" /></p>
</blockquote>
<p>Вече имате solution с едно конзолно приложение в него. Остава да напишете кода за решаване на задачата.</p>
<ol type="1">
<li><p>Прочетете едно цяло число от конзолата:</p></li>
</ol>
<blockquote>
<p><img src="media/image3.png" style="width:4.57351in;height:0.29936in" /></p>
</blockquote>
<ol start="2" type="1">
<li><p>Отпечатайте денят от седмицата според въведеното число. Ако то е невалидно, отпечатайте "<strong>Error</strong>".</p></li>
</ol>
<blockquote>
<p><img src="media/image4.png" style="width:3.06213in;height:2.95802in" /></p>
</blockquote>
<h2 id="почивен-или-работен-ден">Почивен или работен ден</h2>
<p>Напишете програма която, чете ден от седмицата (<strong>текст</strong>), на английски език - въведен от потребителя.Ако денят е работен отпечатва на конзолата - "<strong>Working day</strong>", ако е почивен - "<strong>Weekend</strong>". Ако се въведе текст различен от ден от седмицата да се отпечата - "<strong>Error</strong>".</p>
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
<td>Monday</td>
<td>Working day</td>
</tr>
</tbody>
</table>
<table>
<thead>
<tr class="header">
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>Sunday</td>
<td>Weekend</td>
</tr>
</tbody>
</table>
<table>
<thead>
<tr class="header">
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>April</td>
<td>Error</td>
</tr>
</tbody>
</table>
<h3 id="насоки-1">Насоки</h3>
<ol type="1">
<li><p>Прочетете ден от седмицата(<strong>текст</strong>) от конзолата:</p></li>
</ol>
<blockquote>
<p><img src="media/image5.png" style="width:3.72917in;height:0.46875in" /></p>
</blockquote>
<ol start="2" type="1">
<li><p>Отпечатайте работен или почивен ден,според въведения ден, ако денят е невалиден отпечатайте "<strong>Error</strong>":</p></li>
</ol>
<blockquote>
<p><img src="media/image6.png" style="width:4.72917in;height:4.64583in" /></p>
</blockquote>
<h2 id="клас-животно">Клас животно</h2>
<p>Напишете програма, която отпечатва класа на животното според неговото име, въведено от потребителя.</p>
<ol type="1">
<li><p><strong>dog -&gt; mammal</strong></p></li>
<li><p><strong>crocodile, tortoise, snake -&gt; reptile</strong></p></li>
<li><p><strong>others -&gt; unknown</strong></p></li>
</ol>
<h3 id="примерен-вход-и-изход-2">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>dog</td>
<td>mammal</td>
</tr>
<tr class="even">
<td>snake</td>
<td>reptile</td>
</tr>
<tr class="odd">
<td>cat</td>
<td>unknown</td>
</tr>
</tbody>
</table>
<h3 id="насоки-2">Насоки</h3>
<ol type="1">
<li><p>Прочетете входните данни:</p></li>
</ol>
<blockquote>
<p><img src="media/image7.png" style="width:4.33766in;height:0.28726in" /></p>
</blockquote>
<ol start="2" type="1">
<li><p>Проверете от какъв вид е животното. Ако то е невалидно, отпечатайте "<strong>unknown</strong>".</p></li>
</ol>
<blockquote>
<p><img src="media/image8.png" style="width:3.73388in;height:3.32512in" /></p>
</blockquote>
<h2 id="обръщение-според-възраст-и-пол">Обръщение според възраст и пол</h2>
<p>Да се напише <strong>конзолна програма</strong>, която <strong>прочита възраст</strong> (реално число) и <strong>пол</strong> ('<strong>m</strong>' или '<strong>f</strong>'), въведени от потребителя, и отпечатва <strong>обръщение</strong> измежду следните:</p>
<ul>
<li><p>"<strong>Mr.</strong>" – мъж (пол '<strong>m</strong>') на 16 или повече години</p></li>
<li><p>"<strong>Master</strong>" – момче (пол '<strong>m</strong>') под 16 години</p></li>
<li><p>"<strong>Ms.</strong>" – жена (пол '<strong>f</strong>') на 16 или повече години</p></li>
<li><p>"<strong>Miss</strong>" – момиче (пол '<strong>f</strong>') под 16 години</p></li>
</ul>
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
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>12</p>
<p>f</p></td>
<td>Miss</td>
<td></td>
<td><p>17</p>
<p>m</p></td>
<td>Mr.</td>
<td></td>
<td><p>25</p>
<p>f</p></td>
<td>Ms.</td>
<td></td>
<td><p>13.5</p>
<p>m</p></td>
<td>Master</td>
</tr>
</tbody>
</table>
<h3 id="насоки-3">Насоки</h3>
<ol type="1">
<li><p>Отидете в тялото на метода <strong>Main(string[]</strong> <strong>args)</strong> и напишете решението на задачата. Можете да си помогнете с кода от картинките по-долу:</p></li>
</ol>
<blockquote>
<p><img src="media/image9.png" style="width:2.69345in;height:0.80341in" /></p>
</blockquote>
<ol start="2" type="1">
<li><p>Прочетете <strong>реално число</strong> от конзолата "<strong>age</strong>", на следващия ред прочетете <strong>string / текст</strong> за "<strong>gender</strong>".</p></li>
</ol>
<blockquote>
<p><img src="media/image10.png" style="width:3.775in;height:0.39737in" /></p>
</blockquote>
<ol start="3" type="1">
<li><p>Направете проверка за пола, и ако върне резултат <strong>true,</strong> направете проверка за годините. В тялото на проверките за възраст принтирайте желаното обръщение.</p></li>
</ol>
<blockquote>
<p><img src="media/image11.png" style="width:2.83361in;height:2.18867in" /> <img src="media/image12.png" style="width:3.03111in;height:2.17708in" /></p>
</blockquote>
<ol start="4" type="1">
<li><p><strong>Стартирайте</strong> програмата с [Ctrl+F5] и я <strong>тествайте</strong> с различни входни стойности:</p></li>
</ol>
<p><img src="media/image13.png" style="width:2.90625in;height:1.3125in" /> <img src="media/image14.png" style="width:2.86458in;height:1.34375in" /></p>
<p>Трябва да получите <strong>100 точки</strong> (напълно коректно решение):</p>
<p><img src="media/image15.png" style="width:6.63677in;height:4.02976in" /></p>
<p><img src="media/image16.png" style="width:6.10904in;height:1.18375in" /></p>
<h2 id="квартално-магазинче">Квартално магазинче</h2>
<p>Предприемчив българин отваря <strong>квартални магазинчета</strong> в <strong>няколко града</strong> и продава на <strong>различни цени според града</strong>:</p>
<table>
<thead>
<tr class="header">
<th>град / продукт</th>
<th><strong>coffee</strong></th>
<th><strong>water</strong></th>
<th><strong>beer</strong></th>
<th><strong>sweets</strong></th>
<th><strong>peanuts</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Sofia</strong></td>
<td>0.50</td>
<td>0.80</td>
<td>1.20</td>
<td>1.45</td>
<td>1.60</td>
</tr>
<tr class="even">
<td><strong>Plovdiv</strong></td>
<td>0.40</td>
<td>0.70</td>
<td>1.15</td>
<td>1.30</td>
<td>1.50</td>
</tr>
<tr class="odd">
<td><strong>Varna</strong></td>
<td>0.45</td>
<td>0.70</td>
<td>1.10</td>
<td>1.35</td>
<td>1.55</td>
</tr>
</tbody>
</table>
<p>Напишете програма, която чете <strong>продукт</strong> (низ), <strong>град</strong> (низ) и <strong>количество</strong> (десетично число), въведени от потребителя, и пресмята и отпечатва <strong>колко струва</strong> съответното количество от избрания продукт в посочения град.</p>
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
<td><p>coffee</p>
<p>Varna</p>
<p>2</p></td>
<td>0.9</td>
<td></td>
<td><p>peanuts</p>
<p>Plovdiv</p>
<p>1</p></td>
<td>1.5</td>
<td></td>
<td><p>beer</p>
<p>Sofia</p>
<p>6</p></td>
<td>7.2</td>
<td></td>
<td><p>water</p>
<p>Plovdiv</p>
<p>3</p></td>
<td>2.1</td>
<td></td>
<td><p>sweets</p>
<p>Sofia</p>
<p>2.23</p></td>
<td>3.2335</td>
</tr>
</tbody>
</table>
<h2 id="число-в-интервалa">Число в интервалa</h2>
<p>Да се напише програма, която проверява дали въведеното от потребителя число е в интервала [-100, 100] и е различно от 0 и извежда "<strong>Yes</strong>", ако отговаря на условията, или "<strong>No</strong>" ако е извън тях.</p>
<h3 id="примерен-вход-и-изход-5">Примерен вход и изход</h3>
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
<td>-25</td>
<td>Yes</td>
<td></td>
<td>0</td>
<td>No</td>
<td></td>
<td>25</td>
<td>Yes</td>
</tr>
</tbody>
</table>
<h2 id="работно-време">Работно време</h2>
<p>Да се напише програма, която чете час от денонощието(<strong>цяло число</strong>) и ден от седмицата(<strong>текст</strong>) - въведени от потребителя и проверява дали офисът на фирма е отворен, като работното време на офисът е от <strong>10-18</strong> часа, от <strong>понеделник</strong> до <strong>събота</strong> включително</p>
<h3 id="примерен-вход-и-изход-6">Примерен вход и изход</h3>
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
<td><p>11</p>
<p>Monday</p></td>
<td>open</td>
<td></td>
<td><p>19</p>
<p>Friday</p></td>
<td>closed</td>
<td></td>
<td><p>11</p>
<p>Sunday</p></td>
<td>closed</td>
</tr>
</tbody>
</table>
<h2 id="билет-за-кино">Билет за кино</h2>
<p>Да се напише програма която чете ден от седмицата (текст) – въведен от потребителя и принтира на конзолата цената на билет за кино според деня от седмицата:</p>
<table>
<thead>
<tr class="header">
<th><strong>Monday</strong></th>
<th><strong>Tuesday</strong></th>
<th><strong>Wednesday</strong></th>
<th><strong>Thursday</strong></th>
<th><strong>Friday</strong></th>
<th><strong>Saturday</strong></th>
<th><strong>Sunday</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>12</td>
<td>12</td>
<td>14</td>
<td>14</td>
<td>12</td>
<td>16</td>
<td>16</td>
</tr>
</tbody>
</table>
<h3 id="примерен-вход-и-изход-7">Примерен вход и изход</h3>
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
<td>Monday</td>
<td>12</td>
<td></td>
<td>Friday</td>
<td>12</td>
<td></td>
<td>Sunday</td>
<td>16</td>
</tr>
</tbody>
</table>
<h2 id="плод-или-зеленчук">Плод или зеленчук</h2>
<p>Да се напише програма, която <strong>чете име на продукт</strong>, въведено от потребителя, и проверява дали е <strong>плод</strong> или <strong>зеленчук</strong>.</p>
<ul>
<li><p>Плодовете "<strong>fruit</strong>" имат следните възможни стойности: <strong>banana</strong>, <strong>apple</strong>, <strong>kiwi</strong>, <strong>cherry</strong>, <strong>lemon</strong> и <strong>grapes</strong></p></li>
<li><p>Зеленчуците "<strong>vegetable</strong>" имат следните възможни стойности: <strong>tomato</strong>, <strong>cucumber</strong>, <strong>pepper</strong> и <strong>carrot</strong></p></li>
<li><p>Всички останали са "<strong>unknown</strong>"</p></li>
</ul>
<p>Да се изведе "<strong>fruit</strong>”, "<strong>vegetable</strong>" или "<strong>unknown</strong>" според въведения продукт.</p>
<h3 id="примерен-вход-и-изход-8">Примерен вход и изход</h3>
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
<td>banana</td>
<td>fruit</td>
<td></td>
<td>apple</td>
<td>fruit</td>
<td></td>
<td>tomato</td>
<td>vegetable</td>
<td></td>
<td>water</td>
<td>unknown</td>
</tr>
</tbody>
</table>
<h2 id="невалидно-число">Невалидно число</h2>
<p>Дадено <strong>число е валидно</strong>, ако е в диапазона [<strong>100</strong>…<strong>200</strong>] или е <strong>0</strong>. Да се напише програма, която <strong>чете цяло число</strong>, въведено от потребителя, и печата "<strong>invalid</strong>" ако въведеното число <strong>не е валидно</strong>.</p>
<h3 id="примерен-вход-и-изход-9">Примерен вход и изход</h3>
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
<td>75</td>
<td>invalid</td>
<td></td>
<td>150</td>
<td><em>(няма изход)</em></td>
<td></td>
<td>220</td>
<td>invalid</td>
<td></td>
<td>199</td>
<td><em>(няма изход)</em></td>
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
</tr>
</thead>
<tbody>
<tr class="odd">
<td>-1</td>
<td>invalid</td>
<td></td>
<td>100</td>
<td><em>(няма изход)</em></td>
<td></td>
<td>200</td>
<td><em>(няма изход)</em></td>
<td></td>
<td>0</td>
<td><em>(няма изход)</em></td>
</tr>
</tbody>
</table>
<h2 id="магазин-за-плодове">Магазин за плодове</h2>
<p>Магазин за плодове през <strong>работните дни</strong> работи на следните <strong>цени</strong>:</p>
<table>
<thead>
<tr class="header">
<th><strong>плод</strong></th>
<th><strong>banana</strong></th>
<th><strong>apple</strong></th>
<th><strong>orange</strong></th>
<th><strong>grapefruit</strong></th>
<th><strong>kiwi</strong></th>
<th><strong>pineapple</strong></th>
<th><strong>grapes</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>цена</strong></td>
<td>2.50</td>
<td>1.20</td>
<td>0.85</td>
<td>1.45</td>
<td>2.70</td>
<td>5.50</td>
<td>3.85</td>
</tr>
</tbody>
</table>
<p><strong>Събота</strong> и <strong>неделя</strong> магазинът работи на <strong>по-високи</strong> <strong>цени</strong>:</p>
<table>
<thead>
<tr class="header">
<th><strong>плод</strong></th>
<th><strong>banana</strong></th>
<th><strong>apple</strong></th>
<th><strong>orange</strong></th>
<th><strong>grapefruit</strong></th>
<th><strong>kiwi</strong></th>
<th><strong>pineapple</strong></th>
<th><strong>grapes</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>цена</strong></td>
<td>2.70</td>
<td>1.25</td>
<td>0.90</td>
<td>1.60</td>
<td>3.00</td>
<td>5.60</td>
<td>4.20</td>
</tr>
</tbody>
</table>
<p>Напишете програма, която чете от конзолата <strong>плод</strong> (banana / apple / orange / grapefruit / kiwi / pineapple / grapes), <strong>ден от седмицата</strong> (Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday) и <strong>количество</strong> (реално число) , въведени от потребителя, и пресмята <strong>цената</strong> според цените от таблиците по-горе. Резултатът да се отпечата <strong>закръглен с 2 цифри</strong> след десетичната точка. При невалиден ден от седмицата или невалидно име на плод да се отпечата "<strong>error</strong>".</p>
<h3 id="примерен-вход-и-изход-10">Примерен вход и изход</h3>
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
<td><p>apple</p>
<p>Tuesday</p>
<p>2</p></td>
<td>2.40</td>
<td></td>
<td><p>orange</p>
<p>Sunday</p>
<p>3</p></td>
<td>2.70</td>
<td></td>
<td><p>kiwi</p>
<p>Monday</p>
<p>2.5</p></td>
<td>6.75</td>
<td></td>
<td><p>grapes</p>
<p>Saturday</p>
<p>0.5</p></td>
<td>2.10</td>
<td></td>
<td><p>tomato</p>
<p>Monday</p>
<p>0.5</p></td>
<td>error</td>
</tr>
</tbody>
</table>
<h2 id="търговски-комисионни">Търговски комисионни</h2>
<p>Фирма дава следните <strong>комисионни</strong> на търговците си според <strong>града</strong>, в който работят и обема на <strong>продажбите</strong>:</p>
<table>
<thead>
<tr class="header">
<th><strong>Град</strong></th>
<th><strong>0 ≤ s ≤ 500</strong></th>
<th><strong>500 &lt; s ≤ 1 000</strong></th>
<th><strong>1 000 &lt; s ≤ 10 000</strong></th>
<th><strong>s &gt; 10 000</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>Sofia</td>
<td>5%</td>
<td>7%</td>
<td>8%</td>
<td>12%</td>
</tr>
<tr class="even">
<td>Varna</td>
<td>4.5%</td>
<td>7.5%</td>
<td>10%</td>
<td>13%</td>
</tr>
<tr class="odd">
<td>Plovdiv</td>
<td>5.5%</td>
<td>8%</td>
<td>12%</td>
<td>14.5%</td>
</tr>
</tbody>
</table>
<p>Напишете <strong>конзолна програма</strong>, която чете име на <strong>град</strong> (стринг) и обем на <strong>продажби</strong> (реално число) , въведени от потребителя, и изчислява и извежда размера на търговската <strong>комисионна</strong> според горната таблица. Резултатът да се изведе форматиран до <strong>2 цифри след десетичната точка</strong>. При <strong>невалиден</strong> град или обем на продажбите (отрицателно число) да се отпечата "<strong>error</strong>".</p>
<h3 id="примерен-вход-и-изход-11">Примерен вход и изход</h3>
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
<td><p>Sofia</p>
<p>1500</p></td>
<td>120.00</td>
<td></td>
<td><p>Plovdiv</p>
<p>499.99</p></td>
<td>27.50</td>
<td></td>
<td><p>Varna</p>
<p>3874.50</p></td>
<td>387.45</td>
<td></td>
<td><p>Kaspichan</p>
<p>-50</p></td>
<td>error</td>
</tr>
</tbody>
</table>
<h1 id="примерна-изпитна-задача">Примерна изпитна задача</h1>
<h2 id="ски-почивка">*Ски почивка</h2>
<p>Атанас решава да прекара отпуската си в Банско и да кара ски. Преди да отиде обаче, трябва да резервира хотел и да изчисли <strong>колко ще му струва престоя</strong>. Съществуват следните видове помещения, със следните цени за престой:</p>
<ul>
<li><blockquote>
<p><strong>"room for one person" – 18.00 лв за нощувка</strong></p>
</blockquote></li>
<li><blockquote>
<p>"<strong>apartment</strong>" – <strong>25.00 лв за нощувка</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>"president</strong> <strong>apartment</strong>" – <strong>35.00 лв за нощувка</strong></p>
</blockquote></li>
</ul>
<p>Според <strong>броят на дните</strong>, в които ще остане в хотела (<strong>пример: 11 дни = 10 нощувки</strong>) и <strong>видът на помещението</strong>, което ще избере, той може да ползва различно <strong>намаление</strong>. Намаленията са както следва:</p>
<table>
<thead>
<tr class="header">
<th><strong>вид помещение</strong></th>
<th><strong>по-малко от 10 дни</strong></th>
<th><strong>между 10 и 15 дни</strong></th>
<th><strong>повече от 15 дни</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>room for one person</strong></td>
<td>не ползва намаление</td>
<td>не ползва намаление</td>
<td>не ползва намаление</td>
</tr>
<tr class="even">
<td><strong>apartment</strong></td>
<td><strong>30%</strong> от крайната цена</td>
<td><strong>35%</strong> от крайната цена</td>
<td><strong>50%</strong> от крайната цена</td>
</tr>
<tr class="odd">
<td><strong>president apartment</strong></td>
<td><strong>10%</strong> от крайната цена</td>
<td><strong>15%</strong> от крайната цена</td>
<td><strong>20%</strong> от крайната цена</td>
</tr>
</tbody>
</table>
<p>След престоя, оценката на Атанас за услугите на хотела може да е <strong>позитивна (positive)</strong> или <strong>негативна (negative)</strong> . Ако оценката му е <strong>позитивна</strong>, към цената <strong>с вече приспаднатото намаление</strong> Атанас добавя <strong>25%</strong> от нея. Ако оценката му е <strong>негативна</strong> приспада от цената <strong>10%</strong>.</p>
<h3 id="вход">Вход</h3>
<p>Входът се чете от конзолата и се състои от <strong>три реда</strong>:</p>
<ul>
<li><p><strong>Първи ред</strong> - <strong>дни за престой</strong> - <strong>цяло число</strong> в интервала <strong>[0...365]</strong></p></li>
<li><p><strong>Втори ред</strong> - <strong>вид помещение -</strong> "<strong>room for one person</strong>", "<strong>apartment</strong>" или "<strong>president</strong> <strong>apartment</strong>"</p></li>
<li><p><strong>Трети ред</strong> - <strong>оценка</strong> - "<strong>positive</strong>" или "<strong>negative</strong>"</p></li>
</ul>
<h3 id="изход">Изход</h3>
<p>На конзолата трябва да се отпечата <strong>един ред</strong>:</p>
<ul>
<li><p><strong>Цената за престоят му в хотела, форматирана до втория знак след десетичната запетая.</strong></p></li>
</ul>
<h3 id="примерен-вход-и-изход-12">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
<th><strong>Обяснения</strong></th>
<th></th>
<th></th>
<th></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>14</p>
<p>apartment</p>
<p>positive</p></td>
<td>264.06</td>
<td><p><strong>14 дни =&gt; 13 нощувки</strong> =&gt; 13 * 25.00 = 325 лв.</p>
<p><strong>10 &lt; 13 дни &lt; 15</strong> =&gt; 325 – 35%= 211.25 лв.</p>
<p><strong>Оценката е positive</strong> =&gt; 211.25 + 25% = 264.0625 -&gt; 264.06 лв.</p></td>
<td></td>
<td></td>
<td></td>
</tr>
<tr class="even">
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
</tr>
<tr class="odd">
<td><p>30</p>
<p>president apartment</p>
<p>negative</p></td>
<td>730.80</td>
<td><p>12</p>
<p>room for one person</p>
<p>positive</p></td>
<td>247.50</td>
<td><p>2</p>
<p>apartment</p>
<p>positive</p></td>
<td>21.88</td>
</tr>
</tbody>
</table>
<h2 class="list-paragraph" id="section"></h2>
