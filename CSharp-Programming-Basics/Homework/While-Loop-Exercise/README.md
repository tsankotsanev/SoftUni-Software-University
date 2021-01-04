<p><strong>Упражнение: Повторения с цикли – While-цикъл</strong></p>
<p>Задачи за упражнение и домашно към курса <a href="https://softuni.bg/trainings/3038/programming-basics-with-c-sharp-july-2020">"Основи на програмирането" в СофтУни</a>.</p>
<p><strong>Тествайте</strong> решението си в <strong>judge системата</strong>: <a href="https://judge.softuni.bg/Contests/2384">https://judge.softuni.bg/Contests/2384</a></p>
<h2 id="старата-библиотека">Старата Библиотека</h2>
<p>Ани отива до родния си град след много дълъг период извън страната. Прибирайки се вкъщи тя вижда старата библиотека на баба си и си спомня за любимата си книга. Помогнете на Ани, като напишете програма в която тя въвежда търсената от нея <strong>книга</strong>(<strong>текст</strong>). <strong>Докато Ани не намери любимата си книга или не провери всички в библиотеката, програмата трябва да чете всеки път на нов ред името на всяка следваща книга (текст).</strong> <strong>Книгите в библиотеката са свършили щом получите текст "No More Books".</strong></p>
<ul>
<li><p><strong>Ако не открие търсената книгата да се отпечата на два реда:</strong></p></li>
</ul>
<ul>
<li><p><strong>"The book you search is not here!"</strong></p></li>
<li><p><strong>"You checked {брой} books."</strong></p></li>
</ul>
<ul>
<li><p><strong>Ако открие книгата си се отпечатва един ред:</strong></p>
<ul>
<li><blockquote>
<p><strong>"You checked {брой} books and found it."</strong></p>
</blockquote></li>
</ul></li>
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
<td><p>Troy</p>
<p>Stronger</p>
<p>Life Style</p>
<p>Troy</p></td>
<td>You checked 2 books and found it.</td>
<td>Книгата която Ани търси, в случая е Troy. Първата книга от библиотеката е Stronger, втората е Life Style, третата книга е търсената – Troy и програмата приключва.</td>
</tr>
<tr class="even">
<td><p>The Spot</p>
<p>Hunger Games</p>
<p>Harry Potter</p>
<p>Torronto</p>
<p>Spotify</p>
<p>No More Books</p></td>
<td><p>The book you search is not here!</p>
<p>You checked 4 books.</p></td>
<td><p>Книгата, която търси Ани е "The Spot".</p>
<p>Първата книга от библиотеката е Hunger Games, втората Harry Potter, третата Torronto, а четвъртата Spotify. Понеже няма повече книги в библиотеката, четенето на имена приключва. Ани не намери книгата, която търсеше.</p></td>
</tr>
<tr class="odd">
<td><p>Bourne</p>
<p>True Story</p>
<p>Forever</p>
<p>More Space</p>
<p>The Girl</p>
<p>Spaceship</p>
<p>Strongest</p>
<p>Profit</p>
<p>Tripple</p>
<p>Stella</p>
<p>The Matrix</p>
<p>Bourne</p></td>
<td>You checked 10 books and found it.</td>
<td></td>
</tr>
</tbody>
</table>
<h3 id="насоки">Насоки</h3>
<ol type="1">
<li><blockquote>
<p>Прочетете входните данни от конзолата.</p>
</blockquote></li>
</ol>
<p><img src="media/image1.png" style="width:3.36458in;height:0.23915in" /></p>
<ol start="2" type="1">
<li><blockquote>
<p>Направете <strong>още две помощни променливи в началото</strong>, които да следят <strong>дали книгата е намерена или всички книги са проверени</strong>. Едната променлива ще е <strong>брояч</strong> и трябва да е <strong>от тип цяло число</strong> и с <strong>първоначална стойност нула</strong>. С нея ще следим <strong>колко книги са проверени</strong>. Другата променлива трябва да е от <strong>булев тип</strong> и да е <strong>с началната стойност false</strong>.</p>
</blockquote></li>
</ol>
<p><img src="media/image2.png" style="width:2.08333in;height:0.42318in" /></p>
<ol start="3" type="1">
<li><blockquote>
<p>Направете си <strong>while</strong> цикъл, в който <strong>всеки път</strong> ще четете от конзолата нова книга, докато книгите в библиотеката <strong>се изчерпят</strong> <strong>и прочетете текста</strong> <strong>"No More Books".</strong></p>
</blockquote></li>
</ol>
<p><img src="media/image3.png" style="width:3.29167in;height:1.07597in" /></p>
<ol start="4" type="1">
<li><blockquote>
<p>Ако книгата, която четете от конзолата <strong>съвпада с любимата книга на Ани</strong>, презапишете стойността на <strong>променливата от булев тип</strong>, и <strong>прекратете цикъла</strong>, в противен случай <strong>увеличете брояча с едно</strong>.</p>
</blockquote></li>
</ol>
<p><img src="media/image4.png" style="width:3.34498in;height:2.14583in" /></p>
<ol start="5" type="1">
<li><blockquote>
<p>Според това, дали книгата е намерена, <strong>принтирайте нужните съобщения</strong>.</p>
</blockquote></li>
</ol>
<p><img src="media/image5.png" style="width:5.18822in;height:1.7815in" /></p>
<h2 id="подготовка-за-изпит">Подготовка за изпит</h2>
<p>Напишете програма, в която Марин решава задачи от изпити <strong>докато</strong> <strong>не</strong> <strong>получи</strong> съобщение <strong>"Enough"</strong> от лектора си. При всяка решена задача той получава оценка. <strong>Програмата трябва да приключи прочитането на данни при команда "Enough"</strong> <strong>или ако Марин получи определения брой незадоволителни оценки.</strong><br />
<strong>Незадоволителна е всяка оценка, която е по-малка или равна на 4.</strong></p>
<h3 id="вход">Вход</h3>
<ul>
<li><p><strong>На първи ред - брой незадоволителни оценки - цяло число в интервала [1…5]</strong></p></li>
<li><p><strong>След това многократно се четат по два реда:</strong></p>
<ul>
<li><blockquote>
<p><strong>Име на задача - текст (низ)</strong></p>
</blockquote></li>
</ul></li>
</ul>
<ul>
<li><blockquote>
<p><strong>Оценка - цяло число в интервала [2…6]</strong></p>
</blockquote></li>
</ul>
<h3 id="изход">Изход</h3>
<ul>
<li><p>Ако Марин стигне до командата <strong>"Enough", отпечатайте на 3 реда:</strong></p></li>
</ul>
<ul>
<li><blockquote>
<p><strong>"Average score: {средна оценка}"</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>"Number of problems: {броя на всички задачи}"</strong></p>
</blockquote>
<ul>
<li><blockquote>
<p><strong>"Last problem: {името на последната задача}"</strong></p>
</blockquote></li>
</ul></li>
</ul>
<ul>
<li><p><strong>Ако получи определеният брой незадоволителни оценки:</strong></p></li>
</ul>
<ul>
<li><blockquote>
<p><strong>"You need a break, {брой незадоволителни оценки} poor grades."</strong></p>
</blockquote></li>
</ul>
<p><strong>Средната оценка да бъде форматирана до втория знак след десетичната запетая.</strong></p>
<h3 id="примерен-вход-и-изход-1">Примерен вход и изход</h3>
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
<td><p>3</p>
<p>Money</p>
<p>6</p>
<p>Story</p>
<p>4</p>
<p>Spring Time</p>
<p>5</p>
<p>Bus</p>
<p>6</p>
<p>Enough</p></td>
<td><p>Average score: 5.25</p>
<p>Number of problems: 4</p>
<p>Last problem: Bus</p></td>
<td><p>Броя на позволени незадоволителни оценки е 3.</p>
<p>Първата задача се казва Money, оценката на Марин е 6.</p>
<p>Втората задача е Story, оценката на Марин е 4.</p>
<p>Третата задача е Spring Time, оценката на Марин е 5.</p>
<p>Четвъртата задача е Bus, оценката на Марин е 6.</p>
<p>Следващата команда е Enough, програмата приключва.</p>
<p>Средна оценка: 21 / 4 = 5.25</p>
<p>Брой решени задачи: 4</p>
<p>Последна задача: Bus</p></td>
</tr>
<tr class="even">
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
<td><strong>Обяснения</strong></td>
</tr>
<tr class="odd">
<td><p>2</p>
<p>Income</p>
<p>3</p>
<p>Game Info</p>
<p>6</p>
<p>Best Player</p>
<p>4</p></td>
<td>You need a break, 2 poor grades.</td>
<td><p>Броят незадоволителни оценки е 2.</p>
<p>Първата задача е Income, оценката на Марин е 3.</p>
<p>Втората задача е Game Info, оценката на Марин е 6.</p>
<p>Третата задача е Best Player, оценката на Марин е 4.</p>
<p>Марин достигна допустимия брой незадоволителни оценки, време е за почивка.</p></td>
</tr>
</tbody>
</table>
<h3 id="насоки-1">Насоки</h3>
<ol type="1">
<li><blockquote>
<p>Прочетете входните данни от конзолата:</p>
</blockquote></li>
</ol>
<p><img src="media/image6.png" style="width:4.38681in;height:0.20552in" /></p>
<ol start="2" type="1">
<li><blockquote>
<p>Направете <strong>четири помощни променливи</strong> в началото:</p>
</blockquote>
<ol type="a">
<li><p><strong>брояч за незадоволителни оценки - с първоначална стойност 0</strong></p></li>
<li><p><strong>брояч за решените упражнения - с първоначална стойност 0</strong></p></li>
<li><p><strong>сумата на всички оценки - с първоначална стойност 0</strong></p></li>
<li><p><strong>коя е последната задача</strong> - <strong>с първоначална стойност празен текст</strong></p></li>
<li><p><strong>дали се е провалил или не</strong></p></li>
</ol></li>
</ol>
<p><img src="media/image7.png" style="width:2.1875in;height:0.93656in" /></p>
<ol start="3" type="1">
<li><blockquote>
<p>Създайте <strong>while</strong> цикъл, който продължава докато <strong>броя на незадоволителни оценки е по-малък от числото, което сте прочели от конзолата</strong>. При <strong>всяко</strong> повторение на цикъла, прочетете <strong>името на задачата и оценката за нея</strong>.</p>
</blockquote></li>
</ol>
<p><img src="media/image8.png" style="width:3.59514in;height:1.74289in" /></p>
<ol start="4" type="1">
<li><blockquote>
<p>В случай, че получите команда <strong>Enough</strong> променете стойността на <strong>isfailed</strong> на <strong>true</strong> и <strong>прекратете цикъла.</strong></p>
</blockquote></li>
<li><blockquote>
<p>При <strong>всяко повторение на цикъла</strong>, <strong>прибавете</strong> оценката на Марин към <strong>сбора на всичките му оценки</strong> и увеличете брояча за <strong>оценките</strong>. Ако оценката е <strong>по-ниска или равна на 4</strong> увеличете брояча за <strong>незадоволителни оценки</strong>. Презапишете името на <strong>последната задача</strong>.</p>
</blockquote></li>
</ol>
<p><img src="media/image9.png" style="width:3.73173in;height:3.25in" /></p>
<ol start="6" type="1">
<li><blockquote>
<p>След цикъла ако броя <strong>незадоволителни оценки</strong> е достигнал <strong>максималните незадоволителни оценки</strong>, принтирайте нужното съобщение:</p>
</blockquote></li>
</ol>
<p><img src="media/image10.png" style="width:6.03264in;height:1.85633in" /></p>
<h2 id="почивка">Почивка</h2>
<p>Джеси е решила да събира пари за екскурзия и иска от вас да ѝ помогнете да разбере <strong>дали ще успее да събере необходимата сума</strong>. <strong>Тя спестява</strong> или <strong>харчи част от</strong> <strong>парите</strong> си <strong>всеки ден</strong>. Ако иска да <strong>похарчи повече от наличните си пари</strong>, то тя ще похарчи <strong>колкото има и ще ѝ останат 0 лева</strong>.</p>
<h3 id="вход-1">Вход</h3>
<p>От конзолата се четат:</p>
<ul>
<li><blockquote>
<p><strong>Пари нужни за екскурзията</strong> - <strong>реално</strong> <strong>число в интервала [1.00.. .25000.00]</strong></p>
</blockquote></li>
<li><blockquote>
<p><strong>Налични пари</strong> - <strong>реално</strong> <strong>число в интервала [0.00... 25000.00]</strong></p>
</blockquote></li>
</ul>
<blockquote>
<p><strong>След това многократно се четат по два реда:</strong></p>
</blockquote>
<ul>
<li><blockquote>
<p><strong>Вид действие – текст с възможности "spend" и "save".</strong></p>
</blockquote>
<ul>
<li><blockquote>
<p><strong>Сумата, която ще спести/похарчи - реално число в интервала [0.01… 25000.00]</strong></p>
</blockquote></li>
</ul></li>
</ul>
<h3 id="изход-1">Изход</h3>
<p>Програмата трябва да приключи при следните случаи:</p>
<ul>
<li><p>Ако <strong><u>5 последователни дни</u></strong> Джеси <strong>само харчи, на конзолата да се изпише<u>:</u></strong></p></li>
</ul>
<ul>
<li><p><strong>"You can't save the money."</strong></p></li>
<li><p><strong>"{Общ брой изминали дни}"</strong></p></li>
</ul>
<ul>
<li><p><strong>Ако</strong> <strong>Джеси събере парите за почивката</strong> на <strong>конзолата се изписва:</strong></p></li>
</ul>
<ul>
<li><p><strong>"You saved the money for {общ брой изминали дни} days."</strong></p></li>
</ul>
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
<td><p>2000</p>
<p>1000</p>
<p>spend</p>
<p>1200</p>
<p>save</p>
<p>2000</p></td>
<td>You saved the money for 2 days.</td>
<td><p>Пари нужни за почивката: 2000</p>
<p>Наличните пари: 1000</p>
<p>spend – изваждаме от парите следващото число</p>
<p>1200 - ние разполагаме с 1000, но се опитваме да похарчим 1200, тъй като не разполагаме с толкова, харчим наличните си 1000 и оставаме 0 лева.</p>
<p>save – прибавяме към парите следващото число</p>
<p>2000 – разполагаме с 0, добавяме 2000 и събираме парите успешно за 2 дни.</p></td>
<td></td>
</tr>
<tr class="even">
<td><p>110</p>
<p>60</p>
<p>spend</p>
<p>10</p>
<p>spend</p>
<p>10</p>
<p>spend</p>
<p>10</p>
<p>spend</p>
<p>10</p>
<p>spend</p>
<p>10</p></td>
<td><p>You can't save the money.</p>
<p>5</p></td>
<td><p>250</p>
<p>150</p>
<p>spend</p>
<p>50</p>
<p>spend</p>
<p>50</p>
<p>save</p>
<p>100</p>
<p>save</p>
<p>100</p></td>
<td>You saved the money for 4 days.</td>
</tr>
</tbody>
</table>
<h3 id="насоки-2">Насоки</h3>
<ol type="1">
<li><blockquote>
<p>Прочетете входните данни от конзолата:</p>
</blockquote></li>
</ol>
<p><img src="media/image11.png" style="width:4.57431in;height:0.40613in" /></p>
<ol start="2" type="1">
<li><blockquote>
<p>Направете <strong>две помощни променливи</strong> в началото, които да следят <strong>броя изминали дни и броя последователни дни, в които Джеси харчи пари</strong>. Нека и двете променливи да бъдат с първоначална <strong>стойност нула</strong>:</p>
</blockquote></li>
</ol>
<p><img src="media/image12.png" style="width:2.1574in;height:0.42847in" /></p>
<blockquote>
<p>Създайте <strong>while</strong> цикъл, който продължава, докато парите на Джеси са по-малко от парите, които са ѝ нужни за екскурзията и броячът за последователните дни е по-малък от 5. При <strong>всяко повторение на цикъла</strong> четете от конзолата <strong>два реда</strong> - първият ред е текст - <strong>spend</strong> или <strong>save</strong>, а вторият – парите, които Джеси е спестила или похарчила. Също така увеличете брояча за дни с 1:</p>
</blockquote>
<p><img src="media/image13.png" style="width:4.69931in;height:1.21967in" /></p>
<ol start="3" type="1">
<li><blockquote>
<p>Направете проверка дали Джеси <strong>харчи или спестява</strong> за дадения ден:</p>
</blockquote>
<ol type="a">
<li><p>aко <strong>спестява</strong>, прибавете спестените пари към нейните и <strong>нулирайте брояча за поредните дни</strong>;</p></li>
<li><p>aко <strong>харчи</strong>, извадете от нейните пари сумата която е похарчила и <strong>увеличете брояча за поредните дни,</strong> в които харчи. Проверете дали парите на Джеси са станали <strong>по-малко от нула</strong> и ако е така, то тя е останала без пари и има нула лева</p></li>
</ol></li>
<li><blockquote>
<p>След цикъла проверете дали Джеси е харчила пари в <strong>пет последователни дни</strong> и принтирайте съобщението. Също така проверете дали Джеси е <strong>събрала парите</strong> и, ако е успяла, принтирайте съответното съобщение:</p>
</blockquote></li>
</ol>
<p><img src="media/image14.png" style="width:5.84514in;height:1.77735in" /></p>
<h2 id="стъпки">Стъпки</h2>
<p>Габи иска да започне здравословен начин на живот и си е поставила за цел да върви <strong>10 000 стъпки всеки ден</strong>. Някои дни обаче е много уморена от работа и ще иска да се прибере преди да постигне целта си. Напишете програма, която <strong>чете от конзолата по колко стъпки изминава</strong> тя всеки път като излиза през деня и <strong>когато постигне целта си да се изписва</strong> "<strong>Goal reached! Good job!</strong>" и колко стъпки повече е извървяла "<strong>{разликата между стъпките} steps over the goal!</strong>"</p>
<p>Ако иска да се <strong>прибере преди това</strong>, тя ще въведе <strong>командата</strong> "<strong>Going home</strong>" и <strong>ще въведе стъпките, които е извървяла докато се прибира</strong>. След което, ако не е успяла да постигне целта си, на конзолата трябва да се изпише: "<strong>{разликата между стъпките} more steps to reach goal.</strong>"</p>
<h3 id="примерен-вход-и-изход-3">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
<th><strong>Вход</strong></th>
<th><strong>Изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>1000</p>
<p>1500</p>
<p>2000</p>
<p>6500</p></td>
<td><p>Goal reached! Good job!</p>
<p>1000 steps over the goal!</p></td>
<td><p>1500</p>
<p>300</p>
<p>2500</p>
<p>3000</p>
<p>Going home</p>
<p>200</p></td>
<td>2500 more steps to reach goal.</td>
</tr>
<tr class="even">
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
<td><strong>Вход</strong></td>
<td><strong>Изход</strong></td>
</tr>
<tr class="odd">
<td><p>1500</p>
<p>3000</p>
<p>250</p>
<p>1548</p>
<p>2000</p>
<p>Going home</p>
<p>2000</p></td>
<td><p>Goal reached! Good job!</p>
<p>298 steps over the goal!</p></td>
<td><p>125</p>
<p>250</p>
<p>4000</p>
<p>30</p>
<p>2678</p>
<p>4682</p></td>
<td><p>Goal reached! Good job!</p>
<p>1765 steps over the goal!</p></td>
</tr>
</tbody>
</table>
<h1 id="примерни-изпитни-задачи">Примерни изпитни задачи</h1>
<h2 id="монети">Монети</h2>
<p>Производителите на вендинг машини искали да направят машините си да връщат възможно <strong>най-малко монети ресто</strong>. Напишете програма, която приема <strong>сума</strong> - <strong>рестото</strong>, което трябва да се върне и изчислява <strong>с колко най-малко монети може да стане това</strong>.</p>
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
<td>1.23</td>
<td>4</td>
<td>Рестото ни е 1 лев и 23 стотинки. Машината ни го връща с 4 монети: монета от 1 лев, монета от 20 стотинки, монета от 2 стотинки и монета от 1 стотинка.</td>
</tr>
<tr class="even">
<td>2</td>
<td>1</td>
<td>Рестото ни е 2 лева. Машината ни го връща с 1 монета от 2 лева.</td>
</tr>
<tr class="odd">
<td>0.56</td>
<td>3</td>
<td>Рестото ни е 56 стотинки. Машината ни го връща с 3 монети: монета от 50 стотинки, монета от 5 стотинки и монета от 1 стотинка.</td>
</tr>
<tr class="even">
<td>2.73</td>
<td>5</td>
<td>Рестото ни е 2 лева и 73 стотинки. Машината ни го връща с 5 монети: монета от 2 лева, монета от 50 стотинки, монета от 20 стотинки, монета от 2 стотинки и монета от 1 стотинка.</td>
</tr>
</tbody>
</table>
<h2 id="торта">Торта</h2>
<p>Поканени сте на 30-ти рожден ден, на който рожденикът черпи с огромна торта. Той обаче не знае <strong>колко парчета могат да си вземат гостите от нея</strong>. Вашата задача е да напишете програма, която изчислява <strong>броя на парчетата</strong>, които гостите са взели, преди тя да свърши. Ще получите <strong>размерите на тортата</strong> (широчина и дължина – <strong>цели числа</strong> в интервала [1...1000]) и след това на всеки ред, до получаване на командата "<strong>STOP</strong>" или <strong>докато не свърши тортата</strong>, броят на парчетата, които гостите вземат от нея.</p>
<p><strong>Бележка: Едно парче торта е с размер 1х1 см.</strong></p>
<p>Да се <strong>отпечата</strong> на конзолата <strong>един</strong> от следните редове:</p>
<ul>
<li><p><strong>"{брой парчета} pieces are left."</strong> - ако стигнете до <strong>STOP</strong> и не са свършили парчетата торта</p></li>
</ul>
<ul>
<li><blockquote>
<p><strong>"No more cake left! You need {брой недостигащи парчета} pieces more."</strong></p>
</blockquote></li>
</ul>
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
<td><p>10</p>
<p>10</p>
<p>20</p>
<p>20</p>
<p>20</p>
<p>20</p>
<p>21</p></td>
<td>No more cake left! You need 1 pieces more.</td>
<td><p>Размер на тортата: 10*10 = 100.</p>
<p>Въвеждат се многократно брой парчета които са взети:</p>
<p>20+20+20+20+21=101</p>
<p>Не ни достига едно парче: 101-100=1</p></td>
</tr>
<tr class="even">
<td><p>10</p>
<p>2</p>
<p>2</p>
<p>4</p>
<p>6</p>
<p>STOP</p></td>
<td><ol start="8" type="1">
<li><p>pieces are left.</p></li>
</ol></td>
<td></td>
</tr>
</tbody>
</table>
