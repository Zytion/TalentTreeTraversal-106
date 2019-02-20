using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentTreeTraversal_106
{
    class TalentTreeNode
    {
        string abilityName;
        bool learnedTalent;
        TalentTreeNode leftNode;
        TalentTreeNode rightNode;

        /// <summary> The ability name </summary>
        public string AbiltiyName { get { return abilityName; } set { abilityName = value;  } }
        /// <summary> Boolean indicating if the player has learned this talent </summary>
        public bool LearnedTalent { get { return learnedTalent; } set { learnedTalent = value; } }
        /// <summary> Left child node </summary>
        public TalentTreeNode LeftNode { get { return leftNode; } set { leftNode = value; } }
        /// <summary> Right child node </summary>
        public TalentTreeNode RightNode { get { return rightNode; } set { rightNode = value; } }

        public TalentTreeNode()
        {
            abilityName = "";
            learnedTalent = false;
        }
        public TalentTreeNode(string ability, bool learned, TalentTreeNode leftNode, TalentTreeNode rightNode)
        {
            abilityName = ability;
            learnedTalent = learned;
            this.leftNode = leftNode;
            this.rightNode = rightNode;
        }
    }
}
