/*---------------------------------------------
Iphone7plus.cpp
-----------------------------------------------*/

#define _USE_MATH_DEFINES
#define	ID_MYTIMER	(32767)
#define	ID_MYCHILD	(100)
#define	CHD_WIDTH	(300)
#define	CHD_HEIGHT	(150)
#include <windows.h>
#include <tchar.h>
#include <math.h>

// �v���g�^�C�v�錾
LRESULT CALLBACK WindProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam);
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam);
LRESULT CALLBACK ChdProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam);

BOOL InitApp(HINSTANCE, WNDPROC, LPCTSTR);
BOOL InitInstance(HINSTANCE, int, LPCTSTR);

// ���ϐ�
static TCHAR szWindowClass[] = _T("iPhone7Plus");
static TCHAR szchClassName[] = _T("child");
static TCHAR szTitle[] = _T("Reflect cat");

int count = 1;
HINSTANCE	hInst;

int window_pos_x = 100;
int window_pos_y = 100;

//iPhone���������ɂ���
int window_width = 690;
int window_height = 370;

int WINAPI WinMain(HINSTANCE hInstance,
	HINSTANCE hPrevInstance,
	LPSTR pCmdLine,
	int nCmdShow) {

	WNDCLASSEX wcex;

	// �E�B���h�E�N���X�̏���ݒ�
	wcex.cbSize = sizeof(WNDCLASSEX);				// �\���̃T�C�Y
	wcex.style = CS_HREDRAW | CS_VREDRAW | CS_DBLCLKS;	// �X�^�C��
	wcex.lpfnWndProc = WndProc;							// �E�B���h�E�v���V�[�W��
	wcex.cbClsExtra = 0;									// �g�����P
	wcex.cbWndExtra = 0;									// �g�����Q
	wcex.hInstance = hInstance;							// �C���X�^���X�n���h��
	wcex.hIcon = (HICON)LoadImage(					// �A�C�R��
		NULL,
		MAKEINTRESOURCE(IDI_APPLICATION),
		IMAGE_ICON,
		0,
		0,
		LR_DEFAULTSIZE | LR_SHARED
		);
	wcex.hIconSm = wcex.hIcon;							// �q�A�C�R��
	wcex.hCursor = LoadCursor(NULL, IDC_ARROW);
	wcex.hbrBackground = (HBRUSH)(COLOR_WINDOW + 1);
	wcex.lpszMenuName = NULL;							// ���j���[��
	wcex.lpszClassName = szWindowClass;
	wcex.hIconSm = LoadIcon(wcex.hInstance, MAKEINTRESOURCE(IDI_APPLICATION));

	// �E�B���h�E�N���X��o�^����
	if (!RegisterClassEx(&wcex)) {
		MessageBox(NULL,
			_T("�E�B���h�E�̓o�^�Ɏ��s���܂���"),
			_T("�E�B���h�E�̓o�^�G���["),
			NULL);
		return 1;
	}

	hInst = hInstance; // �C���X�^���X��n���h������ϐ��Ɋi�[

	// �E�B���h�E���쐬����
	HWND hWnd = CreateWindow(
		szWindowClass,					// �E�B���h�E�N���X��
		szTitle,							// �^�C�g���o�[�ɕ\�����镶����
		WS_OVERLAPPEDWINDOW,		// �E�B���h�E�̎��
		window_pos_x,								// �E�B���h�E��\������ʒu(X���W)
		window_pos_y,								// �E�B���h�E��\������ʒu(Y���W)
		window_width,								// �E�B���h�E�̕�
		window_height,								// �E�B���h�E�̍���
		NULL,							// �e�E�B���h�E�̃E�B���h�E�n���h��
		NULL,							// ���j���[�n���h��
		hInst,							// �C���X�^���X�n���h��
		NULL							// ���̑��̍쐬�f�[�^
		);

	if (!hWnd) {
		MessageBox(NULL,
			_T("�E�B���h�E�̍쐬�Ɏ��s���܂���"),
			_T("�E�B���h�E�̍쐬�G���["),
			NULL);
		return 1;
	}

	// �E�B���h�E��\������
	ShowWindow(hWnd, nCmdShow);
	UpdateWindow(hWnd);

	// ���b�Z�[�W����[�v
	MSG msg;
	while (GetMessage(&msg, NULL, 0, 0)) {
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
	return (int)msg.wParam;
}

// �E�B���h�E�v���V�[�W��
LRESULT CALLBACK WindProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam) {
	HDC hDC;
	HBRUSH  hBrushBlack;
	HBRUSH  hBrushYellow;
	HBRUSH  hBrushWhite;
	PAINTSTRUCT ps;
	static LOGFONT logfont;  //�t�H���g���̍\����

	switch (message) {
	case WM_CREATE:
		ZeroMemory(&logfont, sizeof(logfont));	// �t�H���g���\���̂��O�ŏ�����
		logfont.lfCharSet = DEFAULT_CHARSET;	// �V�X�e���̃f�t�H���g�����Z�b�g���g��
		wsprintf(logfont.lfFaceName, _T("Times New Roman"));
		break;

	case WM_PAINT:{

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
					  Rectangle(hDC, 83, 29, 569, 303);            //iPhone7�̉�ʃT�C�Y

					  SelectObject(hDC, hBrushBlack);
					  Ellipse(hDC, 584, 144, 628, 188);            //�{�^���̓���

					  EndPaint(hWnd, &ps);				// GDI�֐��ɂ��`����I������
	}break;

	case WM_DESTROY:
		PostQuitMessage(0);
		break;

	default:
		return DefWindowProc(hWnd, message, wParam, lParam);
		break;
	}

	return 0;
}

LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam) {
	RECT		rc;
	static int 	x;
	static int 	y;
	static int 	direction;
	static HWND		hChdWnd;
	enum { right, left };
	int height = 450;
	int width = 900;
	bool window_end = false;
	//static int pos_x;   //���˂��鎞�ɂ���x���W
	//static int pos_y;   //���˂��鎞�ɂ���y���W

	int go_x1 = window_width / 32;
	int go_y1 = window_height / 64;
	int go_x2 = window_width / 128 + 1;
	int go_y2 = window_height / 64;

	switch (message) {
	case WM_CREATE:
		/*hInst = ((LPCREATESTRUCT)lParam)->hInstance;
		InitApp(hInst, ChdProc, szchClassName);

		/*hChdWnd = CreateWindow(
			szchClassName,			// �E�B���h�E�N���X��
			NULL,					// �^�C�g���o�[�ɕ\�����镶����
			WS_CHILD,				// �E�B���h�E�̎��
			0,						// �E�B���h�E��\������ʒu(X���W�j
			0,						// �E�B���h�E��\������ʒu(Y���W�j
			CHD_WIDTH,			// �E�B���h�E�̕�
			CHD_HEIGHT,			// �E�B���h�E�̍���
			hWnd,					// �e�E�B���h�E�̃E�B���h�E�n���h��
			(HMENU)ID_MYCHILD,	// ���j���[�n���h��
			hInst,					// �C���X�^���X�n���h��
			NULL					// ���̑��̍쐬�f�[�^
			);*/

		ShowWindow(hChdWnd, SW_SHOW);
		UpdateWindow(hChdWnd);

		SetTimer(hWnd, ID_MYTIMER, 10, NULL);
		break;

	case WM_TIMER:
		GetClientRect(hWnd, &rc);
		MoveWindow(hChdWnd, x, y, CHD_WIDTH, CHD_HEIGHT, TRUE);

		switch (direction) {

			/**
			**�E�����Ɉړ����鎞�̏���
			**/
		case right:
			if (count == 1){
				x += go_x1;     //
				y += go_y1;
			}
			if (count == 2){
				x += go_x2;
				y -= go_y2;
			}
			if (y <= 0){
				x += go_x2;
				y += go_y2;
			}
			//if (x >= rc.right - CHD_WIDTH || y >= height) {
			if (x >= rc.right - CHD_WIDTH){
				count = 2;
				direction = left;
			}

			break;

			/**
			**�������Ɉړ����鎞�̏���
			**/
		case left:
			if (x > CHD_WIDTH / 2){
				x -= go_x2;
				y += go_y2;
			}
			if (y >= rc.bottom - CHD_HEIGHT){
				x += go_x2;
				y -= go_y2;
			}
			if (x < 0 || y < 0){
				direction = right;
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

LRESULT CALLBACK ChdProc(HWND hChdWnd, UINT message, WPARAM wParam, LPARAM lParam) {
	static HBITMAP	hBitmap;
	static HBITMAP	hPrevBitmap;
	PAINTSTRUCT	ps;
	HDC			hDC;
	HDC			hCompatDC;

	switch (message) {
	case WM_PAINT:
		hInst = (HINSTANCE)GetWindowLong(hChdWnd, GWL_HINSTANCE);

		hBitmap = (HBITMAP)LoadImage(
			hInst,
			_T("cat.bmp"),
			IMAGE_BITMAP,
			0,
			0,
			LR_LOADFROMFILE);

		if (hBitmap == NULL) {
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
		SelectObject(hCompatDC, hBitmap);

		BitBlt(hDC, 0, 0, CHD_WIDTH, CHD_HEIGHT, hCompatDC, 0, 0, SRCCOPY);

		DeleteDC(hCompatDC);
		DeleteObject(hBitmap);
		EndPaint(hChdWnd, &ps);
		break;

	default:
		return(DefWindowProc(hChdWnd, message, wParam, lParam));
	}
	return 0;
}