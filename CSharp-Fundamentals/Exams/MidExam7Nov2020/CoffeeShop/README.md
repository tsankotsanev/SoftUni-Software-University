<h1 id="coffee-shop">Coffee Shop</h1>
<p>We are placing <strong>N</strong> orders at a time. You need to calculate the price on the following formula:</p>
<p>((daysInMonth * capsulesCount) * pricePerCapsule)</p>
<h3 id="input-constraints">Input / Constraints</h3>
<ul>
<li><p>On the first line you will receive integer <strong>N</strong> – the count of orders the shop will receive.</p></li>
<li><p>For each order you will receive the following information:</p>
<ul>
<li><p>Price per capsule - <strong>floating-point number</strong> in range <strong>[0.00…1000.00]</strong></p></li>
<li><p>Days – <strong>integer</strong> in range <strong>[1…31]</strong></p></li>
<li><p>Capsules count - <strong>integer</strong> in range <strong>[0…2000]</strong></p></li>
</ul></li>
</ul>
<p>The input will be in the described format, there is no need to check it explicitly.</p>
<h3 id="output">Output</h3>
<p>The output should consist of <strong>N + 1</strong> lines. For each order you must print a single line in the following format:</p>
<ul>
<li><p><strong>"The price for the coffee is: ${price}"</strong></p></li>
</ul>
<p>On the last line you need to print the total price in the following format:</p>
<ul>
<li><p><strong>"Total: ${totalPrice}"</strong></p></li>
</ul>
<p>The <strong>price must be rounded</strong> to 2 decimal places.</p>
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
<td><p>1</p>
<p>1.53</p>
<p>30</p>
<p>8</p></td>
<td><p>The price for the coffee is: $367.20</p>
<p>Total: $367.20</p></td>
<td><p>We are given only 1 order. Then we use the formulas:</p>
<p><strong>orderPrice</strong> = 30 * 8 * 1.53 = 367.20</p></td>
</tr>
</tbody>
</table>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>2</p>
<p>4.99</p>
<p>31</p>
<p>3</p>
<p>0.35</p>
<p>31</p>
<p>5</p></td>
<td><p>The price for the coffee is: $464.07</p>
<p>The price for the coffee is: $54.25</p>
<p>Total: $518.32</p></td>
<td></td>
</tr>
</tbody>
</table>
<h3 id="js-input">JS Input</h3>
<p>The input will be an array of numbers</p>
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
<td><p>([1,</p>
<p>1.53,</p>
<p>30,</p>
<p>8])</p></td>
<td><p>The price for the coffee is: $367.20</p>
<p>Total: $367.20</p></td>
<td><p>We are given only 1 order. Then we use the formulas:</p>
<p><strong>orderPrice</strong> = 30 * 8 * 1.53 = 367.20</p></td>
</tr>
</tbody>
</table>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>([2,</p>
<p>4.99,</p>
<p>31,</p>
<p>3,</p>
<p>0.35,</p>
<p>31,</p>
<p>5])</p></td>
<td><p>The price for the coffee is: $464.07</p>
<p>The price for the coffee is: $54.25</p>
<p>Total: $518.32</p></td>
<td></td>
</tr>
</tbody>
</table>
