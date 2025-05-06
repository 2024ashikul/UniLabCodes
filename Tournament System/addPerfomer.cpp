#ifndef ADDPERFOMER_H
#define ADDPERFOMER_H

#include<iostream>
#include <algorithm>
#include<string>
#include<fstream>
#include "Tournament.h"
#include "print.h"
#include <iomanip>
using namespace std;
#include "addPerfomer.h"

ifstream In("input.txt");
void addPerfomer(int n, vector<Perfomer>&forwards){
    for (int i = 0; i < n; i++)
    {   
        struct Perfomer temp;
        In >> temp.name;
        temp.total=0;
        for (int j = 0; j < 3; j++)
        {
            In >> temp.perfomance[j];
            temp.total = temp.total + temp.perfomance[j];
        }
        forwards.push_back(temp);
    }
}

#endif