<Query Kind="Statements" />

int[] nums = {20,15,31,34,35,40,50,90,99,100};

nums
	.ToLookup(k => k, k => nums.Where(n => n < k))
	.Select(k => new KeyValuePair<int,double>
		(k.Key, 100 * ((double)k.First().Count()/(double)nums.Length)))
	.Dump("Percentile");
	
int[] marks = {20,15,31,34,35,40,50,90,99,100};

marks
	.ToLookup(k => k, k => marks.Where(n => n >= k))
	.Select(k => new {
		Marks = k.Key,
		Rank = 10 * ((double)k.First().Count()/(double)marks.Length)
		})
	.Dump("Ranks");