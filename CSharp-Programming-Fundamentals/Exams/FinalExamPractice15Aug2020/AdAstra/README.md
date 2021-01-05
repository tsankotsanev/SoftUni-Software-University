<h1 id="programming-fundamentals-final-exam-retake-15.08.2020">Programming Fundamentals Final Exam Retake 15.08.2020</h1>
<h2 class="list-paragraph" id="problem-2.-ad-astra">Problem 2. Ad Astra</h2>
<p><em>You are an astronaut who just embarked on a mission across the solar system. Since you will be in space for a long time, you have packed a lot of food with you. Create a program, which helps you identify how much food you have left and gives you information about its expiration date.</em></p>
<p>On the first line of the input you will be given a <strong>text string</strong>. You must extract the information about the food <strong>and calculate the total calories.</strong></p>
<p>First you must <strong>extract the food info</strong>. It will always follow the same pattern rules:</p>
<ul>
<li><p>It will be surrounded by <strong>"|"</strong> or <strong>"#"</strong> (only one of the two) in the following pattern:<br />
<strong>#{item name}#{expiration date}#{calories}#</strong> or<br />
<strong>|{item name}|{expiration date}|{calories}|</strong></p></li>
<li><p>The item name will contain <strong>only lowercase and uppercase letters and whitespace</strong></p></li>
<li><p>The expiration date will always follow the pattern: <strong>{day}/{month}/{year}, where the day, month and year will be exactly two digits long</strong></p></li>
<li><p>The calories will be <strong>an integer between 0-10000</strong></p></li>
</ul>
<p>Calculate <strong>the total calories of all food items</strong> and then determine <strong>how many days you can last with the food you have</strong>. Keep in mind that <strong>you need 2000kcal a day</strong>.</p>
<h3 id="input-constraints">Input / Constraints</h3>
<ul>
<li><p><strong>You will receive a single string</strong></p></li>
</ul>
<h3 id="output">Output</h3>
<ul>
<li><p>First print <strong>the amount of days</strong> you will be able to last with the food you have:</p></li>
</ul>
<p><strong>"You have food to last you for: {days} days!"</strong></p>
<ul>
<li><p><strong>The output for each food item should look like this:<br />
"Item: {item name}, Best before: {expiration date}, Nutrition: {calories}"</strong></p></li>
</ul>
<h3 id="examples">Examples</h3>
<table>
<tbody>
<tr class="odd">
<td><strong>Input</strong></td>
<td></td>
</tr>
<tr class="even">
<td>#Bread#19/03/21#4000#|Invalid|03/03.20||Apples|08/10/20|200||Carrots|06/08/20|500||Not right|6.8.20|5|</td>
<td></td>
</tr>
<tr class="odd">
<td><strong>Output</strong></td>
<td><strong>Comments</strong></td>
</tr>
<tr class="even">
<td><p>You have food to last you for: 2 days!</p>
<p>Item: Bread, Best before: 19/03/21, Nutrition: 4000</p>
<p>Item: Apples, Best before: 08/10/20, Nutrition: 200</p>
<p>Item: Carrots, Best before: 06/08/20, Nutrition: 500</p></td>
<td><p>We have a total of three matches – bread, apples and carrots.</p>
<p>The sum of their calories is 4700. Since you need 2000kcal a day, we divide 4700/2000, which means this food will last you for 2 days.</p>
<p>We print each item</p></td>
</tr>
<tr class="odd">
<td><strong>Input</strong></td>
<td></td>
</tr>
<tr class="even">
<td>$$#@@%^&amp;#Fish#24/12/20#8500#|#Incorrect#19.03.20#450|$5*(@!#Ice Cream#03/10/21#9000#^#@aswe|Milk|05/09/20|2000|</td>
<td></td>
</tr>
<tr class="odd">
<td><strong>Output</strong></td>
<td><strong>Comments</strong></td>
</tr>
<tr class="even">
<td><p>You have food to last you for: 9 days!</p>
<p>Item: Fish, Best before: 24/12/20, Nutrition: 8500</p>
<p>Item: Ice Cream, Best before: 03/10/21, Nutrition: 9000</p>
<p>Item: Milk, Best before: 05/09/20, Nutrition: 2000</p></td>
<td>We have three matches. The total calories are 8500 + 9000 + 2000 = 19500, which means you have food for a total of 9 days.</td>
</tr>
<tr class="odd">
<td><strong>Input</strong></td>
<td></td>
</tr>
<tr class="even">
<td>Hello|#Invalid food#19/03/20#450|$5*(@</td>
<td></td>
</tr>
<tr class="odd">
<td><strong>Output</strong></td>
<td><strong>Comments</strong></td>
</tr>
<tr class="even">
<td>You have food to last you for: 0 days!</td>
<td>We have no matches, which means we have no food.<br />
The colored text is not a match, since it doesn't have a # at the end.</td>
</tr>
</tbody>
</table>
<table>
<tbody>
<tr class="odd">
<td><strong>JavaScript Input</strong></td>
<td></td>
</tr>
<tr class="even">
<td><p>[</p>
<p>'#Bread#19/03/21#4000#|Invalid|03/03.20||Apples|08/10/20|200||Carrots|06/08/20|500||Not right|6.8.20|5|'</p>
<p>]</p></td>
<td></td>
</tr>
<tr class="odd">
<td><strong>Output</strong></td>
<td><strong>Comments</strong></td>
</tr>
<tr class="even">
<td><p>You have food to last you for: 2 days!</p>
<p>Item: Bread, Best before: 19/03/21, Nutrition: 4000</p>
<p>Item: Apples, Best before: 08/10/20, Nutrition: 200</p>
<p>Item: Carrots, Best before: 06/08/20, Nutrition: 500</p></td>
<td><p>We have a total of three matches – bread, apples and carrots.</p>
<p>The sum of their calories is 4700. Since you need 2000kcal a day, we divide 4700/2000, which means this food will last you for 2 days.</p>
<p>We print each item</p></td>
</tr>
<tr class="odd">
<td><strong>JavaScript Input</strong></td>
<td></td>
</tr>
<tr class="even">
<td>[ '$$#@@%^&amp;#Fish#24/12/20#8500#|#Incorrect#19.03.20#450|$5*(@!#Ice Cream#03/10/21#9000#^#@aswe|Milk|05/09/20|2000|' ]</td>
<td></td>
</tr>
<tr class="odd">
<td><strong>Output</strong></td>
<td><strong>Comments</strong></td>
</tr>
<tr class="even">
<td><p>You have food to last you for: 9 days!</p>
<p>Item: Fish, Best before: 24/12/20, Nutrition: 8500</p>
<p>Item: Ice Cream, Best before: 03/10/21, Nutrition: 9000</p>
<p>Item: Milk, Best before: 05/09/20, Nutrition: 2000</p></td>
<td>We have three matches. The total calories are 8500 + 9000 + 2000 = 19500, which means you have food for a total of 9 days.</td>
</tr>
<tr class="odd">
<td><strong>JavaScript Input</strong></td>
<td></td>
</tr>
<tr class="even">
<td>['Hello|#Invalid food#19/03/20#450|$5*(@' ]</td>
<td></td>
</tr>
<tr class="odd">
<td><strong>Output</strong></td>
<td><strong>Comments</strong></td>
</tr>
<tr class="even">
<td>You have food to last you for: 0 days!</td>
<td>We have no matches, which means we have no food.<br />
The colored text is not a match, since it doesn't have a # at the end.</td>
</tr>
</tbody>
</table>
