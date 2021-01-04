<p><strong>Problem 1. Bonus Scoring System</strong></p>
<p>Create a program that calculates <strong>bonus points</strong> for each <strong>student</strong>, for a certain <strong>course</strong>. On the first line, you are going to receive <strong>the count of the students</strong> for this course. <strong>On the second line</strong>, you will receive <strong>the count of the lectures</strong> in the course. Every course has <strong>an additional bonus</strong>. You are going to receive it <strong>on the third line</strong>. On the next lines, you will be receiving the <strong>count of attendances</strong> <strong>for each student</strong>.</p>
<p>The bonus is calculated with the following <strong>formula</strong>:</p>
<p><strong>{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus})</strong></p>
<p>Find the student with the <strong>maximum bonus</strong> and print him/her, along with <strong>his attendances</strong> in the following format:</p>
<p><strong>"Max Bonus: {maxBonusPoints}."</strong></p>
<p><strong>"The student has attended {studentAttendances} lectures."</strong></p>
<p>Round the bonus points at the end to <strong>the nearest bigger number</strong>.</p>
<h3 id="input-constrains">Input / Constrains</h3>
<ul>
<li><p>On the <strong>first line</strong> you are going to receive the count of the students – an integer number in the range [0…50]</p></li>
<li><p>On the <strong>second line</strong> you are going to receive the count of the lectures – an integer number in the range [0...50].</p></li>
<li><p>On the <strong>third line</strong> you are going to receive <strong>the initial bonus</strong> – an integer number in the range [0….100].</p></li>
<li><p><strong>On the next lines</strong>, you will be receiving the <strong>attendances of each student</strong>.</p></li>
<li><p>There will <strong>never</strong> be <strong>students with equal bonuses</strong>.</p></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>Print the maximum bonus points along with the attendances of the given student, <strong>rounded</strong> to the nearest <strong>bigger</strong> number, scored by a student in this course in the format described above.</p></li>
</ul>
<h3 id="examples">Examples</h3>
<table>
<tbody>
<tr class="odd">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="even">
<td><p>5</p>
<p>25</p>
<p>30</p>
<p>12</p>
<p>19</p>
<p>24</p>
<p>16</p>
<p>20</p></td>
<td><p>Max Bonus: 34.</p>
<p>The student has attended 24 lectures.</p></td>
</tr>
<tr class="odd">
<td><strong>Comments</strong></td>
<td></td>
</tr>
<tr class="even">
<td>First, we receive the <strong>number of students</strong> enrolled in the course – <strong>5</strong>. The total count of the lectures is <strong>25</strong> and the initial bonus is <strong>30</strong>. Then we calculate the bonus of the student with 12 attendances, which is <strong>16.8</strong>. We continue calculating <strong>each of the student’s bonuses</strong>. The one <strong>with 24 attendances</strong> has the <strong>highest bonus – 33.6 (34 rounded)</strong>, so we print the appropriate message on the console.</td>
<td></td>
</tr>
<tr class="odd">
<td><p>10</p>
<p>30</p>
<p>14</p>
<p>8</p>
<p>23</p>
<p>27</p>
<p>28</p>
<p>15</p>
<p>17</p>
<p>25</p>
<p>26</p>
<p>5</p>
<p>18</p></td>
<td><p>Max Bonus: 18.</p>
<p>The student has attended 28 lectures.</p></td>
</tr>
</tbody>
</table>
