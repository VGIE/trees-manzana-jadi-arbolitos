namespace Trees
{

    public class Tree<T>
    {
        public TreeNode<T> RootNode = null;

        public override string ToString()
        {
            if (RootNode == null)
                return null;
            else return null;//RootNode.ToString(0, 0);
        }
    }
}