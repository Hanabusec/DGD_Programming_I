// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//We will create a player class...

//General Structure of the class.....

//Data Fields - All the attributes our player class will have..
//speed - health - damage

//Properties - Whether our class is accessible or not..Accessibility

//Constructors - sth that is called when we create an object from our class(instantiating)

//Methods - All the functions that our player can do
//Drive - speed up - attack - jump etc.

Player player = new Player();

Console.WriteLine("Player health is: " + player.PlayerHealth);
//player.MyHealth = -10;
//Console.WriteLine("Player health is: " + player.MyHealth);
Console.WriteLine("Player speed is: " + player.PlayerSpeed);
//Console.WriteLine("Player speed is: " + player.speed);

//CHALLENGE

//Player is alive as long as it has more than 0 health
//Player start with 100 health


//Create a health property that checks the player health and ensure player health wont go below 0.
//It must be a read only valuable that returns true or false if the player is alive or not

//Use the health property to keep the program running while the player is alive
//Generate a random number and use the number to damage player
//Print damage taken and player's remaining health
//Print game over when the player is dead.

Random random = new Random();

while (player.IsAlive)
{
    int damage = random.Next(1, 15);

    player.PlayerHealth -= damage;
    Console.WriteLine($"Player took {damage} amount of damage. Remaining health is: {player.PlayerHealth}");
}
Console.WriteLine("GAME OVER");

Console.ReadKey();

class Player
{
    //Fields
    private int health = 100;
    private int speed = 10;

    //Property
    public int PlayerHealth
    {
        get { return health; }

        set
        {
            health = value;

            if (health < 0)
            {
                health = 0;
            }
        }
    }

    public int PlayerSpeed
    {
        get { return speed; }
    }

    public bool IsAlive
    {
        get
        {
            return (health > 0);
        }
    }

    //public int Health { get => health; set => health = value; }
}
