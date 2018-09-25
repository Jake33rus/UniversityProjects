#include <list>
#include "Parser.cpp"

class Controller 
{
public:
	Controller() {}
	Parser parser;
	Car SelectedCar;
	void UpdateSelCar(Car c) {
		SelectedCar = c;
	}
	list<Car>Load(int i) {
		switch (i)
		{
		case 1:
			return parser.GetAudi();
		case 2:
			return parser.GetBMW();
		case 3:
			return parser.GetNissan();
		case 4:
			return parser.GetKia();
		case 5:
			return parser.GetAllCars();
		default:
			break;
		}
	}

	string Converter(System::String^ s) {
		char cStr[50] = { 0 };
		if (s->Length < sizeof(cStr))
			sprintf(cStr, "%s", s);
		string stlString(cStr);
		return stlString;
	}

	list<Car>Search(string mk, string mod, string prc, string tp, list<Car> Cars) {
		list<Car> buf;
		if (mk != "")
			for each(Car c in Cars)
			{
				if (c.GetMark() == mk)
					buf.push_back(c);
			}
		else buf = Cars;
		Cars.erase(Cars.begin(), Cars.end());

		if (mod != "")
			for each(Car c in buf)
			{
				if (c.GetModel() == mod)
					Cars.push_back(c);
			}
		else Cars = buf;
		buf.erase(buf.begin(), buf.end());

		if (tp != "")
			for each(Car c in Cars)
			{
				if (c.GetType() == tp)
					buf.push_back(c);
			}
		else buf = Cars;
		Cars.erase(Cars.begin(), Cars.end());

		if (prc != "")
			for each(Car c in buf)
			{
				if (c.GetPrice() == stoi(prc))
					Cars.push_back(c);
			}
		return buf;
	}
	Car oneCarSrch(string mark, string model, string price, string color, string compType)
	{
		list<Car> buf;

		if (mark == "Audi")buf = parser.GetAudi();
		else if (mark == "BMW")buf = parser.GetBMW();
		else if (mark == "Nissan")buf = parser.GetNissan();
		else buf = parser.GetKia();

		for each(Car c in buf)
		{
			if ((c.GetModel() == model) && (c.GetCompType() == compType) && (c.GetPrice() == stoi(price)) && (c.GetColor() == color))
				return c;
		}
	}
};