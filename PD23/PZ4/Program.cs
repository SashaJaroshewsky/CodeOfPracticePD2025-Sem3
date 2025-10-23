namespace PZ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();
            Lamp lamp = new Lamp();
            Switch sw = new Switch(door);
            Switch sw2 = new Switch(lamp);

            sw.OnSwitch();
            sw.OnSwitch();
            sw.OnSwitch();
            sw2.OnSwitch();
            sw2.OnSwitch();
            sw2.OnSwitch();

            Console.WriteLine("++++++++++++++++++++");

            Character mage = new Mage(100, 20);
            Character robot = new Robot(200, 50);
            ISwitcheable robot1 =  robot as ISwitcheable;

            List<Character> characters = new List<Character> { mage, robot };

            foreach (var character in characters)
            {
                character.Attack(door);
                character.Attack(lamp);

            }

            Switch sw3 = new Switch(robot1);
            sw3.OnSwitch();
            sw3.OnSwitch(); sw3.OnSwitch();
        }
    }
}
