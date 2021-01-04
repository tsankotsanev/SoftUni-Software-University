<h1 id="problem-2.-mu-online">Problem 2. Mu Online</h1>
<p>You have <strong>initial health 100 and initial bitcoins 0</strong>. You will be given <strong>a string, representing the dungeons rooms</strong>. Each room is separated with <strong>'|'</strong> (vertical bar): <strong>"room1|room2|room3…"</strong></p>
<p>Each room contains <strong>a command</strong> and a <strong>number</strong>, separated by space. The command can be:</p>
<ul>
<li><p><strong>"potion"</strong></p>
<ul>
<li><p>You are healed with the number in the second part. But your health <strong>cannot exceed</strong> your <strong>initial health (100)</strong>.</p></li>
<li><p>First print: <strong>"You healed for {amount} hp."</strong>.</p></li>
<li><p>After that, print your current health: <strong>"Current health: {health} hp."</strong>.</p></li>
</ul></li>
<li><p><strong>"chest"</strong></p>
<ul>
<li><p>You've found some bitcoins, the number in the second part.</p></li>
<li><p>Print: <strong>"You found {amount} bitcoins."</strong></p></li>
</ul></li>
<li><p>In any other case you are facing a monster, you are going to fight. The second part of the room, contains the attack of the monster. You should remove the monster's attack from your health.</p>
<ul>
<li><p>If you are not dead (health &lt;= 0) you've slain the monster, and you should print (<strong>"You slayed {monster}."</strong>)</p></li>
<li><p>If you've died, print <strong>"You died! Killed by {monster}."</strong> and your quest is over. Print the best room you`ve manage to reach: <strong>"Best room: {room}"</strong>.</p></li>
</ul></li>
</ul>
<p>If you managed to go through all the rooms in the dungeon, print on the next three lines:</p>
<p><strong>"You've made it!"</strong>, <strong>"Bitcoins: {bitcoins}"</strong>, <strong>"Health: {health}"</strong>.</p>
<h3 id="input-constraints">Input / Constraints</h3>
<p>You receive a string, representing the dungeons rooms, separated with <strong>'|'</strong> (vertical bar): <strong>"room1|room2|room3…"</strong>.</p>
<h3 id="output">Output</h3>
<p>Print the corresponding messages, described above.</p>
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
<td>rat 10|bat 20|potion 10|rat 10|chest 100|boss 70|chest 1000</td>
<td><p>You slayed rat.</p>
<p>You slayed bat.</p>
<p>You healed for 10 hp.</p>
<p>Current health: 80 hp.</p>
<p>You slayed rat.</p>
<p>You found 100 bitcoins.</p>
<p>You died! Killed by boss.</p>
<p>Best room: 6</p></td>
</tr>
<tr class="even">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="odd">
<td>cat 10|potion 30|orc 10|chest 10|snake 25|chest 110</td>
<td><p>You slayed cat.</p>
<p>You healed for 10 hp.</p>
<p>Current health: 100 hp.</p>
<p>You slayed orc.</p>
<p>You found 10 bitcoins.</p>
<p>You slayed snake.</p>
<p>You found 110 bitcoins.</p>
<p>You've made it!</p>
<p>Bitcoins: 120</p>
<p>Health: 65</p></td>
</tr>
</tbody>
</table>
