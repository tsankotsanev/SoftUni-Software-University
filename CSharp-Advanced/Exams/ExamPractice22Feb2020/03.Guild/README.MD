<h1 id="guild">Guild</h1>
<h2 class="list-paragraph" id="preparation">Preparation</h2>
<p>Download the skeleton provided in Judge. <strong>Do not</strong> change the <strong>StartUp</strong> class or its <strong>namespace</strong>.</p>
<h2 class="list-paragraph" id="problem-description">Problem description</h2>
<p>Your task is to create a repository which stores players by creating the classes described below.</p>
<p>First, write a C# class <strong>Player</strong> with the following properties:</p>
<ul>
<li><p><strong>Name: string</strong></p></li>
<li><p><strong>Class: string</strong></p></li>
<li><p><strong>Rank: string – "Trial" by default</strong></p></li>
<li><p><strong>Description: string – "n/a" by default</strong></p></li>
</ul>
<p>The class <strong>constructor</strong> should receive <strong>name and class</strong>. Override the <strong>ToString()</strong> method in the following format:</p>
<p><strong>"Player {Name}: {Class}</strong></p>
<p><strong>Rank: {Rank}</strong></p>
<p><strong>Description: {Description}"</strong></p>
<p><strong>Next</strong>, write a C# class <strong>Guild</strong> that has <strong>a roster</strong> (a collection which stores the entity <strong>Player</strong>). All entities inside the repository have the <strong>same properties</strong>. Also, the <strong>Guild</strong> class should have those <strong>properties</strong>:</p>
<ul>
<li><p><strong>Name: string</strong></p></li>
<li><p><strong>Capacity: int</strong></p></li>
</ul>
<p>The class <strong>constructor</strong> should receive <strong>name</strong> and <strong>capacity</strong>, also it should initialize the <strong>roster</strong> with a new instance of the collection. Implement the following features:</p>
<ul>
<li><p>Field <strong>roster</strong> - <strong>collection</strong> that holds added <strong>players</strong></p></li>
<li><p>Method <strong>AddPlayer(Player player)</strong> - <strong>adds</strong> an <strong>entity</strong> to the roster <strong>if</strong> <strong>there</strong> <strong>is</strong> <strong>room</strong> for it</p></li>
<li><p>Method <strong>RemovePlayer(string name)</strong> - removes a player by <strong>given name,</strong> if such <strong>exists</strong>, and <strong>returns bool</strong></p></li>
<li><p>Method <strong>PromotePlayer(string name)</strong> - <strong>promote</strong> (<strong>set his rank to "Member"</strong>) the <strong>first player</strong> with the <strong>given name.</strong> If the player is <strong>already</strong> a "Member", <strong>do nothing.</strong></p></li>
<li><p>Method <strong>DemotePlayer(string name)- demote (set his rank to "Trial")</strong> the first player with the <strong>given</strong> name. If the player is <strong>already</strong> a "Trial", <strong>do nothing.</strong></p></li>
<li><p>Method <strong>KickPlayersByClass(string class)</strong> - removes all the players by the given class and returns <strong>all players</strong> from that <strong>class <u>as an array</u></strong></p></li>
<li><p>Getter <strong>Count</strong> - <strong>returns</strong> the <strong>number</strong> of players</p></li>
<li><p><strong>Report()</strong> - <strong>returns</strong> a <strong>string</strong> in the following <strong>format:</strong></p>
<ul>
<li><p><strong>"Players in the guild: {guildName}<br />
{Player<sub>1</sub>}<br />
{Player<sub>2</sub>}<br />
(…)</strong>"</p></li>
</ul></li>
</ul>
<h2 class="list-paragraph" id="constraints">Constraints</h2>
<ul>
<li><p>The <strong>names</strong> of the players will be <strong>always unique</strong>.</p></li>
<li><p>You will always have a player added before receiving methods manipulating the Guild's players.</p></li>
</ul>
<h2 class="list-paragraph" id="examples">Examples</h2>
<p>This is an example how the <strong>Guild</strong> class is <strong>intended to be used</strong>.</p>
<table>
<thead>
<tr class="header">
<th>Sample code usage</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>//Initialize the repository (guild)</p>
<p>Guild guild = new Guild("Weekend Raiders", 20);</p>
<p>//Initialize entity</p>
<p>Player player = new Player("Mark", "Rogue");</p>
<p>//Print player</p>
<p>Console.WriteLine(player); //Player Mark: Rogue</p>
<p>//Rank: Trial</p>
<p>//Description: n/a</p>
<p>//Add player</p>
<p>guild.AddPlayer(player);</p>
<p>Console.WriteLine(guild.Count); //1</p>
<p>Console.WriteLine(guild.RemovePlayer("Gosho")); //False</p>
<p>Player firstPlayer = new Player("Pep", "Warrior");</p>
<p>Player secondPlayer = new Player("Lizzy", "Priest");</p>
<p>Player thirdPlayer = new Player("Mike", "Rogue");</p>
<p>Player fourthPlayer = new Player("Marlin", "Mage");</p>
<p>//Add description to player</p>
<p>secondPlayer.Description = "Best healer EU";</p>
<p>//Add players</p>
<p>guild.AddPlayer(firstPlayer);</p>
<p>guild.AddPlayer(secondPlayer);</p>
<p>guild.AddPlayer(thirdPlayer);</p>
<p>guild.AddPlayer(fourthPlayer);</p>
<p>//Promote player</p>
<p>guild.PromotePlayer("Lizzy");</p>
<p>//RemovePlayer</p>
<p>Console.WriteLine(guild.RemovePlayer("Pep")); //True</p>
<p>Player[] kickedPlayers = guild.KickPlayersByClass("Rogue");</p>
<p>Console.WriteLine(string.Join(", ", kickedPlayers.Select(p =&gt; p.Name))); //Mark, Mike</p>
<p>Console.WriteLine(guild.Report());</p>
<p>//Players in the guild: Weekend Raiders</p>
<p>//Player Lizzy: Priest</p>
<p>//Rank: Member</p>
<p>//Description: Best healer EU</p>
<p>//Player Marlin: Mage</p>
<p>//Rank: Trial</p>
<p>//Description: n/a</p></td>
</tr>
</tbody>
</table>
<h2 class="list-paragraph" id="submission">Submission</h2>
<p>Zip all the files in the project folder except for the <strong>bin</strong> and <strong>obj</strong> folders</p>
