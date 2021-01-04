<h1 id="angry-pet">Angry Pet</h1>
<p><em>Tom is very angry with his owner, because he left him alone during the teamwork defenses for the Programming Fundamentals Course at SoftUni. It’s time for Tom to get his payback and he will do it, by breaking various household items.</em></p>
<p>Each item has a <strong>price rating</strong> which is a number that describes how valuable is that item for Tom’s owner. You will be <strong>given an entry point</strong> from which Tom will start <strong>breaking</strong> the <strong>items to his left</strong>, and <strong>then</strong> to <strong>his right</strong>. Tom <strong>will never</strong> break the item at the <strong>entry point</strong>.</p>
<p>You must calculate the damage to <strong>both</strong> his <strong>left</strong>, and <strong>right</strong>, then print <strong>only the higher (bigger)</strong> damage to the household. If both <strong>sums</strong> are <strong>equal</strong> print the <strong>left</strong> one.</p>
<h2 class="list-paragraph" id="input-constrains">Input / Constrains</h2>
<ul>
<li><blockquote>
<p>On the <strong>first line</strong> you will receive the <strong>price ratings</strong>, separated by (space). Each element will be integer in range <strong>[-2<sup>31</sup>… 2<sup>31</sup>]</strong></p>
</blockquote></li>
<li><blockquote>
<p>On the <strong>second line</strong> you will receive the <strong>entry point</strong>, which will always be between the second and the penultimate element in the array</p>
</blockquote></li>
<li><blockquote>
<p>On the <strong>third line</strong> you will receive the <strong>type of items</strong> Tom wants to break, which will be one of the following:</p>
</blockquote>
<ul>
<li><p><strong>cheap</strong> – items that have <strong>lower price rating</strong> than the entry point item</p></li>
<li><p><strong>expensive</strong> – items that have <strong>same price rating</strong>, or <strong>higher price rating</strong> than the entry point item</p></li>
</ul></li>
<li><blockquote>
<p>On the <strong>last line</strong> you will receive the <strong>type of price ratings</strong> that Tom will look for, which will be one of the following:</p>
</blockquote>
<ul>
<li><p><strong>positive</strong> – price ratings <strong>above</strong> 0</p></li>
<li><p><strong>negative</strong> – price ratings <strong>below</strong> 0</p></li>
<li><p><strong>all</strong> – <strong>any</strong> price ratings</p></li>
</ul></li>
</ul>
<h2 class="list-paragraph" id="output">Output</h2>
<ul>
<li><blockquote>
<p>Single line containing the sum of price ratings and their position based on the entry point in the following format:</p>
</blockquote>
<ul>
<li><p>"{<strong>position</strong>} – {<strong>sum of price ratings</strong>}"</p></li>
</ul></li>
</ul>
<h2 class="list-paragraph" id="examples">Examples</h2>
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
<td><p>1 5 1</p>
<p>1</p>
<p>cheap</p>
<p>all</p></td>
<td>Left - 1</td>
<td></td>
<td><p>-2 2 1 5 9 3 2 -2 1 -1 -3 3</p>
<p>7</p>
<p>expensive</p>
<p>positive</p></td>
<td>Left - 22</td>
</tr>
</tbody>
</table>
<h2 class="list-paragraph" id="js-input">JS Input</h2>
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
<td><p>([1, 5, 1],</p>
<p>1,</p>
<p>"cheap",</p>
<p>"all")</p></td>
<td>Left - 1</td>
<td></td>
<td><p>([-2, 2, 1, 5, 9, 3, 2, -2, 1, -1, -3, 3],</p>
<p>7,</p>
<p>"expensive",</p>
<p>"positive")</p></td>
<td>Left - 22</td>
</tr>
</tbody>
</table>
