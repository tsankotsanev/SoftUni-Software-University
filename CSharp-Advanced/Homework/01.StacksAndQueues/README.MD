<h1 id="exercise-stacks-and-queues">Exercise: Stacks and Queues</h1>
<p>Problems for exercises and homework for the <u><a href="https://softuni.bg/courses/csharp-advanced">"CSharp Advanced" course @ Software University</a>.</u></p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/1447/Stacks-and-Queues-Exercise">https://judge.softuni.bg/Contests/1447/Stacks-and-Queues-Exercise</a></p>
<h2 id="basic-stack-operations">Basic Stack Operations</h2>
<p>Play around with a stack. You will be given an integer <strong>N</strong> representing the number of elements to push into the stack, an integer <strong>S</strong> representing the number of elements to pop from the stack and finally an integer <strong>X</strong>, an element that you should look for in the stack. If it’s found, print "<strong>true</strong>" on the console. If it isn’t, print the <strong>smallest</strong> element currently present in the stack. If there are <strong>no</strong> <strong>elements</strong> in the sequence, print <strong>0</strong> on the console.</p>
<h3 id="input">Input</h3>
<ul>
<li><p>On the first line you will be given <strong>N</strong>, <strong>S</strong> and <strong>X,</strong> separated by a single space</p></li>
<li><p>On the next line you will be given <strong>N</strong> number of integers</p></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>On a single line print either <strong>true</strong> if <strong>X</strong> is present in the stack, otherwise print the <strong>smallest</strong> element in the stack. If the stack is <strong>empty</strong>, print 0</p></li>
</ul>
<h3 id="examples">Examples</h3>
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
<td><p>5 2 13</p>
<p>1 13 45 32 4</p></td>
<td>true</td>
<td>We have to <strong>push 5</strong> elements. Then we <strong>pop 2</strong> of them. Finally, we have to check whether 13 is present in the stack. Since it is we print <strong>true</strong>.</td>
</tr>
<tr class="even">
<td><p>4 1 666</p>
<p>420 69 13 666</p></td>
<td>13</td>
<td></td>
</tr>
</tbody>
</table>
<h2 id="basic-queue-operations">Basic Queue Operations</h2>
<p>Play around with a queue. You will be given an integer <strong>N</strong> representing the number of elements to enqueue (<strong>add</strong>), an integer <strong>S</strong> representing the <strong>number of elements</strong> to <strong>dequeue</strong> (<strong>remove</strong>) from the queue and finally an integer <strong>X</strong>, an element that you should look for in the <strong>queue</strong>. If it is, print <strong>true</strong> on the console. If it’s not print the <strong>smallest</strong> <strong>element</strong> currently present in the queue. If there are <strong>no</strong> <strong>elements</strong> in the sequence, print <strong>0</strong> on the console.</p>
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
<td><p>5 2 32</p>
<p>1 13 45 32 4</p></td>
<td>true</td>
<td>We have to <strong>enqueue 5</strong> elements. Then we <strong>dequeue</strong> <strong>2</strong> of them. Finally, we have to check whether 32 is present in the queue. Since it is we print <strong>true</strong>.</td>
</tr>
<tr class="even">
<td><p>4 1 666</p>
<p>666 69 13 420</p></td>
<td>13</td>
<td></td>
</tr>
<tr class="odd">
<td><p>3 3 90</p>
<p>90 0 90</p></td>
<td>0</td>
<td></td>
</tr>
</tbody>
</table>
<h2 id="maximum-and-minimum-element">Maximum and Minimum Element</h2>
<p>You have an empty sequence, and you will be given <strong>N</strong> queries. Each query is one of these three types:</p>
<p>1 x – <strong>Push</strong> the element x into the stack.</p>
<p>2 – <strong>Delete</strong> the element present at the <strong>top</strong> of the <strong>stack</strong>.</p>
<p>3 – <strong>Print</strong> the <strong>maximum</strong> element in the stack.</p>
<p>4 – <strong>Print</strong> the <strong>minimum</strong> element in the stack.</p>
<p>After you go through all of the queries, print the stack in the following format:</p>
<p>"{n}, {n<sub>1</sub>}, {n<sub>2</sub>} …, {n<sub>n</sub>}"</p>
<h3 id="input-1">Input</h3>
<ul>
<li><p>The first line of input contains an integer, <strong>N</strong></p></li>
<li><p>The next <strong>N</strong> lines each contain an above-mentioned query. <em>(It is guaranteed that each query is valid.)</em></p></li>
</ul>
<h3 id="output-1">Output</h3>
<ul>
<li><p>For each type 3 or 4 query, print the <strong>maximum</strong>/minimum element in the stack on a new line</p></li>
</ul>
<h3 id="constraints">Constraints</h3>
<ul>
<li><p>1 ≤ N ≤ 105</p></li>
</ul>
<ul>
<li><p>1 ≤ x ≤ 109</p></li>
<li><p>1 ≤ type ≤ 4</p></li>
<li><p>If there are <strong>no elements</strong> in the stack, <strong>don’t print anything</strong> on commands 3 and 4</p></li>
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
<td><p>9</p>
<p>1 97</p>
<p>2</p>
<p>1 20</p>
<p>2</p>
<p>1 26</p>
<p>1 20</p>
<p>3</p>
<p>1 91</p>
<p>4</p></td>
<td><p>26</p>
<p>20</p>
<p>91, 20, 26</p></td>
</tr>
<tr class="even">
<td><p>10</p>
<p>2</p>
<p>1 47</p>
<p>1 66</p>
<p>1 32</p>
<p>4</p>
<p>3</p>
<p>1 25</p>
<p>1 16</p>
<p>1 8</p>
<p>4</p></td>
<td><p>32</p>
<p>66</p>
<p>8</p>
<p>8, 16, 25, 32, 66, 47</p></td>
</tr>
</tbody>
</table>
<h2 id="fast-food">Fast Food</h2>
<p>You have a fast food restaurant and most of the food that you're offering is previously prepared. You need to know if you will have enough food to serve lunch to all of your customers. Write a program that checks the orders’ quantity. You also want to know the client with the <strong>biggest</strong> order for the day, because you want to give him a discount the next time he comes.</p>
<p>First, you will be given the <strong>quantity</strong> <strong>of the food</strong> that you have for the day (an integer number). Next, you will be given <strong>a sequence of integers</strong>, each representing the <strong>quantity of an order</strong>. Keep the orders in a <strong>queue</strong>. Find the <strong>biggest</strong> <strong>order</strong> and <strong>print</strong> it. You will begin servicing your clients from the <strong>first</strong> <strong>one</strong> that came. Before each order, <strong>check</strong> if you have enough food left to complete it. If you have, <strong>remove the order</strong> from the queue and <strong>reduce</strong> the amount of food you have. If you succeeded in servicing all of your clients, print:</p>
<p>"Orders complete".</p>
<p>If not, print:</p>
<p>"Orders left: {order1} {order2} .... {orderN}".</p>
<h3 id="input-2">Input</h3>
<ul>
<li><p>On the first line you will be given the quantity of your food - <strong>an integer</strong> in the range [0, 1000]</p></li>
<li><p>On the second line you will receive a sequence of integers, representing each order, <strong>separated by a single space</strong></p></li>
</ul>
<h3 id="output-2">Output</h3>
<ul>
<li><p>Print the quantity of biggest order</p></li>
<li><p>Print "Orders complete" if the orders are complete</p></li>
<li><p>If there are orders left, print them in the format given above</p></li>
</ul>
<h3 id="constraints-1">Constraints</h3>
<ul>
<li><p>The input will always be valid</p></li>
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
<td><p>348</p>
<p>20 54 30 16 7 9</p></td>
<td><p>54</p>
<p>Orders complete</p></td>
</tr>
<tr class="even">
<td><p>499</p>
<p>57 45 62 70 33 90 88 76</p></td>
<td><p>90</p>
<p>Orders left: 76</p></td>
</tr>
</tbody>
</table>
<h2 id="fashion-boutique">Fashion Boutique</h2>
<p>You own a fashion boutique and you receive a delivery once a month in a huge box, which is full of clothes. You have to arrange them in your store, so you take the box and start <strong>from the last piece</strong> of clothing on the top of the pile <strong>to the first one</strong> at the bottom. Use a <strong>stack</strong> for the purpose. Each piece of clothing has its <strong>value</strong> (an integer). You have to <strong>sum</strong> their values, while you take them out of the box. You will be given an integer representing the <strong>capacity</strong> of a rack. While the sum of the clothes is <strong>less</strong> than the capacity, <strong>keep summing</strong> them. If the sum becomes <strong>equal</strong> to the capacity you have to <strong>take a new rack</strong> for the <strong>next clothes</strong>, if there are <strong>any left</strong> in the box. If it becomes <strong>greater</strong> than the capacity<strong>, don't add</strong> the piece of clothing to the current rack and take a new one. In the end, print <strong>how many racks</strong> you have used to hang all of the clothes.</p>
<h3 id="input-3">Input</h3>
<ul>
<li><p>On the first line you will be given <strong>a sequence of integers</strong>, representing the clothes in the box, separated <strong>by a single space</strong></p></li>
<li><p>On the second line, you will be given <strong>an integer</strong>, representing the capacity of a rack</p></li>
</ul>
<h3 id="output-3">Output</h3>
<ul>
<li><p>Print the <strong>number of racks</strong>, needed to hang all of the clothes from the box</p></li>
</ul>
<h3 id="constraints-2">Constraints</h3>
<ul>
<li><p>The values of the clothes will be integers in the range [0,20]</p></li>
<li><p>There will never be more than 50 clothes in a box</p></li>
<li><p>The capacity will be an integer in the range [0,20]</p></li>
<li><p><strong>None</strong> of the integers from the box will be <strong>greater</strong> than then the <strong>value</strong> of the <strong>capacity</strong></p></li>
</ul>
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
<td><p>5 4 8 6 3 8 7 7 9</p>
<p>16</p></td>
<td>5</td>
</tr>
<tr class="even">
<td><p>1 7 8 2 5 4 7 8 9 6 3 2 5 4 6</p>
<p>20</p></td>
<td>5</td>
</tr>
</tbody>
</table>
<h2 id="songs-queue">Songs Queue</h2>
<p>Write a program that keeps track of a songs queue. The <strong>first</strong> song that is put in the queue, should be the <strong>first</strong> that <strong>gets played</strong>. A song cannot be added if it is currently in the queue.</p>
<p>You will be given <strong>a sequence of songs</strong>, separated by a comma and a single space. After that you will be given <strong>commands</strong> <strong>until</strong> there are <strong>no songs enqueued</strong>. When there are <strong>no more songs</strong> in the queue <strong>print</strong> "<strong>No more songs!</strong>" and <strong>stop</strong> the <strong>program</strong>.</p>
<p>The possible commands are:</p>
<ul>
<li><p>"<strong>Play</strong>" - plays a song (removes it from the queue)</p></li>
<li><p>"<strong>Add {song}</strong>" - adds the song to the queue if it isn’t contained already, otherwise print "<strong>{song} is already contained!</strong>"</p></li>
<li><p>"<strong>Show</strong>" - prints all songs in the queue separated by a comma and a white space (start from the first song in the queue to the last)</p></li>
</ul>
<h3 id="input-4">Input</h3>
<ul>
<li><p>On the first line, you will be given a sequence of strings, separated by a comma and a white space</p></li>
<li><p>On the next lines you will be given commands until there are no songs in the queue</p></li>
</ul>
<h3 id="output-4">Output</h3>
<ul>
<li><p>While receiving the commands, print the proper messages described above</p></li>
<li><p>After the command "Show", print the songs from the <strong>first</strong> to the <strong>last</strong></p></li>
</ul>
<h3 id="constraints-3">Constraints</h3>
<ul>
<li><p>The input <strong>will always be valid</strong> and in the <strong>formats</strong> described above</p></li>
<li><p>There <strong>might</strong> be commands <strong>even after</strong> there are <strong>no songs in the queue</strong> (ignore them)</p></li>
<li><p>There will never be duplicate songs in the initial queue</p></li>
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
<td><p>All Over Again, Watch Me</p>
<p>Play</p>
<p>Add Watch Me</p>
<p>Add Love Me Harder</p>
<p>Add Promises</p>
<p>Show</p>
<p>Play</p>
<p>Play</p>
<p>Play</p>
<p>Play</p></td>
<td><p>Watch Me is already contained!</p>
<p>Watch Me, Love Me Harder, Promises</p>
<p>No more songs!</p></td>
</tr>
</tbody>
</table>
<h2 id="truck-tour">Truck Tour</h2>
<p>Suppose there is a circle. There are <strong>N</strong> petrol pumps on that circle. Petrol pumps are numbered 0 to (N−1) (both inclusive). You have <strong>two pieces of information</strong> corresponding to each of the petrol pump: (1) the <strong>amount of petrol</strong> that particular petrol pump will give, and (2) the <strong>distance from that petrol pump</strong> to the next petrol pump.</p>
<p>Initially, you have a tank of infinite capacity carrying no petrol. You can start the tour at <strong>any</strong> of the petrol pumps. Calculate the <strong>first point</strong> from where the truck will be able to complete the circle. Consider that the truck will stop at <strong>each of the petrol pumps</strong>. The truck will move one kilometer for each liter of the petrol.</p>
<h3 id="input-5">Input</h3>
<ul>
<li><p>The first line will contain the value of <strong>N</strong></p></li>
<li><p>The next <strong>N</strong> lines will contain a pair of integers each, i.e. the amount of petrol that petrol pump will give and the distance between that petrol pump and the next petrol pump</p></li>
</ul>
<h3 id="output-5">Output</h3>
<ul>
<li><p>An integer which will be the smallest index of the petrol pump from which we can start the tour</p></li>
</ul>
<h3 id="constraints-4">Constraints</h3>
<ul>
<li><p>1 ≤ N ≤ 1000001</p></li>
<li><p>1 ≤ Amount of petrol, Distance ≤ 1000000000</p></li>
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
<td><p>3</p>
<p>1 5</p>
<p>10 3</p>
<p>3 4</p></td>
<td>1</td>
</tr>
</tbody>
</table>
<h2 id="balanced-parentheses">Balanced Parentheses</h2>
<p>Given a sequence consisting of parentheses, determine whether the expression is <strong>balanced</strong>. A sequence of parentheses is balanced if every <strong>open</strong> <strong>parenthesis</strong> can be <strong>paired</strong> <strong>uniquely</strong> with a <strong>closed</strong> <strong>parenthesis</strong> that occurs <strong>after</strong> the former. Also, the <strong>interval</strong> <strong>between</strong> them <strong>must</strong> be <strong>balanced</strong>. You will be given <strong>three</strong> types of parentheses: (, {, and [.</p>
<p><strong>{[()]} - This is a balanced parenthesis.</strong></p>
<p><strong>{[(])} - This is not a balanced parenthesis.</strong></p>
<h3 id="input-6">Input</h3>
<ul>
<li><p>Each input consists of a single line, <strong>the sequence of parentheses</strong>.</p></li>
</ul>
<h3 id="output-6">Output </h3>
<ul>
<li><p>For each test case, print on a new line "YES" if the parentheses are balanced.<br />
Otherwise, print "NO". Do not print the quotes.</p></li>
</ul>
<h3 id="constraints-5">Constraints</h3>
<ul>
<li><p>1 ≤ len<sub>s</sub> ≤ 1000, where len<sub>s</sub> is the length of the sequence.</p></li>
<li><p>Each character of the sequence <strong>will be one of</strong> {, }, (, ), [, ].</p></li>
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
<td>{[()]}</td>
<td>YES</td>
</tr>
<tr class="even">
<td>{[(])}</td>
<td>NO</td>
</tr>
<tr class="odd">
<td>{{[[(())]]}}</td>
<td>YES</td>
</tr>
</tbody>
</table>
<h2 id="simple-text-editor">Simple Text Editor</h2>
<p>You are given an empty text. Your task is to implement 4 commands related to manipulating the text</p>
<ul>
<li><p>1 someString - <strong>appends</strong> someString to the end of the text</p></li>
<li><p>2 count - <strong>erases</strong> the last <em>count</em> elements from the text</p></li>
<li><p>3 index - <strong>returns</strong> the element at position <em>index</em> from the text</p></li>
<li><p>4 - <strong>undoes</strong> the last not undone command of type <em>1 / 2</em> and returns the text to the state before that operation</p></li>
</ul>
<h3 id="input-7">Input</h3>
<ul>
<li><p>The first line contains <em><strong>n</strong></em>, the number of operations.</p></li>
<li><p>Each of the following <em><strong>n</strong></em> lines contains the name of the operation followed by the command argument, if any, separated by space in the following format <em><strong>CommandName Argument</strong></em>.</p></li>
</ul>
<h3 id="output-7">Output</h3>
<ul>
<li><p>For each operation of type <em><strong>3</strong></em> print a single line with the returned character of that operation.</p></li>
</ul>
<h3 id="constraints-6">Constraints</h3>
<ul>
<li><p>1 ≤ N ≤ 105</p></li>
<li><p>The length of the text will not exceed 1000000</p></li>
<li><p>All input characters are English letters.</p></li>
<li><p>It is guaranteed that the sequence of input operation is possible to perform.</p></li>
</ul>
<h3 id="examples-8">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>8</p>
<p>1 abc</p>
<p>3 3</p>
<p>2 3</p>
<p>1 xy</p>
<p>3 2</p>
<p>4</p>
<p>4</p>
<p>3 1</p></td>
<td><p>c</p>
<p>y</p>
<p>a</p></td>
</tr>
</tbody>
</table>
<h3 id="explanation">Explanation</h3>
<ul>
<li><p>There are 8 operations. Initially, the text is empty.</p></li>
<li><p>In the first operation, we append <strong>abc</strong> to the text.</p></li>
<li><p>Then, we print its 3rd character, which is <strong>c</strong> at this point.</p></li>
<li><p>Next, we erase its last 3 characters, <strong>abc</strong>.</p></li>
<li><p>After that, we append <strong>xy</strong> to the text.</p></li>
<li><p>The text becomes <strong>xy</strong> after these previous two modifications.</p></li>
<li><p>Then, we are asked to return the 2nd character of the text, which is <strong>y</strong>.</p></li>
<li><p>After that, we have to undo the last update to the text, so it becomes empty.</p></li>
<li><p>The next operation asks us to undo the update before that, so the text becomes <strong>abc</strong> again.</p></li>
<li><p>Finally, we are asked to print its 1st character, which is <strong>a</strong> at this point.</p></li>
</ul>
<h1 id="crossroads">*Crossroads</h1>
<p>Our favorite super-spy action hero Sam is back from his mission in the previous exam, and he has finally found some time to go on a <strong>holiday</strong>. He is taking his wife somewhere nice and they’re going to have a really good time, but first, they have to get there. Even on his holiday trip, Sam is still going to run into some <strong>problems</strong> and the first one is, of course, getting to the airport. Right now, he is stuck in a traffic jam at a <strong>very</strong> <strong>active</strong> <strong>crossroads</strong> where a lot of <strong>accidents</strong> happen.</p>
<p>Your job is to keep track of traffic at the crossroads and report whether a <strong>crash happened</strong> or everyone <strong>passed</strong> the <strong>crossroads</strong> <strong>safely</strong> and our hero is one step closer to a much desired vacation.</p>
<p>The road Sam is on has a <strong>single</strong> <strong>lane</strong> where cars queue up until the <strong>light</strong> <strong>goes</strong> <strong>green</strong>. When it does, they start passing one by one during the <strong>green</strong> <strong>light</strong> and the <strong>free window</strong> before the <strong>intersecting</strong> <strong>road’s</strong> <strong>light</strong> goes <strong>green</strong>. During <strong>one</strong> <strong>second</strong> only <strong>one</strong> <strong>part</strong> of a <strong>car</strong> (a <strong>single</strong> <strong>character</strong>) passes the crossroads. If a car is still in the crossroads when the <strong>free</strong> <strong>window</strong> ends, it will get hit at the <strong>first character</strong> that is still in the crossroads.</p>
<h3 id="input-8">Input</h3>
<ul>
<li><p>On the <strong>first line</strong>, you will receive the duration of the <strong>green</strong> <strong>light</strong> in seconds – an <strong>integer</strong> <strong>in the range [1-100]</strong></p></li>
<li><p>On the <strong>second line</strong>, you will receive the duration of the <strong>free</strong> <strong>window</strong> in seconds – an <strong>integer</strong> <strong>in the range [0-100]</strong></p></li>
<li><p>On the <strong>following lines</strong>, until you receive the "<strong>END</strong>" command, you will receive one of two things:</p>
<ul>
<li><p>A <strong>car</strong> – a <strong>string</strong> containing any ASCII character, or</p></li>
<li><p>The command "<strong>green</strong>" which indicates the <strong>start</strong> of a <strong>green</strong> <strong>light</strong> <strong>cycle</strong></p></li>
</ul></li>
</ul>
<p>A <strong>green</strong> <strong>light</strong> <strong>cycle</strong> goes as follows:</p>
<ul>
<li><p>During the <strong>green</strong> <strong>light</strong> cars will enter and exit the crossroads one by one</p></li>
<li><p>During the <strong>free window</strong> cars will only exit the crossroads</p></li>
</ul>
<h3 id="output-8">Output</h3>
<ul>
<li><p>If a <strong>crash</strong> <strong>happens</strong>, <strong>end the program</strong> and print:<br />
<strong>"A crash happened!"</strong><br />
<strong>"{car} was hit at {characterHit}."</strong></p></li>
<li><p>If everything <strong>goes</strong> <strong>smoothly</strong> and you receive an "<strong>END</strong>" command, print:<br />
<strong>"Everyone is safe."<br />
"{totalCarsPassed} total cars passed the crossroads."</strong></p></li>
</ul>
<h3 id="constraints-7">Constraints</h3>
<ul>
<li><p>The input will be <strong>within the constaints</strong> specified above and will <strong>always be valid</strong>. There is <strong>no need</strong> to check it explicitly.</p></li>
</ul>
<h3 id="examples-9">Examples</h3>
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
<td><p>10</p>
<p>5</p>
<p>Mercedes</p>
<p>green</p>
<p>Mercedes</p>
<p>BMW</p>
<p>Skoda</p>
<p>green</p>
<p>END</p></td>
<td><p>Everyone is safe.</p>
<p>3 total cars passed the crossroads.</p></td>
<td><p>During the first green light (10 seconds), the Mercedes (8) passes safely.</p>
<p>During the second green light, the Mercedes (8) passes safely and there are 2 seconds left.</p>
<p>The BMW enters the crossroads and when the green light ends, it still has 1 part inside ('W'), but has 5 seconds to leave and passes successfully.</p>
<p>The Skoda never enters the crossroads, so 3 cars passed successfully.</p></td>
</tr>
<tr class="even">
<td><p>9</p>
<p>3</p>
<p>Mercedes</p>
<p>Hummer</p>
<p>green</p>
<p>Hummer</p>
<p>Mercedes</p>
<p>green</p>
<p>END</p></td>
<td><p>A crash happened!</p>
<p>Hummer was hit at e.</p></td>
<td>Mercedes (8) passes successfully and Hummer (6) enters the crossroads but only the 'H' passes during the green light. There are 3 seconds of free window, so "umm" passes and the Hummer gets hit at 'e' and the program ends with a crash.</td>
</tr>
</tbody>
</table>
<h2 id="key-revolver">*Key Revolver</h2>
<p>Our favorite super-spy action hero Sam is back from his mission in another exam, and this time he has an even more difficult task. He needs to <strong>unlock a</strong> <strong>safe</strong>. The problem is that the safe is <strong>locked</strong> by <strong>several locks in a row</strong>, which all have <strong>varying</strong> <strong>sizes</strong>.</p>
<p>Our hero posesses a special weapon though, called the <strong>Key Revolver</strong>, with special bullets. Each <strong>bullet</strong> can unlock a <strong>lock</strong> with a <strong>size</strong> <strong>equal to or larger</strong> <strong>than</strong> the <strong>size</strong> of the <strong>bullet</strong>. The bullet goes into the keyhole, then explodes, completely <strong>destroying</strong> it. Sam <strong>doesn’t know the size</strong> of the locks, so he needs to just shoot at all of them, until the safe runs out of locks.</p>
<p>What’s behind the safe, you ask? Well, intelligence! It is told that Sam’s sworn enemy – <strong>Nikoladze</strong>, keeps his <strong>top secret</strong> <strong>Georgian</strong> <strong>Chacha Brandy</strong> recipe inside. It’s valued differently across different times of the year, so Sam’s boss will tell him what it’s worth over the radio. One last thing, every bullet Sam fires will also cost him money, w<strong>hich will be deducted from his pay</strong> from the price of the intelligence.</p>
<p>Good luck, operative.</p>
<h3 id="input-9">Input</h3>
<ul>
<li><p>On the <strong>first line</strong> of input, you will receive the price of each <strong>bullet</strong> – an <strong>integer</strong> <strong>in the range [0-100]</strong></p></li>
<li><p>On the <strong>second line</strong>, you will receive the <strong>size of the gun barrel</strong> – an <strong>integer</strong> <strong>in the range [1-5000]</strong></p></li>
<li><p>On the <strong>third line</strong>, you will receive the <strong>bullets</strong> – a <strong>space-separated integer sequence</strong> with <strong>[1-100] integers</strong></p></li>
<li><p>On the <strong>fourth line</strong>, you will receive the <strong>locks</strong> – a <strong>space-separated integer sequence</strong> with <strong>[1-100] integers</strong></p></li>
<li><p>On the <strong>fifth</strong> <strong>line</strong>, you will receive the <strong>value of the intelligence</strong> – an <strong>integer</strong> <strong>in the range [1-100000]</strong></p></li>
</ul>
<p>After Sam receives all of his information and gear (<strong>input</strong>), he starts to <strong>shoot the locks</strong> <strong>front-to-back</strong>, while going through the bullets <strong>back-to-front</strong>.</p>
<p>If the <strong>bullet</strong> has a <strong>smaller or equal</strong> size to the <strong>current</strong> <strong>lock</strong>, print “<strong>Bang!</strong>”, then <strong>remove the lock</strong>. If not, print <strong>"Ping!"</strong>, leaving the lock <strong>intact</strong>. The bullet is removed in <strong>both cases</strong>.</p>
<p>If Sam runs out of bullets in his barrel, print <strong>"Reloading!"</strong> on the console, then continue shooting. If there aren’t any bullets left, <strong>don’t</strong> print it.</p>
<p>The program ends when Sam <strong>either</strong> <strong>runs out of bullets</strong>, or the safe <strong>runs out of</strong> <strong>locks</strong>.</p>
<h3 id="output-9">Output</h3>
<ul>
<li><p>If Sam <strong>runs out of bullets</strong> before the safe runs out of <strong>locks</strong>, print:<br />
<strong>"Couldn't get through. Locks left: {locksLeft}"</strong></p></li>
<li><p>If Sam manages to <strong>open the safe</strong>, print:<br />
<strong>"{bulletsLeft} bullets left. Earned ${moneyEarned}"</strong></p></li>
</ul>
<p>Make sure to account for the <strong>price of the bullets</strong> when calculating the <strong>money earned</strong>.</p>
<h3 id="constraints-8">Constraints</h3>
<ul>
<li><p>The input will be <strong>within the constaints</strong> specified above and will <strong>always be valid</strong>. There is <strong>no need</strong> to check it explicitly.</p></li>
<li><p>There will <strong>never</strong> be a case where Sam breaks the lock and ends up with а <strong>negative balance</strong>.</p></li>
</ul>
<h3 id="examples-10">Examples</h3>
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
<td><p>50</p>
<p>2</p>
<p>11 10 5 11 10 20</p>
<p>15 13 16</p>
<p>1500</p></td>
<td><p>Ping!</p>
<p>Bang!</p>
<p>Reloading!</p>
<p>Bang!</p>
<p>Bang!</p>
<p>Reloading!</p>
<p>2 bullets left. Earned $1300</p></td>
<td><p>20 shoots lock 15 (ping)</p>
<p>10 shoots lock 15 (bang)</p>
<p>11 shoots lock 13 (bang)</p>
<p>5 shoots lock 16 (bang)</p>
<p>Bullet cost: 4 * 50 = $200</p>
<p>Earned: 1500 – 200 = $1300</p></td>
</tr>
<tr class="even">
<td><p>20</p>
<p>6</p>
<p>14 13 12 11 10 5</p>
<p>13 3 11 10</p>
<p>800</p></td>
<td><p>Bang!</p>
<p>Ping!</p>
<p>Ping!</p>
<p>Ping!</p>
<p>Ping!</p>
<p>Ping!</p>
<p>Couldn't get through. Locks left: 3</p></td>
<td><p>5 shoots lock 13 (bang)</p>
<p>10 shoots lock 3 (ping)</p>
<p>11 shoots lock 3 (ping)</p>
<p>12 shoots lock 3 (ping)</p>
<p>13 shoots lock 3 (ping)</p>
<p>14 shoots lock 3 (ping)</p></td>
</tr>
<tr class="odd">
<td><p>33</p>
<p>1</p>
<p>12 11 10</p>
<p>10 20 30</p>
<p>100</p></td>
<td><p>Bang!</p>
<p>Reloading!</p>
<p>Bang!</p>
<p>Reloading!</p>
<p>Bang!</p>
<p>0 bullets left. Earned $1</p></td>
<td><p>10 shoots lock 10 (bang)</p>
<p>11 shoots lock 20 (bang)</p>
<p>12 shoots lock 30 (bang)</p>
<p>Bullet cost: 3 * 33 = $99</p>
<p>Earned: 100 – 99 = $1</p></td>
</tr>
</tbody>
</table>
<h2 id="cups-and-bottles">*Cups and Bottles</h2>
<p>You will be given a <strong>sequence of integers</strong> – each indicating a <strong>cup's capacity</strong>. After that you will be given <strong>another sequence of integers</strong> – a <strong>bottle</strong> <strong>with</strong> <strong>water</strong> in it. Your job is to try to <strong>fill up</strong> all of the cups.</p>
<p>Filling is done by picking <strong>exactly one</strong> bottle at a time. You must start picking from <strong>the last received bottle</strong> and start filling from <strong>the first entered cup</strong>. If the current bottle has <strong>N</strong> water, you <strong>give</strong> the <strong>first entered cup N</strong> water and <strong>reduce</strong> its integer value by <strong>N</strong>.</p>
<p>When a cup's <strong>integer value</strong> reaches <strong>0 or less</strong>, it <strong>gets removed</strong>. It is <strong>possible</strong> that the current cup's value is <strong>greater</strong> than the current bottle's value. <strong>In that case</strong> you <strong>pick bottles until</strong> you reduce the cup's integer value to <strong>0 or less</strong>. If a bottle's value is <strong>greater</strong> <strong>or equal to</strong> the cup's <strong>current</strong> value, you fill up the cup and <strong>the remaining water</strong> <strong>becomes wasted</strong>. You should <strong>keep track of the wasted litters of water</strong> and <strong>print it at the end of the program</strong>.</p>
<p>If you <strong>have managed</strong> to <strong>fill up all of the cups</strong>, print the <strong>remaining water bottles</strong>, from the <strong>last entered</strong> <strong>– to the first</strong>, otherwise you must print the <strong>remaining cups</strong>, by <strong>order of entrance</strong> – from the <strong>first entered – to the last</strong>.</p>
<h3 id="input-10">Input</h3>
<ul>
<li><p>On the <strong>first line</strong> of input you will receive the integers, representing the <strong>cups' capacity</strong>, <strong>separated</strong> by a <strong>single space</strong>.</p></li>
<li><p>On the <strong>second line</strong> of input you will receive the integers, representing the <strong>filled</strong> <strong>bottles</strong>, <strong>separated</strong> by a <strong>single space</strong>.</p></li>
</ul>
<h3 id="output-10">Output</h3>
<ul>
<li><p>On the first line of output you must print the remaining bottles, or the remaining cups, depending on the case you are in. Just <strong>keep</strong> the <strong>orders of printing exactly as specified</strong>.</p>
<ul>
<li><p><strong>"Bottles: {remainingBottles}"</strong> or <strong>"Cups: {remainingCups}"</strong></p></li>
</ul></li>
<li><p>On the second line print the wasted litters of water in the following format: <strong>"Wasted litters of water: {wastedLittersOfWater}".</strong></p></li>
</ul>
<h3 id="constraints-9">Constraints</h3>
<ul>
<li><p>All of the given numbers will be valid integers in the range [1, 500].</p></li>
<li><p>It is safe to assume that there will be <strong>NO</strong> case in which the water is <strong>exactly as much</strong> as the cups' values, so that at the end there are no cups and no water in the bottles.</p></li>
<li><p>Allowed time/memory: 100ms/16MB.</p></li>
</ul>
<h3 id="examples-11">Examples</h3>
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
<td><p>4 2 10 5</p>
<p>3 15 15 11 6</p></td>
<td><p>Bottles: 3</p>
<p>Wasted litters of water: 26</p></td>
<td><p>We take the first entered cup and the last entered bottle, as it is described in the condition.</p>
<p>6 – 4 = 2 – we have 2 more so the wasted water becomes 2.</p>
<p>11 – 2 = 9 – again, it is more, so we add it to the previous amount, which is 2 and it becomes 11.</p>
<p>15 – 10 = 5 – wasted water becomes 16.</p>
<p>15 – 5 = 10 – wasted water becomes 26.</p>
<p>We've managed to fill up all of the cups, so we print the remaining bottles and the total amount of wasted water.</p></td>
</tr>
<tr class="even">
<td><p>1 5 28 1 4</p>
<p>3 18 1 9 30 4 5</p></td>
<td><p>Cups: 4</p>
<p>Wasted litters of water: 35</p></td>
<td></td>
</tr>
<tr class="odd">
<td><p>10 20 30 40 50</p>
<p>20 11</p></td>
<td><p>Cups: 30 40 50</p>
<p>Wasted litters of water: 1</p></td>
<td></td>
</tr>
</tbody>
</table>
