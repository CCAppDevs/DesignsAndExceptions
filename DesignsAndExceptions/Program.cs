namespace DesignsAndExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Observerable - Publish Subscribe - PubSub

            // React to changes in state - notify observers


            // scenario - We're making a game
            // we have an enemy on the screen
            // a player on the screen,
            // and we have a heads up display on the screen that shows health and other info

            // Our problem: we want multiple different things to change when a player's health changes

            Player myPlayer = new Player();

            HUD myHud = new HUD();
            Enemy myEnemy = new Enemy();

            myPlayer.Register(myHud);
            myPlayer.Register(myEnemy);

            ClubStrategy club = new ClubStrategy();
            BowStrategy bow = new BowStrategy();
            MachineGunStrategy machineGun = new MachineGunStrategy();

            Console.WriteLine("Attacking with a bare fist.");
            myPlayer.MakeAttack(myEnemy);

            Console.WriteLine("\nAttacking with a club");
            myPlayer.EquipWeapon(club);
            myPlayer.MakeAttack(myEnemy);

            Console.WriteLine("\nAttacking with a bow");
            myPlayer.EquipWeapon(bow);
            myPlayer.MakeAttack(myEnemy);

            Console.WriteLine("\nAttacking with a machine gun");
            myPlayer.EquipWeapon(machineGun);
            myPlayer.MakeAttack(myEnemy);


        }
    }
}
