<Query Kind="Statements" />

Enumerable.Range(2,10)
.Select(c => new {Length = 2 * c,
				  Height = c * c - 1,
				  Hypotenuse = c * c + 1})
.Dump("Pythagorean Triples");

var q = Enumerable.Range(2, 10)
	.Select(c => new {Length = 2 * c,
					  Height = c * c - 1,
					  Hypotenuse = c * c + 1})
	.ToList();

Console.WriteLine(q[0]);