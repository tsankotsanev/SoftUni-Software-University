<h1 id="първи-стъпки-в-програмирането">Първи стъпки в програмирането</h1>
<p>Задачи за упражнение в клас и за домашно към курса <a href="https://softuni.bg/courses/programming-basics">"Основи на програмирането" @ СофтУни</a>.</p>
<p>Тествайте решенията си в <strong>judge системата</strong>: <u>https://judge.softuni.bg/Contests/2339/First-Steps-In-Coding-Lab</u></p>
<h2 id="конзолна-програма-hello-softuni">Конзолна програма "Hello SoftUni"</h2>
<p>Напишете <strong>конзолна C# програма</strong>, която отпечатва текста "<strong>Hello SoftUni</strong>".</p>
<ol type="1">
<li><p>Стартирайте Visual Studio.</p></li>
<li><p>Създайте нов конзолен проект: [Create a new project].</p></li>
</ol>
<p><img src="media/image1.png" style="width:6.97986in;height:4.52083in" /></p>
<ol start="3" type="1">
<li><p>Изберете [Console App (.NET Core)<img src="media/image2.png" style="width:6.13832in;height:4.47014in" /></p></li>
<li><p>Дайте подходящо име на проекта, например "<strong>HelloSoftUni</strong>":</p></li>
</ol>
<p><img src="media/image3.png" style="width:6.38819in;height:3.90271in" /></p>
<ol start="5" type="1">
<li><p>Намерете секцията <strong>Main(string[] args)</strong>. В нея се пише програмен код (команди) на езика C#.</p></li>
<li><p>Придвижете курсора между отварящата и затварящата скоба <strong>{ }</strong>.</p></li>
<li><p>Натиснете <strong>[Enter]</strong> след отварящата скоба <strong>{</strong>.</p></li>
</ol>
<p><img src="media/image4.png" style="width:7.24653in;height:1.97014in" /></p>
<ol start="8" type="1">
<li><p>Напишете следния програмен код (команда за печатане на текста <strong>"Hello SoftUni"</strong>):</p></li>
</ol>
<table>
<tbody>
<tr class="odd">
<td>Console.WriteLine("Hello SoftUni");</td>
</tr>
</tbody>
</table>
<p>Кодът на програмата се пише отместен навътре с една табулация спрямо отварящата скоба <strong>{</strong>.</p>
<p><img src="media/image5.png" style="width:7.24653in;height:1.98125in" /></p>
<ol start="9" type="1">
<li><p><strong>Стартирайте</strong> програмата с натискане на <strong>[Ctrl+F5]</strong>. Трябва да получите следния резултат:</p></li>
</ol>
<blockquote>
<p><img src="media/image6.png" style="width:3.97917in;height:1.21875in" /></p>
</blockquote>
<ol start="10" type="1">
<li><p><strong>Тествайте</strong> решението на тази задача в онлайн judge системата на СофтУни. За целта първо отворете https://judge.softuni.bg/Contests/Compete/Index/2339#0. Влезте с вашето потребителско име в СофтУни. Ще се появи прозорец за изпращане на решения за задача "<strong>Hello SoftUni</strong>". Копирайте сорс кода от Visual Studio и го поставете в полето за изпращане на решения:</p></li>
</ol>
<p><img src="media/image7.png" style="width:7.24653in;height:4.51806in" /></p>
<ol start="11" type="1">
<li><p><strong>Изпратете решението</strong> за оценяване с бутона [Submit]. Ще получите резултата след няколко секунди в таблицата с изпратени решения в judge системата:</p></li>
</ol>
<p><img src="media/image8.png" style="width:7.27725in;height:1.816in" /></p>
<h2 id="числата-от-1-до-10">Числата от 1 до 10</h2>
<p>Напишете C# конзолна програма, която <strong>отпечатва числата от 1 до 10</strong> на отделни редове на конзолата.</p>
<ol type="1">
<li><p>Създайте конзолно C# приложение с име "<strong>Nums1To10</strong>":</p></li>
</ol>
<p><img src="media/image9.png" style="width:7.20833in;height:4.9992in" /></p>
<p><img src="media/image10.png" style="width:7.24653in;height:3.10833in" /></p>
<ol start="2" type="1">
<li><p>Напишете 10 команди <strong>Console.WriteLine()</strong>, една след друга, за да отпечатате числата от 1 до 10.</p></li>
</ol>
<p><img src="media/image11.png" style="width:2.73611in;height:2.71811in" /></p>
<ol start="3" type="1">
<li><p><strong>Тествайте</strong> вашето решение на задачата в judge системата.</p></li>
<li><p>Можете ли да напишете програмата по <strong>по-умен начин</strong>, така че да не повтаряте 10 пъти една и съща команда? Потърсете в Интернет информация за "<a href="https://www.google.com/search?q=for+loop+C%23"><strong>for loop C#</strong></a>".</p></li>
</ol>
<h2 id="пресмятане-на-лице-на-квадрат">Пресмятане на лице на квадрат</h2>
<p>Да се напише <strong>конзолна програма</strong>, която <strong>въвежда цяло число</strong> '<strong>a'</strong> и <strong>пресмята лицето на квадрат</strong> <strong>със страна</strong> '<strong>a'</strong>.</p>
<h3 id="примерен-вход-и-изход">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>5</td>
<td>25</td>
</tr>
</tbody>
</table>
<h3 id="насоки">Насоки</h3>
<ol type="1">
<li><p><strong>Инициализирайте</strong> променлива <strong>side</strong> и в нея запишете стойността въведена от конзолата:</p></li>
</ol>
<blockquote>
<p><img src="media/image12.png" style="width:4.03577in;height:1.52705in" alt="A screenshot of a cell phone Description automatically generated" /></p>
</blockquote>
<ol start="2" type="1">
<li><p><strong>Инициализирайте втора променлива area</strong>, в която да запишете стойността за лицето на правоъгълника, получена по формулата <strong>side * side</strong>. Принтирайте получения резултат:</p></li>
</ol>
<blockquote>
<p><img src="media/image13.png" style="width:4.33333in;height:2.29227in" alt="A screenshot of a cell phone Description automatically generated" /></p>
</blockquote>
<h2 id="от-инчове-към-сантиметри">От инчове към сантиметри</h2>
<p>Да се напише програма, която <strong>чете от конзолата число</strong> (реално число) и преобразува числото <strong>от инчове в сантиметри</strong>. За целта <strong>умножава инчовете по 2.54</strong> (защото 1 инч = 2.54 сантиметра).</p>
<h3 id="примерен-вход-и-изход-1">Примерен вход и изход</h3>
<table>
<thead>
<tr class="header">
<th><strong>вход</strong></th>
<th><strong>изход</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>5</td>
<td>12.7</td>
</tr>
</tbody>
</table>
<p><strong>Внимание:</strong> в зависимост от регионалните настройки на операционната система, е възможно вместо <strong>десетична точка</strong> (US настройки) да се използва <strong>десетична запетая</strong> (BG настройки). Ако програмата очаква десетична точка и бъде въведено число с десетична запетая или на обратно (бъде въведена десетична точка когато се очаква десетична запетая), ще се получи следната грешка:<br />
<img src="media/image14.png" style="width:7.24653in;height:1.86528in" /></p>
<p>Препоръчително е <strong>да промените настройките на компютъра си</strong>, така че да се използва <strong>десетична точка</strong>:</p>
<p><img src="media/image15.png" style="width:6.58333in;height:2.03336in" /></p>
<p><img src="media/image16.png" style="width:6.10429in;height:3.92289in" /></p>
<h2 id="поздрав-по-име">Поздрав по име</h2>
<p>Напишете програма, която <strong>чете от конзолата име на човек</strong> и отпечатва "<strong>Hello,</strong> <strong>&lt;name&gt;!</strong>", където <strong>&lt;name&gt;</strong> е въведеното име от конзолата.</p>
<ol type="1">
<li><p>Първо създайте <strong>нов C# конзолен проект</strong> с име "<strong>Greeting</strong>" в нов проект с име "<strong>SimpleCalculations</strong>", като изберем от горният ляв ъгъл <strong>File -&gt; New -&gt; Project...</strong> <img src="media/image17.png" style="width:5.63681in;height:3.96875in" alt="A screenshot of a cell phone Description automatically generated" /><img src="media/image18.png" style="width:5.93265in;height:4.12528in" alt="A screenshot of a cell phone Description automatically generated" /> <img src="media/image19.png" style="width:5.93264in;height:4.10879in" alt="A screenshot of a cell phone Description automatically generated" /></p></li>
<li><p>Създайте променливата <strong>name</strong> от тип <strong>string</strong> и запазете в нея името, което получавате от конзолата</p></li>
</ol>
<blockquote>
<p><img src="media/image20.png" style="width:3.68216in;height:1.63033in" /></p>
</blockquote>
<ol start="3" type="1">
<li><blockquote>
<p>Изведете изхода на конзолата като използвате следния шаблон:</p>
</blockquote></li>
</ol>
<blockquote>
<p><img src="media/image21.png" style="width:4.05in;height:1.44535in" /></p>
<p>Как работи примерът? Методът <strong>Console.WriteLine</strong> ни позволява в кръглите скоби да записваме поредица от символи, които дефинират място за текстова стойност в крайния текст, който ще бъде принтиран на конзолата. В нашия случай тази стойност ще бъде стойността на променливата <strong>name</strong>, която сме подали в къдравите скоби в текста за принтиране.</p>
<p>Можете да прочетете повече за разновидностите от шаблони, които ни предлага езика <strong>C#</strong>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netcore-2.2">тук</a>.</p>
<p>Можем да постигнем същия ефект и с метода на <strong>конкатенация</strong> (долепяне) на <strong>string</strong> стойности и метода <strong>Console.WriteLine</strong>:</p>
<p><img src="media/image22.png" style="width:4.99028in;height:2.30524in" /></p>
</blockquote>
<ol start="4" type="1">
<li><p>Стартирайте програмата с <strong>Ctrl + F5</strong> и тествайте с различни входни примери. <img src="media/image23.png" style="width:3.71667in;height:1.20169in" /></p></li>
</ol>
<h2 id="съединяване-на-текст-и-числа">Съединяване на текст и числа</h2>
<p>Напишете програма, която прочита от конзолата име, фамилия, възраст и град и печата съобщение от следния вид: "<strong>You are &lt;firstName&gt; &lt;lastName&gt;, a &lt;age&gt;-years old person from &lt;town&gt;.</strong>"</p>
<ol type="1">
<li><p>Добавете към текущото Visual Studio решение още един <strong>конзолен проект</strong> с име "<strong>ConcatenateData</strong>", като изберем с десен бутон върху проекта <strong>Add -&gt; New Project...</strong></p></li>
</ol>
<blockquote>
<p><img src="media/image24.png" style="width:5.93638in;height:5.32553in" alt="A screenshot of a social media post Description automatically generated" /></p>
</blockquote>
<ol start="2" type="1">
<li><p>Въведете входните данни и ги запишете в променливи с подходящ тип данни:<br />
<img src="media/image25.png" style="width:4.55723in;height:2.42103in" alt="A screenshot of a cell phone Description automatically generated" /></p></li>
<li><p>Изведете на конзолата форматирания изход:<br />
<img src="media/image26.png" style="width:5.94958in;height:3.15125in" /></p></li>
<li><p>Стартирайте програмата с <strong>Ctrl + F5</strong> и тествайте с различни входни примери. <img src="media/image27.png" style="width:3.5in;height:1.04525in" /></p></li>
<li><p><strong>Ако все още получавате резултата от миналата задача, това се получава, защото не сте сменили стартовия проект. Как да се справите с проблема?</strong></p></li>
<li><p>Както виждате <strong>Greeting</strong> проекта е с удебелени черни букви – това означава, че това е вашият стартов проект. За да смените стартовия проект, изберете с десен бутон върху желания проект <strong>Set as StartUp Project</strong>.</p></li>
</ol>
<p><img src="media/image28.png" style="width:2.50599in;height:3.68868in" alt="A screenshot of a cell phone Description automatically generated" /></p>
<blockquote>
<p><img src="media/image29.png" style="width:6.48341in;height:1.475in" /></p>
</blockquote>
<h2 id="изготвяне-на-проекти">Изготвяне на проекти</h2>
<p>Напишете програма, която <strong>изчислява</strong> <strong>колко часове</strong> ще са необходими на един архитект, за да <strong>изготви проектите</strong> на няколко строителни обекта. Изготвянето на един проект отнема <strong>три часа</strong>.</p>
<p><strong>Вход</strong></p>
<p>От конзолата се четат <strong>2 реда</strong>:</p>
<ol type="1">
<li><p><strong>Името на архитекта - текст</strong></p></li>
<li><p><strong>Брой на проектите - цяло число в интервала [0… 100]</strong></p></li>
</ol>
<p><strong>Изход</strong></p>
<p>На конзолата се отпечатва:</p>
<ul>
<li><p><strong>"The architect {името на архитекта} will need {необходими часове} hours to complete {брой на проектите} project/s."</strong></p></li>
</ul>
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
<td><p>George</p>
<p>4</p></td>
<td>The architect George will need 12 hours to complete 4 project/s.</td>
<td></td>
<td><p>Sanya</p>
<p>9</p></td>
<td>The architect Sanya will need 27 hours to complete 9 project/s.</td>
</tr>
</tbody>
</table>
<h2 id="зоомагазин">Зоомагазин</h2>
<p>Напишете програма, която <strong>пресмята нужните разходи</strong> за закупуването на храна за кучета. Храната се пазарува <strong>основно за</strong> <strong>кучета</strong>, от зоомагазин, но понякога стопанинът им купува и за <strong>животните на съседа му</strong>. Една опаковка храна за <strong>кучета е на цена 2.50лв.</strong>, а всяка друга, която <strong>не е</strong> за тях <strong>струва 4лв</strong>.</p>
<p><strong>Вход</strong></p>
<p>От конзолата се четат <strong>2 реда</strong>:</p>
<ol type="1">
<li><p><strong>Броят на кучетата – цяло число в интервала [0… 100]</strong></p></li>
<li><p><strong>Броят на останалите животни - цяло число в интервала [0… 100]</strong></p></li>
</ol>
<p><strong>Изход</strong></p>
<p>На конзолата се отпечатва:</p>
<p><strong>"{крайната сума} lv."</strong></p>
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
<td><p>5</p>
<p>4</p></td>
<td>28.5 lv.</td>
<td></td>
<td><p>13</p>
<p>9</p></td>
<td>68.5 lv.</td>
</tr>
</tbody>
</table>
<h2 id="озеленяване-на-дворове">Озеленяване на дворове</h2>
<p>Божидара разполага с <strong>няколко къщи</strong> на Черноморието и <strong>желае да озелени дворовете на някои от тях,</strong> като по този начин създаде <strong>уютна обстановка</strong> <strong>и комфорт на гостите си</strong>, като за целта е наела фирма.</p>
<p>Напишете програма, която <strong>изчислява необходимите средства</strong>, които Божидара ще трябва да заплати на фирмата изпълнител на проекта. Цената на <strong>един кв. м. е 7.61лв със ДДС</strong>. Тъй като нейният двор е <strong>доста голям</strong>, фирмата изпълнител предлага <strong>18% отстъпка от крайната цена</strong>.</p>
<p><strong>Вход</strong></p>
<p>От конзолата се прочита само <strong>един ред</strong>:</p>
<ol type="1">
<li><p><strong>Кв. метри, които ще бъдат озеленени – реално число в интервала [0.00… 10000.00]</strong></p></li>
</ol>
<p><strong>Изход</strong></p>
<p>На конзолата се отпечатват <strong>два реда</strong>:</p>
<ul>
<li><p><strong>"The final price is: {крайна цена на услугата} lv."</strong></p></li>
<li><p><strong>"The discount is: {отстъпка} lv."</strong></p></li>
</ul>
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
<td>550</td>
<td><p>The final price is: 3432.11 lv.</p>
<p>The discount is: 753.39 lv.</p></td>
<td><p>Пресмятаме цената за озеленяване на целия двор:</p>
<p>550 * 7.61 = 4185.5 лв.</p>
<p>Приспадаме отстъпката от общата сума:</p>
<p>0.18 * 4185.5 = 753.39 лв.</p>
<p>Калкулираме крайната цена на услугата:</p>
<p>4185.5– 753.39 3432.11 лв.</p></td>
</tr>
<tr class="even">
<td>150</td>
<td><p>The final price is: 936.03 lv.</p>
<p>The discount is: 205.47 lv.</p></td>
<td></td>
</tr>
</tbody>
</table>
<h3 id="section"></h3>
