namespace BuildSharper.Course105.App1.Models
{
    public class Robot
    {
        public string Name { get; private set; }
        public int MaxDamage { get; private set; }
        public int ArmorLevel { get; private set; }
        public bool IsAlive { get; private set; }

        private int currentHitPoints = 0;
        private int maxHitPoints = 100;
        private Random random = new Random(DateTime.Now.Millisecond);

        public Robot(string name, int maxDamage, int armorLevel)
        {
            Name = name;
            MaxDamage = maxDamage;
            ArmorLevel = armorLevel;
            Reset();
        }

        private void Reset()
        {
            currentHitPoints = maxHitPoints;
            IsAlive = true;
        }

        public void TakeDamage(Robot enemy)
        {
            //let's make sure they're not dead before we attack them
            if (!IsAlive)
            {
                Console.WriteLine($"{enemy.Name} attacks, but {Name} is DEAD!");
                return;
            }

            //randomize the damagePoints from 0 to their MaxDamage
            var damagePoints = random.Next(0, enemy.MaxDamage);

            if (damagePoints <= 0)
            {
                Console.WriteLine($"{enemy.Name} attacks {Name} and MISSES");
                return;
            }

            //deduct this robot's ArmorLevel from the damagePoints
            var damage = damagePoints - ArmorLevel;

            if (damage > 0)
            {
                currentHitPoints -= damage;
                Console.WriteLine($"{enemy.Name} attacks {Name} for {damage} DAMAGE!");
            }
            else
            {
                Console.WriteLine($"{enemy.Name} attacks {Name} and it was BLOCKED!");
            }

            if (currentHitPoints <= 0)
            {
                Console.WriteLine($"{Name} has been DEFEATED!");
                IsAlive = false;
            }
        }
    }
}
