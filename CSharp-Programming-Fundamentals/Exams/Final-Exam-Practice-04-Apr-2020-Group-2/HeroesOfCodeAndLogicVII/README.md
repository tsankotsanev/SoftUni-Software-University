<h1 id="programming-fundamentals-final-exam-04.04.2020">Programming Fundamentals Final Exam 04.04.2020</h1>
<h2 class="list-paragraph" id="problem-3.-heroes-of-code-and-logic-vii">Problem 3. Heroes of Code and Logic VII</h2>
<p><em>You got your hands on the most recent update on the best MMORPG of all time – Heroes of Code and Logic. You want to play it all day long! So cancel all other arrangements and create your party!</em></p>
<p>On the first line of the standard input you will receive an integer <strong>n</strong> – the number of heroes that you can choose for your party. On the next <strong>n</strong> lines, the heroes themselves will follow with their <strong>hit points</strong> and <strong>mana points</strong> separated by empty space in the following format:</p>
<p><strong>{hero name} {HP} {MP}</strong></p>
<ul>
<li><p>where <strong>HP</strong> stands for hit points and <strong>MP</strong> for mana points</p></li>
<li><p>a hero can have a <strong>maximum</strong> of <strong>100 HP</strong> and <strong>200 MP</strong></p></li>
</ul>
<p>After you have successfully picked your heroes, you can start playing the game. You will be receiving different commands, each on a new line, separated by <strong>" – ",</strong> until the <strong>"End"</strong> command is given.</p>
<p>There are several actions that can be performed by the heroes:</p>
<p><strong>CastSpell – {hero name} – {MP needed} – {spell name}</strong></p>
<ul>
<li><p>If the hero has the required MP, he casts the spell, thus reducing his MP. Print this message:</p>
<ul>
<li><p><strong>"</strong>{hero name} has successfully cast {spell name} and now has {mana points left} MP!<strong>"</strong></p></li>
</ul></li>
<li><p>If the hero is unable to cast the spell print:</p>
<ul>
<li><p>"<strong>{hero name} does not have enough MP to cast {spell name}!</strong>"</p></li>
</ul></li>
</ul>
<p><strong>TakeDamage – {hero name} – {damage} – {attacker}</strong></p>
<ul>
<li><p>Reduce the hero HP by the given damage amount. If the hero is still alive (his HP is greater than 0) print:</p>
<ul>
<li><p><strong>"{hero name} was hit for {damage} HP by {attacker} and now has {current HP} HP left!"</strong></p></li>
</ul></li>
<li><p>If the hero has died, remove him from your party and print:</p>
<ul>
<li><p><strong>"{hero name} has been killed by {attacker}!"</strong></p></li>
</ul></li>
</ul>
<p><strong>Recharge – {hero name} – {amount}</strong></p>
<ul>
<li><p>The hero increases his MP. If a command is given that would bring the MP of the hero above <strong>200</strong>, MP is increased so that it reaches the <strong>maximum</strong>. Print the following message:</p>
<ul>
<li><p><strong>"{hero name} recharged for {amount recovered} MP!"</strong></p></li>
</ul></li>
</ul>
<p><strong>Heal – {hero name} – {amount}</strong></p>
<ul>
<li><p>The hero increases his HP. If a command is given that would bring the HP of the hero above <strong>100</strong>, HP is increased so that it reaches the <strong>maximum</strong>. Print the following message:</p>
<ul>
<li><p><strong>"{hero name} healed for {amount recovered} HP!"</strong></p></li>
</ul></li>
</ul>
<h3 id="input">Input</h3>
<ul>
<li><p>On the first line of the standard input you will receive an integer <strong>n</strong></p></li>
<li><p>On the next <strong>n</strong> lines, the heroes themselves will follow with their <strong>hit points</strong> and <strong>mana points</strong> separated by empty space in the following format</p></li>
<li><p>You will be receiving different <strong>commands</strong>, each on a new line, separated by <strong>" – ",</strong> until the <strong>"End"</strong> command is given</p></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>Print all members of your party who are <strong>still alive</strong>, sorted by their <strong>HP in descending order</strong>, then by their <strong>name in ascending order</strong>, in the following format (their HP/MP need to be indented 2 spaces):</p></li>
</ul>
<p><strong>"</strong>{hero name}</p>
<p>HP: {current HP}</p>
<p>MP: {current MP}</p>
<p>...<strong>"</strong></p>
<h3 id="constraints">Constraints</h3>
<ul>
<li><p>The starting HP/MP of the heroes will be valid, 32-bit integers, will never be negative or exceed the respective limits.</p></li>
<li><p>The HP/MP amounts in the commands will never be negative.</p></li>
<li><p>The hero names in the commands will always be valid members of your party. No need to check that explicitly</p></li>
</ul>
<h3 id="examples">Examples</h3>
<table>
<tbody>
<tr class="odd">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="even">
<td><p>2</p>
<p>Solmyr 85 120</p>
<p>Kyrre 99 50</p>
<p>Heal - Solmyr - 10</p>
<p>Recharge - Solmyr - 50</p>
<p>TakeDamage - Kyrre - 66 - Orc</p>
<p>CastSpell - Kyrre - 15 - ViewEarth</p>
<p>End</p></td>
<td><p>Solmyr healed for 10 HP!</p>
<p>Solmyr recharged for 50 MP!</p>
<p>Kyrre was hit for 66 HP by Orc and now has 33 HP left!</p>
<p>Kyrre has successfully cast ViewEarth and now has 35 MP!</p>
<p>Solmyr</p>
<p>HP: 95</p>
<p>MP: 170</p>
<p>Kyrre</p>
<p>HP: 33</p>
<p>MP: 35</p></td>
</tr>
<tr class="odd">
<td><strong>Comments</strong></td>
<td></td>
</tr>
<tr class="even">
<td>These are examples of successful actions. The different colors denote the commands and their respective messages.</td>
<td></td>
</tr>
<tr class="odd">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="even">
<td><p>4</p>
<p>Adela 90 150</p>
<p>SirMullich 70 40</p>
<p>Ivor 1 111</p>
<p>Tyris 94 61</p>
<p>Heal - SirMullich - 50</p>
<p>Recharge - Adela - 100</p>
<p>CastSpell - Tyris - 1000 - Fireball</p>
<p>TakeDamage - Tyris - 99 - Fireball</p>
<p>TakeDamage - Ivor - 3 - Mosquito</p>
<p>End</p></td>
<td><p>SirMullich healed for 30 HP!</p>
<p>Adela recharged for 50 MP!</p>
<p>Tyris does not have enough MP to cast Fireball!</p>
<p>Tyris has been killed by Fireball!</p>
<p>Ivor has been killed by Mosquito!</p>
<p>SirMullich</p>
<p>HP: 100</p>
<p>MP: 40</p>
<p>Adela</p>
<p>HP: 90</p>
<p>MP: 200</p></td>
</tr>
<tr class="odd">
<td><strong>Comments</strong></td>
<td></td>
</tr>
<tr class="even">
<td><p>Heal – SirMullich healed for 30 HP due to the HP max limit.</p>
<p>Recharge – Adela recharged for 50 MP due to the MP max limit.</p>
<p>CastSpell – Tyris does not have enough MP to cast the spell.</p>
<p>TakeDamage – Tyris`s HP is reduced by 99, thus becoming -5, which means that he is dead.</p>
<p>TakeDamage – Ivor`s HP is now -2, so he is dead too.</p>
<p>After the "End" command we print the remaining living heroes, sorted by their HP in reverse order.</p></td>
<td></td>
</tr>
</tbody>
</table>
