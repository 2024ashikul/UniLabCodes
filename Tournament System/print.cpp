
#include<iostream>
#include <algorithm>
#include<string>
#include<fstream>
#include "Tournament.h"

#include <iomanip>
using namespace std;

void print(ofstream &File,string type,string modifier1,vector<Perfomer>temp){
    File << "==============================\n";
    File << type << " Rankings : \n";
    File << setw(10) << "Rank" << setw(20) << "Name" << setw(10) << "Match 01" << setw(10) << "Match 02" << setw(10) << "Match 03" << setw(10) << "Total" << endl;
    for (int i = 0; i < temp.size()/2; i++)
    {
    File << setw(10) <<  i+1 << setw(20) << temp[i].name << setw(10) << temp[i].perfomance[0] << setw(10) << temp[i].perfomance[1] << setw(10) << temp[i].perfomance[2] << setw(10) << temp[i].total << endl;
    }
}

