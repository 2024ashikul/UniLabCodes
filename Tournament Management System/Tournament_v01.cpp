#include<iostream>
#include <algorithm>
#include<string>
#include<fstream>
#include <iomanip>
using namespace std;

ofstream File("output.txt");
ifstream In("input.txt");

//declaring the structures that are required to run the program
struct Forward
{
    string name;
    int goals_per_match[3];
    int total_goals ;
    int rank ;
};
 
struct Goalkeeper
{
    string name;
    int saves_per_match[3];
    int total_saves;
    int rank;
};

struct Referee
{
    string name;
    int wrong_decisions_per_match[3]; 
    int total_wrong_decisions;
    int rank;
};

//sort function using a defined variable
bool compareForwards(const Forward& a,const Forward& b){
    return a.total_goals > b.total_goals;
}
bool compareGoalkeepers(const Goalkeeper& a,const Goalkeeper& b){
    return a.total_saves > b.total_saves;
}
bool compareReferees(const Referee& a,const Referee& b){
    return a.total_wrong_decisions > b.total_wrong_decisions;
}







int main(){

    int number_of_forwards,number_of_goalkeepers,number_of_referees;
    cout << "Number of forwards, Number of goalkeepers , Number of Referees" << endl;
    In >> number_of_forwards >> number_of_goalkeepers >> number_of_referees;
    

    //initializing the vectors of structures
    vector<Forward>forwards(number_of_forwards);
    vector<Goalkeeper>goalkeepers(number_of_goalkeepers);
    vector<Referee>referees(number_of_referees);

    //taking input for forwards
    for (int i = 0; i < number_of_forwards; i++)
    {   
        struct Forward temp;
        cout << "Forward Name : ";
        In >> temp.name;
        temp.total_goals=0;
        cout << "Goals in last three matches : ";
        for (int j = 0; j < 3; j++)
        {
            In >> temp.goals_per_match[j];
            temp.total_goals = temp.total_goals + temp.goals_per_match[j];
        }
        forwards.push_back(temp);
    }
    
    //taking input for goalkeepers
    for (int i = 0; i < number_of_goalkeepers; i++)
    {   
        struct Goalkeeper temp;
        cout << "Goalkeeper Name :" << i+1 <<":" ;
        In >> temp.name;
        temp.total_saves=0;
        cout << "Saves in last three matches: ";
        for (int j = 0; j < 3; j++)
        {
            In >> temp.saves_per_match[j];
            temp.total_saves = temp.total_saves + temp.saves_per_match[j];
        }
        goalkeepers.push_back(temp);
    }
    //taking input for the referees
    for (int i = 0; i < number_of_referees; i++)
    {   
        struct Referee temp;
        cout << "Referee Name  "<< i+1 << ":";
        In >> temp.name;
        temp.total_wrong_decisions=0;
        cout << "Wrong decisions in last three matches: ";
        for (int j = 0; j < 3; j++)
        {
            In >> temp.wrong_decisions_per_match[j];
            temp.total_wrong_decisions = temp.total_wrong_decisions + temp.wrong_decisions_per_match[j];
        }
        referees.push_back(temp);
    }

    //Sorting Forwards, Goalkeepers and Referees according to their own attributes as given in the question
    sort(forwards.begin(),forwards.end(),compareForwards);
    sort(goalkeepers.begin(),goalkeepers.end(),compareGoalkeepers);
    sort(referees.begin(),referees.end(),compareReferees);
    



    //Printing Forward Details
    File << "==============================\n";
    File << "Forward Rankings : \n";
    File << "Rank   |  Name             | Match 1       | Match 2       | Match 3       | Total Goals \n" << endl;
    for (int i = 0; i < number_of_forwards; i++)
    {
    File << setw(10) << i+1 << setw(10) << forwards[i].name << setw(10) << forwards[i].goals_per_match[0] << setw(10) << forwards[i].goals_per_match[1] << setw(10) << forwards[i].goals_per_match[2] << setw(10) << forwards[i].total_goals << endl;
    }
    

    File << "==============================\n";
    File << "Goalkeeper Rankings : \n";
    File << "Rank   |  Name             | Match 1       | Match 2       | Match 3       | Total Saves \n" << endl;
    for (int i = 0; i < number_of_goalkeepers; i++)
    {
    File << i+1 << " |      " << goalkeepers[i].name << " |     " << goalkeepers[i].saves_per_match[0] << " |   " << goalkeepers[i].saves_per_match[1] << " |       " << goalkeepers[i].saves_per_match[2] << " |       " << goalkeepers[i].total_saves << endl;
    }


    File << "==============================\n";
    File << "Referee Rankings : \n";
    File << "Rank   |  Name             | Match 1       | Match 2       | Match 3       | Total Wrong Decisions \n" << endl;
    for (int i = 0; i < number_of_referees; i++)
    {
    File << i+1 << " |      " << referees[i].name << " |     " << referees[i].wrong_decisions_per_match[0] << " |        " << referees[i].wrong_decisions_per_match[1] << " |       " << referees[i].wrong_decisions_per_match[2] << " |        " << referees[i].total_wrong_decisions << endl;
    }
    


    


}