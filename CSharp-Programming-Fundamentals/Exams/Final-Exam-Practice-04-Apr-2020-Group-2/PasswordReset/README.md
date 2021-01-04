<h1 id="programming-fundamentals-final-exam-04.04.2020">Programming Fundamentals Final Exam 04.04.2020</h1>
<h2 class="list-paragraph" id="problem-1.-password-reset">Problem 1. Password Reset</h2>
<p><em>Yet again you have forgotten your password... Naturally it`s not the first time this has happened. Actually you got so tired of it that you decided to help yourself with a smart solution.</em></p>
<p>Write a password reset program that performs a series of commands upon a predefined string. First, you will receive a string and afterwards, until the command "<strong>Done</strong>" is given, you will be receiving strings with commands split by a single space. The commands will be the following:</p>
<ul>
<li><p><strong>TakeOdd</strong></p>
<ul>
<li><p>Takes only the characters at <strong>odd</strong> <strong>indices</strong> and <strong>concatenates</strong> them together to<br />
obtain the <strong>new raw password</strong> and then <strong>prints</strong> it.</p></li>
</ul></li>
<li><p><strong>Cut {index} {length}</strong></p>
<ul>
<li><p>Gets the substring with the <strong>given length</strong> starting from the <strong>given index</strong> from the password and removes its first occurrence of it, then prints the password on the console.</p></li>
<li><p>The given index and length will <strong>always</strong> be <strong>valid</strong>.</p></li>
</ul></li>
<li><p><strong>Substitute {substring} {substitute}</strong></p>
<ul>
<li><p>If the raw password contains the given substring, replaces all of its<br />
occurrences with the substitute text given and prints the result.</p></li>
<li><p>If it doesn’t, prints <strong>"Nothing to replace!"</strong></p></li>
</ul></li>
</ul>
<h3 id="input">Input</h3>
<ul>
<li><p>You will be receiving strings until the "<strong>Done</strong>" command is given.</p></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>After the <strong>"Done"</strong> command is received, print:</p>
<ul>
<li><p><strong>"Your password is: {password}"</strong></p></li>
</ul></li>
</ul>
<h3 id="constraints">Constraints</h3>
<ul>
<li><p>The indexes from the "<strong>Cut {index} {length}</strong>" command will always be valid.</p></li>
</ul>
<h3 id="examples">Examples</h3>
<table>
<tbody>
<tr class="odd">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="even">
<td><p>Siiceercaroetavm!:?:ahsott.:i:nstupmomceqr</p>
<p>TakeOdd</p>
<p>Cut 15 3</p>
<p>Substitute :: -</p>
<p>Substitute | ^</p>
<p>Done</p></td>
<td><p>icecream::hot::summer</p>
<p>icecream::hot::mer</p>
<p>icecream-hot-mer</p>
<p>Nothing to replace!</p>
<p>Your password is: icecream-hot-mer</p></td>
</tr>
<tr class="odd">
<td><strong>Comments</strong></td>
<td></td>
</tr>
<tr class="even">
<td><p><strong>TakeOdd</strong></p>
<p>Siiceercaroetavm!:?:ahsott.:i:nstupmomceqr -&gt; icecream::hot::summer</p>
<p>We only take the chars at odd indices 1, 3, 5 etc.</p>
<p><strong>Cut 15 3 -&gt;</strong> icecream::hot::summer -&gt; sum</p>
<p>icecream::hot::mer</p>
<p>We cut a substring starting at index 15 with length 3,</p>
<p>remove it from the raw password and print it.</p>
<p>Then, on a new line we print the resulting new raw password.</p>
<p><strong>Substitute :: - -&gt;</strong> icecream::hot::summer -&gt; icream-hot-summer</p>
<p>We replace <strong>"</strong>::<strong>"</strong> with <strong>"</strong>-<strong>"</strong>.</p>
<p><strong>Substitute</strong> | ^ <strong>-&gt;</strong> Nothing to replace!</p>
<p><strong>"</strong>|<strong>"</strong> is not found anywhere in the raw password.</p>
<p>Finally, after receiving the <strong>"Done"</strong> command, we print the resulting password in the proper format.</p></td>
<td></td>
</tr>
<tr class="odd">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="even">
<td><p>up8rgoyg3r1atmlmpiunagt!-irs7!1fgulnnnqy</p>
<p>TakeOdd</p>
<p>Cut 18 2</p>
<p>Substitute ! ***</p>
<p>Substitute ? .!.</p>
<p>Done</p></td>
<td><p>programming!is!funny</p>
<p>programming!is!fun</p>
<p>programming***is***fun</p>
<p>Nothing to replace!</p>
<p>Your password is: programming***is***fun</p></td>
</tr>
</tbody>
</table>
