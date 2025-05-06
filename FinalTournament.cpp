#include<iostream>
#include <algorithm>
#include<string>
#include<fstream>
#include <iomanip>
using namespace std;

ofstream File("output.txt");
ifstream In("input.txt");

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
bool compare(const Perfomer& a,const Perfomer& b){
    return a.total > b.total;
}


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

void print(ofstream &File,string type,string modifier1,vector<Perfomer>temp){
    File << "==============================\n";
    File << type << " Rankings : \n";
    File << setw(10) << "Rank" << setw(20) << "Name" << setw(10) << "Match 01" << setw(10) << "Match 02" << setw(10) << "Match 03" << setw(10) << "Total" << endl;
    for (int i = 0; i < temp.size()/2; i++)
    {
    File << setw(10) <<  i+1 << setw(20) << temp[i].name << setw(10) << temp[i].perfomance[0] << setw(10) << temp[i].perfomance[1] << setw(10) << temp[i].perfomance[2] << setw(10) << temp[i].total << endl;
    }
}

void BestPerfomer(vector<Perfomer>forward,vector<Perfomer>goalkeeper,vector<Perfomer>referee){
    Perfomer BestForward = forward[0];
    Perfomer BestGoalkeeper = goalkeeper[0];
    Perfomer BestReferee = referee[0];
    float forwardfactor = BestForward.total/1;
    float goalkeeperfactor = BestForward.total/2;
    float refereefactor = BestForward.total/3;
    File << "===================" << endl;
    File << "Best Performer : \n ";
    if (refereefactor < 1   )
    {
        File << "Best Performer is " << BestReferee.name << " with only " << BestReferee.total << " wrong decisions!!! \n"; 
    }
    else if(forwardfactor > goalkeeperfactor){
        File << "Best Performer is " << BestForward.name << " with  " << BestForward.total << " Goals!!! \n"; 
    }else {
        File << "Best Performer is " << BestGoalkeeper.name <<  " with  " << BestGoalkeeper.total << " saves !!! \n"; 
    }
    
}



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

    BestPerfomer(forwards,goalkeepers,referees);
}