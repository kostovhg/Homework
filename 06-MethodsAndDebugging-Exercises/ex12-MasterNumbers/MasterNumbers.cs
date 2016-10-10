using System;
using System.Linq;

namespace ex12_MasterNumbers
{
	class MasterNumbers
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n ; i++)
			{
				if(IsPalindrome(i) && ContainsEvenDigit(i) && SumOfDigits(i))
				{
					Console.WriteLine(i);
				}
			}

		}

		static bool IsPalindrome(int num)
		{
			bool isPalindrome = true;

			string normal = num.ToString();
			for (int i = 0; i <= normal.Length/2; i++)
			{
				if (normal[i] != normal[normal.Length - i -1])
				{
					isPalindrome = false;
					break;
				}
			}

			return isPalindrome;
		}

		static bool SumOfDigits(int num)
		{
			int sum = 0;


			while (num > 0)
			{
				sum += num % 10;
				num /= 10;
			}

			if (sum % 7 == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static bool ContainsEvenDigit(int num)
		{
			bool containEven = false;
			string number = num.ToString();

			for (int i = 0; i <= number.Length/2; i++)
			{
				int digit = number[i] - 48;
				if (digit%2 == 0)
				{
					containEven = true;
					break;
				}
			}

			if(containEven)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
