
using System;
using System.Xml;
using Lists;

namespace Trees
{
    public class TreeNode<T>
    {
        private T Value;
        //TODO #1: Declare a member variable called "Children" as a list of TreeNode<T> objects
        public TreeNode<T> Children;
        public TreeNode<T> RootNode = null;
        public TreeNode(T value)
        {
            //TODO #2: Initialize member variables/attributes
            TreeNode<T> arbol = new TreeNode<T>(value);
            
        }

        public string ToString(int depth, int index)
        {
            //TODO #3: Uncomment the code below
            
            string output = null;
            string leftSpace = null;
            for (int i = 0; i < depth; i++) leftSpace += " ";
            if (leftSpace != null) leftSpace += "->";

            output += $"{leftSpace}[{Value}]\n";

            for (int childIndex = 0; childIndex < Children.Count(); childIndex++)
            {
            //    TreeNode<T> child = Children.Get(childIndex);
            //    output += child.ToString(depth + 1, childIndex);
            }
            return output;

        }
  
        public TreeNode<T> Add(T value)
        {
            //TODO #4: Add a new instance of class GenericTreeNode<T> with Value=value. Return the instance we just created
            TreeNode<T> arbol = new TreeNode<T>(value);
            return arbol;
            
        }

        public int Count()
        {
            //TODO #5: Return the total number of elements in this tree
            if (this != null)
            {
            return (1 + Children.Count());
            }
            return 0;  
        }

        public int Height()
        {
            //TODO #6: Return the height of this tree
            if (RootNode == null)
            {
                return 0;
            }
            if (this.Children != null)
            {
                return (1 + Children.Height());
            }
            return 0;   
        }

        public void Remove(T value)
        {
            //TODO #7: Remove the child node that has Value=value. Apply recursively
            if (Children.Value.Equals(value))
            {
                Children = null;
            }
            Children.Remove(value);
        }

        public TreeNode<T> Find(T value)
        {
            //TODO #8: Return the node that contains this value (it might be this node or a child). Apply recursively
            if (Value.Equals(value))
            {
                return this;
            }
            Children.Find(value);
            return null;
        }


        public void Remove(TreeNode<T> node)
        {
            //TODO #9: Same as #6, but this method is given the specific node to remove, not the value
            if (Children.RootNode.Equals(node))
            {
                Children = null;
            }
            Children.Remove(node);
        }
    }
}