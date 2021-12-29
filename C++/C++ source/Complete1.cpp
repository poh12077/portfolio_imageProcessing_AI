# include <iostream>
using namespace std;


class FunctionSet 
{
	public:

	void DeterminationFunction(int Input);
};

void FunctionSet::DeterminationFunction(int Input) 
{


	int InputCopy = Input;
	int Output;
	int Prime;
	int Count = 0;

	for (int x = 2; x < Input / 2 + 1; x++)
	{


		int SqrtX = sqrt(x) / 1;

		try
		{
			if (x == 2 || x == 3)
			{
				throw (x);
			}
			else
			{

				for (int i = 2; i < SqrtX + 1; i++)
				{
					if (x % i == 0)
					{
						// x is not a prime 

						break;
					}
					if (i == SqrtX)
					{
						Prime = x;
						// x is prime
					}
				}
			}
		}
		catch (int x)
		{
			Prime = x;
			//x  is prime\n";
		}


		Output = InputCopy - Prime;


		int SqrtOutput = sqrt(Output) / 1;

		try
		{
			if (Output == 2 || Output == 3)
			{
				throw (Output);
			}
			else
			{

				for (int i = 2; i < SqrtOutput + 1; i++)
				{
					if (Output % i == 0)
					{
						// output is not a prime \n";

						break;
					}
					if (i == SqrtOutput)
					{
						//output is prime
						cout << Input << " = " << Prime << " + " << Output << '\n';
						Count++;
						Prime = Input;
					}
				}
			}
		}
		catch (int Output3)
		{
			cout << Input << " = " << Prime << " + " << Output3 << '\n';
			//cout << x << " is prime\n";
		}


		//cout << '\n' << Count << '\n';

	}
	cout << '\n' << "경우의 수 : " << Count << '\n';

}

int main()
{
	int x;
	cout << "4보다 크거나 같은 짝수를 입력하시오 : "  ;
	cin >> x ;
	cout << '\n';
	
	FunctionSet Function;
	Function.DeterminationFunction(x);
	
	return 0;

}