<h1 id="изпит-по-основи-на-програмирането">Изпит по "Основи на програмирането"</h1>
<h2 class="list-paragraph" id="задача-1.-пазаруване-за-първи-учебен-ден">Задача 1. Пазаруване за първи учебен ден</h2>
<p>Анабел е вече първокласничка и като такава трябва да и се купят нужните пособия за часовете и. Tова са, <strong>пакет моливи</strong>, <strong>цветни флумастери</strong>, <strong>скицник за рисуване и тетрадки</strong>. Тя знае че нейните родители имат <strong>5 процента отстъпка</strong> от мястото което ще купят нещата и <strong>ви е помолила да напишете програма, която ще изчисли колко пари ще са нужни за да се купят нужните пособия, като знаете че:</strong></p>
<ul>
<li><p><strong>Пактет моливи - 4.75 лв</strong></p></li>
<li><p><strong>Цветни флумастери</strong> <strong>- 1.80 лв (за брой)</strong></p></li>
<li><p><strong>Скицник за рисуване - 6.50 лв</strong></p></li>
<li><p><strong>Тетрадки</strong> - <strong>2.50 лв (за брой)</strong>.</p></li>
</ul>
<h3 id="вход">Вход</h3>
<p>От конзолата се четат <strong>4 числа</strong>:</p>
<ul>
<li><p><strong>На първия ред – брой пакети моливи. Цяло число в интервал [0…100]</strong></p></li>
<li><p><strong>На втория ред – брой цветни фулмастери. Цяло число в интервал [0…100]</strong></p></li>
<li><p><strong>На третия ред – брой скицници за рисуване. Цяло число в интервал [0…100]</strong></p></li>
<li><p><strong>На четвъртия ред – брой тетрадки. Цяло число в интервал [0…100]</strong></p></li>
</ul>
<h3 id="изход">Изход</h3>
<p>На конзолата <strong>да се отпечата 1 число</strong> – <strong>парите които ще са нужни за пособията на Аннабел</strong>.</p>
<ul>
<li><p><strong>"Your total is {finalTotal:f2}lv"</strong></p></li>
</ul>
<p><strong>Резултатът да се форматира до втората цифра след десетичната запетая.</strong></p>
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
<td><p>3</p>
<p>10</p>
<p>3</p>
<p>7</p></td>
<td>Your total is 65.79lv</td>
<td><p>3 - пакети моливи = <strong>14.25 лева</strong></p>
<p>10 - флумастера = <strong>18 лева</strong></p>
<p>3 скицника = <strong>19.50 лева</strong></p>
<p>7 тетрадки = <strong>17.50 лева</strong></p>
<p><strong>14.25 + 18 + 19.50 + 17.50 = 69.25 лева</strong></p>
<p><strong>Резултат:</strong> 69.25 – (( 69.25 * 5) / 100) = <strong>65.7875 лева</strong></p></td>
<td></td>
</tr>
<tr class="even">
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
</tr>
<tr class="odd">
<td><p>1</p>
<p>2</p>
<p>2</p>
<p>12</p></td>
<td>Your total is 48.78lv</td>
<td><p>5</p>
<p>3</p>
<p>5</p>
<p>15</p></td>
<td>Your total is 94.19lv</td>
</tr>
</tbody>
</table>
