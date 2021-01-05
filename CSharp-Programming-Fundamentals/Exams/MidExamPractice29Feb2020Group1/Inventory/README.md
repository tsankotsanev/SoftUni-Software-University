<h1 id="problem-3.-inventory">Problem 3. Inventory</h1>
<p><em>As a young traveler, you gather items and craft new items.</em></p>
<h3 id="input-constraints">Input / Constraints</h3>
<p>You will receive a journal with some Collecting items, separated with <strong>', '</strong> (comma and space). After that, until receiving <strong>"Craft!"</strong> you will be receiving different commands.</p>
<p>Commands (split by <strong>" - "</strong>):</p>
<ul>
<li><p><strong>"Collect - {item}"</strong> – Receiving this command, you should add the given item in your inventory. If the item already <strong>exists</strong>, you should <strong>skip</strong> this line.</p></li>
<li><p><strong>"Drop - {item}"</strong> – You should remove the item from your inventory, <strong>if it exists</strong>.</p></li>
<li><p><strong>"Combine Items - {oldItem}:{newItem}"</strong> – You should check if the <strong>old item exists</strong>, if so, <strong>add</strong> the new item <strong>after</strong> the <strong>old one</strong>. Otherwise, <strong>ignore</strong> the command.</p></li>
<li><p><strong>"Renew – {item}"</strong> – If the given item exists, you should change its position and <strong>put it last</strong> in your inventory.</p></li>
</ul>
<h3 id="output">Output</h3>
<p>After receiving <strong>"Craft!"</strong> print the items in your inventory, separated by <strong>", "</strong> (comma and space).</p>
<h3 id="examples">Examples</h3>
<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Iron, Wood, Sword</p>
<p>Collect - Gold</p>
<p>Drop - Wood</p>
<p>Craft!</p></td>
<td>Iron, Sword, Gold</td>
</tr>
<tr class="even">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="odd">
<td><p>Iron, Sword</p>
<p>Drop - Bronze</p>
<p>Combine Items - Sword:Bow</p>
<p>Renew - Iron</p>
<p>Craft!</p></td>
<td>Sword, Bow, Iron</td>
</tr>
</tbody>
</table>
