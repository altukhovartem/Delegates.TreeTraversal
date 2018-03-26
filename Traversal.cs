using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.TreeTraversal
{
	public static class Traversal
	{
		public static IEnumerable<int> GetBinaryTreeValues(BinaryTree<int> tree)
		{
			throw new NotImplementedException();
		}

		public static IEnumerable<Job> GetEndJobs(Job tree)
		{
			throw new NotImplementedException();
		}

		public static IEnumerable<Product> GetProducts(ProductCategory tree)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<T>  Travel<...>(root, childrenSelector, filter, resultSelector)
	}

	public static class Helper<T1, T2, T3, T4>
	{
		public static IEnumerable<T1> GeneralTraversal(T1 currentObject, Func<T1,T2> Successors, Func<T2, T3> InterestedSuccessors, Func<T4> GetResult)
		{
			throw new NotImplementedException();
		}

	}


}
