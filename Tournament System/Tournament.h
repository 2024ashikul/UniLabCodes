#ifndef TOURNAMENT_H
#define TOURNAMENT_H

#include<iostream>
#include <algorithm>
#include<string>
#include<fstream>
#include <iomanip>
#include "print.h"
#include "addPerfomer.h"
#include "Tournament.h"
using namespace std;


//declaring the structures that are required to run the program
struct Perfomer
{
    string name;
    string type;
    int perfomance[3];
    int total ;
    int rank ;
};
 

//sort function using a defined variable
bool compare(const Perfomer& a,const Perfomer& b);



#endif