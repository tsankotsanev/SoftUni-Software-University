<h1 id="problem-1.-national-court">Problem 1. National Court</h1>
<p><em>Every day thousands of people pass by the reception at "National Court" with various questions to ask and the employees have to help everyone by providing correct information and to answer all questions.</em></p>
<p>There are <strong>3 employees</strong> working on the reception all day long. Each of them can handle different number of <strong>people</strong> <strong>per hour</strong>. Your task is to calculate <strong>how much time</strong> it will take <strong>to</strong> <strong>answer all the questions</strong> of a given number <strong>of people</strong>.</p>
<p>First you will receive 3 lines with integers, representing the <strong>count of people</strong> that each of the <strong>employee can help per hour.</strong> On the next line you will receive the <strong>total</strong> <strong>people count</strong> as a single integer.</p>
<p>Every <strong>fourth hour</strong> all the employees <strong>have a one-hour break</strong> before they start working again. This is the only break they get because they don’t need rest and have no personal life. Calculate the time needed to answer all people’s questions and print it in the following format: <strong>"Time needed: {time}h."</strong></p>
<h3 id="input-constraints">Input / Constraints</h3>
<ul>
<li><blockquote>
<p>On first three lines - <strong>each employees efficiency</strong> - an integer in the range <strong>[1 - 100]</strong></p>
</blockquote></li>
<li><blockquote>
<p>On the fourth line - <strong>people count</strong> – an integer in the range <strong>[0 – 10000]</strong></p>
</blockquote></li>
<li><blockquote>
<p>Input will always be valid and in the range specified</p>
</blockquote></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>Print a single line: <strong>"Time needed: {time}h."</strong></p></li>
<li><p>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong></p></li>
</ul>
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
<td><p>5</p>
<p>6</p>
<p>4</p>
<p>20</p></td>
<td>Time needed: 2h.</td>
<td><p>All employees can answer 15 people per hour. After the first hour there are 5 people left to be answered.</p>
<p>All people will be answered in the second hour.</p></td>
</tr>
<tr class="even">
<td><p>1</p>
<p>2</p>
<p>3</p>
<p>45</p></td>
<td>Time needed: 10h.</td>
<td><p>All employess can answer 6 people per hour. In the first 3 hours they have answered 6 * 3 = 18 people. Then they have a break for an hour.</p>
<p>After the next 3 hours there are<br />
18 + 6 * 3 = 36 answered people.</p>
<p>After the break for an hour, there are only 9 people to answer.</p>
<p>So in the 10th hour all of the people questions would be answered.</p></td>
</tr>
<tr class="odd">
<td><p>3</p>
<p>2</p>
<p>5</p>
<p>40</p></td>
<td>Time needed: 5h.</td>
<td></td>
</tr>
</tbody>
</table>
