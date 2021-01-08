<h1 id="problem-2.-shopping-list">Problem 2. Shopping List</h1>
<p><em>It’s the end of the week and it is time for you to go shopping, so you need to create a shopping list first.</em></p>
<h3 id="input">Input</h3>
<p>You will receive an <strong>initial list</strong> with groceries separated by <strong>"!"</strong>.</p>
<p>After that you will be receiving <strong>4 types</strong> of commands, until you receive <strong>"Go Shopping!"</strong></p>
<ul>
<li><p><strong>Urgent {item} -</strong> <strong>add</strong> the item at the <strong>start</strong> of the list. If the item <strong>already exists,</strong> skip this command.</p></li>
<li><p><strong>Unnecessary {item} - remove</strong> the item with the given name, only <strong>if it exists</strong> in the list. Otherwise skip this command.</p></li>
<li><p><strong>Correct {oldItem} {newItem} –</strong> if the item with the given <strong>old name</strong> exists, <strong>change</strong> its name with the <strong>new</strong> one. If it <strong>doesn't exist</strong>, skip this command.</p></li>
<li><p><strong>Rearrange {item} -</strong> if the grocery exists in the list, <strong>remove</strong> it from its <strong>current position</strong> and <strong>add</strong> it at the <strong>end</strong> of the list.</p></li>
</ul>
<h3 id="constraints">Constraints</h3>
<ul>
<li><p>There won`t be any duplicate items in the initial list</p></li>
</ul>
<h3 id="output">Output</h3>
<p>Print the <strong>list</strong> with all the groceries, joined by <strong>", ".</strong></p>
<ul>
<li><p><strong>"{firstGrocery}, {secondGrocery}, …{nthGrocery}"</strong></p></li>
</ul>
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
<td><p>Tomatoes!Potatoes!Bread</p>
<p>Unnecessary Milk</p>
<p>Urgent Tomatoes</p>
<p>Go Shopping!</p></td>
<td>Tomatoes, Potatoes, Bread</td>
</tr>
<tr class="even">
<td><strong>Input</strong></td>
<td><strong>Output</strong></td>
</tr>
<tr class="odd">
<td><p>Milk!Pepper!Salt!Water!Banana</p>
<p>Urgent Salt</p>
<p>Unnecessary Grapes</p>
<p>Correct Pepper Onion</p>
<p>Rearrange Grapes</p>
<p>Correct Tomatoes Potatoes</p>
<p>Go Shopping!</p></td>
<td>Milk, Onion, Salt, Water, Banana</td>
</tr>
</tbody>
</table>
