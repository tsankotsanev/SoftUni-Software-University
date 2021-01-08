<h1 id="problem-3.-heart-delivery">Problem 3. Heart Delivery</h1>
<p><em>Valentine’s Day is coming, and Cupid has very limited time to spread some love across the neighborhood. Help him with his mission!</em></p>
<p>You will receive a <strong>string</strong> with <strong>even integers,</strong> separated by a <strong>"@".</strong> This is our neighborhood. After that a series of <strong>Jump</strong> commands will follow, until you receive <strong>"Love!"</strong> Every house in the neighborhood needs a certain number of <strong>hearts</strong> delivered by Cupid, in order to be able to celebrate Valentine’s Day. Those needed hearts are indicated by the integers in the neighborhood.</p>
<p>Cupid starts at the position of the <strong>first</strong> <strong>house</strong> (index 0) and must jump by a <strong>given length.</strong> The jump commands will be in this format: <strong>"Jump {length}"</strong>.</p>
<p>Every time he jumps from one house to another, the needed hearts for the visited house are <strong>decreased by 2</strong>. If the needed hearts for a certain house become <strong>equal to 0</strong> , print on the console <strong>"Place {houseIndex} has Valentine's day."</strong> If <strong>Cupid</strong> jumps to a house where the needed hearts are <strong>already</strong> <strong>0,</strong> print on the console "<strong>Place {houseIndex} already had Valentine's day.</strong>".</p>
<p>Keep in mind that <strong>Cupid</strong> can have a <strong>bigger jump length</strong> than the <strong>size of the neighborhood</strong> and if he does jump <strong>outside</strong> of it, he should <strong>start</strong> from the <strong>first house</strong> again<strong>.</strong></p>
<p><em>For example, we are given this neighborhood: 6@6@6. Cupid is at the start and jumps with a length of 2. He will end up at index 2 and decrease the needed hearts there by 2: [6, 6, 4]. Next he jumps again with a length of 2 and goes outside the neighborhood, so he goes back to the first house (index 0) and again decreases the needed hearts there: [4, 6, 4].</em></p>
<h3 id="input">Input</h3>
<ul>
<li><p>On the first line you will receive a <strong>string</strong> with <strong>even integers</strong> separated by <strong>"@"</strong> – the neighborhood and the number of hearts for each house.</p></li>
<li><p>On the next lines, until "<strong>Love!</strong>" is received, you will be getting jump commands in this format: "<strong>Jump {length}</strong>".</p></li>
</ul>
<h3 id="output">Output</h3>
<p>At the end print <strong>Cupid's</strong> <strong>last position</strong> and whether his mission was successful or not:</p>
<ul>
<li><p>"<strong>Cupid's last position was {lastPositionIndex}.</strong>"</p></li>
<li><p>If <strong>each house</strong> has had a Valentine's day, print:</p>
<ul>
<li><p>"<strong>Mission was successful.</strong>"</p></li>
</ul></li>
<li><p>If <strong>not,</strong> print the <strong>count</strong> of all houses that <strong>didn`t</strong> celebrate a Valentine's Day:</p>
<ul>
<li><p><strong>"Cupid has failed {houseCount} places."</strong></p></li>
</ul></li>
</ul>
<h3 id="constraints">Constraints</h3>
<ul>
<li><p>The <strong>neighborhood`s</strong> size will be in the range [1…20]</p></li>
</ul>
<ul>
<li><p>Each <strong>house</strong> will need an <strong>even number</strong> of hearts in the range [2 … 10]</p></li>
<li><p>Each <strong>jump length</strong> will be an integer in the range [1 … 20]</p></li>
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
<td><p>10@10@10@2</p>
<p>Jump 1</p>
<p>Jump 2</p>
<p>Love!</p></td>
<td><p>Place 3 has Valentine's day.</p>
<p>Cupid's last position was 3.</p>
<p>Cupid has failed 3 places.</p></td>
<td><p>Jump 1 -&gt;&gt; [10, 8, 10, 2]</p>
<p>Jump 2 -&gt;&gt; [10, 8, 10, 0] so we print "Place 3 has Valentine's day."</p>
<p>Next command is "Love!", so we print Cupid`s last position and the outcome of his mission.</p></td>
</tr>
<tr class="even">
<td><p>2@4@2</p>
<p>Jump 2</p>
<p>Jump 2</p>
<p>Jump 8</p>
<p>Jump 3</p>
<p>Jump 1</p>
<p>Love!</p></td>
<td><p>Place 2 has Valentine's day.</p>
<p>Place 0 has Valentine's day.</p>
<p>Place 0 already had Valentine's day.</p>
<p>Place 0 already had Valentine's day.</p>
<p>Cupid's last position was 1.</p>
<p>Cupid has failed 1 places.</p></td>
<td></td>
</tr>
</tbody>
</table>
