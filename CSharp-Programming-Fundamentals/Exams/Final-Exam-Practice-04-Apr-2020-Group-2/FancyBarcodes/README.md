<h1 id="problem-2.-fancy-barcodes">Problem 2. Fancy Barcodes</h1>
<p>Your first task is to determine if the given sequence of characters is a <strong>valid</strong> barcode or <strong>not</strong>.</p>
<p><strong>Each line must not contain anything else but a valid barcode</strong>. A barcode is <strong>valid</strong> when:</p>
<ul>
<li><p>Is surrounded with a <strong>"@"</strong> followed by one or more <strong>"#"</strong></p></li>
<li><p>Is <strong>at least 6 characters long</strong> (without the surrounding <strong>"@"</strong> or <strong>"#"</strong>)</p></li>
<li><p><strong>Starts</strong> with a <strong>capital letter</strong></p></li>
<li><p>Contains <strong>only letters</strong> (lower and upper case) <strong>and digits</strong></p></li>
<li><p><strong>Ends</strong> with a <strong>capital letter</strong></p></li>
</ul>
<p>Examples of valid barcodes: <strong>@#FreshFisH@#</strong>, <strong>@###Brea0D@###</strong>, <strong>@##Che46sE@##</strong>, <strong>@##Che46sE@###</strong></p>
<p>Examples of invalid barcodes: <strong>##InvaliDiteM##</strong>, <strong>@InvalidIteM@</strong>, <strong>@#Invalid_IteM@#</strong></p>
<p>Next you have to determine the <strong>product group</strong> of the item from the <strong>barcode</strong>. The product group is obtained by <strong>concatenating</strong> <strong>all the digits</strong> found in the barcode. If there are <strong>no digits</strong> present in the barcode, the <strong>default</strong> product group is <strong>"00".</strong></p>
<p>Examples:</p>
<p><strong>@#FreshFisH@#</strong> -&gt; product group: 00</p>
<p><strong>@###Brea0D@###</strong> -&gt; product group: 0</p>
<p><strong>@##Che4s6E@##</strong> -&gt; product group: 46</p>
<h3 id="input">Input</h3>
<p>On the first line you will be given an integer <strong>n</strong> – the count of barcodes that you will be receiving next.</p>
<p>On the next <strong>n</strong> lines, you will receive different strings.</p>
<h3 id="output">Output</h3>
<p>For each barcode that you process, you need to print a message.</p>
<p>If the barcode is invalid:</p>
<ul>
<li><p><strong>"</strong>Invalid barcode<strong>"</strong></p></li>
</ul>
<p>If the barcode is valid:</p>
<ul>
<li><p><strong>"</strong>Product group: {product group}<strong>"</strong></p></li>
</ul>
<h3 id="constraints">Constraints</h3>
<h3 id="examples">Examples</h3>
<table>
<tbody>
<tr class="odd">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="even">
<td><p>3</p>
<p>@#FreshFisH@#</p>
<p>@###Brea0D@###</p>
<p>@##Che4s6E@##</p></td>
<td><p>Product group: 00</p>
<p>Product group: 0</p>
<p>Product group: 46</p></td>
</tr>
<tr class="odd">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="even">
<td><p>6</p>
<p>@###Val1d1teM@###</p>
<p>@#ValidIteM@#</p>
<p>##InvaliDiteM##</p>
<p>@InvalidIteM@</p>
<p>@#Invalid_IteM@#</p>
<p>@#ValiditeM@#</p></td>
<td><p>Product group: 11</p>
<p>Product group: 00</p>
<p>Invalid barcode</p>
<p>Invalid barcode</p>
<p>Invalid barcode</p>
<p>Product group: 00</p></td>
</tr>
</tbody>
</table>
