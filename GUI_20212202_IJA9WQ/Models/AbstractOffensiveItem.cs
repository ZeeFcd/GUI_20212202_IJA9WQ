﻿using GUI_20212202_IJA9WQ.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_20212202_IJA9WQ.Models
{
    public abstract class OffensiveItem : GameItem
    {
        protected int innerClock;
        public AttackStateEnum State { get;set; }
        public int Damage { get; set; }
        public int HP { get; set; }
        public double PlaceX
        {
            get { return placeX; }
            set { placeX = value; }
        }
        public double PlaceY
        {
            get { return placeY; }
            set { placeY = value; }
        }

        public int InnerClock
        {
            get { return innerClock; }
        }

        public virtual void DamagedBy(OffensiveItem attacker) 
        {
            this.HP -= attacker.Damage;
            if (HP<1)
            {
                Terminated();
            }
        }

        public void TimeChanged()
        {
            innerClock++;
        }

    }
}
