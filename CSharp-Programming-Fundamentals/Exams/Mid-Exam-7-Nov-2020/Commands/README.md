<h1 id="commands">Commands</h1>
<p>You will be given a <strong>series of strings</strong> on a single line, separated by <strong>one white space</strong>. These represent the collection you’ll be working with.</p>
<p>On the next input lines, until you receive the command <strong>"end"</strong>, you’ll receive a series of commands in one of the following formats:</p>
<ul>
<li><p><strong>reverse from [start] count [count]</strong> - this instructs you to reverse a <strong>portion</strong> of the array – just [count] elements starting at index [start];</p></li>
<li><p><strong>sort from [start] count [count]</strong> - this instructs you to sort a <strong>portion</strong> of the array - [count] elements starting at index [start];</p></li>
<li><p><strong>remove [count]</strong> - <strong>remove</strong> the first <strong>count</strong> elements</p></li>
</ul>
<p><em><strong><u>Note: commands will always be valid and in the range of the array</u></strong></em></p>
<p>After you're done, print the resulting elements joined by <strong>", "</strong>. The examples should help you understand the task better.</p>
<h3 id="input">Input</h3>
<ul>
<li><p>The input data should be read from the console</p></li>
<li><p>The first input line will hold <strong>a series of strings</strong>, separated by <strong>one whitespace</strong></p></li>
<li><p>The next lines will hold <strong>commands</strong> in the described formats (exactly)</p></li>
<li><p>The input ends with the keyword <strong>"end"</strong></p></li>
<li><p>The input data will always be valid and in the format described. There is no need to check it explicitly</p></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>The output should be printed on the console.</p></li>
<li><p>After receiving the "<strong>end</strong>" command, print the <strong>resulting array</strong> on the console in the format specified above.</p></li>
</ul>
<h3 id="constraints">Constraints</h3>
<ul>
<li><p>The <strong>count of strings</strong> in the collection will be in the range [1 … 50]</p></li>
<li><p>The <strong>number of commands</strong> will be in the range [1 … 20]</p></li>
<li><p>All commands will be in the described format</p></li>
<li><p>[<strong>start</strong>] and [<strong>count</strong>] will be integers in the range [-2<sup>31</sup> … 2<sup>31</sup> - 1]</p></li>
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
<td><p>1 2 <strong>5 8 7 3</strong> 10 6 4 9</p>
<p>reverse from 2 count 4</p>
<p>end</p></td>
<td>1, 2, <strong>3, 7, 8, 5</strong>, 10, 6, 4, 9</td>
</tr>
<tr class="even">
<td><p>1 2 <strong>5 8 7 3</strong> 10 6 4 9</p>
<p>sort from 2 count 4</p>
<p>end</p></td>
<td>1, 2, <strong>3, 5, 7, 8</strong>, 10, 6, 4, 9</td>
</tr>
<tr class="odd">
<td><p>1 2 <strong>5 8 7 3</strong> 10 6 4 9</p>
<p>remove 2</p>
<p>end</p></td>
<td>5, 8, 7, 3, 10, 6, 4, 9</td>
</tr>
</tbody>
</table>
<h3 id="js-input">JS Input</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>([["1", "2", "5", "8", "7", "3", "10", "6", "4", "9"],</p>
<p>"reverse from 2 count 4",</p>
<p>"end"])</p></td>
<td>1, 2, <strong>3, 7, 8, 5</strong>, 10, 6, 4, 9</td>
</tr>
<tr class="even">
<td><p>([["1", "2", "5", "8", "7", "3", "10", "6", "4", "9"],</p>
<p>"sort from 2 count 4",</p>
<p>"end"])</p></td>
<td>1, 2, <strong>3, 5, 7, 8</strong>, 10, 6, 4, 9</td>
</tr>
<tr class="odd">
<td><p>([["1", "2", "5", "8", "7", "3", "10", "6", "4", "9"],</p>
<p>"remove 2",</p>
<p>"end"])</p></td>
<td>5, 8, 7, 3, 10, 6, 4, 9</td>
</tr>
</tbody>
</table>
