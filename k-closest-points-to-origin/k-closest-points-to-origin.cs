 public class Solution {
		public int[][] KClosest(int[][] points, int k) {
			// Create a max heap
			var maxHeap = new PriorityQueue<int[], int>(new MaxHeapInt32Comparer());
            //지정된 사용자 지정 우선 순위 비교자를 사용하여 클래스의 PriorityQueue<TElement,TPriority> 새 인스턴스를 초기화합니다.

			// Custom priority function (ignoring the Math.Sqrt calculation)
			var getDistanceToOrigin = (int[] point) => point[0] * point[0] + point[1] * point[1];

			// Traverse and insert points to the max heap
			foreach (var point in points)
			{
				maxHeap.Enqueue(point, getDistanceToOrigin(point));
                //값넣기
				// Pop out the root element if the max heap size is larger than K
				if (maxHeap.Count > k)
				{
					maxHeap.Dequeue();
                    //값빼기
				}
			}

			// Extract closest points into an array
			var res = new List<int[]>();
			while (maxHeap.Count > 0) res.Add(maxHeap.Dequeue());

			return res.ToArray();
	}

}

public class MaxHeapInt32Comparer : IComparer<int>
{
	public int Compare(int x, int y)
	{
		return y - x;
	}
}