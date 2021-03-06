﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Pokemon
{
    [Serializable]
    public class EvolutionInstance
    {
        public int ID { get; private set; }
        public int TreeID { get; private set; }
        public int Place { get; private set; }
        public EvoMethod Method { get; private set; }
        public int Level { get; private set; }
        public string Condition { get; private set; }
        public Item Item { get; private set; }
        public Move Move { get; private set; }

        public EvolutionInstance(int i, int t, int p, EvoMethod m)
        {
            ID = i;
            TreeID = t;
            Place = p;
            Method = m;
        }

        public EvolutionInstance(int i, int t, int p, EvoMethod m, int l, string c)
        {
            ID = i;
            TreeID = t;
            Place = p;
            Method = m;
            Level = l;
            Condition = c;
        }

        public EvolutionInstance(int i, int t, int p, EvoMethod m, int l, string c, Item it)
        {
            ID = i;
            TreeID = t;
            Place = p;
            Method = m;
            Level = l;
            Condition = c;
            Item = it;
        }

        public EvolutionInstance(int i, int t, int p, EvoMethod m, int l, string c, Move mo)
        {
            ID = i;
            TreeID = t;
            Place = p;
            Method = m;
            Level = l;
            Condition = c;
            Move = mo;
        }

        public EvolutionInstance (SerializationInfo info, StreamingContext ctxt)
        {
            ID = (int)info.GetValue("ID", typeof(int));
            TreeID = (int)info.GetValue("TreeID", typeof(int));
            Place = (int)info.GetValue("Place", typeof(int));
            Method = (EvoMethod)info.GetValue("Method", typeof(EvoMethod));
            Level = (int)info.GetValue("Level", typeof(int));
            Condition = (string)info.GetValue("Condition", typeof(string));
            Item = (Item)info.GetValue("Item", typeof(Item));
            Move = (Move)info.GetValue("Move", typeof(Move));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("ID", ID);
            info.AddValue("TreeID", TreeID);
            info.AddValue("Place", Place);
            info.AddValue("Method", Method);
            info.AddValue("Level", Level);
            info.AddValue("Condition", Condition);
            info.AddValue("Item", Item);
            info.AddValue("Move", Move);
        }
    }
}
