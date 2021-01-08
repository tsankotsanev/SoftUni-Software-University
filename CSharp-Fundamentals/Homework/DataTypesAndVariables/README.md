<h1 id="exercise-data-types-and-variables">Exercise: Data Types and Variables</h1>
<p>Problems for exercise and homework for the <u><a href="https://softuni.bg/trainings/3135/csharp-fundamentals-september-2020">"C# Fundamentals" course @ SoftUni</a><br />
You can check your solutions in <a href="https://judge.softuni.bg/Contests/1205/Data-Types-and-Variables-Exercise">Judge</a></p>
<h2 id="integer-operations">Integer Operations</h2>
<p>Read four integer numbers. Add first to the second, divide (integer) the sum by the third number and multiply the result by the fourth number. Print the result.</p>
<h3 id="constraints">Constraints </h3>
<ul>
<li><p>First number will be in the range [-2,147,483,648… 2,147,483,647]</p></li>
<li><p>Second number will be in the range [-2,147,483,648… 2,147,483,647]</p></li>
<li><p>Third number will be in the range [-2,147,483,648… 2,147,483,647]</p></li>
<li><p>Fourth number will be in the range [-2,147,483,648… 2,147,483,647]</p></li>
</ul>
<h3 id="examples">Examples</h3>
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
<td><p>10</p>
<p>20</p>
<p>3</p>
<p>3</p></td>
<td>30</td>
<td></td>
<td><p>15</p>
<p>14</p>
<p>2</p>
<p>3</p></td>
<td>42</td>
</tr>
</tbody>
</table>
<h2 id="sum-digits">Sum Digits</h2>
<p>You will be given a single <strong>integer</strong>. Your task is to find the sum of its digits.</p>
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
<td>245678</td>
<td>32</td>
</tr>
<tr class="even">
<td>97561</td>
<td>28</td>
</tr>
<tr class="odd">
<td>543</td>
<td>12</td>
</tr>
</tbody>
</table>
<h2 id="elevator">Elevator</h2>
<p>Calculate how many courses will be needed to <strong>elevate n persons</strong> by using an elevator of <strong>capacity of p persons</strong>. The input holds two lines: the <strong>number of people n</strong> and the <strong>capacity p</strong> of the elevator.</p>
<h3 id="examples-2">Examples</h3>
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
<td><p>17</p>
<p>3</p></td>
<td>6</td>
<td>5 courses * 3 people<br />
+ 1 course * 2 persons</td>
</tr>
<tr class="even">
<td><p>4</p>
<p>5</p></td>
<td>1</td>
<td><p>All the persons fit inside in the elevator.</p>
<p>Only one course is needed.</p></td>
</tr>
<tr class="odd">
<td><p>10</p>
<p>5</p></td>
<td>2</td>
<td>2 courses * 5 people</td>
</tr>
</tbody>
</table>
<h3 id="hints">Hints</h3>
<ul>
<li><p>You should <strong>divide n by p</strong>. This gives you the number of full courses (e.g. 17 / 3 = 5).</p></li>
<li><p>If <strong>n</strong> does not divide <strong>p</strong> without a remainder, you will need one additional partially full course (e.g. 17 % 3 = 2).</p></li>
<li><p>Another approach is to round up <strong>n</strong> <strong>/</strong> <strong>p</strong> to the nearest integer (ceiling), e.g. 17/3 = 5.67 rounds up to 6.</p></li>
<li><p>Sample code for the round-up calculation:</p></li>
</ul>
<p><img src="media/image1.png" style="width:4.66286in;height:0.3202in" /></p>
<h2 id="sum-of-chars">Sum of Chars</h2>
<p>Write a program, which sums the ASCII codes of <strong>n</strong> characters and prints the <strong>sum</strong> on the console.</p>
<h3 id="input">Input</h3>
<ul>
<li><p>On the <strong>first</strong> <strong>line</strong>, you will receive <strong>n</strong> – the number of <strong>lines</strong>, which will <strong>follow</strong></p></li>
<li><p>On the next <strong>n lines</strong> – you will receive letters from the <strong>Latin</strong> alphabet</p></li>
</ul>
<h3 id="output">Output</h3>
<p>Print the <strong>total</strong> <strong>sum</strong> in the following format:</p>
<p>The sum equals: {totalSum}</p>
<h3 id="constraints-1">Constraints</h3>
<ul>
<li><p><strong>n</strong> will be in the interval <strong>[1…20]</strong>.</p></li>
<li><p>The <strong>characters</strong> will always be either <strong>upper</strong> or <strong>lower</strong>-case letters from the <strong>English alphabet</strong></p></li>
<li><p>You will always receive <strong>one</strong> <strong>letter</strong> per <strong>line</strong></p></li>
</ul>
<h3 id="examples-3">Examples</h3>
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
<td><p><strong>5</strong></p>
<p>A</p>
<p>b</p>
<p>C</p>
<p>d</p>
<p>E</p></td>
<td>The sum equals: 399</td>
<td></td>
<td><p><strong>12</strong></p>
<p>S</p>
<p>o</p>
<p>f</p>
<p>t</p>
<p>U</p>
<p>n</p>
<p>i</p>
<p>R</p>
<p>u</p>
<p>l</p>
<p>z</p>
<p>z</p></td>
<td>The sum equals: 1263</td>
</tr>
</tbody>
</table>
<h2 id="print-part-of-the-ascii-table">Print Part of the ASCII Table</h2>
<p>Find online more information about <a href="http://www.ascii-code.com/">ASCII</a> (American Standard Code for Information Interchange) and write a program that <strong>prints part of the ASCII table</strong> of characters at the console. On the first line of input you will receive <strong>the char index you should start with</strong> and on the <strong>second line - the index of the last character</strong> you should print.</p>
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
<td><p>60</p>
<p>65</p></td>
<td>&lt; = &gt; ? @ A</td>
</tr>
<tr class="even">
<td><p>69</p>
<p>79</p></td>
<td>E F G H I J K L M N O</td>
</tr>
<tr class="odd">
<td><p>97</p>
<p>104</p></td>
<td>a b c d e f g h</td>
</tr>
<tr class="even">
<td><p>40</p>
<p>55</p></td>
<td>( ) * + , - . / 0 1 2 3 4 5 6 7</td>
</tr>
</tbody>
</table>
<h2 id="triples-of-latin-letters">Triples of Latin Letters</h2>
<p>Write a program to read an integer <strong>n</strong> and print all <strong>triples</strong> of the first <strong>n small Latin letters</strong>, ordered alphabetically:</p>
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
<td>3</td>
<td><p>aaa</p>
<p>aab</p>
<p>aac</p>
<p>aba</p>
<p>abb</p>
<p>abc</p>
<p>aca</p>
<p>acb</p>
<p>acc</p>
<p>baa</p>
<p>bab</p>
<p>bac</p>
<p>bba</p>
<p>bbb</p>
<p>bbc</p>
<p>bca</p>
<p>bcb</p>
<p>bcc</p>
<p>caa</p>
<p>cab</p>
<p>cac</p>
<p>cba</p>
<p>cbb</p>
<p>cbc</p>
<p>cca</p>
<p>ccb</p>
<p>ccc</p></td>
</tr>
</tbody>
</table>
<h3 id="hints-1">Hints</h3>
<p>Perform 3 nested loops from <strong>0</strong> to <strong>n-1</strong>.</p>
<p><img src="media/image2.png" style="width:3.36847in;height:1.44792in" /></p>
<p>For each iteration generate new letters</p>
<p><img src="media/image3.png" style="width:3.48206in;height:0.44715in" /></p>
<h2 id="water-overflow">Water Overflow</h2>
<p>You have a <strong>water</strong> <strong>tank</strong> with capacity of <strong>255 liters</strong>. On the next <strong>n</strong> lines, you will receive <strong>liters of water</strong>, which you have to <strong>pour</strong> in your <strong>tank</strong>. If the <strong>capacity</strong> is <strong>not enough</strong>, print “<strong>Insufficient capacity!</strong>” and <strong>continue reading</strong> the next line. On the last line, print the <strong>liters</strong> in the <strong>tank</strong>.</p>
<h3 id="input-1">Input</h3>
<p>The <strong>input</strong> will be on two lines:</p>
<ul>
<li><p>On the <strong>first</strong> <strong>line</strong>, you will receive <strong>n</strong> – the number of <strong>lines</strong>, which will <strong>follow</strong></p></li>
<li><p>On the next <strong>n lines</strong> – you receive <strong>quantities</strong> of water, which you have to <strong>pour</strong> in the <strong>tank</strong></p></li>
</ul>
<h3 id="output-1">Output</h3>
<p>Every time you do not have <strong>enough</strong> <strong>capacity</strong> in the tank to pour the given liters, <strong>print</strong>:</p>
<p>Insufficient capacity!</p>
<p>On the last line, <strong>print</strong> only the <strong>liters</strong> in the <strong>tank</strong>.</p>
<h3 id="constraints-2">Constraints</h3>
<ul>
<li><p><strong>n</strong> will be in the interval <strong>[1…20]</strong></p></li>
<li><p><strong>liters</strong> will be in the interval <strong>[1…1000]</strong></p></li>
</ul>
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
<td><p><strong>5</strong></p>
<p>20</p>
<p>100</p>
<p>100</p>
<p>100</p>
<p>20</p></td>
<td><p>Insufficient capacity!</p>
<p>240</p></td>
<td></td>
<td><p><strong>1</strong></p>
<p>1000</p></td>
<td><p>Insufficient capacity!</p>
<p>0</p></td>
</tr>
</tbody>
</table>
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
<td><p><strong>7</strong></p>
<p>10</p>
<p>20</p>
<p>30</p>
<p>10</p>
<p>5</p>
<p>10</p>
<p>20</p></td>
<td>105</td>
<td></td>
<td><p><strong>4</strong></p>
<p>250</p>
<p>10</p>
<p>20</p>
<p>40</p></td>
<td><p>Insufficient capacity!</p>
<p>Insufficient capacity!</p>
<p>Insufficient capacity!</p>
<p>250</p></td>
</tr>
</tbody>
</table>
<h2 id="beer-kegs">Beer Kegs</h2>
<p>Write a program, which calculates the volume of <strong>n</strong> beer kegs. You will receive in total <strong>3 * n</strong> lines. <strong>Each three lines</strong> will hold <strong>information</strong> for a <strong>single</strong> keg. First up is the <strong>model</strong> of the keg, after that is the <strong>radius</strong> of the keg, and lastly is the <strong>height</strong> of the keg.</p>
<p>Calculate the volume using the following formula: <strong>π * r^2 * h</strong>.</p>
<p>At the end, print the <strong>model</strong> of the <strong>biggest</strong> keg.</p>
<h3 id="input-2">Input</h3>
<p>You will receive <strong>3 * n</strong> lines. Each group of lines will be on a new line:</p>
<ul>
<li><p>First – <strong>model</strong> – <strong>string</strong>.</p></li>
<li><p>Second –<strong>radius</strong> – <strong>floating-point</strong> number</p></li>
<li><p>Third – <strong>height</strong> – <strong>integer</strong> number</p></li>
</ul>
<h3 id="output-2">Output</h3>
<p>Print the <strong>model</strong> of the <strong>biggest</strong> keg.</p>
<h3 id="constraints-3">Constraints</h3>
<ul>
<li><p><strong>n</strong> will be in the interval <strong>[1…10]</strong></p></li>
<li><p>The <strong>radius</strong> will be a <strong>floating-point number</strong> in the interval <strong>[1…3.402823E+38]</strong></p></li>
<li><p>The <strong>height</strong> will be an <strong>integer</strong> in the interval <strong>[1…2147483647]</strong></p></li>
</ul>
<h3 id="examples-7">Examples</h3>
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
<td><p><strong>3</strong></p>
<p>Keg 1</p>
<p>10</p>
<p>10</p>
<p>Keg 2</p>
<p>20</p>
<p>20</p>
<p>Keg 3</p>
<p>10</p>
<p>30</p></td>
<td>Keg 2</td>
<td></td>
<td><p><strong>2</strong></p>
<p>Smaller Keg</p>
<p>2.41</p>
<p>10</p>
<p>Bigger Keg</p>
<p>5.12</p>
<p>20</p></td>
<td>Bigger Keg</td>
</tr>
</tbody>
</table>
<h2 id="spice-must-flow">*Spice Must Flow </h2>
<p><em>Spice is Love, Spice is Life. And most importantly, Spice must flow. It must be extracted from the scorching sands of Arrakis, under constant threat of giant sand worms. To make the work as efficient as possible, the Duke has tasked you with the creation of a management software.</em></p>
<p>Write a program that calculates the <strong>total amount</strong> of spice that can be extracted from a source. The source has a <strong>starting yield</strong>, which indicates how much spice can be mined on the <strong>first day</strong>. After it has been mined for a day, the <strong>yield drops</strong> by 10, meaning on the second day it’ll produce 10 less spice than on the first, on the third day 10 less than on the second, and so on (see examples). A source is considered profitable only while its yield is <strong>at least</strong> 100 – when less than 100 spice is expected in a day, abandon the source.</p>
<p>The mining crew <strong>consumes</strong> 26 spice <strong>every day</strong> at the end of their shift and <strong>an additional</strong> 26 after the mine has been exhausted. Note that the workers cannot consume more spice than there is in storage.</p>
<p>When the operation is complete, print on the console on two separate lines how many days the mine has operated and the total amount of spice extracted.</p>
<h3 id="input-3">Input </h3>
<p>You will receive a <strong>number</strong>, representing the <strong>starting yield</strong> of the source.</p>
<h3 id="output-3">Output </h3>
<p>Print on the console on two separate lines how many <strong>days</strong> the mine has operated and the <strong>total amount</strong> of spice extracted.</p>
<h3 id="constraints-4"> Constraints </h3>
<ul>
<li><p>The starting yield will be a positive <strong>integer</strong> within range [0 … 2 147 483 647]</p></li>
</ul>
<h3 id="examples-8">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th><strong>Explanation</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>111</td>
<td><p>2</p>
<p>134</p></td>
<td><p><strong>Day 1</strong> we extract 111 spice and at the end of the shift, the workers consume 26, leaving 85. The yield drops by 10 to 101.</p>
<p><strong>Day 2</strong> we extract 101 spice, the workers consume 26, leaving 75. The total is 160 and the yield has dropped to 91.</p>
<p><strong>Since</strong> the expected yield is less than 100, we abandon the source. The workers take another 26, leaving 134. The mine has operated 2 days.</p></td>
</tr>
</tbody>
</table>
<h2 id="poke-mon">*Poke Mon</h2>
<p>A Poke Mon is a special type of pokemon which likes to Poke others. But at the end of the day, the Poke Mon wants to keeps statistics, about how many pokes it has managed to make.</p>
<p>The Poke Mon pokes his target, and then proceeds to poke another target. The <strong>distance</strong> between his <strong>targets</strong> <strong>reduces</strong> his <strong>poke power</strong>.</p>
<p>You will be <strong>given</strong> the <strong>poke power</strong> the Poke Mon has, <strong>N</strong> – an <strong>integer</strong>.</p>
<p>Then you will be <strong>given</strong> the <strong>distance</strong> between the <strong>poke targets</strong>, <strong>M</strong> – an <strong>integer</strong>.</p>
<p>Then you will be <strong>given</strong> the <strong>exhaustionFactor</strong> <strong>Y</strong> – an <strong>integer</strong>.</p>
<p><img src="media/image4.jpeg" style="width:1.17708in;height:2.35556in" />Your task is to start <strong>subtracting</strong> <strong>M</strong> from <strong>N</strong> until <strong>N</strong> becomes <strong>less than M</strong>, i.e. the Poke Mon does not have enough power to reach the next target.<br />
<strong>Every time</strong> you <strong>subtract M</strong> from <strong>N</strong> that means you’ve reached a <strong>target</strong> and poked it successfully. <strong>COUNT</strong> how <strong>many targets</strong> you’ve poked – <strong>you’ll need</strong> that <strong>count</strong>.</p>
<p>The Poke Mon becomes gradually more exhausted. <strong>IF</strong> <strong>N</strong> <strong>becomes equal</strong> to <strong>EXACTLY 50 %</strong> of its <strong>original value</strong>, you must <strong>divide</strong> <strong>N</strong> by <strong>Y</strong>, if it is <strong>POSSIBLE</strong>. <strong>This</strong> <strong>DIVISION</strong> is between <strong>integers</strong>.</p>
<p>If a division is <strong>not possible</strong>, you should <strong>NOT</strong> do it. Instead, you should continue <strong>subtracting</strong>.</p>
<p><strong>After dividing</strong>, you should <strong>continue</strong> subtracting from <strong>N</strong>, until it becomes <strong>less</strong> than <strong>M</strong>.</p>
<p>When <strong>N</strong> becomes <strong>less</strong> than <strong>M</strong>, you must take <strong>what has remained</strong> of <strong>N</strong> and the <strong>count</strong> of <strong>targets</strong> you’ve poked, and print them as output.</p>
<p><strong>NOTE</strong>: When you are <strong>calculating percentages</strong>, you should be <strong>PRECISE</strong> at <strong>maximum</strong>.</p>
<p><strong>Example</strong>: <strong>505</strong> is <strong>NOT EXACTLY 50 %</strong> from <strong>1000</strong>, its <strong>50.5 %</strong>.</p>
<h3 id="input-4">Input</h3>
<ul>
<li><p>The input consists of <strong>3 lines</strong>.</p></li>
<li><p>On the <strong>first line</strong> you will receive <strong>N</strong> – an <strong>integer</strong>.</p></li>
<li><p>On the <strong>second line</strong> you will receive <strong>M</strong> – an <strong>integer</strong>.</p></li>
<li><p>On the <strong>third line</strong> you will receive <strong>Y</strong> – an <strong>integer</strong>.</p></li>
</ul>
<h3 id="output-4">Output</h3>
<ul>
<li><p>The output consists of <strong>2 lines</strong>.</p></li>
<li><p>On the <strong>first line</strong> print <strong>what has remained</strong> of <strong>N</strong>, after <strong>subtracting</strong> from it.</p></li>
<li><p>On the <strong>second line</strong> print the <strong>count</strong> of <strong>targets</strong>, you’ve managed to poke.</p></li>
</ul>
<h3 id="constrains">Constrains</h3>
<ul>
<li><p>The integer <strong>N</strong> will be in the <strong>range</strong> <strong>[1, 2.000.000.000]</strong>.</p></li>
<li><p>The integer <strong>M</strong> will be in the <strong>range</strong> <strong>[1, 1.000.000]</strong>.</p></li>
<li><p>The integer <strong>Y</strong> will be in the <strong>range</strong> <strong>[0, 9]</strong>.</p></li>
<li><p>Allowed time / memory: <strong>16 MB / 100ms</strong>.</p></li>
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
<td><p>5</p>
<p>2</p>
<p>3</p></td>
<td><p>1</p>
<p>2</p></td>
<td><p>N = 5, M = 2, Y = 3.</p>
<p>We start <strong>subtracting</strong> <strong>M</strong> from <strong>N</strong>.</p>
<p><strong>N – M = 3</strong>. <strong>1</strong> target poked.</p>
<p><strong>N – M = 1</strong>. <strong>2</strong> targets poked.</p>
<p><strong>N &lt; M</strong>.<br />
We print <strong>what has remained</strong> of <strong>N</strong>, which is <strong>1</strong>.</p>
<p>We print the <strong>count of targets</strong>, which is <strong>2</strong>.</p></td>
</tr>
<tr class="even">
<td><p>10</p>
<p>5</p>
<p>2</p></td>
<td><p>2</p>
<p>1</p></td>
<td><p>N = 10, M = 5, Y = 2.</p>
<p>We start <strong>subtracting</strong> <strong>M</strong> from <strong>N</strong>.</p>
<p><strong>N</strong> <strong>–</strong> <strong>M</strong> = <strong>5</strong>. (N is still not less than M, they are equal).</p>
<p><strong>N</strong> became <strong>EXACTLY</strong> <strong>50 %</strong> of its <strong>original value</strong>.</p>
<p><strong>5</strong> is <strong>50 %</strong> from <strong>10</strong>. So we divide <strong>N</strong> by <strong>Y</strong>.</p>
<p><strong>N / Y</strong> = <strong>5 / 2</strong> = <strong>2</strong>. (<strong>INTEGER DIVISION</strong>).</p></td>
</tr>
</tbody>
</table>
<h2 id="snowballs">*Snowballs</h2>
<p>Tony and Andi love playing in the snow and having snowball fights, but they always argue which makes the best snowballs. They have decided to involve you in their fray, by making you write a program, which calculates snowball data, and outputs the best snowball value.</p>
<p>You will receive <strong>N</strong> – an <strong>integer</strong>, the <strong>number</strong> of <strong>snowballs</strong> being made by Tony and Andi.<br />
<strong>For each snowball</strong> you will receive <strong>3 input lines</strong>:</p>
<ul>
<li><p>On the <strong>first line</strong> you will get the <strong>snowballSnow</strong> – an <strong>integer</strong>.</p></li>
<li><p>On the <strong>second line</strong> you will get the <strong>snowballTime</strong> – an <strong>integer</strong>.</p></li>
<li><p>On the <strong>third line</strong> you will get the <strong>snowballQuality</strong> – an <strong>integer</strong>.</p></li>
</ul>
<p><strong>For each snowball</strong> you must <strong>calculate</strong> its <strong>snowballValue</strong> by the following formula:</p>
<p>(snowballSnow / snowballTime) ^ snowballQuality</p>
<p>At the end you must print the <strong>highest</strong> calculated <strong>snowballValue</strong>.</p>
<h3 id="input-5">Input</h3>
<ul>
<li><p>On the <strong>first input line</strong> you will receive <strong>N</strong> – the <strong>number</strong> of <strong>snowballs</strong>.</p></li>
<li><p>On the <strong>next N * 3 input lines</strong> you will be receiving <strong>data</strong> about <strong>snowballs</strong>.</p></li>
</ul>
<h3 id="output-5">Output</h3>
<ul>
<li><p>As output you must print the <strong>highest</strong> calculated <strong>snowballValue</strong>, by the formula, <strong>specified above</strong>.</p></li>
<li><p>The output format is:<br />
<strong>{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})</strong></p></li>
</ul>
<h3 id="constraints-5">Constraints</h3>
<ul>
<li><p>The <strong>number</strong> of <strong>snowballs</strong> (<strong>N</strong>) will be an <strong>integer</strong> in <strong>range [0, 100]</strong>.</p></li>
<li><p>The <strong>snowballSnow</strong> is an <strong>integer</strong> in <strong>range [0, 1000]</strong>.</p></li>
<li><p>The <strong>snowballTime</strong> is an <strong>integer</strong> in <strong>range [1, 500]</strong>.</p></li>
<li><p>The <strong>snowballQuality</strong> is an <strong>integer</strong> in <strong>range [0, 100]</strong>.</p></li>
</ul>
<ul>
<li><p>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong>.</p></li>
</ul>
<h3 id="examples-10">Examples</h3>
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
<p>10</p>
<p>2</p>
<p>3</p>
<p>5</p>
<p>5</p>
<p>5</p></td>
<td>10 : 2 = 125 (3)</td>
</tr>
<tr class="even">
<td><p>3</p>
<p>10</p>
<p>5</p>
<p>7</p>
<p>16</p>
<p>4</p>
<p>2</p>
<p>20</p>
<p>2</p>
<p>2</p></td>
<td>10 : 5 = 128 (7)</td>
</tr>
</tbody>
</table>
