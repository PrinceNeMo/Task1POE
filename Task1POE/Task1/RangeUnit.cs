using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class RangeUnit : Unit
    {
        internal int rangxPos;
        internal int rangyPos;
        internal int HealthTakeen_rang;
        internal int Rang_Max_Health;
        internal int AttackSpeed;
        internal int RangAttack;
        internal int Rang_Attackrange;
        internal string Rang_Team;
        internal string Rang_Symbol;
        internal bool IRang_isAttacking;

        public RangeUnit(int xpos, int ypos, int health, int speed, int attack, int attackrange, string team, string symbol, bool isattacking)
        {
            rangxPos = xpos;
            rangyPos = ypos;
            HealthTakeen_rang = health;
            AttackSpeed = speed;
            RangAttack = attack;
            Rang_Attackrange = attackrange;
            Rang_Team = team;
            Rang_Symbol = symbol;
            IRang_isAttacking = isattacking;
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
            get { return base.Speed; }
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
        public string teaM
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
        
        
    }
}
