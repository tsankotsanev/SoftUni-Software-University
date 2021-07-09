<h1 id="vet-clinic">Vet Clinic</h1>
<h2 class="list-paragraph" id="preparation">Preparation</h2>
<p>Download the skeleton provided in Judge. <strong>Do not</strong> change the <strong>StartUp</strong> class or its <strong>namespace</strong>.</p>
<h2 class="list-paragraph" id="problem-description">Problem description</h2>
<p>Your task is to create a repository, which stores items by creating the classes described below.</p>
<p>First, write a C# class <strong>Pet</strong> with the following properties:</p>
<ul>
<li><p><strong>Name: string</strong></p></li>
<li><p><strong>Age: int</strong></p></li>
<li><p><strong>Owner: string</strong></p></li>
</ul>
<p>The class <strong>constructor</strong> should receive <strong>name, age</strong> and <strong>owner.</strong> The class should override the <strong>ToString()</strong> method in the following format:</p>
<p><strong>"Name: {Name} Age: {Age} Owner: {Owner}"</strong></p>
<p><strong>Next</strong>, write a C# class <strong>Clinic</strong> that has <strong>data</strong> (a collection, which stores the Pets). All entities inside the repository have the <strong>same properties</strong>. Also, the <strong>Clinic</strong> class should have those properties:</p>
<ul>
<li><p><strong>Capacity: int</strong></p></li>
</ul>
<p>The class <strong>constructor</strong> should receive <strong>capacity</strong>, also it should initialize the <strong>data</strong> with a new instance of the collection<strong>.</strong> Implement the following features:</p>
<ul>
<li><p>Field <strong>data</strong> – <strong>collection</strong> that holds added pets</p></li>
<li><p>Method <strong>Add(Pet pet)</strong> – <strong>adds</strong> an <strong>entity</strong> to the data <strong>if</strong> <strong>there</strong> <strong>is</strong> an <strong>empty cell</strong> for the pet.</p></li>
<li><p>Method <strong>Remove(string name)</strong> – removes the pet by <strong>given name,</strong> if such <strong>exists</strong>, and <strong>returns bool</strong>.</p></li>
<li><p>Method <strong>GetPet(string name, string owner)</strong> – returns the pet with the <strong>given name</strong> and <strong>owner</strong> or <strong>null if no such pet exists</strong>.</p></li>
<li><p>Method <strong>GetOldestPet()</strong> – returns the oldest Pet.</p></li>
<li><p>Getter <strong>Count</strong> – <strong>returns</strong> the <strong>number</strong> of pets.</p></li>
<li><p><strong>GetStatistics()</strong> – <strong>returns</strong> a <strong>string</strong> in the following <strong>format</strong>:</p>
<ul>
<li><p><strong>"The clinic has the following patients:<br />
Pet {Name} with owner: {Owner}<br />
Pet {Name} with owner: {Owner}</strong></p></li>
</ul></li>
</ul>
<blockquote>
<p><strong>(…)</strong>"</p>
</blockquote>
<h2 class="list-paragraph" id="constraints">Constraints</h2>
<ul>
<li><p>The <strong>combinations</strong> of <strong>names</strong> and <strong>owners</strong> will <strong>always be unique</strong>.</p></li>
<li><p>The <strong>age</strong> of the pets will always be <strong>positive</strong>.</p></li>
</ul>
<h2 class="list-paragraph" id="examples"><br />
Examples</h2>
<p>This is an example of how the <strong>Clinic</strong> class is <strong>intended to be used</strong>.</p>
<table>
<thead>
<tr class="header">
<th>Sample code usage</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>// Initialize the repository</p>
<p>Clinic clinic = new Clinic(20);</p>
<p>// Initialize entity</p>
<p>Pet dog = new Pet("Ellias", 5, "Tim");</p>
<p>// Print Pet</p>
<p>Console.WriteLine(dog); // Ellias 5 (Tim)</p>
<p>// Add Pet</p>
<p>clinic.Add(dog);</p>
<p>// Remove Pet</p>
<p>Console.WriteLine(clinic.Remove("Ellias")); // True</p>
<p>Console.WriteLine(clinic.Remove("Pufa")); // False</p>
<p>Pet cat = new Pet("Bella", 2, "Mia");</p>
<p>Pet bunny = new Pet("Zak", 4, "Jon");</p>
<p>clinic.Add(cat);</p>
<p>clinic.Add(bunny);</p>
<p>// Get Oldest Pet</p>
<p>Pet oldestPet = clinic.GetOldestPet();</p>
<p>Console.WriteLine(oldestPet); // Zak 4 (Jon)</p>
<p>// Get Pet</p>
<p>Pet pet = clinic.GetPet("Bella", "Mia");</p>
<p>Console.WriteLine(pet); // Bella 2 (Mia)</p>
<p>// Count</p>
<p>Console.WriteLine(clinic.Count); // 2</p>
<p>// Get Statistics</p>
<p>Console.WriteLine(clinic.GetStatistics());</p>
<p>//The clinic has the following patients:</p>
<p>//Bella Mia</p>
<p>//Zak Jon</p></td>
</tr>
</tbody>
</table>
<h2 class="list-paragraph" id="submission">Submission</h2>
<p>Zip all the files in the project folder except <strong>bin</strong> and <strong>obj</strong> folders</p>
