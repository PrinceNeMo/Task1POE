using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public enum Direction
    {
        North,
        South,
        West,
        East
    }
    abstract class Unit
    {
       internal int XPos;
       internal int YPos;
       internal int Health;
       internal int Max_Health;
       internal int Speed;
       internal int Attack;
       internal int Attack_range;
       internal string Team;
       internal string Symbol;
       internal bool IsAttacking;

        public Unit(int xpos,int ypos, int health,int speed,int attack,int attackrange,string team, string symbol,bool isattacking)
        {
            XPos = xpos;
            YPos = ypos;
            Health = health;
            Speed = speed;
            Attack = attack;
            Attack_range = attackrange;
            Team = team;
            Symbol = symbol;
            IsAttacking = isattacking;
        }
        public Unit()
        {

        }

        public abstract void Move( Direction d);
        public abstract void Combat(Unit u);
        public abstract void AttackRange();
        public abstract void ClosestUnit();
        public abstract void DeathUnit();

        public override string ToString()
        {
            return "Unit" + "(" + XPos + " , " + YPos + ")" + Health + " , " + Max_Health + " , " + Speed + " , " + Attack_range + " ," + Symbol;
        }
    }
}
