<h1 id="изпит-по-основи-на-програмирането">Изпит по "Основи на програмирането"</h1>
<h1 id="задача-2.-туристическа-агенция">Задача 2. Туристическа агенция</h1>
<p>Стамат има туристическа агенция и последните месеци има много запитвания за едни и същи самолетни билети. На Стамат му е необходима помощ, за да може бързо да отговаря на запитванията от клиенти. Той има нужда от калкулатор, който получава 3 стойности и пресмята дали запитването е осъществимо, или не. За да му е полезна вашата програма/функция, тя трябва да получава <strong>3 стойности</strong>: <strong>брой билети</strong> (колко билета желае клиента да закупи), общ <strong>бюджет</strong> на клиента, <strong>цена на един билет</strong>.</p>
<p>Клиентите не знаят цената на самолетния билет и понякога се случва бюджетът им да <strong>не покрива</strong> цената на желания брой билети. Тогава Стамат <strong>получава съобщение на конзолата</strong> за това. В обратния случай, Стамат трябва да получи друго <strong>съобщение на конзолата,</strong> в което пише <strong>броя билети и общата цена</strong>, за която клиента може да ги закупи<strong>.</strong></p>
<h3 id="вход">Вход</h3>
<p>На входа се получават <strong>3 стойности</strong>:</p>
<ul>
<li><p><strong>Брой билети</strong> - <strong>цяло число в интервала [1...10]</strong></p></li>
<li><p><strong>Бюджет</strong> на клиента- <strong>цяло число в интервала [0…10000]</strong></p></li>
<li><p><strong>Цена</strong> на един билет - <strong>цяло число в интервала [10…1000]</strong></p></li>
</ul>
<h3 id="изход">Изход</h3>
<p>Да се <strong>отпечата</strong> на конзолата:</p>
<ul>
<li><p>Ако бюджета на клиента не е достатъчен, Стамат получава на конзолата следното съобщение <strong>на един ред</strong>:</p></li>
</ul>
<p><strong>"The budget of {budget}$ is not enough. Your client can't buy {count of tickets} tickets with this budget!"</strong></p>
<ul>
<li><p>Ако бюджета е достатъчен, Стамат трябва да получи две съобщения, всяко на нов ред:</p></li>
</ul>
<p><strong>"You can sell your client {count of tickets} tickets for the price of {price}$!"</strong></p>
<p><strong>"Your client should become a change of {change}$!"</strong></p>
<h3 id="примерен-вход-и-изход">Примерен вход и изход</h3>
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
<td><p>5</p>
<p>2000</p>
<p>300</p></td>
<td><p>You can sell your client 5</p>
<p>tickets for the price of 1500$!</p>
<p>Your client should become a change of 500$!</p></td>
<td><p>Първо проверяваме дали броя на закупените билети по цената за един билет не надвишава бюджета.</p>
<p>5 * 300 = 1500 -&gt; обща цена за всички желани билети.</p>
<p>Тъй като 1500 е по-малко от 2000 =&gt; бюджета е достатъчен за закупуване на билетите. Стамат получава съобщението, в което пише брой на билетите и общата им цена.</p>
<p>Рестото което трябва да върне е 2000-1500 = 500 $</p></td>
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
<p>800</p>
<p>300</p></td>
<td>The budget of 800$ is not enough. Your client can't buy 3 tickets with this budget!</td>
<td><p>10</p>
<p>10000</p>
<p>1000</p></td>
<td><p>You can sell your client 10 tickets for the price of 10000$!</p>
<p>Your client should become a change of 0$!</p></td>
</tr>
</tbody>
</table>
