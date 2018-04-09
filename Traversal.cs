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
			//return Travel
			//(
			//	tree,
			//	t => t,
			//	j => j.Left 
			//	j => j.Name
			//);
			throw new NotImplementedException();
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
			//return Travel
			//(
			//	tree,
			//	j => j.Categories,
			//	j => j.Categories == null,
			//	j => j.Products.Select(p => p.Name)
			//);
			throw new NotImplementedException();
		}

		public static IEnumerable<Tout> Travel<Tin, Tout>(Tin root, Func<Tin,IEnumerable<Tin>> childrenSelector, Func<Tin,bool> filter, Func<Tin, Tout> resultSelector)
		{
			if (filter(root))
				yield return resultSelector(root);
			else
			{
				foreach (var item in childrenSelector(root))
				{
					if (filter(item))
						yield return resultSelector(item);
					else
					{
						foreach (var item2 in Travel(item, childrenSelector, filter, resultSelector))
						{
							yield return item2;
						}
					}
				}
			}
		}
	}



}
