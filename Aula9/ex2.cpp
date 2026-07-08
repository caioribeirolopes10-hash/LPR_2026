#include <iostream>
#include <list>
#include <algorithm>
using namespace std;

int main()
{
    list<list<string>> grupos;
    for (auto& grupo : grupos)
    {
        grupo.sort([](string a, string b)
        {
            return a.length() < b.length();
        });
    }

    grupos.sort([](list<string> a, list<string> b)
    {
        return a.size() > b.size();
    });

    for (auto grupo : grupos)
    {
        for (auto it = grupo.begin(); it != grupo.end(); it++)
        {
            cout << *it;

            if (next(it) != grupo.end())
                cout << ", ";
        }
        cout << endl;
    }
}