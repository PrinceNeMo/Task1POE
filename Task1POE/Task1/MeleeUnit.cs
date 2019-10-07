using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MeleeUnit : Unit
    {
        internal int MeleexPos;
        internal int MeleeyPos;
        internal int HealthTakeen_Melee;        
        internal int AttackSpeed;
        internal int MeleeAttack;
        internal int Melee_Attackrange;
        internal string Melee_Team;
        internal string Melee_Symbol;
        internal bool IMelee_isAttacking= false ;

        public MeleeUnit(int xpos, int ypos, int health, int speed, int attack, int attackrange, string team, string symbol, bool isattacking)
        {
            MeleexPos = xpos;
            MeleeyPos = ypos;
            HealthTakeen_Melee = health;
            AttackSpeed = speed;
            MeleeAttack = attack;
            Melee_Attackrange = attackrange;
            Melee_Team = team;
            Melee_Symbol = symbol;
            IsAttacking = isattacking;
        }
        public int Xpos
        {
            get { return base.XPos; }
            set { XPos = value; }
        }
        public int Ypos
        {
            get { return base.YPos; }
            set { YPos = value; }
        }
        public int health
        {
            get { return base.Health; }
            set { Health = value; }
        }
        public int max_hp
        {
            get { return base.Max_Health; }
        }
        public int speed
        {
            get { return base.Speed;}
            set { Speed = value; }
        }
        public int attack
        {
            get { return base.Attack; }
            set { Attack = value; }
        }
        public int attackrage
        {
            get { return base.Attack_range; }
            set { Attack_range = value; }
        }
        public string team
        {
            get { return base.Team; }
            set { Team = value; }
        }
        public string symbol
        {
            get { return base.Symbol; }
            set { Symbol = value; }
        }
        public override void ClosestUnit()
        {
            
        }
        public override void Move(Direction d)
        {
            switch (d)
            {
                case Direction.North:
                    YPos--;
                    break;
                case Direction.East:
                    XPos++;
                    break;
                case Direction.West:
                    XPos--;
                    break;
                case Direction.South:
                    YPos++;
                    break;
                default:
                    break;
            }
        }
        public override void Combat(Unit u)
        {

        }
       
        public override void AttackRange()
        {
           
        }
        public override void DeathUnit()
        {
            
        }

       // public override void ToString()        

        
    }
}
