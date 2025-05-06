
#include<iostream>
#include <algorithm>
#include<string>
#include<fstream>
#include <iomanip>
#include "print.h"
#include "addPerfomer.h"
#include "Tournament.h"
using namespace std;

ofstream File("output.txt");
ifstream In("input.txt");




int main(){
    int number_of_forwards,number_of_goalkeepers,number_of_referees;
    In >> number_of_forwards >> number_of_goalkeepers >> number_of_referees;
    
    //initializing the vectors of structures
    vector<Perfomer>forwards(number_of_forwards);
    vector<Perfomer>goalkeepers(number_of_goalkeepers);
    vector<Perfomer>referees(number_of_referees);

    //taking input for performers
    addPerfomer(number_of_forwards,forwards);
    addPerfomer(number_of_goalkeepers,goalkeepers);
    addPerfomer(number_of_referees,referees);
    
    //Sorting Forwards, Goalkeepers and Referees according to their own attributes as given in the question
    sort(forwards.begin(),forwards.end(),compare);
    sort(goalkeepers.begin(),goalkeepers.end(),compare);
    sort(referees.begin(),referees.end(),compare);
    
    //Printing Forward Details
    print(File,"Forward","Goals",forwards);
    print(File,"Goalkeeper","Saves",goalkeepers);
    print(File,"Referees","Wrong decisions",referees);

}
