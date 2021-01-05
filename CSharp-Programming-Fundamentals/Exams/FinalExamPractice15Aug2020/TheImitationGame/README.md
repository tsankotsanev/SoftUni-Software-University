<h1 id="programming-fundamentals-final-exam-retake-15.08.2020">Programming Fundamentals Final Exam Retake 15.08.2020</h1>
<h2 class="list-paragraph" id="problem-1.-the-imitation-game">Problem 1. The Imitation Game</h2>
<p><em>You are a mathematician during world war 2, who has joined the cryptography team to decipher the enemy's enigma code. Your job is to create a program to crack the codes.</em></p>
<p>On the first line of the input you will receive the <strong>encrypted message</strong>. After that, until the <strong>"Decode"</strong> command is given, <strong>you will be receiving strings</strong> with <strong>instructions</strong> for different <strong>operations</strong> that need to be performed upon the <strong>concealed message</strong> to <strong>interpret</strong> <strong>it</strong> and reveal its true content. There are several types of instructions, split by <strong>'|'</strong></p>
<ul>
<li><p><strong>Move {number of letters}</strong></p>
<ul>
<li><p>Moves the first n letters to the back of the string.</p></li>
</ul></li>
<li><p><strong>Insert {index} {value}</strong></p>
<ul>
<li><p>Inserts the given value before the given index in the string.</p></li>
</ul></li>
<li><p><strong>ChangeAll {substring} {replacement}</strong></p>
<ul>
<li><p>Changes all occurrences of the given substring with the replacement text.</p></li>
</ul></li>
</ul>
<h3 id="input-constraints">Input / Constraints</h3>
<ul>
<li><p>On the first line, you will receive a string with message.</p></li>
<li><p>On the next lines, you will be receiving commands, split by <strong>'|' .</strong></p></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>After the <strong>"Decode"</strong> command is received, print this message:<br />
"<strong>The decrypted message is: {message}</strong>"</p></li>
</ul>
<h3 id="examples">Examples</h3>
<table>
<tbody>
<tr class="odd">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="even">
<td><p>zzHe</p>
<p>ChangeAll|z|l</p>
<p>Insert|2|o</p>
<p>Move|3</p>
<p>Decode</p></td>
<td>The decrypted message is: Hello</td>
</tr>
<tr class="odd">
<td><strong>Comments</strong></td>
<td></td>
</tr>
<tr class="even">
<td><p><strong>ChangeAll|z|l</strong></p>
<p>zzHe → llHe (We replace all occurrences of 'z' with 'l')</p>
<p><strong>Insert|2|o</strong></p>
<p>llHe → lloHe (We add an 'o' before the character on index 2)</p>
<p>Move|3</p>
<p>lloHe → Hello (We take the first three characters and move them to the end of the string)</p>
<p>Finally, after receiving the <strong>"Decode"</strong> command, we print the resulting message.</p></td>
<td></td>
</tr>
<tr class="odd">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="even">
<td><p>owyouh</p>
<p>Move|2</p>
<p>Move|3</p>
<p>Insert|3|are</p>
<p>Insert|9|?</p>
<p>Decode</p></td>
<td>The decrypted message is: howareyou?</td>
</tr>
</tbody>
</table>
<table>
<tbody>
<tr class="odd">
<td><strong>JavaScript Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="even">
<td><p>[</p>
<p>'zzHe',</p>
<p>'ChangeAll|z|l',</p>
<p>'Insert|2|o',</p>
<p>'Move|3',</p>
<p>'Decode'</p>
<p>]</p></td>
<td>The decrypted message is: Hello</td>
</tr>
<tr class="odd">
<td><strong>Comments</strong></td>
<td></td>
</tr>
<tr class="even">
<td><p><strong>ChangeAll|z|l</strong></p>
<p>zzHe → llHe (We replace all occurrences of 'z' with 'l')</p>
<p><strong>Insert|2|o</strong></p>
<p>llHe → lloHe (We add an 'o' before the character on index 2)</p>
<p>Move|3</p>
<p>lloHe → Hello (We take the first three characters and move them to the end of the string)</p>
<p>Finally, after receiving the <strong>"Decode"</strong> command, we print the resulting message.</p></td>
<td></td>
</tr>
<tr class="odd">
<td><strong>JavaScript Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="even">
<td><p>[</p>
<p>'owyouh',</p>
<p>'Move|2',</p>
<p>'Move|3',</p>
<p>'Insert|3|are',</p>
<p>'Insert|9|?'</p>
<p>'Decode'</p>
<p>]</p></td>
<td>The decrypted message is: howareyou?</td>
</tr>
</tbody>
</table>
