<h1 id="problem-3">Problem 3</h1>
<h2 class="list-paragraph" id="examples">Examples</h2>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Enroll Stefan</p>
<p>Enroll Peter</p>
<p>Enroll Stefan</p>
<p>Learn Stefan ItShouldWork</p>
<p>Learn John ItShouldNotWork</p>
<p>Unlearn George Dispel</p>
<p>Unlearn Stefan ItShouldWork</p>
<p>End</p></td>
<td><p>Stefan is already enrolled.</p>
<p>John doesn't exist.</p>
<p>George doesn't exist.</p>
<p>Heroes:</p>
<p>== Peter:</p>
<p>== Stefan:</p></td>
</tr>
<tr class="even">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="odd">
<td><p>Enroll Stefan</p>
<p>Learn Stefan ItShouldWork</p>
<p>Learn Stefan ItShouldWork</p>
<p>Unlearn Stefan NotFound</p>
<p>End</p></td>
<td><p>Stefan has already learnt ItShouldWork.</p>
<p>Stefan doesn't know NotFound.</p>
<p>Heroes:</p>
<p>== Stefan: ItShouldWork</p></td>
</tr>
</tbody>
</table>
<h2 class="list-paragraph" id="js-input">JS Input</h2>
<p>The input will be provided as an <strong>array of strings</strong></p>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>(["Enroll Stefan",</p>
<p>"Enroll Peter",</p>
<p>"Enroll Stefan",</p>
<p>"Learn Stefan ItShouldWork",</p>
<p>"Learn John ItShouldNotWork",</p>
<p>"Unlearn George Dispel",</p>
<p>"Unlearn Stefan ItShouldWork",</p>
<p>"End"])</p></td>
<td><p>Stefan is already enrolled.</p>
<p>John doesn't exist.</p>
<p>George doesn't exist.</p>
<p>Heroes:</p>
<p>== Peter:</p>
<p>== Stefan:</p></td>
</tr>
<tr class="even">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="odd">
<td><p>(["Enroll Stefan",</p>
<p>"Learn Stefan ItShouldWork",</p>
<p>"Learn Stefan ItShouldWork",</p>
<p>"Unlearn Stefan NotFound",</p>
<p>"End"])</p></td>
<td><p>Stefan has already learnt ItShouldWork.</p>
<p>Stefan doesn't know NotFound.</p>
<p>Heroes:</p>
<p>== Stefan: ItShouldWork</p></td>
</tr>
</tbody>
</table>
