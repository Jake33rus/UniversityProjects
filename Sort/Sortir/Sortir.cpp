// Sortir.cpp: ���������� ����� ����� ��� ����������� ����������.
//

#include "stdafx.h"
#include "iostream"
#include "cstdio"
#include "iomanip"
#include "string"
#include "locale"
#include <windows.h>

using namespace std;
class VvodZnach {
	int k = 0, n;

public:
	int setRazmer() {
		if (k == 0) {
			cout << "������� ������ �������: ";
			cin >> n;
			k = 1;
			return n;
		}
		if (k == 1) { return n; }
	}
	int * vvodChisMas() {
		int n = setRazmer();
		int *mas = new int[n];
		for (int i = 0; i < n; i++) {
			cout << "������� �������� " << i + 1 << " ��������: ";
			cin >> mas[i];
		}

		return mas;
	}
	string vvodStr() {
		string str;
		cout << "������� ����� ���� ��� ������������: ";
		cin >> str;
		return str;
	}
};
class SortAlgoChisla
{
public:
	void SortAlgoChisla::selectionSort(int *data1, int n)
	{
		int j = 0;
		int tmp = 0;
		for (int i = 0; i < n; i++) {
			j = i;
			for (int k = i; k < n; k++) {
				if (data1[j] > data1[k]) {
					j = k;
				}
			}
			tmp = data1[i];
			data1[i] = data1[j];
			data1[j] = tmp;
		}
		for (int i = 0; i < n; i++) {
			cout << data1[i];
			cout << " ";
		}
		cout << endl;
	}

	void SortAlgoChisla::bubbleSort(int *data1, int n)
	{
		int tmp = 0;
		for (int i = 0; i < n; i++) {
			for (int j = (n - 1); j >= (i + 1); j--) {
				if (data1[j] < data1[j - 1]) {
					tmp = data1[j];
					data1[j] = data1[j - 1];
					data1[j - 1] = tmp;
				}
			}
		}
		for (int i = 0; i < n; i++) {
			cout << data1[i];
			cout << " ";
		}
		cout << endl;
	}

	void SortAlgoChisla::insertionSort(int *data1, int n)
	{
		int key = 0;
		int i = 0;
		for (int j = 1; j < n; j++) {
			key = data1[j];
			i = j - 1;
			while (i >= 0 && data1[i] > key) {
				data1[i + 1] = data1[i];
				i = i - 1;
				data1[i + 1] = key;
			}
		}
		for (int i = 0; i < n; i++) {
			cout << data1[i];
			cout << " ";
		}
		cout << endl;
	}

	void SortAlgoChisla::mergeSort(int *data, int lenD)
	{
		if (lenD > 1) {
			int middle = lenD / 2;
			int rem = lenD - middle;
			int* L = new int[middle];
			int* R = new int[rem];
			for (int i = 0; i < lenD; i++) {
				if (i < middle) {
					L[i] = data[i];
				}
				else {
					R[i - middle] = data[i];
				}
			}

			mergeSort(L, middle);
			mergeSort(R, rem);
			merge(data, lenD, L, middle, R, rem);
			if (lenD == lenD) {
				for (int i = 0; i < lenD; i++) {
					cout << data[i];
					cout << " ";
				}
				cout << endl;
			}
		}

	}
	void SortAlgoChisla::merge(int merged[], int lenD, int L[], int lenL, int R[], int lenR) {
		int i = 0;
		int j = 0;
		while (i < lenL || j < lenR) {
			if ((i < lenL) & (j < lenR)) {
				if (L[i] <= R[j]) {
					merged[i + j] = L[i];
					i++;
				}
				else {
					merged[i + j] = R[j];
					j++;
				}
			}
			else if (i < lenL) {
				merged[i + j] = L[i];
				i++;
			}
			else if (j < lenR) {
				merged[i + j] = R[j];
				j++;

			}

		}
	}
};
class SortAlgoText
{
public:
	void alphSort()//���������� ���� � ������ �� ��������
	{
		VvodZnach v1;
		string st = v1.vvodStr();
		for (size_t i = 0; i < st.length(); i++)
			for (size_t j = 0; j < st.length(); j++)
			{
				int a = int(st[j]);
				int b = int(st[j + 1]);
				if (a > b)
				{
					char buf = st[j];
					st[j] = st[j + 1];
					st[j + 1] = buf;
				}
			}
		cout << st << "\n";
	}
	void sortMain() {
		int count_word = 0;
		string *S = new string[count_word]; //������ �����
		string MyStr = GetMyStr(count_word);
		cout << "***********��������� ���� ������***********\n\n";
		//cout<<MyStr;  //MyStr == ������������� ������
		//����� ������� ��� ������ ����� ������� �� ���� GetStrFromMyStr (��������� � ��� �������)


											//��������� ������ ��������
		for (int i = 0; i<count_word; i++) {
			S[i] = GetStrFromMyStr(MyStr, i + 1);
		}


		sort(S, count_word); //�������� ������

							 //������� ������ �� �����
		for (int i = 0; i<count_word; i++) {
			cout << S[i] << "\n";
		}
		delete[]S;
	}
	//���������� ���������� �����
	string GetMyStr(int &count_word) {

		string S, temp; //S - ��� �������� ������, � ��� ������ ���������� � ����������
						//temp - ��� �������� ������, ���������������� �� ���� ���������� ����� � S

		cout << "��� ����������� ����� ����� CTRL+Z ��� ����� ������ ������ (����� Enter)\n";
		while ((getline(cin, S)) && (S.length())>2) {   //��������� ������� � ����������
			temp = temp + S + '\n';  //���������� ������ � temp
			count_word++;      //����������� ������� �����	

		}
		return temp;	//���������� ���������������� ������
	}

