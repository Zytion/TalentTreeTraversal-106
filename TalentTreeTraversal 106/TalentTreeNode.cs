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
		public string AbiltiyName { get { return abilityName; } set { abilityName = value; } }
		/// <summary> Boolean indicating if the player has learned this talent </summary>
		public bool LearnedTalent { get { return learnedTalent; } set { learnedTalent = value; } }
		/// <summary> Left child node </summary>
		public TalentTreeNode LeftNode { get { return leftNode; } set { leftNode = value; } }
		/// <summary> Right child node </summary>
		public TalentTreeNode RightNode { get { return rightNode; } set { rightNode = value; } }

		/// <summary>
		/// Initalizes an ability that is either learned or not.
		/// </summary>
		/// <param name="ability"></param>
		/// <param name="learned"></param>
		public TalentTreeNode(string ability, bool learned)
		{
			abilityName = ability;
			learnedTalent = learned;
			leftNode = null;
			rightNode = null;
		}
		/// <summary>
		/// Initalizes an ability that is either learned or not. 
		/// The node has two child nodes that can be connected to it.
		/// </summary>
		/// <param name="ability"></param>
		/// <param name="learned"></param>
		/// <param name="leftNode"></param>
		/// <param name="rightNode"></param>
		public TalentTreeNode(string ability, bool learned, TalentTreeNode leftNode, TalentTreeNode rightNode)
		{
			abilityName = ability;
			learnedTalent = learned;
			this.leftNode = leftNode;
			this.rightNode = rightNode;
		}
		/// <summary> Prints all of the abilities in the tree using “in order” traversal </summary>
		public void ListAllAbilities()
		{
			if(leftNode != null)
				leftNode.ListAllAbilities();
			Console.Write(abilityName + ", ");
			if(rightNode != null)
				rightNode.ListAllAbilities();
		}
		/// <summary> Prints out which abilities the player know </summary>
		public void ListKnownAblilites()
		{
			if (learnedTalent)
			{
				Console.Write(abilityName + ", ");
				if (leftNode != null)
					leftNode.ListKnownAblilites();
				if (rightNode != null)
					rightNode.ListKnownAblilites();
			}
		}
		/// <summary> Prints the abilities the player could learn next </summary>
		public void ListPossibleAbilites()
		{
			if (!learnedTalent)
			{
				Console.Write(abilityName + ", ");
			}
			else
			{
				if (leftNode != null)
					leftNode.ListPossibleAbilites();
				if (rightNode != null)
					rightNode.ListPossibleAbilites();
			}
		}
	}
}
