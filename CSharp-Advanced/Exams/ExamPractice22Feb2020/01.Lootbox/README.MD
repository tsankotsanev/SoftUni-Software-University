<h1 id="loot-box">Loot box</h1>
<p><em>You are tired of being the only one on your team without cool items, so you decided buy some loot boxes which have a chance to drop some cool items.</em></p>
<p>Every purchase gives you two loot boxes and they are represented as a sequence of integers. First, you will be given <strong>a sequence of integers, representing the first loot box</strong>. Afterwards, you will be given another <strong>sequence of integers representing the second loot box</strong>.</p>
<p>You need to start from the <strong>first item</strong> in the first box and <strong>sum</strong> it with the last item in the second box. If the <strong>sum</strong> of their values is <strong>an even number,</strong> add the <strong>summed</strong> item to <strong>your collection of claimed items</strong> and <strong>remove</strong> them <strong>both</strong> from the boxes. Otherwise, move the last item from the second box and add it at the last position in the first box. You need to <strong>stop</strong> summing items when one of the boxes becomes empty.</p>
<p>If the first loot box becomes empty print:</p>
<p><strong>"First lootbox is empty"</strong></p>
<p>If the second loot box becomes empty print:</p>
<p><strong>"Second lootbox is empty"</strong></p>
<p>In the end you need to determine the quality of your claimed items. If the sum of the claimed items equal to or greater than 100, print:</p>
<p><strong>"Your loot was epic! Value: {sum of claimed items}"</strong></p>
<p>Else print:</p>
<p><strong>"Your loot was poor... Value: {sum of claimed items}"</strong></p>
<h3 id="input">Input</h3>
<ul>
<li><p>On the <strong>first line</strong>, you will receive the integers representing the <strong>first loot box</strong>, <strong>separated</strong> by a <strong>single space</strong>.</p></li>
<li><p>On the <strong>second line</strong>, you will receive the integers representing the <strong>second loot box, separated</strong> by a <strong>single</strong> <strong>space</strong>.</p></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>On the <strong>first</strong> line of output – print which box got empty in the format described above.</p></li>
<li><p>On the <strong>second</strong> line – the quality of your loot in the format described above.</p></li>
</ul>
<h3 id="constraints">Constraints</h3>
<ul>
<li><p>All of the given numbers will be valid integers in the range <strong>[0, 100]</strong>.</p></li>
<li><p>There won’t be a case where both loot boxes become empty at the same time.</p></li>
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
<td><p>10 11 8 13 5 6</p>
<p>0 4 7 3 6 23 3</p></td>
<td><p>Second lootbox is empty</p>
<p>Your loot was poor... Value: 42</p></td>
<td><p>First we sum 10 and 3. We get 13, which is not an even number, so we take the last item from the second box and move it to last position in the first box. The current state of the boxes:</p>
<p>10 11 8 13 5 6 3</p>
<p>0 4 7 3 6 23</p>
<p>The next sum is 33 so we do the same again. On the third iteration the sum is 16 which is an even number, so we remove both of the boxes and we add the value to our claimed items. We keep summing items until one of the boxes becomes empty.</p></td>
</tr>
<tr class="even">
<td><p>20 40 60 80 100</p>
<p>10 20 30 40 50 60</p></td>
<td><p>First lootbox is empty</p>
<p>Your loot was epic! Value: 500</p></td>
<td></td>
</tr>
</tbody>
</table>
