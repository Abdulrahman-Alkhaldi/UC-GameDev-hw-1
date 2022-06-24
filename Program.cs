// See https://aka.ms/new-console-template for more information

string hero = "abdo"; // why ask us to create this if we wont even use it? :D
int health = 100;

int damaged()
{
    return health -= 20;
}
int boost()
{
    return health += 10;
}
int damagedHealth = damaged();
int boostedHealth = boost();
Console.WriteLine($"Damaged Health: {damagedHealth}");
Console.WriteLine($"Boosted Health: {boostedHealth}");
if (damagedHealth < boostedHealth){
    Console.WriteLine(boostedHealth);
    Console.WriteLine($"{damagedHealth} is less than {boostedHealth}");
} else if (damagedHealth > boostedHealth){
    Console.WriteLine(damagedHealth);
    Console.WriteLine($"{damagedHealth} is greater than {boostedHealth}");
} else {
    Console.WriteLine($"{damagedHealth} is equal to {boostedHealth}");
}