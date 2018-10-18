
#include<iostream>
#include<math.h>
#include<conio.h>
#include<string>


using namespace std;

struct sanPham {
	string idSanPham;
	string tenSanPham;
	int giaSanPham;
};

typedef struct tagNode
{
	sanPham data;
	struct tagNode*pNext;
}node;
typedef struct
{
	node*pHead;
	node*pTail;
}List;

void initList(List &myList);
node*getNode(sanPham x);
int isEmpty(List myList);
void addNodeHead(sanPham x, List &myList);
void addNodeTail(sanPham x, List &myList);
void inNode(List myList);
void addNodeMiddle(node*p, node*q, List &myList);
void deleteNode(string x, List &myList);
void menu(List &myList);


void main()
{
	List myList;
	initList(myList);
	do
	{
		menu(myList);
		cout << "Nhan ESC de thoat khoi phan mem!... HOAC tiep tuc" << endl;
	} while (_getch() != 27);
	menu(myList);
	
}
void initList(List &myList)
{
	myList.pHead = NULL;
	myList.pTail = NULL;
}
node*getNode(sanPham x)
{
	node*p = new node;

	if (p == NULL)
		return NULL;
	else {
		p->data = x;
		p->pNext = NULL;
	}
	return p;
}
int isEmpty(List myList)
{
	if (myList.pHead == NULL)
		return 0;
	return 1;
}
void addNodeHead(sanPham x, List &myList)
{
	node *p = getNode(x);
	if (!isEmpty(myList))
	{
		myList.pHead = p;
		myList.pTail = p;
	}
	else {
		p->pNext = myList.pHead;
		myList.pHead = p;
	}
}
void addNodeTail(sanPham x, List &myList)
{
	node *p = getNode(x);
	if (!isEmpty(myList))
	{
		myList.pHead = p;
		myList.pTail = p;
	}
	else
	{
		myList.pTail->pNext = p;
		myList.pTail = p;
	}
}

void deleteNode(string x, List &myList) 
{
	node *pDelete = myList.pHead;
	if (pDelete == NULL) 
	{
		cout << "Danh sach rong...!";
	}
	else 
	{
		node *pPre = NULL;
		while (pDelete != NULL)
		{
			if (pDelete->data.idSanPham == x) 
			{
				break;
			}
			pPre = pDelete;
			pDelete = pDelete->pNext;
		}

		if (pDelete == NULL) 
		{
			cout << "Khong ton tai id san pham nay. Xin kiem tra lai!" << endl;
		}
		else 
		{
			if (pDelete == myList.pHead) 
			{
				myList.pHead = myList.pHead->pNext;
				pDelete->pNext = NULL;
				delete pDelete;
				pDelete = NULL;
			}
			else 
				if (pDelete->pNext == NULL) 
				{
					myList.pTail = pPre;
					pPre->pNext = NULL;
					delete pDelete;
					pDelete = NULL;
				}
			else 
			{
				pPre->pNext = pDelete->pNext;
				pDelete->pNext = NULL;
				delete pDelete;
				pDelete = NULL;
			}
		}
	}
}

void inNode(List myList)
{
	node *z;
	z = myList.pHead;
	while (z != NULL)
	{
		cout << z->data.tenSanPham << "\t";
		cout << z->data.giaSanPham;
		cout << endl;
		z = z->pNext;
	}
}




//void addNodeMiddle(node*p, node*q, List &myList)		//Thêm vào sau phần tử q
//{
//	if (q == NULL)
//		addNodeHead(p, myList);
//	else
//	{
//		p->pNext = q->pNext;
//		q->pNext = p;
//	}
//	if (q == myList.pTail)
//		myList.pTail = p;
//}



void menu(List &myList) {
	cout << "===========MENU============" << endl;
	cout << "1. Them san pham vao dau danh sach." << endl;
	cout << "2. Them san pham vao cuoi danh sach." << endl;
	cout << "3. Xoa san pham bang id." << endl;
	cout << "4. Xuat danh sach san pham." << endl;

	int chon;
	cout << "Chon chuc nang: ";
	cin >> chon;

	if (chon == 1) {
		sanPham sp;
		cin.ignore();
		cout << "Nhap id san pham: ";
		getline(cin, sp.idSanPham);
		cout << "Nhap ten san pham: ";
		getline(cin, sp.tenSanPham);
		cout << "Nhap gia san pham: ";
		cin >> sp.giaSanPham;
		addNodeHead(sp, myList);
	}
	else if (chon == 2) {
		sanPham sp;
		cin.ignore();
		cout << "Nhap id san pham: ";
		getline(cin, sp.idSanPham);
		cout << "Nhap ten san pham: ";
		getline(cin, sp.tenSanPham);
		cout << "Nhap gia san pham: ";
		cin >> sp.giaSanPham;
		addNodeTail(sp, myList);
	}
	else if (chon == 3) {
		string id;
		cout << "Nhap id san pham can xoa: ";
		cin >> id;
		deleteNode(id, myList);
	}
	else if (chon == 4) {
		cout << "\nDanh sach san pham" << endl;
		inNode(myList);
	}
	else {
		cout << "Ban cho chung nang khong ton tai!..." << endl;
	}
}




