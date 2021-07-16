<h1 id="re-volt">Re-Volt</h1>
<p>You will be given an integer <strong>n</strong> for the size of the square matrix and an integer for the count of commands. On the next <strong>n</strong> lines, you will receive the rows of the matrix. The player starts at a random position (the player is marked with <strong>"f"</strong>) and <strong>all of the empty slots</strong> will be filled with <strong>"-" (dash)</strong>. The goal is to reach the finish mark which will be marked with <strong>"F"</strong>. On the field there can also be bonuses and traps. Bonuses are marked with <strong>"B"</strong> and traps are marked with <strong>"T"</strong>.</p>
<p>Each turn you will be given commands for <strong>the player’s movement.</strong> If the player <strong>goes</strong> <strong>out</strong> of the matrix, he comes in from <strong>the other side</strong>. For example, if the player is on 0, 0 and the next command is left, he goes to the last spot on the first row.</p>
<p>If the player steps on a bonus, he should move another step forward in the direction he is going. If the player steps on a trap, he should move a step backwards.</p>
<p>When the player reaches the <strong>finish mark</strong> or the <strong>count of commands is reached</strong> the game ends.</p>
<h3 id="input">Input</h3>
<ul>
<li><p>On the first line, you are given the integer N – the size of the square matrix.</p></li>
<li><p>On the second you are given the count of commands.</p></li>
<li><p>The next N lines holds the values for every row.</p></li>
<li><p>On each of the next lines you will get commands for movement directions.</p></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>If the player reaches the finish mark, print:</p>
<ul>
<li><p><strong>"Player won!"</strong></p></li>
</ul></li>
<li><p>If the player reaches the commands count and hasn’t reached the finish mark print:</p>
<ul>
<li><p><strong>"Player lost!"</strong></p></li>
</ul></li>
</ul>
<ul>
<li><p>In the end print the matrix.</p></li>
</ul>
<h3 id="constraints">Constraints</h3>
<ul>
<li><p>The size of the matrix will be between <strong>[2…20].</strong></p></li>
<li><p>The players will always be indicated with <strong>"f".</strong></p></li>
<li><p>If the player steps on the finish mark at the same time as his last command, he wins the game.</p></li>
<li><p>Commands will be in the format <strong>up</strong>, <strong>down</strong>, <strong>left</strong> or <strong>right</strong>.</p></li>
<li><p>There won't be a case where you bypass the finish while you are on a trap or a bonus.</p></li>
<li><p>A trap will never place you into a bonus or another trap and a bonus will never place you into a trap or another bonus.</p></li>
</ul>
<h3 id="section"></h3>
<h3 id="section-1"></h3>
<h3 id="section-2"></h3>
<h3 id="section-3"></h3>
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
<p>5</p>
<p>-----</p>
<p>-f---</p>
<p>-B---</p>
<p>--T--</p>
<p>-F---</p>
<p>down</p>
<p>right</p>
<p>down</p></td>
<td><p>Player won!</p>
<p>-----</p>
<p>-----</p>
<p>-B---</p>
<p>--T--</p>
<p>-f---</p></td>
<td><p>The first command is <strong>down</strong> so <strong>f</strong> moves down. On turn 1, the player steps on a bonus and does an additional step. On turn 2, the player steps on a trap and goes a step back. After each turn the field is:</p>
<p>1 2 3</p>
<p>----- ----- -----</p>
<p>----- ----- -----</p>
<p>-B--- -B--- -B---</p>
<p>-fT-- -fT-- --T--</p>
<p>-F--- -F--- -f---</p>
<p>On turn 3 <strong>f</strong> reaches the finish 'F' and wins the game.</p></td>
</tr>
<tr class="even">
<td><p>4</p>
<p>3</p>
<p>----</p>
<p>-f-B</p>
<p>--T-</p>
<p>---F</p>
<p>up</p>
<p>up</p>
<p>left</p></td>
<td><p>Player lost!</p>
<p>----</p>
<p>---B</p>
<p>--T-</p>
<p>f--F</p></td>
<td></td>
</tr>
</tbody>
</table>
