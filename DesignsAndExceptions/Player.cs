using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsAndExceptions
{
    public class Player : ISubject, ISubscriber, IAttackable
    {

        private IWeaponStrategy MainHandWeapon;

        private int _Health;

        public int Health
        {
            get { return _Health; }
            set
            { 
                _Health = value;
                Notify();
            }
        }


        public List<ISubscriber> Subscribers = new List<ISubscriber>();

        public Player()
        {
            Health = 100;
            Subscribers.Add(this);
            MainHandWeapon = new BareFistStrategy();
        }

        public void EquipWeapon(IWeaponStrategy weapon)
        {
            MainHandWeapon = weapon;
        }

        public void MakeAttack(IAttackable target)
        {
            MainHandWeapon.Attack(target);
        }


        public void Register(ISubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void Unregister(ISubscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            foreach (var subscriber in Subscribers)
            {
                subscriber.Update(Health);
            }
        }

        public void Update(int currentHealth)
        {
            if (currentHealth < 50)
            {
                Console.WriteLine("It's not looking good for me...");
            }
        }

        public void TakeDamage(int hitAmount)
        {
            Console.WriteLine($"The player takes {hitAmount} damage!");
            Health -= hitAmount;
        }
    }
}
