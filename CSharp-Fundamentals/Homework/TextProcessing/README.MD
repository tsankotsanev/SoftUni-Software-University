<h1 id="exercise-strings-and-text-processing">Exercise: Strings and Text Processing</h1>
<p>Problems for exercise and homework for the <a href="https://softuni.bg/trainings/3135/csharp-fundamentals-september-2020">"C# Fundamentals" course @ SoftUni</a><br />
You can check your solutions here: <a href="https://judge.softuni.bg/Contests/1217">Judge</a></p>
<h2 id="valid-usernames"> Valid Usernames</h2>
<p>Write a program that <strong>reads user</strong> names on a <strong>single</strong> line (joined by <strong>", "</strong>) and <strong>prints</strong> all <strong>valid usernames</strong>.</p>
<p>A valid username is:</p>
<ul>
<li><p>Has <strong>length</strong> between 3 and 16 characters</p></li>
<li><p><strong>Contains</strong> only letters, numbers, hyphens and underscores</p></li>
</ul>
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
<td>sh, too_long_username, !lleg@l ch@rs, jeffbutt</td>
<td>jeffbutt</td>
</tr>
<tr class="even">
<td>Jeff, john45, ab, cd, peter-ivanov, @smith</td>
<td><p>Jeff</p>
<p>John45</p>
<p>peter-ivanov</p></td>
</tr>
</tbody>
</table>
<h2 id="character-multiplier"> Character Multiplier</h2>
<p>Create a <strong>method</strong> that takes <strong>two strings</strong> as arguments and returns the <strong>sum</strong> of their <strong>character codes</strong> <strong>multiplied</strong> (multiply <strong>str1[0]</strong> with <strong>str2[0]</strong> and add to the total sum). Then continue with the next two characters. If one of the strings is <strong>longer</strong> than the other, <strong>add</strong> the <strong>remaining</strong> character codes to the <strong>total</strong> <strong>sum</strong> without multiplication.</p>
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
<td>Gosho Pesho</td>
<td>53253</td>
</tr>
<tr class="even">
<td>123 522</td>
<td>7647</td>
</tr>
<tr class="odd">
<td>a aaaa</td>
<td>9700</td>
</tr>
</tbody>
</table>
<h2 id="extract-file"> Extract File</h2>
<p>Write a program that reads the path to a file and <strong>subtracts</strong> the <strong>file name</strong> and its <strong>extension</strong>.</p>
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
<td>C:\Internal\training-internal\Template.pptx</td>
<td><p>File name: Template</p>
<p>File extension: pptx</p></td>
</tr>
<tr class="even">
<td>C:\Projects\Data-Structures\LinkedList.cs</td>
<td><p>File name: LinkedList</p>
<p>File extension: cs</p></td>
</tr>
</tbody>
</table>
<h2 id="caesar-cipher"> Caesar Cipher</h2>
<p>Write a program that returns an <strong>encrypted version</strong> of the same text. Encrypt the text by <strong>shifting</strong> <strong>each character</strong> with <strong>three</strong> positions <strong>forward</strong>. For example <strong>A</strong> would be replaced by <strong>D</strong>, <strong>B</strong> would become <strong>E</strong>, and so on. Print the <strong>encrypted</strong> <strong>text</strong>.</p>
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
<td>Programming is cool!</td>
<td>Surjudpplqj#lv#frro$</td>
</tr>
<tr class="even">
<td>One year has 365 days.</td>
<td>Rqh#|hdu#kdv#698#gd|v1</td>
</tr>
</tbody>
</table>
<h2 id="multiply-big-number"> Multiply Big Number</h2>
<p>You are given <strong>two lines</strong> – the <strong>first</strong> one can be a really <strong>big</strong> number <strong>(0 to 10<sup>50</sup>)</strong>. The <strong>second</strong> one will be a <strong>single</strong> digit number <strong>(0 to 9)</strong>. You must display the product of these numbers.</p>
<p>Note: do not use the <strong>BigInteger</strong> class.</p>
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
<p>2</p></td>
<td>46</td>
</tr>
<tr class="even">
<td><p>9999</p>
<p>9</p></td>
<td>89991</td>
</tr>
<tr class="odd">
<td><p>923847238931983192462832102</p>
<p>4</p></td>
<td>3695388955727932769851328408</td>
</tr>
</tbody>
</table>
<h2 id="replace-repeating-chars"> Replace Repeating Chars</h2>
<p>Write a program that reads a string from the console and <strong>replaces</strong> any <strong>sequence of the same letters</strong> with a <strong>single</strong> <strong>corresponding letter</strong>.</p>
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
<td>aaaaabbbbbcdddeeeedssaa</td>
<td>abcdedsa</td>
</tr>
<tr class="even">
<td>qqqwerqwecccwd</td>
<td>qwerqwecwd</td>
</tr>
</tbody>
</table>
<h2 id="string-explosion"> String Explosion</h2>
<p>Explosions are marked with <strong>'&gt;'</strong>. Immediately after the mark, there will be an <strong>integer</strong>, which signifies the <strong>strength</strong> of the explosion.</p>
<p>You should <strong>remove x characters</strong> (where <strong>x</strong> is the <strong>strength</strong> of the explosion), <strong>starting after</strong> the punch <strong>character</strong> (<strong>'&gt;'</strong>).</p>
<p>If you find <strong>another</strong> explosion mark (<strong>'&gt;'</strong>) while you’re deleting characters, you should <strong>add</strong> the <strong>strength</strong> to your <strong>previous</strong> <strong>explosion</strong>.</p>
<p>When all characters are processed, <strong>print</strong> the string <strong>without</strong> the <strong>deleted</strong> <strong>characters</strong>.</p>
<p>You should <strong>not</strong> delete the <strong>explosion</strong> character – <strong>'&gt;'</strong>, but you should <strong>delete</strong> the <strong>integers</strong>, which represent the <strong>strength</strong>.</p>
<h3 id="input">Input</h3>
<p>You will receive <strong>single</strong> <strong>line</strong> with the string.</p>
<h3 id="output">Output</h3>
<p>Print what is left from the string after explosions.</p>
<h3 id="constraints">Constraints</h3>
<ul>
<li><blockquote>
<p>You will <strong>always</strong> receive a <strong>strength</strong> for the punches</p>
</blockquote></li>
<li><blockquote>
<p>The path will consist only of letters from the <strong>Latin</strong> <strong>alphabet</strong>, <strong>integers</strong> and the char <strong>'&gt;'</strong></p>
</blockquote></li>
<li><blockquote>
<p>The strength of the punches will be in the interval [0…9]</p>
</blockquote></li>
</ul>
<h3 id="examples-6">Examples</h3>
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
<td>abv&gt;1&gt;1&gt;2&gt;2asdasd</td>
<td>abv&gt;&gt;&gt;&gt;dasd</td>
<td><p>1<sup>st</sup> explosion is at index <strong>3</strong> and it is with <strong>strength</strong> of <strong>1</strong>. We delete <strong>only</strong> the <strong>digit</strong> <strong>after</strong> the explosion character. The string will look like this: <strong>abv&gt;&gt;1&gt;2&gt;2asdasd</strong></p>
<p>2<sup>nd</sup> explosion is with strength <strong>one</strong> and the string transforms to this: <strong>abv&gt;&gt;&gt;2&gt;2asdasd</strong></p>
<p>3<sup>rd</sup> explosion is now with strength of 2. We delete the digit and we find <strong>another</strong> explosion. At this point the string looks like this: <strong>abv&gt;&gt;&gt;&gt;2asdasd</strong>.</p>
<p>4<sup>th</sup> explosion is with strength <strong>2</strong>. We have <strong>1</strong> strength <strong>left</strong> from the previous explosion, we <strong>add</strong> the strength of the <strong>current</strong> explosion to what is <strong>left</strong> and that adds up to a <strong>total</strong> strength of <strong>3</strong>. We <strong>delete</strong> the next <strong>three</strong> <strong>characters</strong> and we <strong>receive</strong> the <strong>string</strong> <strong>abv&gt;&gt;&gt;&gt;dasd</strong></p>
<p>We do <strong>not</strong> have <strong>any more explosions</strong> and we print the result: <strong>abv&gt;&gt;&gt;&gt;dasd</strong></p></td>
</tr>
<tr class="even">
<td>pesho&gt;2sis&gt;1a&gt;2akarate&gt;4hexmaster</td>
<td>pesho&gt;is&gt;a&gt;karate&gt;master</td>
<td></td>
</tr>
</tbody>
</table>
<h2 id="letters-change-numbers"> *Letters Change Numbers</h2>
<p>Nakov likes Math. But he also likes the English alphabet a lot. He invented a game with numbers and letters from the <strong>English</strong> alphabet. The game was simple. You get a string consisting of a <strong>number between two letters</strong>. Depending on whether the letter was in front of the number or after it you would perform different mathematical operations on the number to achieve the result.</p>
<p><strong>First</strong> you start with the letter <strong>before</strong> the number.</p>
<ul>
<li><p>If it's <strong>uppercase</strong> you <strong>divide</strong> the number by the letter's <strong>position</strong> in the alphabet.</p></li>
<li><p>If it's <strong>lowercase</strong> you <strong>multiply</strong> the number with the letter's <strong>position</strong> in the alphabet.</p></li>
</ul>
<p><strong>Then</strong> you move to the <strong>letter after</strong> the number.</p>
<ul>
<li><p>If it's <strong>uppercase</strong> you <strong>subtract</strong> its position from the resulted number.</p></li>
<li><p>If it's <strong>lowercase</strong> you <strong>add</strong> its position to the resulted number.</p></li>
</ul>
<p>But the game became too easy for Nakov really quick. He decided to complicate it a bit by doing the same but with <strong>multiple</strong> strings keeping track of only the <strong>total sum</strong> of all results. Once he started to solve this with more strings and bigger numbers it became quite hard to do it only in his mind. So he kindly asks you to write a program that <strong>calculates the sum of all numbers after the operations on each number have been done</strong>.</p>
<p><strong>For example</strong>, you are given the sequence <strong>"A12b s17G"</strong>:</p>
<p>We have two strings – <strong>"A12b"</strong> and <strong>"s17G"</strong>. We do the operations on each and sum them. We start with the letter before the number on the first string. <strong>A is Uppercase</strong> and its position in the alphabet is <strong>1</strong>. So we divide the number 12 with the position 1 <strong>(12/1 = 12)</strong>. Then we move to the letter after the number. <strong>b is lowercase</strong> and its position is 2. So we add 2 to the resulted number <strong>(12+2=14)</strong>. Similarly for the second string <strong>s is lowercase</strong> and its position is 19 so we multiply it with the number <strong>(17*19 = 323)</strong>. Then we have Uppercase G with position 7, so we subtract it from the resulted number <strong>(323 – 7 = 316)</strong>. Finally, we sum the 2 results and we get <strong>14 + 316=330</strong>.</p>
<h3 id="input-1">Input</h3>
<p>The input comes from the console as a <strong>single line, holding the sequence of strings</strong>. Strings are separated by <strong>one or more white spaces</strong>.</p>
<p>The input data will always be valid and in the format described. There is no need to check it explicitly.</p>
<h3 id="output-1">Output</h3>
<p>Print at the console a single number: the <strong>total sum of all processed numbers</strong> rounded up to <strong>two digits</strong> after the decimal separator.</p>
<h3 id="constraints-1">Constraints</h3>
<p>The <strong>count</strong> of the strings will be in the range [1 … 10]<strong>.</strong></p>
<ul>
<li><p>The numbers between the letters will be integers in range [1 … 2 147 483 647]<strong>.</strong></p></li>
<li><blockquote>
<p>Time limit: 0.3 sec. Memory limit: 16 MB.</p>
</blockquote></li>
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
<td>A12b s17G</td>
<td>330.00</td>
<td>12/1=12, 12+2=14, 17*19=323, 323–7=316, <strong>14+316=330</strong></td>
</tr>
<tr class="even">
<td>P34562Z q2576f H456z</td>
<td>46015.13</td>
<td></td>
</tr>
<tr class="odd">
<td>a1A</td>
<td>0.00</td>
<td></td>
</tr>
</tbody>
</table>
