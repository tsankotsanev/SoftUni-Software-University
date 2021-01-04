<p><strong>Упражнениe: Повторения с цикли – For-цикъл</strong></p>
<p>Задачи за упражнение в клас и за домашно към курса <a href="https://softuni.bg/trainings/3038/programming-basics-with-c-sharp-july-2020">"Основи на програмирането" @ СофтУни</a>.</p>
<p>Тествайте решенията си в Judge системата: <a href="https://judge.softuni.bg/Contests/2382">https://judge.softuni.bg/Contests/2382</a></p>
<h2 id="числа-до-1000-завършващи-на-7">Числа до 1000, завършващи на 7</h2>
<p>Напишете програма, която отпечатва числата в диапазона <strong>[1…1000]</strong>, които <strong>завършват на 7</strong>.</p>
<table>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>(няма)</td>
<td><p>7</p>
<p>17</p>
<p>27</p>
<p>…</p>
<p>997</p></td>
</tr>
</tbody>
</table>
<h3 id="насоки">Насоки</h3>
<ol type="1">
<li><p>Направете <strong>for цикъл</strong> от 7 до 997 и проверете всяко число дали завършва на 7. Едно число завършва на 7, когато резултатът от <strong>модулното деление на числото и 10 е равен на 7</strong>.</p></li>
</ol>
<blockquote>
<p><img src="media/image1.png" style="width:2.95833in;height:1.59041in" /></p>
</blockquote>
<h2 id="елемент-равен-на-сумата-на-останалите"> Елемент, равен на сумата на останалите</h2>
<p>Да се напише програма, която чете <strong>n-на брой</strong> цели числа, въведени от потребителя, и проверява дали сред тях съществува число, което е равно на сумата на всички останали. Ако има такъв елемент, печата "<strong>Yes</strong>", "<strong>Sum =</strong> " + <strong>неговата стойност</strong>; иначе печата "<strong>No</strong>", "<strong>Diff =</strong> " + <strong>разликата между най-големия елемент и сумата на останалите</strong> (по абсолютна стойност).</p>
<h3 id="примерен-вход-и-изход">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
<th><strong>коментари</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>7</p>
<p>3</p>
<p>4</p>
<p>1</p>
<p>1</p>
<p>2</p>
<p><strong>12</strong></p>
<p>1</p></td>
<td><p>Yes</p>
<p>Sum = 12</p></td>
<td>3 + 4 + 1 + 2 + 1 + 1 = 12</td>
</tr>
<tr class="even">
<td><p>4</p>
<p><strong>6</strong></p>
<p>1</p>
<p>2</p>
<p>3</p></td>
<td><p>Yes</p>
<p>Sum = 6</p></td>
<td>1 + 2 + 3 = 12</td>
</tr>
<tr class="odd">
<td><p>3</p>
<p>1</p>
<p>1</p>
<p>10</p></td>
<td><p>No</p>
<p>Diff = 8</p></td>
<td>|10 - (1 + 1)| = 8</td>
</tr>
<tr class="even">
<td><p>3</p>
<p>5</p>
<p>5</p>
<p>1</p></td>
<td><p>No</p>
<p>Diff = 1</p></td>
<td>|5 - (5 + 1)| = 1</td>
</tr>
<tr class="odd">
<td><p>3</p>
<p>1</p>
<p>1</p>
<p>1</p></td>
<td><p>No</p>
<p>Diff = 1</p></td>
<td></td>
</tr>
</tbody>
</table>
<h3 id="насоки-1">Насоки</h3>
<ol type="1">
<li><p>Прочетете число <strong>n</strong> и завъртете цикъл до него, като на всеки нов ред четете число <strong>num</strong>.</p></li>
</ol>
<p><img src="media/image2.png" style="width:4.10417in;height:1.11353in" /></p>
<ol start="2" type="1">
<li><p>Създайте променливи <strong>sum</strong>, която ще държи сумата на <strong>num</strong> и <strong>max</strong>, която ще пази най-голямото число.</p></li>
</ol>
<p><img src="media/image3.png" style="width:3.8125in;height:2.44088in" /></p>
<ol start="3" type="1">
<li><p>Проверете дали сумата е равна на <strong>max</strong> и принтирайте съответният изход.</p></li>
</ol>
<p><img src="media/image4.png" style="width:3.91667in;height:2.17375in" /></p>
<h2 id="четни-нечетни-позиции">Четни / нечетни позиции</h2>
<p>Напишете програма, която чете <strong>n-на брой</strong> <strong>числа</strong>, въведени от потребителя, и пресмята <strong>сумата</strong>, <strong>минимума</strong> и <strong>максимума</strong> на числата на <strong>четни</strong> и <strong>нечетни</strong> позиции (броим от 1). Когато няма минимален / максимален елемент, отпечатайте "<strong>No</strong>".</p>
<p>Изходът да се форматира в следния вид:</p>
<p>"<strong>OddSum=</strong>" + {<strong>сума</strong> на числата на <strong>нечетни</strong> позиции},</p>
<p>"<strong>OddMin=</strong>" + { <strong>минимална</strong> стойност на числата на <strong>нечетни</strong> позиции } / {“<strong>No</strong>”},</p>
<p>"<strong>OddMax=</strong>" + { <strong>максимална</strong> стойност на числата на <strong>нечетни</strong> позиции } / {“<strong>No</strong>”},</p>
<p>"<strong>EvenSum=</strong>" + { <strong>сума</strong> на числата на <strong>четни</strong> позиции },</p>
<p>"<strong>EvenMin=</strong>" + { <strong>минимална</strong> стойност на числата на <strong>четни</strong> позиции } / {“<strong>No</strong>”},</p>
<p>"<strong>EvenMax=</strong>" + { <strong>максимална</strong> стойност на числата на <strong>четни</strong> позиции } / {“<strong>No</strong>”}</p>
<p><strong>Всяко число трябва да е форматирано до втория знак след десетичната запетая.</strong></p>
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
<td><p>6</p>
<p><strong>2</strong></p>
<p>3</p>
<p><strong>5</strong></p>
<p>4</p>
<p><strong>2</strong></p>
<p>1</p></td>
<td>OddSum=9.00, OddMin=2.00, OddMax=5.00, EvenSum=8.00, EvenMin=1.00, EvenMax=4.00</td>
<td></td>
<td><p>2</p>
<p><strong>1.5</strong></p>
<p>-2.5</p></td>
<td>OddSum=1.50, OddMin=1.50, OddMax=1.50, EvenSum=-2.50, EvenMin=-2.50, EvenMax=-2.50</td>
<td></td>
<td><p>1</p>
<p><strong>1</strong></p></td>
<td>OddSum=1.00, OddMin=1.00, OddMax=1.00, EvenSum=0.00, EvenMin=No, EvenMax=No</td>
<td></td>
<td>0</td>
<td>OddSum=0.00, OddMin=No, OddMax=No, EvenSum=0.00, EvenMin=No, EvenMax=No</td>
</tr>
</tbody>
</table>
<table>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>Изход</strong></th>
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
<p><strong>3</strong></p>
<p>-2</p>
<p><strong>8</strong></p>
<p>11</p>
<p><strong>-3</strong></p></td>
<td>OddSum=8.00, OddMin=-3.00, OddMax=8.00, EvenSum=9.00, EvenMin=-2.00, EvenMax=11.00</td>
<td></td>
<td><p>4</p>
<p>1.5</p>
<p><strong>1.75</strong></p>
<p>1.5</p>
<p><strong>1.75</strong></p></td>
<td>OddSum=3.00, OddMin=1.50, OddMax=1.50, EvenSum=3.50, EvenMin=1.75, EvenMax=1.75</td>
<td></td>
<td><p>1</p>
<p><strong>-5</strong></p></td>
<td>OddSum=-5.00, OddMin=-5.00, OddMax=-5.00, EvenSum=0.00, EvenMin=No, EvenMax=No</td>
<td></td>
<td><p>3</p>
<p><strong>-1</strong></p>
<p>-2</p>
<p><strong>-3</strong></p></td>
<td>OddSum=-4.00, OddMin=-3.00, OddMax=-1.00, EvenSum=-2.00, EvenMin=-2.00, EvenMax=-2.00</td>
</tr>
</tbody>
</table>
<p>Задача обединява няколко предходни задачи: намиране на <strong>минимум</strong>, намиране на <strong>максимум</strong>, намиране на <strong>сума</strong> и обработка на елементите от <strong>четни и нечетни позиции</strong>. Припомнете си ги.</p>
<h3 id="насоки-2">Насоки</h3>
<ol type="1">
<li><p>Работете с <strong>реални числа</strong> (не цели). Сумата, минимумът и максимумът също са реални числа.</p></li>
<li><p>Използвайте <strong>неутрална начална стойност</strong> при намиране на минимум / максимум, например <strong>1000000000.0</strong> и <strong>-1000000000.0</strong>. Ако получите накрая неутралната стойност, печатайте “<strong>No</strong>”.</p></li>
<li><p>Завъртете <strong>for</strong> цикъл до числото, което ви се въвежда като на всеки нов ред прочитате ново число <strong>num</strong>.</p></li>
<li><p>Проверете дали <strong>позицията на числото</strong> е <strong>четна</strong> или <strong>нечетна</strong>, като променливата инициализирана в цикъла <strong>i</strong> отговаря на <strong>позицията на числото</strong>.</p></li>
<li><p>Ако позицията на числото е <strong>четно</strong>, увеличете <strong>сумата на четните числа</strong> и проверете дали числото е<br />
<strong>по-голямо</strong> от <strong>най-голямото четно</strong>, и му презапишете стойността. Също така проверете дали числото е <strong>по-малко</strong> от <strong>най-малкото четно число</strong> и му презапишете стойността.</p></li>
<li><p>Аналогично направете същото и за <strong>нечетните числа</strong>.</p></li>
</ol>
<h1 id="примерни-изпитни-задачи">Примерни изпитни задачи</h1>
<h2 id="хистограма">Хистограма</h2>
<p>Дадени са <strong>n</strong> <strong>цели числа</strong> в интервала [<strong>1</strong>…<strong>1000</strong>]. От тях някакъв процент <strong>p1</strong> са под 200, друг процент <strong>p2</strong> са от 200 до 399, друг процент <strong>p3</strong> са от 400 до 599, друг процент <strong>p4</strong> са от 600 до 799 и останалите <strong>p5</strong> процента са от 800 нагоре. Да се напише програма, която изчислява и отпечатва процентите <strong>p1</strong>, <strong>p2</strong>, <strong>p3</strong>, <strong>p4</strong> и <strong>p5</strong>.</p>
<p><strong>Пример</strong>: имаме n = <strong>20</strong> числа: 53, 7, 56, 180, 450, 920, 12, 7, 150, 250, 680, 2, 600, 200, 800, 799, 199, 46, 128, 65. Получаваме следното разпределение и визуализация:</p>
<table>
<thead>
<tr class="header">
<th><strong>Диапазон</strong></th>
<th><strong>Числа в диапазона</strong></th>
<th><strong>Брой числа</strong></th>
<th><strong>Процент</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>&lt; 200</td>
<td>53, 7, 56, 180, 12, 7, 150, 2, 199, 46, 128, 65</td>
<td>12</td>
<td>p1 = 12 / 20 * 100 = <strong>60.00</strong>%</td>
</tr>
<tr class="even">
<td>200 … 399</td>
<td>250, 200</td>
<td>2</td>
<td>p2 = 2 / 20 * 100 = <strong>10.00</strong>%</td>
</tr>
<tr class="odd">
<td>400 … 599</td>
<td>450</td>
<td>1</td>
<td>p3 = 1 / 20 * 100 = <strong>5.00</strong>%</td>
</tr>
<tr class="even">
<td>600 … 799</td>
<td>680, 600, 799</td>
<td>3</td>
<td>p4 = 3 / 20 * 100 = <strong>15.00</strong>%</td>
</tr>
<tr class="odd">
<td>≥ 800</td>
<td>920, 800</td>
<td>2</td>
<td>p5 = 2 / 20 * 100 = <strong>10.00</strong>%</td>
</tr>
</tbody>
</table>
<h3 id="вход">Вход</h3>
<p>На първия ред от входа стои цялото число <strong>n</strong> (1 ≤ <strong>n</strong> ≤ 1000) – брой числа. На следващите <strong>n</strong> <strong>реда</strong> стои <strong>по едно</strong> <strong>цяло число</strong> в интервала [<strong>1</strong>…<strong>1000</strong>] – числата върху които да бъде изчислена хистограмата.</p>
<h3 id="изход">Изход</h3>
<p>Да се отпечата на конзолата <strong>хистограмата</strong> – <strong>5 реда</strong>, всеки от които съдържа число между 0% и 100%, с точност две цифри след десетичната точка, например 25.00%, 66.67%, 57.14%.</p>
<h3 id="примерен-вход-и-изход-2">Примерен вход и изход</h3>
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
<td><p><strong>3</strong></p>
<p>1</p>
<p>2</p>
<p>999</p></td>
<td><p>66.67%</p>
<p>0.00%</p>
<p>0.00%</p>
<p>0.00%</p>
<p>33.33%</p></td>
<td></td>
<td><p><strong>4</strong></p>
<p>53</p>
<p>7</p>
<p>56</p>
<p>999</p></td>
<td><p>75.00%</p>
<p>0.00%</p>
<p>0.00%</p>
<p>0.00%</p>
<p>25.00%</p></td>
<td></td>
<td><p><strong>7</strong></p>
<p>800</p>
<p>801</p>
<p>250</p>
<p>199</p>
<p>399</p>
<p>599</p>
<p>799</p></td>
<td><p>14.29%</p>
<p>28.57%</p>
<p>14.29%</p>
<p>14.29%</p>
<p>28.57%</p></td>
<td></td>
<td><p><strong>9</strong></p>
<p>367</p>
<p>99</p>
<p>200</p>
<p>799</p>
<p>999</p>
<p>333</p>
<p>555</p>
<p>111</p>
<p>9</p></td>
<td><p>33.33%</p>
<p>33.33%</p>
<p>11.11%</p>
<p>11.11%</p>
<p>11.11%</p></td>
<td></td>
<td><p><strong>14</strong></p>
<p>53</p>
<p>7</p>
<p>56</p>
<p>180</p>
<p>450</p>
<p>920</p>
<p>12</p>
<p>7</p>
<p>150</p>
<p>250</p>
<p>680</p>
<p>2</p>
<p>600</p>
<p>200</p></td>
<td><p>57.14%</p>
<p>14.29%</p>
<p>7.14%</p>
<p>14.29%</p>
<p>7.14%</p></td>
</tr>
</tbody>
</table>
<h2 id="деление-без-остатък">Деление без остатък</h2>
<p>Дадени са <strong>n-на брой</strong> <strong>цели числа</strong> в интервала [<strong>1</strong>…<strong>1000</strong>]. От тях някакъв <strong>процент p1 се делят без остатък на 2</strong>, друг <strong>процент</strong> <strong>p2</strong> се <strong>делят без остатък на 3</strong>, друг <strong>процент</strong> <strong>p3</strong> се <strong>делят без остатък на 4</strong>. Да се напише програма, която изчислява и отпечатва процентите <strong>p1</strong>, <strong>p2</strong> и <strong>p3</strong>.</p>
<p><strong>Пример</strong>: имаме n = <strong>10</strong> числа: 680, 2, 600, 200, 800, 799, 199, 46, 128, 65. Получаваме следното разпределение и визуализация:</p>
<table>
<thead>
<tr class="header">
<th><strong>Деление без остатък на:</strong></th>
<th><strong>Числа в диапазона</strong></th>
<th><strong>Брой числа</strong></th>
<th><strong>Процент</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>2</td>
<td>680, 2, 600, 200, 800, 46, 128</td>
<td>7</td>
<td>p1 = 7.0 / 10 * 100 = <strong>70.00</strong>%</td>
</tr>
<tr class="even">
<td>3</td>
<td>600</td>
<td>1</td>
<td>p2 = 1 / 10 * 100 = <strong>10.00</strong>%</td>
</tr>
<tr class="odd">
<td>4</td>
<td>680, 600, 200, 800, 128</td>
<td>5</td>
<td>p3 = 5 / 10 * 100 = <strong>50.00</strong>%</td>
</tr>
</tbody>
</table>
<h3 id="вход-1">Вход</h3>
<p>На първия ред от входа стои цялото число <strong>n</strong> (1 ≤ <strong>n</strong> ≤ 1000) - брой числа. На следващите <strong>n</strong> <strong>реда</strong> стои <strong>по едно</strong> <strong>цяло число</strong> в интервала [<strong>1</strong>…<strong>1000</strong>] - числата които да бъдат проверени на колко се делят.</p>
<h3 id="изход-1">Изход</h3>
<p>Да се отпечатат на конзолата <strong>3 реда</strong>, всеки от които съдържа процент между 0% и 100%, с точност две цифри след десетичната точка, например 25.00%, 66.67%, 57.14%.</p>
<ul>
<li><p>На <strong>първият ред</strong> - процентът на числата които <strong>се делят на 2</strong></p></li>
<li><p>На <strong>вторият ред</strong> - процентът на числата които <strong>се делят на</strong> <strong>3</strong></p></li>
<li><p>На <strong>третият ред</strong> - процентът на числата които <strong>се делят на 4</strong></p></li>
</ul>
<h3 id="примерен-вход-и-изход-3">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
<th></th>
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><strong>10</strong></p>
<p>680</p>
<p>2</p>
<p>600</p>
<p>200</p>
<p>800</p>
<p>799</p>
<p>199</p>
<p>46</p>
<p>128</p>
<p>65</p></td>
<td><p>70.00%</p>
<p>10.00%</p>
<p>50.00%</p></td>
<td></td>
<td><p><strong>3</strong></p>
<p>3</p>
<p>6</p>
<p>9</p></td>
<td><p>33.33%</p>
<p>100.00%</p>
<p>0.00%</p></td>
</tr>
</tbody>
</table>
<h2 id="заплата">Заплата</h2>
<p>Шеф на компания забелязва че все повече служители прекарват време в сайтове, които ги разсейват.</p>
<p>За да предотврати това, той въвежда изненадващи проверки на отворените табове на браузъра на служителите си. <strong>Според сайта се налагат различни глоби:</strong></p>
<ul>
<li><blockquote>
<p>"<strong>Facebook</strong>" <strong>-&gt; 150 лв.</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>"Instagram" -&gt; 100 лв.</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>"Reddit" -&gt; 50 лв.</strong></p>
</blockquote></li>
</ul>
<p><strong>От конзолата се четат два реда:</strong></p>
<ul>
<li><blockquote>
<p><strong>Брой отворени табове в браузъра</strong> <strong>n -</strong> <strong>цяло число в интервала [1...10]</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>Заплата - число в интервала [700...1500]</strong></p>
</blockquote></li>
</ul>
<p><strong>След това n – на брой пъти се чете име на уебсайт – текст</strong></p>
<p>Ако по време на проверката заплатата стане <strong>по-малка или равна на 0 лева</strong>, на конзолата се изписва<br />
<strong>"You have lost your salary." и програмата приключва.</strong> В противен случай след проверката <strong>на конзолата се изписва остатъкът</strong> от заплатата (да се изпише <strong>като цяло число</strong>).</p>
<h3 id="примерен-вход-и-изход-4">Примерен вход и изход</h3>
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
<td><p>10</p>
<p>750</p>
<p>Facebook</p>
<p>Dev.bg</p>
<p>Instagram</p>
<p>Facebook</p>
<p>Reddit</p>
<p>Facebook</p>
<p>Facebook</p></td>
<td>You have lost your salary.</td>
<td><p>Има 10 отворени таба в браузъра.</p>
<p>Заплатата е 750</p>
<p>За първия таб -&gt; Facebook глоба 150 лв.(750 – 150 = 600)</p>
<p>За втория таб -&gt; Dev.bg не глобяват</p>
<p>За третия таб -&gt; Instagram глоба 100 лв.(600 – 100 = 500)</p>
<p>За четвъртия таб -&gt; Facebook глоба 150 лв.(500 – 150 = 350)</p>
<p>За петия таб -&gt; Reddit глоба 50 лв. (350 – 50 = 300)</p>
<p>За шестия таб -&gt; Facebook глоба 150 лв.(300 – 150 = 150)</p>
<p>За седмия таб -&gt; Facebook глоба 150 лв.(150 – 150 = 0)</p>
<p>Заплатата е равна на 0, следователно се изписва съответният изход и програмата приключва.</p></td>
<td></td>
</tr>
<tr class="even">
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
</tr>
<tr class="odd">
<td><p>3</p>
<p>500</p>
<p>Github.com</p>
<p>Stackoverflow.com</p>
<p>softuni.bg</p></td>
<td>500</td>
<td><p>3</p>
<p>500</p>
<p>Facebook</p>
<p>Stackoverflow.com</p>
<p>softuni.bg</p></td>
<td>350</td>
</tr>
</tbody>
</table>
