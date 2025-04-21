#include <stdio.h>

int main(){
    int test = 1;
    int id = 1;
    

    float height[100] = {0};
    float width[100] = {0};
    float breadth[100] = {0};
    float diameter[100] = {0};

    
    int arr[100];
    for (int i = 0; i < 100; i++)
    {
        arr[i]=0; //O for end
    }
    float totalarea = 0;
    int TotalShapes = 0;
    int circles =0;
    int rectangles = 0;
    int cubes = 0;
    
    float totalarearect = 0;
    float totalareacircle = 0;
    float totalareacubes = 0;
    while (test)
    {
        printf("Please select a menu\n");
        printf("1. Add a circle\n");
        printf("2. Add a rectangle\n");
        printf("3. Add a cube\n");
        printf("4. List Items\n");
        printf("5. Get Statistics\n");
        printf("6. Exit\n");
        int a;
        scanf("%d",&a);
        switch (a)
        {
        case 1:
            printf("Cicle diameter :"); 
            scanf("%f" , &diameter[id-1]);
            arr[id-1]=1;
            float temp = diameter[id-1] ;
            //shape[id-1].cir.id = id;
            printf("Succesfully Added\n");
            totalarea+= 3.14*temp*temp;
            TotalShapes++;
            circles++;
            totalareacircle+= 3.14*temp*temp;
            id++;
            printf("\n");

            break;

        case 2:
            printf("Rectangle Height :");
            scanf("%f" ,&height[id-1]);
            printf("Rectangle Width :");
            scanf("%f" ,&width[id-1]);
            printf("Succesfully Added\n");
            arr[id-1]=2;
            totalarea+= height[id-1]*width[id-1];
            totalarearect+=height[id-1]*width[id-1];
            //shape[id-1].rec.id = id;
            TotalShapes++;
            rectangles++;
            id++;
            printf("\n");
            break;

        case 3:
            printf("Cube Height :");
            scanf("%f" ,&height[id-1]);
            printf("Cube Width :");
            scanf("%f" ,&width[id-1]);
            printf("Cube Breadth :");
            scanf("%f" ,&breadth[id-1]);
            printf("Succesfully Added\n");
            arr[id-1]=3;
            totalarea+= height[id-1]*width[id-1]*breadth[id-1];
            totalareacubes+= height[id-1]*width[id-1]*breadth[id-1];
            //shape[id-1].cube.id = id;
            TotalShapes++;
            cubes++;
            id++;
            printf("\n");
        break;

        case 4:
            printf("Here is the items:\n");
                    printf("Id           Name                 Dimensions\n");
                    printf("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = \n");
            for (int i = 0; i < 100; i++)
            {
                if (arr[i] == 1)
                {
                    printf("%d          Cicle                   %.2f\n",(i+1),diameter[i]);
                }else if(arr[i]==2){
                    printf("%d          Rectangle               %.2f X %.2f\n",i+1,height[i],width[i]);
                }
                else if(arr[i]==3){
                    printf("%d          Cube                    %.2f X %.2f X %.2f \n",i+1,height[i],width[i],breadth[i]);
                }else{
                    break;
                }
            }
            printf("\n");
            break;

        case 5:
            printf("Stats \n");
            float percicle = totalareacircle/totalarea * 100;
            float perrect = totalarearect/totalarea * 100;
            float percube = totalareacubes/totalarea * 100;
            printf("Total Shapes : %d \n" ,TotalShapes );
            printf("Total number of rectangles : %d\n",rectangles);
            printf("Total number of circles : %d\n",circles);
            printf("Total number of cubes : %d\n",cubes);
            printf("Total area %.2f\n",totalarea);
            printf("Total area occupied by recatangles %.2f (%.2f %% )\n", totalarearect,perrect);
            printf("Total area occupied by cicles %.2f (%.2f %%)\n", totalareacircle,percicle);
            printf("Total area occupied by cubes %.2f (%.2f %%)\n", totalareacubes,percube);
            
            printf("\n");
            break;
        
        case 6:
            test =0;
            break;
        }
    }

}