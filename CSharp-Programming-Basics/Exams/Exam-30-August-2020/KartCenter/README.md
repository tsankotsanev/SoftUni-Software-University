<h1 id="изпит-по-основи-на-програмирането">Изпит по "Основи на програмирането"</h1>
<h2 id="задача-3.-картинг-център">Задача 3. Картинг център</h2>
<p>Картинг център искат да въведат безкасово обслужване на клиентите си посредством автомат за купуване на билети. Вашата задача е да напишете програма/функция, която според <strong>въведената сума,</strong> проверява <strong>дали е възможно да се закупи билет за картинг,</strong> имайки предвид следната информация:</p>
<table>
<thead>
<tr class="header">
<th><strong>Обиколки/Вид Карт</strong></th>
<th><strong>Child</strong></th>
<th><strong>Junior</strong></th>
<th><strong>Adult</strong></th>
<th><strong>Profi</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>5 обиколки (five)</strong></td>
<td>7</td>
<td>9</td>
<td>12</td>
<td>18</td>
</tr>
<tr class="even">
<td><strong>10 обиколки (ten)</strong></td>
<td>11</td>
<td>16</td>
<td>21</td>
<td>32</td>
</tr>
</tbody>
</table>
<p><strong>При наличието на фен карта</strong> цената на билета е с <strong>20% намаление</strong>.</p>
<p><strong>Вход</strong></p>
<p>От конзолата се прочитат <strong>4 реда</strong>:</p>
<ul>
<li><blockquote>
<p><strong>Въведената в автомата сума</strong> - <strong>реално число</strong> в интервала <strong>[0.00…1000.00]</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>Обиколки - текст</strong> (<strong>"five",</strong> за пет обиколи и <strong>"ten",</strong> за десет обиколки)</p>
</blockquote></li>
<li><blockquote>
<p><strong>Фен карта</strong> - <strong>текст</strong> (<strong>"yes"</strong> или <strong>"no"</strong>)</p>
</blockquote></li>
<li><blockquote>
<p><strong>Вид Карт - текст</strong> (една от възможностите в таблицата)</p>
</blockquote></li>
</ul>
<p><strong>Изход</strong></p>
<p>На конзолата се отпечатва <strong>1 ред</strong>:</p>
<ul>
<li><blockquote>
<p>Ако сумата <strong>е достатъчна</strong>:</p>
</blockquote></li>
</ul>
<blockquote>
<p><strong>"You bought {Вид Карт} ticket for {Обиколки(five/ten)} laps. Your change is {money}lv."</strong>,</p>
<p>където <strong>{money}</strong> e останалата сума след плащането (рестото), форматирана <strong>до втория знак след десетичната запетая.</strong></p>
</blockquote>
<ul>
<li><blockquote>
<p>Ако сумата <strong>не е достатъчна,</strong> трябва да се пресметне <strong>колко още пари</strong> са необходими, за да се закупи билет:</p>
</blockquote></li>
</ul>
<blockquote>
<p><strong>"You don't have enough money! You need {money}lv more."</strong>,</p>
<p>където <strong>{money}</strong> e оставащата сума нужна, за да се закупи билет, форматирана до <strong>втория знак след десетичната запетая</strong>.</p>
</blockquote>
<p><strong>Примерен вход и изход</strong></p>
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
<td><p>10</p>
<p>ten</p>
<p>yes</p>
<p>Child</p></td>
<td>You bought Child ticket for ten laps. Your change is 1.20lv.</td>
<td><p><strong>Въведената сума е 10лв</strong>, избран е билет с <strong>десет обиколки</strong> за <strong>Child</strong> - 11лв. Има фен карта (<strong>yes</strong>)</p>
<p><strong>Цената на билета е</strong>: 11 - 20% = 8.80лв.</p>
<p><strong>10</strong> &gt; 8.80 - следователно сумата <strong>е достатъчна</strong></p>
<p><strong>Рестото е</strong>: <strong>10</strong> - 8.80 = 1.20лв.</p></td>
</tr>
<tr class="even">
<td><p>18</p>
<p>ten</p>
<p>yes</p>
<p>Profi</p></td>
<td>You don't have enough money! You need 7.60lv more.</td>
<td></td>
</tr>
<tr class="odd">
<td><p>16</p>
<p>five</p>
<p>no</p>
<p>Adult</p></td>
<td>You bought Adult ticket for five laps. Your change is 4.00lv.</td>
<td></td>
</tr>
</tbody>
</table>
