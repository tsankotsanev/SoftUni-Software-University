<h1 id="изпит-по-основи-на-програмирането">Изпит по "Основи на програмирането"</h1>
<p><strong>Задача 5. Картинг – ранглиста</strong></p>
<p>Картинг център всеки ден раздава карти с отстъпки на участниците с най-добри времена. Картите са три вида:</p>
<ul>
<li><p><strong>Gold -</strong> участници с времена <strong>по - малки от 55 секунди</strong></p></li>
<li><p><strong>Silver -</strong> участници с времена <strong>по - големи или равни на 55 секунди</strong> и <strong>по - малки или равни на 1 минута и 25 секунди</strong></p></li>
<li><p><strong>Bronze -</strong> участници с времена <strong>по - големи от 1 минута и 25 секунди</strong> и <strong>по - малки или равни на 2 минути и 0 секунди</strong></p></li>
</ul>
<p>Напишете програма/функция, която изчислява <strong>броя</strong> на <strong>Gold,</strong> <strong>Silver</strong> и <strong>Bronze</strong> картите и принтира <strong>името и времето на победителя (пилота с най - малко време за обиколка). До получаване на команда "Finish"</strong> се прочитат <strong>3 реда</strong> от конзолата <strong>- име на състезателя, минути и секунди.</strong></p>
<p><strong>Винаги ще получавате участници с различни времена!</strong></p>
<h3 id="вход">Вход</h3>
<p>От конзолата се прочитат поредица от <strong>3 реда до получаване на команда "Finish"</strong>:</p>
<ul>
<li><blockquote>
<p><strong>Име на състезателя - текст</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>Минути - цяло число [0…15]</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>Секунди - цяло число [0…59]</strong></p>
</blockquote></li>
</ul>
<h3 id="изход">Изход</h3>
<p>Накрая се отпечатват <strong>два реда</strong>:</p>
<ul>
<li><blockquote>
<p><strong>"With {минути} minutes and {секунди} seconds {име на победителя} is the winner of the day!"</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>"Today's prizes are {брой златни карти} Gold {брой сребърни карти} Silver and {брой бронзови карти} Bronze cards!"</strong></p>
</blockquote></li>
</ul>
<h3 id="примерен-вход-и-изход">Примерен вход и изход</h3>
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
<td><p>Peter</p>
<p>1</p>
<p>20</p>
<p>George</p>
<p>1</p>
<p>45</p>
<p>Maria</p>
<p>2</p>
<p>10</p>
<p>Alexander</p>
<p>0</p>
<p>52</p>
<p><strong>Finish</strong></p></td>
<td><p>With 0 minutes and 52 seconds Alexander is the winner of the day!</p>
<p>Today's prizes are 1 Gold 1 Silver and 1 Bronze cards!</p></td>
<td><p>Първият участник е Peter с време 1 минута и 20 секунди и получава <strong>Silver</strong> - карта</p>
<p>Следващият е George с 1 минута и 45 секунди и съответно получава <strong>Bronze</strong> - карта.</p>
<p>Maria е с време 2 минути и 10 секунди и не получава награда.</p>
<p>Alexander е с време 0 минути и 52 секунди и получава <strong>Gold</strong> - карта, той е и с най - малко време за обиколка и е <strong>победителя за деня</strong>.</p>
<p>Получаваме <strong>Finish</strong> излизаме от програмата и принтираме резултатите.</p></td>
</tr>
<tr class="even">
<td><p>Nick</p>
<p>3</p>
<p>20</p>
<p>Jack</p>
<p>2</p>
<p>45</p>
<p>Sofia</p>
<p>4</p>
<p>10</p>
<p>Viktor</p>
<p>2</p>
<p>52</p>
<p><strong>Finish</strong></p></td>
<td><p>With 2 minutes and 45 seconds Jack is the winner of the day!</p>
<p>Today's prizes are 0 Gold 0 Silver and 0 Bronze cards!</p></td>
<td></td>
</tr>
</tbody>
</table>
