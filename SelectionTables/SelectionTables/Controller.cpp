#include <list>
#include "WorkToXml.cpp"
class Controller {
	WorkToXML worker;
	list<Table> tables;
	list<Table> sortTables;
public:
	Controller(){}
	void LoadTables() {
		 tables = worker.Load();
	}
	list<Table>Search(string color, string material, string country) {
		sortTables.clear();
		if (color != "" && material !="" && country !="")
			for each(Table t in tables)
			{
				if (t.GetColor() == color && t.GetMaterial() == material && t.GetCountry() == country)
					sortTables.push_back(t);
			}
		if (color == "" && material == "" && country == "")
			return tables;
		if (color != "" && material != "" && country == "")
			for each(Table t in tables)
			{
				if (t.GetColor() == color && t.GetMaterial() == material)
					sortTables.push_back(t);
			}
		if (color == "" && material != "" && country != "")
			for each(Table t in tables)
			{
				if (t.GetCountry() == country && t.GetMaterial() == material)
					sortTables.push_back(t);
			}
		if (color != "" && material == "" && country != "")
			for each(Table t in tables)
			{
				if (t.GetColor() == color && t.GetCountry() == country)
					sortTables.push_back(t);
			}
		if (color != "" && material == "" && country == "")
			for each(Table t in tables)
			{
				if (t.GetColor() == color)
					sortTables.push_back(t);
			}
		if (color == "" && material != "" && country == "")
			for each(Table t in tables)
			{
				if (t.GetMaterial() == material)
					sortTables.push_back(t);
			}
		if (color == "" && material == "" && country != "")
			for each(Table t in tables)
			{
				if (t.GetCountry() == country)
					sortTables.push_back(t);
			}
		return sortTables;
	}
	string Converter(System::String^ s) {
		char cStr[50] = { 0 };
		if (s->Length < sizeof(cStr))
			sprintf(cStr, "%s", s);
		string stlString(cStr);
		return stlString;
	}
	Table SerchOne(string name) {
		for each(Table t in tables) {
			if (name == t.GetName())
				return t;
		}
	}
};