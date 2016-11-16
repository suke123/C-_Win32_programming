/*------------------------------------------------------------------------
lir01.cpp	(IphoneImageReflection)	 cat�𓮂���
---------------------------------------------------------------------------*/

#include <windows.h>
#include <tchar.h>

#define	ID_MYTIMER	(32767)
#define	ID_MYCHILD	(100)
#define	CHD_WIDTH	(87)
#define	CHD_HEIGHT	(70)

// �v���g�^�C�v�錾
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam);
LRESULT CALLBACK ChdProc1(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam);
LRESULT CALLBACK ChdProc2(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam);

BOOL InitApp(HINSTANCE, WNDPROC, LPCTSTR);
BOOL InitInstance(HINSTANCE, int, LPCTSTR);

static TCHAR szClassName[] = _T("Animal_Reflect");
static TCHAR szchClassName[] = _T("child");
static TCHAR szTitle[] = _T("Animal Reflect");

int img_start_x = 83;
int img_start_y = 131;
int img_end_x = 482;
int img_end_y = 233;
int min_y = 29;
int center_screen = 283;

int count = 1;      //������w��

int WINAPI WinMain(HINSTANCE hCurInst, HINSTANCE hPrevInst, LPSTR lpsCmdLine, int nCmdShow) {
	MSG msg;

	if (!hPrevInst) {
		if (!InitApp(hCurInst, WndProc, szClassName)) {
			return FALSE;
		}
	}
	if (!InitInstance(hCurInst, nCmdShow, szClassName)) {
		return FALSE;
	}
	while (GetMessage(&msg, NULL, 0, 0)) {
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
	return (int)msg.wParam;
}

BOOL InitApp(HINSTANCE hInst, WNDPROC WndProc, LPCTSTR szClassName) {
	WNDCLASS wc;

	wc.style = CS_HREDRAW | CS_VREDRAW;
	wc.lpfnWndProc = WndProc;
	wc.cbClsExtra = 0;
	wc.cbWndExtra = 0;
	wc.hInstance = hInst;
	wc.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	wc.hCursor = LoadCursor(NULL, IDC_ARROW);
	wc.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);
	wc.lpszMenuName = NULL;
	wc.lpszClassName = szClassName;

	return (RegisterClass(&wc));
}


BOOL InitInstance(HINSTANCE hInst, int nCmdShow, LPCTSTR szClassName) {
	HWND hWnd;

	hWnd = CreateWindow(
		szClassName,
		szTitle,				//�^�C�g���o�[�ɂ��̖��O���\������܂�
		WS_OVERLAPPEDWINDOW,	//�E�B���h�E�̎��
		10,						//�w���W�@�K�X�w�肷��
		10,						//�x���W�@�K�X�w�肷��
		700,					//��	�@�K�X�w�肷��
		400,					//����	�@�K�X�w�肷��
		NULL,					//�e�E�B���h�E�̃n���h���A�e�����Ƃ���NULL
		NULL,					//���j���[�n���h���A�N���X���j���[���g���Ƃ���NULL
		hInst,					//�C���X�^���X�n���h��
		NULL);

	if (!hWnd) {
		return FALSE;
	}

	ShowWindow(hWnd, nCmdShow);
	UpdateWindow(hWnd);

	return TRUE;
}

LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam) {
	RECT		rc;
	static int 	x = img_start_x;
	static int 	y = img_start_y;
	static int 	direction;
	static HWND		hChdWnd;
	HINSTANCE		hInst;
	enum { right, left };
	int height = 102;
	int width = 200;
	bool window_end = false;
	HDC hDC;
	HBRUSH  hBrushBlack;
	HBRUSH  hBrushYellow;
	HBRUSH  hBrushWhite;
	PAINTSTRUCT ps;
	
	int go_x = width / 128 + 1;
	int go_y = height / 64;

	switch (message) {

	case WM_PAINT:

		hDC = BeginPaint(hWnd, &ps);		// GDI�֐��ɂ��`����J�n����

		//***********************
		//**iPhone���������ɂ���
		//***********************
		hBrushBlack = CreateSolidBrush(RGB(0, 0, 0));
		SelectObject(hDC, hBrushBlack);
		RoundRect(hDC, 10, 10, 643, 322, 70, 80);    //iPhone7�̊O�g
		Rectangle(hDC, 85, 321, 110, 325);               //�}�i�[���[�hON/OFF�L�[
		Rectangle(hDC, 135, 321, 185, 325);               //���ʁ{�{�^��
		Rectangle(hDC, 200, 321, 250, 325);               //���ʁ|�{�^��
		Rectangle(hDC, 120, 7, 170, 20);               //�d���{�^��

		hBrushWhite = CreateSolidBrush(RGB(255, 255, 255));
		SelectObject(hDC, hBrushWhite);
		Ellipse(hDC, 25, 162, 33, 170);              //�����㕔�̊�
		Ellipse(hDC, 35, 221, 50, 236);              //�����㕔���̊�
		RoundRect(hDC, 39, 129, 46, 207, 80, 10);
		Ellipse(hDC, 579, 139, 633, 193);            //�{�^���̊O��

		hBrushYellow = CreateSolidBrush(RGB(255, 255, 0));
		SelectObject(hDC, hBrushYellow);
		Rectangle(hDC, 83, 29, 571, 303);            //iPhone7�̉�ʃT�C�Y

		SelectObject(hDC, hBrushBlack);
		Ellipse(hDC, 584, 144, 628, 188);            //�{�^���̓���

		EndPaint(hWnd, &ps);				// GDI�֐��ɂ��`����I������
	
	}

	switch (message) {
	
	case WM_CREATE:
		hInst = ((LPCREATESTRUCT)lParam)->hInstance;
		InitApp(hInst, ChdProc1, szchClassName);
		hChdWnd = CreateWindow(
			szchClassName,		// �E�B���h�E�N���X��
			NULL,				// �^�C�g���o�[�ɕ\�����镶����
			WS_CHILD,			// �E�B���h�E�̎��
			0,					// �E�B���h�E��\������ʒu(X���W�j
			0,					// �E�B���h�E��\������ʒu(Y���W�j
			CHD_WIDTH,			// �E�B���h�E�̕�
			CHD_HEIGHT,			// �E�B���h�E�̍���
			hWnd,				// �e�E�B���h�E�̃E�B���h�E�n���h��
			(HMENU)ID_MYCHILD,	// ���j���[�n���h��
			hInst,				// �C���X�^���X�n���h��
			NULL				// ���̑��̍쐬�f�[�^
			);

		ShowWindow(hChdWnd, SW_SHOW);
		UpdateWindow(hChdWnd);

		SetTimer(hWnd, ID_MYTIMER, 10, NULL);
		break;

	case WM_TIMER:
		GetClientRect(hWnd, &rc);
		MoveWindow(hChdWnd, x, y, CHD_WIDTH, CHD_HEIGHT, TRUE);

		switch (direction) {

			
		//�E�����Ɉړ����鎞�̏���	
		case right:
			if ((x >= img_start_x && y <= img_start_y) && x <= center_screen){
				x += go_x;     
				y -= go_y;				
			}
			if (y >= min_y && x >= center_screen && y <= img_start_y){
				x += go_x;
				y += go_y;
			}
			if (x >= img_end_x){
				direction = left;
				//count += 1;
			}
			break;

			
		//�������Ɉړ����鎞�̏���	
		case left:
			if (x <= img_end_x+1 && x >= center_screen && y <= img_end_y){
				x -= go_x;
				y += go_y;
			}
			if (x <= center_screen && y <= img_end_y && x >= img_start_x){
				x -= go_x;
				y -= go_y;
			}
			if (x <= img_start_x){
				direction = right;
				count += 1;
			}
			break;
		}
		break;

	case WM_DESTROY:
		KillTimer(hWnd, ID_MYTIMER);
		PostQuitMessage(0);
		break;

	default:
		return DefWindowProc(hWnd, message, wParam, lParam);
		break;
	}

	return 0;
}

