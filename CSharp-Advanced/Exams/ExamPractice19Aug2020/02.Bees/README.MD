<h1 id="bee">Bee</h1>
<p>You will be given an integer <strong>n</strong> for the <strong>size</strong> of the bee territory with <strong>square</strong> shape. On the next <strong>n</strong> lines, you will receive the <strong>rows</strong> of the territory. The bee will be placed on a <strong>random position</strong>, marked with the letter '<strong>B</strong>'. On random positions there will be flowers, marked with <strong>'f'</strong>. There may also be а <strong>bonus</strong> on the territory. There will always be <strong>only one bonus</strong>. It will be <strong>marked</strong> with the <strong>letter</strong> - '<strong>O</strong>'. <strong>All of the empty positions</strong> will be marked with <strong>'.'</strong>.</p>
<p>Each turn, you will be given a <strong>command</strong> for the <strong>bee’s movement</strong>.</p>
<p>The commands will be: "<strong>up</strong>", "<strong>down</strong>", "<strong>left</strong>", "<strong>right</strong>", "<strong>End</strong>".</p>
<p>If the bee <strong>moves</strong> to a <strong>flower</strong>, it pollinates the flower and increases the pollinated flowers with one.</p>
<p>If it goes to a <strong>bonus</strong>, the bee gets a bonus one move forward and then the bonus <strong>disappears</strong>. If the bee <strong>goes out</strong> she can't return back and the program ends. If the bee receives the "<strong>End</strong>" command the program ends. The bee needs <strong>at least</strong> <strong>5 pollinated flowers</strong>.</p>
<h3 id="input">Input</h3>
<ul>
<li><p>On the first line, you are given the integer <strong>n</strong> – the size of the <strong>square</strong> matrix.</p></li>
<li><p>The <strong>next n lines</strong> hold the values for every <strong>row</strong>.</p></li>
<li><p>On each of the next lines, until you receive "<strong>End</strong>" command, you will receive a move command.</p></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>On the <strong>first line</strong>:</p>
<ul>
<li><p>If the bee goes out of its territory print: <strong>"The bee got lost!"</strong></p></li>
</ul></li>
<li><p>On the <strong>second line</strong>:</p>
<ul>
<li><p>If the bee couldn’t pollinate enough flowers, print: <strong>"The bee couldn't pollinate the flowers, she needed {needed} flowers more"</strong></p></li>
<li><p>If the bee successfully pollinated enough flowers, print: <strong>"Great job, the bee managed to pollinate {polinationed flowers} flowers!"</strong></p></li>
</ul></li>
<li><p>In the end <strong>print the matrix</strong>.</p></li>
</ul>
<h3 id="constraints">Constraints</h3>
<ul>
<li><p>The size of the <strong>square</strong> matrix will be between <strong>[2…10].</strong></p></li>
<li><p>There will <strong>always</strong> be <strong>0</strong> or <strong>1</strong> bonus, marked with - '<strong>O</strong>'.</p></li>
<li><p>The bee position will be marked with '<strong>B</strong>'.</p></li>
<li><p>There won't be a case where a bonus moves the bee out of its territory.</p></li>
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
<td><p>5</p>
<p>Bff..</p>
<p>..O..</p>
<p>f.f.f</p>
<p>.....</p>
<p>fffff</p>
<p>right</p>
<p>right</p>
<p>down</p>
<p>left</p>
<p>left</p>
<p>down</p>
<p>down</p>
<p>right</p>
<p>down</p></td>
<td><p>The bee got lost!</p>
<p>Great job, the bee managed to pollinate 6 flowers!</p>
<p>.....</p>
<p>.....</p>
<p>....f</p>
<p>.....</p>
<p>..fff</p></td>
<td><p>1) right 2) right 3) down 5) left</p>
<p>.Bf.. ..B.. ..... .....</p>
<p>..O.. ..O.. ..... .....</p>
<p>f.f.f f.f.f f.B.f fB..f</p>
<p>..... ..... ..... .....</p>
<p>fffff fffff fffff fffff</p>
<p>…</p>
<p>2) pollinate a flower: 'f' (0, 1)</p>
<p>3) step on a bonus: 'O' (1, 2) and make one more step down to: 'f' (2, 2)</p>
<p>4) the bee is on (4, 1), the next command she receive is down and she goes out of the field and the program ends.</p></td>
</tr>
<tr class="even">
<td><p>4</p>
<p>....</p>
<p>.O..</p>
<p>ff..</p>
<p>f.B.</p>
<p>left</p>
<p>left</p>
<p>up</p>
<p>right</p>
<p>up</p>
<p>End</p></td>
<td><p>The bee couldn't pollinate the flowers, she needed 2 flowers more</p>
<p>.B..</p>
<p>....</p>
<p>....</p>
<p>....</p></td>
<td></td>
</tr>
</tbody>
</table>
