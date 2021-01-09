<h1 id="exercise-regular-expressions">Exercise: Regular Expressions</h1>
<p>Problems for exercise and homework for the <a href="https://softuni.bg/trainings/3135/csharp-fundamentals-september-2020">"C# Fundamentals" course @ SoftUni</a><br />
You can check your solutions in <a href="https://judge.softuni.bg/Contests/1668/">Judge</a></p>
<h2 id="furniture">Furniture</h2>
<p>Write a program to calculate the total cost of different types of furniture. You will be given some lines of input until you receive the line "Purchase". For the line to be valid it should be in the following format:</p>
<p><strong>"&gt;&gt;{furniture name}&lt;&lt;{price}!{quantity}"</strong></p>
<p>The price can be floating point number or whole number. Store the names of the furniture and the total price. At the end print the each bought furniture on separate line in the format:</p>
<p><strong>"Bought furniture:</strong></p>
<p><strong>{1<sup>st</sup> name}</strong></p>
<p><strong>{2<sup>nd</sup> name}</strong></p>
<p><strong>…"</strong></p>
<p>And on the last line print the following: <strong>"Total money spend: {spend money}"</strong> formatted to the second decimal point.</p>
<h3 id="examples">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th><strong>Comment</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>&gt;&gt;Sofa&lt;&lt;312.23!3</p>
<p>&gt;&gt;TV&lt;&lt;300!5</p>
<p>&gt;Invalid&lt;&lt;!5</p>
<p>Purchase</p></td>
<td><p>Bought furniture:</p>
<p>Sofa</p>
<p>TV</p>
<p>Total money spend: 2436.69</p></td>
<td>Only the Sofa and the TV are valid, for each of them we multiply the price by the quantity and print the result</td>
</tr>
</tbody>
</table>
<h2 id="race">Race</h2>
<p>Write a program that processes information about a race. On the <strong>first line</strong> you will be given <strong>list of participants</strong> <strong>separated by ", "</strong>. On the next few lines until you receive a line <strong>"end of race"</strong> you will be given some info which will be some <strong>alphanumeric characters</strong>. In between them you could have some <strong>extra characters which you should ignore</strong>. For example: <strong>"G!32e%o7r#32g$235@!2e"</strong>. The <strong>letters are the name</strong> of the person and the <strong>sum of the digits is the distance</strong> he ran. So here we have <strong>George</strong> who ran <strong>29 km</strong>. Store the information about the person only <strong>if the list of racers contains the name of the person</strong>. If you receive the <strong>same person more than once just add the distance to his old distance</strong>. At the end <strong>print the top 3 racers</strong> ordered by <strong>distance in descending</strong> in the format:</p>
<p><strong>"1st place: {first racer}</strong></p>
<p><strong>2nd place: {second racer}</strong></p>
<p><strong>3rd place: {third racer}"</strong></p>
<h3 id="examples-1">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th><strong>Comment</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>George, Peter, Bill, Tom</p>
<p>G4e@55or%6g6!68e!!@</p>
<p>R1@!3a$y4456@</p>
<p>B5@i@#123ll</p>
<p>G@e54o$r6ge#</p>
<p>7P%et^#e5346r</p>
<p>T$o553m&amp;6</p>
<p>end of race</p></td>
<td><p>1st place: George</p>
<p>2nd place: Peter</p>
<p>3rd place: Tom</p></td>
<td>On the 3<sup>rd</sup> input line we have Ray. He is not in the list, so we do not count his result. The other ones are valid. George has total of 55 km, Peter has 25 and Tom has 19. We do not print Bill because he is on 4<sup>th</sup> place.</td>
</tr>
</tbody>
</table>
<h2 id="softuni-bar-income">SoftUni Bar Income</h2>
<p>Let`s take a break and visit the game bar at SoftUni. It is about time for the people behind the bar to go home and you are the person who has to draw the line and calculate the money from the products that were sold throughout the day. Until you receive a line with text <strong>"end of shift"</strong> you will be given lines of input. But before processing that line you have to do some validations first.</p>
<p><strong>Each valid order</strong> should have a <strong>customer, product, count and a price:</strong></p>
<ul>
<li><blockquote>
<p>Valid customer's name should be <strong>surrounded by '%'</strong> and must <strong>start with a capital letter</strong>, followed by <strong>lower-case letters</strong></p>
</blockquote></li>
<li><blockquote>
<p>Valid product <strong>contains any word character</strong> and must be <strong>surrounded by '&lt;' and '&gt;'</strong></p>
</blockquote></li>
<li><blockquote>
<p>Valid count is an <strong>integer</strong>, <strong>surrounded by '|'</strong></p>
</blockquote></li>
<li><blockquote>
<p>Valid price is any <strong>real number followed by '$'</strong></p>
</blockquote></li>
</ul>
<p>The parts of a valid order should appear in the order given: <strong>customer, product, count and a price</strong>.</p>
<p>Between each part there can be other symbols, except (<strong>'|', '$', '%' and '.'</strong>)</p>
<p>For each valid line print on the console: <strong>"{customerName}: {product} - {totalPrice}"</strong></p>
<p>When you receive <strong>"end of shift"</strong> print the total amount of money for the day <strong>rounded to 2 decimal places</strong> in the following format: <strong>"Total income: {income}".</strong></p>
<h3 id="input-constraints">Input / Constraints</h3>
<ul>
<li><blockquote>
<p>Strings that you have to process until you receive text <strong>"end of shift".</strong></p>
</blockquote></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>Print all of the valid lines in the format <strong>"{customerName}: {product} - {totalPrice}"</strong></p></li>
<li><p>After receiving <strong>"end of shift"</strong> print the total amount of money for the day rounded to 2 decimal places in the following format: <strong>"Total income: {income}"</strong></p></li>
<li><p>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong>.</p></li>
</ul>
<h3 id="examples-2">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th><strong>Comment</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>%George%&lt;Croissant&gt;|2|10.3$</p>
<p>%Peter%&lt;Gum&gt;|1|1.3$</p>
<p>%Maria%&lt;Cola&gt;|1|2.4$</p>
<p>end of shift</p></td>
<td><p>George: Croissant - 20.60</p>
<p>Peter: Gum - 1.30</p>
<p>Maria: Cola - 2.40</p>
<p>Total income: 24.30</p></td>
<td><p>Each line is valid, so we print each order, calculating the total price of the product bought.</p>
<p>At the end we print the total income for the day</p></td>
</tr>
<tr class="even">
<td><p>%InvalidName%&lt;Croissant&gt;|2|10.3$</p>
<p>%Peter%&lt;Gum&gt;1.3$</p>
<p>%Maria%&lt;Cola&gt;|1|2.4</p>
<p>%Valid%&lt;Valid&gt;valid|10|valid20$</p>
<p>end of shift</p></td>
<td><p>Valid: Valid - 200.00</p>
<p>Total income: 200.00</p></td>
<td><p>On the first line, the customer name isn`t valid, so we skip that line.<br />
The second line is missing product count.</p>
<p>The third line don`t have a valid price.</p>
<p>And only the forth line is valid</p></td>
</tr>
</tbody>
</table>
<h2 id="star-enigma">*Star Enigma</h2>
<p>The war is in its peak, but you, young Padawan, can turn the tides with your programming skills. You are tasked to create a program to <strong>decrypt</strong> the messages of The Order and prevent the death of hundreds of lives.</p>
<p>You will receive several messages, which are <strong>encrypted</strong> using the legendary star enigma. You should <strong>decrypt the messages</strong>, following these rules:</p>
<p>To properly decrypt a message, you should <strong>count all the letters</strong> <strong>[s, t, a, r]</strong> – <strong>case insensitive</strong> and <strong>remove</strong> the count from the <strong>current ASCII value of each symbol</strong> of the encrypted message.</p>
<p>After decryption:</p>
<p>Each message should have a <strong>planet name, population, attack type ('A', as attack or 'D', as destruction) and soldier count.</strong></p>
<p>The planet name <strong>starts after</strong> <strong>'@'</strong> and contains <strong>only letters from the Latin alphabet</strong>.</p>
<p>The planet population <strong>starts after ':'</strong> and is an <strong>Integer</strong>;</p>
<p>The attack type may be <strong>"A"(attack) or "D"(destruction)</strong> and must be <strong>surrounded by "!"</strong> (exclamation mark).</p>
<p>The <strong>soldier count</strong> starts after <strong>"-&gt;"</strong> and should be an Integer.</p>
<p>The order in the message should be: <strong>planet name -&gt; planet population -&gt; attack type -&gt; soldier count.</strong> Each part can be separated from the others by <strong>any character except: '@', '-', '!', ':' and '&gt;'.</strong></p>
<h3 id="input-constraints-1">Input / Constraints</h3>
<ul>
<li><p>The <strong>first line</strong> <strong>holds n</strong> – the number of <strong>messages</strong>– <strong>integer in range [1…100];</strong></p></li>
<li><p>On the next <strong>n</strong> lines, you will be receiving encrypted messages.</p></li>
</ul>
<h3 id="output-1">Output</h3>
<p>After decrypting all messages, you should print the decrypted information in the following format:</p>
<p>First print the attacked planets, then the destroyed planets.<br />
<strong>"Attacked planets: {attackedPlanetsCount}"<br />
"-&gt; {planetName}"<br />
"Destroyed planets: {destroyedPlanetsCount}"<br />
"-&gt; {planetName}"</strong></p>
<p>The planets should be <strong>ordered by name</strong> <strong>alphabetically.</strong></p>
<h3 id="examples-3">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th><strong>Comments</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>2</p>
<p><strong>ST</strong>CDoghudd4=63333$D$0<strong>A</strong>53333</p>
<p>EHf<strong>s</strong>y<strong>ts</strong>nhf?8555&amp;I&amp;2C9555<strong>SR</strong></p></td>
<td><p>Attacked planets: 1</p>
<p>-&gt; Alderaa</p>
<p>Destroyed planets: 1</p>
<p>-&gt; Cantonica</p></td>
<td><p>We receive two messages, to decrypt them we calculate the key:</p>
<p>First message has decryption key 3. So we substract from each characters code 3.</p>
<p><strong>PQ@Alderaa1:30000!A!-&gt;20000</strong></p>
<p>The second message has key 5.</p>
<p><strong>@Cantonica:3000!D!-&gt;4000NM</strong></p>
<p><strong>Both messages are valid</strong> and they contain planet, population, attack type and soldiers count.</p>
<p>After decrypting all messages we print each planet according the format given.</p></td>
</tr>
<tr class="even">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
<td><strong>Comments</strong></td>
</tr>
<tr class="odd">
<td><p>3</p>
<p><strong>tt</strong>(''DG<strong>s</strong>vywge<strong>r</strong>x&gt;6444444444%H%1B9444</p>
<p>GQh<strong>rr</strong>|<strong>A</strong>977777(H(<strong>TTTT</strong></p>
<p>EHf<strong>s</strong>y<strong>ts</strong>nhf?8555&amp;I&amp;2C9555<strong>SR</strong></p></td>
<td><p>Attacked planets: 0</p>
<p>Destroyed planets: 2</p>
<p>-&gt; Cantonica</p>
<p>-&gt; Coruscant</p></td>
<td><p>We receive three messages.</p>
<p>Message one is decrypted with key 4:</p>
<p><strong>pp$##@Coruscant:2000000000!D!-&gt;5000</strong></p>
<p>Message two is decrypted with key 7:</p>
<p><strong>@Jakku:200000!A!MMMM</strong></p>
<p>This is <strong>invalid message</strong>, missing soldier count, so we continue.</p>
<p>The third message has key 5.</p>
<p><strong>@Cantonica:3000!D!-&gt;4000NM</strong></p></td>
</tr>
</tbody>
</table>
<p>"It’s a trap!" – Admiral Ackbar</p>
<h2 id="nether-realms">*Nether Realms</h2>
<p>Mighty battle is coming. In the stormy nether realms, demons are fighting against each other for supremacy in a duel from which only one will survive.</p>
<p>Your job, however is not so exciting. You are assigned to <strong>sign in all the participants</strong> in the nether realm's mighty battle's demon book, which of course is <strong>sorted alphabetically</strong>.</p>
<p>A demon's <strong>name contains his health and his damage</strong>.</p>
<p>The <strong>sum of the asci codes</strong> of <strong>all characters</strong> (excluding numbers (0-9), arithmetic symbols (<strong>'+', '-', '*', '/'</strong>) and delimiter dot (<strong>'.'</strong>)) gives a <strong>demon's total health</strong>.</p>
<p><strong>The sum of all numbers</strong> in his name forms his base damage. Note that you should consider the plus <strong>'+'</strong> and minus <strong>'-'</strong> signs (e.g. <strong>+10 is 10</strong> and <strong>-10 is -10</strong>). However, there are some symbols (<strong>'*'</strong> and <strong>'/'</strong>) that can further <strong>alter the base damage by multiplying or dividing it by 2</strong> (e.g. in the name "m<strong>15</strong>*/c<strong>-5.0</strong>", the base damage is <strong>15 + (-5.0) = 10</strong> and then you need to multiply it by 2 (e.g. 10 * 2 = 20) and then divide it by 2 (e.g. 20 / 2 = 10)).</p>
<p>So, <strong>multiplication and division</strong> are applied <strong>only after all numbers are included</strong> in the calculation and <strong>in the order they appear in the name</strong>.</p>
<p>You will get all demons <strong>on a single line</strong>, separated by commas and zero or more blank spaces. Sort them in <strong>alphabetical order</strong> and print their names <strong>along their health and damage</strong>.</p>
<h3 id="input">Input</h3>
<p>The input will be read from the console. The input consists of a <strong>single line</strong> containing all demon names <strong>separated by commas and zero or more spaces</strong> in the format: <strong>"{demon name}, {demon name}, … {demon name}"</strong></p>
<h3 id="output-2">Output</h3>
<p>Print all demons <strong>sorted by their name in ascending order</strong>, each on a separate line in the format:</p>
<ul>
<li><p><strong>"{demon name} - {health points} health, {damage points} damage"</strong></p></li>
</ul>
<h3 id="constraints">Constraints</h3>
<ul>
<li><blockquote>
<p>A demon's name will contain <strong>at least one character</strong></p>
</blockquote></li>
<li><blockquote>
<p>A demon's name <strong>cannot contain</strong> blank spaces ' ' or commas ','</p>
</blockquote></li>
<li><p>A <strong>floating point number will always have digits before and after its decimal separator</strong></p></li>
<li><p><strong>Number</strong> in a demon's name <strong>is considere</strong>d everything that is a valid integer or floating point number (with dot '.' used as separator). For example, all these are valid numbers: '4', '+4', '-4', '3.5', '+3.5', '-3.5'</p></li>
</ul>
<h3 id="examples-4">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th><strong>Comments</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>M3ph-0.5s-0.5t0.0**</td>
<td>M3ph-0.5s-0.5t0.0** - 524 health, 8.00 damage</td>
<td><p>M3ph-0.5s-0.5t0.0**:</p>
<p>Health = 'M' + 'p' + 'h' + 's' + 't' = 524 health.</p>
<p>Damage = (3 + (-0.5) + (-0.5) + 0.0) * 2 * 2 = 8 damage.</p></td>
</tr>
<tr class="even">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
<td><strong>Comments</strong></td>
</tr>
<tr class="odd">
<td>M3ph1st0**, Azazel</td>
<td><p>Azazel - 615 health, 0.00 damage</p>
<p>M3ph1st0** - 524 health, 16.00 damage</p></td>
<td><p>Azazel:</p>
<p>Health - 'A' + 'z' + 'a' + 'z' + 'e' + 'l' = 615 health. Damage - no digits = 0 damage.</p>
<p>M3ph1st0**:</p>
<p>Health - 'M' + 'p' + 'h' + 's' + 't' = 524 health.</p>
<p>Damage - (3 + 1 + 0) * 2 * 2 = 16 damage.</p></td>
</tr>
<tr class="even">
<td>Gos/ho</td>
<td>Gos/ho - 512 health, 0.00 damage</td>
<td></td>
</tr>
</tbody>
</table>
<h2 id="extract-emails">*Extract Emails</h2>
<p>Write a program to <strong>extract all email addresses from a given text</strong>. The text comes at the only input line. Print the emails on the console, each at a separate line. Emails are considered to be in format <strong>&lt;user&gt;@&lt;host&gt;</strong>, where:</p>
<ul>
<li><p><strong>&lt;user&gt;</strong> is a sequence of <strong>letters</strong> and <strong>digits</strong>, where '<strong>.</strong>', '<strong>-</strong>' and '<strong>_</strong>' can appear between them.</p>
<ul>
<li><p>Examples of valid users: "<strong>stephan</strong>", "<strong>mike03</strong>", "<strong>s.johnson</strong>", "<strong>st_steward</strong>", "<strong>softuni-bulgaria</strong>", "<strong>12345</strong>".</p></li>
<li><p>Examples of invalid users: ''<strong>--123</strong>", "<strong>.....</strong>", "<strong>nakov_-</strong>", "<strong>_steve</strong>", "<strong>.info</strong>".</p></li>
</ul></li>
<li><p><strong>&lt;host&gt;</strong> is a sequence of at least two words, separated by dots '<strong>.</strong>'. Each word is sequence of letters and can have hyphens '<strong>-</strong>' between the letters.</p>
<ul>
<li><p>Examples of hosts: "<strong>softuni.bg</strong>", "<strong>software-university.com</strong>", "<strong>intoprogramming.info</strong>", "<strong>mail.softuni.org</strong>".</p></li>
<li><p>Examples of invalid hosts: "<strong>helloworld</strong>", "<strong>.unknown.soft.</strong>", "<strong>invalid-host-</strong>", "<strong>invalid-</strong>".</p></li>
</ul></li>
<li><p>Examples of <strong>valid emails</strong>: <strong>info@softuni-bulgaria.org</strong>, <strong>kiki@hotmail.co.uk</strong>, <strong>no-reply@github.com</strong>, <strong>s.peterson@mail.uu.net</strong>, <strong>info-bg@software-university.software.academy</strong>.</p></li>
<li><p>Examples of <strong>invalid emails</strong>: <strong>--123@gmail.com</strong>, <strong>…@mail.bg</strong>, <strong>.info@info.info</strong>, <strong>_steve@yahoo.cn</strong>, <strong>mike@helloworld</strong>, <strong>mike@.unknown.soft.</strong>, <strong>s.johnson@invalid-</strong>.</p></li>
</ul>
<h3 id="examples-5">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>Please contact us at: support@github.com.</td>
<td>support@github.com</td>
</tr>
<tr class="even">
<td>Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.</td>
<td><p>s.miller@mit.edu</p>
<p>j.hopking@york.ac.uk</p></td>
</tr>
<tr class="odd">
<td>Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. –- steve.parker@softuni.de.</td>
<td>steve.parker@softuni.de</td>
</tr>
</tbody>
</table>
<h2 class="list-paragraph" id="section"></h2>
