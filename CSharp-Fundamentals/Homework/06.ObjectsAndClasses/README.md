<h1 id="exercise-objects-and-classes">Exercise: Objects and Classes</h1>
<p>Problems for exercise and homework for the <a href="https://softuni.bg/trainings/3135/csharp-fundamentals-september-2020">"C# Fundamentals" course @ SoftUni</a><br />
You can check your solutions in <a href="https://judge.softuni.bg/Contests/1215">Judge</a></p>
<h2 id="advertisement-message">Advertisement Message</h2>
<p>Write a program that <strong>generates random fake advertisement message</strong> to advertise a product. The messages must consist of 4 parts: <strong>phrase</strong> + <strong>event</strong> + <strong>author</strong> + <strong>city</strong>. Use the following predefined parts:</p>
<ul>
<li><p><strong>Phrases</strong> – {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."}</p></li>
<li><p><strong>Events</strong> – {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}</p></li>
<li><p><strong>Authors</strong> – {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}</p></li>
<li><p><strong>Cities</strong> – {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}</p></li>
</ul>
<p>The format of the output message is the following: <strong>{phrase} {event} {author} – {city}</strong>.</p>
<p>You will receive the <strong>number of messages</strong> to be generated. Print each random message at a separate line.</p>
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
<td>3</td>
<td><p>Such a great product. Now I feel good. Elena – Ruse</p>
<p>Excellent product. Makes miracles. I am happy of the results! Katya – Varna</p>
<p>Best product of its category. That makes miracles. Eva - Sofia</p></td>
</tr>
</tbody>
</table>
<h2 id="articles">Articles</h2>
<p>Create a <strong>class</strong> <strong>Article</strong> with the following properties:</p>
<ul>
<li><p><strong>Title</strong> – a string</p></li>
<li><p><strong>Content</strong> – a string</p></li>
<li><p><strong>Author</strong> – a string</p></li>
</ul>
<p>The class should have a constructor and the following methods:</p>
<ul>
<li><p><strong>Edit (new content</strong>) – change the old content with the new one</p></li>
<li><p><strong>ChangeAuthor (new author)</strong> – change the author</p></li>
<li><p><strong>Rename (new title)</strong> – change the title of the article</p></li>
<li><p>Override the <strong>ToString</strong> method – print the article in the following format:</p></li>
</ul>
<p><strong>"{title} - {content}: {autor}"</strong></p>
<p>Write a program that reads an article in the following format <strong>"{title}, {content}, {author}"</strong>. On the next line, you will receive a number <strong>n,</strong> representing the number of commands, which will follow after it. On the next <strong>n lines,</strong> you will be receiving the following commands: <strong>"Edit: {new content}"</strong>; <strong>"ChangeAuthor: {new author}"</strong>; <strong>"Rename: {new title}"</strong>. At the end, print the final state of the article.</p>
<h3 id="example">Example</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>some title, some content, some author</p>
<p>3</p>
<p>Edit: better content</p>
<p>ChangeAuthor: better author</p>
<p>Rename: better title</p></td>
<td>better title - better content: better author</td>
</tr>
</tbody>
</table>
<h2 id="articles-2.0">Articles 2.0</h2>
<p>Change the program in such a way, that you will be able to store a <strong>list of articles</strong>. You will not need to use the previous methods any more (<strong>except the ToString method</strong>). On the <strong>first line</strong>, you will receive the number of articles. On the <strong>next lines</strong>, you will receive the <strong>articles in the same format</strong> as in the previous problem: <strong>"{title}, {content}, {author}"</strong>. Finally, you will receive a string: <strong>"title", "content"</strong> or an <strong>"author"</strong>. You need to <strong>order the articles</strong> alphabetically, based on <strong>the</strong> <strong>given</strong> <strong>criteria</strong>.</p>
<h3 id="example-1">Example</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>2</p>
<p>Science, planets, Bill</p>
<p>Article, content, Johnny</p>
<p>title</p></td>
<td><p>Article - content: Johnny</p>
<p>Science - planets: Bill</p></td>
</tr>
<tr class="even">
<td><p>3</p>
<p>title1, C, author1</p>
<p>title2, B, author2</p>
<p>title3, A, author3</p>
<p>content</p></td>
<td><p>title3 - A: author3</p>
<p>title2 - B: author2</p>
<p>title1 - C: author1</p></td>
</tr>
</tbody>
</table>
<h2 id="students">Students</h2>
<p>Write a program that receives a <strong>count of students - n</strong> and <strong>orders them by grade</strong> in <strong>descending order</strong>. Each student should have a <strong>First name</strong> (string), a <strong>Last name</strong> (string) and a <strong>grade</strong> (a floating-point number).</p>
<h3 id="input">Input</h3>
<ul>
<li><p>On the first line, you are going to receive <strong>n - the count of students</strong></p></li>
<li><p>On the next <strong>n</strong> lines, you will be receiving the info about the students in the following format:</p></li>
</ul>
<p><strong>"{first name} {second name} {grade}"</strong></p>
<h3 id="output">Output</h3>
<ul>
<li><p>Print each student in the following format: <strong>"{first name} {second name}: {grade}"</strong></p></li>
</ul>
<h3 id="example-2">Example</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>4</p>
<p>Lakia Eason 3.90</p>
<p>Prince Messing 5.49</p>
<p>Akiko Segers 4.85</p>
<p>Rocco Erben 6.00</p></td>
<td><p>Rocco Erben: 6.00</p>
<p>Prince Messing: 5.49</p>
<p>Akiko Segers: 4.85</p>
<p>Lakia Eason: 3.90</p></td>
</tr>
</tbody>
</table>
<p><strong>Teamwork Projects</strong></p>
<p>It's time for the teamwork projects and you are responsible for gathering the teams. First you will receive an integer - the <strong>count</strong> of the <strong>teams</strong> you will have to <strong>register</strong>. You will be given a <strong>user</strong> and a <strong>team</strong>, separated with “<strong>-</strong>”. The user is the <strong>creator</strong> of <strong>the team</strong>. For every newly created team you should <strong>print</strong> a message:</p>
<p>"<strong>Team {teamName} has been created by {user}!</strong>".</p>
<p>Next, you will receive а user with a team, separated with <strong>"-&gt;"</strong>, which means that the user wants to <strong>join</strong> that <strong>team</strong>. Upon receiving the command: “<strong>end of assignment</strong>”, you should print <strong>every team</strong>, <strong>ordered</strong> by the <strong>count</strong> of its <strong>members</strong> (<strong>descending</strong>) and then by <strong>name</strong> (<strong>ascending</strong>). For each team, you have to print its members <strong>sorted</strong> by name (<strong>ascending</strong>). However, there are several <strong>rules</strong>:</p>
<ul>
<li><p>If а user tries to <strong>create</strong> a team more than once, a message should be displayed:</p>
<ul>
<li><p>"<strong>Team {teamName} was already created!</strong><em>"</em></p></li>
</ul></li>
<li><p>A creator of a team <strong>cannot</strong> <strong>create</strong> another team – the following message should be thrown:</p>
<ul>
<li><p>"<strong>{user} cannot create another team!</strong>"</p></li>
</ul></li>
<li><p>If а user tries to <strong>join</strong> a non-existent team, a message should be displayed:</p>
<ul>
<li><p>"<strong>Team {teamName} does not exist!</strong><em>"</em></p></li>
</ul></li>
<li><p>A member of a team <strong>cannot</strong> <strong>join</strong> another team – the following message should be thrown:</p>
<ul>
<li><p>"<strong>Member {user} cannot join team {team Name}!</strong>"</p></li>
</ul></li>
<li><p>In the end, teams with <strong>zero</strong> members (with <strong>only a creator</strong>) should <strong>disband</strong> and you have to print them <strong>ordered by name in ascending order</strong>.</p></li>
<li><p>Every <strong>valid</strong> team should be printed ordered by <strong>name</strong> (ascending) in the following format:</p></li>
</ul>
<table>
<tbody>
<tr class="odd">
<td><p>"{teamName}:</p>
<p>- {creator}</p>
<p>-- {member}…"</p></td>
</tr>
</tbody>
</table>
<h3 id="examples-1">Examples</h3>
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
<p>Didi-PowerPuffsCoders</p>
<p>Toni-Toni is the best</p>
<p>Petq-&gt;PowerPuffsCoders</p>
<p>Toni-&gt;Toni is the best</p>
<p>end of assignment</p></td>
<td><p>Team PowerPuffsCoders has been created by Didi!</p>
<p>Team Toni is the best has been created by Toni!</p>
<p>Member Toni cannot join team Toni is the best!</p>
<p>PowerPuffsCoders</p>
<p>- Didi</p>
<p>-- Petq</p>
<p>Teams to disband:</p>
<p>Toni is the best</p></td>
<td>Toni created a team, which he attempted to join later and this action resulted in throwing a certain message. Since nobody else tried to join his team, the team had to <strong>disband</strong>.</td>
</tr>
<tr class="even">
<td><p>3</p>
<p>Tatyana-CloneClub</p>
<p>Helena-CloneClub</p>
<p>Trifon-SoftUni</p>
<p>Pesho-&gt;softUni</p>
<p>Pesho-&gt;SoftUni</p>
<p>Tatyana-&gt;Leda</p>
<p>PeshO-&gt;SoftUni</p>
<p>Cossima-&gt;CloneClub</p>
<p>end of assignment</p></td>
<td><p>Team CloneClub has been created by Tatyana!</p>
<p>Team CloneClub was already created!</p>
<p>Team SoftUni has been created by Trifon!</p>
<p>Team softUni does not exist!</p>
<p>Team Leda does not exist!</p>
<p>SoftUni</p>
<p>- Trifon</p>
<p>-- Pesho</p>
<p>-- PeshO</p>
<p>CloneClub</p>
<p>- Tatyana</p>
<p>-- Cossima</p>
<p>Teams to disband:</p></td>
<td><p>Note that when a user joins a team, you should <strong>first</strong> check if the team exists and <strong>then</strong> check if the user is already in a team:</p>
<p>Tatyana has created CloneClub, then she tried to join a non-existent team and the concrete message was displayed.</p></td>
</tr>
</tbody>
</table>
<h2 id="vehicle-catalogue">Vehicle Catalogue</h2>
<p>You have to create a vehicle catalogue. You will store only two types of vehicles – a <strong>car</strong> and a <strong>truck</strong>. Until you receive the “<strong>End</strong>” command you will be receiving <strong>lines</strong> of <strong>input</strong> in the following format:</p>
<table>
<tbody>
<tr class="odd">
<td>{typeOfVehicle} {model} {color} {horsepower}</td>
</tr>
</tbody>
</table>
<p>After the “<strong>End</strong>” command, you will start receiving <strong>models</strong> of <strong>vehicles</strong>. Print the <strong>data</strong> for every received vehicle in the following format:</p>
<table>
<tbody>
<tr class="odd">
<td><p>Type: {typeOfVehicle}</p>
<p>Model: {modelOfVehicle}</p>
<p>Color: {colorOfVehicle}</p>
<p>Horsepower: {horsepowerOfVehicle}</p></td>
</tr>
</tbody>
</table>
<p>When you receive the command “<strong>Close the Catalogue</strong>”, print the <strong>average</strong> <strong>horsepower</strong> for the <strong>cars</strong> and for the <strong>trucks</strong> in the following format:</p>
<p>{typeOfVehicles} have average horsepower of {averageHorsepower}.</p>
<p>The <strong>average</strong> <strong>horsepower</strong> is calculated by <strong>dividing</strong> the <strong>sum</strong> of the <strong>horsepower</strong> of <strong>all</strong> vehicles from the certain type by the <strong>total</strong> <strong>count</strong> of <strong>vehicles</strong> from the <strong>same</strong> <strong>type</strong>. Round the answer to the <strong>2<sup>nd</sup> digit after the decimal separator</strong>.</p>
<h3 id="constraints">Constraints</h3>
<ul>
<li><p>The type of vehicle will always be either a <strong>car</strong> or a <strong>truck</strong>.</p></li>
<li><p>You will not receive the <strong>same</strong> <strong>model</strong> <strong>twice</strong>.</p></li>
<li><p>The received horsepower will be an integer in the range <strong>[1…1000]</strong></p></li>
<li><p>You will receive at most <strong>50</strong> vehicles.</p></li>
<li><p>The separator will always be a single <strong>whitespace</strong>.</p></li>
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
<td><p>truck Man red 200</p>
<p>truck Mercedes blue 300</p>
<p>car Ford green 120</p>
<p>car Ferrari red 550</p>
<p>car Lamborghini orange 570</p>
<p>End</p>
<p>Ferrari</p>
<p>Ford</p>
<p>Man</p>
<p>Close the Catalogue</p></td>
<td><p>Type: Car</p>
<p>Model: Ferrari</p>
<p>Color: red</p>
<p>Horsepower: 550</p>
<p>Type: Car</p>
<p>Model: Ford</p>
<p>Color: green</p>
<p>Horsepower: 120</p>
<p>Type: Truck</p>
<p>Model: Man</p>
<p>Color: red</p>
<p>Horsepower: 200</p>
<p>Cars have average horsepower of: 413.33.</p>
<p>Trucks have average horsepower of: 250.00.</p></td>
</tr>
</tbody>
</table>
<h2 id="order-by-age">Order by Age</h2>
<p>You will receive an <strong>unknown</strong> number of lines. Each line will be consisted of an array of <strong>3</strong> elements. <strong>The first</strong> element will be a string and it will represent the name of a person. <strong>The second</strong> element will be a <strong>string</strong> and it will represent the <strong>ID</strong> of the person. <strong>The last</strong> element will be an <strong>integer</strong> - the <strong>age</strong> of the person. When you receive the command "<strong>End</strong>", print <strong>all the</strong> <strong>people</strong>, <strong>ordered</strong> by <strong>age</strong>.</p>
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
<td><p>Georgi 123456 20</p>
<p>Pesho 78911 15</p>
<p>Stefan 524244 10</p>
<p>End</p></td>
<td><p>Stefan with ID: 524244 is 10 years old.</p>
<p>Pesho with ID: 78911 is 15 years old.</p>
<p>Georgi with ID: 123456 is 20 years old.</p></td>
</tr>
</tbody>
</table>
