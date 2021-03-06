﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancySaiEditor.Nodes.TargetNodes
{
    [Node(MenuName = "Closest creature", Type = NodeType.TARGET_CLOSEST_CREATURE, AllowedTypes = new NodeType[] { NodeType.ACTION })]
    public class ClosestCreature : TargetNode
    {
        public ClosestCreature()
        {
            Type = NodeType.TARGET_CLOSEST_CREATURE;

            

            NodeName.Content = "Closest creature";
        }

        public override Node Clone()
        {
            return new ClosestCreature();
        }
    }
}
