<h1 id="flower-wreaths">Flower Wreaths</h1>
<p><em>You want to go on a flowers wreath competition but to participate you have to make at least 5 flower wreaths.</em></p>
<p>You will be given <strong>two sequences of integers, representing roses and lilies</strong>. You need to start making wreaths <strong>knowing that one wreath needs 15 flowers</strong>. Your goal is to make <strong>at least 5 flower wreaths</strong>.</p>
<p>You will start crafting from the <strong>last lilies</strong> and the <strong>first roses</strong>. If the <strong>sum</strong> of their values is <strong>equal</strong> to <strong>15</strong> – <strong>create one wreath</strong> and <strong>remove</strong> them. If the sum is <strong>bigger than 15</strong>, just <strong>decrease</strong> the value of the <strong>lilies</strong> <strong>by 2.</strong> If the sum is <strong>less than 15 you have to store them for later and remove them</strong>. You need to <strong>stop</strong> combining when you have <strong>no more roses or lilies</strong>. In the end, if you have <strong>any stored flowers you should make as many wreaths as you can with them</strong>.</p>
<h3 id="input">Input</h3>
<ul>
<li><p>On the <strong>first line</strong>, you will receive the integers representing the <strong>lilies</strong>, <strong>separated</strong> by <strong>", "</strong>.</p></li>
<li><p>On the <strong>second line</strong>, you will receive the integers representing the <strong>roses</strong>, <strong>separated</strong> by "<strong>,</strong> ".</p></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>Print whether you have succeeded making <strong>at least 5 wreaths</strong>:</p>
<ul>
<li><p><strong>"You made it, you are going to the competition with {count of wreaths} wreaths!"</strong></p></li>
<li><p><strong>"You didn't make it, you need {wreaths needed} wreaths more!"</strong></p></li>
</ul></li>
</ul>
<h3 id="constraints">Constraints</h3>
<ul>
<li><p>All of the given numbers will be valid integers in the range <strong>[0, 120]</strong>.</p></li>
<li><p>Don't have situation with negative number.</p></li>
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
<td><p>10, 15, 2, 7, 9, 13</p>
<p>2, 10, 8, 12, 0, 5</p></td>
<td>You made it, you are going to the competition with 5 wreaths!</td>
</tr>
<tr class="even">
<td><strong>Comment</strong></td>
<td></td>
</tr>
<tr class="odd">
<td><p>We start with the last lilies (13) and the first roses (2) -&gt; 13 + 2 = 15 -&gt; 15 = 15 So we create one wreath and remove them bouth.</p>
<p>Next we have 9 + 10 = 19 -&gt; 19 &gt; 15 so we decrease the lilies by 2 -&gt; 7 + 10 = 17 and we decrease the liles by 2 -&gt; 5 + 10 = 15 and we create one more wreath and remove them.</p>
<p>Next, we have 7 + 8 = 15. We create one more wreaht and remove them.</p>
<p>Next, we have 2 + 12 = 14 -&gt; 14 &lt; 15 so we have to store theire sum for later and remove them.</p>
<p>Next, we have 15 + 0 = 15 so we create one more wreath.</p>
<p>And last we have 10 + 5 = 15, we create one more wreath and stop mixing because we don’t have any flowers left.</p>
<p>Now we have a tottal of 5 wreaths and we also have 14 flowers left but we cant create wreath because 14 &lt; 15.</p></td>
<td></td>
</tr>
</tbody>
</table>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>10, 5, 3, 7, 8</p>
<p>5, 10, 8, 7, 6</p></td>
<td>You didn't make, you need 1 wreaths more!</td>
</tr>
<tr class="even">
<td><strong>Comment</strong></td>
<td></td>
</tr>
<tr class="odd">
<td><p>We start with 8 + 5 = 13 -&gt; 13 &lt; 15 -&gt; we have to store their sum for later and remove them.</p>
<p>Next, we have 7 + 10 = 17 -&gt; we decrease the lilies by 2 -&gt; 5 + 10 = 15 -&gt; 15 = 15 and we create one wreath.</p>
<p>Next, we have 3 + 8 = 11 -&gt; 11 &lt; 15 -&gt; we store their sum for later and remove them.</p>
<p>Next, we have 5 +7 = 12 -&gt; we store their sum for later and remove them.</p>
<p>Next, we have 10 + 6 = 16 -&gt; 16 &gt; 15 we decrease the lilies by 2 -&gt; 8 + 6 = 14 and we store their sum for later and remove them.</p>
<p>We stop crafting because we don’t have any flowers left and we have 1 wreath and 50 stored flowers. We create 3 more wreaths because 3 * 15 = 45 -&gt; 50 – 45 = 5 -&gt; 5 &lt; 15.</p></td>
<td></td>
</tr>
</tbody>
</table>
