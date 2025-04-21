#define _Alignof alignof
#include <climits>
#include <cmath>
#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
#include <deque>
#include <set>
#include <bitset>

using namespace std;
typedef long long ll;
#define debug cout << "debug" << endl;
#define yes cout << "YES" << endl;
#define no cout << "NO" << endl;
#define nl cout << '\n';
  
void solve(int testcase) {
    ll n;
    cin >> n;
    vector<ll>arr(n);
    for (int i = 0; i < n; i++){
        cin >> arr[i];
    }

    sort(arr.begin(),arr.end());
    ll m = arr[0];
    vector<ll>temp;
    for (int i = 1; i < n; i++){
        if (arr[i]%m !=0 )
        {
            temp.push_back(arr[i]);
        }
    }

    if (temp.size() == 0)
    {
        yes
        return ;
    }

    sort(temp.begin(),temp.end());
    
    m = temp[0];
    
    for (int i = 1; i < temp.size(); i++)
    {
        if (temp[i] % m  !=0)
        {
            no
            return ;
        }
    }

    yes
}

 

 
int main(){
 //cout << endl;
    int testcase;
    cin >> testcase;
    while(testcase--){
        solve(testcase);
        
    }
    return 0;
}
