using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnOrderedMultiMapTest
{
	public enum enumtest
	{
		None = 0,
		a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z,
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			UnOrderedMultiMapWapper.CSharpUnOrderedMultiMap<int, int> test = new UnOrderedMultiMapWapper.CSharpUnOrderedMultiMap<int, int>();
			UnOrderedMultiMapWapper.CSharpUnOrderedMultiMap<int, int> test1 = new UnOrderedMultiMapWapper.CSharpUnOrderedMultiMap<int, int>();
			for (int i = 11; i >= 0; i--)
			{
				test.emplace(i + 1, (i + 2));
				test1.emplace(i + 10, (i + 20));
			}
			foreach (var iter in test)
			{
				Console.WriteLine("foreach value : " + ((UnOrderedMultiMapWapper.CShorpUnOrderedMultiNode<int, int>)iter).GetValue());
			}
			Console.WriteLine("=====================================");
			Console.WriteLine("=====================================");
			for (var iter = test.begin(); iter != test.end(); iter++)
			{
				Console.WriteLine(iter.GetValue());
			}
			Console.WriteLine("=====================================");
			Console.WriteLine("=====================================");
			for (var iter = test.rbegin(); iter != test.rend(); iter++)
			{
				Console.WriteLine(iter.GetValue());
			}
			Console.WriteLine(test.rend().GetValue());

			UnOrderedMultiMapWapper.CSharpUnOrderedMultiMap<string, myclass> StringClassMulitMap = new UnOrderedMultiMapWapper.CSharpUnOrderedMultiMap<string, myclass>();
			for (int j = 0; j < 2; j++)
				for (int i = 0; i < 40; i++)
				{
					StringClassMulitMap.emplace(i.ToString(), new myclass());
				}

			Console.WriteLine("=====================================");
			Console.WriteLine("=====================================");

			for (var iter = StringClassMulitMap.begin(); iter != StringClassMulitMap.end(); ++iter)
			{
				Console.WriteLine(iter.GetValue().name);
			}
			Console.WriteLine("=====================================");
			Console.WriteLine("=====================================");

			UnOrderedMultiMapWapper.CSharpUnOrderedMultiMap<myclass, string> ClassStringMulitMap = new UnOrderedMultiMapWapper.CSharpUnOrderedMultiMap<myclass, string>();

			int tempNum = 0;
			for (int i = 0; i < 40; i++)
			{
				var tempclass = new myclass();
				for (int j = 0; j < 2; j++)
				{
					ClassStringMulitMap.emplace(tempclass, tempNum.ToString());
					tempNum++;
				}
			}
			myclass testmyclass = new myclass();
			ClassStringMulitMap.emplace(testmyclass, "안녕하세요~!(Hello~!)");
			ClassStringMulitMap.emplace(testmyclass, "안녕~!(Hi~!)");
			Console.WriteLine("=====================================");
			Console.WriteLine("=====================================");

			for (var iter = ClassStringMulitMap.begin(); iter != ClassStringMulitMap.end(); ++iter)
			{
				Console.Write(iter.GetKey().name);
				Console.Write(" <= 클래스 이름 : String 값=> ");//Class Name : String Value
				Console.WriteLine(iter.GetValue());
			}

			{
				var testiter = ClassStringMulitMap.end();
				--testiter;
				testiter.SetValue("안녕하십니까?(Hello!)");
				--testiter;
				testiter.SetValue("진지 잡수셨습니까?(Have you had your meal, sir?)");
			}

			Console.WriteLine("=====================================");
			Console.WriteLine("=====================================");
			for (var iter = ClassStringMulitMap.begin(); iter != ClassStringMulitMap.end(); ++iter)
			{
				Console.Write(iter.GetKey().name);
				Console.Write(" <= 클래스 이름 : String 값=> ");//Class Name : String Value
				Console.WriteLine(iter.GetValue());
			}
			Console.WriteLine("=====================================");
			Console.WriteLine("=====================================");

			UnOrderedMultiMapWapper.CShorpUnOrderedMultiNode<myclass, string> TestNodeIterStart;// = new MultiMapWapper.CShorpMultiNode<myclass, string>();
			UnOrderedMultiMapWapper.CShorpUnOrderedMultiNode<myclass, string> TestNodeIterEnd = new UnOrderedMultiMapWapper.CShorpUnOrderedMultiNode<myclass, string>();
			TestNodeIterStart = ClassStringMulitMap.equal_range(testmyclass); // 노드 자체를 데입 // Wrap the node itself
			TestNodeIterEnd %= ClassStringMulitMap.KeyEnd(); // % 노드의 값을 복사함 // % copy the value of the node.

			for (; TestNodeIterStart != TestNodeIterEnd; TestNodeIterStart++)
			{
				Console.WriteLine(TestNodeIterStart.GetValue());
			}
			Console.WriteLine("=====================================");
			Console.WriteLine("=====================================");

			if (StringClassMulitMap.contains("10"))
			{
				var find_element = StringClassMulitMap.find("10");
				Console.WriteLine(find_element.GetValue().name);
			}

			StringClassMulitMap.clear();

			Console.WriteLine("클리어 완료(Clear complete)");
			Console.WriteLine(StringClassMulitMap.size());
			Console.WriteLine("=====================================");
			Console.WriteLine("=====================================");
			Console.WriteLine("===============Swap==================");
			UnOrderedMultiMapWapper.CSharpUnOrderedMultiMap<myclass, string> ClassStringMulitMap1 = new UnOrderedMultiMapWapper.CSharpUnOrderedMultiMap<myclass, string>();
			ClassStringMulitMap1.Swap(ClassStringMulitMap);
			{
				var testiter = ClassStringMulitMap1.end();
				--testiter;
				testiter.SetValue("밥먹었니?(Have you eaten?)");
			}
			for (var iter = ClassStringMulitMap1.begin(); iter != ClassStringMulitMap1.end(); ++iter)
			{
				Console.Write(iter.GetKey().name);
				Console.Write(" <= Class Name : String Value=> ");//Class Name : String Value
				Console.WriteLine(iter.GetValue());
			}
			Console.WriteLine("original multimap size : " + ClassStringMulitMap.size());
			Console.WriteLine("=====================================");
			Console.WriteLine("=====================================");
			ClassStringMulitMap.erase(ClassStringMulitMap.begin(), ClassStringMulitMap.end());
			Console.WriteLine(ClassStringMulitMap.size());
			Console.WriteLine("지우기 완료(Deletion complete)");
			ClassStringMulitMap.clear();
			Console.WriteLine("=====================================");
			Console.WriteLine("=====================================");
			Console.WriteLine("===============Swap==================");
			test.Swap(test1);
			for (var iter = test.begin(); iter != test.end(); iter++)
			{
				Console.WriteLine("Key : " + iter.GetKey() + " , Value : " + iter.GetValue());
			}

			Console.WriteLine("=====================================");
			Console.WriteLine("=====================================");
			Console.WriteLine("=========copy constructor============");
			UnOrderedMultiMapWapper.CSharpUnOrderedMultiMap<int, int> CopyUnorderedMultimap = null;
			CopyUnorderedMultimap = new UnOrderedMultiMapWapper.CSharpUnOrderedMultiMap<int, int>(test1);

			for (var iter = CopyUnorderedMultimap.begin(); iter != CopyUnorderedMultimap.end(); iter++)
			{
				Console.WriteLine("Key : " + iter.GetKey() + " , Value : " + iter.GetValue());
			}
			UnOrderedMultiMapWapper.CSharpUnOrderedMultiMap<enumtest, int> ENUMTEST = new UnOrderedMultiMapWapper.CSharpUnOrderedMultiMap<enumtest, int>();

			Random randomTest = new Random();

			for (int i = 20; i >= 0; i--)
			{
				ENUMTEST.emplace((enumtest)randomTest.Next(0, 26), (i + 2));
			}
			Console.WriteLine("=====================================");
			Console.WriteLine("=====================================");
			Console.WriteLine("=========Enum========================");
			for (var iter = ENUMTEST.begin(); iter != ENUMTEST.end(); iter++)
			{
				Console.WriteLine("Key : " + iter.GetKey() + " , Value : " + iter.GetValue());
			}
			while (true) { }
		}
	}
}

public class myclass
{
	public string name;
	public int ID = 0;
	public static int Number = 0;
	public myclass()
	{
		name = "Class Name : " + Number.ToString();
		ID = Number;
		Number++;
	}
}