	/*������� ��� ��������� ������ �� ������ ������*/
	string GetStrFromMyStr(string S, int N) {

		int i = 0;		//���������� ����������� ������������
		string buf;	//������������� ������
		const char *temp = (S.c_str()); //��������� �� ������ ������ S

		while (i != N) {	//���� �� �� �������� ����������� ��������� ����� ���, ����� ����
			while (*temp != '\n') {		//���� �����������	
				if (i == N - 1) buf = buf + *temp;	//���� ��������� �������� ���������, �� �������� �������� ������� (��� �� �����, ������ �� ������)
				*temp++;	//������� � ���������� �������
			}
			*temp++;	//������� � ���� �������
			i++;		//����������� ������� ������������
		}
		return buf;		//���������� ��������� �������
	}

	/*������� ���������� �����*/
	void sort(string *S, int N)
	{
		for (int i = 0; i < N - 1; i++)
			for (int j = i + 1; j < N; j++) {
				if (strcmp(S[i].c_str(), S[j].c_str())>0) swap(S[i], S[j]);
			}
	}


};
class SortChisla {
public:
	void viborMetoda() {
		SortAlgoChisla v1;
		VvodZnach v2;
		int v, n = 0;
		int *l = v2.vvodChisMas();
		int t = v2.setRazmer();
		cout << t+"\n";
		cout << "�������� ����� ����������:\n ������� 1 - ���������� ������� (Selection sort)\n ������� 2 - ����������� ���������� (Bubble sort)\n ������� 3 - ���������� �������� (Insertion sort)\n ������� 4 - ���������� �������� (Merge sort)\n : ";
		cin >> v;
		while (n != 1) {
			switch (v) {
			case 1:
				v1.selectionSort(l,t); n = 1;
				break;
			case 2:
				v1.bubbleSort(l, t); n = 1;
				break;
			case 3:
				v1.insertionSort(l, t); n = 1;
				break;
			case 4:
				v1.mergeSort(l, t); n = 1;
				break;
			default:
				cout << "������� �������� ��� ��� - ";
				cin >> v;
				break;
			}
		}
	}
};
class SortText {
public:
	void viborMetoda2() {
		SortAlgoText v1;
		int v;
		cout << "�������� ����� ����������:\n ������� 1 - ���������� ���� � ������ �� ��������\n ������� 2 - ���������� ���������� �����\n : ";
		cin >> v;
		if (v == 1)
			v1.alphSort();
		if (v == 2) {
			v1.sortMain();
		}
	}
};

class ViborObject {
public:
	void chislaOrText() {
		SortChisla v1;
		SortText v2;
		int k;
		cout << "�������� ������ ���������� ����������:\n";
		cout << "���� �� ������ ������������� �����, ������� 1, ���� ����� ��� ������, ������� 2:";
		cin >> k;
		if (k == 1)
			v1.viborMetoda();
		if (k == 2)
			v2.viborMetoda2();
	}
};

int main(int argc, _TCHAR* argv[])
{
	setlocale(LC_ALL, "RUSSIAN");
	ViborObject v1;
	v1.chislaOrText();
	system("PAUSE");
	return 0;
}







