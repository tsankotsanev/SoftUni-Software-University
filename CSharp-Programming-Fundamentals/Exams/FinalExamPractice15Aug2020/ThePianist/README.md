<h1 id="programming-fundamentals-final-exam-retake-15.08.2020">Programming Fundamentals Final Exam Retake 15.08.2020</h1>
<h2 class="list-paragraph" id="problem-3.-the-pianist">Problem 3. The Pianist</h2>
<p><em>You are a pianist and you like to keep a list of your favorite piano pieces. Create a program, to help you organize it and add, change, remove pieces from it!</em></p>
<p>On the first line of the standard input you will receive an integer <strong>n</strong> – the <strong>number of pieces</strong> that you will initially have. On the next <strong>n</strong> lines the <strong>pieces themselves</strong> will follow with their <strong>composer</strong> and <strong>key</strong>, separated by <strong>"|"</strong> in the following format:</p>
<p><strong>{piece}|{composer}|{key}</strong></p>
<p>Then, you will be receiving different <strong>commands</strong>, each on a new line, separated by <strong>"|",</strong> until the <strong>"Stop"</strong> command is given:</p>
<ul>
<li><p><strong>Add|{piece}|{composer}|{key}</strong></p>
<ul>
<li><p>You need to <strong>add the given piece</strong> with the information about it to the other pieces</p></li>
<li><p>If the piece <strong>is already in the collection</strong>, print:</p></li>
</ul></li>
</ul>
<blockquote>
<p>"<strong>{piece} is already in the collection!</strong>"</p>
</blockquote>
<ul>
<li><p>If the piece is <strong>not in the collection</strong>, print:<br />
"<strong>{piece} by {composer} in {key} added to the collection!"</strong></p></li>
</ul>
<ul>
<li><p><strong>Remove|{piece}</strong></p>
<ul>
<li><p>If the piece is in the collection, <strong>remove it</strong> and print:</p></li>
</ul></li>
</ul>
<blockquote>
<p><strong>"Successfully removed {piece}!"</strong></p>
</blockquote>
<ul>
<li><p>If the piece is <strong>not in the collection</strong>, print:</p></li>
</ul>
<blockquote>
<p><strong>"Invalid operation! {piece} does not exist in the collection."</strong></p>
</blockquote>
<ul>
<li><p><strong>ChangeKey|{piece}|{new key}</strong></p>
<ul>
<li><p>If the piece is in the collection, <strong>change its key with the given one</strong> and print:</p></li>
</ul></li>
</ul>
<blockquote>
<p><strong>"Changed the key of {piece} to {new key}!"</strong></p>
</blockquote>
<ul>
<li><p>If the piece is <strong>not in the collection</strong>, print:</p></li>
</ul>
<blockquote>
<p><strong>"Invalid operation! {piece} does not exist in the collection."</strong></p>
</blockquote>
<p>Upon receiving the <strong>"Stop"</strong> command you need to print all pieces in your collection, sorted by their <strong>name and by the name of their composer in alphabetical order</strong>, in the following format:<br />
"<strong>{Piece} -&gt; Composer: {composer}, Key: {key}</strong>"</p>
<h3 id="inputconstraints">Input/Constraints</h3>
<ul>
<li><p>You will receive <strong>a single integer</strong> at first – <strong>the initial number of pieces in the collection</strong></p></li>
<li><p>For each piece you will receive a single line of text with information about it.</p></li>
<li><p>Then you will receive multiple commands in the way described above, until the command "Stop".</p></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>All the output messages with the appropriate formats are described in the problem description.</p></li>
</ul>
<h3 id="examples">Examples</h3>
<table>
<tbody>
<tr class="odd">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="even">
<td><p>3</p>
<p>Fur Elise|Beethoven|A Minor</p>
<p>Moonlight Sonata|Beethoven|C# Minor</p>
<p>Clair de Lune|Debussy|C# Minor</p>
<p>Add|Sonata No.2|Chopin|B Minor</p>
<p>Add|Hungarian Rhapsody No.2|Liszt|C# Minor</p>
<p>Add|Fur Elise|Beethoven|C# Minor</p>
<p>Remove|Clair de Lune</p>
<p>ChangeKey|Moonlight Sonata|C# Major</p>
<p>Stop</p></td>
<td><p>Sonata No.2 by Chopin in B Minor added to the collection!</p>
<p>Hungarian Rhapsody No.2 by Liszt in C# Minor added to the collection!</p>
<p>Fur Elise is already in the collection!</p>
<p>Successfully removed Clair de Lune!</p>
<p>Changed the key of Moonlight Sonata to C# Major!</p>
<p>Fur Elise -&gt; Composer: Beethoven, Key: A Minor</p>
<p>Hungarian Rhapsody No.2 -&gt; Composer: Liszt, Key: C# Minor</p>
<p>Moonlight Sonata -&gt; Composer: Beethoven, Key: C# Major</p>
<p>Sonata No.2 -&gt; Composer: Chopin, Key: B Minor</p></td>
</tr>
<tr class="odd">
<td><strong>Comments</strong></td>
<td></td>
</tr>
<tr class="even">
<td>After we receive the initial pieces with their info, we start receiving commands. The first two commands are to add a piece to the collection and since the pieces are not already added, we manage to add them. The third add command, however, <strong>attempts to add a piece, which is already in the collection</strong>, so we print a special message and don't add the piece. After that we receive the remove command and since the piece is in the collection, we remove it successfully.<br />
Finally, the last command says to change the key of a piece. Since the key is present in the collection, we modify its key.<br />
We receive the Stop command, print the information about the pieces, sorted in the way described above, and the program ends.</td>
<td></td>
</tr>
<tr class="odd">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="even">
<td><p>4</p>
<p>Eine kleine Nachtmusik|Mozart|G Major</p>
<p>La Campanella|Liszt|G# Minor</p>
<p>The Marriage of Figaro|Mozart|G Major</p>
<p>Hungarian Dance No.5|Brahms|G Minor</p>
<p>Add|Spring|Vivaldi|E Major</p>
<p>Remove|The Marriage of Figaro</p>
<p>Remove|Turkish March</p>
<p>ChangeKey|Spring|C Major</p>
<p>Add|Nocturne|Chopin|C# Minor</p>
<p>Stop</p></td>
<td><p>Spring by Vivaldi in E Major added to the collection!</p>
<p>Successfully removed The Marriage of Figaro!</p>
<p>Invalid operation! Turkish March does not exist in the collection.</p>
<p>Changed the key of Spring to C Major!</p>
<p>Nocturne by Chopin in C# Minor added to the collection!</p>
<p>Eine kleine Nachtmusik -&gt; Composer: Mozart, Key: G Major</p>
<p>Hungarian Dance No.5 -&gt; Composer: Brahms, Key: G Minor</p>
<p>La Campanella -&gt; Composer: Liszt, Key: G# Minor</p>
<p>Nocturne -&gt; Composer: Chopin, Key: C# Minor</p>
<p>Spring -&gt; Composer: Vivaldi, Key: C Major</p></td>
</tr>
</tbody>
</table>
<p><em>Suggestion: Choose a piece from the ones here to listen while you are doing the problem!</em></p>
<table>
<tbody>
<tr class="odd">
<td><strong>JavaScript Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="even">
<td><p>[</p>
<p>'3',</p>
<p>'Fur Elise|Beethoven|A Minor',</p>
<p>'Moonlight Sonata|Beethoven|C# Minor',</p>
<p>'Clair de Lune|Debussy|C# Minor',</p>
<p>'Add|Sonata No.2|Chopin|B Minor',</p>
<p>'Add|Hungarian Rhapsody No.2|Liszt|C# Minor',</p>
<p>'Add|Fur Elise|Beethoven|C# Minor',</p>
<p>'Remove|Clair de Lune',</p>
<p>'ChangeKey|Moonlight Sonata|C# Major',</p>
<p>'Stop'</p>
<p>]</p></td>
<td><p>Sonata No.2 by Chopin in B Minor added to the collection!</p>
<p>Hungarian Rhapsody No.2 by Liszt in C# Minor added to the collection!</p>
<p>Fur Elise is already in the collection!</p>
<p>Successfully removed Clair de Lune!</p>
<p>Changed the key of Moonlight Sonata to C# Major!</p>
<p>Fur Elise -&gt; Composer: Beethoven, Key: A Minor</p>
<p>Hungarian Rhapsody No.2 -&gt; Composer: Liszt, Key: C# Minor</p>
<p>Moonlight Sonata -&gt; Composer: Beethoven, Key: C# Major</p>
<p>Sonata No.2 -&gt; Composer: Chopin, Key: B Minor</p></td>
</tr>
<tr class="odd">
<td><strong>Comments</strong></td>
<td></td>
</tr>
<tr class="even">
<td>After we receive the initial pieces with their info, we start receiving commands. The first two commands are to add a piece to the collection and since the pieces are not already added, we manage to add them. The third add command, however, <strong>attempts to add a piece, which is already in the collection</strong>, so we print a special message and don't add the piece. After that we receive the remove command and since the piece is in the collection, we remove it successfully.<br />
<br />
Finally, the last command says to change the key of a piece. Since the key is present in the collection, we modify its key.<br />
<br />
We receive the Stop command, print the information about the pieces, sorted in the way described above, and the program ends.</td>
<td></td>
</tr>
<tr class="odd">
<td><strong>JavaScript Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="even">
<td><p>[</p>
<p>'4',</p>
<p>'Eine kleine Nachtmusik|Mozart|G Major',</p>
<p>'La Campanella|Liszt|G# Minor',</p>
<p>'The Marriage of Figaro|Mozart|G Major',</p>
<p>'Hungarian Dance No.5|Brahms|G Minor',</p>
<p>'Add|Spring|Vivaldi|E Major',</p>
<p>'Remove|The Marriage of Figaro',</p>
<p>'Remove|Turkish March',</p>
<p>'ChangeKey|Spring|C Major',</p>
<p>'Add|Nocturne|Chopin|C# Minor',</p>
<p>'Stop'</p>
<p>]</p></td>
<td><p>Spring by Vivaldi in E Major added to the collection!</p>
<p>Successfully removed The Marriage of Figaro!</p>
<p>Invalid operation! Turkish March does not exist in the collection.</p>
<p>Changed the key of Spring to C Major!</p>
<p>Nocturne by Chopin in C# Minor added to the collection!</p>
<p>Eine kleine Nachtmusik -&gt; Composer: Mozart, Key: G Major</p>
<p>Hungarian Dance No.5 -&gt; Composer: Brahms, Key: G Minor</p>
<p>La Campanella -&gt; Composer: Liszt, Key: G# Minor</p>
<p>Nocturne -&gt; Composer: Chopin, Key: C# Minor</p>
<p>Spring -&gt; Composer: Vivaldi, Key: C Major</p></td>
</tr>
</tbody>
</table>
