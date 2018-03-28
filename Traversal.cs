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
			//return Travel
			//(
			//	tree,
			//	t => t,
			//	j => j.Left 
			//	j => j.Name
			//);
		}

		public static IEnumerable<Job> GetEndJobs(Job tree)
		{
			return Travel
			(
				tree,
				j => j.Subjobs,
				j => j.Subjobs.Count == 0,
				j => j
			);
		}

		public static IEnumerable<Product> GetProducts(ProductCategory tree)
		{
			throw new NotImplementedException();
			//return Travel
			//(
			//	tree,
			//	j => j.Categories,
			//	j => j.Categories == null,
			//	j => j.Products.Select(p => p.Name)
			//);
		}

		public static IEnumerable<Tout> Travel<Tin, Tout>(Tin root, Func<Tin,IEnumerable<Tin>> childrenSelector, Func<Tin,bool> filter, Func<Tin, Tout> resultSelector)
		{
			var selector = childrenSelector(root).Where(filter).SelectMany(n => Travel(n, childrenSelector, filter, resultSelector));
			var selector2 = Enumerable.Concat(childrenSelector(root).SelectMany(resultSelector))
				
				return childrenSelector.Invoke(root).Where(filter).Select(resultSelector); 
		}
	}



}
