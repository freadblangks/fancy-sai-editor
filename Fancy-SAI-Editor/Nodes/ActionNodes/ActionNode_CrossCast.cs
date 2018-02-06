﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NodeAI.Nodes.ActionNodes
{
    [Node(MenuName = "Cross cast", Type = NodeType.ACTION_CROSS_CAST, AllowedTypes = new NodeType[] { NodeType.GENERAL_SPELL, NodeType.EVENT, NodeType.TARGET })]
    class CrossCast : ActionNode
    {
        public CrossCast()
        {
            Type = NodeType.ACTION_CROSS_CAST;

            ActionId = "86";

            //Update text
            NodeName.Content = "Cross cast";

            AddParam<GeneralNodes.Spell>(ParamId.PARAM_1, NodeType.GENERAL_SPELL, "Spell");
            AddParam<CastFlags>(ParamId.PARAM_2, "Flags:");
            //AddParam<TargetNodes.TargetNode>(ParamId.PARAM_3, NodeType.TARGET, "Target"); //TODO: Implement something to make this work
        }

        public override Node Clone()
        {
            return new CrossCast();
        }
    }
}
