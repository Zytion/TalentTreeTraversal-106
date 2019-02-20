using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentTreeTraversal_106
{
    class Program
    {
        static void Main(string[] args)
        {
            TalentTreeNode node6 = new TalentTreeNode("Grappling Hook", true);
            TalentTreeNode node5 = new TalentTreeNode("Double Dash", false);
            TalentTreeNode node4 = new TalentTreeNode("Glide", false);
            TalentTreeNode node3 = new TalentTreeNode("Wall Climb", false);
            TalentTreeNode node2 = new TalentTreeNode("Double Jump", false, node4, node3);
            TalentTreeNode node1 = new TalentTreeNode("Dash", true, node6, node5);
            TalentTreeNode node0 = new TalentTreeNode("Sprint", true, node1, node2);

			Console.Write("All Abilites: ");
			node0.ListAllAbilities();

			Console.Write("\n\nLearned Abilites: ");
			node0.ListKnownAblilites();

			Console.Write("\n\nPossible Abilites: ");
			node0.ListPossibleAbilites();

			Console.ReadLine();
        }
    }
}
