// LoginDialog.cpp : implementation file
//

#include "stdafx.h"
#include "MFCApplication1.h"
#include "LoginDialog.h"
#include "afxdialogex.h"

static ISXAuthPtr	_pSXAuth(NULL);


// CLoginDialog dialog

IMPLEMENT_DYNAMIC(CLoginDialog, CDialogEx)

CLoginDialog::CLoginDialog(CWnd* pParent /*=NULL*/)
	: CDialogEx(IDD_DIALOG1, pParent)
	, m_username(_T(""))
	, m_password(_T(""))
{
	InitAuthCom();
}

CLoginDialog::~CLoginDialog()
{
}

void CLoginDialog::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Text(pDX, IDC_EDIT_USERNAME, m_username);
	DDX_Text(pDX, IDC_EDIT_PASSWORD, m_password);
}


BEGIN_MESSAGE_MAP(CLoginDialog, CDialogEx)
	ON_BN_CLICKED(IDOK, &CLoginDialog::OnBnClickedOk)
END_MESSAGE_MAP()


// CLoginDialog message handlers


void CLoginDialog::OnBnClickedOk()
{
	UpdateData();
	
	CString realPassword = _pSXAuth->GeneratePwdByName((_bstr_t)m_username);
	if (m_password == realPassword)
	{
		MessageBox(_T("OK"));
		CDialogEx::OnOK();
	}
	else
	{
		MessageBox(_T("User name or password is not correct."));
	}
}

void CLoginDialog::InitAuthCom()
{
	HRESULT hr(CoInitialize(NULL));
	if (SUCCEEDED(hr))
	{
		hr = _pSXAuth.CreateInstance(__uuidof(Authentication));
		if (!SUCCEEDED(hr))
		{
			MessageBox(_T("Failed to CreateInstance for Authentication."));
		}

		//helperInitialized = true;
	}

}
