
Console.WriteLine(new Solution().Search([-1, 0, 3, 5, 9, 12], 9));

public class Solution
{
	public int Search(int[] nums, int target)
	{
		double devider = 2;
		int searchingPos = 0;

		if (nums.Length % 2 == 0)
			searchingPos = (int)Math.Round(nums.Length / devider, MidpointRounding.AwayFromZero);
		if (nums.Length % 2 != 0)
			searchingPos = (int)Math.Round(nums.Length / devider, MidpointRounding.ToZero);

		int shift;

		while (nums[searchingPos] != target)
		{
			devider *= 2;
			shift = (int)Math.Round(nums.Length / devider, MidpointRounding.AwayFromZero);

			if (nums[searchingPos] > target)
				searchingPos -= shift;

			if (nums[searchingPos] < target)
				searchingPos += shift;

			if (searchingPos >= nums.Length || shift == 0)
				return -1;
		}

		return searchingPos;
	}
}