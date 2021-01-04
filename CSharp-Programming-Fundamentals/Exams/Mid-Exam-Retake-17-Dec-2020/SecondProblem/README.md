<h2 class="list-paragraph" id="problem-2">Problem 2</h2>
<h2 class="list-paragraph" id="examples">Examples </h2>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Vanilla, Chocolate, Raspberry, Strawberry, Walnuts, WhiteChocolate, Ordinary, Vegan</p>
<p>Update-Any Chocolate</p>
<p>Remove BBB 3</p>
<p>Update-Last Healthy</p>
<p>Eat</p></td>
<td>Vanilla Raspberry BBB Walnuts WhiteChocolate Ordinary Healthy</td>
</tr>
<tr class="even">
<td><p>Vanilla, Chocolate, Raspberry, Strawberry, Walnuts, WhiteChocolate, Ordinary, Vegan</p>
<p>Update-Any Chocolate</p>
<p>Remove BBB 3</p>
<p>Rearrange Walnuts</p>
<p>Eat</p></td>
<td>Vanilla Raspberry BBB WhiteChocolate Ordinary Vegan Walnuts</td>
</tr>
</tbody>
</table>
<p><strong>JS Input</strong><br />
The input will be provided as an <strong>array of strings</strong>.</p>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>([</p>
<p>"Vanilla, Chocolate, Raspberry, Strawberry, Walnuts, WhiteChocolate, Ordinary, Vegan",</p>
<p>"Update-Any Chocolate",</p>
<p>"Remove BBB 3",</p>
<p>"Update-Last Healthy",</p>
<p>"Eat"</p>
<p>])</p></td>
<td>Vanilla Raspberry BBB Walnuts WhiteChocolate Ordinary Healthy</td>
</tr>
<tr class="even">
<td><p>([</p>
<p>"Vanilla, Chocolate, Raspberry, Strawberry, Walnuts, WhiteChocolate, Ordinary, Vegan",</p>
<p>"Update-Any Chocolate",</p>
<p>"Remove BBB 3",</p>
<p>"Rearrange Walnuts",</p>
<p>"Eat"</p>
<p>])</p></td>
<td>Vanilla Raspberry BBB WhiteChocolate Ordinary Vegan Walnuts</td>
</tr>
</tbody>
</table>
