<h1 id="exercise-associative-arrays">Exercise: Associative Arrays</h1>
<p>Problems for exercise and homework for the <a href="https://softuni.bg/trainings/3135/csharp-fundamentals-september-2020">"C# Fundamentals" course @ SoftUni</a><br />
You can check your solutions in <a href="https://judge.softuni.bg/Contests/1213">Judge</a></p>
<h2 id="count-chars-in-a-string">Count Chars in a String</h2>
<p>Write a program that <strong>counts all characters</strong> in a string <strong>except for space (' ')</strong>.</p>
<p><strong>Print all the occurrences in the following format:</strong></p>
<p><strong>{char} -&gt; {occurrences}</strong></p>
<h3 id="examples">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>text</td>
<td><p>t -&gt; 2</p>
<p>e -&gt; 1</p>
<p>x -&gt; 1</p></td>
</tr>
<tr class="even">
<td>text text text</td>
<td><p>t -&gt; 6</p>
<p>e -&gt; 3</p>
<p>x -&gt; 3</p></td>
</tr>
</tbody>
</table>
<h2 id="a-miner-task">A Miner Task</h2>
<p>You will be given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on) and every even - quantity. Your task is to collect the resources and print them each on a new line.</p>
<p><strong>Print the resources and their quantities in the following format:</strong></p>
<p><strong>{resource} –&gt; {quantity}</strong></p>
<p>The quantities will be <strong>in the range</strong> <strong>[1 … 2 000 000 000]</strong></p>
<h3 id="examples-1">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th></th>
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Gold</p>
<p>155</p>
<p>Silver</p>
<p>10</p>
<p>Copper</p>
<p>17</p>
<p>stop</p></td>
<td><p>Gold -&gt; 155</p>
<p>Silver -&gt; 10</p>
<p>Copper -&gt; 17</p></td>
<td></td>
<td><p>gold</p>
<p>155</p>
<p>silver</p>
<p>10</p>
<p>copper</p>
<p>17</p>
<p>gold</p>
<p>15</p>
<p>stop</p></td>
<td><p>gold -&gt; 170</p>
<p>silver -&gt; 10</p>
<p>copper -&gt; 17</p></td>
</tr>
</tbody>
</table>
<h2 id="legendary-farming">Legendary Farming</h2>
<p>You’ve done all the work and the last thing left to accomplish is to own a <strong>legendary item</strong>. However, it’s a tedious process and it requires quite a bit of farming. Anyway, you are not too pretentious - any legendary item will do. The possible <strong>items</strong> are:</p>
<ul>
<li><p><strong>Shadowmourne</strong> - requires <strong>250 Shards</strong>;</p></li>
<li><p><strong>Valanyr</strong> - requires <strong>250 Fragments</strong>;</p></li>
<li><p><strong>Dragonwrath</strong> - requires <strong>250 Motes</strong>;</p></li>
</ul>
<p><strong>Shards, Fragments</strong> and <strong>Motes</strong> are the <strong>key materials</strong> and everything else is <strong>junk.</strong> You will be given lines of input, in the format:</p>
<p><strong>2 motes 3 ores 15 stones</strong></p>
<p>Keep track of the <strong>key materials</strong> - the <strong>first</strong> one that reaches the <strong>250 mark,</strong> <strong>wins</strong> the <strong>race</strong>. At that point you have to print that the corresponding legendary item is obtained. Then, print the <strong>remaining</strong> shards, fragments, motes, ordered by <strong>quantity</strong> in <strong>descending</strong> order, then by <strong>name</strong> in <strong>ascending</strong> order, each on a new line. Finally, print the collected <strong>junk</strong> items in <strong>alphabetical</strong> order.</p>
<h3 id="input">Input</h3>
<ul>
<li><blockquote>
<p>Each line comes in the following format: <strong>{quantity} {material} {quantity} {material} … {quantity} {material}</strong></p>
</blockquote></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>On the first line, print the obtained item in the format: <strong>{Legendary item} obtained!</strong></p></li>
<li><p>On the next three lines, print the remaining key materials in <strong>descending order by quantity</strong></p>
<ul>
<li><p>If <strong>two</strong> key materials have the same quantity, print them in <strong>alphabetical</strong> <strong>order</strong></p></li>
</ul></li>
<li><p>On the final several lines, print the <strong>junk</strong> items <strong>in alphabetical order</strong></p>
<ul>
<li><p>All materials are printed in format <strong>{material}: {quantity}</strong></p></li>
<li><p>The output should be <strong>lowercase</strong>, except for the first letter of the legendary</p></li>
</ul></li>
</ul>
<h3 id="examples-2">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>3 Motes 5 stones 5 Shards</p>
<p>6 leathers 255 fragments 7 Shards</p></td>
<td><p>Valanyr obtained!</p>
<p>fragments: 5</p>
<p>shards: 5</p>
<p>motes: 3</p>
<p>leathers: 6</p>
<p>stones: 5</p></td>
</tr>
<tr class="even">
<td><p>123 silver 6 shards 8 shards 5 motes</p>
<p>9 fangs 75 motes 103 MOTES 8 Shards</p>
<p>86 Motes 7 stones 19 silver</p></td>
<td><p>Dragonwrath obtained!</p>
<p>shards: 22</p>
<p>motes: 19</p>
<p>fragments: 0</p>
<p>fangs: 9</p>
<p>silver: 123</p></td>
</tr>
</tbody>
</table>
<h2 id="orders">Orders</h2>
<p>Write a program that keeps information about <strong>products</strong> and their <strong>prices</strong>. Each product has a <strong>name</strong>, a <strong>price</strong> and a <strong>quantity</strong>. If the product <strong>doesn’t exist</strong> yet, <strong>add</strong> it with its <strong>starting quantity</strong>.</p>
<p>If you receive a product, which <strong>already exists,</strong> <strong>increase</strong> its quantity by the input quantity and if its <strong>price</strong> is different, <strong>replace</strong> the price as well.</p>
<p>You will receive products’ <strong>names</strong>, <strong>prices</strong> and <strong>quantities</strong> on <strong>new lines</strong>. Until you receive the command "<strong>buy</strong>", keep adding items. When you do receive the command "<strong>buy</strong>", print the items with their <strong>names</strong> and <strong>total price</strong> of all the products with that name.</p>
<p><strong>Input</strong></p>
<ul>
<li><p>Until you receive "<strong>buy</strong>", the products will be coming in the format: "<strong>{name} {price} {quantity}</strong>".</p></li>
<li><p>The product data is <strong>always</strong> delimited by a <strong>single space</strong>.</p></li>
</ul>
<p><strong>Output</strong></p>
<ul>
<li><p>Print information about <strong>each</strong> <strong>product</strong> in the following format:<br />
<strong>"{productName} -&gt; {totalPrice}"</strong></p></li>
<li><p><strong>Format</strong> the average grade to the <strong>2<sup>nd</sup> digit after the decimal separator</strong>.</p></li>
</ul>
<h3 id="examples-3">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Beer 2.20 100</p>
<p>IceTea 1.50 50</p>
<p>NukaCola 3.30 80</p>
<p>Water 1.00 500</p>
<p>buy</p></td>
<td><p>Beer -&gt; 220.00</p>
<p>IceTea -&gt; 75.00</p>
<p>NukaCola -&gt; 264.00</p>
<p>Water -&gt; 500.00</p></td>
</tr>
<tr class="even">
<td><p>Beer 2.40 350</p>
<p>Water 1.25 200</p>
<p>IceTea 5.20 100</p>
<p>Beer 1.20 200</p>
<p>IceTea 0.50 120</p>
<p>buy</p></td>
<td><p>Beer -&gt; 660.00</p>
<p>Water -&gt; 250.00</p>
<p>IceTea -&gt; 110.00</p></td>
</tr>
<tr class="odd">
<td><p>CesarSalad 10.20 25</p>
<p>SuperEnergy 0.80 400</p>
<p>Beer 1.35 350</p>
<p>IceCream 1.50 25</p>
<p>buy</p></td>
<td><p>CesarSalad -&gt; 255.00</p>
<p>SuperEnergy -&gt; 320.00</p>
<p>Beer -&gt; 472.50</p>
<p>IceCream -&gt; 37.50</p></td>
</tr>
</tbody>
</table>
<h2 id="softuni-parking">SoftUni Parking</h2>
<p>SoftUni just got a new <strong>parking lot</strong>. It’s so fancy, it even has online <strong>parking validation</strong>. Except the online service doesn’t work. It can only receive users’ data, but it doesn’t know what to do with it. Good thing you’re on the dev team and know how to fix it, right?</p>
<p>Write a program, which validates a parking place for an online service. Users can <strong>register</strong> to park and <strong>unregister</strong> to leave.</p>
<p>The program <strong>receives 2 commands</strong>:</p>
<ul>
<li><p>"<strong>register {username} {licensePlateNumber}</strong>":</p>
<ul>
<li><p>The system only supports <strong>one car per user</strong> at the moment, so if a user tries to register <strong>another license plate</strong>, using the <strong>same username</strong>, the system should print:<br />
"<strong>ERROR: already registered with plate number {licensePlateNumber}</strong>"</p></li>
<li><p>If the aforementioned checks passes successfully, the plate can be registered, so the system should print:<br />
<strong>"{</strong><strong>username} registered {licensePlateNumber} successfully"</strong></p></li>
</ul></li>
<li><p>"<strong>unregister {username}</strong>":</p>
<ul>
<li><p>If the user is <strong>not present</strong> in the database, the system should print:<br />
"<strong>ERROR: user {username} not found</strong>"</p></li>
<li><p>If the aforementioned check passes successfully, the system should print:<br />
"<strong>{username} unregistered successfully</strong>"</p></li>
</ul></li>
</ul>
<p>After you execute all of the commands, <strong>print</strong> all the currently <strong>registered users</strong> and their <strong>license plates</strong> in the format:</p>
<ul>
<li><p>"<strong>{username} =&gt; {licensePlateNumber}</strong>"</p></li>
</ul>
<h3 id="input-1">Input</h3>
<ul>
<li><p>First line: <strong>n</strong> - <strong>number of commands</strong> – <strong>integer</strong></p></li>
<li><p>Next <strong>n</strong> lines: <strong>commands</strong> in one of the <strong>two</strong> possible formats:</p>
<ul>
<li><p>Register: "<strong>register {username} {licensePlateNumber}</strong>"</p></li>
<li><p>Unregister: "<strong>unregister {username}</strong>"</p></li>
</ul></li>
</ul>
<p>The input will <strong>always</strong> be <strong>valid</strong> and you <strong>do not need</strong> to check it explicitly.</p>
<h3 id="examples-4">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>5</p>
<p>register John CS1234JS</p>
<p>register George JAVA123S</p>
<p>register Andy AB4142CD</p>
<p>register Jesica VR1223EE</p>
<p>unregister Andy</p></td>
<td><p>John registered CS1234JS successfully</p>
<p>George registered JAVA123S successfully</p>
<p>Andy registered AB4142CD successfully</p>
<p>Jesica registered VR1223EE successfully</p>
<p>Andy unregistered successfully</p>
<p>John =&gt; CS1234JS</p>
<p>George =&gt; JAVA123S</p>
<p>Jesica =&gt; VR1223EE</p></td>
</tr>
<tr class="even">
<td><p>4</p>
<p>register Jony AA4132BB</p>
<p>register Jony AA4132BB</p>
<p>register Linda AA9999BB</p>
<p>unregister Jony</p></td>
<td><p>Jony registered AA4132BB successfully</p>
<p>ERROR: already registered with plate number AA4132BB</p>
<p>Linda registered AA9999BB successfully</p>
<p>Jony unregistered successfully</p>
<p>Linda =&gt; AA9999BB</p></td>
</tr>
<tr class="odd">
<td><p>6</p>
<p>register Jacob MM1111XX</p>
<p>register Anthony AB1111XX</p>
<p>unregister Jacob</p>
<p>register Joshua DD1111XX</p>
<p>unregister Lily</p>
<p>register Samantha AA9999BB</p></td>
<td><p>Jacob registered MM1111XX successfully</p>
<p>Anthony registered AB1111XX successfully</p>
<p>Jacob unregistered successfully</p>
<p>Joshua registered DD1111XX successfully</p>
<p>ERROR: user Lily not found</p>
<p>Samantha registered AA9999BB successfully</p>
<p>Joshua =&gt; DD1111XX</p>
<p>Anthony =&gt; AB1111XX</p>
<p>Samantha =&gt; AA9999BB</p></td>
</tr>
</tbody>
</table>
<h2 id="courses">Courses</h2>
<p>Write a program that keeps information about <strong>courses</strong>. Each course has a name and registered students.</p>
<p>You will be receiving a <strong>course</strong> <strong>name</strong> and a <strong>student</strong> <strong>name,</strong> until you receive the command "<strong>end</strong>". <strong>Check if such course already exists, and if not, add the course.</strong> Register the user into the course. When you receive the command "<strong>end</strong>", print the courses with their <strong>names</strong> and <strong>total registered users</strong>, ordered by the count of registered users in descending order. For each contest print the registered users <strong>ordered by name</strong> <strong>in ascending order</strong>.</p>
<p><strong>Input</strong></p>
<ul>
<li><p>Until the "<strong>end</strong>" command is received, you will be receiving input in the format: "<strong>{courseName} : {studentName}</strong>".</p></li>
<li><p>The product data is <strong>always</strong> delimited by <strong>" : ".</strong></p></li>
</ul>
<p><strong>Output</strong></p>
<ul>
<li><p>Print the information about <strong>each</strong> <strong>course</strong> in the following the format:<br />
<strong>"{courseName}: {registeredStudents}"</strong></p></li>
<li><p>Print the information about each student, in the following the format:<br />
<strong>"-- {studentName}"</strong></p></li>
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
<td><p>Programming Fundamentals : John Smith</p>
<p>Programming Fundamentals : Linda Johnson</p>
<p>JS Core : Will Wilson</p>
<p>Java Advanced : Harrison White</p>
<p>end</p></td>
<td><p>Programming Fundamentals: 2</p>
<p>-- John Smith</p>
<p>-- Linda Johnson</p>
<p>JS Core: 1</p>
<p>-- Will Wilson</p>
<p>Java Advanced: 1</p>
<p>-- Harrison White</p></td>
</tr>
<tr class="even">
<td><p>Algorithms : Jay Moore</p>
<p>Programming Basics : Martin Taylor</p>
<p>Python Fundamentals : John Anderson</p>
<p>Python Fundamentals : Andrew Robinson</p>
<p>Algorithms : Bob Jackson</p>
<p>Python Fundamentals : Clark Lewis</p>
<p>end</p></td>
<td><p>Python Fundamentals: 3</p>
<p>-- Andrew Robinson</p>
<p>-- Clark Lewis</p>
<p>-- John Anderson</p>
<p>Algorithms: 2</p>
<p>-- Bob Jackson</p>
<p>-- Jay Moore</p>
<p>Programming Basics: 1</p>
<p>-- Martin Taylor</p></td>
</tr>
</tbody>
</table>
<h2 id="student-academy"> Student Academy</h2>
<p>Write a program that keeps information about <strong>students</strong> and <strong>their grades</strong>.</p>
<p>You will receive <strong>n pair of rows</strong>. First you will receive the <strong>student's name</strong>, after that you will receive his grade. <strong>Check if the student already exists and if not, add him</strong>. Keep track of all grades for each student.</p>
<p>When you finish reading the data, keep the students with <strong>average grade higher than or equal to 4.50</strong>. Order the filtered students by <strong>average grade in descending order</strong>.</p>
<p><strong>Print the students and their average grade in the following format:</strong></p>
<p><strong>{name} –&gt; {averageGrade}</strong></p>
<p><strong>Format</strong> the average grade to the <strong>2<sup>nd</sup> decimal place</strong>.</p>
<h3 id="examples-6">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th></th>
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>5</p>
<p>John</p>
<p>5.5</p>
<p>John</p>
<p>4.5</p>
<p>Alice</p>
<p>6</p>
<p>Alice</p>
<p>3</p>
<p>George</p>
<p>5</p></td>
<td><p>John -&gt; 5.00</p>
<p>George -&gt; 5.00</p>
<p>Alice -&gt; 4.50</p></td>
<td></td>
<td><p>5</p>
<p>Amanda</p>
<p>3.5</p>
<p>Amanda</p>
<p>4</p>
<p>Rob</p>
<p>5.5</p>
<p>Christian</p>
<p>5</p>
<p>Robert</p>
<p>6</p></td>
<td><p>Robert -&gt; 6.00</p>
<p>Rob -&gt; 5.50</p>
<p>Christian -&gt; 5.00</p></td>
</tr>
</tbody>
</table>
<h2 id="company-users">Company Users</h2>
<p>Write a program that keeps information about companies and their employees.</p>
<p>You will be receiving a <strong>company</strong> <strong>name</strong> and an <strong>employee's id,</strong> until you receive the command "<strong>End</strong>" command. Add each employee to the given company. Keep in mind that a company cannot have two employees with the same id.</p>
<p>When you finish reading the data, <strong>order the companies by the name in ascending order</strong>.</p>
<p>Print the company name and each employee's id in the following format:</p>
<p><strong>{companyName}</strong></p>
<p><strong>-- {id1}</strong></p>
<p><strong>-- {id2}</strong></p>
<p><strong>-- {idN}</strong></p>
<p><strong>Input / Constraints</strong></p>
<ul>
<li><p>Until you receive the "<strong>End</strong>" command, you will be receiving input in the format: "<strong>{companyName} -&gt; {employeeId}</strong>".</p></li>
<li><p>The input always will be valid.</p></li>
</ul>
<h3 id="examples-7">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>SoftUni -&gt; AA12345</p>
<p>SoftUni -&gt; BB12345</p>
<p>Microsoft -&gt; CC12345</p>
<p>HP -&gt; BB12345</p>
<p>End</p></td>
<td><p>HP</p>
<p>-- BB12345</p>
<p>Microsoft</p>
<p>-- CC12345</p>
<p>SoftUni</p>
<p>-- AA12345</p>
<p>-- BB12345</p></td>
</tr>
<tr class="even">
<td><p>SoftUni -&gt; AA12345</p>
<p>SoftUni -&gt; CC12344</p>
<p>Lenovo -&gt; XX23456</p>
<p>SoftUni -&gt; AA12345</p>
<p>Movement -&gt; DD11111</p>
<p>End</p></td>
<td><p>Lenovo</p>
<p>-- XX23456</p>
<p>Movement</p>
<p>-- DD11111</p>
<p>SoftUni</p>
<p>-- AA12345</p>
<p>-- CC12344</p></td>
</tr>
</tbody>
</table>
<h2 id="forcebook">*ForceBook</h2>
<p>The force users are struggling to remember which side are the different forceUsers from, because they switch them too often. So you are tasked to create a web application to manage their profiles. You should store an information for every <strong>unique forceUser</strong>, registered in the application.</p>
<p>You will receive <strong>several input lines</strong> in one of the following formats:</p>
<p>{forceSide} | {forceUser}</p>
<p>{forceUser} -&gt; {forceSide}</p>
<p>The <strong>forceUser and forceSide</strong> are strings, containing any character.</p>
<p>If you receive <strong>forceSide | forceUser</strong>, you should <strong>check if such forceUser already exists</strong>, and <strong>if not</strong>, <strong>add</strong> him/her to the corresponding side.</p>
<p>If you receive a <strong>forceUser -&gt; forceSide</strong>, you should check if there is such a <strong>forceUser</strong> already and if so, <strong>change his/her side</strong>. If there is no such <strong>forceUser</strong>, add him/her to the corresponding forceSide, treating the command <strong>as a new registered forceUser.</strong><br />
<strong>Then you should print on the console: "{forceUser} joins the {forceSide} side!"</strong></p>
<p>You should end your program when you receive the command <strong>"Lumpawaroo"</strong>. At that point you should print each force side, <strong>ordered descending by forceUsers count, than ordered by name</strong>. For each side print the <strong>forceUsers</strong>, <strong>ordered by name</strong>.</p>
<p>In case there are <strong>no forceUsers in a side</strong>, you <strong>shouldn`t print</strong> the side information.</p>
<h3 id="input-constraints">Input / Constraints</h3>
<ul>
<li><p>The input comes in the form of commands in one of the formats specified above.</p></li>
<li><p>The input ends, when you receive the command <strong>"Lumpawaroo"</strong>.</p></li>
</ul>
<h3 id="output-1">Output</h3>
<ul>
<li><p>As output for each forceSide, <strong>ordered descending by forceUsers count</strong>, <strong>then by name</strong>, you must print all the forceUsers, <strong>ordered by name alphabetically</strong>.</p></li>
<li><p>The output format is:</p></li>
</ul>
<blockquote>
<p>Side: {forceSide}, Members: {forceUsers.Count}</p>
</blockquote>
<p>! {forceUser}</p>
<p>! {forceUser}</p>
<p>! {forceUser}</p>
<ul>
<li><p>In case there are <strong>NO</strong> <strong>forceUsers</strong>, don`t print this side.</p></li>
</ul>
<h3 id="examples-8">Examples</h3>
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
<td><p>Light | Gosho</p>
<p>Dark | Pesho</p>
<p>Lumpawaroo</p></td>
<td><p>Side: Dark, Members: 1</p>
<p>! Pesho</p>
<p>Side: Light, Members: 1</p>
<p>! Gosho</p></td>
<td>We register Gosho in the Light side and Pesho in the Dark side. After receiving "Lumpawaroo" we print both sides, ordered by membersCount and then by name.</td>
</tr>
<tr class="even">
<td><p>Lighter | Royal</p>
<p>Darker | DCay</p>
<p>Ivan Ivanov -&gt; Lighter</p>
<p>DCay -&gt; Lighter</p>
<p>Lumpawaroo</p></td>
<td><p>Ivan Ivanov joins the Lighter side!</p>
<p>DCay joins the Lighter side!</p>
<p>Side: Lighter, Members: 3</p>
<p>! DCay</p>
<p>! Ivan Ivanov</p>
<p>! Royal</p></td>
<td><p>Although Ivan Ivanov doesn`t have profile, we <strong>register</strong> him and add him to the Lighter side.</p>
<p>We <strong>remove DCay</strong> from Darker side and add him to Lighter side.</p>
<p>We print only Lighter side because Darker side <strong>has no members.</strong></p></td>
</tr>
</tbody>
</table>
<h2 id="softuni-exam-results">*SoftUni Exam Results</h2>
<p>Judge statistics on the last Programing Fundamentals exam was not working correctly, so you have the task to take all the submissions and analyze them properly. You should collect all the submissions and print the final results and statistics about each language that the participants submitted their solutions in.</p>
<p>You will be receiving lines in the following format: <strong>"{username}-{language}-{points}" until you receive "exam finished"</strong>. You should store each username and his submissions and points.<br />
You can receive a <strong>command to ban</strong> a user for cheating in the following format: <strong>"{username}-banned".</strong> In that case, you should <strong>remove</strong> the user from the contest, but <strong>preserve his submissions in the total count of submissions for each language</strong>.</p>
<p>After receiving <strong>"exam finished"</strong> print each of the participants, ordered descending by their max points, then by username, in the following format:</p>
<p>Results:</p>
<p>{username} | {points}</p>
<p>…</p>
<p>After that print each language, used in the exam, ordered descending by total submission count and then by language name, in the following format:</p>
<p>Submissions:</p>
<p>{language} – {submissionsCount}</p>
<p>…</p>
<h3 id="input-constraints-1">Input / Constraints</h3>
<p>Until you receive "exam finished" you will be receiving participant submissions in the following format: <strong>"{username}-{language}-{points}"</strong>.</p>
<p>You can receive a ban command -&gt; <strong>"{username}-banned"</strong></p>
<p>The points of the participant will always be a <strong>valid integer in the range [0-100];</strong></p>
<h3 id="output-2">Output</h3>
<ul>
<li><p>Print the exam results for each participant, ordered descending by max points and then by username, in the following format:</p></li>
</ul>
<p>Results:</p>
<p>{username} | {points}</p>
<p>…</p>
<ul>
<li><p>After that print each language, ordered descending by total submissions and then by language name, in the following format:</p></li>
</ul>
<p>Submissions:</p>
<p>{language} – {submissionsCount}</p>
<p>…</p>
<ul>
<li><p>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong>.</p></li>
</ul>
<h3 id="examples-9">Examples</h3>
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
<td><p>Pesho-Java-84</p>
<p>Gosho-C#-84</p>
<p>Gosho-C#-70</p>
<p>Kiro-C#-94</p>
<p>exam finished</p></td>
<td><p>Results:</p>
<p>Kiro | 94</p>
<p>Gosho | 84</p>
<p>Pesho | 84</p>
<p>Submissions:</p>
<p>C# - 3</p>
<p>Java - 1</p></td>
<td><p>We order the participant descending by max points and then by name, printing only the username and the max points.</p>
<p>After that we print each language along with the count of submissions, ordered descending by submissions count, and then by language name.</p></td>
</tr>
<tr class="even">
<td><p>Pesho-Java-91</p>
<p>Gosho-C#-84</p>
<p>Kiro-Java-90</p>
<p>Kiro-C#-50</p>
<p>Kiro-banned</p>
<p>exam finished</p></td>
<td><p>Results:</p>
<p>Pesho | 91</p>
<p>Gosho | 84</p>
<p>Submissions:</p>
<p>C# - 2</p>
<p>Java - 2</p></td>
<td><p>Kiro is banned so he is removed from the contest, but he`s submissions are still preserved in the languages submissions count.</p>
<p>So althou there are only 2 participants in the results, there are 4 submissions in total.</p></td>
</tr>
</tbody>
</table>
