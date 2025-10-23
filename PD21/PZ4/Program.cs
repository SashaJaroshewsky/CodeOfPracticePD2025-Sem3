namespace PZ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();
            Bulb bulb = new Bulb();

            Lever lever = new Lever(door);

            lever.Pull(); // Opens the door
            lever.Pull(); // Closes the door

            lever.ConnectedDevice = bulb;
            lever.Pull(); // Turns the bulb ON
            lever.Pull(); // Turns the bulb OFF
            lever.Pull();

            Console.WriteLine("====================");

            Robot robot = new Robot(100, 20);
            Mage mage = new Mage(80, 25);

            robot.Attack(bulb);
            robot.Attack(door);
            robot.Attack(mage);
            
            mage.Attack(robot);

            lever.ConnectedDevice = robot;
            lever.Pull(); // Activates the robot

        }
    }
}
