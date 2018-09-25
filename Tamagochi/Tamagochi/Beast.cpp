#include <string>

using namespace std;

class Beast {
	string name;
	int health, happy, fullness;
public:
	Beast() {}
		Beast(string name)
	{		
			this->name = name;
			health = 100;
			happy = 100;
			fullness = 100;
	}
		Beast(string n, int hp, int h, int e)
		{
			name = n;
			health = hp;
			happy = h;
			fullness = e;
		}
		string GetName() { return name; }
		int GetHP() { return health; }
		int GetHappy() { return happy; }
		int GetFullness() { return fullness; }
		void SetHP(int p) {
			if ((health + p) > 100)
				health = 100;
			else health += p;
			happy -= 15;
		}
		void SetHappy(int p) {
			if ((happy + p) > 100)
				happy = 100;
			else happy += p;
			fullness -= 5;
			health -= 5;
		}
		void SetEat(int p) {
			if ((fullness + p) > 100)
				fullness = 100;
			else fullness += p;
			happy += 5;
		}
};