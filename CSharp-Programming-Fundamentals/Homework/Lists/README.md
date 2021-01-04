<h1 id="exercise-lists"> Exercise: Lists</h1>
<p>Problems for exercise and homework for the <u><a href="https://softuni.bg/trainings/3135/csharp-fundamentals-september-2020">"C# Fundamentals" course @ SoftUni</a><br />
</u>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/1211"><u>Judge</u></a></p>
<h2 id="train">Train</h2>
<p>You will receive a <strong>list of wagons</strong> (integers) on the first line. Every integer represents <strong>the number of passengers that are currently in each of the wagons</strong>. On the next line, you will get <strong>the max capacity of each wagon</strong> (a single integer). Until you receive "<strong>end</strong>" you will be given two types of input:</p>
<ul>
<li><p><strong>Add</strong> {<strong>passengers</strong>} – add a wagon to the end with the given number of passengers.</p></li>
<li><p>{<strong>passengers</strong>} - find an existing wagon to <strong>fit every passenger</strong>, starting from the first wagon.</p></li>
</ul>
<p>At the end <strong>print the final state</strong> of the train (each of the wagons, separated by a space).</p>
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
<td><p>32 54 21 12 4 0 23</p>
<p>75</p>
<p>Add 10</p>
<p>Add 0</p>
<p>30</p>
<p>10</p>
<p>75</p>
<p>end</p></td>
<td>72 54 21 12 4 75 23 10 0</td>
</tr>
<tr class="even">
<td><p>0 0 0 10 2 4</p>
<p>10</p>
<p>Add 10</p>
<p>10</p>
<p>10</p>
<p>10</p>
<p>8</p>
<p>6</p>
<p>end</p></td>
<td>10 10 10 10 10 10 10</td>
</tr>
</tbody>
</table>
<h2 id="change-list">Change List</h2>
<p>Write a program, which reads a <strong>list</strong> of <strong>integers</strong> from the <strong>console</strong> and receives <strong>commands</strong>, which <strong>manipulate</strong> the list. Your program may receive the following commands:</p>
<ul>
<li><p><strong>Delete {element}</strong> – delete all elements in the array, which are equal to the given element.</p></li>
<li><p><strong>Insert {element} {position}</strong> – insert an element and the given position.</p></li>
</ul>
<p>You should stop the program when you receive the command <strong>"end"</strong>. Print the numbers in the array separated by a <strong>single</strong> white space.</p>
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
<td><p>1 2 3 4 5 5 5 6</p>
<p>Delete 5</p>
<p>Insert 10 1</p>
<p>Delete 5</p>
<p>end</p></td>
<td>1 10 2 3 4 6</td>
</tr>
<tr class="even">
<td><p>20 12 4 319 21 31234 2 41 23 4</p>
<p>Insert 50 2</p>
<p>Insert 50 5</p>
<p>Delete 4</p>
<p>end</p></td>
<td>20 12 50 319 50 21 31234 2 41 23</td>
</tr>
</tbody>
</table>
<h2 id="house-party">House Party</h2>
<p>Write a program that keeps track of guests, that are going to a house party. On the first line of input, you are going to receive the <strong>number of commands</strong> you are going to receive. On the next lines you are going to receive one of the following <strong>messages</strong>:</p>
<ul>
<li><p><strong>"{name} is going!"</strong></p></li>
<li><p><strong>"{name} is not going!"</strong></p></li>
</ul>
<p>If you receive the <strong>first</strong> message, you have to <strong>add</strong> the person if he/she <strong>is not</strong> in the list and if he/she is in the list print on the console: "<strong>{name} is already in the list!"</strong>. If you receive the second message, you have to <strong>remove</strong> the person if he/she <strong>is</strong> in the list and if not print: "<strong>{name} is not in the list!</strong>". At the end print all the guests.</p>
<h3 id="examples-1">Examples</h3>
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
<p>Allie is going!</p>
<p>George is going!</p>
<p>John is not going!</p>
<p>George is not going!</p></td>
<td><p>John is not in the list!</p>
<p>Allie</p></td>
</tr>
<tr class="even">
<td><p>5</p>
<p>Tom is going!</p>
<p>Annie is going!</p>
<p>Tom is going!</p>
<p>Garry is going!</p>
<p>Jerry is going!</p></td>
<td><p>Tom is already in the list!</p>
<p>Tom</p>
<p>Annie</p>
<p>Garry</p>
<p>Jerry</p></td>
</tr>
</tbody>
</table>
<h2 id="list-operations">List Operations</h2>
<p>You will be given a <strong>list</strong> of <strong>integer</strong> numbers on the first line of input. You will be receiving operations you have to apply on the list until you receive the <strong>"End"</strong> command. The possible <strong>commands</strong> are:</p>
<ul>
<li><p><strong>Add {number} – add number at the end.</strong></p></li>
<li><p><strong>Insert {number} {index} – insert number at given index.</strong></p></li>
<li><p><strong>Remove {index} – remove at index.</strong></p></li>
<li><p><strong>Shift left {count} – first number becomes last ‘count’ times.</strong></p></li>
<li><p><strong>Shift right {count} – last number becomes first ‘count’ times.</strong></p></li>
</ul>
<p><strong>Note: there is a possibility that the given index is outside of the bounds of the array. In that case print "Invalid index"</strong></p>
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
<td><p>1 23 29 18 43 21 20</p>
<p>Add 5</p>
<p>Remove 5</p>
<p>Shift left 3</p>
<p>Shift left 1</p>
<p>End</p></td>
<td>43 20 5 1 23 29 18</td>
</tr>
<tr class="even">
<td><p>5 12 42 95 32 1</p>
<p>Insert 3 0</p>
<p>Remove 10</p>
<p>Insert 8 6</p>
<p>Shift right 1</p>
<p>Shift left 2</p>
<p>End</p></td>
<td><p>Invalid index</p>
<p>5 12 42 95 32 8 1 3</p></td>
</tr>
</tbody>
</table>
<h2 id="bomb-numbers">Bomb Numbers</h2>
<p>Write a program that <strong>reads a sequence of numbers</strong> and a <strong>special bomb number</strong> with a certain <strong>power</strong>. Your task is to <strong>detonate every occurrence of the special bomb number</strong> and according to its power - <strong>his neighbors from left and right</strong>. Detonations are performed from <strong>left to right</strong> and all detonated numbers <strong>disappear</strong>. Finally print the <strong>sum of the remaining elements</strong> in the sequence.</p>
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
<td><p>1 2 2 4 2 2 2 9</p>
<p>4 2</p></td>
<td>12</td>
<td>Special number is <strong>4</strong> with power <strong>2</strong>. After detontaion we are left with the sequence [1, 2, 9] with sum 12.</td>
</tr>
<tr class="even">
<td><p>1 4 4 2 8 9 1</p>
<p>9 3</p></td>
<td>5</td>
<td>Special number is <strong>9</strong> with power <strong>3.</strong> After detontaion we are left with the sequence [1, 4] with sum 5. Since the 9 has only 1 neighbour from the right we remove just it (one number instead of 3).</td>
</tr>
<tr class="odd">
<td><p>1 7 7 1 2 3</p>
<p>7 1</p></td>
<td>6</td>
<td>Detonations are performed from left to right. We cannot detonate the second occurance of <strong>7,</strong> because its already destroyed by the first occurance. The numbers [1, 2, 3] survive. Their sum is 6.</td>
</tr>
<tr class="even">
<td><p>1 1 2 1 1 1 2 1 1 1</p>
<p>2 1</p></td>
<td>4</td>
<td>The red and yellow numbers disappear in two sequential detonations. The result is the sequence [1, 1, 1, 1]. Sum = 4.</td>
</tr>
</tbody>
</table>
<h2 id="cards-game">Cards Game</h2>
<p>You will be given two hands of cards, which will be integer numbers. Assume that you have two players. You have to find out the winning deck and respectively the winner.</p>
<p>You start from the beginning of both hands. Compare the cards from the first deck to the cards from the second deck. The player, who has the bigger card, takes both cards and puts them at the <strong>back</strong> of his hand - <strong>the second player’s card is last, and the first person’s card (the winning one) is before it (second to last)</strong> and the player with the smaller card must <strong>remove</strong> the <strong>card</strong> from his deck. If both players’ cards have the same values - no one wins, and the two cards must be <strong>removed</strong> <strong>from</strong> the <strong>decks</strong>. The game is over, when one of the decks is left without any cards. You have to print the winner on the console and the sum of the left cards: <strong>"{First/Second} player wins! Sum: {sum}".</strong></p>
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
<td><p>20 30 40 50</p>
<p>10 20 30 40</p></td>
<td>First player wins! Sum: 240</td>
</tr>
<tr class="even">
<td><p>10 20 30 40 50</p>
<p>50 40 30 30 10</p></td>
<td>Second player wins! Sum: 50</td>
</tr>
</tbody>
</table>
<h2 id="append-arrays">Append Arrays</h2>
<p>Write a program to <strong>append several arrays</strong> of numbers.</p>
<ul>
<li><p>Arrays are separated by '<strong>|</strong>'.</p></li>
<li><p>Values are separated by spaces (' ', one or several).</p></li>
<li><p>Order the arrays from the <strong>last</strong> to the <strong>first</strong>, and their values from <strong>left</strong> to <strong>right</strong>.</p></li>
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
<td>1 2 3 |4 5 6 | 7 8</td>
<td>7 8 4 5 6 1 2 3</td>
</tr>
<tr class="even">
<td>7 | 4 5|1 0| 2 5 |3</td>
<td>3 2 5 1 0 4 5 7</td>
</tr>
<tr class="odd">
<td>1| 4 5 6 7 | 8 9</td>
<td>8 9 4 5 6 7 1</td>
</tr>
</tbody>
</table>
<h2 id="anonymous-threat">*Anonymous Threat</h2>
<p><em>The Anonymous have created a cyber hypervirus, which steals data from the CIA. You, as the lead security developer in CIA, have been tasked to analyze the software of the virus and observe its actions on the data. The virus is known for his innovative and unbeleivably clever technique of merging and dividing data into partitions.</em></p>
<p>You will receive a <strong>single input line,</strong> containing <strong>strings,</strong> separated by <strong>spaces</strong>. The strings may contain <strong>any ASCII</strong> character except <strong>whitespace</strong>.Then you will begin receiving commands in one of the following formats:</p>
<ul>
<li><p>merge {startIndex} {endIndex}</p></li>
<li><p>divide {index} {partitions}</p></li>
</ul>
<p>Every time you receive the <strong>merge command</strong>, you must merge all elements from the <strong>startIndex</strong>, till the <strong>endIndex</strong>. In other words, you should concatenate them.<br />
<strong>Example</strong>: <strong>{abc, def, ghi} -&gt; merge 0 1 -&gt; {abcdef, ghi}</strong></p>
<p>If <strong>any</strong> of the <strong>given indexes</strong> is <strong>out of the array</strong>, you must take <strong><u>only</u></strong> the <strong>range</strong> that is <strong><u>inside</u></strong> the <strong>array</strong> and <strong>merge</strong> it.</p>
<p>Every time you receive the <strong>divide command</strong>, you must <strong><u>divide</u></strong> the <strong>element</strong> at the <strong>given index</strong>, into <strong>several small substrings</strong> with <strong>equal length</strong>. The <strong>count</strong> of the <strong>substrings</strong> should be <strong>equal</strong> to the <strong>given partitions</strong>.</p>
<p><strong>Example</strong>: <strong>{abcdef, ghi, jkl} -&gt; divide 0 <u>3</u> -&gt; {ab, cd, ef, ghi, jkl}</strong></p>
<p>If the string <strong>cannot</strong> be <strong>exactly</strong> <strong>divided</strong> into the <strong>given partitions</strong>, <strong>make all partitions</strong> <strong>except</strong> the <strong>last</strong> with <strong>equal lengths</strong>, and make the <strong>last one</strong> – <strong>the</strong> <strong>longest</strong>.</p>
<p><strong>Example</strong>: <strong>{abcd, efgh, ijkl} -&gt; divide 0 3 -&gt; {a, b, cd, efgh, ijkl}</strong></p>
<p>The <strong>input ends</strong> when you receive the command “<strong>3:1</strong>”. At that point you must print the <strong>resulting elements</strong>, <strong>joined</strong> by a <strong>space</strong>.</p>
<h3 id="input">Input</h3>
<ul>
<li><p>The <strong>first input line</strong> will contain the <strong>array</strong> of <strong>data</strong>.</p></li>
<li><p>On the <strong>next several input</strong> lines you will <strong>receive commands</strong> in the <strong>format specified above</strong>.</p></li>
<li><p>The <strong>input ends</strong> when you receive the command "<strong>3:1</strong>".</p></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>As output you must print a single line containing the elements of the array, <strong>joined</strong> by a <strong>space</strong>.</p></li>
</ul>
<h3 id="constrains">Constrains</h3>
<ul>
<li><p>The <strong>strings</strong> in the <strong>array</strong> may contain any <strong>ASCII character</strong> except <strong>whitespace</strong>.</p></li>
<li><p>The <strong>startIndex</strong> and the <strong>endIndex</strong> will be in <strong>range [-1000, 1000]</strong>.</p></li>
<li><p>The <strong>endIndex</strong> will <strong>always</strong> be <strong>greater</strong> than the <strong>startIndex</strong>.</p></li>
<li><p>The <strong>index</strong> in the <strong>divide command</strong> will <strong>always</strong> be <strong>inside</strong> the array.</p></li>
<li><p>The <strong>partitions</strong> will be in <strong>range [0, 100]</strong>.</p></li>
<li><p>Allowed working <strong>time/memory</strong>: <strong>100ms / 16MB</strong>.</p></li>
</ul>
<h3 id="examples-6">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Ivo Johny Tony Bony Mony</p>
<p>merge 0 3</p>
<p>merge 3 4</p>
<p>merge 0 3</p>
<p>3:1</p></td>
<td>IvoJohnyTonyBonyMony</td>
</tr>
<tr class="even">
<td><p>abcd efgh ijkl mnop qrst uvwx yz</p>
<p>merge 4 10</p>
<p>divide 4 5</p>
<p>3:1</p></td>
<td>abcd efgh ijkl mnop qr st uv wx yz</td>
</tr>
</tbody>
</table>
<h2 id="pokemon-dont-go">*Pokemon Don’t Go</h2>
<p><em>Ely likes to play Pokemon Go a lot. But Pokemon Go bankrupted … So the developers made Pokemon Don’t Go out of depression. And so Ely now plays Pokemon Don’t Go. In Pokemon Don’t Go, when you walk to a certain pokemon, those closer to you, naturally get further, and those further from you, get closer.</em></p>
<p>You will receive a <strong>sequence</strong> of <strong>integers</strong>, separated by <strong>spaces</strong> – the distances to the pokemons. Then you will begin <strong>receiving integers</strong>, which will <strong>correspond</strong> to <strong>indexes</strong> in <strong>that</strong> <strong>sequence</strong>.</p>
<p>When you <strong>receive</strong> an <strong>index</strong>, you must <strong>remove</strong> the <strong>element</strong> at <strong>that index</strong> from the <strong>sequence</strong> (as if you’ve captured the pokemon).</p>
<ul>
<li><p>You must <strong><u>increase</u></strong> the <strong>value</strong> of <strong>all elements</strong> in the sequence, which are <strong><u>less</u></strong> or <strong><u>equal</u></strong> to the <strong>removed element</strong>, with the <strong>value</strong> of the <strong>removed element</strong>.</p></li>
<li><p>You must <strong><u>decrease</u></strong> the <strong>value</strong> of <strong>all elements</strong> in the sequence, which are <strong><u>greater</u></strong> than the <strong>removed element</strong>, with the <strong>value</strong> of the <strong>removed element</strong>.</p></li>
</ul>
<p>If the <strong>given index</strong> is <strong>less</strong> than <strong>0</strong>, <strong>remove</strong> the <strong>first element</strong> of the <strong>sequence</strong>, and <strong>copy</strong> the <strong>last element</strong> to its place.</p>
<p>If the <strong>given index</strong> is <strong>greater</strong> than the <strong>last index</strong> of the <strong>sequence</strong>, <strong>remove</strong> the <strong>last element</strong> from the sequence, and <strong>copy</strong> the <strong>first element</strong> to its place.</p>
<p>The <strong>increasing</strong> and <strong>decreasing</strong> of elements should be done in these cases, <strong>also</strong>. The <strong>element</strong>, whose value you should use is the <strong>removed</strong> element.</p>
<p>The program <strong>ends</strong> when the <strong>sequence</strong> has <strong>no elements</strong> (there are no pokemons left for Ely to catch).</p>
<h3 id="input-1">Input</h3>
<ul>
<li><p>On the <strong>first line</strong> of input you will receive a <strong>sequence</strong> of <strong>integers</strong>, <strong>separated</strong> by <strong>spaces</strong>.</p></li>
<li><p>On the <strong>next several</strong> lines you will receive <strong>integers</strong> – the <strong>indexes</strong>.</p></li>
</ul>
<h3 id="output-1">Output</h3>
<ul>
<li><p>When the program ends, you must print the <strong>summed</strong> <strong>value</strong> of <strong>all removed elements</strong>.</p></li>
</ul>
<h3 id="constrains-1">Constrains</h3>
<ul>
<li><p>The input data will consist <strong>only</strong> of <strong>valid integers</strong> in the <strong>range [-2.147.483.648, 2.147.483.647]</strong>.</p></li>
</ul>
<h3 id="examples-7">Examples</h3>
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
<td><p>4 5 3</p>
<p>1</p>
<p>1</p>
<p>0</p></td>
<td>14</td>
<td><p>The <strong>array</strong> is <strong>{4, 5, 3}</strong>. The index is <strong>1</strong>.</p>
<p>We <strong>remove</strong> <strong>5</strong>, and we <strong>increase all</strong> <strong>the</strong> <strong>lower</strong> ones and <strong>decrease all higher</strong> ones.</p>
<p>In this case there are <strong>no higher</strong> than <strong>5</strong>.</p>
<p>The result is <strong>{9, 8}</strong>.</p>
<p>The <strong>index</strong> is <strong>1</strong>. So we remove <strong>8</strong>, and <strong>decrease all the higher</strong> ones.</p>
<p>The result is <strong>{1}</strong>.</p>
<p>The <strong>index</strong> is <strong>0</strong>. So we remove <strong>1</strong>.</p>
<p>There are <strong>no elements</strong> <strong>left</strong>, so we print the <strong>sum</strong> of <strong>all removed elements</strong>.</p>
<p><strong>5 + 8 + 1 = 14</strong>.</p></td>
</tr>
<tr class="even">
<td><p>5 10 6 3 5</p>
<p>2</p>
<p>4</p>
<p>1</p>
<p>1</p>
<p>3</p>
<p>0</p>
<p>0</p></td>
<td>51</td>
<td><p><strong>Step 1</strong>: <strong>{11, 4, 9, 11}</strong></p>
<p><strong>Step 2</strong>: <strong>{22, 15, 20, 22}</strong></p>
<p><strong>Step 3</strong>: <strong>{7, 5, 7}</strong></p>
<p><strong>Step 4</strong>: <strong>{2, 2}</strong></p>
<p><strong>Step 5</strong>: <strong>{4, 4}</strong></p>
<p><strong>Step 6</strong>: <strong>{8}</strong></p>
<p><strong>Step 7</strong>: <strong>{}</strong> <strong>(empty).</strong></p>
<p><strong>Result</strong> = <strong>6 + 11 + 15 + 5 + 2 + 4 + 8 = 51</strong>.</p></td>
</tr>
</tbody>
</table>
<h2 id="softuni-course-planning"> *SoftUni Course Planning</h2>
<p>You are tasked to help with the planning of the next Technology Fundamentals course by keeping track of the lessons, that are going to be included in the course, as well as all the exercises for the lessons.</p>
<p>On the first line you will <strong>receive the initial schedule of the lessons and the exercises</strong> that are going to be a part of the next course, separated by <strong>comma and space ", ".</strong> But before the course starts, some changes should be made. Until you receive <strong>"course start"</strong> you will be given <strong>some commands to modify the course schedule</strong>. The possible commands are:</p>
<p><strong>Add:{lessonTitle}</strong> – add the lesson to the end of the schedule, <strong>if it does not exist</strong>.</p>
<p><strong>Insert:{lessonTitle}:{index}</strong> – insert the lesson to the given index, <strong>if it does not exist.</strong></p>
<p><strong>Remove:{lessonTitle}</strong> – remove the lesson, <strong>if it exists.</strong></p>
<p><strong>Swap:{lessonTitle}:{lessonTitle}</strong> – change the place of the two lessons, <strong>if they exist.</strong></p>
<p><strong>Exercise:{lessonTitle}</strong> – add Exercise in the schedule right after the lesson index<strong><u>, if the lesson exists and there is no exercise already</u></strong>, in the following format <strong>"{lessonTitle}-Exercise"</strong>. <strong>If the lesson doesn`t exist</strong>, <strong>add the lesson</strong> in the end of the course schedule<strong>, followed by the Exercise</strong>.</p>
<p><strong>Each time you Swap or Remove a lesson, you should do the same with the Exercises, if there are any, which follow the lessons.</strong></p>
<h3 id="input-constraints">Input / Constraints</h3>
<ul>
<li><blockquote>
<p>first line – the initial schedule lessons – strings, separated by comma and space <strong>", "</strong></p>
</blockquote></li>
<li><blockquote>
<p>until <strong>"course start"</strong> you will receive commands in the format described above</p>
</blockquote></li>
</ul>
<h3 id="output-2">Output</h3>
<ul>
<li><p>Print the whole course schedule, each lesson on a new line with its number(index) in the schedule:<br />
<strong>"{lesson index}.{lessonTitle}"</strong></p></li>
<li><p>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong>.</p></li>
</ul>
<h3 id="examples-8">Examples</h3>
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
<td><p>Data Types, Objects, Lists</p>
<p>Add:Databases</p>
<p>Insert:Arrays:0</p>
<p>Remove:Lists</p>
<p>course start</p></td>
<td><p>1.Arrays</p>
<p>2.Data Types</p>
<p>3.Objects</p>
<p>4.Databases</p></td>
<td><p>We receive the initial schedule.</p>
<p>Next, we add Databases lesson, because it doesn`t exist.</p>
<p>We Insert at the given index lesson Arrays, because its not present in the schedule.</p>
<p>After receiving the last command and removing lesson Lists, we print the whole schedule.</p></td>
</tr>
<tr class="even">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
<td><strong>Comment</strong></td>
</tr>
<tr class="odd">
<td><p>Arrays, Lists, Methods</p>
<p>Swap:Arrays:Methods</p>
<p>Exercise:Databases</p>
<p>Swap:Lists:Databases</p>
<p>Insert:Arrays:0</p>
<p>course start</p></td>
<td><p>1.Methods</p>
<p>2.Databases</p>
<p>3.Databases-Exercise</p>
<p>4.Arrays</p>
<p>5.Lists</p></td>
<td><p>We swap the given lessons, because both exist.</p>
<p>After receiving the Exercise command, we see that such lesson doesn`t exist, so we add the lesson at the end, followed by the exercise.</p>
<p>We swap Lists and Databases lessons, the</p>
<p>Databases-Exercise is also moved after the Databases lesson.</p>
<p>We skip the next command, because we already have such lesson in our schedule.</p></td>
</tr>
</tbody>
</table>
