<h1 id="exercise-multidimensional-arrays">Exercise: Multidimensional Arrays</h1>
<p>Problems for exercise and homework for the <a href="https://softuni.bg/courses/csharp-advanced"><u>"CSharp Advanced" course @ Software University</u></a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/1455/Multidimensional-Arrays-Exercise">https://judge.softuni.bg/Contests/1455/Multidimensional-Arrays-Exercise</a></p>
<h2 id="diagonal-difference">Diagonal Difference</h2>
<p>Write a program that finds the <strong>difference between the sums of the square matrix diagonals</strong> (absolute value).</p>
<h3 id="input">Input</h3>
<ul>
<li><p>On the <strong>first line</strong>, you are given the integer <strong>N</strong> – the size of the square matrix</p></li>
<li><p>The next <strong>N lines</strong> holds the values for <strong>every row</strong> – <strong>N</strong> numbers separated by a space</p></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>Print <strong>the absolute</strong> difference between <strong>the sums</strong> of the primary and the secondary diagonal</p></li>
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
<td><p>3</p>
<p>11 2 4</p>
<p>4 5 6</p>
<p>10 8 -12</p></td>
<td>15</td>
<td><p><strong>Primary diagonal:</strong> sum = 11 + 5 + (-12) = 4</p>
<p><strong>Secondary diagonal:</strong> sum = 4 + 5 + 10 = 19</p>
<p><strong>Difference:</strong> |4 - 19| = 15</p></td>
</tr>
</tbody>
</table>
<h2 id="x2-squares-in-matrix"> 2X2 Squares in Matrix</h2>
<p>Find the count of <strong>2 x 2 squares of equal chars</strong> in a matrix.</p>
<h3 id="input-1">Input</h3>
<ul>
<li><p>On the <strong>first line</strong>, you are given the integers <strong>rows</strong> and <strong>cols –</strong> the matrix’s dimensions</p></li>
<li><p>Matrix characters come at the next <strong>rows</strong> lines (space separated)</p></li>
</ul>
<h3 id="output-1">Output</h3>
<ul>
<li><p>Print the number of all the squares matrixes you have found</p></li>
</ul>
<h3 id="examples-1">Examples</h3>
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
<td><p>3 4</p>
<p>A B B D</p>
<p>E B B B</p>
<p>I J B B</p></td>
<td>2</td>
<td><p>Two 2 x 2 squares of equal cells:</p>
<p>A <strong>B B</strong> D A B B D</p>
<p>E <strong>B B</strong> B E B <strong>B B</strong></p>
<p>I J B B I J <strong>B B</strong></p></td>
</tr>
<tr class="even">
<td><p>2 2</p>
<p>a b</p>
<p>c d</p></td>
<td>0</td>
<td>No 2 x 2 squares of equal cells exist.</td>
</tr>
</tbody>
</table>
<h2 id="maximal-sum">Maximal Sum</h2>
<p>Write a program that reads a rectangular integer matrix of size <strong>N x M</strong> and finds in it the square <strong>3 x 3</strong> that <strong>has maximal sum of its elements</strong>.</p>
<h3 id="input-2">Input</h3>
<ul>
<li><p>On the first line, you will receive the rows <strong>N</strong> and columns <strong>M</strong>. On the next <strong>N lines</strong> you will receive <strong>each row with its columns</strong></p></li>
</ul>
<h3 id="output-2">Output</h3>
<ul>
<li><p>Print the <strong>elements</strong> of the 3 x 3 square as a matrix, along with their <strong>sum</strong></p></li>
</ul>
<h3 id="examples-2">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Matrix</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>4 5</p>
<p>1 5 5 2 4</p>
<p>2 1 4 14 3</p>
<p>3 7 11 2 8</p>
<p>4 8 12 16 4</p></td>
<td><img src="media/image2.png" style="width:2.05217in;height:1.30972in" /></td>
<td><p>Sum = 75</p>
<p>1 4 14</p>
<p>7 11 2</p>
<p>8 12 16</p></td>
</tr>
</tbody>
</table>
<h2 id="matrix-shuffling">Matrix Shuffling</h2>
<p>Write a program which reads a string matrix from the console and performs certain operations with its elements. User input is provided in a similar way like in the problems above – first you read the <strong>dimensions</strong> and then the <strong>data</strong>.</p>
<p>Your program should then receive commands in format: "<strong>swap row1 col1 row2c col2</strong>" where row1, row2, col1, col2 are <strong>coordinates</strong> in the matrix. In order for a command to be valid, it should start with the "<strong>swap</strong>" keyword along with <strong>four valid coordinates</strong> (no more, no less). You should <strong>swap the values</strong> at the given coordinates (cell [row1, col1] with cell [row2, col2]) <strong>and print the matrix at each step</strong> (thus you'll be able to check if the operation was performed correctly).</p>
<p>If the <strong>command is not valid</strong> (doesn't contain the keyword "swap", has fewer or more coordinates entered or the given coordinates do not exist), print "<strong>Invalid input!</strong>" and move on to the next command. Your program should finish when the string "<strong>END</strong>" is entered.</p>
<h3 id="examples-3">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>2 3</p>
<p>1 2 3</p>
<p>4 5 6</p>
<p>swap 0 0 1 1</p>
<p>swap 10 9 8 7</p>
<p>swap 0 1 1 0</p>
<p>END</p></td>
<td><p>5 2 3</p>
<p>4 1 6</p>
<p>Invalid input!</p>
<p>5 4 3</p>
<p>2 1 6</p></td>
</tr>
<tr class="even">
<td><p>1 2</p>
<p>Hello World</p>
<p>0 0 0 1</p>
<p>swap 0 0 0 1</p>
<p>swap 0 1 0 0</p>
<p>END</p></td>
<td><p>Invalid input!</p>
<p>World Hello</p>
<p>Hello World</p></td>
</tr>
</tbody>
</table>
<h2 id="snake-moves">Snake Moves</h2>
<p>You are walking in the park and you encounter a snake! You are terrified, and you start running zig-zag, so the snake starts following you.</p>
<p>You have a task to visualize the snake’s path in a square form. A <strong>snake</strong> is represented by <strong>a string</strong>. The <strong>isle</strong> is a <strong>rectangular matrix of size NxM</strong>. A snake starts going down from the <strong>top-left corner</strong> and slithers its way down. The first cell is filled with the first symbol of the snake, the second cell is filled with the second symbol, etc. The snake is as long as it takes in order to <strong>fill the stairs completely</strong> – if you reach the end of the string representing the snake, start again at the beginning. After you fill the matrix with the snake’s path, you should print it.</p>
<h3 id="input-3">Input</h3>
<ul>
<li><p>The input data should be read from the console. It consists of exactly two lines</p></li>
<li><p>On the first line, you’ll receive the <strong>dimensions</strong> of the stairs in format: <strong>"N M"</strong>, where <strong>N</strong> is the number of <strong>rows</strong>, and <strong>M</strong> is the number of <strong>columns</strong>. They’ll be separated by a single space</p></li>
<li><p>On the second line you’ll receive the string representing the <strong>snake</strong></p></li>
</ul>
<h3 id="output-3">Output</h3>
<ul>
<li><p>The output should be printed on the console. It should consist of <strong>N lines</strong></p></li>
<li><p>Each line should contain a string representing the respective row of the matrix</p></li>
</ul>
<h3 id="constraints">Constraints</h3>
<ul>
<li><p>The <strong>dimensions</strong> N and M of the matrix will be integers in the range [1 … 12]</p></li>
<li><p>The <strong>snake</strong> will be a string with length in the range [1 … 20] and <strong>will not contain any whitespace characters</strong></p></li>
</ul>
<h3 id="examples-4">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>5 6</p>
<p>SoftUni</p></td>
<td><p>SoftUn</p>
<p>UtfoSi</p>
<p>niSoft</p>
<p>foSinU</p>
<p>tUniSo</p></td>
</tr>
</tbody>
</table>
<h2 id="jagged-array-manipulator">Jagged Array Manipulator</h2>
<p>Create a program that populates, analyzes and manipulates the elements of a matrix with unequal length of its rows.</p>
<p>First you will receive an <strong>integer N</strong> equal to the <strong>number of rows</strong> in your matrix.</p>
<p>On the <strong>next N lines</strong>, you will receive <strong>sequences of integers</strong>, <strong>separated</strong> by a single <strong>space</strong>. Each sequence is a <strong>row</strong> in the matrix.</p>
<p>After populating the matrix, start analyzing it. If a <strong>row</strong> and the <strong>one below</strong> it have <strong>equal length</strong>, <strong>multiply</strong> each <strong>element</strong> in <strong>both</strong> of them by <strong>2</strong>, <strong>otherwise</strong> - <strong>divide</strong> by <strong>2</strong>.</p>
<p>Then, you will receive commands. There are three possible commands:</p>
<ul>
<li><p>"<strong>Add {row} {column} {value}</strong>" - <strong>add</strong> <strong>{value}</strong> to the element at the <strong>given indexes</strong>, if they are <strong>valid</strong></p></li>
<li><p>"<strong>Subtract {row} {column} {value}</strong>" - <strong>subtract</strong> <strong>{value}</strong> from the element at the <strong>given indexes</strong>, if they are <strong>valid</strong></p></li>
<li><p>"<strong>End</strong>" - print the <strong>final state</strong> of the <strong>matrix</strong> (all elements <strong>separated by a single space</strong>) and <strong>stop</strong> the program</p></li>
</ul>
<p><strong>Input</strong></p>
<ul>
<li><p>On the first line, you will receive the <strong>number of rows</strong> of the matrix - integer <strong>N</strong></p></li>
<li><p>On the next <strong>N</strong> lines, you will receive <strong>each row</strong> - <strong>sequence of integers</strong>, separated by a single <strong>space</strong></p></li>
<li><p><strong>{value}</strong> will always be <strong>integer</strong> number</p></li>
<li><p>Then you will be receiving commands until reading "<strong>End</strong>"</p></li>
</ul>
<p><strong>Output</strong></p>
<ul>
<li><p>The output should be printed on the console and it should consist of <strong>N lines</strong></p></li>
<li><p>Each line should contain a string representing the <strong>respective row</strong> of the <strong>final matrix</strong>, elements <strong>separated</strong> by a single <strong>space</strong></p></li>
</ul>
<p><strong>Constraints</strong></p>
<ul>
<li><p>The <strong>number of rows</strong> N of the matrix will be integer in the range [2 … 12]</p></li>
<li><p>The <strong>input</strong> will always <strong>follow</strong> the <strong>format above</strong></p></li>
<li><p><strong>Think about data types<br />
</strong></p></li>
</ul>
<h3 id="examples-5">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>5</p>
<p>10 20 30</p>
<p>1 2 3</p>
<p>2</p>
<p>2</p>
<p>10 10</p>
<p>End</p></td>
<td>20 40 60<br />
1 2 3<br />
2<br />
2<br />
5 5</td>
</tr>
<tr class="even">
<td><p>5</p>
<p>10 20 30</p>
<p>1 2 3</p>
<p>2</p>
<p>2</p>
<p>10 10</p>
<p>Add 0 10 10</p>
<p>Add 0 0 10</p>
<p>Subtract -3 0 10</p>
<p>Subtract 3 0 10</p>
<p>End</p></td>
<td><p>30 40 60</p>
<p>1 2 3</p>
<p>2</p>
<p>-8</p>
<p>5 5</p></td>
</tr>
</tbody>
</table>
<h2 id="knight-game">Knight Game</h2>
<p>Chess is the oldest game, but it is still popular these days. For this task we will use only one chess piece – the <strong>Knight</strong>.</p>
<p>The knight moves to the <strong>nearest</strong> square but <strong>not on the same <a href="https://en.wikipedia.org/wiki/Glossary_of_chess#rank">row</a></strong>, <a href="https://en.wikipedia.org/wiki/Glossary_of_chess#file"><strong>column</strong></a>, or <a href="https://en.wikipedia.org/wiki/Glossary_of_chess#diagonal"><strong>diagonal</strong></a>. (This can be thought of as moving two squares horizontally, then one square vertically, or moving one square horizontally then two squares vertically— i.e. in an "<strong>L</strong>" pattern.) </p>
<p>The knight game is played on a board with dimensions <strong>N x N</strong> and a lot of chess knights <strong>0 &lt;= K &lt;= N<sup>2</sup></strong>.</p>
<p>You will receive a board with <strong>K</strong> for knights and '<strong>0'</strong> for empty cells. Your task is to remove a minimum of the knights, so there will be no knights left that can attack another knight.</p>
<h3 id="input-4">Input</h3>
<p>On the first line, you will receive the <strong>N</strong> size of the board</p>
<p>On the next <strong>N</strong> lines, you will receive strings with <strong>Ks</strong> and <strong>0s</strong>.</p>
<h3 id="output-4">Output</h3>
<p>Print a single integer with the minimum number of knights that needs to be removed</p>
<h3 id="constraints-1">Constraints</h3>
<ul>
<li><p>Size of the board will be 0 &lt; N &lt; 30</p></li>
<li><p>Time limit: 0.3 sec. Memory limit: 16 MB.</p></li>
</ul>
<h3 id="examples-6">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>5</p>
<p>0K0K0</p>
<p>K000K</p>
<p>00K00</p>
<p>K000K</p>
<p>0K0K0</p></td>
<td>1</td>
</tr>
<tr class="even">
<td><p>2</p>
<p>KK</p>
<p>KK</p></td>
<td>0</td>
</tr>
<tr class="odd">
<td><p>8</p>
<p>0K0KKK00</p>
<p>0K00KKKK</p>
<p>00K0000K</p>
<p>KKKKKK0K</p>
<p>K0K0000K</p>
<p>KK00000K</p>
<p>00K0K000</p>
<p>000K00KK</p></td>
<td>12</td>
</tr>
</tbody>
</table>
<h2 id="bombs">*Bombs</h2>
<p>You will be given a square matrix of integers, each integer separated by a <strong>single space</strong>, and each row on a new line. Then on the last line of input you will receive indexes - coordinates to several cells separated by a <strong>single space</strong>, in the following format: <strong>row1,column1 row2,column2 row3,column3…</strong></p>
<p>On those cells there are bombs. You have to proceed <strong>every</strong> <strong>bomb</strong>, one by one in the order they were given. When a bomb explodes deals damage <strong>equal</strong> to its <strong>own</strong> <strong>integer</strong> <strong>value</strong>, to <strong>all</strong> the cells <strong>around</strong> it (in every direction and in all diagonals). One bomb can't explode more than once and after it does, its value becomes <strong>0</strong>. When a cell’s value reaches <strong>0 or below</strong>, <strong>it dies</strong>. Dead cells <strong>can't explode</strong>.</p>
<p>You must <strong>print the count of all alive cells</strong> and <strong>their sum</strong>. Afterwards, print the matrix with all of its cells (including the dead ones).</p>
<h3 id="input-5">Input</h3>
<ul>
<li><blockquote>
<p>On the first line, you are given the integer N – the size of the square matrix.</p>
</blockquote></li>
<li><blockquote>
<p>The next N lines holds the values for every row – N numbers separated by a space.</p>
</blockquote></li>
<li><blockquote>
<p>On the last line you will receive the coordinates of the cells with the bombs in the format described above.</p>
</blockquote></li>
</ul>
<h3 id="output-5">Output</h3>
<ul>
<li><blockquote>
<p>On the first line you need to print the count of all alive cells in the format:</p>
</blockquote></li>
</ul>
<blockquote>
<p>“<strong>Alive cells: {aliveCells}</strong>”</p>
</blockquote>
<ul>
<li><blockquote>
<p>On the second line you need to print the sum of all alive cell in the format:</p>
</blockquote></li>
</ul>
<blockquote>
<p>“<strong>Sum: {sumOfCells}</strong>”</p>
</blockquote>
<ul>
<li><blockquote>
<p>In the end print the matrix. The cells must be <strong>separated by a single space</strong>.</p>
</blockquote></li>
</ul>
<h3 id="constraints-2">Constraints</h3>
<ul>
<li><p>The size of the matrix will be between <strong>[0…1000].</strong></p></li>
<li><p>The bomb coordinates will <strong>always</strong> be in the matrix.</p></li>
<li><p>The bomb’s values will always be <strong>greater</strong> than <strong>0</strong>.</p></li>
<li><p>The integers of the matrix will be in range <strong>[1…10000].</strong></p></li>
</ul>
<h3 id="examples-7">Examples</h3>
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
<td><p>4</p>
<p>8 3 2 5</p>
<p>6 4 7 9</p>
<p>9 9 3 6</p>
<p>6 8 1 2</p>
<p>1,2 2,1 2,0</p></td>
<td><p>Alive cells: 3</p>
<p>Sum: 12</p>
<p>8 -4 -5 -2</p>
<p>-3 -3 0 2</p>
<p>0 0 -4 -1</p>
<p>-3 -1 -1 2</p></td>
<td>First the bomb with value <strong>7</strong> will explode and reduce the values of the cells around it. Next the bomb with coordinates <strong>2,1</strong> and value <strong>2</strong> (initially 9-7) will explode and reduce its neighbour cells. In the end the bomb with coordinates <strong>2,0</strong> and value <strong>7</strong> (initially 9-2) will explode. After that you have to print the count of the alive cells, which is 3, and their sum is 12. Print the matrix after the explosions.</td>
</tr>
<tr class="even">
<td><p>3</p>
<p>7 8 4</p>
<p>3 1 5</p>
<p>6 4 9</p>
<p>0,2 1,0 2,2</p></td>
<td><p>Alive cells: 3</p>
<p>Sum: 8</p>
<p>4 1 0</p>
<p>0 -3 -8</p>
<p>3 -8 0</p></td>
<td></td>
</tr>
</tbody>
</table>
<h2 id="miner">*Miner</h2>
<p>We get as input <strong>the size</strong> of the <strong>field</strong> in which our miner moves. The field is <strong>always a square</strong>. After that we will receive the commands which represent the directions in which the miner should move. The miner <strong>starts</strong> from position – ‘<strong>s’</strong>. The commands will be: <strong>left</strong>, <strong>right</strong>, <strong>up</strong> and <strong>down</strong>. If the miner has reached a side edge of the field and the next command indicates that he has to get out of the field, he must <strong>remain on his current possition and ignore the current command</strong>. The possible characters that may appear on the screen are:</p>
<ul>
<li><p><strong>*</strong> – a regular position on the field.</p></li>
<li><p><strong>e</strong> – the end of the route.</p></li>
<li><p><strong>c -</strong> coal</p></li>
<li><p><strong>s</strong> - the place where the <strong>miner starts</strong></p></li>
</ul>
<p>Each time when the miner finds a coal, he collects it and <strong>replaces it with '*'</strong>. Keep track of the <strong>count of the collected coals</strong>. If the miner collects all of the coals in the field, the program stops and you have to print the following message: <strong>"You collected all coals! ({rowIndex}, {colIndex})"</strong>.</p>
<p>If the miner <strong>steps at 'e' the game is over (the program stops)</strong> and you have to print the following message: <strong>"Game over! ({rowIndex}, {colIndex})"</strong>.</p>
<p>If there are no more commands and none of the above cases had happened, you have to print the following message: <strong>"{remainingCoals} coals left. ({rowIndex}, {colIndex})"</strong>.</p>
<h3 id="input-6">Input</h3>
<ul>
<li><p><strong>Field size</strong> – an integer number.</p></li>
<li><p><strong>Commands to move</strong> the miner – an array of strings separated by <strong>" "</strong>.</p></li>
<li><p><strong>The field: some of the following characters (*, e, c, s),</strong> separated by whitespace (" ");</p></li>
</ul>
<h3 id="output-6">Output</h3>
<ul>
<li><p>There are three types of output:</p>
<ul>
<li><p>If all the coals have been collected, print the following output: <strong>"You collected all coals! ({rowIndex}, {colIndex})"</strong></p></li>
<li><p>If you have reached the end, you have to stop moving and print the following line: <strong>"Game over! ({rowIndex}, {colIndex})"</strong></p></li>
<li><p>If there are no more commands and none of the above cases had happened, you have to print the following message: <strong>"{totalCoals} coals left. ({rowIndex}, {colIndex})"</strong></p></li>
</ul></li>
</ul>
<h3 id="constraints-3">Constraints</h3>
<ul>
<li><p>The <strong>field size</strong> will be a 32-bit integer in the range [0 … 2 147 483 647].</p></li>
<li><p>The field will always have only one’s’.</p></li>
<li><p>Allowed working time for your program: 0.1 seconds.</p></li>
<li><p>Allowed memory: 16 MB.</p></li>
</ul>
<h3 id="examples-8">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>5</p>
<p>up right right up right</p>
<p>* * * c *</p>
<p>* * * e *</p>
<p>* * c * *</p>
<p>s * * c *</p>
<p>* * c * *</p></td>
<td>Game over! (1, 3)</td>
</tr>
<tr class="even">
<td><p>4</p>
<p>up right right right down</p>
<p>* * * e</p>
<p>* * c *</p>
<p>* s * c</p>
<p>* * * *</p></td>
<td>You collected all coals! (2, 3)</td>
</tr>
<tr class="odd">
<td><p>6</p>
<p>left left down right up left left down down down</p>
<p>* * * * * *</p>
<p>e * * * c *</p>
<p>* * c s * *</p>
<p>* * * * * *</p>
<p>c * * * c *</p>
<p>* * c * * *</p></td>
<td><ol start="3" type="1">
<li><p>coals left. (5, 0)</p></li>
</ol></td>
</tr>
</tbody>
</table>
<h2 class="list-paragraph" id="radioactive-mutant-vampire-bunnies">10. *Radioactive Mutant Vampire Bunnies</h2>
<p>Browsing through GitHub, you come across an old JS Basics teamwork game. It is about very nasty bunnies that multiply extremely fast. There’s also a player that has to escape from their lair. You really like the game, so you decide to port it to C# because that’s your language of choice. The last thing that is left is the algorithm that decides if the player will escape the lair or not.</p>
<p>First, you will receive a line holding integers <strong>N</strong> and <strong>M</strong>, which represent the rows and columns in the lair. Then you receive <strong>N</strong> strings that can <strong>only</strong> consist of <strong>“.”</strong>, <strong>“B”</strong>, <strong>“P”</strong>. The <strong>bunnies</strong> are marked with “<strong>B”,</strong> the <strong>player</strong> is marked with “<strong>P</strong>”, and <strong>everything</strong> else is free space, marked with a dot <strong>“.”</strong>. They represent the initial state of the lair. There will be <strong>only</strong> one player. Then you will receive a string with <strong>commands</strong> such as <strong>LLRRUUDD</strong> – where each letter represents the next <strong>move</strong> of the player (Left, Right, Up, Down).</p>
<p><strong>After</strong> each step of the player, each of the bunnies spread to the up, down, left and right (neighboring cells marked as “.” <strong>changes</strong> their value to B). If the player <strong>moves</strong> to a bunny cell or a bunny <strong>reaches</strong> the player, the player has died. If the player goes <strong>out</strong> of the lair <strong>without</strong> encountering a bunny, the player has won.</p>
<p>When the player <strong>dies</strong> or <strong>wins</strong>, the game ends. All the activities for <strong>this</strong> turn continue (e.g. all the bunnies spread normally), but there are no more turns. There will be <strong>no</strong> stalemates where the moves of the player end before he dies or escapes.</p>
<p>Finally, print the final state of the lair with every row on a separate line. On the last line, print either <strong>“dead: {row} {col}”</strong> or <strong>“won: {row} {col}”</strong>. Row and col are the coordinates of the cell where the player has died or the last cell he has been in before escaping the lair.</p>
<h3 id="input-7">Input</h3>
<ul>
<li><p>On the first line of input, the numbers <strong>N</strong> and <strong>M</strong> are received – the number of <strong>rows</strong> and <strong>columns</strong> in the lair</p></li>
<li><p>On the next N lines, each row is received in the form of a string. The string will contain only “.”, “B”, “P”. All strings will be the same length. There will be only one “P” for all the input</p></li>
<li><p>On the last line, the directions are received in the form of a string, containing “R”, “L”, “U”, “D”</p></li>
</ul>
<h3 id="output-7">Output</h3>
<ul>
<li><p>On the first N lines, print the final state of the bunny lair</p></li>
<li><p>On the last line, print the outcome – “won:” or “dead:” + {row} {col}</p></li>
</ul>
<h3 id="constraints-4">Constraints</h3>
<ul>
<li><p>The dimensions of the lair are in range [3…20]</p></li>
<li><p>The directions string length is in range [1…20]</p></li>
</ul>
<h3 id="examples-9">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>5 8</p>
<p>.......B</p>
<p>...B....</p>
<p>....B..B</p>
<p>........</p>
<p>..P.....</p>
<p>ULLL</p></td>
<td><p>BBBBBBBB</p>
<p>BBBBBBBB</p>
<p>BBBBBBBB</p>
<p>.BBBBBBB</p>
<p>..BBBBBB</p>
<p>won: 3 0</p></td>
</tr>
<tr class="even">
<td><p>4 5</p>
<p>.....</p>
<p>.....</p>
<p>.B...</p>
<p>...P.</p>
<p>LLLLLLLL</p></td>
<td><p>.B...</p>
<p>BBB..</p>
<p>BBBB.</p>
<p>BBB..</p>
<p>dead: 3 1</p></td>
</tr>
</tbody>
</table>
