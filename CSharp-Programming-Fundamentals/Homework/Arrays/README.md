<h1 id="exercise-arrays">Exercise: Arrays</h1>
<p>Problems for exercise and homework for the <u><a href="https://softuni.bg/trainings/3135/csharp-fundamentals-september-2020">"C# Fundamentals" course @ SoftUni</a><br />
</u>You can check your solutions in <a href="https://judge.softuni.bg/Contests/1206"><u>Judge</u></a></p>
<h2 id="train">Train</h2>
<p>You will be given a count of wagons in a <strong>train</strong> <strong>n</strong>. On the next <strong>n</strong> lines you will receive how many people are going to get on each wagon. At the end print the whole train and after that, on the next line, the sum of the people in the train.</p>
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
<td><p>3</p>
<p>13</p>
<p>24</p>
<p>8</p></td>
<td><p>13 24 8</p>
<p>45</p></td>
</tr>
<tr class="even">
<td><p>6</p>
<p>3</p>
<p>52</p>
<p>71</p>
<p>13</p>
<p>65</p>
<p>4</p></td>
<td><p>3 52 71 13 65 4</p>
<p>208</p></td>
</tr>
<tr class="odd">
<td><p>1</p>
<p>100</p></td>
<td><p>100</p>
<p>100</p></td>
</tr>
</tbody>
</table>
<h2 id="common-elements">Common Elements</h2>
<p>Write a program, which prints common elements in two arrays. You have to compare the elements of the second array to the elements of the first.</p>
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
<td><p>Hey hello 2 4</p>
<p>10 hey 4 hello</p></td>
<td>4 hello</td>
</tr>
<tr class="even">
<td><p>S of t un i</p>
<p>of i 10 un</p></td>
<td>of i un</td>
</tr>
<tr class="odd">
<td><p>i love to code</p>
<p>code i love to</p></td>
<td>code i love to</td>
</tr>
</tbody>
</table>
<h2 id="zig-zag-arrays">Zig-Zag Arrays</h2>
<p>Write a program which creates 2 arrays. You will be given an integer <strong>n</strong>. On the next <strong>n</strong> lines you get 2 integers. Form 2 arrays as shown below.</p>
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
<td><p>4</p>
<p>1 5</p>
<p>9 10</p>
<p>31 81</p>
<p>41 20</p></td>
<td><p>1 10 31 20</p>
<p>5 9 81 41</p></td>
</tr>
<tr class="even">
<td><p>2</p>
<p>80 23</p>
<p>31 19</p></td>
<td><p>80 19</p>
<p>23 31</p></td>
</tr>
</tbody>
</table>
<h2 id="array-rotation">Array Rotation</h2>
<p>Write a program that receives an array and number of rotations you have to perform (first element goes at the end) Print the resulting array.</p>
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
<td><p>51 47 32 61 21</p>
<p>2</p></td>
<td>32 61 21 51 47</td>
</tr>
<tr class="even">
<td><p>32 21 61 1</p>
<p>4</p></td>
<td>32 21 61 1</td>
</tr>
<tr class="odd">
<td><p>2 4 15 31</p>
<p>5</p></td>
<td>4 15 31 2</td>
</tr>
</tbody>
</table>
<h2 id="top-integers">Top Integers</h2>
<p>Write a program to find all the top integers in an array. A top integer is an integer which is <strong>bigger</strong> than all the elements to its right.</p>
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
<td>1 4 3 2</td>
<td>4 3 2</td>
</tr>
<tr class="even">
<td>14 24 3 19 15 17</td>
<td>24 19 17</td>
</tr>
<tr class="odd">
<td>27 19 42 2 13 45 48</td>
<td>48</td>
</tr>
</tbody>
</table>
<h2 id="equal-sums">Equal Sums</h2>
<p>Write a program that determines if there <strong>exists an element in the array</strong> such that the <strong>sum of the elements on its left</strong> is <strong>equal</strong> to the <strong>sum of the elements on its right (there will never be more than 1 element like that)</strong>. If there are <strong>no elements to the left / right</strong>, their <strong>sum is considered to be 0</strong>. Print the <strong>index</strong> that satisfies the required condition or <strong>"no"</strong> if there is no such index.</p>
<h3 id="examples-5">Examples</h3>
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
<td>1 2 3 3</td>
<td>2</td>
<td><p>At a[2] -&gt; left sum = 3, right sum = 3</p>
<p>a[0] + a[1] = a[3]</p></td>
</tr>
<tr class="even">
<td>1 2</td>
<td>no</td>
<td><p>At a[0] -&gt; left sum = 0, right sum = 2</p>
<p>At a[1] -&gt; left sum = 1, right sum = 0</p>
<p>No such index exists</p></td>
</tr>
<tr class="odd">
<td>1</td>
<td>0</td>
<td>At a[0] -&gt; left sum = 0, right sum = 0</td>
</tr>
<tr class="even">
<td>1 2 3</td>
<td>no</td>
<td>No such index exists</td>
</tr>
<tr class="odd">
<td>10 5 5 99 3 4 2 5 1 1 4</td>
<td>3</td>
<td><p>At a[3] -&gt; left sum = 20, right sum = 20</p>
<p>a[0] + a[1] + a[2] = a[4] + a[5] + a[6] + a[7] + a[8] + a[9] + a[10]</p></td>
</tr>
</tbody>
</table>
<h2 id="max-sequence-of-equal-elements">Max Sequence of Equal Elements</h2>
<p>Write a program that finds the <strong>longest sequence of equal elements</strong> in an array of integers. If several longest sequences exist, print the leftmost one.</p>
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
<td>2 1 1 2 3 3 <strong>2 2 2</strong> 1</td>
<td>2 2 2</td>
</tr>
<tr class="even">
<td><strong>1 1 1</strong> 2 3 1 3 3</td>
<td>1 1 1</td>
</tr>
<tr class="odd">
<td><strong>4 4 4 4</strong></td>
<td>4 4 4 4</td>
</tr>
<tr class="even">
<td>0 <strong>1 1</strong> 5 2 2 6 3 3</td>
<td>1 1</td>
</tr>
</tbody>
</table>
<h2 id="magic-sum">Magic Sum</h2>
<p>Write a program, which prints all unique pairs in an array of integers whose sum is equal to a given number.</p>
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
<td><p>1 7 6 2 19 23</p>
<p>8</p></td>
<td><p>1 7</p>
<p>6 2</p></td>
</tr>
<tr class="even">
<td><p>14 20 60 13 7 19 8</p>
<p>27</p></td>
<td><p>14 13</p>
<p>20 7</p>
<p>19 8</p></td>
</tr>
</tbody>
</table>
<h2 id="kamino-factory">*Kamino Factory</h2>
<p>The clone factory in Kamino got another order to clone troops. But this time you are tasked to find <strong>the best DNA</strong> sequence to use in the production.</p>
<p>You will receive the <strong>DNA length</strong> and until you receive the command <strong>"Clone them!"</strong> you will be receiving a <strong>DNA sequences of ones and zeroes, split by "!"</strong> <strong>(one or several).</strong></p>
<p>You should select the sequence with the <strong>longest subsequence of ones</strong>. If there are several sequences with <strong>same length of</strong> <strong>subsequence of ones</strong>, print the one with the <strong>leftmost</strong> <strong>starting index</strong>, if there are several sequences with same <strong>length and starting index</strong>, select the sequence with the <strong>greater sum</strong> of its elements.</p>
<p>After you receive the last command <strong>"Clone them!"</strong> you should print the collected information in the following format:</p>
<p>"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."</p>
<p>"{DNA sequence, joined by space}"</p>
<h3 id="input-constraints">Input / Constraints</h3>
<ul>
<li><p>The <strong>first line</strong> holds the <strong>length</strong> of the <strong>sequences</strong> – <strong>integer in range [1…100];</strong></p></li>
<li><p>On the next lines until you receive <strong>"Clone them!"</strong> you will be receiving sequences (at least one) of ones and zeroes, <strong>split by "!"</strong> (one or several).</p></li>
</ul>
<h3 id="output"> Output</h3>
<p>The output should be printed on the console and consists of two lines in the following format:</p>
<p>"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."</p>
<p>"{DNA sequence, joined by space}"</p>
<h3 id="examples-8"> Examples</h3>
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
<p>1!0!<strong>1!1</strong>!0</p>
<p>0!<strong>1!1</strong>!0!0</p>
<p>Clone them!</p></td>
<td><p>Best DNA sample 2 with sum: 2.</p>
<p>0 1 1 0 0</p></td>
<td>We receive 2 sequences with <strong>same length</strong> <strong>of subsequence of ones</strong>, but the second is printed, because its subsequence starts at <strong>index[1].</strong></td>
</tr>
<tr class="even">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
<td><strong>Comments</strong></td>
</tr>
<tr class="odd">
<td><p>4</p>
<p><strong>1!1</strong>!0!<strong>1</strong></p>
<p>1!0!0!1</p>
<p><strong>1!1</strong>!0!0</p>
<p>Clone them!</p></td>
<td><p>Best DNA sample 1 with sum: 3.</p>
<p>1 1 0 1</p></td>
<td>We receive 3 sequences. Both 1 and 3 <strong>have same length</strong> of subsequence of ones -&gt; 2, <strong>and both start from index[0]</strong>, but the first is printed, because its <strong>sum is greater.</strong></td>
</tr>
</tbody>
</table>
<h2 id="ladybugs">*LadyBugs</h2>
<p>You are <strong>given a field size</strong> and the <strong>indexes of ladybugs</strong> inside the field. After that on every new line <strong>until the "end" command</strong> is given, a <strong>ladybug changes its position</strong> either to its <strong>left or to its right</strong> <strong>by a given fly length</strong>.</p>
<p>A <strong>command to a ladybug</strong> looks like this: "<strong>0 right 1</strong>". This means that the little insect placed on index 0 should fly one index to its right. If the ladybug <strong>lands on a fellow ladybug</strong>, it <strong>continues to fly</strong> in the same direction <strong>by the same fly length</strong>. If the ladybug <strong>flies out of the field, it is gone</strong>.</p>
<p>For example, imagine you are given a field with size 3 and ladybugs on indexes 0 and 1. If the ladybug on index 0 needs to fly to its right by the length of 1 (0 right 1) it will attempt to land on index 1 but as there is another ladybug there it will continue further to the right by additional length of 1, landing on index 2. After that, if the same ladybug needs to fly to its right by the length of 1 (2 right 1), it will land somewhere outside of the field, so it flies away:</p>
<p><img src="media/image1.png" style="width:4.91319in;height:0.71111in" /></p>
<p>If you are given ladybug index that does not have ladybug there, nothing happens. If you are given ladybug index that is outside the field, nothing happens.</p>
<p>Your job is to create the program, simulating the ladybugs flying around doing nothing. At the end, <strong>print all cells in the field separated by blank spaces</strong>. For each cell that has a ladybug on it print '<strong>1</strong>' and for each empty cells print '<strong>0</strong>'. For the example above, the output should be <strong>'0 1 0'</strong>.</p>
<h3 id="input">Input</h3>
<ul>
<li><p>On the first line you will receive an integer - the size of the field</p></li>
<li><p>On the second line you will receive the initial <strong>indexes</strong> of all ladybugs separated by a blank space. <strong>The given indexes</strong> may or may not be inside the field range</p></li>
<li><p>On the next lines, until you get the "end" command you will receive commands in the format: "<strong>{ladybug index} {direction} {fly length}</strong>"</p></li>
</ul>
<h3 id="output-1">Output</h3>
<ul>
<li><p>Print the <strong>all cells within the field in format: "{cell} {cell} … {cell}"</strong></p>
<ul>
<li><p>If a cell has ladybug in it, print <strong>'1'</strong></p></li>
<li><p>If a cell is empty, print <strong>'0'</strong></p></li>
</ul></li>
</ul>
<h3 id="constrains">Constrains</h3>
<ul>
<li><p>The size of the field will be in the range [0 … 1000]</p></li>
<li><p>The ladybug indexes will be in the range [-2,147,483,647 … 2,147,483,647]</p></li>
<li><p>The number of commands will be in the range [0 … 100]</p></li>
<li><p>The fly length will be in the range [-2,147,483,647 … 2,147,483,647]</p></li>
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
<td><p>3</p>
<p>0 1</p>
<p>0 right 1</p>
<p>2 right 1</p>
<p>end</p></td>
<td>0 1 0</td>
<td><p>1 1 0 - Initial field</p>
<p>0 1 1 - field after "0 right 1"</p>
<p>0 1 0 - field after "2 right 1"</p></td>
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
<td><p>3</p>
<p>0 1 2</p>
<p>0 right 1</p>
<p>1 right 1</p>
<p>2 right 1</p>
<p>end</p></td>
<td>0 0 0</td>
<td></td>
<td><p>5</p>
<p>3</p>
<p>3 left 2</p>
<p>1 left -2</p>
<p>end</p></td>
<td>0 0 0 1 0</td>
</tr>
</tbody>
</table>