LRESULT CALLBACK ChdProc1(HWND hChdWnd, UINT message, WPARAM wParam, LPARAM lParam) {
	static HBITMAP	hBitmap1;
	static HBITMAP	hPrevBitmap;
	HINSTANCE		hInst;
	PAINTSTRUCT	ps;
	HDC			hDC;
	HDC			hCompatDC;

	if (count % 2 == 0){
		switch (message) {
		case WM_PAINT:
			DeleteObject(hBitmap1);
			hInst = (HINSTANCE)GetWindowLong(hChdWnd, GWL_HINSTANCE);

			hBitmap1 = (HBITMAP)LoadImage(
				hInst,
				_T("dog2.bmp"),
				IMAGE_BITMAP,
				0,
				0,
				LR_LOADFROMFILE);

			if (hBitmap1 == NULL) {
				MessageBox(
					hChdWnd,
					_T("�r�b�g�}�b�v�̃��[�h�Ɏ��s���܂���"),
					_T("�G���["),
					MB_OK | MB_ICONWARNING
					);
				return 0;
			}

			hDC = BeginPaint(hChdWnd, &ps);
			hCompatDC = CreateCompatibleDC(hDC);
			SelectObject(hCompatDC, hBitmap1);

			BitBlt(hDC, 0, 0, CHD_WIDTH, CHD_HEIGHT, hCompatDC, 0, 0, SRCCOPY);

			DeleteDC(hCompatDC);
			DeleteObject(hBitmap1);
			EndPaint(hChdWnd, &ps);
			break;

		default:
			return(DefWindowProc(hChdWnd, message, wParam, lParam));
		}
	}

	else{
		switch (message) {
		case WM_PAINT:
			DeleteObject(hBitmap1);
			hInst = (HINSTANCE)GetWindowLong(hChdWnd, GWL_HINSTANCE);

			hBitmap1 = (HBITMAP)LoadImage(
				hInst,
				_T("cat5.bmp"),
				IMAGE_BITMAP,
				0,
				0,
				LR_LOADFROMFILE);

			if (hBitmap1 == NULL) {
				MessageBox(
					hChdWnd,
					_T("�r�b�g�}�b�v�̃��[�h�Ɏ��s���܂���"),
					_T("�G���["),
					MB_OK | MB_ICONWARNING
					);
				return 0;
			}

			hDC = BeginPaint(hChdWnd, &ps);
			hCompatDC = CreateCompatibleDC(hDC);
			SelectObject(hCompatDC, hBitmap1);

			BitBlt(hDC, 0, 0, CHD_WIDTH, CHD_HEIGHT, hCompatDC, 0, 0, SRCCOPY);

			DeleteDC(hCompatDC);
			DeleteObject(hBitmap1);
			EndPaint(hChdWnd, &ps);
			break;

		default:
			return(DefWindowProc(hChdWnd, message, wParam, lParam));
		}
	}
	return 0;
} 

/*LRESULT CALLBACK ChdProc2(HWND hChdWnd, UINT message, WPARAM wParam, LPARAM lParam) {
	static HBITMAP	hBitmap2;
	//static HBITMAP	hPrevBitmap;
	HINSTANCE		hInst;
	PAINTSTRUCT	ps;
	HDC			hDC;
	HDC			hCompatDC;

	switch (message) {
	case WM_PAINT:
		hInst = (HINSTANCE)GetWindowLong(hChdWnd, GWL_HINSTANCE);

		hBitmap2 = (HBITMAP)LoadImage(
			hInst,
			_T("cat5.bmp"),
			IMAGE_BITMAP,
			0,
			0,
			LR_LOADFROMFILE);

		if (hBitmap2 == NULL) {
			MessageBox(
				hChdWnd,
				_T("�r�b�g�}�b�v�̃��[�h�Ɏ��s���܂���"),
				_T("�G���["),
				MB_OK | MB_ICONWARNING
				);
			return 0;
		}

		hDC = BeginPaint(hChdWnd, &ps);
		hCompatDC = CreateCompatibleDC(hDC);
		SelectObject(hCompatDC, hBitmap2);
		
		BitBlt(hDC, 0, 0, CHD_WIDTH, CHD_HEIGHT, hCompatDC, 0, 0, SRCCOPY);

		DeleteDC(hCompatDC);
		DeleteObject(hBitmap2);
		EndPaint(hChdWnd, &ps);
		break;

	default:
		return(DefWindowProc(hChdWnd, message, wParam, lParam));
	}
	return 0;
}*/