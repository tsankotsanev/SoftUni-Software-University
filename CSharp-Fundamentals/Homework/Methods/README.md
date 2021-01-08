<h1 id="exercise-methods">Exercise: Methods</h1>
<p>Problems for exercise and homework for the <u><a href="https://softuni.bg/trainings/3135/csharp-fundamentals-september-2020">"C# Fundamentals" course @ SoftUni</a><br />
</u>You can check your solutions in <a href="https://judge.softuni.bg/Contests/1209"><u>Judge</u></a></p>
<h2 id="smallest-of-three-numbers">Smallest of Three Numbers</h2>
<p>Write a method to print the smallest of three integer numbers. Use appropriate name for the method.</p>
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
<td><p>2</p>
<p>5</p>
<p>3</p></td>
<td>2</td>
</tr>
<tr class="even">
<td><p>600</p>
<p>342</p>
<p>123</p></td>
<td>123</td>
</tr>
<tr class="odd">
<td><p>25</p>
<p>21</p>
<p>4</p></td>
<td>4</td>
</tr>
</tbody>
</table>
<h2 id="vowels-count">Vowels Count</h2>
<p>Write a method that receives a single string and prints the count of the vowels. Use appropriate name for the method.</p>
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
<td>SoftUni</td>
<td>3</td>
</tr>
<tr class="even">
<td>Cats</td>
<td>1</td>
</tr>
<tr class="odd">
<td>JS</td>
<td>0</td>
</tr>
</tbody>
</table>
<h2 id="characters-in-range">Characters in Range</h2>
<p>Write a method that receives two characters and prints on a single line all the characters in between them according to ASCII.</p>
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
<td><p>a</p>
<p>d</p></td>
<td>b c</td>
</tr>
<tr class="even">
<td><p>#</p>
<p>:</p></td>
<td>$ % &amp; ' ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9</td>
</tr>
<tr class="odd">
<td><p>C</p>
<p>#</p></td>
<td>$ % &amp; ' ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9 : ; &lt; = &gt; ? @ A B</td>
</tr>
</tbody>
</table>
<h2 id="password-validator">Password Validator</h2>
<p>Write a program that checks if a given password is valid. Password rules are:</p>
<ul>
<li><p><strong>6 – 10 characters (inclusive)</strong></p></li>
<li><p><strong>Consists only of letters and digits</strong></p></li>
<li><p><strong>Have at least 2 digits</strong></p></li>
</ul>
<p>If a password is valid print "Password is valid". If it is not valid, for every unfulfilled rule print a message:</p>
<ul>
<li><p><strong>"Password must be between 6 and 10 characters"</strong></p></li>
<li><p><strong>"Password must consist only of letters and digits"</strong></p></li>
<li><p><strong>"Password must have at least 2 digits"</strong></p></li>
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
<td>logIn</td>
<td><p>Password must be between 6 and 10 characters</p>
<p>Password must have at least 2 digits</p></td>
</tr>
<tr class="even">
<td>MyPass123</td>
<td>Password is valid</td>
</tr>
<tr class="odd">
<td>Pa$s$s</td>
<td><p>Password must consist only of letters and digits</p>
<p>Password must have at least 2 digits</p></td>
</tr>
</tbody>
</table>
<h3 id="hints">Hints</h3>
<p>Write a method for each rule.</p>
<h2 id="add-and-subtract">Add and Subtract</h2>
<p>You will receive 3 <strong>integers.</strong> Write a method <strong>Sum</strong> to get the sum of the first two integers and <strong>Subtract</strong> method that subtracts the third integer from the result from the Sum method.</p>
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
<td><p>23</p>
<p>6</p>
<p>10</p></td>
<td>19</td>
</tr>
<tr class="even">
<td><p>1</p>
<p>17</p>
<p>30</p></td>
<td>-12</td>
</tr>
<tr class="odd">
<td><p>42</p>
<p>58</p>
<p>100</p></td>
<td>0</td>
</tr>
</tbody>
</table>
<h2 id="middle-characters">Middle Characters</h2>
<p>You will receive a single string. Write a method that prints the middle character. If the length of the string is even there are two middle characters.</p>
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
<td>aString</td>
<td>r</td>
</tr>
<tr class="even">
<td>someText</td>
<td>eT</td>
</tr>
<tr class="odd">
<td>3245</td>
<td>24</td>
</tr>
</tbody>
</table>
<h2 id="nxn-matrix">NxN Matrix</h2>
<p>Write a method that receives a single integer <strong>N</strong> and prints <strong>NxN</strong> matrix with that number.</p>
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
<td>3</td>
<td><p>3 3 3</p>
<p>3 3 3</p>
<p>3 3 3</p></td>
</tr>
<tr class="even">
<td>7</td>
<td><p>7 7 7 7 7 7 7</p>
<p>7 7 7 7 7 7 7</p>
<p>7 7 7 7 7 7 7</p>
<p>7 7 7 7 7 7 7</p>
<p>7 7 7 7 7 7 7</p>
<p>7 7 7 7 7 7 7</p>
<p>7 7 7 7 7 7 7</p></td>
</tr>
<tr class="odd">
<td>2</td>
<td><p>2 2</p>
<p>2 2</p></td>
</tr>
</tbody>
</table>
<h2 id="factorial-division">Factorial Division</h2>
<p>Read two integer numbers. Calculate <a href="https://en.wikipedia.org/wiki/Factorial"><u>factorial</u></a> of each number. Divide the first result by the second and print the division formatted to the second decimal point.</p>
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
<td><p>5</p>
<p>2</p></td>
<td>60.00</td>
<td></td>
<td><p>6</p>
<p>2</p></td>
<td>360.00</td>
</tr>
</tbody>
</table>
<h2 id="palindrome-integers">Palindrome Integers</h2>
<p>A palindrome is a number which reads the same backward as forward, such as 323 or 1001. Write a program which reads a positive integer numbers until you receive "<strong>End</strong>", for each number print whether the number is palindrome or not.</p>
<h3 id="examples-8">Examples</h3>
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
<td><p>123</p>
<p>323</p>
<p>421</p>
<p>121</p>
<p>END</p></td>
<td><p>false</p>
<p>true</p>
<p>false</p>
<p>true</p></td>
<td></td>
<td><p>32</p>
<p>2</p>
<p>232</p>
<p>1010</p>
<p>END</p></td>
<td><p>false</p>
<p>true</p>
<p>true</p>
<p>false</p></td>
</tr>
</tbody>
</table>
<h2 id="top-number">Top Number</h2>
<p>A top number is an integer that holds the following properties:</p>
<ul>
<li><p>Its <strong>sum of digits is divisible by 8</strong>, e.g. 8, 16, 88.</p></li>
<li><p>Holds at least <strong>one odd digit</strong>, e.g. 232, 707, 87578.</p></li>
</ul>
<p>Write a program to print all master numbers in the range [1…n].</p>
<h3 id="examples-9">Examples</h3>
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
<td>50</td>
<td><p>17</p>
<p>35</p></td>
<td></td>
<td>100</td>
<td><p>17</p>
<p>35</p>
<p>53</p>
<p>71</p>
<p>79</p>
<p>97</p></td>
</tr>
</tbody>
</table>
<h2 id="array-manipulator">*Array Manipulator</h2>
<p>Trifon has finally become a junior developer and has received his first task. It’s about manipulating an array of integers. He is not quite happy about it, since he hates manipulating arrays. They are going to pay him a lot of money, though, and he is willing to give somebody half of it if to help him do his job. You, on the other hand, love arrays (and money) so you decide to try your luck.</p>
<p>The array may be manipulated by one of the following commands</p>
<ul>
<li><p><strong>exchange {index}</strong> – splits the array <strong>after</strong> the given index, and exchanges the places of the two resulting sub-arrays. E.g. [1, 2, 3, 4, 5] -&gt; exchange 2 -&gt; result: [4, 5, 1, 2, 3]</p>
<ul>
<li><p>If the index is outside the boundaries of the array, print “<strong>Invalid index</strong>”</p></li>
</ul></li>
<li><p><strong>max</strong> <strong>even/odd</strong>– returns the <strong>INDEX</strong> of the max even/odd element -&gt; [1, 4, 8, 2, 3] -&gt; <strong>max odd</strong> -&gt; print <strong>4</strong></p></li>
<li><p><strong>min</strong> <strong>even/odd</strong> – returns the <strong>INDEX</strong> of the min even/odd element -&gt; [1, 4, 8, 2, 3] -&gt; <strong>min even</strong> &gt; print <strong>3</strong></p>
<ul>
<li><p>If there are two or more equal <strong>min/max</strong> elements, return the index of the <strong>rightmost</strong> one</p></li>
<li><p>If a <strong>min/max even/odd</strong> element <strong>cannot</strong> be found, print <strong>“No matches”</strong></p></li>
</ul></li>
<li><p><strong>first {count}</strong> <strong>even/odd</strong>– returns the first {count} elements -&gt; [1, 8, 2, 3] -&gt; <strong>first 2 even</strong> -&gt; print [<strong>8, 2]</strong></p></li>
<li><p><strong>last {count}</strong> <strong>even/odd</strong> – returns the last {count} elements -&gt; [1, 8, 2, 3] -&gt; <strong>last 2 odd</strong> -&gt; print [<strong>1, 3]</strong></p>
<ul>
<li><p>If the count is greater than the array length, print “<strong>Invalid count</strong>”</p></li>
<li><p>If there are <strong>not</strong> <strong>enough</strong> elements to satisfy the count, print as many as you can. If there are <strong>zero</strong> <strong>even/odd</strong> elements, print an empty array “[]”</p></li>
</ul></li>
<li><p><strong>end</strong> – stop taking input and print the final state of the array</p></li>
</ul>
<h3 id="input">Input</h3>
<ul>
<li><p>The input data should be read from the console.</p></li>
<li><p>On the first line, the initial array is received as a line of integers, separated by a single space</p></li>
<li><p>On the next lines, until the command “<strong>end</strong>” is received, you will receive the array manipulation commands</p></li>
<li><p>The input data will always be valid and in the format described. There is no need to check it explicitly.</p></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>The output should be printed on the console.</p></li>
<li><p>On a separate line, print the output of the corresponding command</p></li>
<li><p>On the last line, print the final array in <strong>square brackets</strong> with its elements separated by a comma and a space</p></li>
<li><p>See the examples below to get a better understanding of your task</p></li>
</ul>
<h3 id="constraints">Constraints</h3>
<ul>
<li><p>The <strong>number of input lines</strong> will be in the range [2 … 50].</p></li>
<li><p>The <strong>array elements</strong> will be integers in the range [0 … 1000].</p></li>
<li><p>The <strong>number of elements</strong> will be in the range [1 .. 50]</p></li>
<li><p>The <strong>split index</strong> will be an integer in the range [-2<sup>31</sup> … 2<sup>31</sup> – 1]</p></li>
<li><p><strong>first/last count</strong> will be an integer in the range [1 … 2<sup>31</sup> – 1]</p></li>
<li><p>There will <strong>not</strong> be redundant whitespace anywhere in the input</p></li>
<li><p>Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.</p></li>
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
<td><p>1 3 5 7 9</p>
<p>exchange 1</p>
<p>max odd</p>
<p>min even</p>
<p>first 2 odd</p>
<p>last 2 even</p>
<p>exchange 3</p>
<p>end</p></td>
<td><p>2</p>
<p>No matches</p>
<p>[5, 7]</p>
<p>[]</p>
<p>[3, 5, 7, 9, 1]</p></td>
</tr>
<tr class="even">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="odd">
<td><p>1 10 100 1000</p>
<p>max even</p>
<p>first 5 even</p>
<p>exchange 10</p>
<p>min odd</p>
<p>exchange 0</p>
<p>max even</p>
<p>min even</p>
<p>end</p></td>
<td><p>3</p>
<p>Invalid count</p>
<p>Invalid index</p>
<p>0</p>
<p>2</p>
<p>0</p>
<p>[10, 100, 1000, 1]</p></td>
</tr>
<tr class="even">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="odd">
<td><p>1 10 100 1000</p>
<p>exchange 3</p>
<p>first 2 odd</p>
<p>last 4 odd</p>
<p>end</p></td>
<td><p>[1]</p>
<p>[1]</p>
<p>[1, 10, 100, 1000]</p></td>
</tr>
</tbody>
</table>
