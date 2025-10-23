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
            lever.Pull(); // Opens the door again

            lever.ConnectedDevice = bulb; // Switch to controlling the bulb
            lever.Pull(); // Turns the bulb on
            lever.Pull(); // Turns the bulb off
            Console.WriteLine("++++++++++++++++");

            Robot robot = new Robot(100, 20);
            Mage mage = new Mage(80, 25);
            robot.Attack(mage);
            mage.Attack(robot);
            mage.Attack(door);
            robot.Attack(bulb);

            lever.ConnectedDevice = robot; // Switch to controlling the robot
            lever.Pull(); // Activates the robot
        }
    }
}
