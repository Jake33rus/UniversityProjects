#include <string>

using namespace std;

class Panda
{
	int health;
	int power;
	int mood;

public:
	Panda()
	{
		health = 100;
		power = 100;
		mood = 100;
	}

	Panda(int health, int power, int mood)
	{
		this->health = health;
		this->power = power;
		this->mood = mood;
	}

	void declainHealth(int declain)
	{
		if (health - declain >= 0)
			health -= declain;
	}
	void declainPower(int declain)
	{
		if (power - declain >= 0)
			power -= declain;
	}
	void declainMood(int declain)
	{
		if (mood - declain >= 0)
			mood -= declain;
	}

	void growthHealth(int growth)
	{
		if (health + growth <= 100)
			health += growth;
		else health = 100;
	}
	void growthPower(int growth)
	{
		if (power + growth <= 100)
		power += growth;
		else power = 100;
	}
	void growthMood(int growth)
	{
		if (mood + growth <= 100)
			mood += growth;
		else mood = 100;
	}

	int getHealth() { return health; }
	int getPower() { return power; }
	int getMood() { return mood; }
};