
#include<iostream>
#include<math.h>
#include<conio.h>

typedef struct tagNode
{
	int data;
	struct tagNode*pNext;
}node;
typedef struct 
{
	node*pHead;
	node*pTail;
}List;
using namespace std;

void initList(List &myList);
node*getNode(int x);
int isEmpty(List myList);
void addNodeHead(node*p, List &myList);
void addNodeTail(node*m, List &myList);
void inNode(List myList);







void main ()
{
	List myList;
	initList(myList);
	node*y = getNode(5);
	addNodeHead(y, myList);
	node*m = getNode(6);
	addNodeTail(m, myList);
	inNode(myList);

}
void initList(List &myList)
{
	myList.pHead = NULL;
	myList.pTail = NULL;
}
node*getNode(int x)
{
	node*p = new node;
	if (p == NULL)
		return NULL;
	else
		p->data = x;
	return p;
}
int isEmpty( List myList)
{
	if (myList.pHead == NULL)
		return 0;
	return 1;
}
void addNodeHead(node*p, List &myList )
{
	if (!isEmpty(myList))
	{
		myList.pHead = p;
		myList.pTail = p;
	} else {
		p->pNext = myList.pHead;
		myList.pHead = p;
	}
}
void addNodeTail(node*m, List &myList)
{
	if (!isEmpty(myList))
	{
		myList.pHead = m;
		myList.pTail = m;
	}
	else 
	{
		myList.pTail->pNext = m;
		myList.pTail = m;
	}
}
void inNode(List myList)
{
	node *z;
	for(z=myList.pHead;z->pNext !=NULL;)
	{
		cout.width(4);
		cout << z->data;
		z = z->pNext;
	}
}


