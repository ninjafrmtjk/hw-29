// Task 1.

int[] ints = new[] { 5, 14, 28, 105, 10, 87, 32, 42};
var result = ints.Where(n => n > 9 && n < 100)
                     .OrderBy(n => n);

foreach (var item in result)
    Console.WriteLine(item);

// Task 2.
var sequence = new List<string> { "AA", "BCD", "EF", "BGF", "EDC", "FGH", "ABC", "BHG", "BGF" };
var res = sequence.OrderBy(s => s.Length)
                     .ThenByDescending(s => s);

foreach (var item in res)
    Console.WriteLine(item);


// Task 3.

int k = 3; 
var a = new [] {"apple", "Banana", "Cherry", "date", "Eggplant", "fig"};
var res1 = a.Take(k - 1)
              .Where(s => s.Length % 2 != 0 && char.IsUpper(s[0])) 
              .Reverse(); 

foreach (var s in res1)
    Console.WriteLine(s);

// Task 4.

IEnumerable<int> RemoveDuplicates(IEnumerable<int> sequence)
{
    var distinct = new HashSet<int>();
    return sequence
        .Where(n => n > 0)
        .Select(n =>
        {
            var lastDigit = n % 10;
            if (!distinct.Contains(lastDigit))
            {
                distinct.Add(lastDigit);
                return lastDigit;
            }

            return default(int?);
        })
        .Where(n => n.HasValue)
        .Select(n => n.Value);
}

// Task 5.

string[] strings = { "abcde", "abcd", "abcdefg" };

        var characters = strings
            .Select(s => s.Length % 2 == 1 ? s[0] : s[^1])
            .OrderByDescending(c => (int)c);

foreach (var c in characters)
    Console.Write("Letter: " + c + " ");

// Task 6.

int K1 = 5;
int K2 = 10;
int[] A = { 1, 3, 5, 7, 9, 11 };
int[] B = { 2, 4, 6, 8, 10, 12 };

var res2 = A.Where(x => x > K1).Concat(B.Where(x => x < K2)).OrderBy(x => x);

foreach (int num in res2)
{
    Console.Write(num + " ");
}
        


// using System.Linq;

// List<Person> persons = new()
// {
//     new() { FirstName = "Chris", LastName = "Adams"},
//     new() { FirstName = "Anjella", LastName = "Peterson"},
//     new() { FirstName = "Lee", LastName = "Cho"},
//     new() { FirstName = "Bob", LastName = "Nich"}
// };

// List<Pet> pets = new()
// {
//     new() { Name = "Barley", Owner = "Bob" },
//     new() { Name = "Boots", Owner = "Chris" },
//     new() { Name = "Moon", Owner = "Anjella" },
//     new() { Name = "Daisy", Owner = "Lee" }
// };

// var query =
//     from person in persons
//     join pet in pets on person.FirstName equals pet.Owner
//     select new
//     {
//         OwnerName = person.FirstName,
//         PetName = pet.Name
//     };

// var lefOuterJoin = 
//     from person in persons
//     join pet in pets on person.FirstName equals pet.Owner into gj
//     from subpet in gj.DefaultIfEmpty()
//     select new
//     {
//         OwnerName = person.FirstName,
//         PetName = subpet?.Name ?? string.Empty
//     };

// foreach (var ownerAndPet in lefOuterJoin)
//     Console.WriteLine($"Owner name {ownerAndPet.OwnerName}, Pet name {ownerAndPet.PetName}");

// public record Person 
// {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
// }

// public record Pet
// {
//     public string Name { get; set; }
//     public string Owner { get; set; }
// }